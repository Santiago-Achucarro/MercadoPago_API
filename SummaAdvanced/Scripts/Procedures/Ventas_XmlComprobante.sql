-- venCondPago - TipoFiscal
-- genSucursalesEmpr.CodigoPostal
-- conAsientos - Sucursal y genEntidad
-- Tabla venMovimientosMetodoPago
--set transaction isolation level read uncommitted
-- Ventas_XmlComprobante 20457, 'F'

DROP PROCEDURE Ventas_XmlComprobante
GO
CREATE PROCEDURE Ventas_XmlComprobante(	
	@Asiento_Id BigInt,
	@TipoPrecio Char(1)
)

as
DECLARE @Empresa_Id INT

SET @Empresa_Id = (Select Empresa_Id from conAsientos Where conAsientos.conAsientos= @Asiento_Id)
-- Comprobante
SELECT '3.3' as Version, conAsientos.conAsientos Asiento_Id, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	 conAsientos.Fecha , conAsientos.FechaRegistro ,
	 case when venMovimientos.Importe=0 THEN ' ' ELSE
		ISNULL(venMovimientosMetodoPago.nMetodoPago,' ')  END MetodoPago, 
		ISNULL(venMovimientosFiscal.NoCertificadoPropio,(SELECT cValor FROM genGlobales WHERE NOMBRE_VAR = 'VENNOCERTIFICADO' and Empresa_Id=@Empresa_Id)) AS NoCertificado, 
		convert(VarChar(max),(SELECT mValor FROM genGlobales where Nombre_var = 'GENWSAAPUBLICKEY' and Empresa_Id=@Empresa_Id)) AS Certificado,
		venCondPago.descripcion as CondicionesDePago, 
		venMovimientos.Importe - 
			isnull((SELECT SUM(venMovImpuestos.Importe) from venMovImpuestos 
				WHERE 
				venMovimientos.venMovimientos = venMovImpuestos.venMovimientos),0) as SubTotal,
		Convert(Numeric(18,2) , 0) as Descuento, 		
		genMonedas.CodigoFiscal as Moneda, genMonedas.Descripcion as DescripcionMoneda, 
		genMonedas.Moneda_Id,
		venMovimientos.Importe as Total,
		conAsientos.Cambio as TipoCambio,
		case when venMovimientos.Importe = 0 THEN 'T' ELSE
		case when venTipoMov.Signo = 1 Then 
		'I' ELSE 'E' end END as TipoDeComprobante, 
		ISNULL(venMovimientosMetodoPago.MetodoPago,'99') as  FormaPago, 
		genSucursalesEmpr.CodigoPostal as LugarExpedicion, ' ' Confirmacion, 
		venMovimientos.venMovimientos
from venMovimientos INNER JOIN conAsientos ON
venMovimientos.venMovimientos = conAsientos.conAsientos
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
LEFT OUTER JOIN  venCondPago ON
venCondPago.venCondPago = venMovimientos.CondPagoCli_id
left OUTER JOIN venMovimientosFiscal ON 
venMovimientos.venMovimientos =  venMovimientosFiscal.venMovimientos 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conAsientos.Moneda_Id
left JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipomov = venMovimientos.venTipomov
left outer JOIN venMovimientosMetodoPago ON
venMovimientos.venMovimientos =  venMovimientosMetodoPago.venMovimientos
LEFT OUTER JOIN genSucursalesEmpr ON
conAsientos.Sucursal = genSucursalesEmpr.genSucursalesEmpr
Where
venMovimientos.venMovimientos = @Asiento_Id


-- CFDI Relacionados
SELECT DISTINCT TipoRelacion FROM venMovimientosCFDIR 
	where 
	venMovimientosCFDIR.venMovimientos =  @Asiento_Id
	

-- CFDI RELACIONADO
SELECT TipoRelacion, venMovimientosFiscal.ClaveFiscal UUID 
FROM venMovimientosCFDIR INNER JOIN venMovimientosFiscal ON
	venMovimientosCFDIR.venMovimientosR = venMovimientosFiscal.venMovimientos
	Where 
	venMovimientosCFDIR.venMovimientos = @Asiento_Id

-- Emisor

SELECT 
genEmpresas.Cuit AS Rfc,
genEmpresas.RazonSocial AS Nombre,
genEmpresas.Regimen AS RegimenFiscal,
Convert(VarChar(max),(select mValor from genGlobales where Nombre_var = 'GENWSAAPRIVATEKEY' and Empresa_Id=@Empresa_Id)) AS EmpPrivateKey,
genEmpresas.Calle,
genEmpresas.NoExterior,
genEmpresas.NoInterior,
genEmpresas.CodColonia Colonia,
genEmpresas.CodLocalidad Localidad,
genEmpresas.CodMunicipio Municipio,
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
conAsientos.conAsientos = @Asiento_Id

