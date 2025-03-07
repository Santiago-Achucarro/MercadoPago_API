DROP PROCEDURE tesDepositosXBancosDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesDepositosXBancosDatos
(
	@Empresa_Id int,  
	@pFechaDesde datetime,
	@pFechaHasta datetime,
	@pCartera varchar(5)
)
AS
SET NOCOUNT ON 


	Select @pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta,
	 @pCartera as Cartera_Id, Descripcion as DescripcionCartera from tesIdentifica 
	 where Cartera_Id=@pCartera
select dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as SegmentoSTR
, TesDeposito.tesMovimientos, tesRengMovi.conRenglon as Renglon, TesDeposito.FormaDePagoP, TesDeposito.NumOperacion, TesDeposito.NomBancoOrdExt,
TesDeposito.CtaOrdenante, TesDeposito.TipoCadPago, TesDeposito.CertPago,TesDeposito.CadPago,TesDeposito.SelloPago,
TesDeposito.RfcEmisorCtaOrd, conAsientos.Fecha,  conMovCont.ImporteMonedaOriginal Importe, venClientes.RazonSocial as Cliente
from TesDeposito inner join venMovimientos on venMovimientos.venMovimientos=TesDeposito.tesMovimientos
inner join conAsientos on conAsientos.conAsientos=venMovimientos.venMovimientos
inner join tesRengMovi on tesRengMovi.tesMovimientos=venMovimientos.venMovimientos
inner join venClientes on venClientes.genEntidades=venMovimientos.Cliente_Id
inner join conMovCont on (conMovCont.conAsientos=tesRengMovi.tesMovimientos and tesRengMovi.conRenglon=conMovCont.Renglon)
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=TesDeposito.tesMovimientos
inner join tesIdentifica on tesRengMovi.Cartera_Id=tesIdentifica.tesIdentifica
where
genAsiSegmentos.Empresa_Id=@Empresa_Id and conAsientos.Fecha between @pFechaDesde and @pFechaHasta and tesIdentifica.Cartera_Id=@pCartera AND 
NOT EXISTS(SELECT 1 FROM tesCFDICobranza, tesCFDICobranzaCuerpo WHERE
tesCFDICobranza.tesCFDICobranza = tesCFDICobranzaCuerpo.tesCFDICobranza and 
tesCFDICobranzaCuerpo.tesMovimientos= conAsientos.conAsientos and 
tesCFDICobranza.Anulada = ' ')
order by 1
GO