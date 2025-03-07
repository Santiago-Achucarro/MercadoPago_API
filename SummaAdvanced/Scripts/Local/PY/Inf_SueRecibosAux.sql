--exec Inf_SueRecibos @pSegmento_Id='SLIQ',@pSegmento1N=2020,@pSegmento2N=10,@pSegmento3N=2,@pSegmento4N=2,@pSegmento1C='',@pSegmento2C='',@pSegmento3C='',@pSegmento4C='',@Empresa_Id=1,@LegajoDesde=52,@LegajoHasta=52

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
AS
SELECT sueLiquidacion.Descripcion as DescripcionNomina, sueLiquidacion.Anio, sueLiquidacion.Mes, 
sueLiquidacion.Decena, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Vez,
genEmpresas.Regimen,genEmpresas.Cuit CuitEmpr, genSucursalesEmpr.Localidad as LocalidadEmpr, 
genSucursalesEmpr.CodigoPostal CodigoPostalEmpr, sueLiquidacion.sueLiquidacion,
genEmpresas.Calle CalleEmpr, genEmpresas.NoExterior NoExteriorEmpr , 
genEmpresas.NoInterior NoInteriorEmpr , genEmpresas.Localidad LocalidadEmpr, 
genEmpresas.CodigoPostal CodigoPostalEmpr, 
genProvincias.Descripcion as ProvinciaEmpr , genPaises.Descripcion as PaisEmpr,
genEmpresas.Telefono  as TelefonoEmpr, genSucursalesEmpr.RegPatronal,
ISNULL(sueNominaCfdi.Fecha, Convert(char(19),sueLiquidacion.FechaFinal, 103)) as Fecha,
sueLiquidacion.FechaPago, suePersonal.Legajo, suePersonal.ApellidoPaterno, 
suePersonal.ApellidoMaterno, suePersonal.Nombres, genEntidades.Cuit, suePersonal.NumeroDoc,
suePersonal.FechaIngreso, ISNULL(suePersonal.FechaBaja,'') FechaBaja, ISNULL(SDI.Valor,0) AS SDI, 
ISNULL(SD.VALOR,0) AS SD, suePersonal.NroSegSocial, ' ' Departamento, 
DateDiff(YEAR, suePersonal.FechaIngreso,sueLiquidacion.FechaFinal) as Antig,
suePeriodicidad.CodFiscal as Periodicidad, 
suePuestos.RiesgoPuesto, suePuestos.Descripcion as Puesto, 
DateDiff(dd, sueLiquidacion.FechaInicial, sueLiquidacion.FechaFinal)+1 as DiasPagados,
sueConceptos.Concepto_Id, sueConceptos.Descripcion, sueTerminada.Dato, sueTerminada.Dato2,
sueTerminada.IMPORTE*sueTerminada.SIGNO as Importe, 
CASE WHEN sueConceptos.ColumnaRecibo = 1 THEN sueTerminada.IMPORTE ELSE 0 END Haberes,
CASE WHEN sueConceptos.ColumnaRecibo = 2 THEN sueTerminada.IMPORTE ELSE 0 END Descuentos,
sueConceptos.ColumnaRecibo,
ISNULL(sueCategorias.Categoria_Id,0) Categoria_id, ISNULL(sueCategorias.Descripcion,'') DescCatego,
ISNULL(sueConvenio.Convenio_Id,0) Convenio_id, ISNULL(sueConvenio.Descripcion,'') DescConv,
suePersonal.BancoCuenta, suePersonal.BancoSucursal, suePersonal.BancoTipoCta, suePersonal.ClaveBancaria,
ISNULL((SELECT SUM(Importe) Imp FROM sueTerminada 
INNER JOIN sueConceptosPropValor ON sueTerminada.Concepto_Id = sueConceptosPropValor.Concepto_Id 
INNER JOIN sueConceptosProp ON sueConceptosPropValor.Propiedad = sueConceptosProp.sueConceptosProp AND
	sueConceptosPropValor.SiNo = 1 AND
	sueConceptosProp.Propiedad = 'BASICO'
WHERE sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion AND 
sueTerminada.Legajo = suePersonal.genEntidades),0) Basico,
suePersDomicilio.Direccion1 DirLega, suePersDomicilio.CodigoPostal CPLega,
suePersDomicilio.NroExterior NroLega, suePersDomicilio.Localidad LocalidadLega,
genPcia.Descripcion ProvLega, ISNULL(sueLiquidacion.PeriodoDeposito,'') Periodo,
ISNULL(suePersObraSocial.ObraSocial,'') ObraSocial, ISNULL(genEntidadesBasicasValor.Descripcion,'') DescObra,
ISNULL(sueLiquidacion.FechaDeposito,'') FechaDeposito
FROM sueLiquidacion
INNER JOIN conAsientos On sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id  = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN sueTerminada ON sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion 
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo 
INNER JOIN suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal BETWEEN suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = genAsiSegmentos.Empresa_Id
LEFT JOIN genProvincias ON genProvincias.genProvincias = genEmpresas.Provincia_Id
LEFT JOIN genPaises ON genPaises.genPaises = genEmpresas.Pais_Id
LEFT JOIN sueNominaCfdi ON sueNominaCfdi.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
	sueNominaCfdi.Legajo = suePersonal.genEntidades
