DROP VIEW vespStkProductosVenTest
GO
CREATE VIEW vespStkProductosVenTest
AS	
	SELECT stkProductos.Producto_Id, stkProductos.Descripcion,
	venListasPrecios.ListaPrecio_id, 
	Convert(Numeric(18,4), venListasPrecProd.PrecioLista *
		isnull(stkArtiUM.Factor, 1)) as PrecioLista, 
	stkUniMed.Medida_Id, stkCondFisVenta.CFVenta_Id, stkProductos.Inactivo, stkProductos.Posteado, stkProductos.Empresa_Id, 
	ISNULL(stkUniMedA.Medida_Id,' ') as MedidaAlterna, stkProductos.Clase, 
	ISNULL(stkFamilias.Familia_Id, ' ') as Familia_Id, ISNULL(stkFamilias.Descripcion,' ') DescripcionFamilia,
	ISNULL(stkGrupos.Grupo_Id, ' ') as Grupo_Id, ISNULL(stkGrupos.Descripcion,' ') DescripcionGrupo, Observaciones, 
	ISNULL (espstkColorTest.Color_Id, '') Color_Id, ISNULL (espstkTalleTest.Talle_Id, '') Talle_Id
	From stkProductos INNER JOIN venListasPrecProd ON stkProductos.stkProductos = venListasPrecProd.Producto_Id
		INNER JOIN venListasPrecios ON venListasPrecios.venListasPrecios = venListasPrecProd.ListaPrecio_Id
		INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.UMVenta
		INNER JOIN stkCondFisVenta ON stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
		LEFT OUTER JOIN stkArtiUM on stkArtiUM.Producto_Id = stkProductos.stkProductos and 
			stkArtiUM.Medida_Id = stkProductos.UMVenta
		LEFT JOIN stkUniMed  as stkUniMedA on
			stkUniMedA.stkUniMed = stkproductos.MedidaAlterna
		LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
		LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
		LEFT JOIN espProductosColorTalleTest ON espProductosColorTalleTest.Producto_Id = stkProductos.stkProductos
		LEFT JOIN espstkColorTest ON espstkColorTest.espstkColorTest = espProductosColorTalleTest.Color_Id
		LEFT JOIN espstkTalleTest ON espstkTalleTest.espstkTalleTest = espProductosColorTalleTest.Talle_Id


GO