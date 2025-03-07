

--Inf_SueRecibosCabe 'SLIQ',2021,2,7,1,' ',' ',' ',' ',3,4001
--Inf_SueRecibosCuerpo 'SLIQ',2019,9,1,1,' ',' ',' ',' ',1,1
-- Inf_SueRecibosComple 'SLIQ',2019,9,1,1,' ',' ',' ',' ',1,1
DROP PROCEDURE Inf_SueRecibosCabe
GO
CREATE PROCEDURE Inf_SueRecibosCabe
(
	@pSegmento_Id VarChar(10),
	@pSegmento1N INT, 
	@pSegmento2N INT, 
	@pSegmento3N INT, 
	@pSegmento4N INT, 
	@pSegmento1C VarChar(25), 
	@pSegmento2C VarChar(25), 
	@pSegmento3C VarChar(25), 
	@pSegmento4C VarChar(25), 
	@Empresa_Id Int, 
	@Legajo Int 

)

as

select sueLiquidacion.Descripcion as DescripcionNomina , sueLiquidacion.Anio, sueLiquidacion.Mes, 
sueLiquidacion.Decena, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Vez,
genEmpresas.Regimen,genEmpresas.Cuit as RFCEmpresa, genSucursalesEmpr.Localidad as LocalidadEmpr, 
genSucursalesEmpr.CodigoPostal CodigoPostalEmpr, 
genEmpresas.Calle  CalleEmpr , genEmpresas.NoExterior NoExteriorEmpr , 
genEmpresas.NoInterior NoInteriorEmpr , genEmpresas.Localidad LocalidadEmpr, 
genEmpresas.CodigoPostal CodigoPostalEmpr, 
genProvincias.Descripcion as ProvinciaEmpr , genPaises.Descripcion as PaisEmpr,
genEmpresas.Telefono  as TelefonoEmpr, genSucursalesEmpr.RegPatronal,
ISNULL(sueNominaCfdi.Fecha, Convert(char(19),sueLiquidacion.FechaFinal, 103)) as Fecha,
sueLiquidacion.FechaPago, 
suePersonal.Legajo, suePersonal.ApellidoPaterno, suePersonal.ApellidoMaterno, suePersonal.Nombres, 
genEntidades.Cuit as RFC, suePersonal.NumeroDoc as CURP,
suePersonal.FechaIngreso, ISNULL(SDI.Valor,0) AS SDI, 
ISNULL(SD.VALOR,0) AS SD, suePersonal.NroSegSocial, conCentro1.Descripcion Departamento, 
DateDiff(ww, suePersonal.FechaIngreso,sueLiquidacion.FechaFinal) as Antig,
suePeriodicidad.CodFiscal as Periodicidad, 
suePuestos.RiesgoPuesto, suePuestos.Descripcion as Puesto, 
case when 
ISNULL((select sum(sueTerminada.Dato * sueTerminada.Signo)
	from sueConceptos , sueConceptosPropValor , sueTerminada
	where 
		sueTerminada.Concepto_Id = sueConceptos.sueConceptos and 
		sueConceptosPropValor.Concepto_Id = sueConceptos.sueConceptos and 
		sueConceptosPropValor.Propiedad = 3 and 
		sueConceptosPropValor.SiNo = 1 and 
		sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion and
		sueTerminada.Legajo = suePersonal.genEntidades),0) = 0 
	then 
	DateDiff(dd, sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal)+1 else
	ISNULL((select sum(sueTerminada.Dato* sueTerminada.Signo)
	from sueConceptos , sueConceptosPropValor , sueTerminada
	where 
		sueTerminada.Concepto_Id = sueConceptos.sueConceptos and 
		sueConceptosPropValor.Concepto_Id = sueConceptos.sueConceptos and 
		sueConceptosPropValor.Propiedad = 3 and 
		sueConceptosPropValor.SiNo = 1 and 
		sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion and
		sueTerminada.Legajo = suePersonal.genEntidades),0) end 	as DiasPagados,
TipoSdi.Descripcion as TipoSdi, TipoJornada.Descripcion as TipoJornada, 
	'PUE' MetodoPago, suePersonal.ClaveBancaria as Clabe, 
	suePersTipoContrato.TipoContrato 
