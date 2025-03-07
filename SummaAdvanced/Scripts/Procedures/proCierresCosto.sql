--EXEC proCierresCosto 10531

DROP PROCEDURE proCierresCosto
go
CREATE PROCEDURE proCierresCosto
(
	@stkMoviCabe BigInt
)

AS

declare @proMovCierreOrden as bigint
SET @proMovCierreOrden = (SELECT proMovCierreOrden FROM 
	proOrdenStock where stkMoviCabe = @stkMoviCabe)

Select  proOrdenStock.stkMovicabe
from proOrdenStock
Where
	stkMoviCabe = @stkMoviCabe


Select  proMovCierreOrden.proMovCierreOrden, 
ISNULL((select sum(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario)
from proOrdenStock INNER JOIN stkMoviCabe ON 
proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden AND 
proOrdenStock.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN  stkMoviCuerpo ON
stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
inner join conAsientos ON 
conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
Where
	stkMoviCabe.Signo = -1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1),0) as Materiales, 
	ISNULL((SELECT SUM(proMovCierreTrabajos3.Cantidad* proMovCierreTrabajos3.Precio)
	from proMovCierreTrabajos3 Where
	proMovCierreTrabajos3.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden),0) as Trabajos3,

	ISNULL((SELECT SUM(proMovCierreRecursos.Cantidad* proMovCierreRecursos.Costo)
	from proMovCierreRecursos Where
	proMovCierreRecursos.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden),0) as Recursos

from proMovCierreOrden INNER JOIN conAsientos ON 
proMovCierreOrden.proMovCierreOrden = conAsientos.conAsientos
Where
	proMovCierreOrden.proMovCierreOrden =  @proMovCierreOrden and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1


Select  proMovCierreOrden.proMovCierreOrden, 
	stkMoviCuerpo.stkMoviCabe, 	stkMoviCuerpo.Renglon,
stkProductos.Producto_Id, proOrdenStockCosto.PorcentajeCosto, 
	stkMoviCuerpo.Cantidad, stkMoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario as CostoTotal
from 
proMovCierreOrden INNER JOIN conAsientos ON 
proMovCierreOrden.proMovCierreOrden = conAsientos.conAsientos
INNER JOIN proOrdenStockCosto ON
proOrdenStockCosto.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden 
INNER JOIN stkMoviCabe ON 
proOrdenStockCosto.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN  stkMoviCuerpo ON
stkMoviCuerpo.stkMoviCabe = proOrdenStockCosto.stkMoviCabe and 
stkMoviCuerpo.Renglon =  proOrdenStockCosto.Renglon 
inner join conAsientos  conAsientoss ON 
conAsientoss.conAsientos = stkMoviCabe.stkMoviCabe
INNER JOIN stkProductos ON 
stkProductos.stkProductos = stkmovicuerpo.Producto_Id
Where
	proMovCierreOrden.proMovCierreOrden =  @proMovCierreOrden and
	conAsientoss.Anulado = 0 and 
	conAsientoss.Posteado = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GO
	
