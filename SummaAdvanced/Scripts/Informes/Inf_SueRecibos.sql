--Inf_SueRecibos 'SLIQ',2019,9,1,1,' ',' ',' ',' ',1,1,9999
DROP PROCEDURE Inf_SueRecibos
GO
CREATE PROCEDURE Inf_SueRecibos
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
	@LegajoDesde Int,
	@LegajoHasta Int,
	@ConvenioDesde VARCHAR(5),
	@ConvenioHasta VARCHAR(5),
	@TipoPagoDesde VARCHAR(5),
	@TipoPagoHasta VARCHAR(5),
	@Centro1Desde VARCHAR(8),
	@Centro1Hasta VARCHAR(8),
	@Centro2Desde VARCHAR(8),
	@Centro2Hasta VARCHAR(8)
)
as
Select sueLiquidacion.Descripcion as DescripcionNomina , sueLiquidacion.Anio, sueLiquidacion.Mes, 
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
ISNULL(SD.VALOR,0) AS SD, suePersonal.NroSegSocial, ' ' Departamento, 
DateDiff(ww, suePersonal.FechaIngreso,sueLiquidacion.FechaFinal) as Antig,
suePeriodicidad.CodFiscal as Periodicidad, 
suePuestos.RiesgoPuesto, suePuestos.Descripcion as Puesto, 
DateDiff(dd, sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal)+1 as DiasPagados,
TipoSdi.Descripcion as TipoSdi, TipoJornada.Descripcion as TipoJornada, 
	'PUE' MetodoPago, suePersonal.ClaveBancaria as Clabe,
		sueConceptos.Concepto_Id, 	sueConceptos.Descripcion, 
		sueTerminada.Dato, sueTerminada.Dato2,
		sueTerminada.IMPORTE*sueTerminada.SIGNO as Importe, 
		sueConceptos.ColumnaRecibo
From sueLiquidacion
INNER JOIN conAsientos On sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id  = conAsientos.conAsientos
inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN sueTerminada ON sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion 
inner join suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo 
INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = genAsiSegmentos.Empresa_Id
LEFT JOIN genProvincias ON genProvincias.genProvincias = genEmpresas.Provincia_Id
LEFT JOIN genPaises ON genPaises.genPaises = genEmpresas.Pais_Id
LEFT JOIN sueNominaCfdi ON sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
	sueNominaCfdi.Legajo = suePersonal.genEntidades
inner join genEntidades on genEntidades.genEntidades = suePersonal.genEntidades
inner join sueGrupos on sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
Left join suePeriodicidad on suePeriodicidad.Periodo_Id = sueGrupos.Periodo_Id
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
inner join suePuestos ON suePuestos.suePuestos = suePersPuestos.Puesto_Id
Left join suePersTipoSDI on suePersTipoSDI.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoSDI.FechaDesde AND suePersTipoSDI.FechaHasta
Left join suePersTipoJornada on suePersTipoJornada.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoJornada.FechaDesde AND suePersTipoJornada.FechaHasta
left join genEntidadesBasicasValor TipoSdi ON
	TipoSdi.Entidad_id  = 1513 and
	TipoSdi.Clave = suePersTipoSDI.TipoSDI and
	TipoSdi.Dominio_ID = 'MX'
	
left join genEntidadesBasicasValor TipoJornada ON
	TipoJornada.Entidad_id  = 1511 and
	TipoJornada.Clave = suePersTipoJornada.TipoJornada and
	TipoJornada.Dominio_ID = 'MX'
inner join sueConceptos ON sueConceptos.sueConceptos = sueTerminada.Concepto_Id
LEFT JOIN (suePersObraSocial INNER JOIN genEntidadesBasicasValor ON
		suePersObraSocial.ObraSocial = genEntidadesBasicasValor.Clave AND
	genEntidadesBasicasValor.Entidad_Id = 1607) ON
	suePersObraSocial.Legajo = suePersonal.genEntidades AND 
	sueLiquidacion.FechaFinal BETWEEN suePersObraSocial.FechaDesde AND suePersObraSocial.FechaHasta
LEFT JOIN (suePersTipoPago INNER JOIN sueTipoPago ON suePersTipoPago.TipoPago_Id = sueTipoPago.sueTipoPago) ON 
	suePersTipoPago.Legajo = suePersonal.genEntidades AND
	sueLiquidacion.FechaFinal BETWEEN suePersTipoPago.FechaDesde AND suePersTipoPago.FechaHasta
LEFT JOIN (suePersContable INNER JOIN suePersContableDatos ON suePersContable.Legajo = suePersContableDatos.Legajo AND
	suePersContable.FechaDesde = suePersContableDatos.FechaDesde 
	INNER JOIN conCentro1 ON suePersContableDatos.Centro1_Id = conCentro1.conCentro1 
	INNER JOIN conCentro2 ON suePersContableDatos.Centro2_Id = conCentro2.conCentro2) ON 
	suePersContable.Legajo = suePersonal.genEntidades AND
	sueLiquidacion.FechaFinal BETWEEN suePersContable.FechaDesde AND suePersContable.FechaHasta	
LEFT JOIN (suePersConvenio INNER JOIN sueConvenio ON suePersConvenio.Convenio_Id = sueConvenio.sueConvenio)  ON
		suePersConvenio.Legajo = suePersonal.genEntidades AND 
		sueLiquidacion.FechaFinal BETWEEN suePersConvenio.FechaDesde AND suePersConvenio.FechaHasta	
Where
	conAsientos.Anulado = 0 and 
	sueTerminada.Signo != 0 and
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
	suePersonal.Legajo BETWEEN  @LegajoDesde And @LegajoHasta AND
	ISNULL(sueTipoPago.TipoPago_Id,'') BETWEEN @TipoPagoDesde AND @TipoPagoHasta AND
	ISNULL(sueConvenio.Convenio_Id,'') BETWEEN @ConvenioDesde AND @ConvenioHasta AND
	ISNULL(conCentro1.Centro1_Id,'') BETWEEN @Centro1Desde AND @Centro1Hasta AND
	ISNULL(conCentro2.Centro2_Id,'') BETWEEN @Centro2Desde AND @Centro2Hasta  		
ORDER BY suePersonal.Legajo, sueConceptos.Concepto_Id
go

	