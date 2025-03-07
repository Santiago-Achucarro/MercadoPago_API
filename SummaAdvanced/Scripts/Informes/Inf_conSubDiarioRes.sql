

 -- Inf_conSubDiarioRes '20210930','20210930',1, 'es'
-- Inf_conSubDiarioRes '20180101','20180831',1, 'en'
DROP Procedure Inf_conSubDiarioRes
GO

Create Procedure Inf_conSubDiarioRes
 ( @FechaDesde DateTime, @FechaHasta DateTime, @Empresa Int,@Cultura VarChar(5)=null)
as

Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))


SELECT conPeriodos.Fecha_Hasta Fecha, disFormularios.Formulario_Id, 
	conMovCont.Tipomov,
	ISNULL(conAsientosCon.LeyendaLibroDiario,disFormularios.Descripcion) as Formulario, genAsiSegmentos.Segmento_Id,
	conCuentas.Cuenta_Id, 
	CASE WHEN @EnOtro=1 THEN conCuentas.Description ELSE conCuentas.Descripcion END Descripcion,  
	ISNULL(conCentro1.Centro1_Id,' ') as Centro1_Id,
	ISNULL(conCentro2.Centro2_Id,' ') as Centro2_Id,
	SUM(CASE WHEN conMovCont.Tipomov = 1 then  conMovCont.Importe else 0 end) As Debe,
	SUM(CASE WHEN conMovCont.Tipomov = 2 then  conMovCont.Importe else 0 end) As Haber 
	
From conCuentas 
INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN conPeriodos ON conPeriodos.Empresa_Id = @Empresa and
conAsientos.Fecha BETWEEN conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
WHERE
conAsientos.Anulado = 0 and 
conAsientos.Posteado =1 and 
conAsientos.Empresa_Id = @Empresa and 
conAsientos.Fecha Between @FechaDesde and @FechaHasta AND
(conAsientos.Fecha >= genEmpresas.FechaInicioSumma or conAsientosCon.conAsientos IS Not NULL)

GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion ,  conPeriodos.Fecha_Hasta ,genAsiSegmentos.Segmento_Id,
	ISNULL(conAsientosCon.LeyendaLibroDiario,disFormularios.Descripcion), conCentro1.Centro1_Id, conCentro2.Centro2_Id, disFormularios.Formulario_Id, 
		concuentas.Description, conMovCont.Tipomov
ORDER BY 1,2,3,5,6,7
GO