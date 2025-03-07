drop procedure inf_stkOrdenComp
go
create procedure inf_stkOrdenComp
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

DECLARE @pstkMoviCabe bigint

SET @pstkMoviCabe = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id) and
	Segmento1N =@pSegmento1N and
	Segmento2N = @pSegmento2N and
	Segmento3N = @pSegmento3N and
	Segmento4N = @pSegmento4N and
	Segmento1C = @pSegmento1C and
	Segmento2C = @pSegmento2C and 
	Segmento3C = @pSegmento3C and 
	Segmento4C = @pSegmento4C )
SELECT  comOCSegmentos.Empresa_Id, dbo.Segmento(genSegmentos.genSegmentos, 
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
	comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
	comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C) as SegmentoSTROC,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id

From comOCSegmentos 
INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id


WHERE 
	Exists(select 1 from stkmovioc where
		stkmovioc.stkMoviCabe = @pstkMoviCabe and 
		stkmovioc.comOrdenComp =	comOrdenComp.comOrdenComp)
go