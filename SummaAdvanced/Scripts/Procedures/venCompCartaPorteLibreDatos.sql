-- EXEC venCompCartaPorteLibreDatos 1,'FC',1,0,0,0,'M','0202','',''
Drop Procedure venCompCartaPorteLibreDatos 
GO
Create Procedure venCompCartaPorteLibreDatos (
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
as


SELECT venMovimientos.venMovimientos, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
venCompCartaPorteOrigen.FechaHoraSalida,  ' ' Archivo, ' ' NombreArchivo, ' ' Extension, 
venCamiones.Patente_Id Camion_Id, Remolque1.Patente_Id Remolque1, Remolque2.Patente_Id Remolque2, venOperadores.Operador_Id ,conAsientos.Fecha,
' ' XML

from venMovimientos 
	inner join conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =conAsientos.conAsientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	LEFT JOIN venCompCartaPorte ON venCompCartaPorte.venmovimientos = venmovimientos.venMovimientos
	LEFT JOIN venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	LEFT JOIN venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
	LEFT JOIN venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
	LEFT JOIN venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
	LEFT JOIN venCompCartaPorteDestino ON  venCompCartaPorteDestino.venmovimientos = venmovimientos.venmovimientos
	LEFT JOIN venCompCartaPorteOrigen ON  venCompCartaPorteOrigen.venmovimientos = venmovimientos.venmovimientos


WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C

-- ubicaciones
Select venCompCartaPorteUbi.venmovimientos,
	venCompCartaPorteUbi.Ubicacion, TipoEstacion, DistanciaRecorrida,
	venCompCartaPorteOrigen.RFCRemitente Rfc, venCompCartaPorteOrigen.NombreRemitente Nombre, 
	venCompCartaPorteOrigen.FechaHoraSalida FechaHora,
	venCompCartaPorteOrigen.Calle, venCompCartaPorteOrigen.NumeroExterior, 
	venCompCartaPorteOrigen.Numerointerior, venCompCartaPorteOrigen.Colonia, 
	venCompCartaPorteOrigen.Localidad, venCompCartaPorteOrigen.Municipio, 
	venCompCartaPorteOrigen.CodigoPostal,
	venCompCartaPorteOrigen.Estado, genProvincias.Descripcion DescripcionEstado,
	venCompCartaPorteOrigen.NumRegIdTrib,
	genPaises.Pais_Id, genPaises.Descripcion DescripcionPais,
	Residencia.Pais_Id ResidenciaFiscal, 
	venCompCartaPorteOrigen.Referencia, 
	' ' as Cliente_Id, 0 as Sucursal, ' ' as Mi_Sucursal, 
	' ' as Segmento_Id, ' ' Segmento1C, ' ' Segmento2C, ' ' Segmento3C, ' ' Segmento4C,
	0 Segmento1N,0 Segmento2N, 0 Segmento3N, 0 Segmento4N
From venCompCartaPorteUbi
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =venCompCartaPorteUbi.venmovimientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN venCompCartaPorteOrigen ON
		venCompCartaPorteOrigen.venmovimientos = venCompCartaPorteUbi.venmovimientos AND 
		venCompCartaPorteOrigen.idOrigen =venCompCartaPorteUbi.Ubicacion
	LEFT join genProvincias ON  genProvincias.Provincia_Id = venCompCartaPorteOrigen.Estado
	INNER JOIN genPaises ON  genPaises.genPaises = venCompCartaPorteOrigen.Pais
	INNER JOIN genPaises as Residencia ON  Residencia.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C
UNION ALL
Select venCompCartaPorteUbi.venmovimientos,
	venCompCartaPorteUbi.Ubicacion, TipoEstacion, DistanciaRecorrida,
	vencompCartaPorteDestino.RFCDestinatario Rfc, vencompCartaPorteDestino.NombreDestinatario, 
	vencompCartaPorteDestino.FechaHoraProgLlegada,
	vencompCartaPorteDestino.Calle, vencompCartaPorteDestino.NumeroExterior, 
	vencompCartaPorteDestino.Numerointerior, vencompCartaPorteDestino.Colonia, 
	vencompCartaPorteDestino.Localidad, vencompCartaPorteDestino.Municipio, 
	vencompCartaPorteDestino.CodigoPostal,
	vencompCartaPorteDestino.Estado, genProvincias.Descripcion DescripcionEstado,
	vencompCartaPorteDestino.NumRegIdTrib,
	genPaises.Pais_Id, genPaises.Descripcion DescripcionPais,
	Residencia.Pais_Id ResidenciaFiscal, vencompCartaPorteDestino.Referencia, 
	' ' as Cliente_Id, 0 as Sucursal, ' ' as Mi_Sucursal, 
	' ' as Segmento_Id, ' ' Segmento1C, ' ' Segmento2C, ' ' Segmento3C, ' ' Segmento4C,
	0 Segmento1N,0 Segmento2N, 0 Segmento3N, 0 Segmento4N
From venCompCartaPorteUbi
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =venCompCartaPorteUbi.venmovimientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN vencompCartaPorteDestino ON
		vencompCartaPorteDestino.venmovimientos = venCompCartaPorteUbi.venmovimientos AND 
		vencompCartaPorteDestino.idDestino =venCompCartaPorteUbi.Ubicacion
	LEFT join genProvincias ON  genProvincias.Provincia_Id = vencompCartaPorteDestino.Estado
	INNER JOIN genPaises ON  genPaises.genPaises = vencompCartaPorteDestino.Pais
	INNER JOIN genPaises as Residencia ON  Residencia.genPaises = vencompCartaPorteDestino.ResidenciaFiscal
WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C
ORDER BY 2

-- mercancias

Select venCompCartaPorteMercancia.venmovimientos, venCompCartaPorteMercancia.idDestino,
	venCompCartaPorteMercancia.Renglon,
	venCompCartaPorteMercancia.BienesTransp,
	venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, 
	stkUniMed.Medida_Id,
	venCompCartaPorteMercancia.MaterialPeligroso, venCompCartaPorteMercancia.CveMaterialPeligroso, 
	venCompCartaPorteMercancia.Embalaje, venCompCartaPorteMercancia.DescripEmbalaje, 
	venCompCartaPorteMercancia.Dimensiones, venCompCartaPorteMercancia.PesoEnKg * venCompCartaPorteMercancia.Cantidad as PesoEnKg, 
	venCompCartaPorteMercancia.ValorMercancia, venCompCartaPorteMercancia.FraccionArancelaria, 
	venCompCartaPorteMercancia.UUIDComercioExt, ' ' as Producto_Id
FROM venCompCartaPorteMercancia
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =venCompCartaPorteMercancia.venmovimientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	inner join stkUniMed ON stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_id
WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C
ORDER BY 2,3

GO