from sueLiquidacion INNER JOIN conAsientos on 
sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id  = conAsientos.conAsientos
inner join genSegmentos ON 
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
inner join suePersonal ON 
suePersonal.Legajo = @Legajo 
INNER JOIN suePersSucursal ON 
suePersSucursal.Legajo = suePersonal.genEntidades and 
sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genEmpresas ON
genEmpresas.genEmpresas = genAsiSegmentos.Empresa_Id
LEFT JOIN genProvincias ON
genProvincias.genProvincias = genEmpresas.Provincia_Id
LEFT JOIN genPaises ON
genPaises.genPaises = genEmpresas.Pais_Id
LEFT JOIN sueNominaCfdi ON
sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
sueNominaCfdi.Legajo = suePersonal.genEntidades and 
sueNominaCfdi.Anulada = 0 
inner join genEntidades on 
genEntidades.genEntidades = suePersonal.genEntidades
inner join sueGrupos on sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
inner join suePeriodicidad on suePeriodicidad.Periodo_Id = sueGrupos.Periodo_Id
LEFT JOIN sueLiqPersImportes SDI ON 
	SDI.Legajo = suePersonal.genEntidades and 
	SDI.Importe_Id = 2 and 
	sueLiquidacion.FechaFinal Between SDI.Fecha_Desde AND SDI.Fecha_Hasta
LEFT JOIN sueLiqPersImportes SD ON 
	SD.Legajo = suePersonal.genEntidades and 
	SD.Importe_Id = 1 and 
	sueLiquidacion.FechaFinal Between SD.Fecha_Desde AND SD.Fecha_Hasta
inner join suePersPuestos on suePersPuestos.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersPuestos.FechaDesde AND suePersPuestos.FechaHasta
inner join suePuestos ON
suePuestos.suePuestos = suePersPuestos.Puesto_Id
inner join suePersTipoSDI on suePersTipoSDI.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoSDI.FechaDesde AND suePersTipoSDI.FechaHasta
inner join suePersTipoJornada on suePersTipoJornada.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoJornada.FechaDesde AND suePersTipoJornada.FechaHasta
left join genEntidadesBasicasValor TipoSdi ON
	TipoSdi.Entidad_id  = 1513 and
	TipoSdi.Clave = suePersTipoSDI.TipoSDI and
	TipoSdi.Dominio_ID = 'MX'
	
left join genEntidadesBasicasValor TipoJornada ON
	TipoJornada.Entidad_id  = 1511 and
	TipoJornada.Clave = suePersTipoJornada.TipoJornada and
	TipoJornada.Dominio_ID = 'MX'

inner join (SELECT suePersContable.FechaDesde , suePersContable.FechaHasta, 
	suePersContableDatos.Legajo, MAX(suePersContableDatos.Centro1_id) AS Centro1_id 
FROM suePersContableDatos INNER JOIN  suePersContable ON
suePersContableDatos.Legajo = suePersContable.Legajo and 
suePersContableDatos.FechaDesde = suePersContable.FechaDesde 
GROUP BY suePersContableDatos.Legajo, suePersContable.FechaDesde, suePersContable.FechaHasta ) as suePersContableDatos ON
suePersContableDatos.Legajo = suePersonal.genEntidades and 
sueLiquidacion.FechaFinal between suePersContableDatos.FechaDesde And suePersContableDatos.FechaHasta
inner join conCentro1 ON conCentro1.conCentro1 = suePersContableDatos.Centro1_id
LEFT JOIN suePersTipoContrato ON suePersTipoContrato.Legajo = suePersonal.genEntidades and 
 sueLiquidacion.FechaFinal Between  suePersTipoContrato.FechaDesde  and suePersTipoContrato.FechaHasta
Where
	conAsientos.Anulado = 0 and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N AND
	genAsiSegmentos.Segmento2N = @pSegmento2N AND
	genAsiSegmentos.Segmento3N = @pSegmento3N AND
	genAsiSegmentos.Segmento4N = @pSegmento4N AND
	genAsiSegmentos.Segmento1C = @pSegmento1C AND
	genAsiSegmentos.Segmento2C = @pSegmento2C AND
	genAsiSegmentos.Segmento3C = @pSegmento3C AND
	genAsiSegmentos.Segmento4C = @pSegmento4C AND
	genAsiSegmentos.Empresa_Id = @Empresa_Id AND
	Exists(SELECT 1 from sueTerminada Where
		suePersonal.genEntidades = sueTerminada.Legajo and 
		sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
		suePersonal.Legajo= @Legajo ) 
go

DROP PROCEDURE Inf_SueRecibosCuerpo
GO
CREATE PROCEDURE Inf_SueRecibosCuerpo
(
	@pSegmento_Id VarChar(10),
	@pSegmento1N INT, 
	@pSegmento2N INT, 
	@pSegmento3N INT, 
	@pSegmento4N INT, 
	@pSegmento1C VarChar(25), 
	@pSegmento2C VarChar(25), 
	@pSegmento3C VarChar(25), 
	@pSegmento4C VarChar(25), 
	@Empresa_Id Int, 
	@Legajo Int 

)

as

-- Cuerpo

