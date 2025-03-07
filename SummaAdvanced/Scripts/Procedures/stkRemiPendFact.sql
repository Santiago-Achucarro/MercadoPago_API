DROP PROCEDURE stkRemiPendFactGuardar
GO
CREATE PROCEDURE stkRemiPendFactGuardar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidadPendiente qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkRemiPendFact WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE stkRemiPendFact
	SET		CantidadPendiente = @pCantidadPendiente
	WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO stkRemiPendFact
	(
		stkMoviCabe,
		Renglon,
		CantidadPendiente
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pCantidadPendiente
	)
END 

GO

DROP PROCEDURE stkRemiPendFactDatos
GO
CREATE PROCEDURE stkRemiPendFactDatos
(
@pstkMoviCabe bigint,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

SELECT stkRemiPendFact.stkMoviCabe, stkRemiPendFact.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto,
	stkMoviCuerpo.Cantidad,  stkRemiPendFact.CantidadPendiente
FROM stkRemiPendFact 
INNER JOIN stkMoviCuerpo  ON (stkMoviCuerpo.stkMoviCabe = stkRemiPendFact.stkMoviCabe) AND (stkMoviCuerpo.Renglon = stkRemiPendFact.Renglon)
INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
WHERE (stkRemiPendFact.stkMoviCabe = @pstkMoviCabe)
AND (stkRemiPendFact.Renglon = isnull(@pRenglon,stkRemiPendFact.Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE stkRemiPendFactEliminar
GO
CREATE PROCEDURE stkRemiPendFactEliminar
(
@pstkMoviCabe bigint,
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkRemiPendFact 
WHERE (stkMoviCabe = @pstkMoviCabe)
AND (stkRemiPendFact.Renglon = isnull(@pRenglon,stkRemiPendFact.Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE stkRemiPendFactActualizarPend
GO
CREATE PROCEDURE stkRemiPendFactActualizarPend
(
@pstkMoviCabe bigint,
@pRenglon int,
@pCantidadPendiente qCantidadD8
)
AS
SET NOCOUNT ON 
UPDATE stkRemiPendFact
	SET		CantidadPendiente = CantidadPendiente - @pCantidadPendiente
		WHERE (stkMoviCabe = @pstkMoviCabe) AND (Renglon = @pRenglon)

GO



