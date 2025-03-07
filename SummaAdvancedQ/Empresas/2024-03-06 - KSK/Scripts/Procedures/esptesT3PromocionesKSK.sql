DROP PROCEDURE esptesT3PromocionesKSKGuardar
GO
CREATE PROCEDURE esptesT3PromocionesKSKGuardar
(
@ptesT3Promociones int,
@pPorcentajeEntidad qPorcentaje,
@pPorcentajeBanco qPorcentaje
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM esptesT3PromocionesKSK WHERE (tesT3Promociones = @ptesT3Promociones)))
BEGIN 
	UPDATE esptesT3PromocionesKSK
	SET		PorcentajeEntidad = @pPorcentajeEntidad,
		PorcentajeBanco = @pPorcentajeBanco
	WHERE (tesT3Promociones = @ptesT3Promociones)
END 
ELSE 
BEGIN 
	INSERT INTO esptesT3PromocionesKSK
	(
		tesT3Promociones,
		PorcentajeEntidad,
		PorcentajeBanco
	)
	VALUES 
	(
		@ptesT3Promociones,
		@pPorcentajeEntidad,
		@pPorcentajeBanco
	)
END 

GO

DROP PROCEDURE esptesT3PromocionesKSKDatos
GO
CREATE PROCEDURE esptesT3PromocionesKSKDatos
(
@ptesT3Promociones int
)
AS
SET NOCOUNT ON 

SELECT tesT3Promociones.tesT3Promociones,  ISNULL(esptesT3PromocionesKSK.PorcentajeEntidad,0) PorcentajeEntidad, 
ISNULL(esptesT3PromocionesKSK.PorcentajeBanco,0) PorcentajeBanco
FROM  tesT3Promociones 
left JOIN esptesT3PromocionesKSK  ON (tesT3Promociones.tesT3Promociones = esptesT3PromocionesKSK.tesT3Promociones)
WHERE (tesT3Promociones.tesT3Promociones = @ptesT3Promociones)
 
RETURN @@Error 

GO

DROP PROCEDURE esptesT3PromocionesKSKEliminar
GO
CREATE PROCEDURE esptesT3PromocionesKSKEliminar
(
@pPromocion_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM esptesT3PromocionesKSK 
WHERE (tesT3Promociones = dbo.FuncFKtesT3Promociones(@pPromocion_Id))
 
 RETURN @@Error 

GO

GO
