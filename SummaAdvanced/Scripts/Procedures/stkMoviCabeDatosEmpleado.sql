DROP PROCEDURE stkMoviCabeDatosEmpleado
GO
CREATE PROCEDURE stkMoviCabeDatosEmpleado
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
Declare @pstkMoviCabe bigint = (select Asiento_Id
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
	
EXEC stkMoviCabeDatos @pstkMoviCabe

SELECT stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion,
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
FROM stkMoviCausa 
	INNER JOIN stkCausasMovi ON stkMoviCausa.Causa_Id = stkCausasMovi.stkCausasMovi
	INNER JOIN conCuentas ON stkCausasMovi.Cuenta_Id = conCuentas.conCuentas
	LEFT Join conCentro1 On stkMoviCausa.Centro1_Id = conCentro1.conCentro1
	LEFT Join conCentro2 On stkMoviCausa.Centro2_Id = conCentro2.conCentro2
	WHERE
	stkMoviCausa.stkMoviCabe = @pstkMoviCabe 

SELECT suePersonal.Legajo, suePersonal.Nombres +', '+suePersonal.ApellidoPaterno +
	CASE WHEN suePersonal.ApellidoPaterno = ' ' THEN '' ELSE ', ' end +suePersonal.ApellidoMaterno as Nombre
FROM stkMoviLega
	INNER JOIN suePersonal ON stkMoviLega.Legajo = suePersonal.genEntidades
WHERE
	stkMoviLega.stkMoviCabe = @pstkMoviCabe
GO	

