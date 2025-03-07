DROP PROCEDURE inf_comFactProvMenores
GO

CREATE PROCEDURE inf_comFactProvMenores 
(
@Empresa int,
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@ProveedDesde VarChar(15),
@ProveedHasta VarChar(15))
AS
SELECT conAsientos.Fecha, comProveedores.Proveed_Id, 
comProveedores.RazonSocial,
dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento3N) Comp, comMovProv.Importe,
dbo.Segmento(genAsiSeg.Segmento_Id,genAsiSeg.Segmento1C,
genAsiSeg.Segmento2C,genAsiSeg.Segmento3C,
genAsiSeg.Segmento4C,genAsiSeg.Segmento1N,
genAsiSeg.Segmento2N,genAsiSeg.Segmento3N,
genAsiSeg.Segmento3N) OP
FROM comMovProv 
INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
INNER JOIN tesRengMoviComMovProv ON comMovProv.comMovProv = tesRengMoviComMovProv.comMovProv
INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id AND conAsientos.Empresa_Id = genAsiSegmentos.Empresa_Id
INNER JOIN tesMovimientos ON tesRengMoviComMovProv.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN conAsientos conAsi ON tesMovimientos.tesMovimientos = conAsi.conAsientos
INNER JOIN genAsiSegmentos genAsiSeg ON conAsi.conAsientos = genAsiSeg.Asiento_Id AND conAsi.Empresa_Id = genAsiSeg.Empresa_Id
WHERE 
conAsientos.Anulado = 0 AND 
conAsientos.Empresa_Id = @Empresa AND
conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta  AND
comProveedores.Proveed_Id BETWEEN @ProveedDesde AND @ProveedHasta
Order by conAsientos.Fecha, comProveedores.Proveed_Id
GO


