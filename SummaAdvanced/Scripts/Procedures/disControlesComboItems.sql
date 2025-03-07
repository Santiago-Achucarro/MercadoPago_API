DROP PROCEDURE disControlesComboItemsGuardar
GO
CREATE PROCEDURE disControlesComboItemsGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pValor varchar(30),
@pDescripcion varchar(60),
@pTipo varchar(20),
@pOrden int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesComboItems WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Valor = @pValor)))
BEGIN 
	UPDATE disControlesComboItems
	SET	Descripcion = @pDescripcion,
		Tipo = @pTipo,
		Orden = @pOrden
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Valor = @pValor)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesComboItems
	(
		Formulario_Id,
		Control_Id,
		Valor,
		Descripcion,
		Tipo,
		Orden
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pValor,
		@pDescripcion,
		@pTipo,
		@pOrden
	)
END 

GO

DROP PROCEDURE disControlesComboItemsEliminar
GO
CREATE PROCEDURE disControlesComboItemsEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pValor varchar(30) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesComboItems 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (Valor = ISNULL(@pValor, Valor))

 RETURN @@Error 

GO
