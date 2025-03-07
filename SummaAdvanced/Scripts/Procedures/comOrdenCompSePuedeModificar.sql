
DROP PROCEDURE comOrdenCompSePuedeModificar
GO

CREATE PROCEDURE comOrdenCompSePuedeModificar(

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

select 'Tiene_Facturas' as Mensaje
from comOrdenComp 
INNER JOIN comOCSegmentos ON comOrdenComp.comOrdenComp =comOCSegmentos.comOrdenComp
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
where
(exists(SELECT 1 FROM comMovpoc WHERE comMovpoc.comOrdenComp = comOrdenComp.comOrdenComp) or
exists(SELECT 1 FROM comOCMovProv WHERE comOCMovProv.comOrdenComp = comOrdenComp.comOrdenComp) ) and 
genSegmentos.Segmento_Id = @pSegmento_Id and 
comOCSegmentos.Segmento1N = @pSegmento1N AND 
comOCSegmentos.Segmento2N = @pSegmento2N AND 
comOCSegmentos.Segmento3N = @pSegmento3N AND 
comOCSegmentos.Segmento4N = @pSegmento4N AND 
comOCSegmentos.Segmento1C = @pSegmento1C AND 
comOCSegmentos.Segmento2C = @pSegmento2C AND 
comOCSegmentos.Segmento3C = @pSegmento3C AND 
comOCSegmentos.Segmento4C = @pSegmento4C AND 
comOCSegmentos.Empresa_Id = @pEmpresa_Id
UNION ALL
select 'Tiene_Entregas' as Mensaje
from comOrdenComp 
INNER JOIN comOCSegmentos ON comOrdenComp.comOrdenComp =comOCSegmentos.comOrdenComp
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
where
exists(SELECT 1 FROM stkMoviOC WHERE stkMoviOC.comOrdenComp = comOrdenComp.comOrdenComp) and 
genSegmentos.Segmento_Id = @pSegmento_Id and 
comOCSegmentos.Segmento1N = @pSegmento1N AND 
comOCSegmentos.Segmento2N = @pSegmento2N AND 
comOCSegmentos.Segmento3N = @pSegmento3N AND 
comOCSegmentos.Segmento4N = @pSegmento4N AND 
comOCSegmentos.Segmento1C = @pSegmento1C AND 
comOCSegmentos.Segmento2C = @pSegmento2C AND 
comOCSegmentos.Segmento3C = @pSegmento3C AND 
comOCSegmentos.Segmento4C = @pSegmento4C AND 
comOCSegmentos.Empresa_Id = @pEmpresa_Id
UNION ALL
select 'Es_Por_Requerimiento_Interno' as Mensaje
from comOrdenComp 
INNER JOIN comOCSegmentos ON comOrdenComp.comOrdenComp =comOCSegmentos.comOrdenComp
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
where
exists(SELECT 1 FROM comOCRi WHERE comOCRi.comOrdenComp = comOrdenComp.comOrdenComp) and 
genSegmentos.Segmento_Id = @pSegmento_Id and 
comOCSegmentos.Segmento1N = @pSegmento1N AND 
comOCSegmentos.Segmento2N = @pSegmento2N AND 
comOCSegmentos.Segmento3N = @pSegmento3N AND 
comOCSegmentos.Segmento4N = @pSegmento4N AND 
comOCSegmentos.Segmento1C = @pSegmento1C AND 
comOCSegmentos.Segmento2C = @pSegmento2C AND 
comOCSegmentos.Segmento3C = @pSegmento3C AND 
comOCSegmentos.Segmento4C = @pSegmento4C AND 
comOCSegmentos.Empresa_Id = @pEmpresa_Id
GO


