-- tesAsiCierreCalculo '20180331', 1

DROP PROCEDURE tesAsiCierreCalculo
GO
CREATE PROCEDURE tesAsiCierreCalculo
(
@pFecha DateTime, 
@Empresa_Id Int
)
AS
SET NOCOUNT ON 

SELECT @pFecha as Fecha 

SELECT genMonedas.Moneda_Id, 
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
	SUM(conMovCont.Importe *(-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal *(-2*conMovCont.Tipomov+3)) as ImporteMonedaOriginal
from tesMovimientos 
INNER JOIN tesRengMovi on tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN tesIdentifica on tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER Join conCuentas ON conCuentas.conCuentas = tesIdentifica.Cuenta_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = tesMovimientos.tesMovimientos
INNER JOIN genEmpresas ON genEmpresas.genEmpresas =conAsientos.Empresa_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = tesIdentifica.Moneda_Id
Where
conAsientos.Anulado = 0 and 
genMonedas.genMonedas != genEmpresas.Moneda_Id and 
conAsientos.Fecha <= @pFecha  and
conAsientos.Empresa_Id = @Empresa_Id
GROUP BY genMonedas.Moneda_Id, tesIdentifica.Cartera_Id, tesIdentifica.Descripcion, conCuentas.Cuenta_Id, conCuentas.Descripcion 
ORDER BY 1,2
RETURN @@Error 

GO


DROP PROCEDURE tesAsiCierreDatosCierre
GO
CREATE PROCEDURE tesAsiCierreDatosCierre
(
@pFecha DateTime, 
@Empresa_Id Int
)
AS
SET NOCOUNT ON 

SELECT @pFecha as Fecha 



SELECT conAsientos.conAsientos Asiento_Id , conAsientos.Empresa_Id, conAsientos.Fecha, 
	conAsientos.Anulado, genMonedas.Moneda_Id, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
FROM conAsientos 
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
inner join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE conAsientos.Fecha = @pFecha  and 
conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmtesoreriaCierre') and
conAsientos.Anulado = 0 and 
conAsientos.Empresa_Id = @Empresa_Id

 
RETURN @@Error 

GO




