Drop procedure impSifereWeb
Go
Create procedure impSifereWeb
(
@pEmpresa_id int,
@pMes int,
@pAnio int,
@pJurisDesde varchar(3),
@pJurisHasta varchar(3)
)
As

Select @pEmpresa_Id Empresa_Id, @pMes Mes, @pAnio Anio, '' JurisDesde, '' JurisDesdeDescripcion, 'ZZZ' JurisHasta, '' JurisHastaDescripcion, 0 Opcion

--Percepciones
Select impJurisdicciones.Juris_Id, conAsientos.Fecha, genEntidades.Cuit,
comMovProv.TipoMov, conMovCont.Importe,
genAsiSegmentos.Segmento1C Sucursal, genAsiSegmentos.Segmento4C Letra, 
genAsiSegmentos.Segmento1N Comprobante, comMovImpuestos.Porcentaje
From comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join genEntidades On genEntidades.genEntidades = comProveedores.genEntidades
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join comMovImpuestos On comMovImpuestos.comMovProv = comMovProv.comMovProv
Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Inner Join impJurisdicciones On impJurisdicciones.impJurisdicciones = impTipoImpuesto.Juris_Id
Inner Join conMovCont On conMovCont.conAsientos = comMovImpuestos.comMovProv And conMovCont.Renglon = comMovImpuestos.conRenglon
Where conAsientos.Anulado = 0 And impTipoImpuesto.Juris_Id <> 0 And impTipoImpuesto.Referencia04 = 'PERC' And
genEntidades.Cuit <> '33-69345023-9'
--And comMovProv.TipoMov <> 'R' 
And conAsientos.Empresa_Id = @pEmpresa_id And Year(conAsientos.Fecha) = @pAnio And
Month( conAsientos.Fecha) = @pMes -- And impJurisdicciones.Juris_Id = @pJurisdiccion
And impJurisdicciones.Juris_Id Between @pJurisDesde And @pJurisHasta


--Retenciones
Select impJurisdicciones.Juris_Id, genEntidades.Cuit, conAsientos.Fecha, tesRengMoviRetClie.SucursalRet,
tesRengMoviRetClie.ComprobanteRet, 'R' Tipo, genAsiSegmentos.Segmento2C Sucursal, genAsiSegmentos.Segmento1N Comprobante,
conMovCont.Importe
From tesMovimientos
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
Where conAsientos.Empresa_Id = @pEmpresa_id And Year(conAsientos.Fecha) = @pAnio And conAsientos.Anulado = 0 And
Month( conAsientos.Fecha) = @pMes
And impJurisdicciones.Juris_Id Between @pJurisDesde And @pJurisHasta


--Percepciones Aduaneras
Select impJurisdicciones.Juris_Id, conAsientos.Fecha, genEntidades.Cuit,
comMovProv.TipoMov, conMovCont.Importe,
genAsiSegmentos.Segmento1C Sucursal, genAsiSegmentos.Segmento4C Letra, 
genAsiSegmentos.Segmento1N Comprobante, comMovImpuestos.Porcentaje
From comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join genEntidades On genEntidades.genEntidades = comProveedores.genEntidades
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join comMovImpuestos On comMovImpuestos.comMovProv = comMovProv.comMovProv
Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Inner Join impJurisdicciones On impJurisdicciones.impJurisdicciones = impTipoImpuesto.Juris_Id
Inner Join conMovCont On conMovCont.conAsientos = comMovImpuestos.comMovProv And conMovCont.Renglon = comMovImpuestos.conRenglon
Where conAsientos.Anulado = 0 And impTipoImpuesto.Juris_Id <> 0 And impTipoImpuesto.Referencia04 = 'PERC' And
genEntidades.Cuit = '33-69345023-9' And comMovProv.TipoMov <> 'R' 
And conAsientos.Empresa_Id = @pEmpresa_id And Year(conAsientos.Fecha) = @pAnio And
Month( conAsientos.Fecha) = @pMes 
And impJurisdicciones.Juris_Id Between @pJurisDesde And @pJurisHasta

--Recaudaciones Bancarias
SELECT conAsientos.Fecha, conMovCont.Importe, impJurisdicciones.Juris_Id,
(SELECT tesBancos.RFC FROM tesIdBancoPropio 
INNER JOIN tesBancos ON tesIdBancoPropio.Banco_Id = tesBancos.tesBancos
WHERE tesRengMovi.Cartera_Id = tesIdBancoPropio.Cartera_Id) CuitBanco,
(SELECT ValorC FROM genAtributosGenerales A 
INNER JOIN genAtributosValores B ON 
A.AtributoNro = B.AtributoNro AND
A.Tabla_Id = B.Tabla_Id
WHERE A.AtributoNro = 1 AND A.Tabla_Id = 'tesBancos' AND
Identity_Id = tesBancos.tesBancos) CBUBanco,
(SELECT tesTiposId.TipoCartera FROM
tesTiposId WHERE tesIdentifica.TipoCartera = tesTiposId.tesTiposId) TipoCuenta,
ISNULL(genMonedas.Moneda_Id,'') Moneda_Id
FROM tesRengMovi
INNER JOIN tesMovimientos ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
INNER JOIN tesSubTiposMov ON tesMovimientos.SubTipo_Id = tesSubTiposMov.tesSubTiposMov
INNER JOIN tesIdRetClien ON tesRengMovi.Cartera_Id = tesIdRetClien.Cartera_Id
INNER JOIN tesIdBancoPropio ON tesRengMovi.Cartera_Id = tesIdBancoPropio.Cartera_Id
INNER JOIN tesBancos ON tesIdBancoPropio.Banco_Id = tesBancos.tesBancos
INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
LEFT JOIN genMonedas ON tesIdentifica.Moneda_Id = genMonedas.genMonedas
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = tesIdRetClien.TipoImpuesto
Inner Join impJurisdicciones On impJurisdicciones.impJurisdicciones = impTipoImpuesto.Juris_Id
INNER JOIN conMovCont ON tesRengMovi.tesMovimientos = conMovCont.conAsientos AND
	tesRengMovi.conRenglon = conMovCont.Renglon
WHERE --tesRengMovi.TipomovCont = 2 AND 
tesSubTiposMov.SubTipo_Id = 'DBA' AND  conAsientos.Anulado = 0 AND
conAsientos.Empresa_Id = @pEmpresa_id And Year(conAsientos.Fecha) = @pAnio And
Month( conAsientos.Fecha) = @pMes AND 
impJurisdicciones.Juris_Id Between @pJurisDesde And @pJurisHasta
GO

