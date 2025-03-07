
-- INF_venPediAutorizados ' ','zzz', '20170101', '20170630',1

DROP PROCEDURE INF_venPediAutorizados
GO
CREATE PROCEDURE INF_venPediAutorizados (
@VendedorDesde Char(5),
@VendedorHasta Char(5), 
@FechaDesde DateTime, @FechaHasta DateTime,
@Empresa int )

AS
select venPediSegmentos.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id,
venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,  
venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,   
venPediSegmentos.Segmento4N) as Segmento, venClientes.Cliente_Id, 
venClientes.RazonSocial  , venPedidos.Fecha, 
venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVen,
venpedidos.ImporteTotal, genMonedas.Moneda_id,
genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as NombreUsuario
From venpedidos INNER JOIN venPediSegmentos ON
venpedidos.venpedidos = venPediSegmentos.venpedidos
inner join venClientes ON
venpedidos.Cliente_Id = venClientes.genEntidades
inner join venVendedores ON 
venVendedores.venVendedores = venPedidos.Vendedor_Id
inner join genUsuarios ON 
venpedidos.UsuarioAutoriz_id =genUsuarios.genUsuarios
inner join genMonedas ON
genMonedas.genMonedas = venPedidos.Moneda_Id
WHERE
	venPedidos.Empresa_id = @Empresa and 
	venpedidos.Estado <> 'R' AND 
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta and
	DATEADD(dd, 0, DATEDIFF(dd, 0, venPedidos.FechaAutorizo)) between @FechaDesde and @FechaHasta --FM que filtre solo por Date y no por Time
ORDER BY 2,3,4,5,6,7,8,9
	
	
	