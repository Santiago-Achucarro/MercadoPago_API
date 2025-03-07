Drop procedure tesRetProvxOPDatos
Go

Create procedure tesRetProvxOPDatos
(
@pEmpresa_Id Int,
@pSegmento1N_OP int,
@pSegmento2N_OP int,
@pSegmento3N_OP int,
@pSegmento4N_OP int,
@pSegmento1C_OP varchar(20),
@pSegmento2C_OP varchar(20),
@pSegmento3C_OP varchar(20),
@pSegmento4C_OP varchar(20)
)
As

Select @pSegmento1N_OP Segmento1N_OP, @pSegmento2N_OP Segmento2N_OP, @pSegmento3N_OP Segmento3N_OP, @pSegmento4N_OP Segmento4N_OP,
@pSegmento1C_OP Segmento1C_OP, @pSegmento2C_OP Segmento2C_OP, @pSegmento3C_OP Segmento3C_OP, @pSegmento4C_OP Segmento4C_OP


Select tesMovimientos.tesMovimientos, tesRengMovi.conRenglon, tesIdentifica.Cartera_Id, genSegmentosRet.Segmento_Id,
tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, tesRetProvSegmento.Segmento4N, 
tesRetProvSegmento.Segmento1C, tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,
dbo.Segmento(tesIdRetProv.Segmento_Id, tesRetProvSegmento.Segmento1C, tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,
tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, tesRetProvSegmento.Segmento4N) Segmento,
genReportes.Reporte_Id
From conAsientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join tesMovimientos On tesMovimientos.tesMovimientos = conAsientos.conAsientos
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
Inner Join tesRengMoviRetProv On tesRengMoviRetProv.tesMovimientos = tesRengMovi.tesMovimientos And
			tesRengMoviRetProv.conRenglon = tesRengMovi.conRenglon
Inner Join conMovCont On conMovCont.conAsientos = tesRengMovi.tesMovimientos And
			conMovCont.Renglon = tesRengMovi.conRenglon
Inner Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesRengMovi.Cartera_Id
Inner Join genSegmentos genSegmentosRet On genSegmentosRet.genSegmentos = tesIdRetProv.Segmento_Id
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner Join tesRetProvSegmento On tesRetProvSegmento.tesMovimientos = tesRengMovi.tesMovimientos And
			tesRetProvSegmento.conRenglon = tesRengMovi.conRenglon
Left Join genReportes On genReportes.genReportes = tesIdRetProv.Reporte_Id
Where conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
genAsiSegmentos.Segmento1N = @pSegmento1N_OP And genAsiSegmentos.Segmento2N = @pSegmento2N_OP And genAsiSegmentos.Segmento3N = @pSegmento3N_OP And
genAsiSegmentos.Segmento4N = @pSegmento4N_OP And genAsiSegmentos.Segmento1C = @pSegmento1C_OP And genAsiSegmentos.Segmento2C = @pSegmento2C_OP And
genAsiSegmentos.Segmento3C = @pSegmento3C_OP And genAsiSegmentos.Segmento4C = @pSegmento4C_OP
Go