-- Receptor
SELECT genEntidades.CUIT AS Rfc, 
	CASE WHEN genEntidades.CUIT = 'XAXX010101000' THEN 'PUBLICO EN GENERAL' ELSE venClientes.RazonSocial END as Nombre, 
	ISNULL(genPaises.CodFiscal,'MX') AS ResidenciaFiscal,
	ISNULL(venMovimientosExpMX.receptornumregidtrib,' ') AS NumRegIdTrib,
	-- ' ' AS NumRegIdTrib,
	isnull(venMovimientosMetodoPago.UsoCfdi, ' ') as UsoCfdi, 
	venClieHabitual.Direccion1_Fact Calle , venClieHabitual.NroExterior_Fact NroExterior, 
	venClieHabitual.NroInterior_Fact NroInterior, venClieHabitual.Direccion2_Fact Colonia,
	venClieHabitual.Localidad_Fact AS Localidad,
	genProvincias.CodFiscal as Provincia, genPaises.CodFiscal as Pais, 
	CASE WHEN genEntidades.CUIT = 'XAXX010101000' THEN genSucursalesEmpr.CodigoPostal ELSE  venClieHabitual.CodPostal_Fact END as CodigoPostal, 
	venClientes.Regimen RegimenFiscalReceptor,
	venCondFiscal.CodigoFiscal as ObjetoImp
from venClientes INNER JOIN venMovimientos ON	
venClientes.genEntidades = venMovimientos.Cliente_id
INNER JOIN genEntidades ON
genEntidades.genEntidades = venMovimientos.Cliente_id
INNER JOIN venClieHabitual ON 
venMovimientos.Cliente_id = venClieHabitual.genEntidades and 
venMovimientos.Sucursal = venClieHabitual.Sucursal
INNER JOIN genPaises ON 
venClieHabitual.Pais_id_Fact = genPaises.genPaises
LEFT OUTER JOIN venMovimientosExpMX ON
venMovimientos.venMovimientos =  venMovimientosExpMX.venMovimientos 
LEFT JOIN venSubTipomov ON 
venSubTipomov.venSubTipomov = venMovimientos.venSubTipomov_id
INNER JOIN genProvincias ON
genProvincias.genProvincias = venClieHabitual.Provincia_id_Fact
INNER JOIN venMovimientosMetodoPago ON
venMovimientosMetodoPago.venMovimientos = venMovimientos.venMovimientos
inner join venCondFiscal ON venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
INNER JOIN conasientos ON  conasientos.conasientos = venMovimientos.venMovimientos
INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Where
venMovimientos.venMovimientos = @Asiento_Id
union all -- Cambio de Almacen es el mismo que el Emisor
Select genEmpresas.Cuit AS Rfc,
genEmpresas.RazonSocial AS Nombre,
ISNULL(genPaises.CodFiscal,'MEX') AS ResidenciaFiscal,
' ' AS NumRegIdTrib,
'P01' as UsoCfdi,
genEmpresas.Calle,
genEmpresas.NoExterior,
genEmpresas.NoInterior,
genEmpresas.Colonia Colonia,
genEmpresas.Localidad Localidad,
genProvincias.CodFiscal AS Provincia,
genPaises.CodFiscal AS Pais,
genEmpresas.CodigoPostal, genEmpresas.Regimen RegimenFiscalReceptor, 
venCondFiscal.CodigoFiscal as ObjetoImp
from genEmpresas inner join conAsientos ON 
genEmpresas.genEmpresas = conAsientos.Empresa_Id 
LEFT OUTER JOIN genProvincias ON 
genEmpresas.Provincia_Id =genProvincias.genProvincias
LEFT OUTER JOIN genPaises ON 
genPaises.genPaises = genEmpresas.Pais_Id
inner join venMovimientos ON  venMovimientos.venMovimientos = conAsientos.conAsientos
left join venCondFiscal ON venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
Where
conAsientos.conAsientos = @Asiento_Id AND venMovimientos.Cliente_Id is null


-- Concepto

SELECT venMovConStockCr.RenglonCuerpo as Renglon, 
	isNull(stkProductos.CodigoFiscal, ' ') as ClaveProdServ,
	stkProductos.Producto_id as NoIdentificacion, 
	case when @TipoPrecio= 'F' THEN 
	venMovConStockCr.CantOriginal ELSE
		venMovConStockCr.CantFacturada END AS Cantidad,
	ISNULL(case when @TipoPrecio= 'F' THEN 
		MO.CodigoFiscal
		ELSE
		MP.CodigoFiscal END,' ') AS ClaveUnidad,

	case when @TipoPrecio= 'F' THEN 
		MO.Medida_id
		ELSE
		MP.Medida_id END as Unidad,
	stkProductos.Descripcion, 			
	case when @TipoPrecio= 'F' THEN 
		venMovConStockCr.PrecioVenta * venMovConStockCr.Factor
	ELSE
		venMovConStockCr.PrecioVenta END AS ValorUnitario,
	venMovConStockCr.PrecioVenta * venMovConStockCr.CantFacturada as Importe, 
	Convert(Numeric(18,2) , 0) as Descuento	
FROM venMovConStockCr INNER JOIN stkProductos ON		
venMovConStockCr.Producto_id = stkProductos.stkProductos
INNER JOIN stkUniMed as MO ON
MO.stkUniMed = venMovConStockCr.Medida_id 
INNER JOIN stkUniMed as MP ON
MP.stkUniMed = stkProductos.Medida_Id
WHERE
venMovConStockCr.venMovimientos = @Asiento_Id
UNION ALL 
SELECT venMovDetalle.conRenglon as Renglon, 
	isNull(venMovDetalle.CodigoFiscal, ' ') as ClaveProdServ,
	venMovDetalle.Producto_Id as NoIdentificacion, 
	venMovDetalle.Cantidad,
	MO.CodigoFiscal  AS ClaveUnidad,
	MO.Medida_id as Unidad,
	venMovDetalle.Detalle, 			
	venMovDetalle.ImporteUnitario ValorUnitario,
	venMovDetalle.ImporteUnitario*venMovDetalle.Cantidad as Importe, 
	Convert(Numeric(18,2) , 0) as Descuento	
