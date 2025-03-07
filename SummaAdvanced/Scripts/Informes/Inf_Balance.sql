--  EXEC Inf_Balance  '20220101','20221231',' ','ZZZ',1,1,1,' ', 'ZZZ', ' ', 'zzz', 1,1,'es',1
--EXEC Inf_Balance  '20200701','20200731','12-171-001-000','12-171-001-000',1,0,1,' ', 'ZZZ', ' ', 'zzz', 1,0,'es',0
--  EXEC Inf_Balance  '20190501','20190531',' ','ZZZZZ',1,1,1, '', 'ZZZ', '', 'zzz', 1,0,'en',1
--  EXEC Inf_Balance  '20190501','20190531',' ','ZZZZZ',1,0,1, '', 'ZZZ', '', 'zzz', 1,0,'es'
-- EXEC Inf_Balance  '20190501','20190531',' ','ZZZZZ',1,0,1, '', 'ZZZ', '', 'zzz', 1,0,'es'
-- EXEC Inf_Balance  '20190501','20190531',' ','ZZZZZ',1,0,1, '', 'ZZZ', '', 'zzz', 1,0,'es'

DROP Procedure Inf_Balance 
GO


CREATE Procedure [dbo].[Inf_Balance] 
 ( @FechaDesde DateTime, @FechaHasta DateTime, 
	@CuentaDesde VarChar(25),@CuentaHasta VarChar(25), 
	@ConAcumuladoras Bit, @ConSadoCero Bit, 
	@Empresa Int,
	@Centro1Desde varChar(8), @Centro1Hasta varChar(8), 
	@Centro2Desde varChar(8), @Centro2Hasta varChar(8),
	@ConSaldoInicial Sino, @ConCierre SiNo,
	@Cultura VarChar(5)=null, 
	@PorNaturaleza bit
)
as

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

Set @FechaDesdeE = isNull((Select Max(Fecha) From conAsientos Where Fecha <= @FechaDesde And Especial = 'APE' and anulado = 0), '20000101')

declare @Centro1Blanco VarChar(1)
declare @Centro2Blanco VarChar(1)

SET @Centro1Blanco = (select conCentro1 from conCentro1 where Centro1_Id = ' ')
SET @Centro2Blanco = (select conCentro2 from conCentro2 where Centro2_Id = ' ')

select * into #Tb1 from vconMovcontRes where Fecha between 
	case when @ConSaldoInicial = 1 then @FechaDesdeE else @FechaDesde end and @FechaHasta and 
	Empresa_id = @Empresa and 
		Centro1_Id between @Centro1Desde and @Centro1Hasta and 
		Centro2_Id between @Centro2Desde and @Centro2Hasta and 
		Cuenta_Id between @CuentaDesde and @CuentaHasta

if @ConAcumuladoras=1 
begin

SELECT conCuentas.Cuenta_Id, 
	CASE WHEN @EnOtro=1 then conCuentas.Description ELSE conCuentas.Descripcion END Descripcion, 
		conCuentas.TipoSAT_Id,
	conCuentas.Nivel , conCuentas.Imputable,
	isnull(SUM(case when (tb1.Fecha < @FechaDesde Or tb1.Especial = 'APE') And @ConSaldoInicial = 1 Then 
		tb1.Monto else 0 end),0) 
		/* * case when @PorNaturaleza=1 and conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END */ as Saldoinicial,
	isnull(SUM(case when tb1.Especial <> 'APE' AND  tb1.Fecha >= @FechaDesde And
		tb1.Fecha >= genEmpresas.FechaInicioSumma then  tb1.Debe else 0 end),0) as Debe,
	isnull(SUM(case when tb1.Especial <> 'APE' AND  tb1.Fecha >= @FechaDesde And
		tb1.Fecha >= genEmpresas.FechaInicioSumma then  tb1.Haber else 0 end),0) as Haber,
	Case When @ConSaldoInicial = 1 Then ISNULL(SUM(Case When tb1.Fecha >= genEmpresas.FechaInicioSumma then tb1.Monto else 0 end),0) 
		Else SUM(case when tb1.Especial <> 'APE' AND  tb1.Fecha >= @FechaDesde And
		tb1.Fecha >= genEmpresas.FechaInicioSumma then tb1.Monto else 0 end) End as SaldoiFinal ,
		conCuentas.Naturaleza
	into #Temp1 
FROM conCuentas 
	LEFT OUTER JOIN #Tb1 tb1 ON tb1.conCuentas = conCuentas.conCuentas
	INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa 
Where
	(@ConCierre=1 OR tb1.Especial not in ('CIR','CCP'))  and
	conCuentas.Imputable = 1 AND 
	ISNULL(conCuentas.Empresa_Id,@Empresa) = @Empresa AND 
	conCuentas.Cuenta_id Between @CuentaDesde and @CuentaHasta and 
	(@ConSadoCero= 1 or isnull(tb1.Debe,0) != 0 or isnull(tb1.Haber,0) != 0)
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel , conCuentas.Imputable, 
	concuentas.Description, conCuentas.TipoSAT_Id, conCuentas.Naturaleza
