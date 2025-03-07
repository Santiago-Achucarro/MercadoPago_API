DROP PROCEDURE proProgramaOrdenInsertar
GO
CREATE PROCEDURE proProgramaOrdenInsertar
(
@pproProgramas int,
@pRenglon int,
@pproOrden int
)
AS
BEGIN 
	INSERT INTO proProgramaOrden
	(
		proProgramas,
		Renglon,
		proOrden
	)
	VALUES 
	(
		@pproProgramas,
		@pRenglon,
		@pproOrden
	)
END 

GO

DROP PROCEDURE proProgramaOrdenDatos
GO
CREATE PROCEDURE proProgramaOrdenDatos
(
@pproProgramas int=null,
@pRenglon int=null,
@pproOrden int=null
)
AS
SET NOCOUNT ON 

SELECT proProgramaOrden.proProgramas, proProgramaOrden.Renglon, proProgramaOrden.proOrden
FROM proProgramaOrden 
INNER JOIN proOrden  ON (proOrden.proOrden = proProgramaOrden.proOrden)
WHERE proProgramaOrden.proProgramas = isnull(@pproProgramas, proProgramaOrden.proProgramas)
AND proProgramaOrden.Renglon = ISNULL(@pRenglon,proProgramaOrden.Renglon)
AND proProgramaOrden.proOrden = ISNULL(@pproOrden,proProgramaOrden.proOrden)
 
RETURN @@Error 

GO

DROP PROCEDURE proProgramaOrdenEliminar
GO
CREATE PROCEDURE proProgramaOrdenEliminar
(
@pproProgramas int,
@pRenglon int
)
AS
SET NOCOUNT ON 

DELETE FROM proProgramaOrden 
WHERE (proProgramas = @pproProgramas) AND (Renglon = @pRenglon)

 
 RETURN @@Error 

GO


