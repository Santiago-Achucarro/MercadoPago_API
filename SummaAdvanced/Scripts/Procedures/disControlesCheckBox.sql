DROP PROCEDURE disControlesCheckBoxGuardar
GO
CREATE PROCEDURE disControlesCheckBoxGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pChecked Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesCheckBox WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesCheckBox
	SET		Checked = @pChecked
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesCheckBox
	(
		Formulario_Id,
		Control_Id,
		Checked
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pChecked
	)
END 

GO


DROP PROCEDURE disControlesCheckBoxEliminar
GO
CREATE PROCEDURE disControlesCheckBoxEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesCheckBox 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
