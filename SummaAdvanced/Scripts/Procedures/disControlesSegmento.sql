DROP PROCEDURE disControlesSegmentoGuardar
GO
CREATE PROCEDURE disControlesSegmentoGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pSegmento_Id varchar(10),
@pIdentidad_Id varchar(30),
@pEsLaEntidadDelForm Sino,
@pFiltros varchar(250) = NULL

)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesSegmento WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesSegmento
	SET Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id),		
		Identidad_Id = dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		EsLaEntidadDelForm = @pEsLaEntidadDelForm,
		Filtros = @pFiltros
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesSegmento
	(
		Formulario_Id,
		Control_Id,
		Segmento_Id,
		Identidad_Id,
		EsLaEntidadDelForm,
		Filtros
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		@pEsLaEntidadDelForm,
		@pFiltros
	)
END 

GO

GO

DROP PROCEDURE disControlesSegmentoEliminar
GO
CREATE PROCEDURE disControlesSegmentoEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesSegmento 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
