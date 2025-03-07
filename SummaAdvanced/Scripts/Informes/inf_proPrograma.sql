-- EXEC inf_proPrograma 'PROG',' ',' ',' ',' ',1,0,0,0,1
DROP PROCEDURE inf_proPrograma
GO

CREATE PROCEDURE inf_proPrograma
(
	@Segmento_Id VarChar(10), 
	@Segmento1C VarChar(25),
	@Segmento2C VarChar(25),
	@Segmento3C VarChar(25),
	@Segmento4C VarChar(25),
	@Segmento1N INT,
	@Segmento2N INT,
	@Segmento3N INT,
	@Segmento4N INT,
	@Empresa_Id INT

)

AS

SELECT dbo.Segmento(proProgramasSegmento.Segmento_Id,
		proProgramasSegmento.Segmento1C, proProgramasSegmento.Segmento2C,
		proProgramasSegmento.Segmento3C, proProgramasSegmento.Segmento4C,
		proProgramasSegmento.Segmento1N, proProgramasSegmento.Segmento2N,
		proProgramasSegmento.Segmento3N, proProgramasSegmento.Segmento4N) as Programa,
		proProgramasCuerpo.FechaNecesidad, 
		stkProductos.Producto_Id, stkProductos.Descripcion, 
		proProgramasCuerpo.Cantidad, 	proProgramasCuerpo.Confirmado, 
		genSegmentos.Segmento_Id
from proProgramas INNER JOIN proProgramasSegmento ON
proProgramas.proProgramas = proProgramasSegmento.proProgramas
INNER JOIN proProgramasCuerpo ON
proProgramasCuerpo.proProgramas = proProgramas.proProgramas 
INNER JOIN stkProductos ON
stkProductos.stkProductos = proProgramasCuerpo.Producto_Id
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = proProgramasSegmento.Segmento_Id
WHERE
	genSegmentos.Segmento_Id = @Segmento_Id AND
	proProgramasSegmento.Segmento1C = @Segmento1C AND
	proProgramasSegmento.Segmento2C = @Segmento2C AND
	proProgramasSegmento.Segmento3C = @Segmento3C AND
	proProgramasSegmento.Segmento4C = @Segmento4C AND
	proProgramasSegmento.Segmento1N = @Segmento1N AND
	proProgramasSegmento.Segmento2N = @Segmento2N AND
	proProgramasSegmento.Segmento3N = @Segmento3N AND
	proProgramasSegmento.Segmento4N = @Segmento4N AND
	proProgramasSegmento.Empresa_Id = @Empresa_Id
ORDER BY 2, 3	

GO
