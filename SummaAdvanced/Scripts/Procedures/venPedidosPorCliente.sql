DROP PROCEDURE venPedidosPorCliente
GO
CREATE PROCEDURE venPedidosPorCliente
(
	@Cliente_Id VarChar(15),
	@Empresa_Id Int, 
	@Historico bit,
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Vendedor_Id VarChar(5) = NULL
)
as

SELECT venClientes.Cliente_Id, venClientes.RazonSocial , @Historico as Historico,
@FechaDesde FechaDesde, @FechaHasta FechaHasta
FROM venClientes
Where
	venClientes.Cliente_Id = @Cliente_Id

SELECT dbo.Segmento( venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, 
	venPediSegmentos.Segmento3C,venPediSegmentos.Segmento4C,venPediSegmentos.Segmento1N, 
	venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N
	) AS Segmento, venPedidos.Fecha, venPedidos.Estado, venPedidos.ImporteTotal,
		genMonedas.Moneda_Id,
	venPedidos.Observaciones, genUsuarios.Apellido_y_Nombres Usuario, venPedidos.CliOrdenCompra
	FROM venPedidos INNER JOIN venClientes ON 
		venPedidos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venPediSegmentos ON venPediSegmentos.venPedidos = venPedidos.venPedidos
		INNER JOIN genUsuarios ON genUsuarios.genUsuarios = venPedidos.Usuario_Id
		INNER JOIN genMonedas ON genMonedas.genMonedas = venPedidos.Moneda_Id
		INNER JOIN venVendedores ON venVendedores.venVendedores = venPedidos.Vendedor_Id
WHERE
	venClientes.Cliente_Id = @Cliente_Id AND 
	venPedidos.Empresa_Id = @Empresa_Id and 
	venPedidos.Estado NOT IN ('N','R') and 
	((@Historico = 0 and venPedidos.Estado!= 'T') OR
	(@Historico = 1 and venPedidos.Fecha Between @FechaDesde and @FechaHasta)) and
	venVendedores.Vendedor_Id = ISNULL(@Vendedor_Id, venVendedores.Vendedor_Id)
ORDER BY 2,1

SELECT stkProductos.Producto_Id, stkProductos.Descripcion, genMonedas.Moneda_Id,
		SUM(VenPediCuerpo.CantidadPedida) as Pedidos, 
		SUM(VenPediCuerpo.CantidadRemitida) as Remitidos,
		SUM(VenPediCuerpo.CantidadPedida*VenPediCuerpo.PrecioVenta) /SUM(VenPediCuerpo.CantidadPedida) Precio
FROM venPedidos INNER JOIN venClientes ON 
		venPedidos.Cliente_Id = venClientes.genEntidades
		INNER JOIN venPediCuerpo ON 
		venPediCuerpo.venPedidos = venPedidos.venPedidos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venPediCuerpo.Producto_Id
		INNER JOIN genMonedas ON genMonedas.genMonedas = venPedidos.Moneda_Id
		INNER JOIN venVendedores ON venVendedores.venVendedores = venPedidos.Vendedor_Id
WHERE
	venClientes.Cliente_Id = @Cliente_Id AND 
	venPedidos.Empresa_Id = @Empresa_Id and 
	venPedidos.Estado NOT IN ('N','R') and 
	((@Historico = 0 and venPedidos.Estado!= 'T' AND venPediCuerpo.Pendiente=1 and 
		venPediCuerpo.CantidadRemitida < venPediCuerpo.CantidadPedida ) OR
	(@Historico = 1 and venPedidos.Fecha Between @FechaDesde and @FechaHasta)) AND
	venVendedores.Vendedor_Id = ISNULL(@Vendedor_Id, venVendedores.Vendedor_Id) 
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, genMonedas.Moneda_Id
ORDER BY 1