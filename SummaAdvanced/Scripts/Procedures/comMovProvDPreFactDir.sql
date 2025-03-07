DROP PROCEDURE comMovProvDPreFactDirInsertar
GO
CREATE PROCEDURE comMovProvDPreFactDirInsertar
(
@pcomMovProv bigint,
@pRenglon int,
@pstkMoviCabe bigint ,
@pRenglonStk int ,
@pCantidadOriginal qCantidadD8,
@pCantidad qCantidadD8,
@pDescuento qPorcentaje,
@pMonto qMonedaD8
)
AS
SET NOCOUNT ON 
	INSERT INTO comMovProvDPreFactDir
	(
		comMovProv,
		Renglon,
		stkMoviCabe,
		RenglonStk,
		CantidadOriginal,
		Cantidad,
		Descuento,
		Monto
	)
	VALUES 
	(
		@pcomMovProv,
		@pRenglon,
		@pstkMoviCabe,
		@pRenglonStk,
		@pCantidadOriginal,
		@pCantidad,
		@pDescuento,
		@pMonto
	)
GO

DROP PROCEDURE comMovProvDPreFactDirDatos
GO
CREATE PROCEDURE comMovProvDPreFactDirDatos
(
@pcomMovProv bigint,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT comMovProvDPreFactDir.comMovProv, comMovProvDPreFactDir.Renglon, comMovProvDPreFactDir.stkMoviCabe,
	comMovProvDPreFactDir.RenglonStk, comMovProvDPreFactDir.CantidadOriginal, comMovProvDPreFactDir.Cantidad, comMovProvDPreFactDir.Descuento,
	comMovProvDPreFactDir.Monto
FROM comMovProvDPreFactDir 
WHERE (comMovProvDPreFactDir.comMovProv = @pcomMovProv)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE comMovProvDPreFactDirEliminar
GO
CREATE PROCEDURE comMovProvDPreFactDirEliminar
(
@pcomMovProv bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProvDPreFactDir 
WHERE (comMovProv = @pcomMovProv)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

