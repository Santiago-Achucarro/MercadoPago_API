--select * from venCompCartaPorteMercancia where venmovimientos = 32103

-- EXEC inf_venFactuMercanciasLibre 1,'FC',5,0,0,0,'M','0202',' ',' '
DROP Procedure inf_venFactuMercanciasLibre
GO
CREATE Procedure inf_venFactuMercanciasLibre(
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
AS

select venCompCartaPorteUbi.Ubicacion idDestino,
venCompCartaPorteMercancia.Renglon, 
venCompCartaPorteUbi.TipoEstacion + '- Destino' as TipoEstacion
	, venCompCartaPorteUbi.DistanciaRecorrida,
venCompCartaPorteDestino.RFCDestinatario Rfc, venCompCartaPorteDestino.NombreDestinatario Nombre,
	isnull(venCompCartaPorteDestino.NumRegIdTrib,'') NumRegIdTrib , genPaisesRes.CodFiscal,
	isnull(venCompCartaPorteDestino.NumEstacion,'') NumEstacion, 
	isnull(venCompCartaPorteDestino.NombreEstacion,'') NombreEstacion,
	venCompCartaPorteDestino.FechaHoraProgLlegada FechaHora, venCompCartaPorteDestino.Calle, 
	isnull(venCompCartaPorteDestino.NumeroExterior,'') NumeroExterior, 
	isnull(venCompCartaPorteDestino.Numerointerior,'') Numerointerior, 
	isnull(venCompCartaPorteDestino.Colonia,'') codColonia, 
	isnull(venCompCartaPorteDestino.Localidad,'') codLocalidad, 
	isnull(venCompCartaPorteDestino.Municipio,'') codMunicipo, 
	isnull(venCompCartaPorteDestino.Referencia,'') Referencia,
	ISNULL(genProvincias.CodFiscal, venCompCartaPorteDestino.Estado) Estado,
	genPaises.CodFiscal AS Pais, venCompCartaPorteDestino.CodigoPostal,
	ISNULL(genlocalidades.Descripcion,' ') Localidad, 
	ISNULL(genMunicipios.Descripcion,' ') Municipio, 
	venCompCartaPorteMercancia.BienesTransp, 
	venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, stkUniMed.CodigoFiscal, 
	ISNULL(venCompCartaPorteMercancia.Dimensiones,'') Dimensiones,
	venCompCartaPorteMercancia.MaterialPeligroso, 
	ISNULL(venCompCartaPorteMercancia.Embalaje,'') Embalaje, 
	ISNULL(venCompCartaPorteMercancia.CveMaterialPeligroso,'') CveMaterialPeligroso,
	venCompCartaPorteMercancia.PesoEnKg*venCompCartaPorteMercancia.Cantidad as PesoEnKg, venCompCartaPorteMercancia.ValorMercancia, 
		ISNULL(venCompCartaPorteMercancia.FraccionArancelaria,'') FraccionArancelaria, 
		ISNULL(venCompCartaPorteMercancia.UUIDComercioExt,'') UUIDComercioExt
	from venCompCartaPorteMercancia 
	inner join venCompCartaPorteUbi ON  venCompCartaPorteUbi.Ubicacion = venCompCartaPorteMercancia.idDestino AND 
			venCompCartaPorteUbi.venmovimientos = venCompCartaPorteMercancia.venmovimientos
	inner join venCompCartaPorteDestino ON  venCompCartaPorteUbi.Ubicacion = venCompCartaPorteDestino.idDestino AND 
		venCompCartaPorteUbi.venmovimientos = venCompCartaPorteDestino.venmovimientos
	inner join stkUniMed ON stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_id
	inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCompCartaPorteMercancia.venmovimientos
	inner join genSegmentos on genSegmentos.genSegmentos  = genAsiSegmentos.Segmento_Id
	LEFT JOIN genProvincias ON genProvincias.Provincia_Id = venCompCartaPorteDestino.Estado
	INNER JOIN genPaises ON genPaises.genPaises = venCompCartaPorteDestino.Pais
	INNER JOIN genPaises genPaisesRes ON genPaisesRes.genPaises = venCompCartaPorteDestino.ResidenciaFiscal
	LEFT JOIN genlocalidades ON  genlocalidades.c_Localidad = venCompCartaPorteDestino.Localidad AND 
		genlocalidades.c_Estado = genProvincias.CodFiscal
	LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = venCompCartaPorteDestino.Municipio AND 
		genMunicipios.c_Estado = genProvincias.CodFiscal
	WHERE 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id

union all
select venCompCartaPorteMercancia.idDestino,
venCompCartaPorteMercancia.Renglon, 
venCompCartaPorteUbi.TipoEstacion + '-Origen' as TipoEstacion, venCompCartaPorteUbi.DistanciaRecorrida,
venCompCartaPorteOrigen.RFCRemitente Rfc, venCompCartaPorteOrigen.NombreRemitente Nombre,
	isnull(venCompCartaPorteOrigen.NumRegIdTrib,'') NumRegIdTrib , genPaisesRes.CodFiscal,
	isnull(venCompCartaPorteOrigen.NumEstacion,'') NumEstacion, 
	isnull(venCompCartaPorteOrigen.NombreEstacion,'') NombreEstacion,
	venCompCartaPorteOrigen.FechaHoraSalida FechaHora, venCompCartaPorteOrigen.Calle, 
	isnull(venCompCartaPorteOrigen.NumeroExterior,'') NumeroExterior, 
	isnull(venCompCartaPorteOrigen.Numerointerior,'') Numerointerior, 
	isnull(venCompCartaPorteOrigen.Colonia,'') codColonia, 
	isnull(venCompCartaPorteOrigen.Localidad,'') codLocalidad, 
	isnull(venCompCartaPorteOrigen.Municipio,'') codMunicipo, 
	isnull(venCompCartaPorteOrigen.Referencia,'') Referencia,
	ISNULL(genProvincias.CodFiscal, venCompCartaPorteOrigen.Estado) Estado,
	genPaises.CodFiscal AS Pais, venCompCartaPorteOrigen.CodigoPostal,
	ISNULL(genlocalidades.Descripcion,' ') Localidad, 
	ISNULL(genMunicipios.Descripcion,' ') Municipio, 
	venCompCartaPorteMercancia.BienesTransp, 
	venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, stkUniMed.CodigoFiscal, 
	ISNULL(venCompCartaPorteMercancia.Dimensiones,'') Dimensiones,
	venCompCartaPorteMercancia.MaterialPeligroso, 
	ISNULL(venCompCartaPorteMercancia.Embalaje,'') Embalaje, 
	ISNULL(venCompCartaPorteMercancia.CveMaterialPeligroso,'') CveMaterialPeligroso,
	venCompCartaPorteMercancia.PesoEnKg*venCompCartaPorteMercancia.Cantidad as PesoEnKg, 
	venCompCartaPorteMercancia.ValorMercancia, 
		ISNULL(venCompCartaPorteMercancia.FraccionArancelaria,'') FraccionArancelaria, 
		ISNULL(venCompCartaPorteMercancia.UUIDComercioExt,'') UUIDComercioExt
	from venCompCartaPorteMercancia 
	inner join venCompCartaPorteUbi ON  venCompCartaPorteUbi.Ubicacion = venCompCartaPorteMercancia.idDestino AND
	venCompCartaPorteUbi.venmovimientos = venCompCartaPorteMercancia.venmovimientos
	inner join venCompCartaPorteOrigen ON  venCompCartaPorteUbi.Ubicacion = venCompCartaPorteOrigen.idOrigen AND 
	venCompCartaPorteOrigen.venmovimientos  =venCompCartaPorteUbi.venmovimientos
	inner join stkUniMed ON stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_id
	inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCompCartaPorteMercancia.venmovimientos
	inner join genSegmentos on genSegmentos.genSegmentos  = genAsiSegmentos.Segmento_Id
	LEFT JOIN genProvincias ON genProvincias.Provincia_Id = venCompCartaPorteOrigen.Estado
	INNER JOIN genPaises ON genPaises.genPaises = venCompCartaPorteOrigen.Pais
	INNER JOIN genPaises genPaisesRes ON genPaisesRes.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
	LEFT JOIN genlocalidades ON  genlocalidades.c_Localidad = venCompCartaPorteOrigen.Localidad AND 
		genlocalidades.c_Estado = genProvincias.CodFiscal
	LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = venCompCartaPorteOrigen.Municipio AND 
		genMunicipios.c_Estado = genProvincias.CodFiscal
	WHERE 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	order by 1,2
go

