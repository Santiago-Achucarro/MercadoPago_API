DROP PROCEDURE stkTiposMovGuardar
GO
CREATE PROCEDURE stkTiposMovGuardar
(
@pTipoMov varchar(2),
@pDescripcion varchar(50),
@pSigno smallint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkTiposMov WHERE (TipoMov = @pTipoMov)))
BEGIN 
	UPDATE stkTiposMov
	SET		Descripcion = @pDescripcion,
		Signo = @pSigno
	WHERE (TipoMov = @pTipoMov)
END 
ELSE 
BEGIN 
	INSERT INTO stkTiposMov
	(
		TipoMov,
		Descripcion,
		Signo
	)
	VALUES 
	(
		@pTipoMov,
		@pDescripcion,
		@pSigno
	)
END 

GO

DROP PROCEDURE stkTiposMovDatos
GO
CREATE PROCEDURE stkTiposMovDatos
(
@pTipoMov varchar(2)
)
AS
SET NOCOUNT ON 

SELECT stkTiposMov.TipoMov, stkTiposMov.Descripcion, stkTiposMov.Signo
FROM stkTiposMov 
WHERE (TipoMov = @pTipoMov)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkTiposMovEliminar
GO
CREATE PROCEDURE stkTiposMovEliminar
(
@pTipoMov varchar(2) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkTiposMov 
WHERE (TipoMov = ISNULL(@pTipoMov, TipoMov))
 
 RETURN @@Error 

GO

GO
