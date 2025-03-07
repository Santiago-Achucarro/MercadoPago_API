DROP PROCEDURE disControlesFechaGuardar
GO
CREATE PROCEDURE disControlesFechaGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pValorMinimo varchar(30) = NULL,
@pValorMaximo varchar(30) = NULL,
@pDiasDiferenciaFecha int = NULL,
@pDiasDiferenciaFechaMaxima int = NULL,
@pDiasDiferenciaFechaMinima int = NULL,
@pEsFechaHora bit,
@pValorHora varchar(8) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disControlesFecha WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE disControlesFecha
	SET		ValorMinimo = @pValorMinimo,
		ValorMaximo = @pValorMaximo,
		DiasDiferenciaFecha = @pDiasDiferenciaFecha,
		DiasDiferenciaFechaMaxima = @pDiasDiferenciaFechaMaxima,
		DiasDiferenciaFechaMinima =@pDiasDiferenciaFechaMinima,
		EsFechaHora = @pEsFechaHora,
		ValorHora = @pValorHora
	WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disControlesFecha
	(
		Formulario_Id,
		Control_Id,
		ValorMinimo,
		ValorMaximo,
		DiasDiferenciaFecha,
		DiasDiferenciaFechaMaxima,
		DiasDiferenciaFechaMinima,
		EsFechaHora,
		ValorHora
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pValorMinimo,
		@pValorMaximo,
		@pDiasDiferenciaFecha,
		@pDiasDiferenciaFechaMaxima,
		@pDiasDiferenciaFechaMinima,
		@pEsFechaHora,
		@pValorHora
	)
END 

GO


DROP PROCEDURE disControlesFechaEliminar
GO
CREATE PROCEDURE disControlesFechaEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disControlesFecha 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
