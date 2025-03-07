DROP PROCEDURE venListasPrecProdGuardar
GO
CREATE PROCEDURE venListasPrecProdGuardar
(
@pListaPrecio_Id int,
@pVersion Int,
@pProducto_Id varChar(25),
@pPrecioLista numeric(15,4),
@pPrecioPromocion numeric(15,4),
@pAdmiteRegalo bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venListasPrecProd WHERE 
	ListaPrecio_Id = @pListaPrecio_Id AND 
	Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Version = @pVersion))
	
BEGIN 
	UPDATE venListasPrecProd
	SET		PrecioLista = @pPrecioLista,
		PrecioPromocion = @pPrecioPromocion,
		AdmiteRegalo = @pAdmiteRegalo
	WHERE (ListaPrecio_Id = @pListaPrecio_Id) AND 
		(Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) and 
		Version = @pVersion)
END 
ELSE 
BEGIN 
	INSERT INTO venListasPrecProd
	(
		ListaPrecio_Id,
		Version,
		Producto_Id,
		PrecioLista,
		PrecioPromocion,
		AdmiteRegalo
	)
	VALUES 
	(
		@pListaPrecio_Id,
		@pVersion,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pPrecioLista,
		@pPrecioPromocion,
		@pAdmiteRegalo
	)
END 

GO

DROP PROCEDURE venListasPrecProdDatos
GO
CREATE PROCEDURE venListasPrecProdDatos
(
@pListaPrecio_Id varChar(5),
@pProducto_Id varChar(25),
@pVersion Int

)
AS
SET NOCOUNT ON 

SELECT venListasPrecios.venListasPrecios, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, 
	venListasPrecProd.Version, venListasVersion.VigenciaDesde as Fecha,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	venListasPrecProd.PrecioLista, venListasPrecProd.PrecioPromocion, venListasPrecProd.AdmiteRegalo
	FROM venListasPrecProd 
INNER JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venListasPrecProd.ListaPrecio_Id)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = venListasPrecProd.Producto_Id)
INNER JOIN venListasVersion ON venListasVersion.ListaPrecio_Id = venListasPrecProd.ListaPrecio_Id AND
					venListasVersion.Version =venListasPrecProd.Version
WHERE (venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)
AND (stkProductos.Producto_Id = @pProducto_Id) and 
venListasPrecProd.Version = @pVersion
 
RETURN @@Error 

GO

DROP PROCEDURE venListasPrecProdEliminar
GO
CREATE PROCEDURE venListasPrecProdEliminar
(
@pListaPrecio_Id varchar(5),
@pProducto_Id varchar(25)= NULL,
@pVersion Int
)
AS
SET NOCOUNT ON 

DELETE FROM venListasPrecProd 
WHERE (ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id))
AND (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) or @pProducto_Id IS NULL) 
and Version = @pVersion
 
 RETURN @@Error 

GO

DROP PROCEDURE venListasPrecProdFechaDatos
GO
CREATE PROCEDURE venListasPrecProdFechaDatos
(
@pListaPrecio_Id varChar(5),
@pProducto_Id varChar(25),
@pFecha DateTime
)
AS
SET NOCOUNT ON 

SELECT venListasPrecios.venListasPrecios, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, 
	venListasPrecProd.Version, venListasVersion.VigenciaDesde as Fecha,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	venListasPrecProd.PrecioLista, venListasPrecProd.PrecioPromocion, venListasPrecProd.AdmiteRegalo
	
FROM venListasPrecProd 
INNER JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venListasPrecProd.ListaPrecio_Id)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = venListasPrecProd.Producto_Id)
INNER JOIN venListasVersion ON venListasVersion.ListaPrecio_Id = venListasPrecProd.ListaPrecio_Id and 
	venListasVersion.Version = venListasPrecProd.Version
WHERE (venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)
AND (stkProductos.Producto_Id = @pProducto_Id) AND 
@pFecha BETWEEN venListasVersion.VigenciaDesde AND venListasVersion.VigenciaHasta
RETURN @@Error 

GO