FROM venMovDetalle INNER JOIN stkUniMed as MO ON
MO.stkUniMed =  venMovDetalle.Medida_id
WHERE
venMovDetalle.venMovimientos = @Asiento_Id 
UNION ALL -- REMITOS
SELECT stkMoviCuerpo.Renglon as Renglon, 
	isNull(stkProductos.CodigoFiscal, ' ') as ClaveProdServ,
	stkProductos.Producto_id as NoIdentificacion, 
	case when @TipoPrecio= 'F' THEN 
	stkMoviCuerpo.CantidadForm ELSE
		stkMoviCuerpo.Cantidad END AS Cantidad,
	ISNULL(case when @TipoPrecio= 'F' THEN 
		MO.CodigoFiscal
		ELSE
		MP.CodigoFiscal END,' ') AS ClaveUnidad,

	case when @TipoPrecio= 'F' THEN 
		MO.Medida_id
		ELSE
		MP.Medida_id END as Unidad,
	stkProductos.Descripcion, 			
	0 AS ValorUnitario,
	0 as Importe, 
	Convert(Numeric(18,2) , 0) as Descuento	
FROM stkMoviCuerpo INNER JOIN stkProductos ON		
stkMoviCuerpo.Producto_id = stkProductos.stkProductos
INNER JOIN stkUniMed as MO ON
MO.stkUniMed = stkMoviCuerpo.Medida_id 
INNER JOIN stkUniMed as MP ON
MP.stkUniMed = stkProductos.Medida_Id
WHERE
stkMoviCuerpo.stkMoviCabe = @Asiento_Id
UNION ALL
--- CARTA PORTE M
SELECT venCompCartaPorteMercancia.Renglon as Renglon, 
	isNull(venCompCartaPorteMercancia.BienesTransp, ' ') as ClaveProdServ,
	' ' as NoIdentificacion, 
	venCompCartaPorteMercancia.Cantidad,
	MO.CodigoFiscal AS ClaveUnidad,
	MO.Medida_Id Unidad,
	venCompCartaPorteMercancia.Descripcion, 			
	0.00 AS ValorUnitario,
	0.00 as Importe, 
	Convert(Numeric(18,2) , 0) as Descuento	
FROM venCompCartaPorteMercancia 
INNER JOIN stkUniMed as MO ON
MO.stkUniMed = venCompCartaPorteMercancia.Medida_id 
INNER JOIN venMovimientos ON  venMovimientos.venMovimientos =venCompCartaPorteMercancia.venmovimientos
WHERE
venCompCartaPorteMercancia.venMovimientos = @Asiento_Id and 
venMovimientos.venTipoMov = 'M' 
ORDER BY 1

-- Pedimentos
SELECT venMovConStockCr.RenglonCuerpo as Renglon, 
ISNULL(comDespachos.Anio,'XX') + '  ' + ltrim(ISNULL(comDespachos.Aduana_id,'XX'))+'  '+
		ltrim(ISNULL(comDespachos.Patente,'XXXX'))	+ '  ' +
		left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) as NroPedimento, 
			comDespachos.Despacho_Id
From venMovConStockCr inner join venMovStkHist ON
venMovConStockCr.venMovimientos =  venMovStkHist.venMovimientos and 
venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo
INNER JOIN stkMoviDespa ON
stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe and 
stkMoviDespa.Renglon  = venMovStkHist.Renglon
INNER JOIN comDespachos ON 
comDespachos.comDespachos = stkMoviDespa.Despacho_Id
WHERE
venMovConStockCr.venMovimientos = @Asiento_id and 
comDespachos.Pedimento > 0
union all
SELECT stkMoviCuerpo.Renglon, 
ISNULL(comDespachos.Anio,'XX') + '  ' + ltrim(ISNULL(comDespachos.Aduana_id,'XX'))+'  '+
		ltrim(ISNULL(comDespachos.Patente,'XXXX'))	+ '  ' +
		left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) as NroPedimento, 
			comDespachos.Despacho_Id
From stkMoviCuerpo 
INNER JOIN stkMoviDespa ON
stkMoviDespa.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
stkMoviDespa.Renglon  = stkMoviCuerpo.Renglon
INNER JOIN comDespachos ON 
comDespachos.comDespachos = stkMoviDespa.Despacho_Id
WHERE
stkMoviCuerpo.stkMoviCabe = @Asiento_id and 
comDespachos.Pedimento > 0
ORDER BY 1

-- Cuenta Predial

SELECT venMoviPredial.conRenglon as Renglon ,  
	venMoviPredial.CuentaPredial
From venMoviPredial 
WHERE
venMoviPredial.venMovimientos = @Asiento_Id


