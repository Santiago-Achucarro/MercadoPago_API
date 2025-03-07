DROP PROCEDURE disControlesGraficoTortaGuardar
GO
CREATE PROCEDURE disControlesGraficoTortaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pValoresASeparar smallint,
@pUbicacionTituloPorcion varchar(40),
@pFormatoTituloPorcion varchar(10)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesGraficoTorta WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesGraficoTorta
	SET	ValoresASeparar = @pValoresASeparar,
		UbicacionTituloPorcion = @pUbicacionTituloPorcion,
		FormatoTituloPorcion = @pFormatoTituloPorcion
	WHERE (Formulario_Id = @pFormulario_Id) 
	AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesGraficoTorta
	(
		Formulario_Id,
		Control_Id,
		ValoresASeparar,
		UbicacionTituloPorcion,
		FormatoTituloPorcion
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pValoresASeparar,
		@pUbicacionTituloPorcion,
		@pFormatoTituloPorcion
	)
END 

GO

DROP PROCEDURE disControlesGraficoTortaEliminar
GO
CREATE PROCEDURE disControlesGraficoTortaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesGraficoTorta 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO


