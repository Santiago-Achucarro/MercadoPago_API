
--  INF_stkTraspasosPend 1
DROP PROCEDURE INF_stkTraspasosPend
GO
CREATE PROCEDURE INF_stkTraspasosPend
(
	@Empresa int
)

AS

SELECT conAsientos.Fecha,stkMoviCabe.stkMoviCabe, 
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N)  as Segmento, 
	stkDepositosD.Deposito_Id as DepositoDestino, stkDepositosD.Descripcion  as DescripcionDepoDestino,
	ISNULL(conAsientos.Observaciones,' ') AS Observaciones, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 
	stkUniMed.Medida_Id, stkMoviCuerpo.Cantidad as Cantidad, 
	stkMoviCuerpo.CostoUnitario, 
	stkDepositos.Deposito_Id as Deposito, stkDepositos.Descripcion  as DescripcionDepo,
	Convert(numeric(18,2), stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario ) as Monto 
FROM stkEnTransito inner join stkMoviCabe ON
	stkEnTransito.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN conAsientos ON
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos 
	INNER JOIn genAsiSegmentos ON 
	conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	inner join stkDepositos  ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	inner join stkDepositos  as stkDepositosD ON
	stkDepositosD.stkDepositos = stkEnTransito.Deposito_Id
	WHERE
	conAsientos.Anulado = 0 and 
	genAsiSegmentos.Empresa_Id = @Empresa and
	stkEnTransito.stkMoviCabeEntr IS NULL
ORDER BY 1, 3, 2
