DROP PROCEDURE tesT3LinkGuardar
GO
CREATE PROCEDURE tesT3LinkGuardar
(
@ptesMovimientos bigint,
@pconRenglon int,
@pEstado char(1),
@pSecuencia int,
@ptesTarjetas3 int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesT3Link WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE tesT3Link
	SET	 Estado = @pEstado,
		Secuencia = @pSecuencia,
		tesTarjetas3 = @ptesTarjetas3
	WHERE (tesMovimientos = @ptesMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesT3Link
	(
		tesMovimientos,
		conRenglon,
		Estado,
		Secuencia,
		tesTarjetas3
	)
	VALUES 
	(
		@ptesMovimientos,
		@pconRenglon,
		@pEstado,
		@pSecuencia,
		@ptesTarjetas3
	)
END 
GO

DROP PROCEDURE tesT3LinkDatos
GO
CREATE PROCEDURE tesT3LinkDatos
(
@ptesMovimientos bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

SELECT tesT3Link.tesMovimientos, tesT3Link.conRenglon, tesT3Link.Estado,
	tesTarjetas3Estado.Descripcion as DescripcionCheqTerEstado, tesT3Link.Secuencia, tesT3Link.tesTarjetas3, 
	tesTarjetas3.Cupon	
FROM tesT3Link 
INNER JOIN tesRengMovi  ON (tesRengMovi.tesMovimientos = tesT3Link.tesMovimientos) AND (tesRengMovi.conRenglon = tesT3Link.conRenglon)
INNER JOIN tesTarjetas3Estado  ON (tesT3Link.Estado = tesT3Link.Estado)
LEFT JOIN tesTarjetas3  ON (tesTarjetas3.tesTarjetas3 = tesT3Link.tesTarjetas3)
WHERE (tesT3Link.tesMovimientos = @ptesMovimientos)
AND (tesT3Link.conRenglon = ISNULL(@pconRenglon, tesT3Link.conRenglon))
 
RETURN @@Error 
GO

DROP PROCEDURE tesT3LinkEliminar
GO
CREATE PROCEDURE tesT3LinkEliminar
(
@ptesMovimientos bigint,
@pconRenglon int= null
)
AS
SET NOCOUNT ON 

DELETE FROM tesT3Link 
WHERE (tesMovimientos = @ptesMovimientos)
AND (tesT3Link.conRenglon = ISNULL(@pconRenglon, tesT3Link.conRenglon))
 
RETURN @@Error 
GO