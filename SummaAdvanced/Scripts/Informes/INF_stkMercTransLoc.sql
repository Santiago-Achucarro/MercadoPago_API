-- INF_stkMercTransLoc '20170831',1
DROP PROCEDURE INF_stkMercTransLoc 
GO

CREATE PROCEDURE INF_stkMercTransLoc (
	@FechaHasta DateTime,
	@Empresa int
)

AS



SELECT 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	conAsientos.Fecha, stkMoviCabe.StkMoviCabe,
	stkDepositos.Deposito_Id as Deposito, stkDepositos.Descripcion  as DescripcionDepo,
	stkDepositosD.Deposito_Id as DepositoDestino, stkDepositosD.Descripcion  as DescripcionDepoDestino,
	stkProductos.Producto_Id, stkProductos.Descripcion, stkMoviCuerpo.Cantidad,  stkUniMed.Medida_Id, 
	Convert(Numeric(18,2), stkMoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario) as Monto

FROM
	stkEnTransito INNER JOIN stkMoviCabe ON
	stkEnTransito.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkMoviCuerpo ON 
	stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
	INNER JOIN conAsientos ON
	conAsientos.conAsientos =stkMoviCabe.stkMoviCabe 
	INNER JOIN genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = stkMoviCabe.stkMoviCabe 
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	LEFT OUTER JOIN (stkMoviCabe stkMoviCabeEntr INNER JOIN conAsientos conAsientosEntr ON
		stkMoviCabeEntr.stkMoviCabe =conAsientosEntr.conAsientos) ON
	stkMoviCabeEntr.stkMoviCabe = stkEnTransito.stkMoviCabeEntr and
	conAsientosEntr.Fecha <= @FechaHasta 
	inner join stkDepositos  as stkDepositosD ON
	stkDepositosD.stkDepositos = stkEnTransito.Deposito_Id
	inner join stkDepositos  ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientosEntr.Fecha IS NULL and 
		conAsientos.Empresa_Id = @Empresa and 
		conAsientos.Fecha <= @FechaHasta 
	ORDER BY 1,2,3

go
