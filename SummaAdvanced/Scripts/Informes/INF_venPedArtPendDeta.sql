
-- INF_venPedArtPendDeta ' ','zzz',' ','zzz',' ','zzz',1

DROP PROCEDURE INF_venPedArtPendDeta
GO
CREATE PROCEDURE INF_venPedArtPendDeta (
@VendedorDesde Char(5),
@VendedorHasta Char(5), 
@ClienteDesde Char(15),
@ClienteHasta Char(15),
@ProductoDesde Char(25),
@ProductoHasta Char(25),
@Empresa int)

AS
select stkProductos.Producto_id, stkProductos.Descripcion as DescripcionProducto, 
venPediSegmentos.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id,
venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,  
venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,   
venPediSegmentos.Segmento4N) as Segmento, venClientes.Cliente_Id, 
venClientes.RazonSocial  , venClieHabitual.Sucursal, venClieHabitual.NombreFantasia,
venPedidos.Fecha, venPediCuerpo.FechaEntrega,
venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVen,
genMonedas.Moneda_Id, 
convert(Numeric(18,6), (venPediCuerpo.CantidadPedida -  venPediCuerpo.CantidadRemitida) / venPediCuerpo.Factor) as CantidadPendiente,
convert(Numeric(18,6), ((venPediCuerpo.CantidadPedida -  venPediCuerpo.CantidadRemitida) / venPediCuerpo.Factor)* venPediCuerpo.precioVenta) as Precio
,venPediCuerpo.PrecioVenta*venPedidos.Cambio as PrecioBase,venPediCuerpo.CantidadPedida as CantidadOriginal
From venpedidos INNER JOIN venPediSegmentos ON
venpedidos.venpedidos = venPediSegmentos.venpedidos
inner join venClientes ON
venpedidos.Cliente_Id = venClientes.genEntidades
INNER JOIN venClieHabitual ON 
venClieHabitual.genEntidades = venPedidos.Cliente_Id AND 
venClieHabitual.Sucursal = venPedidos.Sucursal
inner join venVendedores ON 
venVendedores.venVendedores = venPedidos.Vendedor_Id
inner join venPediCuerpo ON
venPediCuerpo.venPedidos = venpedidos.venpedidos 
inner join stkProductos ON
stkProductos.stkProductos = venPediCuerpo.Producto_Id
inner join stkUniMed ON
stkUniMed.stkUniMed = venPedicuerpo.Medida_Id
inner join genMonedas ON
genMonedas.genMonedas = venPedidos.Moneda_Id
WHERE
	venPedidos.Empresa_id = @Empresa and 
	venpedidos.Estado <> 'R' AND 
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
	venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta And
	stkProductos.Producto_Id Between @ProductoDesde And @ProductoHasta And
	venPediCuerpo.CantidadPedida >  venPediCuerpo.CantidadRemitida and 
	venPediCuerpo.Pendiente = 1 and 
	venPedidos.Estado NOT IN ('T','N','R')
ORDER BY 1,3,4,5,6,7,8
	
	
	