
-- INF_venPedArtPendRes ' ','zzz',1

DROP PROCEDURE INF_venPedArtPendRes
GO
CREATE PROCEDURE INF_venPedArtPendRes (
@VendedorDesde Char(5),
@VendedorHasta Char(5),
@ClienteDesde Char(15),
@ClienteHasta Char(15),
@ProductoDesde Char(25),
@ProductoHasta Char(25),
@Empresa int)

AS
select stkProductos.Producto_id, stkProductos.Descripcion as DescripcionProducto, 
SUM(convert(Numeric(18,6), (venPediCuerpo.CantidadPedida -  venPediCuerpo.CantidadRemitida) / venPediCuerpo.Factor)) as CantidadPendiente, 
ISNULL(stkExistencia.Cantidad,0) AS Existencia, 
ISNULL((select sum(stkExistencia.Cantidad) from stkExistencia where
	stkExistencia.Producto_Id= stkProductos.stkProductos and 
	stkExistencia.Empresa_Id = @Empresa ) ,0) AS ExistenciaTotal 
From venpedidos INNER JOIN venPediSegmentos ON
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
left join stkExistencia ON stkExistencia.Producto_Id= venPediCuerpo.Producto_Id and 
stkExistencia.Deposito_Id = venPediCuerpo.Deposito_Id and 
stkExistencia.Empresa_Id = @Empresa 
WHERE
	venPedidos.Empresa_id = @Empresa and 
	venpedidos.Estado <> 'R' AND 
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
	venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta And
	stkProductos.Producto_Id Between @ProductoDesde And @ProductoHasta And
	venPediCuerpo.CantidadPedida >  venPediCuerpo.CantidadRemitida and 
	venPediCuerpo.Pendiente = 1 and 
	venPedidos.Estado NOT IN ('T','N','R')
GROUP BY stkProductos.Producto_id, stkProductos.Descripcion 	, stkExistencia.Cantidad, 
stkProductos.stkProductos
ORDER BY 1
	
	
	