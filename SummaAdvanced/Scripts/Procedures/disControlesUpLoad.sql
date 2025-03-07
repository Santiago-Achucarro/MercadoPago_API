DROP PROCEDURE disControlesUpLoadGuardar
GO
CREATE PROCEDURE disControlesUpLoadGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pGuardaCaminoCompleto bit,
@pColumnaNombreInterno varchar(40) = NULL,
@pExtensionesPermitidas varchar(40) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesUpLoad WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesUpLoad
	SET		GuardaCaminoCompleto = @pGuardaCaminoCompleto,
		ColumnaNombreInterno = @pColumnaNombreInterno,
		ExtensionesPermitidas = @pExtensionesPermitidas
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesUpLoad
	(
		Formulario_Id,
		Control_Id,
		GuardaCaminoCompleto,
		ColumnaNombreInterno,
		ExtensionesPermitidas
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pGuardaCaminoCompleto,
		@pColumnaNombreInterno,
		@pExtensionesPermitidas
	)
END 

GO


DROP PROCEDURE disControlesUpLoadEliminar
GO
CREATE PROCEDURE disControlesUpLoadEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesUpLoad 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 
GO

GO