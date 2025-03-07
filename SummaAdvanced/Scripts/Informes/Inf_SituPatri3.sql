-- Inf_SituPatri3 '20181031','20181130', 1,'3310-101', 'es'
-- Inf_SituPatri3 '20181031','20181130', 1,'3310-101', 'en'


DROP Procedure Inf_SituPatri3
GO

Create Procedure Inf_SituPatri3
 ( 
   @FechaHasta DateTime,  
   @FechaHasta1 DateTime, 
   @Empresa Int, 
   @CtaResEjer VarChar(25),
   @Cultura VarChar(5)=null,
   @PorNaturaleza Bit =0)
as

Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))

DECLARE @FechaDesde DateTime
DECLARE @FechaDesde1 DateTime


SET @FechaDesde = (select min(Fecha_Desde) from conPeriodos WHERE
			conPeriodos.Empresa_Id = @Empresa and
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				@FechaHasta between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta AND
				conPeriodos1.Empresa_Id = @Empresa))

SET @FechaDesde1 = (select min(Fecha_Desde) from conPeriodos WHERE
			conPeriodos.Empresa_Id = @Empresa and
			conPeriodos.Ejercicio = (select ejercicio from conPeriodos conPeriodos1 
			where
				@FechaHasta1 between conPeriodos1.Fecha_Desde and conPeriodos1.Fecha_Hasta and 
				conPeriodos1.Empresa_Id = @Empresa))

DECLARE @FechaDesdeMin DAteTime 
DECLARE @FechaHastaMax DAteTime 

set @FechaDesdeMin = @FechaDesde
IF @FechaDesde1 < @FechaDesde
	set @FechaDesdeMin = @FechaDesde1
set @FechaHastaMax = @FechaHasta
IF @FechaHasta1 > @FechaHasta
	set @FechaHastaMax = @FechaHasta1

SELECT *  into #tsp1 FROM vconMovContRes WHERE Fecha between @FechaDesdeMin and @FechaHastaMax AND 
	Empresa_Id = @Empresa


SELECT vcuentasRango.Cuenta_Id, 
	case when @EnOtro=1 then concuentas.Description else  vcuentasRango.Descripcion end Descripcion, 
		vcuentasRango.Nivel,
 (select MAX(Cuenta_Id)from conCuentas as C1 where C1.Cuenta_Id<=vcuentasRango.Cuenta_Id and C1.Nivel<=vcuentasRango.Nivel and c1.Nivel<3) as Grupo 
		--SUBSTRING(vcuentasRango.Cuenta_Id,0,3) as Grupo 
		, conRubros.Rubro_Id,
		ISNULL((SELECT SUM(tsp1.Monto)
		FROM #tsp1 tsp1
		WHERE
			(( @CtaResEjer  between vcuentasRango.Cuenta_Id and vcuentasRango.CuentaHasta and	tsp1.Cuenta_Id >='4') or
			(tsp1.Cuenta_id >= vcuentasRango.Cuenta_Id and tsp1.Cuenta_id < vcuentasRango.CuentaHasta )) and
			tsp1.Especial NOT IN('CIR','CCP')  and 
			tsp1.Fecha between @FechaDesde and  @FechaHasta ),0) as Saldo , 
	ISNULL((SELECT SUM(tsp1.Monto) 
		FROM #tsp1 tsp1 
			WHERE
			(( @CtaResEjer  between vcuentasRango.Cuenta_Id and vcuentasRango.CuentaHasta and	tsp1.Cuenta_Id >='4') or
			(tsp1.Cuenta_id >= vcuentasRango.Cuenta_Id and tsp1.Cuenta_id < vcuentasRango.CuentaHasta )) and
			tsp1.Especial NOT IN('CIR','CCP')  and 
			tsp1.Fecha between @FechaDesde1 and  @FechaHasta1 ),0) as Saldo1 , 
			vcuentasRango.Naturaleza
FROM vcuentasRango  INNER JOIN conRubros ON
	conRubros.Rubro_id = vcuentasRango.Rubro_Id
	inner join concuentas on
	concuentas.Cuenta_id = vcuentasRango.Cuenta_Id

	
Where
	ISNULL(vCuentasRango.Empresa_Id,@Empresa) = @Empresa AND 
		vCuentasRango.Nivel <= 3 and 
		conRubros.Tipo IN ('ACT','PAS','CAP') and (
ISNULL((SELECT SUM(tsp1.Monto)
		FROM #tsp1 tsp1
		WHERE
			(( @CtaResEjer  between vcuentasRango.Cuenta_Id and vcuentasRango.CuentaHasta and	tsp1.Cuenta_Id >='4') or
			(tsp1.Cuenta_id >= vcuentasRango.Cuenta_Id and tsp1.Cuenta_id < vcuentasRango.CuentaHasta )) and
			tsp1.Especial NOT IN('CIR','CCP')  and 
			tsp1.Fecha between @FechaDesde and  @FechaHasta ),0) <>0 or   
	ISNULL((SELECT SUM(tsp1.Monto) 
		FROM #tsp1 tsp1 
			WHERE
			(( @CtaResEjer  between vcuentasRango.Cuenta_Id and vcuentasRango.CuentaHasta and	tsp1.Cuenta_Id >='4') or
			(tsp1.Cuenta_id >= vcuentasRango.Cuenta_Id and tsp1.Cuenta_id < vcuentasRango.CuentaHasta )) and
			tsp1.Especial NOT IN('CIR','CCP')  and 
			tsp1.Fecha between @FechaDesde1 and  @FechaHasta1 ),0) <>0 )
GROUP BY vcuentasRango.Cuenta_Id, vcuentasRango.Descripcion, vcuentasRango.Nivel , vcuentasRango.Imputable,
	vcuentasRango.CuentaHasta, conRubros.Rubro_Id, concuentas.Description, vcuentasRango.Naturaleza
ORDER BY 1
drop table #tsp1

GO


