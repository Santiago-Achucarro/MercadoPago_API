DROP PROCEDURE venMoviPredialGuardar
GO
CREATE PROCEDURE venMoviPredialGuardar
(
@pvenMovimientos bigint,
@pconRenglon int,
@pCuentaPredial varchar(20)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMoviPredial WHERE (venMovimientos = @pvenMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE venMoviPredial
	SET		CuentaPredial = @pCuentaPredial
	WHERE (venMovimientos = @pvenMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venMoviPredial
	(
		venMovimientos,
		conRenglon,
		CuentaPredial
	)
	VALUES 
	(
		@pvenMovimientos,
		@pconRenglon,
		@pCuentaPredial
	)
END 

GO

DROP PROCEDURE venMoviPredialDatos
GO
CREATE PROCEDURE venMoviPredialDatos
(
@pvenMovimientos bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

SELECT venMoviPredial.venMovimientos, venMoviPredial.conRenglon, venMoviPredial.CuentaPredial
FROM venMoviPredial 
WHERE (venMovimientos = @pvenMovimientos)
AND (conRenglon = @pconRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMoviPredialEliminar
GO
CREATE PROCEDURE venMoviPredialEliminar
(
@pvenMovimientos bigint = NULL,
@pconRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMoviPredial 
WHERE (venMovimientos = ISNULL(@pvenMovimientos, venMovimientos))
AND (conRenglon = ISNULL(@pconRenglon, conRenglon))
 
 RETURN @@Error 

GO

GO
