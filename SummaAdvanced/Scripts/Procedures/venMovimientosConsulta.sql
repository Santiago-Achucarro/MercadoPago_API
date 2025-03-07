--Exec venMovimientosConsultaDrillDown 1, 'FC', 20, 0, 0, 0, 'F', '1492', 'A', ''

DROP PROCEDURE venMovimientosConsultaDrillDown
GO
CREATE PROCEDURE venMovimientosConsultaDrillDown
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
as

SET NOCOUNT ON

Declare @pIdentity bigint = (Select Asiento_Id
 From genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

Exec venMovimientosDatos @pIdentity

-- Traigo el cuerpo conjunto

SELECT venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, stkProductos.Descripcion, venMovConStockCr.CantOriginal, 
	stkUniMed.Medida_Id, venMovConStockCr.PrecioForm, venMovConStockCr.Bonificacion,
	venMovConStockCr.Observaciones,
	CONVERT(Numeric(18,2),
	ROUND(venMovConStockCr.CantOriginal * venMovConStockCr.PrecioForm * (1-venMovConStockCr.Bonificacion/100),2)) as SubTotal,
	stkDepositos.Deposito_Id, MedidaAlt.Medida_Id MedidaAlterna, venMovConStockCr.CantidadAlternaForm, venMovConStockCr.Factor
From venMovConStockCr 
Inner Join stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
Inner Join stkUniMed ON stkUniMed.stkUniMed = venMovConStockCr.Medida_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = venMovConStockCr.Deposito_Id
Left Join stkUniMed MedidaAlt On MedidaAlt.stkUniMed = venMovConStockCr.MedidaAlterna
WHERE venMovConStockCr.venMovimientos = @pIdentity
UNION ALL
SELECT venMovDetalle.conRenglon, venMovDetalle.Producto_Id, venMovDetalle.Detalle Descripcion, 
	venMovDetalle.Cantidad, 
	stkUniMed.Medida_Id, venMovDetalle.ImporteUnitario, 0 AS Bonificacion,
	'' AS Observaciones,
	CONVERT(Numeric(18,2),
	ROUND(venMovDetalle.Cantidad * venMovDetalle.ImporteUnitario,2)) as SubTotal, '' Deposito_Id, '' MedidaAlterna, 0 CantidadAlternaForm, 1 Factor
From venMovDetalle
Inner Join stkUniMed ON stkUniMed.stkUniMed = venMovDetalle.Medida_Id
WHERE venMovDetalle.venMovimientos = @pIdentity
Order by 1

	
Exec VenMovImpuestosDatos @pIdentity
Exec venMovimientosFiscalDatos @pIdentity
Exec venMovimientosFiscalINEDatos @pIdentity
Exec venMovimientosMetodoPagoDatos @pIdentity
Exec venMovimientosCFDIRDatos @pIdentity -- AR
Exec venMovimientosCFDIRDatos @pIdentity -- MX
Exec venMoviAnticipoDatos @pIdentity


SELECT stkMoviSerie.stkMoviCabe, venMovStkHist.RenglonCuerpo Renglon, stkMoviSerie.Serie, stkMoviSerie.Cantidad / stkMoviCuerpo.Factor Cantidad,
stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id, Cast(0 As Numeric(18,8)) Existencia
From stkMoviSerie 
Inner Join stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
Left Join stkSerieVencimiento On stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
	stkSerieVencimiento.Empresa_Id = @pEmpresa_id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviSerie.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
left join (stkMoviSerieUbicacion INNER JOIN stkUbicaciones ON
	stkUbicaciones.stkUbicaciones = stkMoviSerieUbicacion.Ubicacion_Id) ON  
	stkMoviSerieUbicacion.stkMoviCabe = venMovStkHist.stkMoviCabe and 
	  stkMoviSerieUbicacion.Renglon  = venMovStkHist.Renglon
WHERE venMovStkHist.venMovimientos = @pIdentity

Exec venMoviAnticipoDatos @pIdentity

-- V2 UBICACIONES
Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id,
	stkMoviUbicacion.Cantidad, stkMoviUbicacion.CantidadAlterna
From stkMoviUbicacion inner join stkMoviCuerpo ON 
stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and
stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
Inner Join stkProductos on  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Inner Join stkDepositos on  stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Inner Join stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
inner join venMovimientos ON venMovimientos.venMovimientos = venMovStkHist.venMovimientos
Inner Join venTipoMov ON venTipoMov.Signo = 1
WHERE venMovStkHist.venMovimientos = @pIdentity 



Select stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id,
	stkMoviUbicacion.Cantidad, stkMoviUbicacion.CantidadAlterna
From stkMoviUbicacion 
Inner Join stkMoviCuerpo ON stkMoviUbicacion.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And stkMoviUbicacion.Renglon = stkMoviCuerpo.Renglon
Inner Join stkProductos on stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Inner Join stkDepositos on stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Inner Join stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
Inner Join venMovStkHist On venMovStkHist.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And venMovStkHist.Renglon = stkMoviCuerpo.Renglon
Inner Join venMovimientos ON venMovimientos.venMovimientos = venMovStkHist.venMovimientos
Inner Join venTipoMov ON venTipoMov.Signo = -1
WHERE venMovStkHist.venMovimientos = @pIdentity

-- Relacionados __
-- Pedidos
SELECT dbo.Segmento(venPediSegmentos.Segmento_Id, 
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, 
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, 
	venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N,
	venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) as Relacionado,
	genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venPediFacturados inner join venPediSegmentos ON venPediFacturados.venPedidos = venPediSegmentos.venPedidos
Inner Join genSegmentos ON genSegmentos.genSegmentos  = venPediSegmentos.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE venPediFacturados.venMovimientos = @pIdentity And genMenus.Orden = '539920'
UNION ALL
SELECT distinct dbo.Segmento(venPediSegmentos.Segmento_Id, 
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, 
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, 
	venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N,
	venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) as Relacionado,
	genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venMovConStockCrPed inner join venPediSegmentos ON venMovConStockCrPed.venPedidos = venPediSegmentos.venPedidos
Inner Join genSegmentos ON genSegmentos.genSegmentos = venPediSegmentos.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE venMovConStockCrPed.venMovimientos = @pIdentity And genMenus.Orden = '531000'
Union All
-- Remitos --
SELECT DISTINCT dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Relacionado, 
	genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venMovStkHist 
Inner Join genAsiSegmentos ON venMovStkHist.stkMoviCabe = genAsiSegmentos.Asiento_Id
Inner Join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE venMovStkHist.venMovimientos = @pIdentity And genMenus.Orden = '239010'
Union All
-- Cotizaciones --
SELECT dbo.Segmento(venCotizSegmento.Segmento_Id, 
	venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C, 
	venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, 
	venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N,
	venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N) as Relacionado, 
	genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venCotizFactura inner join venCotizSegmento ON venCotizFactura.venCotizaciones = venCotizSegmento.venCotizaciones
Inner Join genSegmentos ON genSegmentos.genSegmentos  = venCotizSegmento.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE venCotizFactura.venMovimientos = @pIdentity And genMenus.Orden = '524010'



-- todo reparto

-- todo hoja de ruta

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venMovimientos' 

SELECT venMovConStock.venMovimientos, venListasPrecios.ListaPrecio_Id, 
venListasPrecios.Descripcion as DescripcionListasPrecios, venMovConStock.TipoPrecioForm, venListasPrecios.LlevaImpuestoInclu
FROM venMovConStock 
INNER JOIN venListasPrecios ON venListasPrecios.venListasPrecios = venMovConStock.ListaPrecio_Id
WHERE venMovimientos = @pIdentity

GO