-- Rentencion Prod
select venMovCSImpuestos.RenglonCuerpo as Renglon, venMovCSImpuestos.BaseImponible Base, 
	impTipoImpuesto.Referencia02 Impuesto, 
	case when impTipoImpuesto.CodigoFiscal ='E1' THEN 'Cuota' else 'Tasa' END TipoFactor, 
	abs(venMovCSImpuestos.Porcentaje/100) TasaOCuota, 
	-venMovCSImpuestos.Importe as Importe
From venMovCSImpuestos INNER JOIN venImpuestos ON
venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE
venMovCSImpuestos.Importe < 0 and 
venMovCSImpuestos.venMovimientos =@Asiento_id
UNION ALL
select venMovSSImpuestos.conRenglon as Renglon, venMovSSImpuestos.BaseImponible Base, 
	impTipoImpuesto.Referencia02 Impuesto, 
	case when impTipoImpuesto.CodigoFiscal='E1' THEN 'Cuota' else 'Tasa' END TipoFactor, 
	abs(venMovSSImpuestos.Porcentaje/100) TasaOCuota, 
	-venMovSSImpuestos.Importe as Importe
From venMovSSImpuestos INNER JOIN venImpuestos ON
venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE
venMovSSImpuestos.Importe < 0 and 
venMovSSImpuestos.venMovimientos = @Asiento_ID
ORDER BY 1

-- Traslados Prod
select venMovCSImpuestos.RenglonCuerpo as Renglon, venMovCSImpuestos.BaseImponible Base, 
	impTipoImpuesto.Referencia02 Impuesto, 
	case when impTipoImpuesto.CodigoFiscal ='E1' THEN 'Cuota' else 'Tasa' END TipoFactor, 
	abs(venMovCSImpuestos.Porcentaje/100) TasaOCuota, 
	venMovCSImpuestos.Importe as Importe
From venMovCSImpuestos INNER JOIN venImpuestos ON
venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE
venMovCSImpuestos.Importe >= 0 and 
venMovCSImpuestos.venMovimientos =@Asiento_id
UNION ALL
select venMovSSImpuestos.conRenglon as Renglon, venMovSSImpuestos.BaseImponible Base, 
	impTipoImpuesto.Referencia02 Impuesto, 
	case when impTipoImpuesto.CodigoFiscal='E1' THEN 'Cuota' else 'Tasa' END TipoFactor, 
	abs(venMovSSImpuestos.Porcentaje/100) TasaOCuota, 
	venMovSSImpuestos.Importe as Importe
From venMovSSImpuestos INNER JOIN venImpuestos ON
venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE
venMovSSImpuestos.Importe >= 0 and 
venMovSSImpuestos.venMovimientos = @Asiento_ID
ORDER BY 1



-- Impuestos
SELECT 
 isnull(sum(case when venMovimpuestos.Importe>=0 then venMovimpuestos.Importe else 0 end ),0) as TotalimpuestosTraslados,
 isnull(sum(case when venMovimpuestos.Importe<0 then -venMovimpuestos.Importe else 0 end ),0) as TotalimpuestosRetenciones
From venMovImpuestos 
WHERE
venMovImpuestos.VenMovimientos = @Asiento_Id

-- Traslado
SELECT impTipoImpuesto.Referencia02 as Impuesto, 
	case when impTipoImpuesto.CodigoFiscal='E1' THEN 'Cuota' else 'Tasa' END TipoFactor, 
	ABS(venMovImpuestos.Porcentaje/100) TasaOCuota, 
	venMovImpuestos.Importe 
From venMovImpuestos INNER JOIN venImpuestos ON
venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE
venMovimpuestos.Importe>=0 and 
venMovImpuestos.venMovimientos = @Asiento_Id
 
-- Retencion
SELECT impTipoImpuesto.Referencia02 as Impuesto, 
	case when impTipoImpuesto.CodigoFiscal='E1' THEN 'Cuota' else 'Tasa' END TipoFactor, 
	ABS(venMovImpuestos.Porcentaje/100) TasaOCuota, 
	-venMovImpuestos.Importe as Importe
From venMovImpuestos INNER JOIN venImpuestos ON
venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
WHERE
venMovimpuestos.Importe<0 and 
venMovImpuestos.venMovimientos = @Asiento_Id
 
-- Complemento

SELECT '1.1' as Version,  venMovimientosFiscal.ClaveFiscal as UUID, 
	venMovimientosFiscal.FechaString FechaTimbrado, 
	isnull(venMovimientosFiscal.RfcProvCertif,' ') as RfcProvCertif,
	isnull(venMovimientosFiscal.Leyenda,' ') as Leyenda,
	venMovimientosFiscal.SelloDigital as SelloCFD,
	venMovimientosFiscal.NoCertificadoFiscal NoCertificadoSAT,
	venMovimientosFiscal.SelloFiscal SelloSAT
FROM venMovimientosFiscal
WHERE
venMovimientosFiscal.venMovimientos = @Asiento_Id

-- Complemento INE

SELECT TipoProceso, TipoComite, idContabilidad FROM venMovimientosFiscal
WHERE
TipoProceso IS NOT NULL AND 
venMovimientosFiscal.venMovimientos = @Asiento_Id

SELECT Ambito, ClaveIdentidad , idContabilidad 
FROM venMovimientosFiscalINE
WHERE
venMovimientosFiscalINE.venMovimientos = @Asiento_Id
ORDER BY 2,1

