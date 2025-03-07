Drop Procedure venLimiteCreditoGuardar
GO
Create Procedure venLimiteCreditoGuardar
(
@pCliente_Id varchar(15), 
@pLimiteCredito numeric(18,2),
@pMoneda_Id VarChar(5)
) 
as
SET NOCOUNT ON

	update venClientes set LimiteCredito= @pLimiteCredito, 
		MonedaLimCred = dbo.FuncFKgenMonedas(@pMoneda_Id)
	Where 
	Cliente_Id=@pCliente_Id

	go


drop procedure venLimiteCreditoDatos
go
Create procedure venLimiteCreditoDatos
(
@pCliente_Ap varchar(15)
)
as
SET NOCOUNT ON
Select venClientes.Cliente_Id, venClientes.RazonSocial, 
venClientes.LimiteCredito, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda
From venClientes 
	left join genMonedas ON genMonedas.genMonedas =venClientes.MonedaLimCred
where 
venClientes.Cliente_Id=@pCliente_Ap
GO

