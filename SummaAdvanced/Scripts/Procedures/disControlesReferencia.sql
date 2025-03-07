DROP PROCEDURE disControlesReferenciaGuardar
GO
CREATE PROCEDURE disControlesReferenciaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pFormularioPopup_Id varChar(30) = NULL,
@pTieneBtnCerrar bit,
@pTieneBtnGuardar bit,
@pTablaPrimaria varchar(40) = NULL,
@pParametros varchar(512) = NULL,
@pTamanioPopup varchar(20)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesReferencia WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesReferencia
	SET	FormularioPopup_Id = dbo.FuncFKdisFormularios(@pFormularioPopup_Id),
		TieneBtnCerrar = @pTieneBtnCerrar,
		TieneBtnGuardar = @pTieneBtnGuardar,
		TablaPrimaria = @pTablaPrimaria,
		Parametros = @pParametros,
		TamanioPopup = @pTamanioPopup
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesReferencia
	(
		Formulario_Id,
		Control_Id,
		FormularioPopup_Id,
		TieneBtnCerrar,
		TieneBtnGuardar,
		TablaPrimaria,
		Parametros,
		TamanioPopup
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		dbo.FuncFKdisFormularios(@pFormularioPopup_Id),
		@pTieneBtnCerrar,
		@pTieneBtnGuardar,
		@pTablaPrimaria,
		@pParametros,
		@pTamanioPopup
	)
END 

GO


DROP PROCEDURE disControlesReferenciaEliminar
GO
CREATE PROCEDURE disControlesReferenciaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesReferencia 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
