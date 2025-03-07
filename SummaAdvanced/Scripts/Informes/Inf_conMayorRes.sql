-- Inf_conMayorRes '20180201','20180228','1140-101','1140-101',' ','ZZZZ',' ','ZZZZ',1,1, 'es'
--  Inf_conMayorRes '20180201','20180228','1140-101','1140-101',' ','ZZZZ',' ','ZZZZ',1,1, 'en'
DROP Procedure Inf_conMayorRes
GO

Create Procedure Inf_conMayorRes
 ( @FechaDesde DateTime, @FechaHasta DateTime, 
	@CuentaDesde VarChar(25),@CuentaHasta VarChar(25), 
	@Centro1Desde VarChar(8), @Centro1Hasta VarChar(8),  
	@Centro2Desde VarChar(8), @Centro2Hasta VarChar(8),  
	@Empresa Int, @ConSaldo Sino, @Cultura VarChar(5)=null)
AS

Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))
DECLARE @FechaDesdeE DateTime

/* FM 11/05/2020 Que vaya hasta el primer asiento de apertura cualquiera sea el ejercicio

SET @FechaDesdeE = (select min(Fecha_Desde) from conPeriodos WHERE
			conPeriodos.Empresa_Id = @Empresa AND 
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				conPeriodos1.Empresa_Id = @Empresa AND 
				@FechaHasta between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta))
*/
Set @FechaDesdeE = isNull((Select Max(Fecha) From conAsientos Where Fecha <= @FechaDesde And Especial = 'APE'), '20000101')

SELECT conCuentas.Cuenta_Id, 
case when @EnOtro=1 then concuentas.Description else conCuentas.Descripcion end Descripcion , 
	DATEADD(dd, -1,@FechaDesde) as Fecha, 
	case when @EnOtro=1 then 'INITIAL BALANCE' else 'SALDO INICIAL' end  AS Formulario, ' ' as Formulario_Id,
	' ' Centro1_Id, ' ' Centro2_Id, 
	SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3)) as SaldoInicial, 
	0 As Debe,
	0 As Haber
From conCuentas
INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = ISNULL(conMovCont.Centro1_Id,' ')
LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = ISNULL(conMovCont.Centro2_Id,' ')
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa 
LEFT JOIN conAsientosCon ON conAsientos.conAsientos = conAsientosCon.conAsientos
WHERE
@ConSaldo = 1 And
(conAsientos.Fecha >= genEmpresas.FechaInicioSumma  or conAsientosCon.conAsientos IS NOT NULL) and
conAsientos.Anulado = 0 and conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa and 
(conAsientos.Fecha < @FechaDesde or conAsientos.Especial = 'APE') and 
(conAsientos.Fecha between @FechaDesdeE AND @FechaDesde) and 
conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
ISNULL(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
ISNULL(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, concuentas.Description
UNION ALL

SELECT conCuentas.Cuenta_Id, 
	case when @EnOtro=1 then concuentas.Description else conCuentas.Descripcion end Descripcion , 
	conPeriodos.Fecha_Hasta Fecha,
	disFormularios.Descripcion as Formulario, disFormularios.Formulario_Id,
	ISNULL(conCentro1.Centro1_Id,' ') as Centro1_Id,
	ISNULL(conCentro2.Centro2_Id,' ') as Centro2_Id,
	0 as SaldoInicial, 
	SUM(CASE WHEN conMovCont.Tipomov = 1 then  conMovCont.Importe else 0 end) As Debe,
	SUM(CASE WHEN conMovCont.Tipomov = 2 then  conMovCont.Importe else 0 end) As Haber
From conCuentas
INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN conPeriodos ON conPeriodos.Empresa_Id = conPeriodos.Empresa_Id and
	conAsientos.Fecha BETWEEN conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta and 
	conPeriodos.Empresa_Id =@Empresa
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa 
LEFT JOIN conAsientosCon ON conAsientos.conAsientos = conAsientosCon.conAsientos
WHERE
conasientos.Especial NOT IN ( 'APE','CIR','CCP') AND 
(conAsientos.Fecha >= genEmpresas.FechaInicioSumma  or conAsientosCon.conAsientos IS NOT NULL) and
conAsientos.Anulado = 0 and conAsientos.Posteado = 1 AND 
conAsientos.Empresa_Id = @Empresa and 
conAsientos.Fecha Between @FechaDesde and @FechaHasta and 
conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and 
ISNULL(conCentro1.Centro1_Id,' ') between @Centro1Desde and @Centro1Hasta and
ISNULL(conCentro2.Centro2_Id,' ') between @Centro2Desde and @Centro2Hasta 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion ,  conPeriodos.Fecha_Hasta ,
	disFormularios.Descripcion, conCentro1.Centro1_Id, conCentro2.Centro2_Id, disFormularios.Formulario_Id, 
		conCuentas.Description
ORDER BY 1,3,5,6,7

GO