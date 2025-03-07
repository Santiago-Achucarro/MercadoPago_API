DROP PROCEDURE disControlesRefSolapaGuardar
GO
CREATE PROCEDURE disControlesRefSolapaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pControlSolapaRef_Id varChar(200)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesRefSolapa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesRefSolapa
	SET	ControlSolapaRef_Id = @pControlSolapaRef_Id
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesRefSolapa
	(
		Formulario_Id,
		Control_Id,
		ControlSolapaRef_Id
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pControlSolapaRef_Id	
	)
END 

GO


DROP PROCEDURE disControlesRefSolapaEliminar
GO
CREATE PROCEDURE disControlesRefSolapaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesRefSolapa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
