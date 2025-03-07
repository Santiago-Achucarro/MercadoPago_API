DROP PROCEDURE proOrdenProdSerieGuardar
GO
CREATE PROCEDURE proOrdenProdSerieGuardar
(
@pproOrden int,
@pRenglon int,
@pSerie varchar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenProdSerie WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon) and (Serie = @pSerie)))
BEGIN 
	UPDATE proOrdenProdSerie
	SET	   Cantidad = @pCantidad
	WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon) and (Serie = @pSerie)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenProdSerie
	(
		proOrden,
		Renglon,
		Serie,
		Cantidad
	)
	VALUES 
	(
		@pproOrden,
		@pRenglon,
		@pSerie,
		@pCantidad
	)
END 

GO

DROP PROCEDURE proOrdenProdSerieDatos
GO
CREATE PROCEDURE proOrdenProdSerieDatos
(
@pproOrden int,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT proOrdenProdSerie.proOrden, proOrdenProdSerie.Renglon, proOrdenProdSerie.Serie,proOrdenProdSerie.Cantidad,stkSerieVencimiento.Vencimiento, ' ' AS Ubicacion_Id
FROM proOrdenProdSerie 
INNER JOIN proOrdenProd  ON (proOrdenProd.proOrden = proOrdenProdSerie.proOrden) AND (proOrdenProd.Renglon = proOrdenProdSerie.Renglon)
INNER JOIN proOrden ON proOrdenProd.proOrden = proOrden.proOrden
INNER JOIN proOrdenSegmento on	proOrden.proOrden = proOrdenSegmento.proOrden
Left Join stkSerieVencimiento ON stkSerieVencimiento.Serie =  proOrdenProdSerie.Serie And stkSerieVencimiento.Producto_Id = proOrdenProd.Producto_Id And
		stkSerieVencimiento.Empresa_Id = proOrdenSegmento.Empresa_Id
WHERE (proOrdenProdSerie.proOrden = @pproOrden)
AND (proOrdenProdSerie.Renglon = @pRenglon)
 
 RETURN @@Error 

GO


DROP PROCEDURE proOrdenProdSerieEliminar
GO
CREATE PROCEDURE proOrdenProdSerieEliminar
(
@pproOrden int,
@pRenglon int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenProdSerie 
WHERE (proOrden = @pproOrden)
AND Renglon = isnull(@pRenglon,Renglon)
 
RETURN @@Error 

GO

GO
