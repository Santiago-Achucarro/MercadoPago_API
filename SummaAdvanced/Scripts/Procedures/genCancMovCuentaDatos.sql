
DROP PROCEDURE genCancMovCuentaDatos
GO
CREATE PROCEDURE genCancMovCuentaDatos (
	@pconAsientos bigint
)

AS

SELECT conAsientos.conAsientos, conCuentas.Cuenta_Id, 
	conCuentas.Descripcion, conMovCont.Clase, 
		conMovCont.TipoMov, genMonedas.Moneda_Id, 
		conAsientos.Cambio,conMovCont.Importe, conMovCont.ImporteMonedaOriginal
From conAsientos INNER JOIN conMovCont ON
	conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN conCuentas ON
	conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN genMonedas ON
	genMonedas.genMonedas = conCuentas.Moneda_Id
	Where
		conAsientos.conAsientos = @pconAsientos and
		conMovCont.Clase in ('PRO','CLI','ANTPR','ANTCL')
GO