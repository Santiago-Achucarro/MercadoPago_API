DROP PROCEDURE disControlesIndicadorGuardar
GO
CREATE PROCEDURE disControlesIndicadorGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pTipo varchar(30),
@pDecimales smallint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesIndicador WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesIndicador
	SET	Tipo = @pTipo, 
		Decimales = @pDecimales
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesIndicador
	(
		Formulario_Id,
		Control_Id,
		Tipo,
		Decimales
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pTipo,
		@pDecimales
	)
END 

GO


DROP PROCEDURE disControlesIndicadorEliminar
GO
CREATE PROCEDURE disControlesIndicadorEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesIndicador 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
