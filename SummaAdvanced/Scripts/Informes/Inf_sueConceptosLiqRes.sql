-- Inf_sueConceptosLiqRes 'SLIQ',2022,4,2,35,' ',' ',' ',' ',0,9999,' ','ZZZ',1,' ','zz',' ','zzz',3
-- Inf_sueConceptosLiqRes 'SLIQ',2022,4,0,0,' ',' ',' ',' ',0,9999,' ','ZZZ',2,' ','zz',' ','zzz',1
-- Inf_sueConceptosLiqRes 'SLIQ',2022,4,0,0,' ',' ',' ',' ',0,9999,' ','ZZZ',3,' ','zz',' ','zzz',1
-- Inf_sueConceptosLiqRes 'SLIQ',2022,4,2,35,' ',' ',' ',' ',0,9999,' ','ZZZ',4,' ','zz',' ','zzz',1

DROP PROCEDURE Inf_sueConceptosLiqRes
GO
CREATE PROCEDURE Inf_sueConceptosLiqRes
(
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(25),
	@Segmento2C VarChar(25),
	@Segmento3C VarChar(25),
	@Segmento4C VarChar(25),
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@AgrupadoPor Char(1),
	@Centro1Desde VarChar(8),
	@Centro1Hasta VarChar(8),
	@Centro2Desde VarChar(8),
	@Centro2Hasta VarChar(8),
	@Empresa_Id Int
)

as

-- @AgrupadoPor 1 = Niniguno - 2 = Sucursal - 3 = Centro de Costos - 4 Centro2

declare @Sueliquidacion bigint
declare @SegmentoInt int

set @Sueliquidacion = (select sueLiquidacion from 
	sueLiquidacion, genAsiSegmentos, genSegmentos
	where
	sueLiquidacion.sueLiquidacion =genAsiSegmentos.Asiento_Id and
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id and 
	genAsiSegmentos.Segmento1C = @Segmento1C AND 
	genAsiSegmentos.Segmento1C = @Segmento2C AND 
	genAsiSegmentos.Segmento1C = @Segmento3C AND 
	genAsiSegmentos.Segmento1C= @Segmento3C AND 
	genAsiSegmentos.Segmento1N= @Segmento1N AND 
	genAsiSegmentos.Segmento2N= @Segmento2N AND 
	genAsiSegmentos.Segmento3N= @Segmento3N AND 
	genAsiSegmentos.Segmento4N= @Segmento4N AND 
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_Id)

set @SegmentoInt =(select genSegmentos.genSegmentos from 
	genSegmentos
	where
	genSegmentos.Segmento_Id = @Segmento_Id)
		

if @AgrupadoPor = '2'

SELECT Nomina, MAX(DescripcionN) AS DescripcionN, Sucursal, DescripcionSuc,
	Concepto_Id, DescripcionConc, SUM(CANTIDAD) Cantidad,
	SUM(Percepciones) Percepciones, SUM(Deducciones) Deducciones, 
	SUM(Aportes) Aportes, MAX(Empleados) Empleados
