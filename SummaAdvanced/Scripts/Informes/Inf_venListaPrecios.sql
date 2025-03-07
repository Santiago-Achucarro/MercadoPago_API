-- Inf_venListaPrecios ' ','zzz',1
DROP PROCEDURE Inf_venListaPrecios
GO
CREATE PROCEDURE Inf_venListaPrecios
(
	@ListaDesde VarChar(15),
	@ListaHasta VarChar(15),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@Empresa Int
)

AS

SELECT venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionLista, 
	venListasPrecios.Inactivo, venListasPrecios.Posteado, 
	genMonedas.Moneda_Id,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	venListasPrecProd.PrecioLista, venListasPrecProd.PrecioPromocion, 
	venListasPrecProd.AdmiteRegalo, stkFamilias.Familia_Id, stkFamilias.Descripcion as DescripcionFamilia
From venListasPrecios INNER JOIN genMonedas ON
	venListasPrecios.Moneda_Id = genMonedas.genMonedas
	INNER JOIN venListasPrecProd ON
	venListasPrecProd.ListaPrecio_Id = venListasPrecios.venListasPrecios
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = venListasPrecProd.Producto_Id
	LEFT JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
	Where
	venListasPrecios.ListaPrecio_Id between @ListaDesde and @ListaHasta and
	isnull(stkFamilias.Familia_Id,' ') between @FamiliaDesde and @FamiliaHasta and
	@Empresa = ISNULL( venListasPrecios.Empresa_Id, @Empresa)
ORDER BY 1,6
GO
	
