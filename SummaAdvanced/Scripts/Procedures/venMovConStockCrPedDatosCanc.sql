drop  procedure venMovConStockCrPedDatosCanc
go
create procedure venMovConStockCrPedDatosCanc
(
    @pvenPedidos bigint=null,
    @pRenglon_Pe int =null,
    @pvenMovimientos bigint=null,
    @pRenglon_Ventas int =null
)
as
select venMovConStockCrPed.venPedidos, venMovConStockCrPed.Renglon_Pe, venMovConStockCrPed.venMovimientos,
venMovConStockCrPed.RenglonCuerpo, venMovConStockCr.CantEntregada, venMovConStockCr.CantFacturada , 
	venPediCuerpo.ReservaMercaderia, stkDepositos.Deposito_Id, stkProductos.Producto_Id, venMovConStockCrPed.venReparto
From venMovConStockCrPed inner join venMovConStockCr on venMovConStockCr.venMovimientos=venMovConStockCrPed.venMovimientos and 
														venMovConStockCr.RenglonCuerpo=venMovConStockCrPed.RenglonCuerpo
						 inner join venPediCuerpo ON	venPediCuerpo.venPedidos= venMovConStockCrPed.venPedidos AND
													    venPediCuerpo.Renglon_Pe = venMovConStockCrPed.Renglon_Pe				
						 Inner join stkDepositos ON stkDepositos.stkDepositos =venMovConStockCr.Deposito_Id
						 inner join stkProductos ON stkProductos.stkProductos=venMovConStockCr.Producto_Id
WHERE
	venMovConStockCrPed.venPedidos = isnull(@pvenPedidos, venMovConStockCrPed.venPedidos) and 
	venMovConStockCrPed.Renglon_Pe = isnull(@pRenglon_Pe, venMovConStockCrPed.Renglon_Pe) and 
	venMovConStockCrPed.venMovimientos = isnull(@pvenMovimientos, venMovConStockCrPed.venMovimientos) and 
	venMovConStockCrPed.RenglonCuerpo = isnull(@pRenglon_Ventas, venMovConStockCrPed.RenglonCuerpo) 

go