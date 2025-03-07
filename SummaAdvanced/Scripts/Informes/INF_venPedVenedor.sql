
-- INF_venPedVenedor ' ','zzz',1

DROP PROCEDURE INF_venPedVenedor
GO
CREATE PROCEDURE INF_venPedVenedor (
@VendedorDesde Char(5),
@VendedorHasta Char(5),
@Empresa int)

AS
select venPediSegmentos.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id,
venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,  
venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,   
venPediSegmentos.Segmento4N) as Segmento, venClientes.Cliente_Id, 
venClientes.RazonSocial  , venPedidos.Fecha, 
venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVen,
venpedidos.ImporteTotal, genMonedas.Moneda_id,
stkProductos.Producto_id, stkProductos.Descripcion as DescripcionProducto, 
venPediCuerpo.CantidadOriginal, 
convert(Numeric(18,6), (venPediCuerpo.CantidadPedida -  venPediCuerpo.CantidadRemitida) / venPediCuerpo.Factor) as CantidadPendiente,
venPediCuerpo.PrecioVenta as Precio, venPediCuerpo.PrecioVenta*venPedidos.Cambio as PrecioBase, venPedidos.CliOrdenCompra
From venpedidos 
INNER JOIN venPediSegmentos ON venpedidos.venpedidos = venPediSegmentos.venpedidos
inner join venClientes ON venpedidos.Cliente_Id = venClientes.genEntidades
inner join venVendedores ON venVendedores.venVendedores = venPedidos.Vendedor_Id
inner join venPediCuerpo ON venPediCuerpo.venPedidos = venpedidos.venpedidos 
inner join stkProductos ON stkProductos.stkProductos = venPediCuerpo.Producto_Id
inner join stkUniMed ON stkUniMed.stkUniMed = venPedicuerpo.Medida_Id
inner join genMonedas ON genMonedas.genMonedas = venPedidos.Moneda_Id
WHERE
	venPedidos.Empresa_id = @Empresa and 
	venpedidos.Estado <> 'R' AND 
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
	venPediCuerpo.CantidadPedida >  venPediCuerpo.CantidadRemitida and 
	venPediCuerpo.Pendiente = 1 and 
	venPedidos.Estado NOT IN ('T','N','R')
ORDER BY 2,3,4,5,6,7,8,9
	
	
	