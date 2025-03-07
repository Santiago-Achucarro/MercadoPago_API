DROP PROCEDURE disAccionesGuardar
GO
CREATE PROCEDURE disAccionesGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pTipoEvento varchar(30),
@pOrdenAccion smallint,
@pAccion varchar(30),
@pControlDestino_Id varChar(200) = NULL,
@pTexto varchar(256) = NULL,
@pControlTexto_Id varChar(200) = NULL,
@pValorCondicion varchar(30) = NULL,
@pAccionPadre_Id varchar(100) = NULL,
@pHeredado bit,
@pAccion_Id varchar(100),
@pHabilitado bit,
@pEsEspecializacion bit,
@pAdicionalInfo varchar(80)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disAcciones WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (TipoEvento = @pTipoEvento) AND (OrdenAccion = @pOrdenAccion)))
BEGIN 
	UPDATE disAcciones
	SET		Accion = @pAccion,
		ControlDestino_Id = @pControlDestino_Id,
		Texto = @pTexto,
		ControlTexto_Id = @pControlTexto_Id,
		ValorCondicion = @pValorCondicion,
		AccionPadre_Id = @pAccionPadre_Id,
		Heredado = @pHeredado,
		Accion_Id = @pAccion_Id,
		Habilitado = @pHabilitado,
		EsEspecializacion = @pEsEspecializacion,
		AdicionalInfo = @pAdicionalInfo
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (TipoEvento = @pTipoEvento) AND (OrdenAccion = @pOrdenAccion)
END 
ELSE 
BEGIN 
	INSERT INTO disAcciones
	(
		Formulario_Id,
		Control_Id,
		TipoEvento,
		OrdenAccion,
		Accion,
		ControlDestino_Id,
		Texto,
		ControlTexto_Id,
		ValorCondicion,
		AccionPadre_Id,
		Heredado,
		Accion_Id,
		Habilitado,
		EsEspecializacion,
		AdicionalInfo
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pTipoEvento,
		@pOrdenAccion,
		@pAccion,
		@pControlDestino_Id,
		@pTexto,
		@pControlTexto_Id,
		@pValorCondicion,
		@pAccionPadre_Id,
		@pHeredado,
		@pAccion_Id,
		@pHabilitado,
		@pEsEspecializacion,
		@pAdicionalInfo
	)
END 

GO

DROP PROCEDURE disAccionesEliminar
GO
CREATE PROCEDURE disAccionesEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pTipoEvento varchar(30) = NULL,
@pOrdenAccion smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disAcciones 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (TipoEvento = ISNULL(@pTipoEvento, TipoEvento))
AND (OrdenAccion = ISNULL(@pOrdenAccion, OrdenAccion))
 
 RETURN @@Error 

GO

