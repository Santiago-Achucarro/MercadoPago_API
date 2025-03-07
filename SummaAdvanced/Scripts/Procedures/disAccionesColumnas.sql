DROP PROCEDURE disAccionesColumnasGuardar
GO
CREATE PROCEDURE disAccionesColumnasGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pColumna varchar(40),
@pTipoEvento varchar(30),
@pOrdenAccion smallint,
@pAccion varchar(30),
@pControlDestino_Id varChar(200) = NULL,
@pColumnaDestino varchar(40) = NULL,
@pTexto varchar(256) = NULL,
@pControlTexto_Id varChar(200) = NULL,
@pValorCondicion varchar(30) = NULL,
@pAccionPadre_Id varchar(100) = NULL,
@pHeredado bit,
@pAccion_Id varchar(100)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disAccionesColumnas WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Columna = @pColumna) AND (TipoEvento = @pTipoEvento) AND (OrdenAccion = @pOrdenAccion)))
BEGIN 
	UPDATE disAccionesColumnas
	SET		Accion = @pAccion,
		ControlDestino_Id = @pControlDestino_Id,
		ColumnaDestino = @pColumnaDestino,
		Texto = @pTexto,
		ControlTexto_Id = @pControlTexto_Id,
		ValorCondicion = @pValorCondicion,
		AccionPadre_Id = @pAccionPadre_Id,
		Heredado = @pHeredado,
		Accion_Id = @pAccion_Id
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Columna = @pColumna) AND (TipoEvento = @pTipoEvento) AND (OrdenAccion = @pOrdenAccion)
END 
ELSE 
BEGIN 
	INSERT INTO disAccionesColumnas
	(
		Formulario_Id,
		Control_Id,
		Columna,
		TipoEvento,
		OrdenAccion,
		Accion,
		ControlDestino_Id,
		ColumnaDestino,
		Texto,
		ControlTexto_Id,
		ValorCondicion,
		AccionPadre_Id,
		Heredado,
		Accion_Id
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pColumna,
		@pTipoEvento,
		@pOrdenAccion,
		@pAccion,
		@pControlDestino_Id,
		@pColumnaDestino,
		@pTexto,
		@pControlTexto_Id,
		@pValorCondicion,
		@pAccionPadre_Id,
		@pHeredado,
		@pAccion_Id
	)
END 

GO


DROP PROCEDURE disAccionesColumnasEliminar
GO
CREATE PROCEDURE disAccionesColumnasEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL ,
@pColumna varchar(40) = NULL,
@pTipoEvento varchar(30) = NULL,
@pOrdenAccion smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disAccionesColumnas 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (Columna = ISNULL(@pColumna, Columna))
AND (TipoEvento = ISNULL(@pTipoEvento, TipoEvento))
AND (OrdenAccion = ISNULL(@pOrdenAccion, OrdenAccion))
 
 RETURN @@Error 

GO

GO
