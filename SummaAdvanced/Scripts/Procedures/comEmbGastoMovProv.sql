DROP PROCEDURE comEmbGastoMovProvInsertar
GO
CREATE PROCEDURE comEmbGastoMovProvInsertar
(
@pcomMovProv bigint,
@pcomRenglon int,
@pcomEmbarques bigint,
@pRenglon int
)
AS
	INSERT INTO comEmbGastoMovProv
	(
		comMovProv,
		comRenglon,
		comEmbarques,
		Renglon
	)
	VALUES 
	(
		@pcomMovProv,
		@pcomRenglon,
		@pcomEmbarques,
		@pRenglon
	)

GO

DROP PROCEDURE comEmbGastoMovProvDatos
GO
CREATE PROCEDURE comEmbGastoMovProvDatos
(
@pcomMovProv bigint,
@pcomRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT comEmbGastoMovProv.comMovProv, comEmbGastoMovProv.comRenglon, comEmbGastoMovProv.comEmbarques,
	comEmbGastoMovProv.Renglon, comEmbGastos.Detalle
FROM comEmbGastoMovProv  
INNER JOIN comEmbGastos  ON (comEmbGastos.comEmbarques = comEmbGastoMovProv.comEmbarques) AND (comEmbGastos.Renglon = comEmbGastoMovProv.Renglon)
WHERE (comMovProv = @pcomMovProv)
AND (comRenglon = ISNULL(@pcomRenglon, comRenglon))
 
RETURN @@Error 

GO

DROP PROCEDURE comEmbGastoMovProvEliminar
GO
CREATE PROCEDURE comEmbGastoMovProvEliminar
(
@pcomMovProv bigint,
@pcomRenglon int=null
)
AS
SET NOCOUNT ON 

DELETE FROM comEmbGastoMovProv 
WHERE (comMovProv = @pcomMovProv)
AND (comRenglon = ISNULL(@pcomRenglon, comRenglon))
 
 RETURN @@Error 

GO

GO
