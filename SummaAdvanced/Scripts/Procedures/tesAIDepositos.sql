DROP PROCEDURE tesAIDepositosGuardar
GO
CREATE PROCEDURE tesAIDepositosGuardar
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pRenglon int,
@pCarteraCheq_Id VarChar(5),
@pnumCheque int,
@pFechaVencimiento datetime,
@pImporte qMonedaD2,
@pClearing varchar(3),
@pBanco_Id varchar(3),
@pCliente_Id VarChar(15) = NULL,
@pcuentaBanco varchar(15),
@psucBanco varchar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesAIDepositos WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND 
		(Empresa_Id = @pEmpresa_Id) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE tesAIDepositos
	SET		Empresa_Id = @pEmpresa_Id,
		CarteraCheq_Id = dbo.FuncFKtesIdentifica(@pCarteraCheq_Id),
		FechaVencimiento = @pFechaVencimiento,
		Importe = @pImporte,
		Clearing = @pClearing,
		Banco_Id = dbo.FuncFKtesBancos(@pBanco_Id),
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		cuentaBanco = @pcuentaBanco,
		sucBanco = @psucBanco, 
		numCheque = @pnumCheque
	WHERE (Cartera_Id =dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (Empresa_Id = @pEmpresa_Id) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesAIDepositos
	(
		Cartera_Id,
		Empresa_Id,
		Renglon,
		CarteraCheq_Id,
		numCheque,
		FechaVencimiento,
		Importe,
		Clearing,
		Banco_Id,
		Cliente_Id,
		cuentaBanco,
		sucBanco
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pEmpresa_Id,
		@pRenglon,
		dbo.FuncFKtesIdentifica(@pCarteraCheq_Id),
		@pnumCheque,
		@pFechaVencimiento,
		@pImporte,
		@pClearing,
		dbo.FuncFKtesBancos(@pBanco_Id),
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pcuentaBanco,
		@psucBanco
	)
END 

GO

DROP PROCEDURE tesAIDepositosDatos
GO
CREATE PROCEDURE tesAIDepositosDatos
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.Cartera_Id, 
	tesAIDepositos.Empresa_Id, tesAIDepositos.Renglon, 
	tesIdCheqTerceros.Cartera_Id CarteraCheq_Id, 
	tesIdCheqTerceros.Descripcion as DescripcionIdCheqTerceros,
	tesAIDepositos.numCheque, 
	tesAIDepositos.FechaVencimiento, tesAIDepositos.Importe, 
	tesClearing.Clearing, tesClearing.Descripcion as DescripcionClearing,
	tesBancos.Banco_Id, tesBancos.Descripcion as DescripcionBancos, 
	venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionClientes,
	tesAIDepositos.cuentaBanco, tesAIDepositos.sucBanco
FROM tesAIDepositos 
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesAIDepositos.Cartera_Id
INNER JOIN tesIdentifica as tesIdCheqTerceros ON tesIdCheqTerceros.tesIdentifica = tesAIDepositos.CarteraCheq_Id
INNER JOIN tesClearing  ON (tesClearing.Clearing = tesAIDepositos.Clearing)
INNER JOIN tesBancos  ON (tesBancos.tesBancos = tesAIDepositos.Banco_Id)
LEFT JOIN venClientes  ON (venClientes.genEntidades = tesAIDepositos.Cliente_Id)
WHERE (tesIdentifica.Cartera_Id = @pCartera_Id)
AND (tesAIDepositos.Empresa_Id = @pEmpresa_Id)
AND (tesAIDepositos.Renglon = ISNULL(@pRenglon,tesAIDepositos.Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE tesAIDepositosEliminar
GO
CREATE PROCEDURE tesAIDepositosEliminar
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesAIDepositos 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (Empresa_Id = @pEmpresa_Id)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
RETURN @@Error 

GO

