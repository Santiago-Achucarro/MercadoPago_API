DROP PROCEDURE disControlesParametrosGuardar
GO
CREATE PROCEDURE disControlesParametrosGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pTipoDato varchar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesParametros WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesParametros
	SET	TipoDato = @pTipoDato		
	WHERE (Formulario_Id = @pFormulario_Id) 
	AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesParametros
	(
		Formulario_Id,
		Control_Id,
		TipoDato
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pTipoDato
	)
END 

GO

DROP PROCEDURE disControlesParametrosEliminar
GO
CREATE PROCEDURE disControlesParametrosEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesParametros 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO
