DROP PROCEDURE venCompCartaPorteMercanciaGuardar
GO
CREATE PROCEDURE venCompCartaPorteMercanciaGuardar
(
@pvenmovimientos bigint,
@pidDestino int,
@pRenglon int,
@pBienesTransp varchar(10) = NULL,
@pClaveSTCC varchar(10) = NULL,
@pDescripcion varchar(1000) = NULL,
@pCantidad numeric(18,6),
@pMedida_id varchar(5) = NULL,
@pDimensiones varchar(20) = NULL,
@pMaterialPeligroso varchar(2) = NULL,
@pCveMaterialPeligroso varchar(6) = NULL,
@pEmbalaje varchar(6) = NULL,
@pDescripEmbalaje varchar(100) = NULL,
@pPesoEnKg numeric(18,3),
@pValorMercancia numeric(18,2),
@pFraccionArancelaria varchar(20) = NULL,
@pUUIDComercioExt varchar(36) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCompCartaPorteMercancia WHERE (venmovimientos = @pvenmovimientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE venCompCartaPorteMercancia
	SET		idDestino = @pidDestino,
		BienesTransp = @pBienesTransp,
		ClaveSTCC = @pClaveSTCC,
		Descripcion = @pDescripcion,
		Cantidad = @pCantidad,
		Medida_id = dbo.FuncFKstkUniMed(@pMedida_id),
		Dimensiones = @pDimensiones,
		MaterialPeligroso = @pMaterialPeligroso,
		CveMaterialPeligroso = @pCveMaterialPeligroso,
		Embalaje = @pEmbalaje,
		DescripEmbalaje = @pDescripEmbalaje,
		PesoEnKg = @pPesoEnKg,
		ValorMercancia = @pValorMercancia,
		FraccionArancelaria = @pFraccionArancelaria,
		UUIDComercioExt = @pUUIDComercioExt
	WHERE (venmovimientos = @pvenmovimientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venCompCartaPorteMercancia
	(
		venmovimientos,
		idDestino,
		Renglon,
		BienesTransp,
		ClaveSTCC,
		Descripcion,
		Cantidad,
		Medida_id,
		Dimensiones,
		MaterialPeligroso,
		CveMaterialPeligroso,
		Embalaje,
		DescripEmbalaje,
		PesoEnKg,
		ValorMercancia,
		FraccionArancelaria,
		UUIDComercioExt
	)
	VALUES 
	(
		@pvenmovimientos,
		@pidDestino,
		@pRenglon,
		@pBienesTransp,
		@pClaveSTCC,
		@pDescripcion,
		@pCantidad,
		dbo.FuncFKstkUniMed(@pMedida_id),
		@pDimensiones,
		@pMaterialPeligroso,
		@pCveMaterialPeligroso,
		@pEmbalaje,
		@pDescripEmbalaje,
		@pPesoEnKg,
		@pValorMercancia,
		@pFraccionArancelaria,
		@pUUIDComercioExt
	)
END 

GO

DROP PROCEDURE venCompCartaPorteMercanciaDatos
GO
CREATE PROCEDURE venCompCartaPorteMercanciaDatos
(
@pvenmovimientos bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT venCompCartaPorteMercancia.venmovimientos, venCompCartaPorteMercancia.idDestino, venCompCartaPorteMercancia.Renglon,
	venCompCartaPorteMercancia.BienesTransp, venCompCartaPorteMercancia.ClaveSTCC, venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Cantidad,
	stkUniMed.Medida_Id, venCompCartaPorteMercancia.Dimensiones, venCompCartaPorteMercancia.MaterialPeligroso,
	venCompCartaPorteMercancia.CveMaterialPeligroso, venCompCartaPorteMercancia.Embalaje, venCompCartaPorteMercancia.DescripEmbalaje, venCompCartaPorteMercancia.PesoEnKg,
	venCompCartaPorteMercancia.ValorMercancia, venCompCartaPorteMercancia.FraccionArancelaria, venCompCartaPorteMercancia.UUIDComercioExt
FROM venCompCartaPorteMercancia 
INNER JOIN venCompCartaPorte  ON (venCompCartaPorte.venmovimientos = venCompCartaPorteMercancia.venmovimientos)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_id)
WHERE (venCompCartaPorteMercancia.venmovimientos = @pvenmovimientos)
AND (venCompCartaPorteMercancia.Renglon = ISNULL(@pRenglon,venCompCartaPorteMercancia.Renglon))
 
RETURN @@Error 

GO

DROP PROCEDURE venCompCartaPorteMercanciaEliminar
GO
CREATE PROCEDURE venCompCartaPorteMercanciaEliminar
(
@pvenmovimientos bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCompCartaPorteMercancia 
WHERE (venmovimientos = @pvenmovimientos)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO


