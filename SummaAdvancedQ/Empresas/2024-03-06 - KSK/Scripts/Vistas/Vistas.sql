DROP VIEW vespStkProductosVenKSK
GO
CREATE VIEW vespStkProductosVenKSK
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

-- 19/07/2023 para filtrar desde el punto de ventas los creditos con comprobantes asociados
DROP VIEW vEspvenMovimientosAsociadosKSK 
GO
CREATE VIEW vEspvenMovimientosAsociadosKSK 
as
SELECT venMovimientos.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
conAsientos.Fecha, venMovimientos.venTipomov, 
ISNULL(venSubTipomov.SubTipomov_Id,'') SubTipomov_Id,
ISNULL(venClientes.Cliente_Id,'') Cliente_Id, 
ISNULL(venClientes.RazonSocial,'') RazonSocial, 
ISNULL(venSubTipomov.MueveStock,0) MueveStock ,
disFormularios.Formulario_Id , conAsientos.Empresa_Id as Empresa, conAsientos.Anulado,
	venMovimientos.Importe, venMovimientos.Saldo, venTipoMov.Signo,
	venVendedores.Vendedor_Id
FROM venMovimientos 
LEFT JOIN venSubTipomov ON venMovimientos.venSubTipomov_Id = venSubTipomov.venSubTipomov
left join venClientes	ON venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
LEFT OUTER JOIN disFormularios ON disFormularios.disFormularios= conAsientos.Formulario_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
left JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
where not exists(select '' from venMovimientosCFDIR where venmovimientos.venMovimientos = venMovimientosCFDIR.venMovimientosR)

GO



