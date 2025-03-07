DROP PROCEDURE comProveedoresTipoPasivoGuardar
GO
CREATE PROCEDURE comProveedoresTipoPasivoGuardar
(
@pTipoCtaProv int,
@pDescripcion varchar(100)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comProveedoresTipoPasivo WHERE (TipoCtaProv = @pTipoCtaProv)))
BEGIN 
	UPDATE comProveedoresTipoPasivo
	SET		Descripcion = @pDescripcion
	WHERE (TipoCtaProv = @pTipoCtaProv)
END 
ELSE 
BEGIN 
	INSERT INTO comProveedoresTipoPasivo
	(
		TipoCtaProv,
		Descripcion
	)
	VALUES 
	(
		@pTipoCtaProv,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE comProveedoresTipoPasivoDatos
GO
CREATE PROCEDURE comProveedoresTipoPasivoDatos
(
@pTipoCtaProv int
)
AS
SET NOCOUNT ON 

SELECT comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion
FROM comProveedoresTipoPasivo 
WHERE (TipoCtaProv = @pTipoCtaProv)
 
 RETURN @@Error 

GO

DROP PROCEDURE comProveedoresTipoPasivoEliminar
GO
CREATE PROCEDURE comProveedoresTipoPasivoEliminar
(
@pTipoCtaProv int 
)
AS
SET NOCOUNT ON 

DELETE FROM comProveedoresTipoPasivo 
WHERE @pTipoCtaProv = TipoCtaProv
 
 RETURN @@Error 

GO

