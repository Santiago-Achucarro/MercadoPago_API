
-- Inf_proCostosPorOrden 'PORD', '0001',' ',' ',' ',8,0,0,0,1
drop Procedure Inf_proCostosPorOrden
go
CREATE Procedure Inf_proCostosPorOrden
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
	@Empresa_Id Int
)

AS

SELECT 
	dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		1 as Tipo, 
		stkProductos.Producto_Id ProductoOP, stkProductos.Descripcion AS DescripcionProductoOP,
		conAsientos.Fecha,
		dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante,
		stkProductosc.Producto_Id, stkProductosc.Descripcion ,
		case when stkMoviCabe.Signo = 1 then stkMoviCuerpo.Cantidad else 0 end Entrada,
		case when stkMoviCabe.Signo = -1 then stkMoviCuerpo.Cantidad else 0 end Salida,
		stkUniMedC.Medida_Id, 
		stkMoviCuerpo.CostoUnitario , 
		Convert(Numeric(18,2),case when stkMoviCabe.Signo = 1 then  stkMoviCuerpo.CostoUnitario*stkMoviCuerpo.Cantidad else 0 end) as CostoEntrada,
		Convert(Numeric(18,2),case when stkMoviCabe.Signo = -1 then  stkMoviCuerpo.CostoUnitario*stkMoviCuerpo.Cantidad else 0 end) as CostoSalida
from proOrden INNER JOIN proOrdenSegmento ON 
proOrden.proOrden = proOrdenSegmento.proOrden
INNER JOIN stkProductos ON 
proOrden.Producto_Id =  stkProductos.stkProductos
INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed = stkProductos.Medida_Id
INNER JOIN proMovCierreOrden ON 
proMovCierreOrden.proOrden = proOrden.proOrden
inner join proOrdenStock on 
proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
inner join stkMoviCabe ON
stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
inner join stkMoviCuerpo ON
stkMoviCuerpo.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN conAsientos ON 
stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
inner join stkProductos stkProductosc ON 
stkProductosC.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed stkUniMedC ON
stkUniMedC.stkUniMed = stkProductosC.Medida_Id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = proOrdenSegmento.Segmento_Id
WHERE
	conAsientos.Empresa_Id =@Empresa_Id and 
	genSegmentos.Segmento_Id = @Segmento_Id and
	proOrdenSegmento.Segmento1C = @Segmento1C and 
	proOrdenSegmento.Segmento2C = @Segmento2C and 
	proOrdenSegmento.Segmento3C = @Segmento3C and 
	proOrdenSegmento.Segmento4C = @Segmento4C and 
	proOrdenSegmento.Segmento1N = @Segmento1N AND
	proOrdenSegmento.Segmento2N  = @Segmento2N and
	proOrdenSegmento.Segmento3N  = @Segmento3N and
	proOrdenSegmento.Segmento4N  = @Segmento4N and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 
UNION ALL -- TRABAJOS DE 3
SELECT 
	dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		2 as Tipo, 
		stkProductos.Producto_Id ProductoOP, stkProductos.Descripcion AS DescripcionProductoOP,
		conAsientos.Fecha,
		dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante,
		proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion ,
		0 Entrada,
		proMovCierreTrabajos3.Cantidad Salida,
		' ' Medida_Id, 
		proMovCierreTrabajos3.Precio , 
		0 as CostoEntrada,
		Convert(Numeric(18,2),proMovCierreTrabajos3.Precio *proMovCierreTrabajos3.Cantidad ) as CostoSalida
from proOrden INNER JOIN proOrdenSegmento ON 
proOrden.proOrden = proOrdenSegmento.proOrden
INNER JOIN stkProductos ON 
proOrden.Producto_Id =  stkProductos.stkProductos
INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed = stkProductos.Medida_Id
INNER JOIN proMovCierreOrden ON 
proMovCierreOrden.proOrden = proOrden.proOrden
inner join proMovCierreTrabajos3 on 
proMovCierreTrabajos3.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN conAsientos ON 
proMovCierreOrden.proMovCierreOrden = conAsientos.conAsientos
inner join proTrabajo3 ON 
proTrabajo3.proTrabajo3 = proMovCierreTrabajos3.Trabajo3_Id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = proOrdenSegmento.Segmento_Id
WHERE
	conAsientos.Empresa_Id =@Empresa_Id and 
	genSegmentos.Segmento_Id = @Segmento_Id and
	proOrdenSegmento.Segmento1C = @Segmento1C and 
	proOrdenSegmento.Segmento2C = @Segmento2C and 
	proOrdenSegmento.Segmento3C = @Segmento3C and 
	proOrdenSegmento.Segmento4C = @Segmento4C and 
	proOrdenSegmento.Segmento1N = @Segmento1N AND
	proOrdenSegmento.Segmento2N  = @Segmento2N and
	proOrdenSegmento.Segmento3N  = @Segmento3N and
	proOrdenSegmento.Segmento4N  = @Segmento4N and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 
UNION ALL -- Recursos
SELECT 
	dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		3 as Tipo, 
		stkProductos.Producto_Id ProductoOP, stkProductos.Descripcion AS DescripcionProductoOP,
		conAsientos.Fecha,
		dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante,
		proRecursos.Recurso_Id, proRecursos.Descripcion ,
		0 Entrada,
		proMovCierreRecursos.Cantidad Salida,
		' ' Medida_Id, 
		proMovCierreRecursos.Costo , 
		0 as CostoEntrada,
		Convert(Numeric(18,2),proMovCierreRecursos.Costo *proMovCierreRecursos.Cantidad ) as CostoSalida
from proOrden INNER JOIN proOrdenSegmento ON 
proOrden.proOrden = proOrdenSegmento.proOrden
INNER JOIN stkProductos ON 
proOrden.Producto_Id =  stkProductos.stkProductos
INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed = stkProductos.Medida_Id
INNER JOIN proMovCierreOrden ON 
proMovCierreOrden.proOrden = proOrden.proOrden
inner join proMovCierreRecursos on 
proMovCierreRecursos.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN conAsientos ON 
proMovCierreOrden.proMovCierreOrden = conAsientos.conAsientos
inner join proRecursos ON 
proRecursos.proRecursos = proMovCierreRecursos.Recurso_Id
INNER JOIN genAsiSegmentos ON 
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = proOrdenSegmento.Segmento_Id
WHERE
	conAsientos.Empresa_Id =@Empresa_Id and 
	genSegmentos.Segmento_Id = @Segmento_Id and
	proOrdenSegmento.Segmento1C = @Segmento1C and 
	proOrdenSegmento.Segmento2C = @Segmento2C and 
	proOrdenSegmento.Segmento3C = @Segmento3C and 
	proOrdenSegmento.Segmento4C = @Segmento4C and 
	proOrdenSegmento.Segmento1N = @Segmento1N AND
	proOrdenSegmento.Segmento2N  = @Segmento2N and
	proOrdenSegmento.Segmento3N  = @Segmento3N and
	proOrdenSegmento.Segmento4N  = @Segmento4N and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 

	ORDER BY 1,2,3
GO


