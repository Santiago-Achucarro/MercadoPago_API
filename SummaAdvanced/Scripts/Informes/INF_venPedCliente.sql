
-- INF_venPedCliente ' ','zzz','20190501','20190531',1
-- se supone que son Ingresados y no pendientes

DROP PROCEDURE INF_venPedCliente
GO
CREATE PROCEDURE INF_venPedCliente (
@ClienteDesde VarChar(15),
@ClienteHasta VarChar(15),
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@Empresa int)

AS
DECLARE @FechaHasta1 DateTime 
SET @FechaHasta1 = DATEADD(ms,-31,DATEADD(dd,1,@FechaHasta))
SELECT venClientes.Cliente_Id,  venClientes.RazonSocial,  
venPediSegmentos.venPedidos,  dbo.Segmento(venPediSegmentos.Segmento_Id,
venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,  
venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,   
venPediSegmentos.Segmento4N) as Segmento, venPedidos.Fecha, 
venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVen,
venPedidos.ImporteTotal, genMonedas.Moneda_id,
stkProductos.Producto_id, stkProductos.Descripcion as DescripcionProducto, 
venPediCuerpo.CantidadOriginal, 
convert(Numeric(18,6), (venPediCuerpo.CantidadPedida -  venPediCuerpo.CantidadRemitida) / venPediCuerpo.Factor) as CantidadPendiente,
venPediCuerpo.PrecioVenta as Precio, venPediCuerpo.PrecioVenta*venPedidos.Cambio as PrecioBase, venPedidos.CliOrdenCompra
FROM venpedidos INNER JOIN venPediSegmentos ON
venpedidos.venpedidos = venPediSegmentos.venpedidos
inner join venClientes ON
venpedidos.Cliente_Id = venClientes.genEntidades
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
	VenClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and
	/*venPediCuerpo.CantidadPedida >  venPediCuerpo.CantidadRemitida and 
	venPediCuerpo.Pendiente = 1 and */
	-- venPedidos.Estado NOT IN ('T','N','R') and 
	venPedidos.Fecha between @FechaDesde And @FechaHasta1
ORDER BY 1,3,4,5,6,7,8,9,10



	
	
	