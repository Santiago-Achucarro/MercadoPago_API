DROP PROCEDURE disControlesGrupoSolapaGuardar
GO
CREATE PROCEDURE disControlesGrupoSolapaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pCantSolapas int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesGrupoSolapa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesGrupoSolapa
	SET		CantSolapas = @pCantSolapas
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesGrupoSolapa
	(
		Formulario_Id,
		Control_Id,
		CantSolapas
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pCantSolapas
	)
END 

GO

DROP PROCEDURE disControlesGrupoSolapaEliminar
GO
CREATE PROCEDURE disControlesGrupoSolapaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesGrupoSolapa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
