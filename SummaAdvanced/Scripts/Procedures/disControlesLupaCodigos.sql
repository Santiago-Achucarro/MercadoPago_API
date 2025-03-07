DROP PROCEDURE disControlesLupaCodigosGuardar
GO
CREATE PROCEDURE disControlesLupaCodigosGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pCodigo smallint,
@pTipo varchar(20),
@pCharCasing varchar(6),
@pMask varchar(40) = NULL,
@pRegExpression varchar(50) = NULL,
@pMaxLength smallint,
@pTexto varchar(256) = NULL,
@pWidth int,
@pNombreColumna varchar(40)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesLupaCodigos WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Codigo = @pCodigo)))
BEGIN 
	UPDATE disControlesLupaCodigos
	SET		Tipo = @pTipo,
		CharCasing = @pCharCasing,
		Mask = @pMask,
		RegExpression = @pRegExpression,
		MaxLength = @pMaxLength,
		Texto = @pTexto,
		Width = @pWidth,
		NombreColumna = @pNombreColumna
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Codigo = @pCodigo)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesLupaCodigos
	(
		Formulario_Id,
		Control_Id,
		Codigo,
		Tipo,
		CharCasing,
		Mask,
		RegExpression,
		MaxLength,
		Texto,
		Width,
		NombreColumna
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pCodigo,
		@pTipo,
		@pCharCasing,
		@pMask,
		@pRegExpression,
		@pMaxLength,
		@pTexto,
		@pWidth,
		@pNombreColumna
	)
END 

GO

DROP PROCEDURE disControlesLupaCodigosEliminar
GO
CREATE PROCEDURE disControlesLupaCodigosEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pCodigo smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesLupaCodigos 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (Codigo = ISNULL(@pCodigo, Codigo))
 
 RETURN @@Error 

GO

GO
