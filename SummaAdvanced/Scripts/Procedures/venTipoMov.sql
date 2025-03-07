DROP PROCEDURE venTipoMovGuardar
GO
CREATE PROCEDURE venTipoMovGuardar
(
@pvenTipoMov char(1),
@pDescripcion char(50),
@pSigno smallint,
@pTipoMovResumido char(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venTipoMov WHERE (venTipoMov = @pvenTipoMov)))
BEGIN 
	UPDATE venTipoMov
	SET		Descripcion = @pDescripcion,
		Signo = @pSigno,
		TipoMovResumido = @pTipoMovResumido
	WHERE (venTipoMov = @pvenTipoMov)
END 
ELSE 
BEGIN 
	INSERT INTO venTipoMov
	(
		venTipoMov,
		Descripcion,
		Signo,
		TipoMovResumido
	)
	VALUES 
	(
		@pvenTipoMov,
		@pDescripcion,
		@pSigno,
		@pTipoMovResumido
	)
END 

GO

DROP PROCEDURE venTipoMovDatos
GO
CREATE PROCEDURE venTipoMovDatos
(
@pvenTipoMov char(1)
)
AS
SET NOCOUNT ON 

SELECT venTipoMov.venTipoMov, venTipoMov.Descripcion, venTipoMov.Signo, venTipoMov.TipoMovResumido
FROM venTipoMov 
WHERE (venTipoMov = @pvenTipoMov)
 
 RETURN @@Error 

GO

DROP PROCEDURE venTipoMovEliminar
GO
CREATE PROCEDURE venTipoMovEliminar
(
@pvenTipoMov char(1) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venTipoMov 
WHERE (venTipoMov = ISNULL(@pvenTipoMov, venTipoMov))
 
 RETURN @@Error 

GO

GO
