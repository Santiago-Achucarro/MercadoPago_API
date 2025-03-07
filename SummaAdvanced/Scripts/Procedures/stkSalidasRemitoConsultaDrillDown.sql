DROP PROCEDURE stkSalidasRemitoConsultaDrillDown
GO
CREATE PROCEDURE stkSalidasRemitoConsultaDrillDown
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

EXEC stkRemitosDatos @pstkMoviCabe

Select stkMoviCausa.stkMoviCabe, Cast(0 As bit) SoloRemito, Cast(1 As bit) PendienteFacturacion,
stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion DescripcionCausa,
conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
From stkMoviCausa
Inner Join stkCausasMovi On stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id
Left Join conCentro1 On conCentro1.conCentro1 = stkMoviCausa.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = stkMoviCausa.Centro2_Id
Where stkMoviCausa.stkMoviCabe = @pstkMoviCabe

-- Relacionados --
-- Facturas --
SELECT DISTINCT dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Relacionado, 
	genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venMovStkHist 
Inner Join genAsiSegmentos ON venMovStkHist.venMovimientos = genAsiSegmentos.Asiento_Id
Inner Join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE venMovStkHist.stkMoviCabe = @pstkMoviCabe And genMenus.Orden = '539910'
Union All
-- Hoja de ruta --
SELECT dbo.Segmento(stkHojaSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, stkHojaSegmentos.Segmento2C,
stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N, 
stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N) as Relacionado,
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
FROM stkRemitos
Inner Join genSegmentos On stkRemitos.Segmento_Id = genSegmentos.genSegmentos
Inner Join stkHojaSegmentos On stkHojaSegmentos.stkHojaDeRuta = stkRemitos.HojaRuta_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE stkRemitos.stkMoviCabe = @pstkMoviCabe And genMenus.Orden = '222060'
UNION ALL 
-- REPARTO
SELECT DISTINCT dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, 
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) as Relacionado,
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
FROM stkRemitos
Inner Join venPediRemitidos On stkRemitos.stkMoviCabe =  venPediRemitidos.stkMoviCabe
INNER JOIN venRepaPedi ON  venRepaPedi.venPedidos =venPediRemitidos.venPedidos and 
				venPediRemitidos.stkMoviCabe = stkRemitos.stkMoviCabe and 
				venRepaPedi.venReparto = venPediRemitidos.venReparto
INNER JOIN venRepaSegmentos ON  venRepaSegmentos.venReparto =venRepaPedi.venReparto
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos =venRepaSegmentos.Segmento_Id
INNER Join genMenus  ON genMenus.Orden = '52103020'
Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id
WHERE stkRemitos.stkMoviCabe = @pstkMoviCabe 
GO


