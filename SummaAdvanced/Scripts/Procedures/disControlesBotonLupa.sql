DROP PROCEDURE disControlesBotonLupaGuardar
GO
CREATE PROCEDURE disControlesBotonLupaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pControlAsociado_Id varchar(200) = NULL,
@pIcono varchar(40) = NULL,
@pCamposClave smallint,
@pCantMaxRegAMostrar int,
@pIdentidad_Id varchar(30),
@pOrderBy varchar(40) = NULL,
@pUsaAccion Sino,
@pFiltros varchar(250) = NULL,
@pAdicionalesCampos varchar(250) = NULL,
@pAdicionalesControles varchar(250) = NULL, 
@pAdicionalesParametros VarChar(250)=NULL,
@pReemplazaEnDestino Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesBotonLupa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesBotonLupa
	SET	ControlAsociado_Id = @pControlAsociado_Id, 
		Icono = @pIcono,
		CamposClave = @pCamposClave,
		CantMaxRegAMostrar = @pCantMaxRegAMostrar,
		Identidad_Id = dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		OrderBy = @pOrderBy,
		UsaAccion = @pUsaAccion,
		Filtros = @pFiltros,
		AdicionalesCampos = @pAdicionalesCampos,
		AdicionalesControles = @pAdicionalesControles, 
		AdicionalesParametros = @pAdicionalesParametros,
		ReemplazaEnDestino = @pReemplazaEnDestino
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesBotonLupa
	(
		Formulario_Id,
		Control_Id,
		ControlAsociado_Id,
		Icono,
		CamposClave,
		CantMaxRegAMostrar,
		Identidad_Id,
		OrderBy,
		UsaAccion,
		Filtros,
		AdicionalesCampos,
		AdicionalesControles, 
		AdicionalesParametros,
		ReemplazaEnDestino

	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pControlAsociado_Id,
		@pIcono,
		@pCamposClave,
		@pCantMaxRegAMostrar,
		dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		@pOrderBy,
		@pUsaAccion,
		@pFiltros,
		@pAdicionalesCampos,
		@pAdicionalesControles, 
		@pAdicionalesParametros,
		@pReemplazaEnDestino
	)
END 

GO


DROP PROCEDURE disControlesBotonLupaEliminar
GO
CREATE PROCEDURE disControlesBotonLupaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesBotonLupa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
