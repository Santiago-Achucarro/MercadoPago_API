
-- INF_venPedRankCliente '20170101','20171231', 1

DROP PROCEDURE INF_venPedRankCliente
GO
CREATE PROCEDURE INF_venPedRankCliente (
@FechaDesde DateTime,
@FechaHasta DateTime,
@Empresa int)

AS

SELECT genMonedas.genMonedas,
dbo.func_TipoCambio(genMonedas.genMonedas, DATEADD(dd,1,@FechaHasta), @Empresa) as Cambio
INTO #CAMBIO
FROM genMonedas

select venClientes.Cliente_Id,  venClientes.RazonSocial,  
SUM(Convert(numeric(18,2) , venPediCuerpo.CantidadPedida * venPediCuerpo.PrecioVenta*Cambio.Cambio)) as Monto
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
inner join #CAMBIO Cambio on 
Cambio.genMonedas = genMonedas.genMonedas
WHERE
	venPedidos.Empresa_id = @Empresa and 
	venpedidos.Estado <> 'R' AND 
	venPedidos.Fecha Between @FechaDesde and @FechaHasta
GROUP BY venClientes.Cliente_Id,  venClientes.RazonSocial 	
ORDER BY 3 Desc
	
	
	