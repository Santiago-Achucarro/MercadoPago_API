DROP PROCEDURE tesMoviReversaGuardar
GO
CREATE PROCEDURE tesMoviReversaGuardar
(
@ptesMovimientos bigint,
@ptesMoviReversa bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesMoviReversa WHERE (tesMovimientos = @ptesMovimientos)))
BEGIN 
	UPDATE tesMoviReversa
	SET		tesMoviReversa = @ptesMoviReversa
	WHERE (tesMovimientos = @ptesMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO tesMoviReversa
	(
		tesMovimientos,
		tesMoviReversa
	)
	VALUES 
	(
		@ptesMovimientos,
		@ptesMoviReversa
	)
END 

GO

DROP PROCEDURE tesMoviReversaDatos
GO
CREATE PROCEDURE tesMoviReversaDatos
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT tesMoviReversa.tesMovimientos, tesMoviReversa.tesMoviReversa, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C
FROM tesMoviReversa 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesMoviReversa.tesMovimientos)
INNER JOIN genAsiSegmentos ON (genAsiSegmentos.Asiento_Id = tesMoviReversa.tesMoviReversa)
WHERE (tesMoviReversa.tesMovimientos = @ptesMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesMoviReversaEliminar
GO
CREATE PROCEDURE tesMoviReversaEliminar
(
@ptesMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM tesMoviReversa 
WHERE (tesMovimientos = @ptesMovimientos)
 
 RETURN @@Error 

GO



DROP PROCEDURE tesMoviReversaRevDatos
GO
CREATE PROCEDURE tesMoviReversaRevDatos
(
@ptesMovimientosRev bigint
)
AS
SET NOCOUNT ON 

SELECT tesMoviReversa.tesMovimientos, tesMoviReversa.tesMoviReversa, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C
FROM tesMoviReversa 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesMoviReversa.tesMovimientos)
INNER JOIN genAsiSegmentos ON (genAsiSegmentos.Asiento_Id = tesMoviReversa.tesMoviReversa)
WHERE (tesMoviReversa.tesMoviReversa = @ptesMovimientosRev)
 
 RETURN @@Error 

GO
