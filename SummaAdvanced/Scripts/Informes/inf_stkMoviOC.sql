DROP PROCEDURE inf_stkMoviOC
GO
CREATE PROCEDURE inf_stkMoviOC
(
@Empresa_Id int, 
@Segmento_Id VarChar(10), 
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int,
@Segmento1C VarChar(20),
@Segmento2C VarChar(20),
@Segmento3C VarChar(20),
@Segmento4C VarChar(20)
)
AS
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @Empresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@Segmento_id) and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

SELECT dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, 
	comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, 
	comOCSegmentos.Segmento4N) AS SegmentoOC, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial
FROM stkMoviOC inner join comOrdenComp on
stkMoviOC.comOrdenComp =  comOrdenComp.comOrdenComp
INNER JOIN comOCSegmentos ON
comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
inner join comProveedores on
comProveedores.genEntidades = comOrdenComp.Proveed_Id
WHERE (stkMoviOC.stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO