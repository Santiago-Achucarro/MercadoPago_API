DROP PROCEDURE wooOrdenesCuitGuardar
GO
CREATE PROCEDURE wooOrdenesCuitGuardar
(
@pOrder_Id int,
@pCuit varchar(25) = NULL,
@pUsoCFDI varchar(3),
@pRegimen varchar(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooOrdenesCuit WHERE (Order_Id = @pOrder_Id)))
BEGIN 
	UPDATE wooOrdenesCuit
	SET		Cuit = @pCuit,
			UsoCFDI=@pUsoCFDI,
			Regimen=@pRegimen
	WHERE (Order_Id = @pOrder_Id)
END 
ELSE 
BEGIN 
	INSERT INTO wooOrdenesCuit
	(
		Order_Id,
		Cuit,
		UsoCFDI,
		Regimen
	)
	VALUES 
	(
		@pOrder_Id,
		@pCuit,
		@pUsoCFDI,
		@pRegimen
	)
END 

GO

DROP PROCEDURE wooOrdenesCuitEliminar
GO
CREATE PROCEDURE wooOrdenesCuitEliminar
(
@pOrder_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM wooOrdenesCuit 
WHERE (Order_Id = ISNULL(@pOrder_Id, Order_Id))
 
 RETURN @@Error 

GO

GO
