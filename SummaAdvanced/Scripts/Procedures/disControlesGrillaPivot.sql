DROP PROCEDURE disControlesGrillaPivotGuardar
GO
CREATE PROCEDURE disControlesGrillaPivotGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pURLServidor varchar(200),
@pCatalogo varchar(100),
@pCubo varchar(100),
@pMeasures varchar(200),
@pFilas varchar(200),
@pColumnas varchar(200)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesGrillaPivot WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesGrillaPivot
	SET	URLServidor = @pURLServidor, 
		Catalogo = @pCatalogo,
		Cubo = @pCubo,
		Measures = @pMeasures,
		Filas = @pFilas,
		Columnas = @pColumnas
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesGrillaPivot
	(
		Formulario_Id,
		Control_Id,
		URLServidor,
		Catalogo,
		Cubo,
		Measures,
		Filas,
		Columnas
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pURLServidor,
		@pCatalogo,
		@pCubo,
		@pMeasures,
		@pFilas,
		@pColumnas
	)
END 

GO


DROP PROCEDURE disControlesGrillaPivotEliminar
GO
CREATE PROCEDURE disControlesGrillaPivotEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesGrillaPivot 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
