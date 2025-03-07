DROP PROCEDURE tesAIChequesGuardar
GO
CREATE PROCEDURE tesAIChequesGuardar
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pRenglon int,
@pFechaVencimiento datetime,
@pChequera_Id int,
@pnumCheque int,
@pAlaOrden varchar(120),
@pImporte qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesAICheques WHERE (Cartera_Id =dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (Empresa_Id = @pEmpresa_Id) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE tesAICheques
	SET		Empresa_Id = @pEmpresa_Id,
		FechaVencimiento = @pFechaVencimiento,
		Chequera_Id = @pChequera_Id,
		numCheque = @pnumCheque,
		AlaOrden = @pAlaOrden,
		Importe = @pImporte
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (Empresa_Id = @pEmpresa_Id) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesAICheques
	(
		Cartera_Id,
		Empresa_Id,
		Renglon,
		FechaVencimiento,
		Chequera_Id,
		numCheque,
		AlaOrden,
		Importe
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pEmpresa_Id,
		@pRenglon,
		@pFechaVencimiento,
		@pChequera_Id,
		@pnumCheque,
		@pAlaOrden,
		@pImporte
	)
END 

GO

DROP PROCEDURE tesAIChequesDatos
GO
CREATE PROCEDURE tesAIChequesDatos
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT 
	tesAICheques.Empresa_Id, tesIdentifica.Cartera_Id, tesAICheques.Renglon, tesAICheques.FechaVencimiento, 
	tesAICheques.Chequera_Id, tesAICheques.numCheque,	
	tesAICheques.AlaOrden, tesAICheques.Importe
FROM tesAICheques 
INNER JOIN tesChequeras  ON (tesChequeras.Chequera_Id = tesAICheques.Chequera_Id) AND 
			(tesChequeras.Cartera_Id = tesAICheques.Cartera_Id) AND 
			(tesChequeras.Empresa_Id = tesAICheques.Empresa_Id)
inner join tesIdentifica ON
tesIdentifica.tesIdentifica = tesAICheques.Cartera_Id
WHERE tesIdentifica.Cartera_Id = @pCartera_Id AND 
	  tesAICheques.Empresa_Id = @pEmpresa_Id AND 
	  tesAICheques.Renglon = isnull(@pRenglon,tesAICheques.Renglon)
 
RETURN @@Error 

GO

DROP PROCEDURE tesAIChequesEliminar
GO
CREATE PROCEDURE tesAIChequesEliminar
(
@pCartera_Id VarChar(5),
@pEmpresa_Id int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesAICheques 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
AND (Empresa_Id = @pEmpresa_Id)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

