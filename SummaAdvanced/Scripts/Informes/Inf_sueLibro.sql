--Inf_SueLibro 'SLIQ',2022,3,1,2,' ',' ',' ',' ',1,1,9999,'','ZZZZZ','','ZZZZZZZZ','','ZZZZZ','','ZZZZ'
--Inf_SueLibro 'SLIQ',2022,2,2,5,' ',' ',' ',' ',1,1,99999,'','ZZZZZ','','ZZZZZZZZ','','ZZZZZ','','ZZZZ'

DROP PROCEDURE Inf_SueLibro
GO
CREATE PROCEDURE Inf_SueLibro
(
	@Segmento_Id VarChar(10),
	@Segmento1N INT, 
	@Segmento2N INT, 
	@Segmento3N INT, 
	@Segmento4N INT, 
	@Segmento1C VarChar(25), 
	@Segmento2C VarChar(25), 
	@Segmento3C VarChar(25), 
	@Segmento4C VarChar(25), 
	@Empresa_Id Int, 
	@LegajoDesde Int ,
	@LegajoHasta Int, 
	@TipoPagoDesde VARCHAR(5),
	@TipoPagoHasta VARCHAR(5),
	@Centro1Desde VARCHAR(8),
	@Centro1Hasta VARCHAR(8),
	@ConvenioDesde VARCHAR(5),
	@ConvenioHasta VARCHAR(5),
	@SucursalDesde VARCHAR(4),
	@SucursalHasta VARCHAR(4)
)
AS

SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED

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
--CASE WHEN sueTerminada.IMPORTE*sueTerminada.SIGNO > 0  THEN sueTerminada.IMPORTE ELSE 0 END Haberes,
--CASE WHEN sueTerminada.IMPORTE*sueTerminada.SIGNO < 0  THEN sueTerminada.IMPORTE ELSE 0 END Descuentos,
CASE WHEN sueConceptos.ColumnaRecibo = 1 THEN sueTerminada.IMPORTE ELSE 0 END Haberes,
CASE WHEN sueConceptos.ColumnaRecibo = 2 THEN sueTerminada.IMPORTE ELSE 0 END Descuentos,
sueConceptos.ColumnaRecibo,
ISNULL(sueCategorias.Categoria_Id,0) Categoria_id, ISNULL(sueCategorias.Descripcion,'') DescCatego,
ISNULL(sueConvenio.Convenio_Id,0) Convenio_Id, ISNULL(sueConvenio.Descripcion,'') DescConv,
suePersonal.BancoCuenta, suePersonal.BancoSucursal, suePersonal.BancoTipoCta, suePersonal.ClaveBancaria,
ISNULL((SELECT SUM(Importe) Imp FROM sueTerminada 
INNER JOIN sueConceptosPropValor ON sueTerminada.Concepto_Id = sueConceptosPropValor.Concepto_Id 
INNER JOIN sueConceptosProp ON sueConceptosPropValor.Propiedad = sueConceptosProp.sueConceptosProp AND
	sueConceptosPropValor.SiNo = 1 AND
	sueConceptosProp.Propiedad = 'BASICO'
WHERE sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion AND 
sueTerminada.Legajo = suePersonal.genEntidades),0) Basico,
suePersDomicilio.Direccion1 DirLega, suePersDomicilio.CodigoPostal CPLega,
suePersDomicilio.NroExterior NroLega, suePersDomicilio.Localidad LocalidadLega, suePersDomicilio.NroInterior Piso,
genPcia.Descripcion ProvLega, ISNULL(sueLiquidacion.PeriodoDeposito,'') Periodo,
ISNULL(suePersObraSocial.ObraSocial,'') ObraSocial, ISNULL(genEntiBV1.Descripcion,'') DescObra,
genEntidadesBasicasValor.Clave EstadoCivil,
genEntidadesBasicasValor.Descripcion DescECivil, suePersonal.FechaNacimiento, genPaises2.Descripcion DescNac,
genPaises2.Dominio_Id Nac
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
LEFT JOIN (suePersObraSocial INNER JOIN genEntidadesBasicasValor genEntiBV1 ON
		suePersObraSocial.ObraSocial = genEntiBV1.Clave AND
	genEntiBV1.Entidad_Id = 1607) ON
	suePersObraSocial.Legajo = suePersonal.genEntidades AND 
	sueLiquidacion.FechaFinal BETWEEN suePersObraSocial.FechaDesde AND suePersObraSocial.FechaHasta	
