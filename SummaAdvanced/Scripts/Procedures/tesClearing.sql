DROP PROCEDURE tesClearingGuardar
GO
CREATE PROCEDURE tesClearingGuardar
(
@pClearing varchar(3),
@pDescripcion varchar(35),
@pDias int,
@pcVariable char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesClearing WHERE (Clearing = @pClearing)))
BEGIN 
	UPDATE tesClearing
	SET		Descripcion = @pDescripcion,
		Dias = @pDias,
		cVariable = @pcVariable
	WHERE (Clearing = @pClearing)
END 
ELSE 
BEGIN 
	INSERT INTO tesClearing
	(
		Clearing,
		Descripcion,
		Dias,
		cVariable
	)
	VALUES 
	(
		@pClearing,
		@pDescripcion,
		@pDias,
		@pcVariable
	)
END 

GO

DROP PROCEDURE tesClearingDatos
GO
CREATE PROCEDURE tesClearingDatos
(
@pClearing varchar(3)
)
AS
SET NOCOUNT ON 

SELECT tesClearing.Clearing, tesClearing.Descripcion, tesClearing.Dias, tesClearing.cVariable
FROM tesClearing 
WHERE (Clearing = @pClearing)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesClearingEliminar
GO
CREATE PROCEDURE tesClearingEliminar
(
@pClearing varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesClearing 
WHERE (Clearing = ISNULL(@pClearing, Clearing))
 
 RETURN @@Error 

GO

GO
