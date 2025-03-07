--EXEC Inf_proOrdenCierre 'CPRO',2,0,0,0,'0001','','','',1
--EXEC Inf_proOrdenCierreProd 'CPRO',2,0,0,0,'0001','','','',1
--EXEC Inf_proOrdenCierreConsumo 'CPRO',2,0,0,0,'0001','','','',1
--EXEC Inf_proOrdenCierreT3 'CPRO',2,0,0,0,'0001','','','',1
--EXEC Inf_proOrdenCierreRecursos 'CPRO',2,0,0,0,'0001','','','',1


DROP PROCEDURE Inf_proOrdenCierre
GO
CREATE PROCEDURE Inf_proOrdenCierre
(
	@pSegmento_Id varchar(10),
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C varchar(20),
	@pSegmento2C varchar(20),
	@pSegmento3C varchar(20),
	@pSegmento4C varchar(20),
	@pEmpresa_Id int

)
AS
SELECT proMovCierreOrden.proOrden, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C , genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
    genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS SegmentoCierre, conAsientos.Observaciones,
	conAsientos.Fecha FechaFin, proMovCierreOrden.Cantidad as CantCierre, conAsientos.Anulado, 
	CASE WHEN proMovCierreOrden.Parcial = 1 THEN '2' ELSE '1' END  TipoCierre, 
	ISNULL(proCausas.Causa_Id,'') Causa_Id, ISNULL(proCausas.Descripcion,'') DescripcionCausa, 
	proMovCierreOrden.proMovCierreOrden,
	dbo.Segmento(proOrdenSegmento.Segmento_Id, proOrdenSegmento.Segmento1C, 
	proOrdenSegmento.Segmento2C , proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C, 
    proOrdenSegmento.Segmento1N, proOrdenSegmento.Segmento2N, 
	proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) AS SegmentoOP,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, 	
	proRecetas.Receta_Id, 	proRecetas.Descripcion as DescripcionReceta, 
	proOrden.Cantidad, proOrden.CantidadIngresada, 
	proOrden.FechaEmision, proOrden.FechaNecesidad, proOrden.FechaProduccion,
	proOrden.CantidadTerminada, (proOrden.Cantidad - proOrden.CantidadTerminada)/proOrden.Factor as CantPendiente,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, Factor
FROM proMovCierreOrden 
INNER JOIN genAsiSegmentos ON 
proMovCierreOrden.proMovCierreOrden = genAsiSegmentos.Asiento_Id
INNER JOIN conAsientos ON 
conAsientos.conAsientos = proMovCierreOrden.proMovCierreOrden
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
LEFT JOIN proCausas ON proCausas.proCausas = proMovCierreOrden.Causa_Id
INNER JOIN proOrden ON proOrden.proOrden = promovCierreOrden.proOrden
INNER JOIN proOrdenSegmento ON proOrdenSegmento.proOrden = proOrden.proOrden
INNER JOIN stkProductos ON stkProductos = proOrden.Producto_Id
INNER JOIN proRecetas ON proRecetas = proOrden.Receta_Id
INNER JOIN genSegmentos genSegOP ON genSegOP.genSegmentos = proOrdenSegmento.Segmento_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = proOrden.Medida_Id
WHERE 
genSegmentos.Segmento_Id = @pSegmento_Id AND
genAsiSegmentos.Segmento1N = @pSegmento1N AND 
genAsiSegmentos.Segmento2N = @pSegmento2N AND 
genAsiSegmentos.Segmento3N = @pSegmento3N AND 
genAsiSegmentos.Segmento4N = @pSegmento4N AND 
genAsiSegmentos.Segmento1C = @pSegmento1C AND 
genAsiSegmentos.Segmento2C = @pSegmento2C AND 
genAsiSegmentos.Segmento3C = @pSegmento3C AND 
genAsiSegmentos.Segmento4C = @pSegmento4C 
GO


DROP PROCEDURE Inf_proOrdenCierreProd
GO
CREATE PROCEDURE Inf_proOrdenCierreProd
(
	@pSegmento_Id varchar(10),
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C varchar(20),
	@pSegmento2C varchar(20),
	@pSegmento3C varchar(20),
	@pSegmento4C varchar(20),
	@pEmpresa_Id int

)
AS
DECLARE @proMovCierreOrden int