-- Complemento Exportaciones

select venMovimientosExpMX.Motivo_id, 
	case when venMovimientosExpMX.TipoOperacion='B' THEN '2' ELSE venMovimientosExpMX.TipoOperacion END AS TipoOperacion, 
	venMovimientosExpMX.ClaveDePedimento, 
	venMovimientosExpMX.CertificadoOrigen, venMovimientosExpMX.NumeroExportadorConfiable, 
	venIncoterm.Incoterm_id as Incoterm, venMovimientosExpMX.Subdivision, venMovimientosExpMX.Observaciones, 
	venMovimientosExpMX.TipoCambioUSD, venMovimientosExpMX.TotalUSD, venMovimientosExpMX.UsaProv, 
	venMovimientosExpMX.PropNumRegIdTrib, venMovimientosExpMX.PropResidenciaFiscal, 
	venMovimientosExpMX.ReceptorNumRegIdTrib, venMovimientosExpMX.Destinatario_id, venMovimientosExpMX.SucursalDest,
	venClientes.RazonSocial,
	venClieHabitual.Direccion1_Fact Calle , venClieHabitual.NroExterior_Fact NroExterior, 
	venClieHabitual.NroInterior_Fact NroInterior, venClieHabitual.Direccion2_Fact Colonia,
	venClieHabitual.Localidad_Fact AS Localidad,
	genProvincias.CodFiscal as Provincia, genPaises.CodFiscal as Pais, 
	venClieHabitual.CodPostal_Fact as CodigoPostal, venMovimientosExpMX.ReceptorNumRegIdTrib AS NumRegIdTrib
from venMovimientosExpMX LEFT OUTER JOIN 
	(venClieHabitual INNER JOIN genPaises ON
		venClieHabitual.Pais_id_Fact = genPaises.genPaises
		inner join genProvincias ON
			genProvincias.genProvincias = venClieHabitual.Provincia_id_Fact 
			INNER JOIN venClientes ON 
			venClientes.genEntidades = venClieHabitual.genEntidades  ) ON
		venClieHabitual.genEntidades  =venMovimientosExpMX.Destinatario_id and 
		venClieHabitual.Sucursal = venMovimientosExpMX.SucursalDest
		INNER JOIN venMovimientos ON 
		venMovimientos.venMovimientos = venMovimientosExpMX.venMovimientos
		INNER JOIN venIncoterm ON
		venIncoterm.venIncoterm_int =  venMovimientos.Incoterm_Id
WHERE
venMovimientosExpMX.venMovimientos = @Asiento_Id

SELECT venMovConStockCr.RenglonCuerpo venRenglon, stkProductos.Producto_id as NoIdentificacion,
	convert(numeric(18,3),isnull(CantidadAduana, venMovConStockCr.CantOriginal)* ISNULL(genAtributosValores.Valorn,1)) as CantidadAduana , 
	isnull(UnidadAduana, stkUniMed.UniExpor) as UnidadAduana , 
	Convert(numeric(18,2),venMovConStockCr.PrecioVenta*venMovConStockCr.CantFacturada/venMovConStockCr.CantOriginal
		/ ISNULL(genAtributosValores.Valorn,1)) as ValorUnitarioAduana ,
	 isnull(ValorDolares , venMovConStockCr.PrecioVenta * venMovConStockCr.CantFacturada ) ValorDolares, 
	 stkProductos.FraccionArancelaria
FROM  venMovConStockCr left outer join venMovimientosCRExpMX ON
venMovimientosCRExpMX.VenMovimientos = venMovConStockCr.venMovimientos and 
venMovimientosCRExpMX.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
INNER JOIN venMovimientosExpMX ON
venMovimientosExpMX.venMovimientos =venMovConStockCr.venMovimientos 
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = venMovConStockCr.Medida_id
INNER JOIN stkProductos ON
stkProductos.stkProductos = venMovConStockCr.Producto_id
LEFT JOIN genAtributosValores ON 
genAtributosValores.Tabla_Id = 'stkProductos' and 
genAtributosValores.Identity_Id = stkProductos.stkProductos and 
genAtributosValores.AtributoNro = 5
WHERE
venMovConStockCr.venMovimientos = @Asiento_ID
order by 1


--- Complemento Carta Porte

