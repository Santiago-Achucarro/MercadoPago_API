-- EXEC  Inf_proTrabajosProv ' ','ZZZZ',' ','zzz', '20190801','20190831',1
DROP PROCEDURE Inf_proTrabajosProv
GO
CREATE PROCEDURE Inf_proTrabajosProv
(
	@ProveedorDesde VarChar(25),
	@ProveedorHasta VarChar(25),
	@Trabajo3Desde VarChar(25),
	@Trabajo3Hasta VarChar(25),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id INT
)

AS


SELECT ISNULL(comProveedores.Proveed_Id, ' ') AS Proveed_Id, 
	ISNULL(comProveedores.RazonSocial, 'NO_Asignado') as RazonSocial,
	proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion as DescripcionT2,
dbo.Segmento(proOrdenSegmento.Segmento_Id, 
		proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C,
		proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
		proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N,
		proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) as Orden,

		stkProductos.Producto_Id, stkProductos.Descripcion,
		proOrdenTrabajos3.Renglon , proOrden.Cantidad,
		proOrden.CantidadTerminada

from proOrdenTrabajos3 
INNER JOIN proOrden ON
proOrden.proOrden = proOrdenTrabajos3.proOrden
INNER JOIN proOrdenSegmento ON
proOrdenSegmento.proOrden = proOrden.proOrden
INNER JOIN stkProductos ON
stkProductos.stkProductos = proOrden.Producto_Id 
INNER JOIN proTrabajo3 ON
proTrabajo3.proTrabajo3 = proOrdenTrabajos3.proTrabajo3
LEFT JOIN comProveedores ON 
comProveedores.genEntidades = proOrdenTrabajos3.Proveed_Id
WHERE
	proTrabajo3.Trabajo3_Id BETWEEN @Trabajo3Desde AND @Trabajo3Hasta and 
	proOrden.FechaNecesidad BETWEEN @FechaDesde AND @FechaHasta and
	proOrdenSegmento.Empresa_Id = @Empresa_Id
ORDER BY 1, 3, 5
GO

