DROP PROCEDURE tesRengMoviRetProvGuardar
GO
CREATE PROCEDURE tesRengMoviRetProvGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pPorcentaje qPorcentaje,
@pExencion qPorcentaje,
@pBaseImponible qMonedaD2,
@pAcum qMonedaD2,
@pTRet qMonedaD2,
@pAcumTot qMonedaD2,
@pcomMovProv bigint = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRengMoviRetProv WHERE tesMovimientos = @ptesMovimientos AND conRenglon = @pconRenglon))
BEGIN 
	UPDATE tesRengMoviRetProv
	SET Porcentaje = @pPorcentaje,
		Exencion = @pExencion,
		BaseImponible = @pBaseImponible,
		Acum = @pAcum,
		TRet = @pTRet,
		AcumTot = @pAcumTot,
		comMovProv = @pcomMovProv
	WHERE tesMovimientos = @ptesMovimientos AND conRenglon = @pconRenglon
END 
ELSE 
BEGIN 
	INSERT INTO tesRengMoviRetProv
	(
		tesMovimientos,
		conRenglon,
		Porcentaje,
		Exencion,
		BaseImponible,
		Acum,
		TRet,
		AcumTot,
		comMovProv
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		@pPorcentaje,
		@pExencion,
		@pBaseImponible,
		@pAcum,
		@pTRet,
		@pAcumTot,
		@pcomMovProv
	)
END 

GO

DROP PROCEDURE tesRengMoviRetProvDatos
GO
CREATE PROCEDURE tesRengMoviRetProvDatos
(
@ptesMovimientos bigint,
@pconRenglon int
)
AS
SET NOCOUNT ON 

SELECT tesRengMoviRetProv.tesMovimientos, conAsientos.Fecha, tesRengMoviRetProv.conRenglon, tesRengMoviRetProv.Porcentaje,
	tesRengMoviRetProv.Exencion, tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Acum, tesRengMoviRetProv.TRet,
	tesRengMoviRetProv.AcumTot, tesRengMoviRetProv.comMovProv, tesIdentifica.Cartera_Id, genSegmentosRet.Segmento_Id,
	tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, tesRetProvSegmento.Segmento4N, 
tesRetProvSegmento.Segmento1C, tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,
'' NombreArchivo, '' PDF
FROM tesRengMoviRetProv 
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesRengMoviRetProv.tesMovimientos AND tesRengMovi.conRenglon = tesRengMoviRetProv.conRenglon
LEFT JOIN comMovProv ON comMovProv.comMovProv = tesRengMoviRetProv.comMovProv
Inner Join tesRetProvSegmento On tesRetProvSegmento.tesMovimientos = tesRengMovi.tesMovimientos And
			tesRetProvSegmento.conRenglon = tesRengMovi.conRenglon
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesRengMovi.Cartera_Id
Inner Join genSegmentos genSegmentosRet On genSegmentosRet.genSegmentos = tesIdRetProv.Segmento_Id
Inner Join conAsientos On conAsientos.conAsientos = tesRengMovi.tesMovimientos
WHERE tesRengMoviRetProv.tesMovimientos = @ptesMovimientos
AND tesRengMoviRetProv.conRenglon = @pconRenglon
 
RETURN @@Error 

GO

DROP PROCEDURE tesRengMoviRetProvEliminar
GO
CREATE PROCEDURE tesRengMoviRetProvEliminar
(
@ptesMovimientos bigint,
@pconRenglon int 
)
AS
SET NOCOUNT ON 

DELETE FROM tesRengMoviRetProv 
WHERE (tesMovimientos = @ptesMovimientos)
AND (conRenglon = @pconRenglon)
 
 RETURN @@Error 

GO

GO

