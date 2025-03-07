-- Inf_SituPatri '20170831','20160831', 1


DROP Procedure Inf_SituPatri
GO

Create Procedure Inf_SituPatri
 ( @FechaHasta DateTime,  @FechaHasta1 DateTime, @Empresa Int)
AS

DECLARE @FechaDesde DateTime
DECLARE @FechaDesde1 DateTime

SET @FechaDesde = (select min(Fecha_Desde) from conPeriodos WHERE
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				@FechaHasta between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta))


SET @FechaDesde1 = (select min(Fecha_Desde) from conPeriodos WHERE
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				@FechaHasta1 between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta))

SELECT vcuentasRango.Cuenta_Id, vcuentasRango.Descripcion, vcuentasRango.Nivel ,
	ISNULL(SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3) ),0) as Saldo , 
	ISNULL((SELECT SUM(conMovCont1.Importe * (-2*conMovCont1.Tipomov+3)) 
		FROM conMovCont conMovCont1 INNER JOIN conAsientos conAsientos1 ON
			conMovCont1.conAsientos = conAsientos1.conAsientos 
			INNER JOIN conCuentas conCuentas1 ON
			conCuentas1.conCuentas = conMovCont1.Cuenta_id and
			conCuentas1.Cuenta_id >= vcuentasRango.Cuenta_Id and
			conCuentas1.Cuenta_id < vcuentasRango.CuentaHasta
			Where
			conAsientos1.Fecha between @FechaDesde1 and  @FechaHasta1 ),0) as Saldo1 
FROM vcuentasRango  INNER JOIN conRubros ON
	conRubros.Rubro_id = vcuentasRango.Rubro_Id

LEFT OUTER JOIN 
	(conMovCont inner join conCuentas ON 
	conCuentas.conCuentas =conMovCont.Cuenta_Id 
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = conMovCont.conAsientos AND 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	conAsientos.Empresa_Id = @Empresa) ON
	conCuentas.Cuenta_id >= vcuentasRango.Cuenta_Id and
	conCuentas.Cuenta_id < vcuentasRango.CuentaHasta
Where
	conAsientos.Anulado = 0 and 
	ISNULL(vCuentasRango.Empresa_Id,@Empresa) = @Empresa AND 
		vCuentasRango.Nivel <= 3
GROUP BY vcuentasRango.Cuenta_Id, vcuentasRango.Descripcion, vcuentasRango.Nivel , vcuentasRango.Imputable,
	vcuentasRango.CuentaHasta
ORDER BY 1

GO
