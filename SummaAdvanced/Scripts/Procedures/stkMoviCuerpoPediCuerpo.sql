DROP PROCEDURE stkMoviCuerpoPediCuerpoInsertar
GO
CREATE PROCEDURE stkMoviCuerpoPediCuerpoInsertar
(
@pstkMoviCabe bigint,
@pRenglon int,
@pvenPedidos int,
@pRenglon_Pe int
)
AS
SET NOCOUNT ON 
	INSERT INTO stkMoviCuerpoPediCuerpo
	(
		stkMoviCabe,
		Renglon,
		venPedidos,
		Renglon_Pe
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pRenglon,
		@pvenPedidos,
		@pRenglon_Pe
	)

GO

DROP PROCEDURE stkMoviCuerpoPediCuerpoDatos
GO
CREATE PROCEDURE stkMoviCuerpoPediCuerpoDatos
(
@pstkMoviCabe bigint,
@pRenglon int=Null
)
AS
SET NOCOUNT ON 

SELECT stkMoviCuerpoPediCuerpo.stkMoviCabe, stkMoviCuerpoPediCuerpo.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	venPediCuerpo.CantidadPedida, stkMoviCuerpo.Cantidad, 
	stkMoviCuerpoPediCuerpo.venPedidos, stkMoviCuerpoPediCuerpo.Renglon_Pe
FROM stkMoviCuerpoPediCuerpo 
INNER JOIN stkMoviCuerpo  ON (stkMoviCuerpo.stkMoviCabe = stkMoviCuerpoPediCuerpo.stkMoviCabe) AND (stkMoviCuerpo.Renglon = stkMoviCuerpoPediCuerpo.Renglon)
INNER JOIN venPediCuerpo  ON (venPediCuerpo.venPedidos = stkMoviCuerpoPediCuerpo.venPedidos) AND (venPediCuerpo.Renglon_Pe = stkMoviCuerpoPediCuerpo.Renglon_Pe)
INNER JOIN stkProductos ON venPediCuerpo.Producto_Id = stkproductos.stkproductos 
WHERE (stkMoviCuerpoPediCuerpo.stkMoviCabe = @pstkMoviCabe)
AND (stkMoviCuerpoPediCuerpo.Renglon =  ISNULL(@pRenglon,stkMoviCuerpoPediCuerpo.Renglon))
 
RETURN @@Error 

GO

DROP PROCEDURE stkMoviCuerpoPediCuerpoEliminar
GO
CREATE PROCEDURE stkMoviCuerpoPediCuerpoEliminar
(
@pstkMoviCabe bigint,
@pRenglon int=Null
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCuerpoPediCuerpo 
WHERE (stkMoviCabe = @pstkMoviCabe) and 
(stkMoviCuerpoPediCuerpo.Renglon =  ISNULL(@pRenglon,stkMoviCuerpoPediCuerpo.Renglon))
 
 RETURN @@Error 

GO

