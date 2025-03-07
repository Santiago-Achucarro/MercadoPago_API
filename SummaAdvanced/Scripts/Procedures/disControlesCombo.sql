DROP PROCEDURE disControlesComboGuardar
GO
CREATE PROCEDURE disControlesComboGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pMultiSeleccion Sino,
@pCheckBoxes Sino,
@pIdentidad_Id varchar(30) = NULL,
@pEsOptionGroup bit, 
@pOptionGroupHorizontal bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesCombo WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesCombo
	SET	MultiSeleccion = @pMultiSeleccion,
		CheckBoxes = @pCheckBoxes,
		Identidad_Id = dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		EsOptionGroup = @pEsOptionGroup, 
		OptionGroupHorizontal = @pOptionGroupHorizontal
	WHERE (Formulario_Id = @pFormulario_Id) 
	AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesCombo
	(
		Formulario_Id,
		Control_Id,
		MultiSeleccion,
		CheckBoxes,
		Identidad_Id,
		EsOptionGroup, 
		OptionGroupHorizontal
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pMultiSeleccion,
		@pCheckBoxes,
		dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		@pEsOptionGroup, 
		@pOptionGroupHorizontal
	)
END 

GO

DROP PROCEDURE disControlesComboEliminar
GO
CREATE PROCEDURE disControlesComboEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesCombo 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
