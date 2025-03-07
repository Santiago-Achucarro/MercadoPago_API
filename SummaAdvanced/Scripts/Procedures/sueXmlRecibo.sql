
-- sueXmlReciboDatos  52481,38, 'O'

DROP PROCEDURE sueXmlReciboDatos 
GO
CREATE PROCEDURE sueXmlReciboDatos 
(
	@pSueliquidacion bigint,
	@Legajo Int ,
	@pTipoNomina Char(1)
)

as

DECLARE @Empresa_Id int

SET @Empresa_Id = (Select Empresa_Id from conAsientos Where conAsientos.conAsientos= @pSueLiquidacion)

-- Comprobante
SELECT '3.3' as Version, conAsientos.conAsientos Asiento_Id, 
		sueNominaCfdi.Folio, 'NOM' Serie,
		 dbo.FechaActual() as Fecha , conAsientos.FechaRegistro ,
		'PUE' MetodoPago, 
		ISNULL(sueNominaCfdi.noCertificado,(SELECT cValor FROM genGlobales WHERE NOMBRE_VAR = 'VENNOCERTIFICADO' and Empresa_Id=@Empresa_Id)) AS NoCertificado, 
		convert(VarChar(max),(SELECT mValor FROM genGlobales where Nombre_var = 'GENWSAAPUBLICKEY' and Empresa_Id=@Empresa_Id)) AS Certificado,
		SUM(case when sueTerminada.Importe*sueTerminada.Signo < 0 then 0 else  sueTerminada.Importe*sueTerminada.Signo end)  as SubTotal,
		SUM(case when sueTerminada.Importe*sueTerminada.Signo > 0 then 0 else  -sueTerminada.Importe*sueTerminada.Signo end)   as Descuento, 		
		genMonedas.CodigoFiscal as Moneda, genMonedas.Descripcion as DescripcionMoneda, 
		genMonedas.Moneda_Id,
		SUM(sueTerminada.Importe*sueTerminada.Signo) as Total,
		1 as TipoCambio,
		'N' as TipoDeComprobante, 
		'99' as  FormaPago, 
		genSucursalesEmpr.CodigoPostal as LugarExpedicion, ' ' Confirmacion
from sueLiquidacion INNER JOIN conAsientos ON
sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN sueTerminada ON 
sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion
INNER JOIN suePersonal ON
suePersonal.genEntidades = sueTerminada.Legajo 
left OUTER JOIN sueNominaCfdi ON 
sueNominaCfdi.sueLiquidacion =  sueLiquidacion.sueLiquidacion AND 
sueNominaCfdi.Legajo =  suePersonal.genEntidades
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conAsientos.Moneda_Id
LEFT OUTER JOIN genSucursalesEmpr ON
conAsientos.Sucursal = genSucursalesEmpr.genSucursalesEmpr
Where
sueNominaCfdi.Anulada = 0 AND 
sueTerminada.sueLiquidacion = @pSueliquidacion and 
suePersonal.Legajo = @Legajo
GROUP BY conAsientos.conAsientos , sueNominaCfdi.Folio,	 conAsientos.FechaRegistro , sueNominaCfdi.noCertificado,
		genMonedas.CodigoFiscal , genMonedas.Descripcion , 		genMonedas.Moneda_Id,	genSucursalesEmpr.CodigoPostal 

-- CFDI Relacionados
SELECT '04' as TipoRelacion
	where Exists(select 1 from sueNominaCfdi,suePersonal 
		where
		suePersonal.genEntidades = sueNominaCfdi.Legajo and 
		sueNominaCfdi.sueLiquidacion = @pSueliquidacion and 
		suePersonal.Legajo = @Legajo and 
		sueNominaCfdi.Anulada = 1)
	

-- CFDI RELACIONADO
SELECT '04' TipoRelacion, MAX(sueNominaCfdi.UUID) AS UUID
FROM sueNominaCfdi inner join suePersonal ON 
suePersonal.genEntidades = sueNominaCfdi.Legajo
	Where 
		sueNominaCfdi.sueLiquidacion = @pSueliquidacion and 
		suePersonal.Legajo = @Legajo and 
		sueNominaCfdi.Anulada = 1 
HAVING 	MAX(sueNominaCfdi.UUID) IS NOT NULL	

-- Emisor