SELECT TranspInternac, EntradaSalidaMerc, ViaEntradaSalida, TotalDistRec, 
	PesoBrutoTotal, UnidadPeso, PesoNetoTotal, CargoPorTasacion, 
	venCamiones.Patente_Id, venCamiones.Descripcion, venCamiones.Modelo, venCamiones.ConfVehicular,
	venCamiones.Marca, 	venCamiones.NroPoliza,  venCamiones.NombreAseg, venCamiones.TipoPermisoSCT, venCamiones.NroPermisoSCT,
	venCamiones.AseguraMedAmb, venCamiones.PolizaMedAmbiente, 
	venCamiones.AseguraCarga, venCamiones.PolizaCarga, venCamiones.PrimaSeguro,
	Remolque1.Patente_Id PatenteR1, Remolque1.Descripcion DescripcionR1, Remolque1.Modelo ModeloR1, Remolque1.ConfVehicular ConfVehicularR1 ,
	Remolque1.Marca MarcaR1, 	Remolque1.NroPoliza NroPolizaR1,  Remolque1.NombreAseg NombreAsegR1, 
	Remolque1.TipoPermisoSCT TipoPermisoSCTR1, Remolque1.NroPermisoSCT NroPermisoSCTR1,
	Remolque1.AseguraMedAmb AseguraMedAmbR1, Remolque1.PolizaMedAmbiente PolizaMedAmbienteR1, 
	Remolque1.AseguraCarga AseguraCargaR1, Remolque1.PolizaCarga PolizaCargaR1, Remolque1.PrimaSeguro PrimaSeguroR1,
	Remolque2.Patente_Id PatenteR2, Remolque2.Descripcion DescripcionR2, Remolque2.Modelo ModeloR2, Remolque2.ConfVehicular ConfVehicularR2 ,
	Remolque2.Marca MarcaR2, 	Remolque2.NroPoliza NroPolizaR2,  Remolque2.NombreAseg NombreAsegR2 , 
	Remolque2.TipoPermisoSCT TipoPermisoSCTR2, Remolque1.NroPermisoSCT NroPermisoSCTR2,
	Remolque2.AseguraMedAmb AseguraMedAmbR2, Remolque2.PolizaMedAmbiente PolizaMedAmbienteR2, 
	Remolque2.AseguraCarga AseguraCargaR2, Remolque1.PolizaCarga PolizaCargaR2, Remolque1.PrimaSeguro PrimaSeguroR2
	FROM venCompCartaPorte
	left join venCamiones on venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	left join venCamiones Remolque1 on Remolque1.venCamiones = venCompCartaPorte.Remolque1
	left join venCamiones Remolque2 on Remolque2.venCamiones = venCompCartaPorte.Remolque2
WHERE
venCompCartaPorte.venMovimientos = @Asiento_ID
order by 1


SELECT venCompCartaPorteUbi.Ubicacion, venCompCartaPorteUbi.TipoEstacion, 
	case when venCompCartaPorteUbi.TipoEstacion ='01' then 0 else venCompCartaPorteUbi.DistanciaRecorrida end DistanciaRecorrida
	FROM venCompCartaPorteUbi
WHERE
venCompCartaPorteUbi.venMovimientos = @Asiento_ID
order by 1


select venCompCartaPorteOrigen.Ubicacion, venCompCartaPorteOrigen.idOrigen, venCompCartaPorteOrigen.RFCRemitente,
	venCompCartaPorteOrigen.NombreRemitente, venCompCartaPorteOrigen.NumRegIdTrib, genPaisesR.CodFiscal ResidenciaFiscal,
	venCompCartaPorteOrigen.NumEstacion, venCompCartaPorteOrigen.NombreEstacion, venCompCartaPorteOrigen.NavegacionTrafico,
	venCompCartaPorteOrigen.FechaHoraSalida, venCompCartaPorteOrigen.Calle, venCompCartaPorteOrigen.NumeroExterior, 
	venCompCartaPorteOrigen.Numerointerior,venCompCartaPorteOrigen.Colonia, venCompCartaPorteOrigen.Localidad,
	venCompCartaPorteOrigen.Referencia, venCompCartaPorteOrigen.Municipio, 
	isnull(genProvincias.CodFiscal, venCompCartaPorteOrigen.Estado) Estado,
	genPaises.CodFiscal Pais, venCompCartaPorteOrigen.CodigoPostal
	FROM venCompCartaPorteOrigen
	LEFT JOIN genPaises genPaisesR ON genPaisesR.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
	left join genProvincias ON  genProvincias.Provincia_Id = venCompCartaPorteOrigen.Estado
	INNER JOIN genPaises on  genPaises.genPaises =venCompCartaPorteOrigen.Pais
WHERE
venCompCartaPorteOrigen.venMovimientos = @Asiento_ID
order by 1


select venCompCartaPorteDestino.Ubicacion, venCompCartaPorteDestino.idDestino, venCompCartaPorteDestino.RFCDestinatario,
	venCompCartaPorteDestino.NombreDestinatario, venCompCartaPorteDestino.NumRegIdTrib, genPaises.CodFiscal ResidenciaFiscal,
	venCompCartaPorteDestino.NumEstacion, venCompCartaPorteDestino.NombreEstacion, venCompCartaPorteDestino.NavegacionTrafico,
	venCompCartaPorteDestino.FechaHoraProgLlegada, venCompCartaPorteDestino.Calle, venCompCartaPorteDestino.NumeroExterior, 
	venCompCartaPorteDestino.Numerointerior,venCompCartaPorteDestino.Colonia, venCompCartaPorteDestino.Localidad,
	venCompCartaPorteDestino.Referencia, venCompCartaPorteDestino.Municipio, 
	isnull(genProvincias.CodFiscal, venCompCartaPorteDestino.Estado) Estado,
	genPaises.CodFiscal Pais, venCompCartaPorteDestino.CodigoPostal
	FROM venCompCartaPorteDestino
	LEFT JOIN genPaises genPaisesR ON genPaisesR.genPaises = venCompCartaPorteDestino.ResidenciaFiscal
	INNER JOIN genPaises on  genPaises.genPaises =venCompCartaPorteDestino.Pais
	LEFT JOIN genProvincias ON venCompCartaPorteDestino.Estado = genProvincias.Provincia_Id