UNION ALL
SELECT conCuentas.Cuenta_Id, 
	CASE WHEN @EnOtro=1 then conCuentas.Description ELSE conCuentas.Descripcion END Descripcion, 
	conCuentas.TipoSAT_Id,
	conCuentas.Nivel , conCuentas.Imputable,
	0 as Saldoinicial,
	0 as Debe,
	0 as Haber,
	0 as SaldoiFinal,conCuentas.Naturaleza
from conCuentas where
	Imputable = 0 and 
	ISNULL(conCuentas.Empresa_Id, @Empresa ) = @Empresa and 
	conCuentas.Cuenta_id Between @CuentaDesde and @CuentaHasta 
ORDER BY 1
OPTION	(RECOMPILE)

-- select * from #Temp1
 

SELECT vcuentasRango.Cuenta_Id, 
	CASE WHEN @EnOtro=1 then conCuentas.Description ELSE vcuentasRango.Descripcion END Descripcion, 
	vcuentasRango.TipoSAT_Id,
	vcuentasRango.Nivel , vcuentasRango.Imputable,
	SUM(SaldoInicial)*case when @PorNaturaleza=1 and conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END as Saldoinicial,
	SUM(Debe) as Debe,
	SUM(Haber) as Haber,
	sum(SaldoiFinal)*case when @PorNaturaleza=1 and conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END as SaldoiFinal, 
	conCuentas.Naturaleza
FROM vcuentasRango 
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa 
Left JOIN #Temp1 as Movimientos on 
		Movimientos.Cuenta_id >= vcuentasRango.Cuenta_Id and
		Movimientos.Cuenta_id < vcuentasRango.CuentaHasta
Inner join concuentas ON concuentas.Cuenta_Id = vcuentasRango.cuenta_id
where
vcuentasRango.cuenta_id between @CuentaDesde and @CuentaHasta
GROUP BY vcuentasRango.Cuenta_Id, vcuentasRango.Descripcion, vcuentasRango.Nivel , vcuentasRango.Imputable, 
	concuentas.Description, vcuentasRango.TipoSAT_Id, conCuentas.Naturaleza
Having @ConSadoCero = 1 Or sum(SaldoiFinal) <> 0 Or SUM(Haber) <> 0 Or SUM(Debe) <> 0 Or SUM(SaldoInicial) <> 0 
ORDER BY 1
OPTION	(RECOMPILE)
end

ELSE


begin
	-- Sin Acumuladoras
SELECT conCuentas.Cuenta_Id, 
	CASE WHEN @EnOtro=1 then conCuentas.Description ELSE conCuentas.Descripcion END Descripcion, 
	conCuentas.TipoSAT_Id,
	 conCuentas.Nivel , conCuentas.Imputable,
	SUM(case when (tb1.Fecha < @FechaDesde Or tb1.Especial = 'APE') And @ConSaldoInicial = 1 Then 
		tb1.Monto else 0 end) *
		case when @PorNaturaleza=1 and conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END as Saldoinicial,
	SUM(case when tb1.Especial <> 'APE' AND tb1.Fecha >= @FechaDesde And 
		tb1.Fecha >= genEmpresas.FechaInicioSumma then TB1.Debe else 0 end) as Debe,
	SUM(case when tb1.Especial <> 'APE' AND  tb1.Fecha >= @FechaDesde And
		tb1.Fecha >= genEmpresas.FechaInicioSumma then tb1.Haber else 0 end) as Haber,
	Case When @ConSaldoInicial = 1 Then ISNULL(SUM(Case When tb1.Fecha >= genEmpresas.FechaInicioSumma then tb1.Monto else 0 end),0) 
		Else SUM(case when tb1.Especial <> 'APE' AND  tb1.Fecha >= @FechaDesde And
		tb1.Fecha >= genEmpresas.FechaInicioSumma then tb1.Monto else 0 end) End *
		case when @PorNaturaleza=1 and conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END as SaldoiFinal, 
		conCuentas.Naturaleza
FROM conCuentas 
Left join #Tb1 tb1 ON tb1.conCuentas = conCuentas.conCuentas
-- And (@ConCierre=1 OR tb1.Especial not in ('CIR','CCP'))
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa 
Where
	(@ConCierre=1 OR isnull(tb1.Especial,'') not in ('CIR','CCP')) and 
	conCuentas.Imputable = 1 AND ISNULL(conCuentas.Empresa_Id,@Empresa) = @Empresa AND 
	conCuentas.Cuenta_id Between @CuentaDesde and @CuentaHasta 
	AND (@ConSadoCero = 1 Or isnull(tb1.Debe,0) != 0 Or isnull(tb1.Haber,0) != 0)
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel, conCuentas.Imputable, 
	concuentas.Description, conCuentas.TipoSAT_Id, conCuentas.Naturaleza
ORDER BY 1
OPTION	(RECOMPILE)
end

drop table #Tb1

GO


