DROP PROCEDURE tesRengMovicomMovProvGuardar
GO
CREATE PROCEDURE tesRengMovicomMovProvGuardar
(
@ptesMovimientos bigint,
@pRenglon int,
@pcomMovProv bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRengMovicomMovProv WHERE (tesMovimientos = @ptesMovimientos) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE tesRengMovicomMovProv
	SET		comMovProv = @pcomMovProv
	WHERE (tesMovimientos = @ptesMovimientos) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesRengMovicomMovProv
	(
		tesMovimientos,
		Renglon,
		comMovProv
	)
	VALUES 
	(
		@ptesMovimientos,
		@pRenglon,
		@pcomMovProv
	)
END 

GO

DROP PROCEDURE tesRengMovicomMovProvDatos
GO
CREATE PROCEDURE tesRengMovicomMovProvDatos
(
@ptesMovimientos bigint,
@pRenglon int= NULL
)
AS
SET NOCOUNT ON 

SELECT tesRengMovicomMovProv.tesMovimientos, tesRengMovicomMovProv.Renglon,  tesRengMovicomMovProv.comMovProv
FROM tesRengMovicomMovProv 
WHERE (tesMovimientos = @ptesMovimientos)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
RETURN @@Error 

GO

DROP PROCEDURE tesRengMovicomMovProvDatosXcomMovProv
GO
CREATE PROCEDURE tesRengMovicomMovProvDatosXcomMovProv
(
@pcomMovProv bigint
)
AS
SET NOCOUNT ON 

SELECT tesRengMovicomMovProv.tesMovimientos, tesRengMovicomMovProv.Renglon,  tesRengMovicomMovProv.comMovProv
FROM tesRengMovicomMovProv 
WHERE (tesMovimientos = @pcomMovProv)
 
RETURN @@Error 

GO

DROP PROCEDURE tesRengMovicomMovProvEliminar
GO
CREATE PROCEDURE tesRengMovicomMovProvEliminar
(
@ptesMovimientos bigint,
@pRenglon int=null
)
AS
SET NOCOUNT ON 

DELETE FROM tesRengMovicomMovProv 
WHERE (tesMovimientos = @ptesMovimientos)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
RETURN @@Error 

GO

