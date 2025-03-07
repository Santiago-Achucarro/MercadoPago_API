DROP PROCEDURE Inf_impSiferePerc
GO
CREATE PROCEDURE Inf_impSiferePerc
(
@pEmpresa_id int,
@pMes int,
@pAnio int
)
AS
SELECT impJurisdicciones.Juris_Id, 
impJurisdicciones.Descripcion DescJuris, conAsientos.Fecha, 
comProveedores.Proveed_Id, comProveedores.RazonSocial, genEntidades.Cuit,
conMovCont.Importe, comMovImpuestos.Porcentaje,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comp,
comMovImpuestos.Base_Imponible Base
FROM comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join genEntidades On genEntidades.genEntidades = comProveedores.genEntidades
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join comMovImpuestos On comMovImpuestos.comMovProv = comMovProv.comMovProv
Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Inner Join impJurisdicciones On impJurisdicciones.impJurisdicciones = impTipoImpuesto.Juris_Id
Inner Join conMovCont On conMovCont.conAsientos = comMovImpuestos.comMovProv And 
conMovCont.Renglon = comMovImpuestos.conRenglon
WHERE conAsientos.Anulado = 0 And impTipoImpuesto.Juris_Id <> 0 And 
impTipoImpuesto.Referencia04 = 'PERC' And
genEntidades.Cuit <> '33-69345023-9' And conAsientos.Empresa_Id = @pEmpresa_id And 
Year(conAsientos.Fecha) = @pAnio And Month( conAsientos.Fecha) = @pMes 
GO

DROP PROCEDURE Inf_impSifereRet
GO
CREATE PROCEDURE Inf_impSifereRet
(
@pEmpresa_id int,
@pMes int,
@pAnio int
)
AS
SELECT impJurisdicciones.Juris_Id, impJurisdicciones.Descripcion DescJuris, 
conAsientos.Fecha, venClientes.Cliente_Id, venClientes.RazonSocial, 
genEntidades.Cuit, conMovCont.Importe, tesRengMoviRetClie.Porcentaje,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comp,
tesRengMoviRetClie.BaseImponible Base
FROM tesMovimientos
Inner Join conAsientos On conAsientos.conAsientos = tesMovimientos.tesMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join venMovimientos On venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
Inner Join tesRengMoviRetClie On tesRengMoviRetClie.tesMovimientos = tesRengMovi.tesMovimientos And 
		tesRengMoviRetClie.conRenglon = tesRengMovi.conRenglon
Inner Join conMovCont On conMovCont.conAsientos = tesRengMovi.tesMovimientos And conMovCont.Renglon = tesRengMovi.conRenglon
Inner Join tesIdRetClien On tesIdRetClien.Cartera_Id = tesRengMovi.Cartera_Id
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = tesIdRetClien.TipoImpuesto
Inner Join impJurisdicciones On impJurisdicciones.impJurisdicciones = impTipoImpuesto.Juris_Id
Inner Join genEntidades On genEntidades.genEntidades = venMovimientos.Cliente_Id
Inner Join venClientes On genEntidades.genEntidades = venClientes.genEntidades
WHERE conAsientos.Empresa_Id = @pEmpresa_id And Year(conAsientos.Fecha) = @pAnio And 
conAsientos.Anulado = 0 And Month( conAsientos.Fecha) = @pMes
GO





