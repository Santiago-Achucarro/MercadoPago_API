DROP PROCEDURE disControlesBotonSegmentoGuardar
GO
CREATE PROCEDURE disControlesBotonSegmentoGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pControlAsociado_Id varchar(200) = NULL,
@pIcono varchar(40) = NULL,
@pIdentidad_Id varchar(30),
@pFiltros varchar(250) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesBotonSegmento WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesBotonSegmento
	SET	ControlAsociado_Id = @pControlAsociado_Id, 
		Icono = @pIcono,
		Identidad_Id = dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		Filtros = @pFiltros
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesBotonSegmento
	(
		Formulario_Id,
		Control_Id,
		ControlAsociado_Id,
		Icono,
		Identidad_Id,
		Filtros
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pControlAsociado_Id,
		@pIcono,
		dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		@pFiltros
	)
END 

GO


DROP PROCEDURE disControlesBotonSegmentoEliminar
GO
CREATE PROCEDURE disControlesBotonSegmentoEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesBotonSegmento 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
