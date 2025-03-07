DROP PROCEDURE disControlesColumnaSolapaGuardar
GO
CREATE PROCEDURE disControlesColumnaSolapaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pColumna int,
@pAncho int,
@pTipoValor char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesColumnaSolapa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Columna = @pColumna)))
BEGIN 
	UPDATE disControlesColumnaSolapa
	SET		Ancho = @pAncho,
		TipoValor = @pTipoValor
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Columna = @pColumna)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesColumnaSolapa
	(
		Formulario_Id,
		Control_Id,
		Columna,
		Ancho,
		TipoValor
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pColumna,
		@pAncho,
		@pTipoValor
	)
END 

GO


DROP PROCEDURE disControlesColumnaSolapaEliminar
GO
CREATE PROCEDURE disControlesColumnaSolapaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pColumna int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesColumnaSolapa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (Columna = ISNULL(@pColumna, Columna))
 
 RETURN @@Error 

GO

GO
