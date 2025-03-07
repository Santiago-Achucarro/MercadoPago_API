DROP PROCEDURE comCFDISatPagoGuardar
GO
CREATE PROCEDURE comCFDISatPagoGuardar
(
@pUUID char(36),
@pRenglon int,
@pUUIDR varchar(36),
@pMonto qMonedaD2,
@pMoneda varchar(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comCFDISatPago WHERE (UUID = @pUUID) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE comCFDISatPago
	SET		UUIDR = @pUUIDR,
		Monto = @pMonto,
		Moneda = @pMoneda
	WHERE (UUID = @pUUID) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comCFDISatPago
	(
		UUID,
		Renglon,
		UUIDR,
		Monto,
		Moneda
	)
	VALUES 
	(
		@pUUID,
		@pRenglon,
		@pUUIDR,
		@pMonto,
		@pMoneda
	)
END 

GO

DROP PROCEDURE comCFDISatPagoDatos
GO
CREATE PROCEDURE comCFDISatPagoDatos
(
@pUUID char(36),
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT comCFDISatPago.UUID, comCFDISatPago.Renglon, comCFDISatPago.UUIDR,
	comCFDISatPago.Monto, comCFDISatPago.Moneda
FROM comCFDISatPago 
INNER JOIN comCFDISat  ON (comCFDISat.UUID = comCFDISatPago.UUID)
WHERE (comCFDISat.UUID = @pUUID)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE comCFDISatPagoEliminar
GO
CREATE PROCEDURE comCFDISatPagoEliminar
(
@pUUID char(36),
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comCFDISatPago 
WHERE (UUID = @pUUID)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