INNER JOIN suePersTipoPago on suePersTipoPago.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersTipoPago.FechaDesde AND suePersTipoPago.FechaHasta
INNER JOIN sueTipoPago ON suePersTipoPago.TipoPago_Id = sueTipoPago.sueTipoPago
INNER JOIN (SELECT MAX(conMovCont.Centro1_Id) Centro1_Id, conMovCont.conAsientos from sueTerminada 
INNER JOIN conMovCont ON sueTerminada.sueLiquidacion = conMovCont.conAsientos
GROUP BY conMovCont.conAsientos) conMovCont ON sueTerminada.sueLiquidacion = conMovCont.conAsientos
LEFT JOIN conCentro1 ON ISNULL(conMovCont.Centro1_Id,'') = conCentro1.conCentro1
INNER JOIN suePersEstadoCivil ON suePersEstadoCivil.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal Between suePersEstadoCivil.FechaDesde AND suePersEstadoCivil.FechaHasta
INNER JOIN genEntidadesBasicasValor ON suePersEstadoCivil.EstadoCivil_Id = genEntidadesBasicasValor.Clave AND	
	genEntidadesBasicasValor.Entidad_Id = 1504
INNER JOIN genPaises genPaises2 ON suePersonal.Nacionalidad_Id = genPaises2.genPaises
WHERE conAsientos.Anulado = 0 AND 
	sueTerminada.Signo != 0 AND
	genSegmentos.Segmento_Id = @Segmento_Id AND 
	genAsiSegmentos.Segmento1N = @Segmento1N AND
	genAsiSegmentos.Segmento2N = @Segmento2N AND
	genAsiSegmentos.Segmento3N = @Segmento3N AND
	genAsiSegmentos.Segmento4N = @Segmento4N AND
	genAsiSegmentos.Segmento1C = @Segmento1C AND
	genAsiSegmentos.Segmento2C = @Segmento2C AND
	genAsiSegmentos.Segmento3C = @Segmento3C AND
	genAsiSegmentos.Segmento4C = @Segmento4C AND
	genAsiSegmentos.Empresa_Id = @Empresa_Id AND
	suePersonal.Legajo BETWEEN  @LegajoDesde And @LegajoHasta AND
	sueTipoPago.TipoPago_Id BETWEEN @TipoPagoDesde AND @TipoPagoHasta AND
	ISNULL(conCentro1.Centro1_Id,'') BETWEEN @Centro1Desde AND @Centro1Hasta AND
	sueConvenio.Convenio_Id BETWEEN @ConvenioDesde AND @ConvenioHasta AND
	genSucursalesEmpr.Sucursal BETWEEN @SucursalDesde AND @SucursalHasta
/*UNION ALL
SELECT ' ' DescNomina, 0 Anio,0 Mes,0 Decena,0 Quincena, 0 Semana, 0 Vez,'' Regimen,'' CuitEmpr,'' Locali,'' CP,0 sueLiquidacion,'' Calle,
'' NroExt,'' NroInt,'' Localidad,'' CodigoP,'' Pcia,'' Pais,'' Tel,'' Reg,'' Fecha,'' Fecha,  suePersonal.Legajo, '' Apell,'' ApellM,'' Nombre,
'' Cuit,'' Doc,'' FechaIng,'' FechaBaja, 0 SDI,0 SD,'' SegSo,'' Dpto, 0 Antig,'' Perio,'' Riesgo,'' Puesto,0 DiasP , '9999' Concepto_Id, 
sueFamiliares.ApellidoyNombre, 0 Dato,0 Dato2, 0 Imp, 0 Hab,0 Descu, 0 ColRe, '' Cate, sueFamiliares.Sexo, '' Convenio, sueFamiliares.NroDoc Descconv,'' BancocTa,
'' BancoSuc,'' BancoTipoCta,'' Clave, 0 Basico, '' DirLega,'' CPLega, '' NroLega,'' Loca,'' Piso,'' Prov,'' Periodo,'' ObraSoc,'' DescObra,
'' EC,'' DECI ,sueFamiliares.FechaNacimiento, '', ''
	FROM suePersonal
	INNER JOIN sueFamiliares ON suePersonal.genEntidades = sueFamiliares.Legajo
	WHERE suePersonal.Legajo BETWEEN  @LegajoDesde And @LegajoHasta*/
ORDER BY suePersonal.Legajo, sueConceptos.Concepto_Id

OPTION (RECOMPILE)
GO

