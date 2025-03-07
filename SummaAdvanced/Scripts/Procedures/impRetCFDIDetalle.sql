DROP PROCEDURE impRetCFDIDetalleGuardar
GO
CREATE PROCEDURE impRetCFDIDetalleGuardar
(
@pimpRetencionesCFDI int,
@pRenglon int,
@pBaseRet numeric(18,4),
@pTipoImpuesto varchar(2),
@pmontoRet numeric(18,4),
@pTipoPagoRet varchar(17)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIDetalle WHERE (impRetencionesCFDI = @pimpRetencionesCFDI) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE impRetCFDIDetalle
	SET		BaseRet = @pBaseRet,
		TipoImpuesto = @pTipoImpuesto,
		montoRet = @pmontoRet,
		TipoPagoRet = @pTipoPagoRet
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIDetalle
	(
		impRetencionesCFDI,
		Renglon,
		BaseRet,
		TipoImpuesto,
		montoRet,
		TipoPagoRet
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pRenglon,
		@pBaseRet,
		@pTipoImpuesto,
		@pmontoRet,
		@pTipoPagoRet
	)
END 

GO

DROP PROCEDURE impRetCFDIDetalleDatos
GO
CREATE PROCEDURE impRetCFDIDetalleDatos
(
@pimpRetencionesCFDI int,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIDetalle.impRetencionesCFDI,  impRetCFDIDetalle.Renglon, impRetCFDIDetalle.BaseRet,
	impRetCFDIDetalle.TipoImpuesto, impRetCFDIDetalle.montoRet, impRetCFDIDetalle.TipoPagoRet
FROM impRetCFDIDetalle 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIDetalleEliminar
GO
CREATE PROCEDURE impRetCFDIDetalleEliminar
(
@pimpRetencionesCFDI int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIDetalle 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
