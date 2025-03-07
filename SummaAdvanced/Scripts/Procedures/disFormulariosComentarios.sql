DROP PROCEDURE disFormulariosComentariosGuardar
GO

CREATE PROCEDURE disFormulariosComentariosGuardar
(
@pFormulario_Id int,
@pFechaRegistro Datetime,
@pFechaRegistroOrig Datetime,
@pFechaUltModif Datetime,
@pComentario QMemo, 
@pFormularioRegOrig_Id varchar(30) = NULL,
@pComentario_Id int = NULL,
@pTipoComentario char(1) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disFormulariosComentarios WHERE (Formulario_Id = @pFormulario_Id) AND (FechaRegistro = @pFechaRegistro)))
BEGIN 
	UPDATE disFormulariosComentarios
	SET	FechaRegistroOrig = @pFechaRegistroOrig,
		FechaUltModif = FechaUltModif,
		Comentario = @pComentario, 
		--FormularioRegOrig_Id = dbo.FuncFKdisFormularios(@pFormularioRegOrig_Id)
		FormularioRegOrig_Id = @pFormularioRegOrig_Id,
		Comentario_Id = @pComentario_Id,
		TipoComentario = @pTipoComentario
	WHERE (Formulario_Id = @pFormulario_Id) AND (FechaRegistro = @pFechaRegistro)
END 
ELSE 
BEGIN 
	INSERT INTO disFormulariosComentarios
	(
		Formulario_Id,
		FechaRegistro,
		FechaRegistroOrig,
		FechaUltModif,
		Comentario, 
		FormularioRegOrig_Id,
		Comentario_Id,
		TipoComentario
	)
	VALUES 
	(
		@pFormulario_Id,
		@pFechaRegistro,
		@pFechaRegistroOrig,
		@pFechaUltModif,
		@pComentario, 
		--dbo.FuncFKdisFormularios(@pFormularioRegOrig_Id)
		@pFormularioRegOrig_Id,
		@pComentario_Id,
		@pTipoComentario
	)
END 

GO


DROP PROCEDURE disFormulariosComentariosEliminar
GO
CREATE PROCEDURE disFormulariosComentariosEliminar
(
@pFormulario_Id varchar(30)
)
AS
SET NOCOUNT ON 

DELETE FROM disFormulariosComentarios 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
 
RETURN @@Error 

GO

GO
