DROP PROCEDURE INF_stkInvAjustes
GO
CREATE PROCEDURE INF_stkInvAjustes(
@Empresa Int, 
@Segmento_Id VarChar(10),
@Segmento1N INT,
@Segmento2N INT,
@Segmento3N INT,
@Segmento4N INT,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)

as
SELECT XXX.InventarioSeg, XXX.FechaInventario, XXX.UsuarioRespozable, 
	XXX.Producto_Id, XXX.Descripcion, xxx.Medida_Id, xxx.Cantidad, xxx.Stock, 
		xxx.Cantidad - xxx.Stock as Diferencia

FROM (

select dbo.Segmento(stkInvenSegmentos.Segmento_Id, 
	stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C, 
	stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C,
	stkInvenSegmentos.Segmento1N, stkInvenSegmentos.Segmento2N, 
	stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N) AS InventarioSeg, 
	stkInventarios.FechaInventario, genUsuarios.Apellido_y_Nombres as UsuarioRespozable, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkUniMed.Medida_Id, stkInventCuerpo.Cantidad, 
	ISNULL((SELECT SUM(stkMoviCuerpo.Cantidad*stkMoviCabe.Signo) 
			FROM  stkMoviCuerpo INNER JOIN stkMoviCabe ON
			stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
			INNER JOIN conAsientos ON
			conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
			INNER JOIN genAsiSegmentos ON
			genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
			where
				conAsientos.Fecha <= stkInventarios.FechaInventario and 
				conAsientos.Anulado = 0 and 
				genAsiSegmentos.Empresa_Id = @Empresa and 
				stkMoviCuerpo.Producto_Id = stkProductos.stkProductos and 
				stkMoviCuerpo.Deposito_Id = stkInventarios.Deposito_Id),0) as Stock

 from 
	stkInvenSegmentos inner join stkInventarios ON
	stkInvenSegmentos.stkInventarios = stkInventarios.stkInventarios
	INNER JOIN genUsuarios ON 
	genUsuarios.genUsuarios =stkInventarios.UsuRespo_Id
	INNER JOIN stkInventCuerpo on
	stkInventCuerpo.stkInventarios = stkInventarios.stkInventarios
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = stkInventCuerpo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = stkInvenSegmentos.Segmento_Id
	LEFT JOIN stkUniMed as stkUmAlterna ON
	stkUmAlterna.stkUniMed = stkProductos.Medida_Id
	Where
		genSegmentos.Segmento_Id = @Segmento_id and
		stkInvenSegmentos.Segmento1N = @Segmento1N and
		stkInvenSegmentos.Segmento2N = @Segmento2N and
		stkInvenSegmentos.Segmento3N = @Segmento3N and
		stkInvenSegmentos.Segmento4N = @Segmento4N and
		stkInvenSegmentos.Segmento1C = @Segmento1C and
		stkInvenSegmentos.Segmento2C = @Segmento2C and
		stkInvenSegmentos.Segmento3C = @Segmento3C and
		stkInvenSegmentos.Segmento4C = @Segmento4C and
		stkInvenSegmentos.Empresa_Id = @Empresa) AS XXX
		
order by 4
GO

