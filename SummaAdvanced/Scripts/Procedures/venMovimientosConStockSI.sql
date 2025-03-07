Drop Procedure venMovimientosConStockSIDatos
GO
Create Procedure venMovimientosConStockSIDatos
(
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
SET NOCOUNT ON 

Declare @pIdentity bigint = (Select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id And 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And 
	genAsiSegmentos.Segmento1N = @pSegmento1N And 
	genAsiSegmentos.Segmento2N = @pSegmento2N And 
	genAsiSegmentos.Segmento3N = @pSegmento3N And 
	genAsiSegmentos.Segmento4N = @pSegmento4N And 
	genAsiSegmentos.Segmento1C = @pSegmento1C And 
	genAsiSegmentos.Segmento2C = @pSegmento2C And 
	genAsiSegmentos.Segmento3C = @pSegmento3C And 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
Exec venMovimientosDatos @pIdentity

exec venMovConStockDatos @pIdentity

Exec venMovImpuestosDatos @pIdentity, Null

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venMovimientos'
Exec genMovCuotasDatos @pIdentity
/*
SELECT genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo, genMovCuotas.FechaVencimiento
FROM genMovCuotas
WHERE genMovCuotas.Asiento_id = @pIdentity
ORDER BY 1
*/
exec venMovCSImpuestosDatos @pIdentity, Null, Null
exec venMovimientosFiscalDatos @pIdentity
exec venMovimientosFiscalINEDatos @pIdentity
exec venMovimientosMetodoPagoDatos  @pIdentity
exec venMovimientosExpMXDatos  @pIdentity

exec venMovimientosCFDIRDatos @pIdentity -- AR
exec venMovimientosCFDIRDatos @pIdentity -- MX

SELECT stkMoviSerie.stkMoviCabe, venMovStkHist.RenglonCuerpo Renglon, stkMoviSerie.Serie, stkMoviSerieUbicacion.Cantidad / stkMoviCuerpo.Factor Cantidad,
stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia,
	Case @pIdentity When 0 Then Cast(0 As bit) Else Cast(1 As bit) End Marcado
FROM stkMoviSerie 
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Left Join stkSerieVencimiento On stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
	stkSerieVencimiento.Empresa_Id = @pEmpresa_id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviSerie.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
left join (stkMoviSerieUbicacion INNER JOIN stkUbicaciones ON
	stkUbicaciones.stkUbicaciones = stkMoviSerieUbicacion.Ubicacion_Id) ON  
	stkMoviSerieUbicacion.stkMoviCabe = stkMoviSerie.stkMoviCabe and 
	  stkMoviSerieUbicacion.Renglon  = stkMoviSerie.Renglon And
	  stkMoviSerieUbicacion.Serie = stkMoviSerie.Serie
WHERE venMovStkHist.venMovimientos = @pIdentity

exec venMoviAnticipoDatos @pIdentity

-- V2 UBICACIONES
Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id,
	Cast(0 As Numeric(19,8)) Cantidad, Cast(0 As Numeric(19,8)) CantidadAlterna, 
	stkMoviUbicacion.Cantidad Existencia, stkMoviUbicacion.CantidadAlterna ExistenciaAlterna
From stkMoviUbicacion 
inner join stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and
	stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
INNER JOIN stkProductos on  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos on  stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
inner join venMovimientos ON venMovimientos.venMovimientos = venMovStkHist.venMovimientos
INNER JOIN venTipoMov ON venTipoMov.Signo = 1
WHERE venMovStkHist.venMovimientos = @pIdentity 



Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id,
	stkMoviUbicacion.Cantidad, stkMoviUbicacion.CantidadAlterna
From stkMoviUbicacion 
inner join stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and
	stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
INNER JOIN stkProductos on  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos on  stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
inner join venMovimientos ON venMovimientos.venMovimientos = venMovStkHist.venMovimientos
INNER JOIN venTipoMov ON venTipoMov.Signo = -1
WHERE venMovStkHist.venMovimientos = @pIdentity

-- AJ MAY 2020 PARA LAS CONSULTAS DE STOCK
SELECT getdate() as Fecha, '' Producto_Id, '' Descripcion, 0.00 as Existencia, 
	0.00 as Compras, 0.00 as Embarques,	
		0.00 as Pedidos, 0.00 as TransitoLocal,
		0.00 as Final, '' as Deposito_Id

select '' as Entidad_Id, '' as Descripcion, '' SegmentoSTR, 0.00 as Cantidad


-- para las cotizaciones
select genSegmentos.Segmento_Id, venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N,
	venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C
FROM venCotizFactura INNER JOIN venCotizSegmento ON
	venCotizFactura.venCotizaciones = venCotizSegmento.venCotizaciones
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = venCotizSegmento.Segmento_Id
	Where
		venCotizFactura.venMovimientos = @pIdentity

Exec conAsientosAnulDatos @pidentity

-- Carta Porte

SELECT venCompCartaporte.TranspInternac, venCompCartaporte.EntradaSalidaMerc, venCompCartaPorte.ViaEntradaSalida, 
	venCompCartaporte.TotalDistRec, venCompCartaporte.PesoBrutoTotal, venCompCartaporte.UnidadPeso, 
	venCompCartaporte.PesoBrutoTotal, venCompCartaporte.PesoNetoTotal, venCompCartaporte.CargoPorTasacion,
	venCamiones.Patente_Id as Camion_Id,  venCamiones.Descripcion  DescripcionCamion,
	Remolque1.Patente_Id as Remolque1, Remolque1.Descripcion as DescripcionRemolque1,
	Remolque2.Patente_Id as Remolque2, Remolque2.Descripcion as DescripcionRemolque2,
	venOperadores.Operador_Id, venOperadores.NombreOperador,
	venCompCartaPorteOrigen.RFCRemitente, venCompCartaPorteOrigen.NombreRemitente,
	venCompCartaPorteOrigen.NumRegIdTrib NumRegIdTribO, genPaisesOR.Pais_Id as  ResidenciaFiscalO,
	venCompCartaPorteOrigen.NumEstacion NumEstacionO, venCompCartaPorteOrigen.NombreEstacion NombreEstacionO, 
	venCompCartaPorteOrigen.NavegacionTrafico NavegacionTraficoO, venCompCartaPorteOrigen.FechaHoraSalida,
	venCompCartaPorteOrigen.Calle CalleOrigen,  venCompCartaPorteOrigen.NumeroExterior  NumeroExteriorOrigen, 
	venCompCartaPorteOrigen.Numerointerior NumerointeriorOrigen, 
	venCompCartaPorteOrigen.Colonia ColoiniaOrigen, 
		genColoniasO.NombreAsentamiento as DescripcionColoniaO, 
	venCompCartaPorteOrigen.Localidad  LocalidadOrigen, genlocalidadesO.Descripcion as DescripcionLocalidadO, 
	venCompCartaPorteOrigen.Referencia ReferenciaOrigen,
	venCompCartaPorteOrigen.Municipio MunicipioOrigen, genMunicipiosO.Descripcion AS DescripcionMunicipioO, 
	genProvincias.Provincia_Id EstadoO, venCompCartaPorteOrigen.CodigoPostal CodigoPostalOrigen, 
	genPaisesO.Pais_Id PaisOrigen, genPaisesO.Descripcion DescripcionPaisO,
	venCompCartaPorteDestino.RFCDestinatario, venCompCartaPorteDestino.NombreDestinatario,
	venCompCartaPorteDestino.NumRegIdTrib NumRegIdTribD, genPaisesOR.Pais_Id as  ResidenciaFiscal,
	venCompCartaPorteDestino.NumEstacion NumEstacionD, venCompCartaPorteDestino.NombreEstacion NombreEstacionD, 
	venCompCartaPorteDestino.NavegacionTrafico NavegacionTraficoD, venCompCartaPorteDestino.FechaHoraProgLlegada,
	venCompCartaPorteDestino.Calle CalleDestino,  venCompCartaPorteDestino.NumeroExterior  NumeroExteriorDestino, 
	venCompCartaPorteDestino.Numerointerior NumerointeriorDestino, 
	venCompCartaPorteDestino.Colonia ColoiniaDestino, 
		genColoniasD.NombreAsentamiento as DescripcionColoniaD, 
	venCompCartaPorteDestino.Localidad  LocalidadDestino, genlocalidadesD.Descripcion as DescripcionLocalidadD, 
	venCompCartaPorteDestino.Referencia ReferenciaDestino,
	venCompCartaPorteDestino.Municipio MunicipioDestino, genMunicipiosD.Descripcion AS DescripcionMunicipioD, 
	genProvinciasD.Provincia_Id EstadoD, venCompCartaPorteDestino.CodigoPostal CodigoPostalDestino, 
	genPaisesO.Pais_Id PaisDestino, genPaisesD.Descripcion DescripcionPaisD
FROM  venCompCartaporte
	inner join venCamiones ON  venCompCartaporte.Camion_Id= venCamiones.venCamiones
	left join venCamiones Remolque1 ON  venCompCartaporte.Remolque1= Remolque1.venCamiones
	left join venCamiones Remolque2 ON  venCompCartaporte.Remolque2= Remolque2.venCamiones
	inner join venOperadores on  venOperadores.venOperadores = venCompCartaPorte.Operador_Id
	INNER JOIN venCompCartaPorteOrigen on  venCompCartaPorteOrigen.venmovimientos = venCompCartaPorte.venmovimientos
	INNER JOIN genPaises genPaisesOR ON  genPaisesOR.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal
	LEFT JOIN genProvincias ON  genProvincias.CodFiscal = venCompCartaPorteOrigen.Estado
	LEFT JOIN genColonias  genColoniasO ON genColoniasO.c_Colonia = venCompCartaPorteOrigen.Colonia AND 
	genColoniasO.c_CodigoPostal = venCompCartaPorteOrigen.CodigoPostal
	LEFT JOIN genlocalidades  genlocalidadesO ON genlocalidadesO.c_Localidad = venCompCartaPorteOrigen.Localidad AND 
		genlocalidadesO.c_Estado = venCompCartaPorteOrigen.Estado
	LEFT JOIN genMunicipios  genMunicipiosO ON genMunicipiosO.c_Municipio = venCompCartaPorteOrigen.Municipio and 
								genMunicipiosO.c_Estado = venCompCartaPorteOrigen.Estado
	INNER JOIN genPaises genPaisesO ON genPaisesO.genPaises = venCompCartaPorteOrigen.Pais

	INNER JOIN venCompCartaPorteDestino on  venCompCartaPorteDestino.venmovimientos = venCompCartaPorte.venmovimientos
	INNER JOIN genPaises genPaisesDR ON  genPaisesDR.genPaises = venCompCartaPorteDestino.ResidenciaFiscal
	LEFT JOIN genProvincias genProvinciasD ON  genProvinciasD.CodFiscal = venCompCartaPorteDestino.Estado
	LEFT JOIN genColonias  genColoniasD ON genColoniasD.c_Colonia = venCompCartaPorteDestino.Colonia AND 
	genColoniasD.c_CodigoPostal = venCompCartaPorteDestino.CodigoPostal
	LEFT JOIN genlocalidades  genlocalidadesD ON genlocalidadesD.c_Localidad = venCompCartaPorteDestino.Localidad AND 
		genlocalidadesD.c_Estado = venCompCartaPorteDestino.Estado
	LEFT JOIN genMunicipios  genMunicipiosD ON genMunicipiosD.c_Municipio = venCompCartaPorteDestino.Municipio and 
								genMunicipiosD.c_Estado = venCompCartaPorteDestino.Estado
	INNER JOIN genPaises genPaisesD ON genPaisesD.genPaises = venCompCartaPorteDestino.Pais
WHERE
	venCompCartaPorte.venmovimientos = @pIdentity

-- mercancia Carta Porte
Select venCompCartaPorteMercancia.Renglon, venCompCartaPorteMercancia.BienesTransp, venCompCartaPorteMercancia.ClaveSTCC, 
	venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad, stkUniMed.Medida_Id, 
		venCompCartaPorteMercancia.Dimensiones, venCompCartaPorteMercancia.MaterialPeligroso, venCompCartaPorteMercancia.CveMaterialPeligroso, 
			venCompCartaPorteMercancia.Embalaje, venCompCartaPorteMercancia.DescripEmbalaje, venCompCartaPorteMercancia.PesoEnKg, 
			venCompCartaPorteMercancia.ValorMercancia, venCompCartaPorteMercancia.FraccionArancelaria, 
			venCompCartaPorteMercancia.UUIDComercioExt
from venCompCartaPorteMercancia
	INNER JOIN stkUniMed ON venCompCartaPorteMercancia.Medida_id = stkUniMed.stkUniMed
	WHERE venCompCartaPorteMercancia.venMovimientos = @pIdentity
ORDER BY 1


-- Datos de cobranzas venta al contado/pto de venta --
Select 0 Renglon, '' Cartera_Id, '' DescripcionCartera, '' TipoCartera, Cast(0 As Numeric(19,2)) Importe, Cast(0 As Numeric(12,8)) Ponderado,
	'' CTBanco_Id, '' CTDescripcionBanco, '' CTClearing,
	'' CTClearingDias, GetDate() CTFechaVencimiento, '' CTsucBanco, '' CTcuentaBanco, 0 CTnumCheque, '' CTLectoraCheques,
	0 T3Cuotas, 0 T3Cupon, 0 T3Lote, 0 T3Comercio, 0 T3Terminal, 0 T3Promocion, Cast(0 As Numeric(19,8)) T3Coeficiente

RETURN @@Error
GO