FROM(
	SELECT 	case when  @Segmento2N=0 then ''  else dbo.Segmento(@SegmentoInt,@Segmento1C,
		@Segmento2C, @Segmento3C, @Segmento4C,
		@Segmento1N,@Segmento2N, @Segmento3N,
		@Segmento4N) end AS Nomina,
		case when  @Segmento2N=0 then ''  else  max(sueLiquidacion.Descripcion) end AS DescripcionN, 
		genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSuc , 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		SUM(sueTerminada.Dato* suePersContableDatos.Porcentaje/100) as Cantidad,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo >0 then
			sueTerminada.Importe * sueTerminada.Signo else 0 end  * suePersContableDatos.Porcentaje/100) as Percepciones,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo <0 then
			-sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100) as Deducciones,
		SUM(Case when sueTerminada.Signo =0 then
			sueTerminada.Importe else 0 end * suePersContableDatos.Porcentaje/100) as Aportes,
			(SELECT COUNT(1) FROM 
						(SELECT Distinct sueTerminada1.legajo 
							from sueTerminada sueTerminada1 
							inner join suePersSucursal	suePersSucursal1 on
							suePersSucursal1.Legajo = sueTerminada1.Legajo and 
							sueLiquidacion.FechaFinal between suePersSucursal1.FechaDesde and suePersSucursal1.FechaHasta 
						 Where
							suePersSucursal1.Sucursal = genSucursalesEmpr.genSucursalesEmpr and 
							sueTerminada1.sueLiquidacion = sueLiquidacion.sueLiquidacion) as Empelados) as Empleados
				
		From sueLiquidacion INNER JOIN sueTerminada ON
			sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			INNER JOIN genSegmentos ON
			genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id 
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueTerminada.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueTerminada.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			INNER JOIN suePersContable ON
					suePersContable.Legajo = suePersonal.genEntidades AND 
					sueLiquidacion.FechaFinal between suePersContable.FechaDesde and  suePersContable.FechaHasta
			INNER JOIN suePersContableDatos ON  suePersContableDatos.Legajo = suePersContable.Legajo AND
					suePersContableDatos.FechaDesde =suePersContable.FechaDesde 
			LEFT JOIN  conCentro1 ON  conCentro1.conCentro1 = suePersContableDatos.Centro1_Id
			LEFT JOIN  conCentro2 ON  conCentro2.conCentro2 = suePersContableDatos.Centro2_Id
			where
			ISNULL(conCentro1.Centro1_Id,'') Between @Centro1Desde and @Centro1Hasta and 
			ISNULL(conCentro2.Centro2_Id,'') Between @Centro2Desde and @Centro2Hasta and 
				conAsientos.Anulado = 0 and
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genSegmentos.Segmento_Id = @Segmento_Id and 
				genAsiSegmentos.Segmento1N = case when @Segmento1N=0 then genAsiSegmentos.Segmento1N else @Segmento1N end and
				genAsiSegmentos.Segmento2N = case when @Segmento2N=0 then genAsiSegmentos.Segmento2N else @Segmento2N end and
				genAsiSegmentos.Segmento3N = case when @Segmento3N=0 then genAsiSegmentos.Segmento3N else @Segmento3N end and
				genAsiSegmentos.Segmento4N = case when @Segmento4N=0 then genAsiSegmentos.Segmento4N else @Segmento4N end and 
				genAsiSegmentos.Segmento1C = @Segmento1C and
				genAsiSegmentos.Segmento2C = @Segmento2C and
				genAsiSegmentos.Segmento3C = @Segmento3C and
				genAsiSegmentos.Segmento4C = @Segmento4C and
				genAsiSegmentos.Empresa_Id = @Empresa_Id
		GROUP BY genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion , 
				sueConceptos.Concepto_Id, sueConceptos.Descripcion , sueLiquidacion.sueLiquidacion, 
				sueLiquidacion.FechaFinal, genSucursalesEmpr.genSucursalesEmpr,
				genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N, sueLiquidacion.Descripcion, sueLiquidacion.sueLiquidacion ) AS XXX
		GROUP BY Nomina,  Sucursal, DescripcionSuc,	Concepto_Id, DescripcionConc			
		ORDER BY 3,5,1
ELSE
if @AgrupadoPor = '3'
begin 

select Nomina, MAX(DescripcionN) AS DescripcionN, Sucursal, DescripcionSuc,
	Concepto_Id, DescripcionConc, SUM(CANTIDAD) Cantidad,
	SUM(Percepciones) Percepciones, SUM(Deducciones) Deducciones, 
	SUM(Aportes) Aportes, MAX(Empleados) Empleados
