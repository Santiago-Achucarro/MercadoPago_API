DROP PROCEDURE disControlesLinkGuardar
GO
CREATE PROCEDURE disControlesLinkGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pLink varchar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesLink WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesLink
	SET	Link = @pLink 
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesLink
	(
		Formulario_Id,
		Control_Id,
		Link
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pLink
	)
END 

GO


DROP PROCEDURE disControlesLinkEliminar
GO
CREATE PROCEDURE disControlesLinkEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesLink 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
