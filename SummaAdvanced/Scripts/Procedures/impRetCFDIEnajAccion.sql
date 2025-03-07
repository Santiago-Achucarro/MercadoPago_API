DROP PROCEDURE impRetCFDIEnajAccionGuardar
GO
CREATE PROCEDURE impRetCFDIEnajAccionGuardar
(
@pimpRetencionesCFDI int,
@pContratoIntermediacion varchar(300),
@pGanancia numeric(18,4),
@pPerdida numeric(18,4)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIEnajAccion WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIEnajAccion
	SET		ContratoIntermediacion = @pContratoIntermediacion,
		Ganancia = @pGanancia,
		Perdida = @pPerdida
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIEnajAccion
	(
		impRetencionesCFDI,
		ContratoIntermediacion,
		Ganancia,
		Perdida
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pContratoIntermediacion,
		@pGanancia,
		@pPerdida
	)
END 

GO

DROP PROCEDURE impRetCFDIEnajAccionDatos
GO
CREATE PROCEDURE impRetCFDIEnajAccionDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIEnajAccion.impRetencionesCFDI, impRetCFDIEnajAccion.ContratoIntermediacion, impRetCFDIEnajAccion.Ganancia,
	impRetCFDIEnajAccion.Perdida
FROM impRetCFDIEnajAccion 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIEnajAccionEliminar
GO
CREATE PROCEDURE impRetCFDIEnajAccionEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIEnajAccion 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO
