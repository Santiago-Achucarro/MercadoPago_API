-- Inf_comPrevCompras  ' ','ZZZ', '1','20180101','20180531', 1
DROP PROCEDURE Inf_comPrevCompras 
GO
CREATE PROCEDURE Inf_comPrevCompras 
(
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Deposito_Id VarChar(5),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa Int
)
AS

DECLARE @FechaDesde1 DateTime
DECLARE @FechaHasta1 DateTime
SET @FechaDesde1 = DATEADD(yy,-1, @FechaDesde)
SET @FechaHasta1 = DATEADD(yy,-1, @FechaHasta)

SELECT Producto_Id, Descripcion, Stock, Compras, Pedidos, 
	Stock + Compras - Pedidos as StockTotal,
	Consumos ConsumosPeriodo, MismoPerAnioAnt ConsumosAnioAnt,
	Maximo, Minimo, 
	case when Stock + Compras - Pedidos < Minimo then 
		case when Stock + Compras - Pedidos > Maximo
				then Minimo else Maximo end -(Stock + Compras - Pedidos)
			else 0 end NecesidadCompra, 
	case when Stock + Compras - Pedidos > Maximo then 
		(Stock + Compras - Pedidos)-Maximo  else 0 end Exceso 
		

FROM (

select stkProductos.Producto_Id, stkProductos.Descripcion, 
	ISNULL(stkMaxMin.Minimo,0) as Minimo, 
	ISNULL(stkMaxMin.Maximo,0) as Maximo, 
	ISNULL((SELECT sum(-stkMoviCuerpo.Cantidad * stkMoviCabe.Signo) 
		From stkMoviCabe INNER JOIN stkMoviCuerpo ON
		stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
		inner join conAsientos ON
		conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkSubTipoMov ON
		stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
		INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		Where
			stkSubTipoMov.Consumo = 1 and 
			conAsientos.Anulado = 0 and 
			genAsiSegmentos.Empresa_Id = @Empresa AND 
			conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta),0) Consumos,
	ISNULL((SELECT sum(-stkMoviCuerpo.Cantidad * stkMoviCabe.Signo) 
		From stkMoviCabe INNER JOIN stkMoviCuerpo ON
		stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
		stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
		inner join conAsientos ON
		conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
		INNER JOIN stkSubTipoMov ON
		stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
		INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
		Where
			stkSubTipoMov.Consumo = 1 and 
			conAsientos.Anulado = 0 and 
			genAsiSegmentos.Empresa_Id = @Empresa AND 
			conAsientos.Fecha BETWEEN @FechaDesde1 and @FechaHasta1),0) MismoPerAnioAnt,
		ISNULL(stkExistencia.Cantidad,0) as Stock, 
		ISNULL((SELECT sum(comOCCuerpo.Cantidad -
		case when stkDepositos.Consignacion = 1 then 
		comOCCuerpo.CantidadConsignada else comOCCuerpo.Cantidad_Recibida end ) 
		From comOCCuerpo INNER JOIN comOrdenComp ON
		comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp
		INNER JOIN comOCArticulo ON
		comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp AND 
		comOCCuerpo.Renglon_OC = comOCArticulo.Renglon_OC and 
		comOCArticulo.Producto_Id = stkProductos.stkProductos
		INNER JOIN comOCSegmentos ON
		comOCSegmentos.comOrdenComp = comOCCuerpo.comOrdenComp 
		INNER JOIN stkDepositos ON stkDepositos.stkDepositos = comOCArticulo.Deposito_Id
		Where
			comOCSegmentos.Empresa_Id = @Empresa AND 
			comOrdenComp.Estado_Id in ('A','P') AND 
			comOCCuerpo.Cantidad >  case when stkDepositos.Consignacion = 1 then 
			comOCCuerpo.CantidadConsignada else comOCCuerpo.Cantidad_Recibida end  AND 
			comOCCuerpo.Pendiente = 1 ),0) Compras, 
	ISNULL((SELECT sum(venPediCuerpo.CantidadPedida-venPediCuerpo.CantidadRemitida) 
		From venPediCuerpo INNER JOIN venPedidos ON
		venPediCuerpo.venPedidos = venPedidos.venPedidos and 
		venPediCuerpo.Producto_Id = stkProductos.stkProductos
		INNER JOIN venPediSegmentos ON
		venPediSegmentos.venPedidos = venPedidos.venPedidos
		Where
			venPediSegmentos.Empresa_Id = @Empresa AND 
			venPedidos.Estado in ('A','P') AND 
			venPediCuerpo.CantidadPedida> venPediCuerpo.CantidadRemitida and 
			venPediCuerpo.Pendiente = 1 ),0) Pedidos

from stkProductos INNER JOIN stkDepositos ON
stkDepositos.Deposito_Id = @Deposito_id
LEFT JOIN stkMaxMin ON
stkMaxMin.Producto_Id = stkProductos.stkProductos AND 
stkMaxMin.Deposito_Id = stkDepositos.stkDepositos  AND
stkMaxMin.Empresa_Id = @Empresa
LEFT JOIN stkExistencia ON
stkExistencia.Producto_Id = stkProductos.stkProductos AND 
stkExistencia.Deposito_Id = stkDepositos.stkDepositos AND 
stkExistencia.Empresa_Id = @Empresa
Where
	stkProductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta AND 
	stkProductos.Acepta_Compras = 1 and 
	stkProductos.Inactivo = 0 and 
	stkProductos.Posteado = 1 and 
	stkProductos.Clase IN ('E','-')) AS XXX
	
order by 1	