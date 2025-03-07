DROP PROCEDURE disControlesGrillaGuardar
GO

CREATE PROCEDURE disControlesGrillaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pPermiteAgregarFilas bit,
@pPermiteBorrarFilas bit,
@pPermiteEditarCeldas bit,
@pEditaEnGrilla bit,
@pRegistrosxPagina int,
@pAutoFormateable bit,
@pEsGrillaAdjuntos bit,
@pEsArbol bit,
@pAccionNuevoValorNodo varchar(30),
@pTotalizaColumnas bit,
@pFilasAMostrar int,
@pAnchoMinimo int,
@pAnchoColumnasFijas varchar(20) = NULL,
@pNombreColCalculoTotal varchar(30) = NULL,
@pColFormatoNumericoFila varchar(30) = NULL,
@pColumnasFijas varchar(256) = NULL,
@pColumnasSoloLectura varchar(256)= NULL,
@pColumnasOcultas varchar(256)= NULL,
@pColumnasTotalizarCantidad varchar(256)= NULL,
@pColumnasTotalizarMinimo varchar(256)= NULL,
@pColumnasTotalizarMaximo varchar(256)= NULL,
@pColumnasTotalizarPromedio varchar(256)= NULL,
@pColumnasTotalizarSuma varchar(256)= NULL,
@pAnchoColPorContenido bit,
@pColumnaColorFondoFila varchar(35)= NULL,
@pColumnaColorTextoFila varchar(35)= NULL,
@pPermiteCambiarOrden bit,
@pPermiteOrdenMultiCols bit,
@pExpandirHastaNivel smallint
)
AS
SET NOCOUNT ON 
IF (NOT EXISTS (SELECT 1 FROM disControlesGrilla WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	INSERT INTO disControlesGrilla
	(
		Formulario_Id,
		Control_Id,
		PermiteAgregarFilas,
		PermiteBorrarFilas,
		PermiteEditarCeldas,
		EditaEnGrilla,
		RegistrosxPagina,
		AutoFormateable,
		EsGrillaAdjuntos,
		EsArbol,
		AccionNuevoValorNodo,
		TotalizaColumnas,
		FilasAMostrar,
		AnchoMinimo,
		AnchoColumnasFijas,
		NombreColCalculoTotal,
		ColFormatoNumericoFila,
		ColumnasFijas,
		ColumnasSoloLectura,
		ColumnasOcultas,
		ColumnasTotalizarCantidad,
		ColumnasTotalizarMinimo,
		ColumnasTotalizarMaximo,
		ColumnasTotalizarPromedio,
		ColumnasTotalizarSuma,
		AnchoColPorContenido,
		ColumnaColorFondoFila,
		ColumnaColorTextoFila,
		PermiteCambiarOrden,
		PermiteOrdenMultiCols,
		ExpandirHastaNivel
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pPermiteAgregarFilas,
		@pPermiteBorrarFilas,
		@pPermiteEditarCeldas,
		@pEditaEnGrilla,
		@pRegistrosxPagina,
		@pAutoFormateable,
		@pEsGrillaAdjuntos,
		@pEsArbol,
		@pAccionNuevoValorNodo,
		@pTotalizaColumnas,
		@pFilasAMostrar,
		@pAnchoMinimo,
		@pAnchoColumnasFijas,
		@pNombreColCalculoTotal,
		@pColFormatoNumericoFila,
		@pColumnasFijas,
		@pColumnasSoloLectura,
		@pColumnasOcultas,
		@pColumnasTotalizarCantidad,
		@pColumnasTotalizarMinimo,
		@pColumnasTotalizarMaximo,
		@pColumnasTotalizarPromedio,
		@pColumnasTotalizarSuma,
		@pAnchoColPorContenido,
	    @pColumnaColorFondoFila,
		@pColumnaColorTextoFila,
		@pPermiteCambiarOrden,
		@pPermiteOrdenMultiCols,
		@pExpandirHastaNivel
	)
END 

GO


DROP PROCEDURE disControlesGrillaEliminar
GO
CREATE PROCEDURE disControlesGrillaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesGrilla 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
