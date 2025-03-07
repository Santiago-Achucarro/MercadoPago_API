DROP procedure inf_stkEmbarque
GO
create procedure inf_stkEmbarque
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
Declare @pstkMoviCabe bigint = (Select Asiento_id
 From genAsiSegmentos
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
Select genAsiSegmentos.Empresa_Id, dbo.Segmento(genSegmentos.genSegmentos, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N)as SegmentoSTREMB, comProveedores.Proveed_Id, comProveedores.RazonSocial,
	stkMoviEmbarque.RemitoProv, comDespachos.Despacho_Id
From stkMoviEmbarque
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviEmbarque.comEmbarques
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join comProveedores On comProveedores.genEntidades = stkMoviEmbarque.Proveed_Id
Inner Join comDespachos On comDespachos.comDespachos = stkMoviEmbarque.Despacho_Id
Where stkMoviEmbarque.stkMoviCabe = @pstkMoviCabe
go