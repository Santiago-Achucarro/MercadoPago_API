-- tesPagosProvDatos 1, 'TES',30765,0,0,0,'E','MXL',' ',' ','PM0299'

DROP PROCEDURE tesPagosProvDatos
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesPagosProvDatos
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
	@pMoneda_Id varChar(3) = null

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


IF (@ptesMovimientos IS NULL)
Begin

	-- TODO SALDOS INICIALES
	-- Cobranzas y/o Pagos a Clientes
	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda, conAsientos.Cambio, genMovCuotas.CuotaNro,
	genMovCuotas.Importe, genMovCuotas.Saldo,
	Convert(Numeric(18,2), genMovCuotas.Saldo*conAsientos.Cambio) As SaldoOri,
	conAsientos.conAsientos, conCuentas.Cuenta_Id, comPagosHabilitados.ImporteHabilitado, 
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @Empresa_Id) As CambioPago,
	comPagosHabilitados.Importe1, comPagosHabilitados.Importe2, comPagosHabilitados.Importe3, comPagosHabilitados.FechaHabilitacion,
	comPagosHabilitados.Secuencia, comMovProv.Fecha_CCP
	FROM comMovProv
	INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
	Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
	Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'PRO'
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	Inner Join genMovCuotas On genMovCuotas.Asiento_Id = comMovProv.comMovProv
	Inner JOIN comPagosHabilitados ON comMovProv.comMovProv = comPagosHabilitados.comMovProv
	--Inner JOIN genUsuarios  ON (genUsuarios.genUsuarios = comPagosHabilitados.Usuario_Id)
	WHERE comMovProv.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id) And comPagosHabilitados.tesMovimientos Is Null
	And conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)




end

else
Begin

	SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		comMovProv.comMovProv,
		genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, conAsientos.Cambio as Cambio, genMovCuotas.CuotaNro,
		genMovCuotas.Importe, genMovCuotas.Saldo, Convert(Numeric(18,2),genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri,
		conAsientos.conAsientos, conCuentas.Cuenta_Id, IsNull(comPagosHabilitados.ImporteHabilitado, genCancMov.Importe) ImporteHabilitado,
		isnull((select max(tesRengMovi.Cambio) from tesRengMovi, conMovCont conMovCont1 WHERE
			tesRengMovi.TesMovimientos = genCancMov.Asiento_Id_Ap and 
			tesRengMovi.TesMovimientos = conMovCont1.conAsientos AND 
			tesRengMovi.conRenglon = conMovCont1.Renglon and 
			conMovCont.Cuenta_id = conMovCont1.Cuenta_id),1)  as CambioPago,
		IsNull(comPagosHabilitados.Importe1, 0) Importe1, IsNull(comPagosHabilitados.Importe2, 0) Importe2, 
		IsNull(comPagosHabilitados.Importe3, 0) Importe3, IsNull(comPagosHabilitados.FechaHabilitacion, conAsientos.Fecha) FechaHabilitacion,
		IsNull(comPagosHabilitados.Secuencia, 1) Secuencia, comMovProv.Fecha_CCP, 
			conAsientos.Usuario_Id
	From genAsiSegmentos 
	INNER JOIN comMovprov ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovprov.comMovprov
	inner JOIN genMovCuotas ON genMovCuotas.Asiento_id = conAsientos.conAsientos
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos  AND
		conMovCont.Clase =	'PRO'
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comMovTipos ON
	comMovTipos.Tipomov = comMovprov.Tipomov
	INNER JOIN genCancMov ON genCancMov.Asiento_Id_ap = conAsientos.conAsientos and 
		genCancMov.CuotaNro_ap = genMovCuotas.CuotaNro and
		genCancMov.Asiento_Id = @ptesMovimientos and 
		genCancMov.CuotaNro = 1 and 
		genCancMov.EsAplicOriginal = 1
	left Join comPagosHabilitados On comPagosHabilitados.tesMovimientos = conAsientos.conAsientos And
										comPagosHabilitados.comMovProv = genCancMov.Asiento_Id 


end

-- AntProveedores
-- Anticipos a Proveedores

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, 0 as TipoCtaProv, ' ' as DescripcionProveedoresTipoPasivo,
	conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta, ' ' as Usuario_id, 
		 conAsientos.conAsientos as comPagosAnticipos ,conAsientos.conAsientos,
			' ' DescripcionUsuario ,   conAsientos.conAsientos as comEmbarques
From tesRengMovi 
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon = tesRengMovi.conRenglon and 
	conMovCont.Clase = 'ANTPR'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id
Where 
tesRengMovi.TesMovimientos =  @pTesMovimientos


-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos

Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

Exec tesMoviGravadoDatos @ptesMovimientos

-- AJ OCT 2018
SELECT comMovProv.VieneDeFiscal as ReqCompPago 
From comMovProv where comMovProv.comMovProv = @ptesMovimientos


-- FM Grilla de PDF generados por retenciones a proveedores --
Select '' PDF,
tesIdentifica.Cartera_Id + dbo.Segmento(tesRetProvSegmento.Segmento_Id, tesRetProvSegmento.Segmento1C, tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, 
tesRetProvSegmento.Segmento4C, tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, tesRetProvSegmento.Segmento4N) NombreArchivo,
tesRengMoviRetProv.tesMovimientos, tesRengMoviRetProv.conRenglon
From tesRengMoviRetProv
Inner Join tesRengMovi On tesRengMovi.tesMovimientos = tesRengMoviRetProv.tesMovimientos And tesRengMovi.conRenglon = tesRengMoviRetProv.conRenglon
Inner Join tesIdRetProv On tesIdRetProv.Cartera_Id = tesRengMovi.Cartera_Id
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesIdRetProv.Cartera_Id
Inner Join tesRetProvSegmento On tesRetProvSegmento.tesMovimientos = tesRengMovi.tesMovimientos And tesRetProvSegmento.conRenglon = tesRengMovi.conRenglon
Where tesRetProvSegmento.tesMovimientos = @ptesMovimientos
RETURN @@Error 

GO