from (
SELECT 	case when  @Segmento2N=0 then ''  else dbo.Segmento(@SegmentoInt,@Segmento1C,
		@Segmento2C, @Segmento3C, @Segmento4C,
		@Segmento1N,@Segmento2N, @Segmento3N,
		@Segmento4N) end AS Nomina,
		case when  @Segmento2N=0 then ''  else  max(sueLiquidacion.Descripcion) end AS DescripcionN, 
		conCentro1.Centro1_Id Sucursal, conCentro1.Descripcion as DescripcionSuc , 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		SUM(sueTerminada.Dato* suePersContableDatos.Porcentaje/100) as Cantidad,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo >0 then
			sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100) as Percepciones,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo <0 then
			-sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100) as Deducciones,
		SUM(Case when sueTerminada.Signo =0 then
			sueTerminada.Importe else 0 end * suePersContableDatos.Porcentaje/100) as Aportes, 
			(SELECT COUNT(1) FROM 
			(SELECT Distinct sueTerminada1.legajo from sueTerminada sueTerminada1
				INNER JOIN suePersContable suePersContable1 ON 
					sueTerminada1.sueLiquidacion = sueLiquidacion.Sueliquidacion AND
					suePersContable1.Legajo = sueTerminada1.Legajo AND 
					sueLiquidacion.FechaFinal between  suePersContable1.FechaDesde AND  suePersContable1.FechaHasta
				INNER JOIN  suePersContableDatos suePersContableDatos1 ON suePersContableDatos1.Legajo = suePersContable1.Legajo and 
					suePersContableDatos1.FechaDesde = suePersContable1.FechaDesde and 
					ISNULL(suePersContableDatos1.Centro1_Id,1)= isnull(conCentro1.conCentro1,1)) as Empelados) as Empleados
		From sueLiquidacion INNER JOIN sueTerminada ON
			sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			INNER JOIN genSegmentos ON
			genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id 
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueTerminada.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueTerminada.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			INNER JOIN suePersContable ON
					suePersContable.Legajo = suePersonal.genEntidades AND 
					sueLiquidacion.FechaFinal between suePersContable.FechaDesde and  suePersContable.FechaHasta
			INNER JOIN suePersContableDatos ON  suePersContableDatos.Legajo = suePersContable.Legajo AND
					suePersContableDatos.FechaDesde =suePersContable.FechaDesde 
			LEFT JOIN  conCentro1 ON  conCentro1.conCentro1 = suePersContableDatos.Centro1_Id
			LEFT JOIN  conCentro2 ON  conCentro2.conCentro2 = suePersContableDatos.Centro2_Id
			where
			ISNULL(conCentro1.Centro1_Id,'') Between @Centro1Desde and @Centro1Hasta and 
			ISNULL(conCentro2.Centro2_Id,'') Between @Centro2Desde and @Centro2Hasta and 
				conAsientos.Anulado = 0 and
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genSegmentos.Segmento_Id = @Segmento_Id and 
				genAsiSegmentos.Segmento1N = case when @Segmento1N=0 then genAsiSegmentos.Segmento1N else @Segmento1N end and
				genAsiSegmentos.Segmento2N = case when @Segmento2N=0 then genAsiSegmentos.Segmento2N else @Segmento2N end and
				genAsiSegmentos.Segmento3N = case when @Segmento3N=0 then genAsiSegmentos.Segmento3N else @Segmento3N end and
				genAsiSegmentos.Segmento4N = case when @Segmento4N=0 then genAsiSegmentos.Segmento4N else @Segmento4N end and 
				genAsiSegmentos.Segmento1C = @Segmento1C and
				genAsiSegmentos.Segmento2C = @Segmento2C and
				genAsiSegmentos.Segmento3C = @Segmento3C and
				genAsiSegmentos.Segmento4C = @Segmento4C and
				genAsiSegmentos.Empresa_Id = @Empresa_Id
		GROUP BY 	sueConceptos.Concepto_Id, sueConceptos.Descripcion , 
			conCentro1.Centro1_Id , conCentro1.Descripcion, sueLiquidacion.FechaFinal, conCentro1.conCentro1, 
			sueLiquidacion.sueLiquidacion) as xxx
			GROUP BY Nomina,  Sucursal, DescripcionSuc,	Concepto_Id, DescripcionConc	
		ORDER BY 5,1

end

else

if @AgrupadoPor = '4'
begin 
select Nomina, MAX(DescripcionN) AS DescripcionN, Sucursal, DescripcionSuc,
	Concepto_Id, DescripcionConc, SUM(CANTIDAD) Cantidad,
	SUM(Percepciones) Percepciones, SUM(Deducciones) Deducciones, 
	SUM(Aportes) Aportes, MAX(Empleados) Empleados
