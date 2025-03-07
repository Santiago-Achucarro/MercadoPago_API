-- INF_venPediRetCreditos ' ','zzz',1

DROP PROCEDURE INF_venPediRetCreditos
GO
CREATE PROCEDURE INF_venPediRetCreditos (
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
genMonedas.Moneda_id, venpedidos.ImporteTotal
From venpedidos INNER JOIN venPediSegmentos ON
venpedidos.venpedidos = venPediSegmentos.venpedidos
inner join venClientes ON
venpedidos.Cliente_Id = venClientes.genEntidades
inner join venVendedores ON 
venVendedores.venVendedores = venPedidos.Vendedor_Id
inner join genMonedas ON
genMonedas.genMonedas = venPedidos.Moneda_Id
WHERE
	venPedidos.Empresa_id = @Empresa and 
	venpedidos.Estado = 'P' AND 
	-- venpedidos.Motivo_id IS NOT NULL AND 
	venpedidos.UsuarioAutoriz_id IS NULL and 
	venVendedores.Vendedor_Id between @VendedorDesde and @VendedorHasta
ORDER BY 2,3,4,5,6,7,8,9
	
	
	