WHERE
venCompCartaPorteDestino.venMovimientos = @Asiento_ID
order by 1




select venCompCartaPorteMercancia.idDestino,  venCompCartaPorteMercancia.Renglon, venCompCartaPorteMercancia.BienesTransp, venCompCartaPorteMercancia.ClaveSTCC, 
venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, stkUniMed.CodigoFiscal Medida_id, 
venCompCartaPorteMercancia.Dimensiones, 
stkUniMed.Medida_id AS Unidad,
Cast(case when venCompCartaPorteMercancia.MaterialPeligroso='Si' THEN 1 ELSE 0 END AS Bit) AS MaterialPeligroso , venCompCartaPorteMercancia.CveMaterialPeligroso, venCompCartaPorteMercancia.Embalaje,
venCompCartaPorteMercancia.DescripEmbalaje, venCompCartaPorteMercancia.PesoEnKg * venCompCartaPorteMercancia.Cantidad as PesoEnKg, venCompCartaPorteMercancia.ValorMercancia, venCompCartaPorteMercancia.FraccionArancelaria, 
venCompCartaPorteMercancia.UUIDComercioExt
FROM venCompCartaPorteMercancia
inner join stkUniMed ON  stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_Id
WHERE
	venCompCartaPorteMercancia.venmovimientos= @Asiento_Id
UNION ALL
select 1 as idDestino,   venMovConStockCr.RenglonCuerpo, stkProductos.CodigoFiscal BienesTransp, stkProductos.ClaveSTCC, 
stkProductos.Descripcion, venMovConStockCr.CantEntregada, stkUniMed.CodigoFiscal Medida_id, ' ' Dimensiones,
stkUniMed.Medida_id AS Unidad,
stkProductos.MaterialPeligroso, stkProductos.CveMaterialPeligroso, stkProductos.Embalaje,
'' DescripEmbalaje, stkProductos.PesoEnKg*venMovConStockCr.CantEntregada as PesoEnKg, 
stkProductos.CostoUltCompra * venMovConStockCr.CantEntregada ValorMercancia, stkProductos.FraccionArancelaria, 
'' UUIDComercioExt
FROM venMovConStockCr
INNER JOIN stkProductos ON  stkProductos.stkProductos = venMovConStockCr.Producto_Id
inner join stkUniMed ON  stkUniMed.stkUniMed = stkProductos.Medida_Id
WHERE
	venMovConStockCr.venmovimientos= @Asiento_Id and not exists(select 1 from venCompCartaPorteMercancia
		where venCompCartaPorteMercancia.venmovimientos =@Asiento_Id)
UNION ALL -- REMISIONES
select 1 as idDestino,   stkMoviCuerpo.Renglon, stkProductos.CodigoFiscal BienesTransp, stkProductos.ClaveSTCC, 
stkProductos.Descripcion, stkMoviCuerpo.Cantidad, stkUniMed.CodigoFiscal Medida_id, ' ' Dimensiones, 
stkUniMed.Medida_id AS Unidad,
stkProductos.MaterialPeligroso, stkProductos.CveMaterialPeligroso, stkProductos.Embalaje,
'' DescripEmbalaje, stkProductos.PesoEnKg*stkMoviCuerpo.Cantidad as PesoEnKg, 
stkProductos.CostoUltCompra * stkMoviCuerpo.Cantidad ValorMercancia, stkProductos.FraccionArancelaria, 
'' UUIDComercioExt
FROM stkMoviCuerpo
INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
inner join stkUniMed ON  stkUniMed.stkUniMed = stkProductos.Medida_Id
WHERE
	stkMoviCuerpo.stkMoviCabe= @Asiento_Id and not exists(select 1 from venCompCartaPorteMercancia
		where venCompCartaPorteMercancia.venmovimientos =@Asiento_Id)

Select venCompCartaPorteDestinatario.NumRegIdTrib, venCompCartaPorteDestinatario.Nombre,
venCompCartaPorteDestinatario.Calle, venCompCartaPorteDestinatario.NumeroExterior,
venCompCartaPorteDestinatario.Numerointerior, venCompCartaPorteDestinatario.Colonia,
venCompCartaPorteDestinatario.Localidad, venCompCartaPorteDestinatario.Referencia,
venCompCartaPorteDestinatario.Municipio, venCompCartaPorteDestinatario.Estado,
genPaises.CodFiscal Pais, venCompCartaPorteDestinatario.CodigoPostal
FROM venCompCartaPorteDestinatario
inner join genPaises ON venCompCartaPorteDestinatario.Pais = genPaises.genPaises
union all
Select genEntidades.IdFiscal NumRegIdTrib, venClientes.RazonSocial Nombre,
venClieHabitual.Direccion1_Entr Calle, venClieHabitual.NroExterior_Entr NumeroExterior,
venClieHabitual.NroInterior_Entr Numerointerior,  
case when genPaises.CodFiscal = 'MEX' THEN venClieHabitual.c_ColoniaEntr else venClieHabitual.Direccion2_Entr end Colonia,
case when genPaises.CodFiscal = 'MEX' THEN venClieHabitual.c_LocalidadEntr else venClieHabitual.Localidad_Entr end Localidad, 
' ' Referencia,
case when genPaises.CodFiscal = 'MEX' THEN venClieHabitual.c_MunicipioEntr else ' ' end Municipio, 
CASE WHEN genProvincias.CodFiscal = ' ' THEN genProvincias.Descripcion ELSE genProvincias.CodFiscal END Estado,
genPaises.CodFiscal Pais, venClieHabitual.CodPostal_Entr CodigoPostal
FROM venMovimientos 
	INNER JOIN venClientes ON  venClientes.genEntidades =venMovimientos.Cliente_Id
	INNER JOIN genEntidades ON  genEntidades.genEntidades =venClientes.genEntidades
	INNER JOIN venClieHabitual ON  venClieHabitual.genEntidades =venMovimientos.Cliente_Id AND 
		venClieHabitual.Sucursal = venMovimientos.Sucursal
	inner join genPaises ON venClieHabitual.Pais_Id_Entr = genPaises.genPaises
	inner join genProvincias ON  genProvincias.genProvincias =venClieHabitual.Provincia_Id_Entr