INNER JOIN genEntidades on genEntidades.genEntidades = suePersonal.genEntidades
INNER JOIN sueGrupos on sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
LEFT JOIN suePeriodicidad on suePeriodicidad.Periodo_Id = sueGrupos.Periodo_Id
LEFT JOIN sueLiqPersImportes SDI ON 
	SDI.Legajo = suePersonal.genEntidades and 
	SDI.Importe_Id = 2 and 
	sueLiquidacion.FechaFinal Between SDI.Fecha_Desde AND SDI.Fecha_Hasta
LEFT JOIN sueLiqPersImportes SD ON 
	SD.Legajo = suePersonal.genEntidades and 
	SD.Importe_Id = 1 and 
	sueLiquidacion.FechaFinal Between SD.Fecha_Desde AND SD.Fecha_Hasta
INNER JOIN suePersPuestos on suePersPuestos.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersPuestos.FechaDesde AND suePersPuestos.FechaHasta
INNER JOIN suePuestos ON suePuestos.suePuestos = suePersPuestos.Puesto_Id
LEFT JOIN suePersTipoSDI on suePersTipoSDI.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoSDI.FechaDesde AND suePersTipoSDI.FechaHasta
LEFT JOIN suePersTipoJornada on suePersTipoJornada.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoJornada.FechaDesde AND suePersTipoJornada.FechaHasta
LEFT JOIN (suePersCatego INNER JOIN sueCategorias ON suePersCatego.Categoria_Id = sueCategorias.sueCategorias) ON
		suePersCatego.Legajo = suePersonal.genEntidades AND 
		sueLiquidacion.FechaFinal BETWEEN suePersCatego.FechaDesde AND suePersCatego.FechaHasta
LEFT JOIN (suePersConvenio INNER JOIN sueConvenio ON suePersConvenio.Convenio_Id = sueConvenio.sueConvenio) ON
		suePersConvenio.Legajo = suePersonal.genEntidades AND 
		sueLiquidacion.FechaFinal BETWEEN suePersConvenio.FechaDesde AND suePersConvenio.FechaHasta	
INNER JOIN sueConceptos ON sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersDomicilio ON suePersonal.genEntidades = suePersDomicilio.Legajo AND	
	sueLiquidacion.FechaFinal BETWEEN suePersDomicilio.FechaDesde AND suePersDomicilio.FechaHasta
INNER JOIN genProvincias genPcia ON suePersDomicilio.Provincia_Id = genPcia.genProvincias
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
WHERE conAsientos.Anulado = 0 AND 
	sueTerminada.Signo != 0 AND
	genSegmentos.Segmento_Id = @pSegmento_Id AND 
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
GO