SET @proMovCierreOrden = (SELECT proMovCierreOrden.proMovCierreOrden
	FROM proMovCierreOrden 
	inner join genAsiSegmentos ON proMovCierreOrden.proMovCierreOrden =  genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @pSegmento_Id AND
	genAsiSegmentos.Segmento1N = @pSegmento1N AND 
	genAsiSegmentos.Segmento2N = @pSegmento2N AND 
	genAsiSegmentos.Segmento3N = @pSegmento3N AND 
	genAsiSegmentos.Segmento4N = @pSegmento4N AND 
	genAsiSegmentos.Segmento1C = @pSegmento1C AND 
	genAsiSegmentos.Segmento2C = @pSegmento2C AND 
	genAsiSegmentos.Segmento3C = @pSegmento3C AND 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

SELECT proMovCierreOrden.proOrden, stkMoviCuerpo.Renglon AS Renglon, 
	'P' EntradaSalida, stkUniMed.Medida_Id, stkProductos.Producto_Id, stkProductos.Descripcion,
	proOrdenStockCosto.PorcentajeCosto,	
	ISNULL(stkMoviSerie.Serie,'') Serie, ISNULL(ISNULL(ISNULL(stkMoviSerieUbicacion.Cantidad,stkMoviUbicacion.Cantidad),
	stkMoviSerie.Cantidad),stkMoviCuerpo.Cantidad) Cantidad, 
	ISNULL(ISNULL(stkUbicacionesSerie.Ubicacion_Id,stkUbicaciones.Ubicacion_Id),'') Ubicacion, 
	ISNULL(stkSerieVencimiento.Vencimiento,'') FVencimiento, stkDepositos.Deposito_Id,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C , genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
    genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Movimiento, conAsientos.Fecha
FROM proMovCierreOrden 
INNER JOIN proOrdenStock ON proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN proOrden ON proMovCierreOrden.proOrden = proOrden.proOrden
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUniMed ON  stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN stkMoviCabe on  stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
LEFT JOIN proOrdenStockCosto ON proOrdenStockCosto.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
		proOrdenStockCosto.Renglon = stkMoviCuerpo.Renglon and 
		proOrdenStockCosto.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
LEFT OUTER JOIN stkMoviSerie on stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe and stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
LEFT JOIN stkSerieVencimiento on stkSerieVencimiento.Serie = stkMoviSerie.Serie and stkSerieVencimiento.Producto_Id = stkProductos.stkProductos And
	stkSerieVencimiento.Empresa_Id = @pEmpresa_Id
LEFT JOIN (stkMoviUbicacion INNER JOIN stkUbicaciones ON stkMoviUbicacion.Ubicacion_Id = stkUbicaciones.stkUbicaciones)
	ON stkMoviCabe.stkMoviCabe = stkMoviUbicacion.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviUbicacion.Renglon
LEFT JOIN (stkMoviSerieUbicacion INNER JOIN stkUbicaciones stkUbicacionesSerie ON stkMoviSerieUbicacion.Ubicacion_Id = stkUbicacionesSerie.stkUbicaciones)
	ON stkMoviCabe.stkMoviCabe = stkMoviSerieUbicacion.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerieUbicacion.Renglon AND
	stkMoviSerie.Serie = stkMoviSerieUbicacion.Serie
INNER JOIN genAsiSegmentos ON stkMoviCabe.stkMoviCabe = genAsiSegmentos.Asiento_Id
INNER JOIN conAsientos ON stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
WHERE
	proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden AND 
	stkMoviCabe.Signo = 1
ORDER BY 2,3
GO


DROP PROCEDURE Inf_proOrdenCierreConsumo
GO
CREATE PROCEDURE Inf_proOrdenCierreConsumo
(
	@pSegmento_Id varchar(10),
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C varchar(20),
	@pSegmento2C varchar(20),
	@pSegmento3C varchar(20),
	@pSegmento4C varchar(20),
	@pEmpresa_Id int

)
AS
DECLARE @proMovCierreOrden int

SET @proMovCierreOrden = (SELECT proMovCierreOrden.proMovCierreOrden
	FROM proMovCierreOrden 
	inner join genAsiSegmentos ON proMovCierreOrden.proMovCierreOrden =  genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @pSegmento_Id AND
	genAsiSegmentos.Segmento1N = @pSegmento1N AND 
	genAsiSegmentos.Segmento2N = @pSegmento2N AND 
	genAsiSegmentos.Segmento3N = @pSegmento3N AND 
	genAsiSegmentos.Segmento4N = @pSegmento4N AND 
	genAsiSegmentos.Segmento1C = @pSegmento1C AND 
	genAsiSegmentos.Segmento2C = @pSegmento2C AND 
	genAsiSegmentos.Segmento3C = @pSegmento3C AND 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

SELECT proMovCierreOrden.proOrden, stkMoviCuerpo.Renglon, 'C' EntradaSalida, 
	stkUniMed.Medida_Id, stkProductos.Producto_Id, stkProductos.Descripcion,
	ISNULL(stkMoviSerie.Serie,'') Serie, ISNULL(ISNULL(ISNULL(stkMoviSerieUbicacion.Cantidad,stkMoviUbicacion.Cantidad),
	stkMoviSerie.Cantidad),stkMoviCuerpo.Cantidad) Cantidad, 
	ISNULL(ISNULL(stkUbicacionesSerie.Ubicacion_Id,stkUbicaciones.Ubicacion_Id),'') Ubicacion, 
	ISNULL(stkSerieVencimiento.Vencimiento,'') FVencimiento, stkDepositos.Deposito_Id,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C , genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
    genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Movimiento, conAsientos.Fecha
FROM proMovCierreOrden 
INNER JOIN proOrdenStock ON proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN proOrden ON proMovCierreOrden.proOrden = proOrden.proOrden
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = proOrdenStock.stkMoviCabe
INNER JOIN stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe = proOrdenStock.stkMoviCabe
LEFT OUTER JOIN stkMoviSerie on stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe and stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
LEFT JOIN stkSerieVencimiento on stkSerieVencimiento.Serie = stkMoviSerie.Serie and stkSerieVencimiento.Producto_Id = stkProductos.stkProductos And
	stkSerieVencimiento.Empresa_Id = @pEmpresa_Id
LEFT JOIN (stkMoviUbicacion INNER JOIN stkUbicaciones ON stkMoviUbicacion.Ubicacion_Id = stkUbicaciones.stkUbicaciones)
	ON stkMoviCabe.stkMoviCabe = stkMoviUbicacion.stkMoviCabe and stkMoviCuerpo.Renglon = stkMoviUbicacion.Renglon
LEFT JOIN (stkMoviSerieUbicacion INNER JOIN stkUbicaciones stkUbicacionesSerie ON stkMoviSerieUbicacion.Ubicacion_Id = stkUbicacionesSerie.stkUbicaciones)
	ON stkMoviCabe.stkMoviCabe = stkMoviSerieUbicacion.stkMoviCabe and stkMoviCuerpo.Renglon = stkMoviSerieUbicacion.Renglon AND
	stkMoviSerie.Serie = stkMoviSerieUbicacion.Serie
INNER JOIN genAsiSegmentos ON stkMoviCabe.stkMoviCabe = genAsiSegmentos.Asiento_Id
INNER JOIN conAsientos ON stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
WHERE proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden AND 
	stkMoviCabe.Signo = -1
ORDER BY 3,2
GO



DROP PROCEDURE Inf_proOrdenCierreT3
GO
CREATE PROCEDURE Inf_proOrdenCierreT3
(
	@pSegmento_Id varchar(10),
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C varchar(20),
	@pSegmento2C varchar(20),
	@pSegmento3C varchar(20),
	@pSegmento4C varchar(20),
	@pEmpresa_Id int

)
AS
DECLARE @proMovCierreOrden int

SET @proMovCierreOrden = (SELECT proMovCierreOrden.proMovCierreOrden
	FROM proMovCierreOrden 
	inner join genAsiSegmentos ON proMovCierreOrden.proMovCierreOrden =  genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @pSegmento_Id AND
	genAsiSegmentos.Segmento1N = @pSegmento1N AND 
	genAsiSegmentos.Segmento2N = @pSegmento2N AND 
	genAsiSegmentos.Segmento3N = @pSegmento3N AND 
	genAsiSegmentos.Segmento4N = @pSegmento4N AND 
	genAsiSegmentos.Segmento1C = @pSegmento1C AND 
	genAsiSegmentos.Segmento2C = @pSegmento2C AND 
	genAsiSegmentos.Segmento3C = @pSegmento3C AND 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

SELECT proMovCierreOrden.proOrden, proMovCierreTrabajos3.Renglon, 
	proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	proMovCierreTrabajos3.Cantidad, proMovCierreTrabajos3.PrecioOriginal as Preciouni, 
	genMonedas.Moneda_Id, CASE WHEN proMovCierreTrabajos3.PrecioOriginal != 0 THEN 
		ROUND(proMovCierreTrabajos3.Precio/proMovCierreTrabajos3.PrecioOriginal,4) ELSE 1 END as Cambio
FROM proMovCierreOrden 
INNER JOIN proMovCierreTrabajos3 on proMovCierreTrabajos3.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN proTrabajo3 ON proTrabajo3.proTrabajo3 =  proMovCierreTrabajos3.Trabajo3_Id
INNER JOIN proTrabajo3Prov on proTrabajo3Prov.Trabajo3_Id =  proMovCierreTrabajos3.Trabajo3_Id and 
			proTrabajo3Prov.Proveedor_Id = proMovCierreTrabajos3.Proveed_Id
INNER JOIN comProveedores  on comProveedores.genEntidades =  proMovCierreTrabajos3.Proveed_Id
INNER JOIN genMonedas ON proTrabajo3Prov.Moneda_Id = proMovCierreTrabajos3.Moneda_Id
WHERE
	proMovCierreTrabajos3.proMovCierreOrden = @proMovCierreOrden
ORDER BY 2
GO





DROP PROCEDURE Inf_proOrdenCierreRecursos
GO
CREATE PROCEDURE Inf_proOrdenCierreRecursos
(
	@pSegmento_Id varchar(10),
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C varchar(20),
	@pSegmento2C varchar(20),
	@pSegmento3C varchar(20),
	@pSegmento4C varchar(20),
	@pEmpresa_Id int

)
AS
DECLARE @proMovCierreOrden int

SET @proMovCierreOrden = (SELECT proMovCierreOrden.proMovCierreOrden
	FROM proMovCierreOrden 
	inner join genAsiSegmentos ON proMovCierreOrden.proMovCierreOrden =  genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @pSegmento_Id AND
	genAsiSegmentos.Segmento1N = @pSegmento1N AND 
	genAsiSegmentos.Segmento2N = @pSegmento2N AND 
	genAsiSegmentos.Segmento3N = @pSegmento3N AND 
	genAsiSegmentos.Segmento4N = @pSegmento4N AND 
	genAsiSegmentos.Segmento1C = @pSegmento1C AND 
	genAsiSegmentos.Segmento2C = @pSegmento2C AND 
	genAsiSegmentos.Segmento3C = @pSegmento3C AND 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

SELECT proMovCierreOrden.proOrden, proMovCierreRecursos.Renglon, proRecursos.Recurso_Id, proRecursos.Descripcion,
	ISNULL(proSubRecursos.SubRecurso_Id,'') as SubRecurso_Id, ISNULL(proSubRecursos.Descripcion,'') as DescripcionSubRecurso, 
	Cast(case when proSubRecursos.SubRecurso_Id is null then 0 else  1 end  as bit) as UsaSubRecurso,
	proMovCierreRecursos.Cantidad, proMovCierreRecursos.Costo
From proMovCierreOrden 
INNER JOIN proMovCierreRecursos ON proMovCierreRecursos.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
INNER JOIN proRecursos ON  proRecursos.proRecursos = proMovCierreRecursos.Recurso_Id
LEFT JOIN proSubRecursos ON proSubRecursos.proSubRecursos = proMovCierreRecursos.SubRecurso_Id
WHERE
	proMovCierreOrden.proMovCierreOrden = @proMovCierreOrden
ORDER BY 2
GO
