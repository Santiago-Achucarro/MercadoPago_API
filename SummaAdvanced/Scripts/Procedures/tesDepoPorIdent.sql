DROP PROCEDURE tesDepoPorIdentGuardar
GO
CREATE PROCEDURE tesDepoPorIdentGuardar
(
@ptesMovimientos bigint,
@pvenMovimientos bigint = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesDepoPorIdent WHERE (tesMovimientos = @ptesMovimientos)))
BEGIN 
	UPDATE tesDepoPorIdent
	SET		venMovimientos = @pvenMovimientos
	WHERE (tesMovimientos = @ptesMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO tesDepoPorIdent
	(
		tesMovimientos,
		venMovimientos
	)
	VALUES 
	(
		@ptesMovimientos,
		@pvenMovimientos
	)
END 

GO

DROP PROCEDURE tesDepoPorIdentDatos
GO
CREATE PROCEDURE tesDepoPorIdentDatos
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT tesDepoPorIdent.tesMovimientos, tesDepoPorIdent.venMovimientos
FROM tesDepoPorIdent 
WHERE (tesMovimientos = @ptesMovimientos)
 
EXEC tesDepoPorIdentImpDatos @ptesMovimientos
RETURN @@Error 

GO

DROP PROCEDURE tesDepoPorIdentEliminar
GO
CREATE PROCEDURE tesDepoPorIdentEliminar
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM tesDepoPorIdent 
WHERE (tesMovimientos = @ptesMovimientos)
 
 RETURN @@Error 

GO


DROP PROCEDURE tesDepoPorIdentVenDatos
GO
CREATE PROCEDURE tesDepoPorIdentVenDatos
(
@pVenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT tesDepoPorIdent.tesMovimientos, tesDepoPorIdent.venMovimientos
FROM tesDepoPorIdent 
WHERE (venMovimientos = @pVenMovimientos)


RETURN @@Error 

GO