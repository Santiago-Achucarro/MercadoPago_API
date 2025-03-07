DROP PROCEDURE disControlesSolapaGuardar
GO
CREATE PROCEDURE disControlesSolapaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pPosicion int,
@pCantFilas int,
@pCantColumnas int,
@pTipoPopup varchar(20),
@pFormularioPopup_Id varChar(30) = NULL,
@pTieneBtnCerrar bit,
@pTieneBtnGuardar bit,
@pTablaPrimaria varchar(40) = NULL,
@pParametros varchar(512) = NULL,
@pTamanioPopup varchar(20)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesSolapa WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesSolapa
	SET		Posicion = @pPosicion,
		CantFilas = @pCantFilas,
		CantColumnas = @pCantColumnas,
		TipoPopup = @pTipoPopup,
		FormularioPopup_Id = dbo.FuncFKdisFormularios(@pFormularioPopup_Id),
		TieneBtnCerrar = @pTieneBtnCerrar,
		TieneBtnGuardar = @pTieneBtnGuardar,
		TablaPrimaria = @pTablaPrimaria,
		Parametros = @pParametros,
		TamanioPopup = @pTamanioPopup
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesSolapa
	(
		Formulario_Id,
		Control_Id,
		Posicion,
		CantFilas,
		CantColumnas,
		TipoPopup,
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
		@pPosicion,
		@pCantFilas,
		@pCantColumnas,
		@pTipoPopup,
		dbo.FuncFKdisFormularios(@pFormularioPopup_Id),
		@pTieneBtnCerrar,
		@pTieneBtnGuardar,
		@pTablaPrimaria,
		@pParametros,
		@pTamanioPopup
	)
END 

GO


DROP PROCEDURE disControlesSolapaEliminar
GO
CREATE PROCEDURE disControlesSolapaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesSolapa 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
