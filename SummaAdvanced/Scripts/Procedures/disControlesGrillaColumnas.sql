DROP PROCEDURE disControlesGrillaColumnasGuardar
GO
CREATE PROCEDURE disControlesGrillaColumnasGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pPosicion int,
@pNombreCampo varchar(40),
@pTitulo varchar(40),
@pTipoDato char(20),
@pFormato varchar(30) = NULL,
@pVisible Sino,
@pControlColumna_Id varChar(200) = NULL,
@pAncho int,
@pAnchoVariable Sino,
@pAlineacion varchar(20),
@pSoloLectura Sino,
@pModoTamanioVariable varchar(25),
@pCongelarTamanio Sino,
@pAnchoMinimo int,
@pModoOrdenamiento varchar(25) = NULL,
@pTextoColumnaVacia varchar(40) = NULL,
@pTexto varchar(80) = NULL, 
@pEsParamAccionBoton Sino,
@pHeredado bit,
@pRequerido bit,
@pAutoNumerico bit,
@pEsPrimaryKey bit,
@pItemsCombo varchar(256) = NULL,
@pIdentidad_Id varchar(30) = NULL,
@pTotalizarCantidad bit, 
@pTotalizarMinimo bit,
@pTotalizarMaximo bit,
@pTotalizarSuma bit,
@pTotalizarPromedio bit,
@pColumnaColorFondoCelda varchar(35) = NULL,
@pColumnaColorTextoCelda varchar(35) = NULL
)
AS

SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesGrillaColumnas WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (NombreCampo = @pNombreCampo)))
BEGIN 
	UPDATE disControlesGrillaColumnas
	SET		Posicion = @pPosicion,
		Titulo = @pTitulo,
		TipoDato = @pTipoDato,
		Formato = @pFormato,
		Visible = @pVisible,
		ControlColumna_Id = @pControlColumna_Id,
		Ancho = @pAncho,
		AnchoVariable = @pAnchoVariable,
		Alineacion = @pAlineacion,
		SoloLectura = @pSoloLectura,
		ModoTamanioVariable = @pModoTamanioVariable,
		CongelarTamanio = @pCongelarTamanio,
		AnchoMinimo = @pAnchoMinimo,
		ModoOrdenamiento = @pModoOrdenamiento,
		TextoColumnaVacia = @pTextoColumnaVacia,
		Texto = @pTexto,
		EsParamAccionBoton = @pEsParamAccionBoton,
		Heredado = @pHeredado,
		Requerido = @pRequerido,
		AutoNumerico = @pAutoNumerico,
		EsPrimaryKey = @pEsPrimaryKey,
		ItemsCombo = @pItemsCombo,
		Identidad_Id = dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		TotalizarCantidad = @pTotalizarCantidad, 
		TotalizarMinimo = @pTotalizarMinimo,
		TotalizarMaximo = @pTotalizarMaximo,
		TotalizarSuma = @pTotalizarSuma,
		TotalizarPromedio = @pTotalizarPromedio,
		ColumnaColorFondoCelda = @pColumnaColorFondoCelda,
		ColumnaColorTextoCelda = @pColumnaColorTextoCelda

	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (NombreCampo = @pNombreCampo)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesGrillaColumnas
	(
		Formulario_Id,
		Control_Id,
		Posicion,
		NombreCampo,
		Titulo,
		TipoDato,
		Formato,
		Visible,
		ControlColumna_Id,
		Ancho,
		AnchoVariable,
		Alineacion,
		SoloLectura,
		ModoTamanioVariable,
		CongelarTamanio,
		AnchoMinimo,
		ModoOrdenamiento,
		TextoColumnaVacia,
		Texto,
		EsParamAccionBoton,
		Heredado,
		Requerido,
		AutoNumerico,
		EsPrimaryKey,
		ItemsCombo,
		Identidad_Id,
		TotalizarCantidad, 
		TotalizarMinimo,
		TotalizarMaximo,
		TotalizarSuma,
		TotalizarPromedio,
		ColumnaColorFondoCelda,
		ColumnaColorTextoCelda
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pPosicion,
		@pNombreCampo,
		@pTitulo,
		@pTipoDato,
		@pFormato,
		@pVisible,
		@pControlColumna_Id,
		@pAncho,
		@pAnchoVariable,
		@pAlineacion,
		@pSoloLectura,
		@pModoTamanioVariable,
		@pCongelarTamanio,
		@pAnchoMinimo,
		@pModoOrdenamiento,
		@pTextoColumnaVacia,
		@pTexto,
		@pEsParamAccionBoton,
		@pHeredado,
		@pRequerido,
		@pAutoNumerico,
		@pEsPrimaryKey,
		@pItemsCombo,
		dbo.FuncFKlupIdentidades(@pIdentidad_Id),
		@pTotalizarCantidad, 
		@pTotalizarMinimo,
		@pTotalizarMaximo,
		@pTotalizarSuma,
		@pTotalizarPromedio,
		@pColumnaColorFondoCelda,
		@pColumnaColorTextoCelda
	)
END 

GO

GO

DROP PROCEDURE disControlesGrillaColumnasEliminar
GO
CREATE PROCEDURE disControlesGrillaColumnasEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pNombreCampo varchar(40) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesGrillaColumnas 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (NombreCampo = ISNULL(@pNombreCampo, NombreCampo))
 
 RETURN @@Error 

GO

GO
