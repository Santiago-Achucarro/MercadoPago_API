
DROP PROCEDURE disControlesNumericoGuardar
GO
CREATE PROCEDURE disControlesNumericoGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pDecimales smallint,
@pBotonSpin Sino,
@pSpinIncremento smallint,
@pValorMinimo numeric(25,8) = NULL,
@pValorMaximo numeric(25,8) = NULL,
@pEsPorcentaje Sino, 
@pLLevaSeparadorGrupo Sino 
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesNumerico WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesNumerico
	SET		Decimales = @pDecimales,
		BotonSpin = @pBotonSpin,
		SpinIncremento = @pSpinIncremento,
		ValorMinimo = @pValorMinimo,
		ValorMaximo = @pValorMaximo,
		EsPorcentaje = @pEsPorcentaje,
		LLevaSeparadorGrupo = @pLLevaSeparadorGrupo
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesNumerico
	(
		Formulario_Id,
		Control_Id,
		Decimales,
		BotonSpin,
		SpinIncremento,
		ValorMinimo,
		ValorMaximo,
		EsPorcentaje,
		LLevaSeparadorGrupo
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pDecimales,
		@pBotonSpin,
		@pSpinIncremento,
		@pValorMinimo,
		@pValorMaximo,
		@pEsPorcentaje,
		@pLLevaSeparadorGrupo
	)
END 

GO


DROP PROCEDURE disControlesNumericoEliminar
GO
CREATE PROCEDURE disControlesNumericoEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesNumerico 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO
