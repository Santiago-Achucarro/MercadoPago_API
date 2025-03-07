-- tesCobraProvDatos 1, 'TES',0,0,0,0,'I','0001',' ',' ','ABB', 'PES'

DROP PROCEDURE tesCobraProvDatos
GO

CREATE PROCEDURE tesCobraProvDatos
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
	@pProveed_Id VarChar(15)=null,
	@pMoneda_Id varChar(3) = NULL

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

Exec tesRengConciliacDatos @ptesMovimientos, NULL,1


IF (@ptesMovimientos IS NULL)
Begin

	--  Pagos a Proveedores

	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda, conAsientos.Cambio, genMovCuotas.CuotaNro,
	genMovCuotas.Importe, genMovCuotas.Saldo,
	Convert(Numeric(18,2), genMovCuotas.Saldo*conAsientos.Cambio) As SaldoOri,
	conAsientos.conAsientos comMovProv, conCuentas.Cuenta_Id, 0.00 as ImporteHabilitado, 
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @Empresa_Id) As CambioPago,
	comMovProv.Fecha_CCP
	FROM comMovProv
	INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
	Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
	Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'ANTPR'
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	Inner Join genMovCuotas On genMovCuotas.Asiento_Id = comMovProv.comMovProv
	WHERE comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And 
	comMovTipos.Signo = 1 and 
	genMovCuotas.Saldo > 0 	And 
	conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
	union all

	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda, conAsientos.Cambio, genMovCuotas.CuotaNro,
	genMovCuotas.Importe, genMovCuotas.Saldo,
	Convert(Numeric(18,2), genMovCuotas.Saldo*conAsientos.Cambio) As SaldoOri,
	conAsientos.conAsientos comMovProv, conCuentas.Cuenta_Id, 0.00 as ImporteHabilitado, 
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @Empresa_Id) As CambioPago,
	comMovProv.Fecha_CCP
	FROM comMovProv
	INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
	Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
	Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'PRO'
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	Inner Join genMovCuotas On genMovCuotas.Asiento_Id = comMovProv.comMovProv
	WHERE comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And 
	comMovTipos.Signo = 1 and 
	genMovCuotas.Saldo > 0 	And 
	conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id) AND 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 AND 
		Not EXISTS(SELECT 1 FROM conMovCont c1 where 
		c1.conAsientos = conAsientos.conAsientos AND 
		c1.Clase = 'ANTPR')

end

else
Begin

	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio, 
		genMovCuotas.CuotaNro,	genMovCuotas.Importe, genMovCuotas.Saldo, 
		Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri,
		conAsientos.conAsientos comMovProv, conCuentas.Cuenta_Id as Cuenta_Id, genCancMov.Importe ImporteHabilitado,
		isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
			tesRengMovi.TesMovimientos = genCancMov.Asiento_Id_Ap and 
			tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
			tesRengMovi.conRenglon = conMovCont1.Renglon and 
			conMovCont.Cuenta_id = conMovCont1.Cuenta_id),1)  as CambioPago,
			comMovProv.Fecha_CCP, conMovCont.Clase
	From genAsiSegmentos 
	INNER JOIN comMovprov ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovprov.comMovprov
	inner JOIN genMovCuotas ON genMovCuotas.Asiento_id = conAsientos.conAsientos
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND
		conMovCont.Clase IN('ANTPR')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comMovTipos ON
	comMovTipos.Tipomov = comMovprov.Tipomov
	INNER JOIN genCancMov ON genCancMov.Asiento_Id = conAsientos.conAsientos and 
		genCancMov.CuotaNro = genMovCuotas.CuotaNro and
		genCancMov.Asiento_Id_Ap = @ptesMovimientos and 
		genCancMov.CuotaNro_ap = 1
	UNION ALL
	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio, 
		genMovCuotas.CuotaNro,	genMovCuotas.Importe, genMovCuotas.Saldo, 
		Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri,
		conAsientos.conAsientos comMovProv, conCuentas.Cuenta_Id as Cuenta_Id, genCancMov.Importe ImporteHabilitado,
		isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
			tesRengMovi.TesMovimientos = genCancMov.Asiento_Id_Ap and 
			tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
			tesRengMovi.conRenglon = conMovCont1.Renglon and 
			conMovCont.Cuenta_id = conMovCont1.Cuenta_id),1)  as CambioPago,
			comMovProv.Fecha_CCP, conMovCont.Clase
	From genAsiSegmentos 
	INNER JOIN comMovprov ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovprov.comMovprov
	inner JOIN genMovCuotas ON genMovCuotas.Asiento_id = conAsientos.conAsientos
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND
		conMovCont.Clase = 'PRO'
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comMovTipos ON
	comMovTipos.Tipomov = comMovprov.Tipomov
	INNER JOIN genCancMov ON genCancMov.Asiento_Id = conAsientos.conAsientos and 
		genCancMov.CuotaNro = genMovCuotas.CuotaNro and
		genCancMov.Asiento_Id_Ap = @ptesMovimientos and 
		genCancMov.CuotaNro_ap = 1
	WHERE
		Not EXISTS(SELECT 1 FROM conMovCont c1 where 
		c1.conAsientos = conAsientos.conAsientos AND 
		c1.Clase = 'ANTPR')
			


end

-- TODO PUEDO COBRAR A UN PROVEEDOR QUE NO TENGA SALDO A FAVOR?
-- AntProveedores
-- Anticipos a Proveedores

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta
From tesRengMovi 
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon = tesRengMovi.conRenglon and 
	conMovCont.Clase = 'ANTPR'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id
Where 
tesRengMovi.TesMovimientos =  @pTesMovimientos and 
conAsientos.Anulado = 0 and 
conAsientos.Posteado = 1

-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

Exec tesMoviGravadoDatos @ptesMovimientos

RETURN @@Error 

GO
