drop procedure venPedidosPendClie
go
create procedure venPedidosPendClie
(
    @pCliente_Id varchar(15)
)
as
select Segmento, Cliente_Id, RazonSocial, Fecha, Moneda_Id, Estado, ImporteTotal, Anticipo, AnticipoPendiente, Cambio from vvenPedidos
where 
Cliente_Id=@pCliente_Id AND Estado in ('A' ,'P')
go