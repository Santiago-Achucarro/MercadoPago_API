DROP PROCEDURE inf_stkMoviCausa
GO
CREATE PROCEDURE inf_stkMoviCausa
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

SELECT stkMoviCausa.stkMoviCabe, stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion as DescripcionCausasMovi,
conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
FROM stkMoviCausa 
INNER JOIN stkCausasMovi  ON (stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id)
Inner Join conCentro1 On stkMoviCausa.Centro1_Id = conCentro1.conCentro1
Inner Join conCentro2 On stkMoviCausa.Centro2_Id = conCentro2.conCentro2
WHERE (stkMoviCausa.stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO