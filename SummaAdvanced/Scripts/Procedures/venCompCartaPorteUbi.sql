DROP PROCEDURE venCompCartaPorteUbiGuardar
GO
CREATE PROCEDURE venCompCartaPorteUbiGuardar
(
@pvenmovimientos bigint,
@pUbicacion int,
@pTipoEstacion varchar(2) = NULL,
@pDistanciaRecorrida numeric(5,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCompCartaPorteUbi WHERE (venmovimientos = @pvenmovimientos) AND (Ubicacion = @pUbicacion)))
BEGIN 
	UPDATE venCompCartaPorteUbi
	SET		TipoEstacion = @pTipoEstacion,
		DistanciaRecorrida = @pDistanciaRecorrida
	WHERE (venmovimientos = @pvenmovimientos) AND (Ubicacion = @pUbicacion)
END 
ELSE 
BEGIN 
	INSERT INTO venCompCartaPorteUbi
	(
		venmovimientos,
		Ubicacion,
		TipoEstacion,
		DistanciaRecorrida
	)
	VALUES 
	(
		@pvenmovimientos,
		@pUbicacion,
		@pTipoEstacion,
		@pDistanciaRecorrida
	)
END 

GO

DROP PROCEDURE venCompCartaPorteUbiDatos
GO
CREATE PROCEDURE venCompCartaPorteUbiDatos
(
@pvenmovimientos bigint,
@pUbicacion int = NULL
)
AS
SET NOCOUNT ON 

SELECT venCompCartaPorteUbi.venmovimientos,  venCompCartaPorteUbi.Ubicacion, venCompCartaPorteUbi.TipoEstacion,
	venCompCartaPorteUbi.DistanciaRecorrida
FROM venCompCartaPorteUbi 
INNER JOIN venCompCartaPorte  ON (venCompCartaPorte.venmovimientos = venCompCartaPorteUbi.venmovimientos)
WHERE (venCompCartaPorteUbi.venmovimientos = @pvenmovimientos)
AND (venCompCartaPorteUbi.Ubicacion = ISNULL(@pUbicacion, venCompCartaPorteUbi.Ubicacion))
 
RETURN @@Error 

GO

DROP PROCEDURE venCompCartaPorteUbiEliminar
GO
CREATE PROCEDURE venCompCartaPorteUbiEliminar
(
@pvenmovimientos bigint,
@pUbicacion int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCompCartaPorteUbi 
WHERE (venmovimientos = @pvenmovimientos)
AND (Ubicacion = ISNULL(@pUbicacion, Ubicacion))
 
 RETURN @@Error 

GO

GO
