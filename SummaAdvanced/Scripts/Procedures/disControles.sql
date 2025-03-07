DROP PROCEDURE disControlesGuardar
GO
CREATE PROCEDURE disControlesGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pNroControl int,
@pControlParent_Id varChar(200) = NULL,
@pTipoControl varchar(50),
@pAlto int,
@pAncho int,
@pArriba smallint,
@pIzquierda smallint,
@pTexto varchar(80) = NULL,
@pVisible Sino,
@pHabilitado Sino,
@pAlineacion varchar(7),
@pTabStop Sino,
@pTabOrden smallint,
@pRequerido bit,
@pEmbebido bit,
@pAncla varchar(8),
@pEsCodigoNuevo Sino,
@pPaises varchar(20) = NULL,
@pFila int,
@pColumna int,
@pFilasExtension int,
@pColumnasExtension int,
@pMaximaLongitud int = NULL, 
@pClickNuevoBlanquea bit,
@pControlaCambios bit, 
@pSoloLectura bit, 
@pTextoFijo bit,
@pTextoControlVacio varchar(40) = NULL,
@pEstilo varchar(200) = NULL,
@pTituloLabel varchar(50) = NULL,
@pAlineacionLabel varchar(10),
@pIgualaAnchoColumna bit,
@pSegmentoOrigen smallint = NULL,
@pControlsegmento varchar(200) = NULL,
@pHeredado bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControles WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControles
	SET		NroControl = @pNroControl,
		ControlParent_Id = @pControlParent_Id,
		TipoControl = @pTipoControl,
		Alto = @pAlto,
		Ancho = @pAncho,
		Arriba = @pArriba,
		Izquierda = @pIzquierda,
		Texto = @pTexto,
		Visible = @pVisible,
		Habilitado = @pHabilitado,
		Alineacion = @pAlineacion,
		TabStop = @pTabStop,
		TabOrden = @pTabOrden,
		Requerido = @pRequerido,
		Embebido = @pEmbebido,
		Ancla = @pAncla,
		EsCodigoNuevo = @pEsCodigoNuevo,
		Paises = @pPaises,
		Fila = @pFila,
		Columna = @pColumna,
		FilasExtension = @pFilasExtension,
		ColumnasExtension = @pColumnasExtension,
		MaximaLongitud = @pMaximaLongitud, 
		ClickNuevoBlanquea = @pClickNuevoBlanquea,
		ControlaCambios = @pControlaCambios, 
		SoloLectura = @pSoloLectura, 
		TextoFijo = @pTextoFijo,
		TextoControlVacio = @pTextoControlVacio,
		Estilo = @pEstilo,
		TituloLabel = @pTituloLabel,
		AlineacionLabel = @pAlineacionLabel,
		IgualaAnchoColumna = @pIgualaAnchoColumna,
		SegmentoOrigen = @pSegmentoOrigen,
		ControlSegmento = @pControlsegmento,
		Heredado = @pHeredado
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControles
	(
		Formulario_Id,
		Control_Id,
		NroControl,
		ControlParent_Id,
		TipoControl,
		Alto,
		Ancho,
		Arriba,
		Izquierda,
		Texto,
		Visible,
		Habilitado,
		Alineacion,
		TabStop,
		TabOrden,
		Requerido,
		Embebido,
		Ancla,
		EsCodigoNuevo,
		Paises,
		Fila,
		Columna,
		FilasExtension,
		ColumnasExtension,
		MaximaLongitud, 
		ClickNuevoBlanquea,
		ControlaCambios, 
		SoloLectura, 
		TextoFijo,
		TextoControlVacio,
		Estilo,
		TituloLabel,
		AlineacionLabel,
		IgualaAnchoColumna,
		SegmentoOrigen,
		ControlSegmento,
		Heredado
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pNroControl,
		@pControlParent_Id,
		@pTipoControl,
		@pAlto,
		@pAncho,
		@pArriba,
		@pIzquierda,
		@pTexto,
		@pVisible,
		@pHabilitado,
		@pAlineacion,
		@pTabStop,
		@pTabOrden,
		@pRequerido,
		@pEmbebido,
		@pAncla,
		@pEsCodigoNuevo,
		@pPaises,
		@pFila,
		@pColumna,
		@pFilasExtension,
		@pColumnasExtension,
		@pMaximaLongitud, 
		@pClickNuevoBlanquea,
		@pControlaCambios, 
		@pSoloLectura, 
		@pTextoFijo,
		@pTextoControlVacio,
		@pEstilo,
		@pTituloLabel,
		@pAlineacionLabel,
		@pIgualaAnchoColumna,
		@pSegmentoOrigen,
		@pControlsegmento,
		@pHeredado
	)
END 

GO


DROP PROCEDURE disControlesEliminar
GO
CREATE PROCEDURE disControlesEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControles 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (TipoControl <> 'frm')
AND (TipoControl <> 'rpt')
 
 RETURN @@Error 

GO

GO
