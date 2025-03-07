DROP PROCEDURE disEventosGuardar
GO
CREATE PROCEDURE disEventosGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pTipoEvento varchar(30),
@pEsMetodo bit,
@pHeredado bit,
@pHabilitado bit
)
AS
SET NOCOUNT ON 
IF (NOT EXISTS (SELECT 1 FROM disEventos WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (TipoEvento = @pTipoEvento)))
BEGIN 
	INSERT INTO disEventos
	(
		Formulario_Id,
		Control_Id,
		TipoEvento,
		esMetodo,
		Heredado,
		Habilitado
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pTipoEvento,
		@pEsMetodo,
		@pHeredado,
		@pHabilitado
	)
END 

GO


DROP PROCEDURE disEventosEliminar
GO
CREATE PROCEDURE disEventosEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pTipoEvento varchar(30) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disEventos 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (TipoEvento = ISNULL(@pTipoEvento, TipoEvento))
 
 RETURN @@Error 

GO

GO
