-- exec comEmbarquesCostoReal  311, 21.30, '20191231'
DROP PROCEDURE comEmbarquesCostoReal 
GO
CREATE PROCEDURE comEmbarquesCostoReal 
(
	@comEmbarques bigint, 
	@Cambio Numeric(18,4), 
	@Fecha DateTime = NULL
)
AS
Declare @lEmpresa_Id Int
Select @lEmpresa_Id = conAsientos.Empresa_Id
From comEmbarques
Inner Join conAsientos On conAsientos.conAsientos = comEmbarques.comEmbarques
Where comEmbarques.comEmbarques = @comEmbarques

-- Si Tiene 2 veces el mismo prodcuto esta mal
-- Embaruqes 
SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
	SUM(stkMoviCuerpo.Cantidad) AS Cantidad, comEmbCuerpo.PrecioCalculado*@Cambio as PrecioCalculado, 
	SUM(stkMoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario) / SUM(stkMoviCuerpo.Cantidad) as Costo, 
	comOCCuerpo.Precio as PrecioOC, conCuentas.Cuenta_Id as CtaAjuInventario, 
	ISNULL((SELECT sum(stkMoviCuerpoReva.ImporteAjuste + ImporteAjusteCosto)
		from stkMoviCuerpoReva 
		INNER JOIN comEmbAsiCierre ON stkMoviCuerpoReva.stkMoviCabe=comEmbAsiCierre.stkMoviCabe and stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos
		inner join conasientos conA ON conA.conAsientos = comEmbAsiCierre.stkMoviCabe
			where
				(@Fecha IS NULL OR conA.FechaRegistro <= @Fecha) and 
				conA.Anulado = 0 and conA.Empresa_Id = @lEmpresa_Id And
				conA.Posteado = 1 And comEmbAsiCierre.comEmbarques = @comEmbarques),0) CierresAnt,
	ISNULL((SELECT sum(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo)
		from stkMoviCuerpo
		Inner Join stkMoviCabe On stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
		inner join conasientos conA ON conA.conAsientos = stkMoviCabe.stkMoviCabe
			where
				(@Fecha IS NULL OR conA.FechaRegistro <= @Fecha) and stkMoviCuerpo.Producto_Id = stkProductos.stkProductos And
				conA.Anulado = 0 and conA.Empresa_Id = @lEmpresa_Id And
				conA.Posteado = 1),0) Existencia

From stkMoviEmbarque
Inner Join conAsientos On conAsientos.conAsientos = stkMoviEmbarque.comEmbarques
INNER JOIN stkMoviCuerpo ON stkMoviEmbarque.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
inner join stkProductos ON stkProductos.stkProductos =stkMoviCuerpo.Producto_Id
inner join stkMoviOC ON stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND stkMoviOC.Renglon = stkMoviCuerpo.Renglon
INNER JOIN comEmbCuerpo ON comEmbCuerpo.comEmbarques = stkMoviEmbarque.comEmbarques and 
		comEmbCuerpo.comOrdenComp =stkMoviOC.comOrdenComp and
		comEmbCuerpo.Renglon_OC = stkMoviOC.Renglon_OC
INNER JOIN comOCCuerpo ON comOCCuerpo.comOrdenComp = comEmbCuerpo.comOrdenComp and comOCCuerpo.Renglon_OC = comEmbCuerpo.Renglon_OC
inner join comOCArticulo on comocArticulo.comOrdenComp = comEmbCuerpo.comOrdenComp and comocArticulo.Renglon_OC = comEmbCuerpo.Renglon_OC
left JOIN conCuentas ON conCuentas.conCuentas = stkProductos.CtaAjuInventario
WHERE
	stkMoviEmbarque.comEmbarques = @comEmbarques
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion,comEmbCuerpo.PrecioCalculado, 
comOCCuerpo.Precio, conCuentas.Cuenta_Id, stkProductos.stkProductos

-- FACTURA DE GASTOS

SELECT comEmbGastos.Renglon, 
	comEmbGastos.Importe, comEmbGastos.CantidadImporte, 
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) AS ImporteReal
FROM conMovCont inner join comEmbGastoMovProv ON
conMovCont.conAsientos = comEmbGastoMovProv.comMovProv and 
conMovCont.Renglon =comEmbGastoMovProv.comRenglon
inner join comEmbGastos ON
comEmbGastos.comEmbarques = comEmbGastoMovProv.comEmbarques and
comEmbGastos.Renglon = comEmbGastoMovProv.Renglon
inner join comMovDetalle ON
comMovDetalle.comMovProv = comEmbGastoMovProv.comMovProv AND
comMovDetalle.Renglon =comEmbGastoMovProv.comRenglon
WHERE
	 
	comEmbGastoMovProv.comEmbarques = @comEmbarques
GROUP BY comEmbGastos.Renglon, 	comEmbGastos.Importe, comEmbGastos.CantidadImporte


	
GO



