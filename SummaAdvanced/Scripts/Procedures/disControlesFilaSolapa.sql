DROP PROCEDURE disControlesFilaSolapaGuardar
GO
CREATE PROCEDURE disControlesFilaSolapaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pFila int,
@pAlto int,
@pTipoValor char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesFilaSolapa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Fila = @pFila)))
BEGIN 
	UPDATE disControlesFilaSolapa
	SET		Alto = @pAlto,
		TipoValor = @pTipoValor
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Fila = @pFila)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesFilaSolapa
	(
		Formulario_Id,
		Control_Id,
		Fila,
		Alto,
		TipoValor
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pFila,
		@pAlto,
		@pTipoValor
	)
END 

GO


DROP PROCEDURE disControlesFilaSolapaEliminar
GO
CREATE PROCEDURE disControlesFilaSolapaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pFila int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesFilaSolapa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (Fila = ISNULL(@pFila, Fila))
 
 RETURN @@Error 

GO

GO
