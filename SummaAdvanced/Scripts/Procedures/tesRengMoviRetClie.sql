DROP PROCEDURE tesRengMoviRetClieGuardar
GO
CREATE PROCEDURE tesRengMoviRetClieGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pSucursalRet char(4),
@pComprobanteRet int,
@pBaseImponible qMonedaD2,
@pPorcentaje qPorcentaje
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRengMoviRetClie WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE tesRengMoviRetClie
	SET SucursalRet = @pSucursalRet,
		ComprobanteRet = @pComprobanteRet,
		BaseImponible = @pBaseImponible,
		Porcentaje = @pPorcentaje
	WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesRengMoviRetClie
	(
		tesMovimientos,
		conRenglon,
		SucursalRet,
		ComprobanteRet,
		BaseImponible,
		Porcentaje
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		@pSucursalRet,
		@pComprobanteRet,
		@pBaseImponible,
		@pPorcentaje
	)
END 

GO

DROP PROCEDURE tesRengMoviRetClieDatos
GO
CREATE PROCEDURE tesRengMoviRetClieDatos
(
@ptesMovimientos bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

SELECT tesRengMoviRetClie.tesMovimientos, tesRengMoviRetClie.conRenglon, tesRengMoviRetClie.SucursalRet,
	tesRengMoviRetClie.ComprobanteRet, tesRengMoviRetClie.BaseImponible, tesRengMoviRetClie.Porcentaje
FROM tesRengMoviRetClie 
INNER JOIN tesRengMovi  ON (tesRengMovi.tesMovimientos = tesRengMoviRetClie.tesMovimientos) AND (tesRengMovi.conRenglon = tesRengMoviRetClie.conRenglon)
WHERE (tesRengMoviRetClie.tesMovimientos = @ptesMovimientos)
AND (tesRengMoviRetClie.conRenglon = @pconRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesRengMoviRetClieEliminar
GO
CREATE PROCEDURE tesRengMoviRetClieEliminar
(
@ptesMovimientos bigint,
@pconRenglon int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM tesRengMoviRetClie 
WHERE tesMovimientos = @ptesMovimientos
AND conRenglon = IsNull(@pconRenglon, conRenglon)
 
 RETURN @@Error 

GO

GO
