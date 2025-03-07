-- comOrdenCompDatosCons 1, 'OC', 124,0,0,0,'0001',' ',' ',' '
DROP PROCEDURE comOrdenCompDatosCons
GO
CREATE PROCEDURE comOrdenCompDatosCons
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)
AS

DECLARE @lComOrdenComp as Int
SET @lComOrdenComp = (SELECT comOrdenComp 
	FROM comOCSegmentos WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C))

Exec comOrdenCompDatos @pEmpresa_Id, @pSegmento_Id, @pSegmento1N, @pSegmento2N, @pSegmento3N, @pSegmento4N, @pSegmento1C, @pSegmento2C, @pSegmento3C, @pSegmento4C

-- Para mostrar las cantidad recibidas/facturadas por renglón --
Select '' Producto_Id, '' Descripcion, '' Medida_Id, Cast(0 As numeric(19,8)) CantidadPedida, Cast(0 As numeric(19,8)) CantidadRecibida,
	Cast(0 As numeric(19,8)) CantidadPendRec, Cast(0 As numeric(19,8)) CantidadFacturada, Cast(0 As numeric(19,8)) CantidadPendFac, 
		Cast(0 As numeric(19,8)) CantidadConsignada

-- Para mostrar una grilla de las recepciones por renglón --
Select getDate() Fecha, '' Recepcion, '' Medida_Id, Cast(0 As numeric(19,8)) Cantidad, '' Deposito_Id, '' Observacion

-- Para mostrar una grilla de las facturas recibidas por renglón --
Select getDate() Fecha, '' Comprobante, '' Medida_Id, Cast(0 As numeric(19,8)) Cantidad

-- Para mostrar una grilla con todas las recepciones de la OC --
SELECT DISTINCT conAsientos.conAsientos, conAsientos.Fecha, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Recepcion, comOCMemo.Detalle, 
comOcReceCuerpo.Cantidad, ' ' Remito 
From comOcReceCuerpo
INNER JOIN comOCMemo ON comOcReceCuerpo.comOrdenComp = comOCMemo.comOrdenComp AND
	comOcReceCuerpo.Renglon_OC = comOCMemo.Renglon_OC
Inner Join conAsientos On conAsientos.conAsientos = comOcReceCuerpo.comOcRecepcion
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Where comOcReceCuerpo.comOrdenComp = @lComOrdenComp
UNION ALL
SELECT DISTINCT conAsientos.conAsientos, conAsientos.Fecha, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Recepcion, stkProductos.Producto_Id,
stkMoviCuerpo.Cantidad, ISNULL(stkMoviProv.RemitoProv,ISNULL(stkMoviEmbarque.RemitoProv,'')) Remito
From stkMoviOC
INNER JOIN stkMoviCuerpo ON stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND
	stkMoviOC.Renglon = stkMoviCuerpo.Renglon
LEFT JOIN stkMoviProv ON stkMoviOC.stkMoviCabe = stkMoviProv.stkMoviCabe
LEFT JOIN stkMoviEmbarque ON  stkMoviOC.stkMoviCabe = stkMoviEmbarque.stkMoviCabe
INNER JOIN stkProductos ON stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
Inner Join conAsientos On conAsientos.conAsientos = stkMoviOC.stkMoviCabe
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Where stkMoviOC.comOrdenComp = @lComOrdenComp And conAsientos.Posteado = 1 And conAsientos.Anulado = 0


-- Para mostrar una grilla con todas las facturas de la OC --
SELECT DISTINCT conAsientos.conAsientos, conAsientos.Fecha, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante, comMovProv.Saldo,
comMovProv.Importe
FROM (SELECT DISTINCT comMovPOC.comOrdenComp, comMovPOC.comMovProv 
FROM comMovPOC 
UNION ALL
SELECT comOcMovProv.comOrdenComp, comOcMovProv.comMovProv 
FROM comOcMovProv) comMov 
INNER JOIN comMovProv ON comMov.comMovProv = comMovProv.comMovProv
INNER JOIN conAsientos ON conAsientos.conAsientos = comMov.comMovProv
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
WHERE comMov.comOrdenComp = @lComOrdenComp And conAsientos.Posteado = 1 And conAsientos.Anulado = 0

select comocRI.Renglon_OC,
genSegmentos.Segmento_Id, comRISegmento.Segmento1N, comRISegmento.Segmento2N, comRISegmento.Segmento3N, comRISegmento.Segmento4N, comRISegmento.Segmento1C, comRISegmento.Segmento2C, comRISegmento.Segmento3C,
comRISegmento.Segmento4C, 
	dbo.Segmento(comRISegmento.Segmento_Id, comRISegmento.Segmento1C, Segmento2C, Segmento3C, Segmento4C, Segmento1N, Segmento2N, Segmento3N, Segmento4N) as SegmentoSTR 
from comOCRI
inner join comRISegmento on comRISegmento.comReqInterno=comOCRI.comReqInterno
inner join genSegmentos on genSegmentos.genSegmentos=comRISegmento.Segmento_Id
where comOCRI.comOrdenComp=@lComOrdenComp
order by 1
RETURN @@Error 
