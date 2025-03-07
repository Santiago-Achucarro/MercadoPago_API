DROP PROCEDURE genTiposCompAfipDatos
GO
CREATE PROCEDURE genTiposCompAfipDatos
(
@pComprobante_Id int
)
AS
SET NOCOUNT ON 

SELECT genTiposCompAfip.Comprobante_Id, genTiposCompAfip.Descripcion, genTiposCompAfip.Segmento1N, genTiposCompAfip.Segmento2N, 
genTiposCompAfip.Segmento3N, genTiposCompAfip.Segmento4N, genTiposCompAfip.Segmento1C, genTiposCompAfip.Segmento2C, 
genTiposCompAfip.Segmento3C, genTiposCompAfip.Segmento4C
FROM genTiposCompAfip 
WHERE (Comprobante_Id = @pComprobante_Id)
 
 RETURN @@Error 

GO