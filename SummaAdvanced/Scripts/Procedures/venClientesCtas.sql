DROP PROCEDURE venClientesCtasGuardar
GO
CREATE PROCEDURE venClientesCtasGuardar
(
@pCliente_Id bigint,
@pMoneda_Id VarChar(5),
@pCuentaDxVtas varchar(25),
@pCtaFactAnticipo varchar(25),
@pCtaAnticipo varchar(25), 
@pParaPedidos Bit, 
@pParaFactura Bit 
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venClientesCtas WHERE (Cliente_Id = @pCliente_Id) AND 
	(Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))))
BEGIN 
	UPDATE venClientesCtas
	SET		CuentaDxVtas = dbo.FuncFKconCuentas(@pCuentaDxVtas),
		CtaFactAnticipo = dbo.FuncFKconCuentas(@pCtaFactAnticipo),
		CtaAnticipo = dbo.FuncFKconCuentas(@pCtaAnticipo), 
		ParaFactura = @pParaFactura, 
		ParaPedidos = @pParaPedidos
	WHERE (Cliente_Id = @pCliente_Id) AND (Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))
END 
ELSE 
BEGIN 
	INSERT INTO venClientesCtas
	(
		Cliente_Id,
		Moneda_Id,
		CuentaDxVtas,
		CtaFactAnticipo,
		CtaAnticipo, 
		ParaFactura, 
		ParaPedidos
	)
	VALUES 
	(
		@pCliente_Id,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKconCuentas(@pCuentaDxVtas),
		dbo.FuncFKconCuentas(@pCtaFactAnticipo),
		dbo.FuncFKconCuentas(@pCtaAnticipo), 
		@pParaFactura, 
		@pParaPedidos
	)
END 

GO

DROP PROCEDURE venClientesCtasDatos
GO
CREATE PROCEDURE venClientesCtasDatos
(
@pCliente_Id VarChar(15),
@pMoneda_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT 	venClientes.genEntidades, venClientes.Cliente_Id, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	CuentaDxVtas.Cuenta_Id as CuentaDxVtas, CuentaDxVtas.Descripcion as DescripcionCuentaDxVtas, 
	CtaFactAnticipo.Cuenta_Id as CtaFactAnticipo, CtaFactAnticipo.Descripcion as DescripcionCtaFactAnticipo,
	CtaAnticipo.Cuenta_Id as CtaAnticipo , CtaAnticipo.Descripcion as DescripcionCtaAnticipo, 
	venClientesCtas.ParaFactura, venClientesCtas.ParaPedidos
FROM venClientesCtas 
INNER JOIN venClientes  ON (venClientes.genEntidades = venClientesCtas.Cliente_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = venClientesCtas.Moneda_Id)
INNER JOIN conCuentas  as CuentaDxVtas ON (CuentaDxVtas.conCuentas = venClientesCtas.CuentaDxVtas)
INNER JOIN conCuentas CtaFactAnticipo ON (CtaFactAnticipo.conCuentas = venClientesCtas.CtaFactAnticipo)
INNER JOIN conCuentas CtaAnticipo ON (CtaAnticipo.conCuentas = venClientesCtas.CtaAnticipo)
WHERE (venClientes.Cliente_Id = @pCliente_Id)
AND (genMonedas.Moneda_Id = @pMoneda_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE venClientesCtasEliminar
GO
CREATE PROCEDURE venClientesCtasEliminar
(
@pCliente_Id bigint,
@pMoneda_Id varchar(3)= NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venClientesCtas 
WHERE (Cliente_Id = @pCliente_Id)
AND (Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) or @pMoneda_id IS NULL)
 
 RETURN @@Error 

GO


