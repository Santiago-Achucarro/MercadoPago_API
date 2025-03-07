DROP PROCEDURE disControlesGraficoGuardar
GO
CREATE PROCEDURE disControlesGraficoGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pSubTitulo varchar(50) = NULL,
@pLeyenda varchar(10) = NULL,
@pTipo varchar(30),
@pSubTipo varchar(30),
@pPermiteCambiarSubTipo bit,
@pTituloEjevalores varchar(80) = NULL,
@pColores varchar(140) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesGrafico WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesGrafico
	SET	SubTitulo = @pSubTitulo,
		Leyenda = @pLeyenda,
		Tipo = @pTipo,
		SubTipo = @pSubTipo,
		PermiteCambiarSubTipo = @pPermiteCambiarSubTipo,
		TituloEjevalores = @pTituloEjevalores,
		Colores = @pColores
	WHERE (Formulario_Id = @pFormulario_Id) 
	AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesGrafico
	(
		Formulario_Id,
		Control_Id,
		SubTitulo,
		Leyenda,
		Tipo,
		SubTipo,
		PermiteCambiarSubTipo,
		TituloEjevalores,
		Colores
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pSubTitulo,
		@pLeyenda,
		@pTipo,
		@pSubTipo,
		@pPermiteCambiarSubTipo,
		@pTituloEjevalores,
		@pColores
	)
END 

GO

DROP PROCEDURE disControlesGraficoEliminar
GO
CREATE PROCEDURE disControlesGraficoEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesGrafico 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO


