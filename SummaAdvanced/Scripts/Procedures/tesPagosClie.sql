-- exec tesPagosClieDatosPendientes @Empresa_Id=2,@pCliente_id='00001',@pMoneda_Id=''
-- exec tesPagosClieDatosPendientes @Empresa_Id=1,@pCliente_id='00025',@pMoneda_Id='PES'

DROP PROCEDURE tesPagosClieDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesPagosClieDatos
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20), 
	@pCliente_id VarChar(15)=null, 
	@pMoneda_Id VarChar(5)=NULL

)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )


EXECUTE tesMovimientosDatos @ptesMovimientos

Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2


-- Solo traigo las facturas que intervinieron en la cobranza pasada como parámetro --
SELECT SegmentoSTR, Fecha, Moneda_Id, DescripcionMoneda, Cambio,
	Importe, Saldo, SaldoOri, conAsientos, max(Cuenta_Id)  as Cuenta_Id, 
	MontoACobrar, CambioCobra, CuotaNro, Clase
FROM (
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	conAsientos.Fecha as Fecha, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio,
	genMovCuotas.Importe, genMovCuotas.Saldo, Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, 
	conAsientos.conAsientos, conCuentas.Cuenta_Id, genCancMov.Importe as MontoACobrar, 
	isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
		tesRengMovi.TesMovimientos =genCancMov.Asiento_Id_Ap and 
		tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
		tesRengMovi.conRenglon  = 	conMovCont1.Renglon and 
		conMovCont.Cuenta_id =conMovCont1.Cuenta_id),1)  as CambioCobra, 
		genMovCuotas.CuotaNro, conMovCont.Clase
from genAsiSegmentos INNER JOIN venMovimientos ON
genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON
conAsientos.conAsientos = venMovimientos.venMovimientos
inner JOIN genMovCuotas ON
genMovCuotas.Asiento_id = conAsientos.conAsientos
INNER JOIN conMovCont ON
conMovCont.conAsientos = conAsientos.conAsientos  AND
conMovCont.Clase IN('CLI','ANTCL') 
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipomov = venMovimientos.venTipomov
INNER JOIN genCancMov ON
genCancMov.Asiento_Id_ap = conAsientos.conAsientos and 
genCancMov.CuotaNro_ap = genMovCuotas.CuotaNro and
genCancMov.Asiento_Id = @ptesMovimientos and 
genCancMov.CuotaNro = 1
WHERE 
conAsientos.Anulado = 0 AND 
conAsientos.Posteado = 1
) AS XXX
GROUP BY  SegmentoSTR, Fecha, Moneda_Id, DescripcionMoneda, Cambio,
	Importe, Saldo, SaldoOri, conAsientos, MontoACobrar, CambioCobra, CuotaNro, 
	Clase


-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'



RETURN @@Error 

GO

------------------------------------------------------------------------------
DROP PROCEDURE tesPagosClieDatosPendientes
GO

CREATE PROCEDURE tesPagosClieDatosPendientes
(
	@Empresa_Id int, 
	@pCliente_id VarChar(15), 
	@pMoneda_Id VarChar(5)

)
AS
SET NOCOUNT ON 

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = 0

EXECUTE tesMovimientosDatos @ptesMovimientos

Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2


-- TODO SALDOS INICIALES
-- Cobranzas y/o Pagos a Clientes
SELECT SegmentoSTR, Fecha, Moneda_Id, DescripcionMoneda, Cambio,
	Importe, Saldo, SaldoOri, conAsientos, max(Cuenta_Id)  as Cuenta_Id, 
	MontoACobrar, CambioCobra, CuotaNro, Clase
FROM (
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	conAsientos.Fecha as Fecha, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio,
	genMovCuotas.Importe, genMovCuotas.Saldo, Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, 
	conAsientos.conAsientos, conCuentas.Cuenta_Id, genMovCuotas.Importe*0 as MontoACobrar, 
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @Empresa_Id) as CambioCobra, 
	genMovCuotas.CuotaNro, conMovCont.Clase
from genAsiSegmentos 
INNER JOIN venMovimientos ON
genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON
conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON
venTipoMov.venTipomov = venMovimientos.venTipomov
INNER JOIN conMovCont ON
conMovCont.conAsientos = conAsientos.conAsientos  AND
conMovCont.Clase IN('CLI','ANTCL') 
INNER JOIN conCuentas ON
conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMovCuotas ON 
genMovCuotas.Asiento_Id = venmovimientos.venMovimientos
Where 
conAsientos.Anulado = 0 and 
conAsientos.Posteado = 1 and 
venMovimientos.Cliente_id = dbo.FuncFKvenClientes(@pCliente_Id) and 
conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) and 
genMovCuotas.Saldo > 0 and 
venTipoMov.Signo = -1 And
conAsientos.Empresa_Id = @Empresa_Id) AS XXX
GROUP BY  SegmentoSTR, Fecha, Moneda_Id, DescripcionMoneda, Cambio,
	Importe, Saldo, SaldoOri, conAsientos, MontoACobrar, CambioCobra, CuotaNro, 
	Clase



-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

RETURN @@Error 

GO

--exec tesPagosClieDatosPendientes 1,'90003','PES'