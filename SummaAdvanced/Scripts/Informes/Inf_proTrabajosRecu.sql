-- EXEC  Inf_proTrabajosRecu ' ','ZZZZ','20190801','20190831',1
DROP PROCEDURE Inf_proTrabajosRecu
GO
CREATE PROCEDURE Inf_proTrabajosRecu
(
	@RecursoDesde VarChar(25),
	@RecursoHasta VarChar(25),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id INT
)

AS


SELECT proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecurso, 
dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		'  ' as SubRecurso_Id, ' ' as DescripcionSubRecurso, 
		proOrdenRecursos.Renglon , 	proOrdenRecursos.Cantidad, 
		stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProd

from proRecursos INNER JOIN proOrdenRecursos ON
proRecursos.proRecursos = proOrdenRecursos.Recurso_Id
INNER JOIN proOrden ON
proOrden.proOrden = proOrdenRecursos.proOrden
INNER JOIN proOrdenSegmento ON
proOrdenSegmento.proOrden = proOrden.proOrden
INNER JOIN stkProductos ON
stkProductos.stkProductos = proOrden.Producto_Id
WHERE
	NOT Exists(SELECT 1 FROM proOrdenSubRecurso WHERE
		proOrdenSubRecurso.proOrden = proOrdenRecursos.proOrden and 
		proOrdenSubRecurso.Renglon = proOrdenRecursos.Renglon) and 
	proRecursos.Recurso_Id BETWEEN @RecursoDesde AND @RecursoHasta and 
	proOrden.FechaNecesidad BETWEEN @FechaDesde AND @FechaHasta and
	proOrdenSegmento.Empresa_Id = @Empresa_Id
UNION ALL
SELECT proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecurso, 
dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,
		proSubRecursos.SubRecurso_Id, proSubRecursos.Descripcion as DescripcionSubRecurso, 
		proOrdenRecursos.Renglon , 	proOrdenSubRecurso.Cantidad, 
		stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProd
from proRecursos INNER JOIN proOrdenRecursos ON
proRecursos.proRecursos = proOrdenRecursos.Recurso_Id
INNER JOIN proOrden ON
proOrden.proOrden = proOrdenRecursos.proOrden
INNER JOIN proOrdenSegmento ON
proOrdenSegmento.proOrden = proOrden.proOrden
inner join proOrdenSubRecurso ON
		proOrdenSubRecurso.proOrden = proOrdenRecursos.proOrden and 
		proOrdenSubRecurso.Renglon = proOrdenRecursos.Renglon
INNER JOIN proSubRecursos ON 
		proSubRecursos.proSubRecursos = proOrdenSubRecurso.SubRecurso_Id
INNER JOIN stkProductos ON
stkProductos.stkProductos = proOrden.Producto_Id

Where
	proRecursos.Recurso_Id BETWEEN @RecursoDesde AND @RecursoHasta and 
	proOrden.FechaNecesidad BETWEEN @FechaDesde AND @FechaHasta and
	proOrdenSegmento.Empresa_Id = @Empresa_Id
ORDER BY 1, 3, 4
GO

