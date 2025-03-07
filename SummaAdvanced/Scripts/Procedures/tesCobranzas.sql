-- tesCobranzasDatos 1, 'TES',1193,0,0,0,'I','0005','',''
DROP PROCEDURE tesCobranzasDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesCobranzasDatos
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
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos 
From tesMovimientos 
INNER JOIN genAsiSegmentos ON tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
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

Exec tesRengConciliacDatos @ptesMovimientos, NULL, 1
Exec tesRengConciliacDatos @ptesMovimientos, NULL, 2


-- Solo traigo las facturas que intervinieron en la cobranza pasada como parámetro --
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	conAsientos.Fecha as Fecha, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio,
	genMovCuotas.Importe, genMovCuotas.Saldo, 
	--Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, 
	genCancMov.Importe SaldoOri,
	conAsientos.conAsientos, conCuentas.Cuenta_Id, genCancMov.Importe as MontoACobrar, 
	isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
		tesRengMovi.TesMovimientos =genCancMov.Asiento_Id_Ap and 
		tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
		tesRengMovi.conRenglon  = 	conMovCont1.Renglon and 
		conMovCont.Cuenta_id =conMovCont1.Cuenta_id),1)  as CambioCobra, 
		genMovCuotas.CuotaNro, genCancMov.EsVentaContado, 
		venMovimientosMetodoPago.NMetodoPago
From genAsiSegmentos 
INNER JOIN venMovimientos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
inner JOIN genMovCuotas ON genMovCuotas.Asiento_id = conAsientos.conAsientos
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND
	conMovCont.Clase =	'CLI'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipomov = venMovimientos.venTipomov
INNER JOIN genCancMov ON genCancMov.Asiento_Id = conAsientos.conAsientos and 
	genCancMov.CuotaNro = genMovCuotas.CuotaNro and
	genCancMov.Asiento_Id_Ap = @ptesMovimientos and 
	genCancMov.CuotaNro_ap = 1
LEFT JOIN venMovimientosMetodoPago ON venMovimientosMetodoPago.venMovimientos = venMovimientos.venMovimientos
Where
	conAsientos.Anulado = 0 And genCancMov.EsAplicOriginal = 1
	ORDER BY 2,1



-- AntClientes
-- Anticipos de Clientes 
SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta
From tesRengMovi 
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon = tesRengMovi.conRenglon and 
	conMovCont.Clase = 'ANTCL'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id
Where 
tesRengMovi.TesMovimientos =  @pTesMovimientos

-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'


select cast(case when Exists(select 1 from tesCFDICobranzaCuerpo inner join tesCFDICobranza ON
	tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza  AND
	tesCFDICobranzaCuerpo.tesMovimientos = @ptesMovimientos
	Where	
	tesCFDICobranza.Anulada = ' ') THEN 1 ELSE 0 END as Bit) AS ReqCompPago

SELECT tesMoviOficial.tesMovimientos, tesMoviOficial.Sucursal_Of, tesMoviOficial.Comprobante_Of 
FROM tesMoviOficial
WHERE 
	tesMoviOficial.tesMovimientos = @ptesMovimientos

RETURN @@Error 
GO

------------------------------------------------------------------------------
-- tesCobranzasDatosPendientes 1, '02020010000001', 'PES'
GO 
DROP PROCEDURE tesCobranzasDatosPendientes
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesCobranzasDatosPendientes
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
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	conAsientos.Fecha as Fecha, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio,
	genMovCuotas.Importe, genMovCuotas.Saldo, 
	--Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, 
	genMovCuotas.Importe*0 as SaldoOri,
	conAsientos.conAsientos, conCuentas.Cuenta_Id, genMovCuotas.Importe*0 as MontoACobrar, 
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @Empresa_Id) as CambioCobra, 
	genMovCuotas.CuotaNro, cast(0 as bit) as EsVentaContado, venMovimientosMetodoPago.NMetodoPago,
	conMovCont.Clase, genMovCuotas.FechaVencimiento
From genAsiSegmentos 
INNER JOIN venMovimientos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
INNER JOIN venTipoMov ON venTipoMov.venTipomov = venMovimientos.venTipomov
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND
	conMovCont.Clase =	'CLI'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = venmovimientos.venMovimientos
LEFT JOIN venMovimientosMetodoPago ON venMovimientosMetodoPago.venMovimientos = venMovimientos.venMovimientos
Where 
conAsientos.Anulado = 0 and conAsientos.Posteado = 1 And
venMovimientos.Cliente_id = dbo.FuncFKvenClientes(@pCliente_Id) and 
conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) and 
genMovCuotas.Saldo > 0 and 
venTipoMov.Signo = 1 And
conAsientos.Empresa_Id = @Empresa_Id
ORDER BY 2,1
-- AntClientes
-- Anticipos de Clientes 
SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta
From tesRengMovi 
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon = tesRengMovi.conRenglon and 
	conMovCont.Clase = 'ANTCL'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id
Where 
tesRengMovi.TesMovimientos =  @pTesMovimientos

-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

select cast(case when Exists(select 1 from tesCFDICobranzaCuerpo inner join tesCFDICobranza ON
	tesCFDICobranzaCuerpo.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza  AND
	tesCFDICobranzaCuerpo.tesMovimientos = @ptesMovimientos
	Where	
	tesCFDICobranza.Anulada = ' ') THEN 1 ELSE 0 END as Bit) AS ReqCompPago

RETURN @@Error 
GO

DROP PROCEDURE tesCobranzasDatosOfi
GO
CREATE PROCEDURE tesCobranzasDatosOfi    
(    
@pSucursal_Of Sucursal,    
@pComprobante_Of int    
)    
AS    
SET NOCOUNT ON     
    
Declare @ptesMovimientos as BigInt    
SET @ptesMovimientos = (SELECT tesMovimientos     
 FROM  tesMoviOficial    
 WHERE Sucursal_Of = @pSucursal_Of AND     
 Comprobante_Of = @pComprobante_Of AND
 NOT EXISTS (SELECT 1 FROM tesRecOfiAnul 
 WHERE tesMoviOficial.Sucursal_Of = tesRecOfiAnul.Sucursal_Of AND 
 tesMoviOficial.Comprobante_Of = tesRecOfiAnul.Comprobante_Of))    
    
SELECT genSegmentos.Segmento_Id, genAsiSegmentos.Empresa_Id, genAsiSegmentos.Segmento1N,    
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,     
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,     
genAsiSegmentos.Segmento4C    
FROM tesMovimientos     
INNER JOIN genAsiSegmentos ON tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id    
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id    
 WHERE tesMovimientos.tesMovimientos = @ptesMovimientos    
    
RETURN @@Error     