WHERE
	venMovimientos.venMovimientos = @Asiento_Id
	/*
union all -- remitos
Select genEntidades.IdFiscal NumRegIdTrib, venClientes.RazonSocial Nombre,
venClieHabitual.Direccion1_Entr Calle, venClieHabitual.NroExterior_Entr NumeroExterior,
venClieHabitual.NroInterior_Entr Numerointerior,  
case when genPaises.CodFiscal = 'MEX' THEN venClieHabitual.c_ColoniaEntr else venClieHabitual.Direccion2_Entr end Colonia,
case when genPaises.CodFiscal = 'MEX' THEN venClieHabitual.c_LocalidadEntr else venClieHabitual.Localidad_Entr end Localidad, 
' ' Referencia,
case when genPaises.CodFiscal = 'MEX' THEN venClieHabitual.c_MunicipioEntr else ' ' end Municipio, 
CASE WHEN genProvincias.CodFiscal = ' ' THEN genProvincias.Descripcion ELSE genProvincias.CodFiscal END Estado,
genPaises.CodFiscal Pais, venClieHabitual.CodPostal_Entr CodigoPostal
FROM stkRemitos
	INNER JOIN venClientes ON  venClientes.genEntidades =stkRemitos.Cliente_Id
	INNER JOIN genEntidades ON  genEntidades.genEntidades =venClientes.genEntidades
	INNER JOIN venClieHabitual ON  venClieHabitual.genEntidades =stkRemitos.Cliente_Id AND 
		venClieHabitual.Sucursal = stkRemitos.Sucursal
	inner join genPaises ON venClieHabitual.Pais_Id_Entr = genPaises.genPaises
	inner join genProvincias ON  genProvincias.genProvincias =venClieHabitual.Provincia_Id_Entr
WHERE
	stkRemitos.stkMoviCabe = @Asiento_Id
	*/

SELECT 	venCamiones.ConfVehicular, venPropietarioArrenda.PropArre, 
		venPropietarioArrenda.Rfc, venPropietarioArrenda.Nombre, 
			genPaises.CodFiscal ResidenciaFiscal, venPropietarioArrenda.NumRegIdTrib, 
			venPropietarioArrenda.Calle, venPropietarioArrenda.NumeroExterior, 
			venPropietarioArrenda.Numerointerior, venPropietarioArrenda.Colonia, 
			venPropietarioArrenda.Localidad, venPropietarioArrenda.Municipio, 
			venPropietarioArrenda.CodigoPostal, venPropietarioArrenda.Estado, 
			venPropietarioArrenda.Referencia, genPaisesDom.CodFiscal Pais
	FROM venCompCartaPorte
	inner join venCamiones on venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	LEFT JOIN (venPropietarioArrenda INNER JOIN genPaises ON  genPaises.genPaises= venPropietarioArrenda.ResidenciaFiscal
	inner join genPaises genPaisesDom on genPaisesDom.genPaises = venPropietarioArrenda.Pais) 	ON 
		venPropietarioArrenda.venPropietarioArrenda = venCamiones.PropArre_Id 
WHERE
venCompCartaPorte.venMovimientos = @Asiento_ID
order by 1


SELECT 		venOperadores.RfcOperador, venOperadores.NombreOperador, 
			venOperadores.NumLicencia,
			genPaises.CodFiscal ResidenciaFiscal, venOperadores.NumRegIdTribOperador, 
			venOperadores.Calle, venOperadores.NumeroExterior, 
			venOperadores.Numerointerior, venOperadores.Colonia, 
			venOperadores.Localidad, venOperadores.Municipio, 
			venOperadores.CodigoPostal, venOperadores.Estado, 
			venOperadores.Referencia, genPaisesDom.CodFiscal Pais
	FROM venCompCartaPorte
	INNER JOIN venOperadores ON venOperadores.venOperadores = venCompCartaPorte.Operador_Id
	INNER JOIN genPaises ON  genPaises.genPaises= venOperadores.ResidenciaFiscalOperador
	inner join genPaises genPaisesDom on genPaisesDom.genPaises = venOperadores.Pais
WHERE
venCompCartaPorte.venMovimientos = @Asiento_ID
order by 1


select Periodicidad, Meses , Anio 
from venMovimientosGlobal where venMovimientos = @Asiento_ID






GO
