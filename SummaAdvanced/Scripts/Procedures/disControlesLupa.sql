-- AJ JUN 2016 AdicionalesParametros

DROP PROCEDURE disControlesLupaGuardar
GO
CREATE PROCEDURE disControlesLupaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pCamposClave smallint,
@pCantMaxRegAMostrar int,
@pEsLaEntidadDelForm Sino,
@pIdentidad_Id varchar(30),
@pOrderBy varchar(40) = NULL,
@pTraePrimerRegistro bit,
@pUsaAccion Sino,
@pDescripcionCharCasing varchar(6),
@pDescripcionMaxLength smallint,
@pDescripcionTexto varchar(256) = NULL,
@pDescripcionOculta Sino,
@pColumnaGrillaDescripcion varchar(80) = NULL,
@pFiltros varchar(500) = NULL,
@pCodigoTipo varchar(20),
@pCodigoCharCasing varchar(6),
@pCodigoMask varchar(40) = NULL,
@pCodigoRegExpression varchar(50) = NULL,
@pCodigoMaxLength smallint,
@pCodigoTexto varchar(256) = NULL,
@pCodigoWidth int,
@pCodigoNombreColumna varchar(40),
@pAdicionalesCampos varchar(250) = NULL,
@pAdicionalesControles varchar(250) = NULL, 
@pAdicionalesParametros VarChar(250)=NULL,
@pPermiteNoExistentes bit,
@pMascara varchar(40) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesLupa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesLupa
	SET		CamposClave = @pCamposClave,
		CantMaxRegAMostrar = @pCantMaxRegAMostrar,
		EsLaEntidadDelForm = @pEsLaEntidadDelForm,
		Identidad_Id = dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		OrderBy = @pOrderBy,
		TraePrimerRegistro = @pTraePrimerRegistro,
		UsaAccion = @pUsaAccion,
		DescripcionCharCasing = @pDescripcionCharCasing,
		DescripcionMaxLength = @pDescripcionMaxLength,
		DescripcionTexto = @pDescripcionTexto,
		DescripcionOculta = @pDescripcionOculta,
		ColumnaGrillaDescripcion = @pColumnaGrillaDescripcion,
		Filtros = @pFiltros,
		CodigoTipo = @pCodigoTipo,
		CodigoCharCasing = @pCodigoCharCasing,
		CodigoMask = @pCodigoMask,
		CodigoRegExpression = @pCodigoRegExpression,
		CodigoMaxLength = @pCodigoMaxLength,
		CodigoTexto = @pCodigoTexto,
		CodigoWidth = @pCodigoWidth,
		CodigoNombreColumna = @pCodigoNombreColumna,
		AdicionalesCampos = @pAdicionalesCampos,
		AdicionalesControles = @pAdicionalesControles, 
		AdicionalesParametros = @pAdicionalesParametros,
		PermiteNoExistentes = @pPermiteNoExistentes,
		Mascara = @pMascara
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesLupa
	(
		Formulario_Id,
		Control_Id,
		CamposClave,
		CantMaxRegAMostrar,
		EsLaEntidadDelForm,
		Identidad_Id,
		OrderBy,
		TraePrimerRegistro,
		UsaAccion,
		DescripcionCharCasing,
		DescripcionMaxLength,
		DescripcionTexto,
		DescripcionOculta,
		ColumnaGrillaDescripcion,
		Filtros,
		CodigoTipo,
		CodigoCharCasing,
		CodigoMask,
		CodigoRegExpression,
		CodigoMaxLength,
		CodigoTexto,
		CodigoWidth,
		CodigoNombreColumna,
		AdicionalesCampos,
		AdicionalesControles, 
		AdicionalesParametros,
		PermiteNoExistentes,
		Mascara
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pCamposClave,
		@pCantMaxRegAMostrar,
		@pEsLaEntidadDelForm,
		dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		@pOrderBy,
		@pTraePrimerRegistro,
		@pUsaAccion,
		@pDescripcionCharCasing,
		@pDescripcionMaxLength,
		@pDescripcionTexto,
		@pDescripcionOculta,
		@pColumnaGrillaDescripcion,
		@pFiltros,
		@pCodigoTipo,
		@pCodigoCharCasing,
		@pCodigoMask,
		@pCodigoRegExpression,
		@pCodigoMaxLength,
		@pCodigoTexto,
		@pCodigoWidth,
		@pCodigoNombreColumna,
		@pAdicionalesCampos,
		@pAdicionalesControles, 
		@pAdicionalesParametros,
		@pPermiteNoExistentes,
		@pMascara
	)
END 

GO

GO

DROP PROCEDURE disControlesLupaEliminar
GO
CREATE PROCEDURE disControlesLupaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesLupa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
