--comMovProvDatosPorDifPrecio 1, 'PROV', 0,0,0,0,' ',' ',' ',' '

DROP PROCEDURE comMovProvDatosPorDifPrecio
GO

CREATE PROCEDURE comMovProvDatosPorDifPrecio
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)

)
AS
SET NOCOUNT ON 
Declare @pidentity bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec comMovprovDatos @pidentity


SELECT comMovProvDPreFactDir.comMovProv, comMovProvDPreFactDir.Renglon, 
	comMovProvDPreFactDir.RenglonStk as RenglonOrig,
	genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr ,
	comMovProvDPreFactDir.CantidadOriginal as CantidadForm, comMovProvDPreFactDir.Cantidad, 
	comMovProvDPreFactDir.Descuento, comMovProvDPreFactDir.Monto, 
	comMovProvDPreFactDir.Monto *comMovProvDPreFactDir.CantidadOriginal as Total, 
	0 as ComordenComp, comMovProvDPreFactDir.stkMoviCabe as MovimientoOrig, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkMoviCuerpo.CantidadForm as CantidadOriginal, stkUniMed.Medida_Id, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.PrecioOriginal 
FROM comMovProvDPreFactDir INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = comMovProvDPreFactDir.stkMoviCabe
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN stkMoviCuerpo ON 
stkMoviCuerpo.stkMoviCabe = comMovProvDPreFactDir.stkMoviCabe AND 
stkMoviCuerpo.Renglon = comMovProvDPreFactDir.RenglonStk
INNER JOIN stkProductos ON
stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
Where 
	comMovProvDPreFactDir.comMovProv = @pidentity

UNION ALL
SELECT comMovProvDPreOC.comMovProv, comMovProvDPreOC.Renglon, 
	comMovProvDPreOC.Renglon_OC,
	genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr ,
	comMovProvDPreOC.CantidadOriginal as CantidadForm, comMovProvDPreOC.Cantidad, 
	comMovProvDPreOC.Descuento, comMovProvDPreOC.Monto, 
	comMovProvDPreOC.Monto *comMovProvDPreOC.CantidadOriginal as Total, 
	comMovProvDPreOC.comOrdenComp, comMovProvDPreOC.comMovProvFactOrig as MovimientoOrig, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	comMovPOC.Cantidad , stkUniMed.Medida_Id, 
	comMovpOC.Factor, comOCArticulo.PrecioOriginal

FROM comMovProvDPreOC INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = comMovProvDPreOC.comMovProvFactOrig
INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN comOCArticulo ON
comOCArticulo.comOrdenComp = comMovProvDPreOC.comOrdenComp and 
comOCArticulo.Renglon_OC =comMovProvDPreOC.Renglon_OC
INNER JOIN comOCCuerpo ON
comOCCuerpo.comOrdenComp = comMovProvDPreOC.comOrdenComp and 
comOCCuerpo.Renglon_OC =comMovProvDPreOC.Renglon_OC
INNER JOIN comMovpOC ON 
comMovpOC.comMovProv = comMovProvDPreOC.comMovProvFactOrig AND 
comMovpOC.comOrdenComp = comMovProvDPreOC.comOrdenComp AND 
comMovpOC.Renglon_OC = comMovProvDPreOC.Renglon_OC

INNER JOIN stkProductos ON
stkProductos.stkProductos = comOCArticulo.Producto_Id
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
Where 
	comMovProvDPreOC.comMovProv = @pidentity
ORDER BY 2


exec comMovImpuestosDatos @pidentity, null
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comMovProv' 
Exec genMovCuotasDatos @pidentity, null


RETURN @@Error 

GO

DROP PROCEDURE comMovprovFactDifPrecRengDatos 
GO
CREATE PROCEDURE comMovprovFactDifPrecRengDatos 
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pProducto_Id VarChar(25)
)
AS


SELECT  
	stkMoviCuerpo.Renglon as RenglonOrig,
	genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr ,
	0 as ComordenComp, genAsiSegmentos.Asiento_Id as MovimientoOrig, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkMoviCuerpo.CantidadForm as CantidadOriginal, stkUniMed.Medida_Id, 
	stkMoviCuerpo.Factor, stkMoviCuerpo.PrecioOriginal
FROM genAsiSegmentos INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN stkMoviCuerpo ON 
stkMoviCuerpo.stkMoviCabe = genAsiSegmentos.Asiento_Id
INNER JOIN stkProductos ON
stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
Where 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and
	genAsiSegmentos.Segmento2C = @pSegmento2C and
	genAsiSegmentos.Segmento3C = @pSegmento3C and
	genAsiSegmentos.Segmento4C = @pSegmento4C and
	genAsiSegmentos.Segmento1N = @pSegmento1N and
	genAsiSegmentos.Segmento2N = @pSegmento2N and
	genAsiSegmentos.Segmento3N = @pSegmento3N and
	genAsiSegmentos.Segmento4N = @pSegmento4N and
	stkProductos.Producto_Id = @pProducto_Id


UNION ALL
SELECT comMovPOC.Renglon_OC,
	genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr ,
	comMovPOC.comOrdenComp, comMovPOC.comMovProv as MovimientoOrig, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	comMovPOC.Cantidad , stkUniMed.Medida_Id, 
	comMovpOC.Factor, comOCArticulo.PrecioOriginal

FROM genAsiSegmentos INNER JOIN genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN comMovpOC ON 
comMovpOC.comMovProv = genAsiSegmentos.Asiento_Id 
INNER JOIN comOCArticulo ON
comMovpOC.comOrdenComp = comOCArticulo.comOrdenComp AND 
comMovpOC.Renglon_OC = comOCArticulo.Renglon_OC
INNER JOIN comOCCuerpo ON
comOCCuerpo.comOrdenComp = comOCArticulo.comOrdenComp and 
comOCCuerpo.Renglon_OC =comOCArticulo.Renglon_OC
INNER JOIN stkProductos ON
stkProductos.stkProductos = comOCArticulo.Producto_Id
INNER JOIN stkUniMed ON
stkUniMed.stkUniMed = comOCCuerpo.Medida_Id
Where 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and
	genAsiSegmentos.Segmento2C = @pSegmento2C and
	genAsiSegmentos.Segmento3C = @pSegmento3C and
	genAsiSegmentos.Segmento4C = @pSegmento4C and
	genAsiSegmentos.Segmento1N = @pSegmento1N and
	genAsiSegmentos.Segmento2N = @pSegmento2N and
	genAsiSegmentos.Segmento3N = @pSegmento3N and
	genAsiSegmentos.Segmento4N = @pSegmento4N and
	stkProductos.Producto_Id = @pProducto_Id

GO




