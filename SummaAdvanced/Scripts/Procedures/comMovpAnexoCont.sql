DROP PROCEDURE comMovpAnexoContGuardar
GO
CREATE PROCEDURE comMovpAnexoContGuardar
(
@pAsiento_Id bigint,
@pconRenglon int,
@pRenglon int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comMovpAnexoCont WHERE (Asiento_Id = @pAsiento_Id) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE comMovpAnexoCont
	SET		Renglon = @pRenglon
	WHERE (Asiento_Id = @pAsiento_Id) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comMovpAnexoCont
	(
		Asiento_Id,
		conRenglon,
		Renglon
	)
	VALUES 
	(
		@pAsiento_Id,
		@pconRenglon,
		@pRenglon
	)
END 

GO

DROP PROCEDURE comMovpAnexoContDatos
GO
CREATE PROCEDURE comMovpAnexoContDatos
(
@pAsiento_Id bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

SELECT comMovpAnexoCont.Asiento_Id, comMovpAnexoCont.conRenglon, 
	comMovpAnexoCont.Renglon
FROM comMovpAnexoCont 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = comMovpAnexoCont.Asiento_Id) AND (conMovCont.Renglon = comMovpAnexoCont.conRenglon)
INNER JOIN comMovpAnexoDetalle  ON (comMovpAnexoDetalle.Asiento_Id = comMovpAnexoCont.Asiento_Id) AND (comMovpAnexoDetalle.Renglon = comMovpAnexoCont.Renglon)
WHERE (comMovpAnexoCont.Asiento_Id = @pAsiento_Id)
AND (comMovpAnexoCont.conRenglon = @pconRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE comMovpAnexoContEliminar
GO
CREATE PROCEDURE comMovpAnexoContEliminar
(
@pAsiento_Id bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

DELETE FROM comMovpAnexoCont 
WHERE (Asiento_Id = @pAsiento_Id)
AND (conRenglon = @pconRenglon)
 
 RETURN @@Error 

GO

GO
