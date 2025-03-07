--Inf_comCostosImprtacion 'EMB',1,0,0,0,'0001',' ',' ',' ',1,1

DROP PROCEDURE Inf_comCostosImprtacion
GO
CREATE PROCEDURE Inf_comCostosImprtacion
(
	@Segmento_Id VarChar(10),
	@Segmento1N INT, 
	@Segmento2N INT, 
	@Segmento3N INT, 
	@Segmento4N INT, 
	@Segmento1C VarChar(25), 
	@Segmento2C VarChar(25), 
	@Segmento3C VarChar(25), 
	@Segmento4C VarChar(25), 
	@Segmento1NHasta INT, 
	@Empresa_Id Int
)
as



			

	
select xxx.comEmbarques, Renglon, Embarque, Producto_Id, Descripcion, CantidadOriginal as Cantidad, 
	PrecioOriginal as Precio,  PrecioCalculadoOriginal as PrecioEstimado, 
	Detalle DetalleGasto, ImporteOriginal * case when CantidadImporte ='I' THEN PrecioOriginal*CantidadOriginal / Total ELSE
		CantidadOriginal / CantidadTotal END / case when xxx.Moneda_id = xxx.MonedaGasto THEN 1 ELSE 
			Cambio.Cambio end  AS GastoEstimado,
		GastosReales * case when CantidadImporte ='I' THEN PrecioOriginal*CantidadOriginal / Total ELSE
		CantidadOriginal / CantidadTotal END / Cambio.Cambio GastoReal
from 
(
SELECT comEmbarques.comEmbarques , comEmbCuerpo.comOrdenComp*1000+comEmbCuerpo.Renglon_OC AS Renglon,
	conAsientos.Moneda_Id,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
		genAsiSegmentos.Segmento4N) AS Embarque,
		stkProductos.Producto_Id, stkProductos.Descripcion, comEmbCuerpo.CantidadOriginal, 
		comOCArticulo.PrecioOriginal,  	comEmbCuerpo.PrecioCalculadoOriginal, 
		comEmbGastos.Detalle, comEmbGastos.ImporteOriginal  ,comEmbGastos.CantidadImporte, 
			comEmbGastos.Moneda_Id AS MonedaGasto,
		ISNULL((SELECT SUM(comMovDetalle.Importe*conAsientos.Cambio)  
			from comEmbGastoMovProv inner join comMovDetalle ON
			comEmbGastoMovProv.comMovProv = comMovDetalle.comMovProv and 
			comEmbGastoMovProv.comRenglon = comMovDetalle.Renglon
			inner join conAsientos ON conAsientos.conAsientos = comMovDetalle.comMovProv 
			Where
				conAsientos.Posteado= 1 and 
				conAsientos.Anulado = 0 and 
				comEmbGastoMovProv.comEmbarques = comEmbGastos.comEmbarques and 
				comEmbGastoMovProv.Renglon = comEmbGastos.Renglon),0) as GastosReales, 
		ISNULL((SELECT SUM(comEmbCuerpo.CantidadOriginal * comOCArticulo.PrecioOriginal)  
			from comEmbCuerpo inner join comOCArticulo ON 
			comEmbCuerpo.comOrdenComp = comOCArticulo.comOrdenComp AND 
			comEmbCuerpo.Renglon_OC = comOCArticulo.Renglon_OC
			Where
				comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques ),0) AS Total, 
		ISNULL((SELECT SUM(comEmbCuerpo.CantidadOriginal)  
			from comEmbCuerpo inner join comOCArticulo ON 
			comEmbCuerpo.comOrdenComp = comOCArticulo.comOrdenComp AND 
			comEmbCuerpo.Renglon_OC = comOCArticulo.Renglon_OC
			Where
				comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques ),0) AS CantidadTotal
FROM comEmbarques 
	inner join genAsiSegmentos ON comEmbarques.comEmbarques = genAsiSegmentos.Asiento_Id
	inner join conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	inner join comEmbCuerpo ON	comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques
	inner join comOCArticulo ON comOCArticulo.comOrdenComp = comEmbCuerpo.comOrdenComp and 
				comOCArticulo.Renglon_OC = 	comEmbCuerpo.Renglon_OC
	INNER JOIN stkProductos ON  stkProductos.stkProductos = comOCArticulo.Producto_Id
	INNER JOIN comEmbGastos ON comEmbGastos.comEmbarques = comEmbarques.comEmbarques
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Where
		conAsientos.Posteado = 1 and 
		conAsientos.Anulado = 0 and 
		genAsiSegmentos.Empresa_Id = @Empresa_Id AND
		genSegmentos.Segmento_Id = @Segmento_Id AND 
		genAsiSegmentos.Segmento1C = @Segmento1C AND
		genAsiSegmentos.Segmento2C = @Segmento2C AND
		genAsiSegmentos.Segmento3C = @Segmento3C AND
		genAsiSegmentos.Segmento4C = @Segmento4C AND
		genAsiSegmentos.Segmento1N between @Segmento1N AND @Segmento1NHasta and 
		genAsiSegmentos.Segmento2N = @Segmento2N AND
		genAsiSegmentos.Segmento3N = @Segmento3N AND
		genAsiSegmentos.Segmento4N = @Segmento4N 

) as xxx  INNER JOIN 
(select stkMoviEmbarque.comEmbarques, comDespachos.cambio 
		from comDespachos inner join stkMoviEmbarque ON 
				stkMoviEmbarque.Despacho_Id = comDespachos.comDespachos  
			inner join conAsientos ON 
				conAsientos.conAsientos = stkMoviEmbarque.stkMoviCabe
			where
				conAsientos.Anulado= 0 and 
				conAsientos.Posteado = 1 ) as Cambio  on 
				Cambio.comEmbarques = xxx.comEmbarques
ORDER BY 1,2

GO
