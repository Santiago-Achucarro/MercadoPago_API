-- INF_StkRankConsumo '20170601','20170831', ' ','ZZZ', ' ','ZZZ', 1
DROP PROCEDURE INF_StkRankConsumo
GO
CREATE PROCEDURE INF_StkRankConsumo (
@FechaDesde DateTime,
@FechaHasta DateTime,
@ProductoDesde VarChar(25),
@ProductoHasta VarChar(25),
@DepositoDesde VarChar(5),
@DepositoHasta VarChar(5),
@Empresa Int)

AS
	SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
			stkProductos.Medida_id,
			SUM(stkMoviCuerpo.Cantidad) as Cantidad,
			ISNULL(UniAlt.Medida_id,'') MedidaAlt,
			SUM(ISNULL(stkMoviCuerpo.CantidadAlternaForm,0)) as CantidadAlt
			FROM stkMoviCabe INNER JOIN stkMoviCuerpo ON 
			stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
			INNER JOIN conAsientos ON
			conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
			INNER JOIN stkDepositos ON
			stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
			INNER JOIN stkSubTipoMov ON
			stkSubTipoMov.SubTipomov_id = stkMoviCabe.SubTipoMov_id
			INNER JOIN stkProductos ON
			stkProductos.stkProductos = stkMoviCuerpo.Producto_id
			INNER JOIN stkUniMed ON
			stkUniMed.stkUniMed = stkProductos.Medida_id
			LEFT JOIN stkUniMed UniAlt ON
			UniAlt.stkUniMed = stkProductos.MedidaAlterna
			WHERE
			conAsientos.Anulado = 0 and 
			stkSubTipoMov.Consumo = 1 and
			stkMoviCabe.Signo = -1 and 
			stkProductos.Producto_Id between @ProductoDesde and  @ProductoHasta and 
			conAsientos.Fecha between @FechaDesde And @FechaHasta and 
			conAsientos.Empresa_Id = @Empresa and 
			stkDepositos.Deposito_Id BETWEEN @DepositoDesde and @DepositoHasta
			GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion, 
			stkProductos.Medida_id, UniAlt.Medida_id
			ORDER BY 3 Desc
GO



