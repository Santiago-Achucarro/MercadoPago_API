-- comMovContCuentaDatos 126

DROP PROCEDURE comMovContCuentaDatos
GO

CREATE PROCEDURE comMovContCuentaDatos (
	@Asiento_Id BigInt
)
AS
SELECT conMovCont.conAsientos Asiento_Id, conCuentas.Cuenta_Id, conMovCont.Clase,
	conAsientos.Cambio, genMonedas.Moneda_Id, genMonedas.CantidadDigitos as Decimales,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as Monto 
FROM
conMovCont INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos =  conMovCont.conAsientos
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_Id
Where
	conMovCont.Clase IN ('ANTPR','PRO') AND 
	conAsientos.Anulado = 0 and 
	conAsientos.conAsientos = @Asiento_Id
GROUP BY conCuentas.Cuenta_Id, conMovCont.Clase, conMovCont.conAsientos, conAsientos.Cambio, 
genMonedas.Moneda_Id, genMonedas.CantidadDigitos 
GO