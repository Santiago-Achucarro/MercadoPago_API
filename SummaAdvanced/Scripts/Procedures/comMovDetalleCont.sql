DROP PROCEDURE comMovDetalleContInsertar
GO
CREATE PROCEDURE comMovDetalleContInsertar
(
@pcomMovProv bigint,
@pRenglon int,
@pconRenglon int
)
AS

	INSERT INTO comMovDetalleCont
	(
		comMovProv,
		Renglon,
		conRenglon
	)
	VALUES 
	(
		@pcomMovProv,
		@pRenglon,
		@pconRenglon
	)

GO

DROP PROCEDURE comMovDetalleContDatos
GO
CREATE PROCEDURE comMovDetalleContDatos
(
@pcomMovProv bigint,
@pRenglon int = Null,
@pconRenglon int= Null
)
AS
SET NOCOUNT ON 

SELECT comMovDetalleCont.comMovProv, comMovDetalleCont.Renglon, comMovDetalleCont.conRenglon
FROM comMovDetalleCont 
WHERE comMovProv = @pcomMovProv
	AND Renglon = ISNULL(@pRenglon,Renglon)
	AND conRenglon = ISNULL(@pRenglon,conRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE comMovDetalleContEliminar
GO
CREATE PROCEDURE comMovDetalleContEliminar
(
@pcomMovProv bigint,
@pRenglon int=null,
@pconRenglon int= null
)
AS
SET NOCOUNT ON 

DELETE FROM comMovDetalleCont 
WHERE comMovProv = @pcomMovProv
	AND Renglon = ISNULL(@pRenglon,Renglon)
	AND conRenglon = ISNULL(@pRenglon,conRenglon)
 
RETURN @@Error 

GO