from (
SELECT 	case when  @Segmento2N=0 then ''  else dbo.Segmento(@SegmentoInt,@Segmento1C,
		@Segmento2C, @Segmento3C, @Segmento4C,
		@Segmento1N,@Segmento2N, @Segmento3N,
		@Segmento4N) end AS Nomina,
		case when  @Segmento2N=0 then ''  else  max(sueLiquidacion.Descripcion) end AS DescripcionN, 
		conCentro2.Centro2_Id Sucursal, conCentro2.Descripcion as DescripcionSuc , 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		SUM(sueTerminada.Dato* suePersContableDatos.Porcentaje/100) as Cantidad,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo >0 then
			sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100) as Percepciones,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo <0 then
			-sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100) as Deducciones,
		SUM(Case when sueTerminada.Signo =0 then
			sueTerminada.Importe else 0 end * suePersContableDatos.Porcentaje/100) as Aportes, 
			(SELECT COUNT(1) FROM 
			(SELECT Distinct sueTerminada1.legajo from sueTerminada sueTerminada1
				INNER JOIN suePersContable suePersContable1 ON 
					sueTerminada1.sueLiquidacion = sueLiquidacion.Sueliquidacion AND
					suePersContable1.Legajo = sueTerminada1.Legajo AND 
					sueLiquidacion.FechaFinal between  suePersContable1.FechaDesde AND  suePersContable1.FechaHasta
				INNER JOIN  suePersContableDatos suePersContableDatos1 ON suePersContableDatos1.Legajo = suePersContable1.Legajo and 
					suePersContableDatos1.FechaDesde = suePersContable1.FechaDesde and 
					ISNULL(suePersContableDatos1.Centro2_Id,1)= isnull(conCentro2.conCentro2,1)) as Empelados) as Empleados
		From sueLiquidacion INNER JOIN sueTerminada ON
			sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			INNER JOIN genSegmentos ON
			genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id 
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueTerminada.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueTerminada.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			INNER JOIN suePersContable ON
					suePersContable.Legajo = suePersonal.genEntidades AND 
					sueLiquidacion.FechaFinal between suePersContable.FechaDesde and  suePersContable.FechaHasta
			INNER JOIN suePersContableDatos ON  suePersContableDatos.Legajo = suePersContable.Legajo AND
					suePersContableDatos.FechaDesde =suePersContable.FechaDesde 
			LEFT JOIN  conCentro1 ON  conCentro1.conCentro1 = suePersContableDatos.Centro1_Id
			LEFT JOIN  conCentro2 ON  conCentro2.conCentro2 = suePersContableDatos.Centro2_Id
			where
			ISNULL(conCentro1.Centro1_Id,'') Between @Centro1Desde and @Centro1Hasta and 
			ISNULL(conCentro2.Centro2_Id,'') Between @Centro2Desde and @Centro2Hasta and 
				conAsientos.Anulado = 0 and
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genSegmentos.Segmento_Id = @Segmento_Id and 
				genAsiSegmentos.Segmento1N = case when @Segmento1N=0 then genAsiSegmentos.Segmento1N else @Segmento1N end and
				genAsiSegmentos.Segmento2N = case when @Segmento2N=0 then genAsiSegmentos.Segmento2N else @Segmento2N end and
				genAsiSegmentos.Segmento3N = case when @Segmento3N=0 then genAsiSegmentos.Segmento3N else @Segmento3N end and
				genAsiSegmentos.Segmento4N = case when @Segmento4N=0 then genAsiSegmentos.Segmento4N else @Segmento4N end and 
				genAsiSegmentos.Segmento1C = @Segmento1C and
				genAsiSegmentos.Segmento2C = @Segmento2C and
				genAsiSegmentos.Segmento3C = @Segmento3C and
				genAsiSegmentos.Segmento4C = @Segmento4C and
				genAsiSegmentos.Empresa_Id = @Empresa_Id
		GROUP BY 	sueConceptos.Concepto_Id, sueConceptos.Descripcion , 
			conCentro2.Centro2_Id , conCentro2.Descripcion,  sueLiquidacion.FechaFinal, conCentro2.conCentro2, 
			sueLiquidacion.Sueliquidacion) as xxx
		GROUP BY Nomina,  Sucursal, DescripcionSuc,	Concepto_Id, DescripcionConc	
		ORDER BY 5,1

end

else
SELECT Nomina, MAX(DescripcionN) AS DescripcionN, Sucursal, DescripcionSuc,
	Concepto_Id, DescripcionConc, SUM(CANTIDAD) Cantidad,
	SUM(Percepciones) Percepciones, SUM(Deducciones) Deducciones, 
	SUM(Aportes) Aportes, MAX(Empleados) Empleados
