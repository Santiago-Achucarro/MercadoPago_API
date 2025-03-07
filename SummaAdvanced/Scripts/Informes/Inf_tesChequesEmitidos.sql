-- Inf_tesChequesEmitidos   ' ','ZZZZZ', '20230101','20230531',1,0,999999, 0,999999,'20230531'
DROP PROCEDURE Inf_tesChequesEmitidos
GO

CREATE PROCEDURE Inf_tesChequesEmitidos
(
	@BancoDesde VarChar(5),
	@BancoHasta VarChar(5),
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id INT,
	@ChequeDesde int,
	@ChequeHasta int,
	@ChequeraDesde int,
	@ChequeraHasta int,
	@FechaOpFechaCheque char(1)
)

AS

SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	tesCheqProp.Chequera_Id,  tesCheqProp.numCheque, 
	conAsientos.Fecha, tesCheqProp.FechaVencimiento, 
	tesCheqProp.aLaOrden, 
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) As Segmento,
	conMovCont.ImporteMonedaOriginal, conMovCont.Importe
FROM conAsientos
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = conMovCont.conAsientos And tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id 
INNER JOIN tesBPlink ON tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos AND tesBPlink.conRenglon =tesRengMovi.conRenglon
INNER JOIN tesCheqProp ON tesCheqProp.tesCheqProp =tesBPlink.tesCheqProp
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
WHERE
	tesBPlink.Secuencia = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	(conAsientos.Fecha between @FechaDesde And @FechaHasta And @FechaOpFechaCheque = 'O' Or 
		tesCheqProp.FechaVencimiento between @FechaDesde And @FechaHasta And @FechaOpFechaCheque = 'C' ) And
	tesIdentifica.Cartera_Id between @BancoDesde AND @BancoHasta and
	tesCheqProp.numCheque between @ChequeDesde and @ChequeHasta and
	tesCheqProp.Chequera_Id between @ChequeraDesde and @ChequeraHasta

UNION ALL
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	0 Chequera_Id,  0 numCheque, 
	conAsientos.Fecha,  conAsientos.Fecha FechaVencimiento, 
	isnull(comproveedores.RazonSocial,conAsientos.Observaciones) aLaOrden, 
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	conMovCont.ImporteMonedaOriginal , conMovCont.Importe
FROM conAsientos 
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
	tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
left outer join comMovProv On conAsientos.conAsientos = comMovprov.comMovProv
left outer join comproveedores on commovprov.Proveed_Id = comproveedores.genEntidades
inner join tesmovimientos on tesmovimientos.tesMovimientos= conasientos.conAsientos
Inner Join tesTiposId On tesTiposId.tesTiposId = tesIdentifica.tipoCartera
WHERE
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
	conAsientos.Fecha between @FechaDesde and @FechaHasta and
	tesIdentifica.Cartera_Id between @BancoDesde AND @BancoHasta and
	not exists (select 1 from tesbplink where
	tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
tesBPlink.conRenglon =tesRengMovi.conRenglon) and tesmovimientos.SubTipo_Id=20
	and tesTiposId.tipoCartera = 'CP'
Union all
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	tesCheqProp.Chequera_Id,  tesCheqProp.numCheque, 
	conAsientos.Fecha,  tesCheqProp.FechaVencimiento, 
	'ANULADO', 
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
	0 ImporteMonedaOriginal , 0 Importe
FROM conAsientos 
INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
	tesRengMovi.conRenglon = conMovCont.Renglon
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id 
INNER JOIN tesBPlink ON tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
	tesBPlink.conRenglon =tesRengMovi.conRenglon
INNER JOIN tesCheqProp ON tesCheqProp.tesCheqProp =tesBPlink.tesCheqProp
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
WHERE
	tesBPlink.Secuencia = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 1 and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta and
	tesIdentifica.Cartera_Id between @BancoDesde AND @BancoHasta and
	tesCheqProp.numCheque between @ChequeDesde and @ChequeHasta and
	tesCheqProp.Chequera_Id between @ChequeraDesde and @ChequeraHasta

UNION ALL
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, 
	tesCheqProp.Chequera_Id,  tesCheqProp.numCheque, 
	tesCheqPropAnul.FechaOriginal,  tesCheqProp.FechaVencimiento, 
	'CANCELADO', 
	'' as Segmento,
	0 ImporteMonedaOriginal , 0 Importe
FROM tesCheqPropAnul 
INNER JOIN tesCheqProp ON tesCheqProp.tesCheqProp =tesCheqPropAnul.tesCheqProp
inner join tesIdentifica on  tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id
WHERE
	tesCheqProp.Empresa_Id = @Empresa_Id and 
	tesCheqPropAnul.FechaOriginal between @FechaDesde and @FechaHasta and
	tesIdentifica.Cartera_Id between @BancoDesde AND @BancoHasta and
	tesCheqProp.numCheque between @ChequeDesde and @ChequeHasta and
	tesCheqProp.Chequera_Id between @ChequeraDesde and @ChequeraHasta and 
	not exists(select 1 from tesBPlink where
	tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp)
	order by 1,3,4
GO

