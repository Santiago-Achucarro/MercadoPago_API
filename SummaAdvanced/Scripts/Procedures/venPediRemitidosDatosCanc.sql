--exec venPediRemitidosDatosCanc null,null,124740,null
drop procedure venPediRemitidosDatosCanc
go
create procedure venPediRemitidosDatosCanc
(
    @pvenPedidos bigint=null,
    @pRenglon_Pedido int=null,
    @pstkMoviCabe bigint=null,
    @pRenglon_Stock int=null
)
as
select venPediRemitidos.venPedidos, venPediRemitidos.Renglon_Pe, venPediRemitidos.stkMoviCabe, venPediRemitidos.Renglon, 
	stkMoviCuerpo.Cantidad , venPediCuerpo.ReservaMercaderia, stkDepositos.Deposito_Id, stkProductos.Producto_Id
From venPediRemitidos 
inner join stkMoviCuerpo on stkMoviCuerpo.stkMoviCabe=venPediRemitidos.stkMoviCabe and stkMoviCuerpo.Renglon=venPediRemitidos.Renglon
inner join venPediCuerpo ON  venPediCuerpo.venPedidos = venPediRemitidos.venPedidos AND 
							 venPediCuerpo.Renglon_Pe = venPediRemitidos.Renglon_Pe
INNER JOIN stkProductos ON stkProductos.stkProductos = venPediCuerpo.Producto_Id 
INNER JOIN stkDepositos ON stkDepositos.stkDepositos= venPediCuerpo.Deposito_Id
where 
venPediRemitidos.venPedidos=isnull(@pvenPedidos, venPediRemitidos.venPedidos) and
venPediRemitidos.Renglon_Pe=isnull(@pRenglon_Pedido, venPediRemitidos.Renglon_Pe) and
venPediRemitidos.stkMoviCabe=isnull(@pstkMoviCabe, venPediRemitidos.stkMoviCabe) and
venPediRemitidos.Renglon=isnull(@pRenglon_Stock, venPediRemitidos.Renglon)
-- para el caso de factrua y remito en un solo paso
union all
select venMovConStockCrPed.venPedidos, venMovConStockCrPed.Renglon_Pe, 
	venMovStkHist.stkMoviCabe, venMovStkHist.Renglon, 
	stkMoviCuerpo.Cantidad , venPediCuerpo.ReservaMercaderia, stkDepositos.Deposito_Id, stkProductos.Producto_Id
From venMovStkHist 
INNER JOIN  venMovConStockCrPed ON
	venMovStkHist.venMovimientos = venMovConStockCrPed.venMovimientos AND
	venMovStkHist.RenglonCuerpo =venMovConStockCrPed.RenglonCuerpo
inner join stkMoviCuerpo on stkMoviCuerpo.stkMoviCabe=venMovStkHist.stkMoviCabe and stkMoviCuerpo.Renglon=venMovStkHist.Renglon
inner join venPediCuerpo ON  venPediCuerpo.venPedidos = venMovConStockCrPed.venPedidos AND 
							 venPediCuerpo.Renglon_Pe = venMovConStockCrPed.Renglon_Pe
INNER JOIN stkProductos ON stkProductos.stkProductos = venPediCuerpo.Producto_Id 
INNER JOIN stkDepositos ON stkDepositos.stkDepositos= venPediCuerpo.Deposito_Id
where 
venMovStkHist.FacturaRemito = '2' AND
venMovConStockCrPed.venPedidos=isnull(@pvenPedidos, venMovConStockCrPed.venPedidos) and
venMovConStockCrPed.Renglon_Pe=isnull(@pRenglon_Pedido, venMovConStockCrPed.Renglon_Pe) and
venMovStkHist.stkMoviCabe=isnull(@pstkMoviCabe, venMovStkHist.stkMoviCabe) and
venMovStkHist.Renglon=isnull(@pRenglon_Stock, venMovStkHist.Renglon) and
Not exists(select 1 from venPediRemitidos where
	venPediRemitidos.stkMoviCabe = venMovStkHist.stkMoviCabe and 
	venPediRemitidos.Renglon =venMovStkHist.Renglon)


go
