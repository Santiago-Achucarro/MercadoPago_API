drop procedure stkEntradasCDDatos
go
create procedure stkEntradasCDDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
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
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

exec stkMoviCabeDatos @pstkMoviCabe


SELECT stkEnTransito.stkMoviCabe,stkEnTransito.stkMoviCabeEntr, @pstkMoviCabe as var, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
stkEnTransito.stkMoviCabeEntr, stkSubTipoMov.TipoMov,
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos

FROM stkEnTransito 

INNER JOIN genAsiSegmentos  ON (genAsiSegmentos.Asiento_id = stkEnTransito.stkMoviCabe)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkEnTransito.Deposito_Id)
inner join genSegmentos on genAsiSegmentos.Segmento_Id=genSegmentos.genSegmentos
Inner Join stkMoviCabe On stkMoviCabe.stkMoviCabe = stkEnTransito.stkMoviCabe
Inner Join stkSubTipoMov On stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
WHERE (stkEnTransito.stkMoviCabeEntr = @pstkMoviCabe)
go

--exec stkEntradasCDDatos 1,'STOCK',19,0,0,0,'E','0001','',''