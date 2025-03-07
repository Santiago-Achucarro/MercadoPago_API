DROP PROCEDURE disControlesTextoGuardar
GO
CREATE PROCEDURE disControlesTextoGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pMultiplesLineas Sino,
@pCharCasing varchar(6),
@pMascara varchar(40) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesTexto WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesTexto
	SET	MultiplesLineas = @pMultiplesLineas,
		CharCasing = @pCharCasing,
		Mascara = @pMascara
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesTexto
	(
		Formulario_Id,
		Control_Id,
		MultiplesLineas,
		CharCasing,
		Mascara
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pMultiplesLineas,
		@pCharCasing,
		@pMascara
	)
END 

GO


DROP PROCEDURE disControlesTextoEliminar
GO
CREATE PROCEDURE disControlesTextoEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesTexto 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO
