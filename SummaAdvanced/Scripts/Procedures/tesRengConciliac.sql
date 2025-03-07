DROP PROCEDURE tesRengConciliacGuardar
GO
CREATE PROCEDURE tesRengConciliacGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pSaldo qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRengConciliac WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE tesRengConciliac
	SET		Saldo = @pSaldo
	WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesRengConciliac
	(
		tesMovimientos,
		conRenglon,
		Saldo
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		@pSaldo
	)
END 

GO

DROP PROCEDURE tesRengConciliacDatos
GO
CREATE PROCEDURE tesRengConciliacDatos
(
@ptesMovimientos bigint,
@pconRenglon int= NULL, 
@pTipomov int= NULL
)
AS
SET NOCOUNT ON 

SELECT tesRengConciliac.tesMovimientos, tesRengConciliac.conRenglon, tesRengConciliac.Saldo
FROM tesRengConciliac 
INNER JOIN tesRengMovi  ON 
	tesRengMovi.tesMovimientos = tesRengConciliac.tesMovimientos AND 
	tesRengMovi.conRenglon = tesRengConciliac.conRenglon
INNER JOIN conMovCont on 
conMovCont.conAsientos = tesRengMovi.tesMovimientos  and 
conMovCont.Renglon = tesRengMovi.conRenglon
WHERE (tesRengConciliac.tesMovimientos = @ptesMovimientos)
AND (tesRengConciliac.conRenglon = ISNULL(@pconRenglon, tesRengConciliac.conRenglon))
AND (conMovCont.TipoMov = ISNULL(@pTipomov, conMovCont.TipoMov))
 
 RETURN @@Error 

GO

DROP PROCEDURE tesRengConciliacEliminar
GO
CREATE PROCEDURE tesRengConciliacEliminar
(
@ptesMovimientos bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesRengConciliac 
WHERE (tesRengConciliac.tesMovimientos = @ptesMovimientos)
AND (tesRengConciliac.conRenglon = ISNULL(@pconRenglon, tesRengConciliac.conRenglon))
 
 RETURN @@Error 

GO

GO
