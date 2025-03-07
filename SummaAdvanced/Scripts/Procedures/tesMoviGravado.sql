DROP PROCEDURE tesMoviGravadoGuardar
GO
CREATE PROCEDURE tesMoviGravadoGuardar
(
@ptesMovimientos bigint,
@pTipoCtaProv int,
@pImporte qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesMoviGravado WHERE (tesMovimientos = @ptesMovimientos) AND (TipoCtaProv = @pTipoCtaProv)))
BEGIN 
	UPDATE tesMoviGravado
	SET Importe = @pImporte
	WHERE (tesMovimientos = @ptesMovimientos) AND (TipoCtaProv = @pTipoCtaProv)
END 
ELSE 
BEGIN 
	INSERT INTO tesMoviGravado
	(
		tesMovimientos,
		TipoCtaProv,
		Importe
	)
	VALUES 
	(
		@ptesMovimientos,
		@pTipoCtaProv,
		@pImporte
	)
END 

GO

DROP PROCEDURE tesMoviGravadoDatos
GO
CREATE PROCEDURE tesMoviGravadoDatos
(
@ptesMovimientos bigint,
@pTipoCtaProv int = Null
)
AS
SET NOCOUNT ON 

SELECT tesMoviGravado.tesMovimientos, tesMoviGravado.TipoCtaProv, comProveedoresTipoPasivo.Descripcion as DescripcionProveedoresTipoPasivo,
	tesMoviGravado.Importe
FROM tesMoviGravado 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesMoviGravado.tesMovimientos)
INNER JOIN comProveedoresTipoPasivo  ON (comProveedoresTipoPasivo.TipoCtaProv = tesMoviGravado.TipoCtaProv)
WHERE tesMoviGravado.tesMovimientos = @ptesMovimientos
AND tesMoviGravado.TipoCtaProv = IsNull(@pTipoCtaProv, tesMoviGravado.TipoCtaProv)

RETURN @@Error 

GO

DROP PROCEDURE tesMoviGravadoEliminar
GO
CREATE PROCEDURE tesMoviGravadoEliminar
(
@ptesMovimientos bigint,
@pTipoCtaProv int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM tesMoviGravado 
WHERE tesMovimientos = @ptesMovimientos
AND TipoCtaProv = IsNull(@pTipoCtaProv, TipoCtaProv)
 
RETURN @@Error 

GO