FROM(
SELECT 	case when  @Segmento2N=0 then ''  else dbo.Segmento(@SegmentoInt,@Segmento1C,
		@Segmento2C, @Segmento3C, @Segmento4C,
		@Segmento1N,@Segmento2N, @Segmento3N,
		@Segmento4N) end AS Nomina,
		case when  @Segmento2N=0 then ''  else  max(sueLiquidacion.Descripcion) end AS DescripcionN, 
		' ' Sucursal, ' ' as DescripcionSuc , 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConc, 
		SUM(sueTerminada.Dato* suePersContableDatos.Porcentaje/100) as Cantidad,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo >0 then
			sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100) as Percepciones,
		SUM(Case when sueTerminada.Importe * sueTerminada.Signo <0 then
			-sueTerminada.Importe * sueTerminada.Signo else 0 end * suePersContableDatos.Porcentaje/100 ) as Deducciones,
		SUM(Case when sueTerminada.Signo =0 then
			sueTerminada.Importe else 0 end * suePersContableDatos.Porcentaje/100) as Aportes, 
			(SELECT COUNT(1) FROM 
			(SELECT Distinct legajo from sueTerminada sueTerminada1
				 where
				sueTerminada1.sueLiquidacion = sueLiquidacion.Sueliquidacion) as Empelados) as Empleados
		From sueLiquidacion INNER JOIN sueTerminada ON
			sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
			INNER JOIN conAsientos ON 
				conAsientos.conAsientos = sueLiquidacion.sueLiquidacion 
			inner join genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			INNER JOIN genSegmentos ON
			genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id 
			inner join sueConceptos ON
			sueConceptos.sueConceptos = sueTerminada.Concepto_Id
			inner join suePersonal ON
			suePersonal.genEntidades = sueTerminada.Legajo
			Inner join suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
			inner join genSucursalesEmpr ON 
			genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
			INNER JOIN suePersContable ON
					suePersContable.Legajo = suePersonal.genEntidades AND 
					sueLiquidacion.FechaFinal between suePersContable.FechaDesde and  suePersContable.FechaHasta
			INNER JOIN suePersContableDatos ON  suePersContableDatos.Legajo = suePersContable.Legajo AND
					suePersContableDatos.FechaDesde =suePersContable.FechaDesde 
			LEFT JOIN  conCentro1 ON  conCentro1.conCentro1 = suePersContableDatos.Centro1_Id
			LEFT JOIN  conCentro2 ON  conCentro2.conCentro2 = suePersContableDatos.Centro2_Id
			where
			ISNULL(conCentro1.Centro1_Id,'') Between @Centro1Desde and @Centro1Hasta and 
			ISNULL(conCentro2.Centro2_Id,'') Between @Centro2Desde and @Centro2Hasta and 
				conAsientos.Anulado = 0 and
				suePersonal.Legajo between @LegajoDesde and @LegajoHasta and 
				genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
				genSegmentos.Segmento_Id = @Segmento_Id and 
				genAsiSegmentos.Segmento1N = case when @Segmento1N=0 then genAsiSegmentos.Segmento1N else @Segmento1N end and
				genAsiSegmentos.Segmento2N = case when @Segmento2N=0 then genAsiSegmentos.Segmento2N else @Segmento2N end and
				genAsiSegmentos.Segmento3N = case when @Segmento3N=0 then genAsiSegmentos.Segmento3N else @Segmento3N end and
				genAsiSegmentos.Segmento4N = case when @Segmento4N=0 then genAsiSegmentos.Segmento4N else @Segmento4N end and 
				genAsiSegmentos.Segmento1C = @Segmento1C and
				genAsiSegmentos.Segmento2C = @Segmento2C and
				genAsiSegmentos.Segmento3C = @Segmento3C and
				genAsiSegmentos.Segmento4C = @Segmento4C and
				genAsiSegmentos.Empresa_Id = @Empresa_Id
		GROUP BY 	sueConceptos.Concepto_Id, sueConceptos.Descripcion , sueLiquidacion.Sueliquidacion) as xxx
		GROUP BY Nomina,  Sucursal, DescripcionSuc,	Concepto_Id, DescripcionConc	
		ORDER BY 5,1
GO