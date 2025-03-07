Drop procedure espTicketModificar
Go
Create procedure espTicketModificar
(
@pconAsientos bigint,
@pFecha datetime,
@pCliente_Id varchar(15)
)
As
Update conAsientos Set Fecha = @pFecha Where conAsientos = @pconAsientos

Update venMovimientos Set Cliente_Id = venClientes.genEntidades, venTipomov = 'F', venSubTipoMov_Id = dbo.FuncFKvenSubTipoMov('FCSTK')
From venClientes 
Where venMovimientos.venMovimientos = @pconAsientos And venClientes.Cliente_Id = @pCliente_Id

Update genMovCuotas Set FechaVencimiento = @pFecha Where Asiento_Id = @pconAsientos
Go

