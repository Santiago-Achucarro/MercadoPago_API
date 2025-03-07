-- INF_venPedEstados '20190501','20190531',1,'002','002',1

DROP PROCEDURE INF_venPedEstados
GO
CREATE PROCEDURE INF_venPedEstados (
@FechaDesde DateTime,
@FechaHasta DateTime,
@Pendientes bit, 
@VendedorDesde Char(5),
@VendedorHasta Char(5),
@Empresa int
)

AS
SELECT 
venPediSegmentos.venPedidos, 
dbo.Segmento(genSegmentos.genSegmentos,
 venPediSegmentos.Segmento1C,  
venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,  
venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,   
venPediSegmentos.Segmento4N) as SegmentoStr, venClientes.Cliente_Id, 
venpedidos.Sucursal as SucCliente,
venClientes.RazonSocial  , venPedidos.Fecha, venPedidos.Fecha_Registro,
venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVen,
genMonedas.Moneda_id, 
Convert(Numeric(18,2),SUM(venPediCuerpo.CantidadPedida*venPediCuerpo.PrecioVenta)) as MontoMO,
Convert(Numeric(18,2),SUM((venPediCuerpo.CantidadPedida-venPediCuerpo.CantidadFacturada)*venPediCuerpo.PrecioVenta)) as MontoPendienteMO,
Convert(Numeric(18,2),SUM(venPediCuerpo.CantidadPedida*venPediCuerpo.PrecioVenta*venPedidos.Cambio)) as Monto,
Convert(Numeric(18,2),SUM((venPediCuerpo.CantidadPedida-venPediCuerpo.CantidadFacturada)*venPediCuerpo.PrecioVenta*venPedidos.Cambio)) as MontoPendiente,
venPedidos.Estado, 
case when venPedidos.UsuarioAutoriz_Id is null and venPedidos.Motivo_Id is not null and 
	venPedidos.Estado = 'P' THEN 1 ELSE 0 END AS RetenidoEnCredito, 
case when (select count(1) from venPediCuerpo  LEFT JOIN stkExistencia ON
	stkExistencia.Producto_Id  = venPediCuerpo.Producto_Id and 
	stkExistencia.Deposito_Id = venPediCuerpo.Deposito_Id
	Where
	venPediCuerpo.venPedidos = venPediSegmentos.venPedidos and 
	(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida) > ISNULL(stkExistencia.Cantidad,0) ) > 0
	then 1 else 0 end as FaltaStock, ISNULL(venPedidos.Observaciones,'') AS Observaciones ,
	@Pendientes Pend, @VendedorDesde VendD ,@VendedorHasta VendH 
From venpedidos 
INNER JOIN venPediSegmentos ON venpedidos.venpedidos = venPediSegmentos.venpedidos
inner join venClientes ON venpedidos.Cliente_Id = venClientes.genEntidades
inner join venVendedores ON venVendedores.venVendedores = venPedidos.Vendedor_Id
inner join venPediCuerpo ON venPediCuerpo.venPedidos = venpedidos.venpedidos 
inner join stkProductos ON stkProductos.stkProductos = venPediCuerpo.Producto_Id
inner join stkUniMed ON stkUniMed.stkUniMed = venPedicuerpo.Medida_Id
inner join genMonedas ON genMonedas.genMonedas = venPedidos.Moneda_Id
INNER JOIN genSegmentos ON genSegmentos.Segmento_Id = 'NP' 
WHERE
	venPedidos.Empresa_id = @Empresa AND
	venVendedores.Vendedor_Id BETWEEN @VendedorDesde AND @VendedorHasta AND
	venpedidos.Estado <> 'R' AND 
	((@Pendientes=0 AND venPedidos.Fecha Between @FechaDesde and @FechaHasta) OR
	(@Pendientes=1 AND venPedidos.Estado NOT IN ('N','T')))
GROUP BY venPediSegmentos.venPedidos, venPediSegmentos.Segmento1C,  
venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,  
venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N,   
venPediSegmentos.Segmento4N, venClientes.Cliente_Id, 
venClientes.RazonSocial  , venPedidos.Fecha, 
venVendedores.Vendedor_Id, venVendedores.Nombre,
genMonedas.Moneda_id, venPedidos.Estado, venPedidos.Motivo_Id,
venPedidos.UsuarioAutoriz_Id, genSegmentos.genSegmentos, venPedidos.Fecha_Registro, 
venPedidos.Observaciones, venpedidos.Sucursal 
ORDER BY 2,3,4,5,6,7,8 
	
	
	
