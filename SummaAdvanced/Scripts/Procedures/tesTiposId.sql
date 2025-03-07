DROP PROCEDURE tesTiposIdGuardar
GO
CREATE PROCEDURE tesTiposIdGuardar
(
@pTipoCartera char(2),
@pTipoCartera_Nuevo char(2),
@pDescripcion varchar(35)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesTiposId WHERE (TipoCartera = @pTipoCartera)))
BEGIN 
	UPDATE tesTiposId
	SET		@lIdentidad = tesTiposId,
		TipoCartera = @pTipoCartera_Nuevo,
		Descripcion = @pDescripcion
	WHERE (TipoCartera = @pTipoCartera)
END 
ELSE 
BEGIN 
	INSERT INTO tesTiposId
	(
		TipoCartera,
		Descripcion
	)
	VALUES 
	(
		@pTipoCartera,
		@pDescripcion
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesTiposIdDatos
GO
CREATE PROCEDURE tesTiposIdDatos
(
@pTipoCartera char(2)
)
AS
SET NOCOUNT ON 

SELECT tesTiposId.tesTiposId, tesTiposId.TipoCartera, tesTiposId.Descripcion
FROM tesTiposId 
WHERE (TipoCartera = @pTipoCartera)
 


RETURN @@Error 

GO

DROP PROCEDURE tesTiposIdEliminar
GO
CREATE PROCEDURE tesTiposIdEliminar
(
@pTipoCartera char(2) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesTiposId 
WHERE (TipoCartera = @pTipoCartera)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesTiposId
GO

CREATE FUNCTION FuncFKtesTiposId
(
@pTipoCartera char (2)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesTiposId FROM tesTiposId WHERE 
	TipoCartera = @pTipoCartera
  RETURN @pIdentity
END


GO
