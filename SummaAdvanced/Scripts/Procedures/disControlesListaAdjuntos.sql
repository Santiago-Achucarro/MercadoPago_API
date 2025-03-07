DROP PROCEDURE disControlesListaAdjuntosGuardar
GO

CREATE PROCEDURE disControlesListaAdjuntosGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pPermiteAgregarArchivo Sino,
@pPermiteBorrarArchivo Sino,
@pMuestraDescripciones Sino,
@pPermiteDescargar Sino,
@pCantidadMaxima int,
@pExtensionesPermitidas varchar(40) = NULL, 
@pTamanioMaximo int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesListaAdjuntos WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesListaAdjuntos
	SET	PermiteAgregarArchivo = @pPermiteAgregarArchivo,
		PermiteBorrarArchivo = @pPermiteBorrarArchivo,
		MuestraDescripciones = @pMuestraDescripciones,
		PermiteDescargar = @pPermiteDescargar,
		CantidadMaxima = @pCantidadMaxima,
		ExtensionesPermitidas = @pExtensionesPermitidas,
		TamanioMaximo = @pTamanioMaximo
	WHERE (Formulario_Id = @pFormulario_Id) 
	AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesListaAdjuntos
	(
		Formulario_Id,
		Control_Id,
		PermiteAgregarArchivo,
		PermiteBorrarArchivo,
		MuestraDescripciones,
		PermiteDescargar,
		CantidadMaxima,
		ExtensionesPermitidas,
		TamanioMaximo
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pPermiteAgregarArchivo,
		@pPermiteBorrarArchivo,
		@pMuestraDescripciones,
		@pPermiteDescargar,
		@pCantidadMaxima,
		@pExtensionesPermitidas,
		@pTamanioMaximo
	)
END 

GO

DROP PROCEDURE disControlesListaAdjuntosEliminar
GO
CREATE PROCEDURE disControlesListaAdjuntosEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesListaAdjuntos 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO


