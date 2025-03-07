DROP PROCEDURE disAccionesTablasaEnviarGuardar
GO
CREATE PROCEDURE disAccionesTablasaEnviarGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pTipoEvento varchar(30),
@pOrdenAccion smallint,
@pTabla_Id varchar(40)
)
AS
SET NOCOUNT ON 
IF (NOT EXISTS (SELECT 1 FROM disAccionesTablasaEnviar WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (TipoEvento = @pTipoEvento) AND (OrdenAccion = @pOrdenAccion) AND (Tabla_Id = @pTabla_Id)))
BEGIN 
	INSERT INTO disAccionesTablasaEnviar
	(
		Formulario_Id,
		Control_Id,
		TipoEvento,
		OrdenAccion,
		Tabla_Id
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pTipoEvento,
		@pOrdenAccion,
		@pTabla_Id
	)
END 

GO

DROP PROCEDURE disAccionesTablasaEnviarEliminar
GO
CREATE PROCEDURE disAccionesTablasaEnviarEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pTipoEvento varchar(30) = NULL,
@pOrdenAccion smallint = NULL,
@pTabla_Id varchar(40) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disAccionesTablasaEnviar 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (TipoEvento = ISNULL(@pTipoEvento, TipoEvento))
AND (OrdenAccion = ISNULL(@pOrdenAccion, OrdenAccion))
AND (Tabla_Id = ISNULL(@pTabla_Id, Tabla_Id))
 RETURN @@Error 

GO

