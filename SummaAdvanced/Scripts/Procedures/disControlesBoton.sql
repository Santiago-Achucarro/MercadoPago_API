DROP PROCEDURE disControlesBotonGuardar
GO
CREATE PROCEDURE disControlesBotonGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pControlAsociado_Id varchar(200) = NULL,
@pAsociadoAFilaGrilla bit = NULL,
@pIcono varchar(40) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesBoton WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesBoton
	SET	ControlAsociado_Id = @pControlAsociado_Id, 
		AsociadoAFilaGrilla = @pAsociadoAFilaGrilla,
		Icono = @pIcono	
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesBoton
	(
		Formulario_Id,
		Control_Id,
		ControlAsociado_Id,
		AsociadoAFilaGrilla, 
		Icono
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pControlAsociado_Id,
		@pAsociadoAFilaGrilla,
		@pIcono
	)
END 

GO


DROP PROCEDURE disControlesBotonEliminar
GO
CREATE PROCEDURE disControlesBotonEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesBoton 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