SELECT case when sueTerminada.IMPORTE*sueTerminada.SIGNO > 0 THEN 
	ISNULL(sueConceptos.TipoOtro, sueConceptos.TipoPercepcion) else 
		sueConceptos.TipoDeduccion end as Clave, 
		sueConceptos.Concepto_Id, 	sueConceptos.Descripcion, 
			sueTerminada.Dato, 
			case when sueConceptos.TipoPercepcion ='019' then 
			case when sueTerminada.Dato2 = 0 THEN DATEDIFF(dd, sueLiquidacion.FechaInicial, sueliquidacion.FechaFinal) ELSE 
			sueTerminada.Dato2 END else 0 end Dato2 ,
			sueTerminada.IMPORTE*sueTerminada.SIGNO as Importe, 
			case when sueTerminada.IMPORTE*sueTerminada.SIGNO > 0 THEN 
				case when sueConceptos.TipoOtro  is not null  Then 3 else 1 end else 
				2  end ColumnaRecibo, 
				Case when sueTerminada.IMPORTE*sueTerminada.SIGNO > 0 THEN 
					ISNULL(sueConceptos.TipoOtro ,sueConceptos.TipoPercepcion) 
					 when sueTerminada.IMPORTE*sueTerminada.SIGNO > 0 THEN 
					sueConceptos.TipoDeduccion  ELSE 0 END  TipoConc 
From sueConceptos inner join sueTerminada ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN genAsiSegmentos on
genAsiSegmentos.Asiento_Id = sueTerminada.sueLiquidacion 
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER JOIN conAsientos ON 
conAsientos.conAsientos =sueTerminada.sueLiquidacion
INNER JOIN suePersonal ON  suePersonal.genEntidades = sueTerminada.Legajo
INNER JOIN sueLiquidacion ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
Where
	sueConceptos.Signo != 0 and 
	conAsientos.Anulado = 0 and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N AND
	genAsiSegmentos.Segmento2N = @pSegmento2N AND
	genAsiSegmentos.Segmento3N = @pSegmento3N AND
	genAsiSegmentos.Segmento4N = @pSegmento4N AND
	genAsiSegmentos.Segmento1C = @pSegmento1C AND
	genAsiSegmentos.Segmento2C = @pSegmento2C AND
	genAsiSegmentos.Segmento3C = @pSegmento3C AND
	genAsiSegmentos.Segmento4C = @pSegmento4C AND
	genAsiSegmentos.Empresa_Id = @Empresa_Id AND
	suePersonal.Legajo = @Legajo
ORDER BY 2
GO

DROP PROCEDURE Inf_SueRecibosComple
GO
CREATE PROCEDURE Inf_SueRecibosComple
(
	@pSegmento_Id VarChar(10),
	@pSegmento1N INT, 
	@pSegmento2N INT, 
	@pSegmento3N INT, 
	@pSegmento4N INT, 
	@pSegmento1C VarChar(25), 
	@pSegmento2C VarChar(25), 
	@pSegmento3C VarChar(25), 
	@pSegmento4C VarChar(25), 
	@Empresa_Id Int, 
	@Legajo Int 

)
as

-- Complemento
SELECT	sueNominaCfdi.FechaTimbrado, sueNominaCfdi.Fecha, sueNominaCfdi.NoCertificado, 
	sueNominaCfdi.noCertificadoSAT, sueNominaCfdi.RfcProvCertif, sueNominaCfdi.Folio, 
	sueNominaCfdi.UUID, sueNominaCfdi.SelloSAt, sueNominaCfdi.SelloDigital
FROM sueNominaCfdi 
INNER JOIN genAsiSegmentos on
genAsiSegmentos.Asiento_Id = sueNominaCfdi.sueLiquidacion 
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER JOIN conAsientos ON 
conAsientos.conAsientos =sueNominaCfdi.sueLiquidacion
INNER JOIN suePersonal ON  suePersonal.genEntidades = sueNominaCfdi.Legajo
Where
	sueNominaCfdi.Anulada =0 and
	conAsientos.Anulado = 0 and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N AND
	genAsiSegmentos.Segmento2N = @pSegmento2N AND
	genAsiSegmentos.Segmento3N = @pSegmento3N AND
	genAsiSegmentos.Segmento4N = @pSegmento4N AND
	genAsiSegmentos.Segmento1C = @pSegmento1C AND
	genAsiSegmentos.Segmento2C = @pSegmento2C AND
	genAsiSegmentos.Segmento3C = @pSegmento3C AND
	genAsiSegmentos.Segmento4C = @pSegmento4C AND
	genAsiSegmentos.Empresa_Id = @Empresa_Id AND
	suePersonal.Legajo = @Legajo

go
		

	