SELECT 
genEmpresas.Cuit AS Rfc,
genEmpresas.RazonSocial AS Nombre,
genEmpresas.Regimen AS RegimenFiscal,
Convert(VarChar(max),(select mValor from genGlobales where Nombre_var = 'GENWSAAPRIVATEKEY' and Empresa_Id=@Empresa_Id)) AS EmpPrivateKey,
genEmpresas.Calle,
genEmpresas.NoExterior,
genEmpresas.NoInterior,
genEmpresas.Colonia,
genEmpresas.Localidad,
genEmpresas. Municipio,
genProvincias.CodFiscal AS Provincia,
genPaises.CodFiscal AS Pais,
genEmpresas.CodigoPostal, 
genEmpresas.CodLocalidad, 
genEmpresas.CodColonia, 
genEmpresas.CodMunicipio
from genEmpresas inner join conAsientos ON 
genEmpresas.genEmpresas = conAsientos.Empresa_Id 
LEFT OUTER JOIN genProvincias ON 
genEmpresas.Provincia_Id =genProvincias.genProvincias
LEFT OUTER JOIN genPaises ON 
genPaises.genPaises = genEmpresas.Pais_Id
Where
conAsientos.conAsientos = @pSueLiquidacion


--- receptor
SELECT genEntidades.CUIT AS Rfc, 
	suePersonal.Nombres +
	case when isnull(suePersonal.ApellidoPaterno,'') != '' THEN ' ' +suePersonal.ApellidoPaterno ELSE '' END +
	case when isnull(suePersonal.ApellidoMaterno,'') != '' THEN ' ' +suePersonal.ApellidoMaterno ELSE '' END as Nombre, 
	genPaises.CodFiscal AS ResidenciaFiscal,
	' ' AS NumRegIdTrib,
	'P01' as UsoCfdi, 
	suePersDomicilio.Direccion1 Calle , suePersDomicilio.NroExterior NroExterior, 
	suePersDomicilio.NroInterior NroInterior, suePersDomicilio.Direccion2 Colonia,
	suePersDomicilio.Localidad AS Localidad,
	genProvincias.CodFiscal as Provincia, genPaises.CodFiscal as Pais, 
	suePersDomicilio.CodigoPostal as CodigoPostal
from sueLiquidacion INNER JOIN
	suePersonal ON
		EXISTS(SELECT 1 FROM sueTerminada where
			sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion and 
			sueTerminada.Legajo = suePersonal.genEntidades)
INNER JOIN suePersDomicilio ON
suePersonal.genEntidades = suePersDomicilio.Legajo AND 
sueLiquidacion.FechaFinal between suePersDomicilio.FechaDesde AND suePersDomicilio.FechaHasta
INNER JOIN genEntidades ON
genEntidades.genEntidades = suePersonal.genEntidades
CROSS JOIN genInstalacion
INNER JOIN genPaises ON 
genInstalacion.Dominio_Id = genPaises.Dominio_Id
INNER JOIN genProvincias ON
genProvincias.genProvincias = suePersDomicilio.Provincia_id
Where
sueLiquidacion.sueLiquidacion = @psueLiquidacion AND 
suePersonal.Legajo = @Legajo


SELECT 1 as Renglon, 
	'84111505' as ClaveProdServ,
	'' as NoIdentificacion, 
	1 AS Cantidad,
	'ACT' AS ClaveUnidad,
    ' ' Descripcion, 			
	SUM(case when sueTerminada.Importe*sueTerminada.Signo < 0 then 0 else  sueTerminada.Importe*sueTerminada.Signo end)   AS ValorUnitario,
	SUM(case when sueTerminada.Importe*sueTerminada.Signo > 0 then 0 else  -sueTerminada.Importe*sueTerminada.Signo end)   as Descuento, 		
	SUM(case when sueTerminada.Importe*sueTerminada.Signo < 0 then 0 else  sueTerminada.Importe*sueTerminada.Signo end)   AS Importe 
from sueLiquidacion INNER JOIN conAsientos ON
sueLiquidacion.sueLiquidacion = conAsientos.conAsientos
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN sueTerminada ON 
sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN suePersonal ON
suePersonal.genEntidades = sueTerminada.Legajo
LEFT OUTER JOIN genSucursalesEmpr ON
conAsientos.Sucursal = genSucursalesEmpr.genSucursalesEmpr
Where
sueTerminada.sueLiquidacion = @pSueliquidacion and 
suePersonal.Legajo = @Legajo


-- Complemento
SELECT '1.2' as Version, @pTipoNomina as TipoNomina, sueLiquidacion.FechaPago, 
sueliquidacion.FechaInicial, sueliquidacion.FechaFinal, 
 Convert(int, case when 
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
		sueTerminada.Legajo = suePersonal.genEntidades),0) end) 	as NumDiasPagado, 
sum(case when sueTerminada.Importe*sueTerminada.signo > 0 And sueConceptos.TipoOtro IS NULL then sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalPercepciones,
sum(case when sueTerminada.Importe*sueTerminada.signo < 0 then -sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalDeducciones,
sum(case when sueTerminada.Importe*sueTerminada.signo > 0 And sueConceptos.TipoOtro IS NOT NULL then sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalOtros
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo
GROUP BY sueLiquidacion.FechaPago, sueliquidacion.FechaInicial, sueliquidacion.FechaFinal,
sueLiquidacion.sueLiquidacion, suePersonal.genEntidades

-- Emisor

SELECT genSucursalesEmpr.RegPatronal , genEmpresas.NumeroIIBB Curp, ' ' RFCPatronOrigen
from sueLiquidacion inner join suePersonal on
suePersonal.Legajo = @Legajo 
inner join suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr on 
	genSucursalesEmpr.genSucursalesEmpr =  suePersSucursal.Sucursal
inner join genEmpresas ON genEmpresas.genEmpresas = @Empresa_Id
Where
	sueliquidacion.sueliquidacion = @psueliquidacion 

--  EntidadSNCF 
SELECT ' ' OrigenRecurso, 0.00 MontoRecursoPropio
Where 1 = 2

-- Receptor
-- TODO  SINDICALIZADO FALTA

SELECT suePersonal.NumeroDoc AS CURP, suePersonal.NroSegSocial as NumSeguridadSocial , 
suePersonal.FechaIngreso as FechaInicioRelLaboral, 
Convert(Int,(DateDiff(dd, suePersonal.FechaIngreso, sueliquidacion.FechaFinal)+1)/7) as Antig,
suePersTipoContrato.TipoContrato , 0 Sindicalizado ,
suePersTipoJornada.TipoJornada , suePersTipoRegimen.TipoRegimen, 
suePersonal.Legajo as NumEmpleado, conCentro1.Descripcion as Departamento,
suePuestos.Descripcion as Puesto, suePuestos.RiesgoPuesto , 
CASE WHEN @pTipoNomina = 'E' THEN '99' ELSE sueperiodicidad.CodFiscal END as PeriodicidadPago, 
sueTipoPago.Descripcion as Banco, 
suePersonal.ClaveBancaria as CuentaBancaria, ISNULL(SD.Valor,0) as SalarioBaseCotApor ,
ISNULL(sdi.Valor,0) SalarioDiarioIntegrado, genProvincias.CodFiscal as ClaveEntFed

From sueLiquidacion inner join suePersonal on
suePersonal.Legajo = @Legajo 
inner join suePersTipoContrato ON suePersTipoContrato.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersTipoContrato.FechaDesde And suePersTipoContrato.FechaHasta
inner join suePersTipoJornada ON suePersTipoJornada.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersTipoJornada.FechaDesde And suePersTipoJornada.FechaHasta
inner join suePersTipoRegimen ON suePersTipoRegimen.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersTipoRegimen.FechaDesde And suePersTipoRegimen.FechaHasta
inner join (SELECT suePersContable.FechaDesde , suePersContable.FechaHasta, 
	suePersContableDatos.Legajo, MAX(suePersContableDatos.Centro1_id) AS Centro1_id 
FROM suePersContableDatos INNER JOIN  suePersContable ON
suePersContableDatos.Legajo = suePersContable.Legajo and 
suePersContableDatos.FechaDesde = suePersContable.FechaDesde 
GROUP BY suePersContableDatos.Legajo, suePersContable.FechaDesde, suePersContable.FechaHasta ) as suePersContableDatos ON
suePersContableDatos.Legajo = suePersonal.genEntidades and 
sueLiquidacion.FechaFinal between suePersContableDatos.FechaDesde And suePersContableDatos.FechaHasta
inner join conCentro1 ON conCentro1.conCentro1 = suePersContableDatos.Centro1_id
inner join suePersPuestos ON suePersPuestos.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersPuestos.FechaDesde And suePersPuestos.FechaHasta
INNER JOIN suePuestos ON 
suePuestos.suePuestos = suePersPuestos.Puesto_Id
inner join suePersCatego ON  suePersCatego.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersCatego.FechaDesde And suePersCatego.FechaHasta
inner join sueCategorias ON sueCategorias.sueCategorias = suePersCatego.Categoria_Id
inner join sueperiodicidad ON sueperiodicidad.Periodo_Id = sueCategorias.Periodo_Id
inner join suePersTipoPago ON  suePersTipoPago.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersTipoPago.FechaDesde And suePersTipoPago.FechaHasta
inner join sueTipoPago ON sueTipoPago.sueTipoPago = suePersTipoPago.TipoPago_Id
left join sueLiqPersImportes  AS SDI ON SDI.Legajo = suePersonal.genEntidades and 
			SDI.Importe_Id = 2 and 
			sueLiquidacion.FechaFinal between  SDI.Fecha_Desde and SDI.Fecha_Hasta
left join sueLiqPersImportes  AS SD ON SD.Legajo = suePersonal.genEntidades and 
			SD.Importe_Id = 1 and 
			sueLiquidacion.FechaFinal between  SD.Fecha_Desde and SD.Fecha_Hasta

inner join suePersSucursal ON suePersSucursal.Legajo = suePersonal.genEntidades and 
	sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde And suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr on 
	genSucursalesEmpr.genSucursalesEmpr =  suePersSucursal.Sucursal
INNER JOIN genProvincias on genProvincias.genProvincias = genSucursalesEmpr.Provincia_Id
Where
	sueliquidacion.sueliquidacion = @psueliquidacion 


-- Percepciones

SELECT 
	sum(case when sueTerminada.Importe*sueTerminada.signo > 0  and 
		sueConceptos.TipoPercepcion not in ('022','023','025', '039','044')
		then sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalSueldos,
	sum(case when sueTerminada.Importe*sueTerminada.signo > 0 And  
		sueConceptos.TipoPercepcion in ('022','023','025')
		then sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalSeparacionIndemnizacion ,
	sum(case when sueTerminada.Importe*sueTerminada.signo > 0 And  
		sueConceptos.TipoPercepcion in ('039','044')
		then sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalJubilacionPensionRetiro ,
sum(case when sueTerminada.Importe*sueTerminada.signo > 0 And  
		sueConceptos.EsExento = 0 
		then sueTerminada.Importe*sueTerminada.signo else 0 end ) 	TotalGravado ,
sum(case when sueTerminada.Importe*sueTerminada.signo > 0 And  
		sueConceptos.EsExento = 1 
		then sueTerminada.Importe*sueTerminada.signo else 0 end ) 	TotalExento

FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueConceptos.TipoPercepcion IS NOT NULL  and
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo

-- Percepcion

SELECT sueConceptos.TipoPercepcion, sueConceptos.Concepto_id, 
	sueConceptos.Descripcion as Concepto, 
	case when sueConceptos.EsExento = 0 then sueTerminada.Importe*sueTerminada.Signo else 0 end ImporteGravado ,
	case when sueConceptos.EsExento = 1 then sueTerminada.Importe*sueTerminada.Signo else 0 end ImporteExento 
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueTerminada.Importe*sueTerminada.Signo >0 and 
	sueConceptos.TipoPercepcion IS NOT NULL AND 
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo


-- Horas Extas

SELECT sueConceptos.Concepto_id, 
		case when sueTerminada.Dato2 >0 then sueTerminada.Dato2 else  DATEDIFF(dd, sueLiquidacion.FechaInicial, sueliquidacion.FechaFinal) end 	Dias,
		CASE sueConceptos.TipoHora	
			WHEN 'D' THEN '01' 
			WHEN 'T' THEN '02' 
			ELSE '03' END TipoHoras,
		sueTerminada.Dato HorasExtras,
		sueTerminada.Importe ImportePagado
	
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
Where
	sueConceptos.TipoPercepcion = '019' AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo


-- TODO jUBILACION PENSION Y RETIRO
SELECT 0 AS TotalUnaExhibicion , 0 as TotalParcialidad , 0 as MontoDiario,
	0 as IngresoAcumulable , 0 as IngresoNoAcumulable 
	WHERE 1 = 2

-- EL SUELDO MENSUAL PARA KLOEME ES DIRECTO LOS OTROS SERIA POR 30?
-- SEPARACIONES E INDEMNIZACION
SELECT SUM(sueTerminada.Importe*sueTerminada.Signo)  TotalPagado , 
	datediff(yy, suePersonal.FechaIngreso, sueLiquidacion.FechaFinal) AS NumAnosServicio, 
	ISNULL(SD.Valor,0) as UltimoSueldoMensOrd , 
	SUM(case when sueConceptos.EsExento = 0 then sueTerminada.Importe*sueTerminada.Signo else 0 end) as IngresoAcumulable,
	SUM(case when sueConceptos.EsExento = 1 then sueTerminada.Importe*sueTerminada.Signo else 0 end) as IngresoNoAcumulable
	FROM sueliquidacion INNER JOIN sueTerminada ON 
	sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
	INNER JOIN sueConceptos ON
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
	inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
	left join sueLiqPersImportes  AS SD ON SD.Legajo = suePersonal.genEntidades and 
			SD.Importe_Id = 1 and 
			sueLiquidacion.FechaFinal between  SD.Fecha_Desde and SD.Fecha_Hasta

Where
	sueTerminada.Importe*sueTerminada.Signo >0 and 
	sueConceptos.TipoPercepcion  in ('022','023','025') AND
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo
group by SD.Valor	, suePersonal.FechaIngreso, sueLiquidacion.FechaFinal

	


-- Deducciones
SELECT 
	sum(case when sueTerminada.Importe*sueTerminada.signo < 0  and
		sueConceptos.TipoDeduccion != '002' 
		then -sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalOtrasDeducciones ,
	sum(case when sueTerminada.Importe*sueTerminada.signo < 0  and
		sueConceptos.TipoDeduccion = '002' 
		then -sueTerminada.Importe*sueTerminada.signo else 0 end ) TotalImpuestosRetenidos

FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueConceptos.TipoDeduccion IS NOT NULL  and
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo



-- Deduccion

SELECT sueConceptos.TipoDeduccion , sueConceptos.Concepto_id, 
	sueConceptos.Descripcion as Concepto, 
	-sueTerminada.Importe*sueTerminada.Signo Importe
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueTerminada.Importe*sueTerminada.Signo < 0 AND
	sueConceptos.TipoDeduccion IS NOT NULL AND 
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo


-- INCAPACIDADES

SELECT sueConceptos.TipoIncapacidad , sueConceptos.Concepto_id, 
	sueConceptos.Descripcion as Concepto, 
	sueTerminada.Dato as DiasIncapacidad ,
	Abs(sueTerminada.Importe*sueTerminada.Signo) ImporteMonetario 
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueConceptos.TipoIncapacidad IS NOT NULL AND 
	sueConceptos.TipoIncapacidad != 0 and 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo

-- Otros Pagos

SELECT 
	sum(sueTerminada.Importe*sueTerminada.signo) TotalOtros
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueConceptos.signo != 0 and 
	sueConceptos.TipoOtro IS NOT NULL  and
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo

-- Otros Pago
SELECT sueConceptos.TipoOtro TipoOtroPago  , sueConceptos.Concepto_id, 
	sueConceptos.Descripcion as Concepto, 
	sueTerminada.Importe*sueTerminada.Signo Importe
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueConceptos.signo != 0 and 
	sueConceptos.TipoOtro IS NOT NULL AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo

-- SubSidio al Empleo
SELECT 	sum(sueTerminada.Importe) SubsidioCausado
FROM sueliquidacion INNER JOIN sueTerminada ON 
sueTerminada.sueliquidacion = sueliquidacion.sueliquidacion
INNER JOIN sueConceptos ON
sueConceptos.sueConceptos = sueTerminada.Concepto_Id
INNER JOIN suePersonal ON suePersonal.genEntidades = sueTerminada.Legajo
inner join conAsientos ON 
	conAsientos.conAsientos =  sueliquidacion.sueliquidacion
Where
	sueConceptos.signo = 0 and 
	sueConceptos.TipoOtro = '002'  and
	conAsientos.Anulado = 0 AND 
	sueliquidacion.sueliquidacion = @psueliquidacion and 
	suePersonal.Legajo = @Legajo


-- compensacion Saldo a Favor
select sueConceptos.Concepto_Id, 
	sueTerminada.Importe  as SaldoAFavor, 
	ISNULL(sueTerminadaRetro.AnioRetro , CASE WHEN sueLiquidacion.MES=12 THEN sueLiquidacion.Anio else
		sueLiquidacion.Anio-1 end) as AnioRetro,
	sueTerminada.Importe*0 as RemanenteSalFav
from sueTerminada 
	INNER JOIN sueLiquidacion ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
	LEFT JOIN  sueTerminadaRetro ON 
	sueTerminadaRetro.sueliquidacion =sueTerminada.sueLiquidacion and 
	sueTerminadaRetro.Concepto_Id = sueTerminada.Concepto_Id and 
	sueTerminadaRetro.Legajo = sueTerminada.Legajo
	INNER JOIN suePersonal ON  suePersonal.genEntidades = sueTerminada.sueLiquidacion 
	INNER JOIN sueConceptos ON sueConceptos.sueConceptos = sueTerminada.Concepto_Id
	Where
		suePersonal.Legajo = @Legajo and 
		sueTerminada.sueLiquidacion = @pSueliquidacion and 
		sueConceptos.TipoOtro = '004'

GO

