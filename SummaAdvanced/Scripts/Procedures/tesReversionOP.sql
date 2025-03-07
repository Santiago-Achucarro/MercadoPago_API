--exec tesReversionOPDatos 1,'TES','E','0001',' ',' ',1,0,0,0
DROP Procedure tesReversionOPDatos
GO
Create Procedure tesReversionOPDatos
(

@Empresa_Id INT, 
@Segmento_Id Char(5),
@Segmento1C Char(25),
@Segmento2C Char(25),
@Segmento3C Char(25),
@Segmento4C Char(25),
@Segmento1N int,
@Segmento2N int,
@Segmento3N int,
@Segmento4N int

)
AS
SET NOCOUNT ON 
DECLARE @ptesMovimientos bigint

SELECT @pTesMovimientos = Asiento_Id FROM genAsiSegmentos 
	WHERE
		genAsiSegmentos.Empresa_Id = @Empresa_Id and 
		genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@Segmento_Id) AND
		genAsiSegmentos.Segmento1C = @Segmento1C AND 
		genAsiSegmentos.Segmento2C = @Segmento2C AND 
		genAsiSegmentos.Segmento3C = @Segmento3C AND 
		genAsiSegmentos.Segmento4C = @Segmento4C AND 
		genAsiSegmentos.Segmento1N = @Segmento1N AND 
		genAsiSegmentos.Segmento2N = @Segmento2N AND 
		genAsiSegmentos.Segmento3N = @Segmento3N AND 
		genAsiSegmentos.Segmento4N = @Segmento4N

-- Principal
EXECUTE tesMovimientosDatos @ptesMovimientos

-- Debe
Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
-- Haber
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

-- ConciliacDebe
Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
-- ConciliacHaber
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2

SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
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
		IsNull(comPagosHabilitados.Secuencia, 1) Secuencia, comMovProv.Fecha_CCP
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
	INNER JOIN genCancMov ON genCancMov.Asiento_Id = conAsientos.conAsientos and 
		genCancMov.CuotaNro = genMovCuotas.CuotaNro 
	INNER JOIN tesMoviReversa ON 
			tesMoviReversa.tesMoviReversa =genCancMov.Asiento_Id_Ap  AND 
			genCancMov.CuotaNro_ap = 1
	Left Join comPagosHabilitados On comPagosHabilitados.tesMovimientos = conAsientos.conAsientos And
										comPagosHabilitados.comMovProv = genCancMov.Asiento_Id
Where
	tesMoviReversa.tesMovimientos = @ptesMovimientos 



-- AntProveedores
-- Anticipos a Proveedores

SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, tesRengMovi.Cambio,
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,
	conAsientos.conAsientos, conCuentas.Cuenta_id as Cuenta_Id, 
		conCuentas.Descripcion as DescripcionCuenta, conAsientos.conAsientos as comPagosAnticipos ,
			conAsientos.conAsientos as comEmbarques
From tesRengMovi 
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
	conMovCont.Renglon = tesRengMovi.conRenglon and 
	conMovCont.Clase = 'ANTPR'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_Id
INNER JOIN tesMoviReversa ON
 tesMoviReversa.tesMoviReversa =	tesRengMovi.TesMovimientos
Where 
	tesMoviReversa.tesMovimientos	=  @pTesMovimientos	

-- Reversa
SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
tesMovimientos.tesMovimientos, conAsientos.Fecha
FROM tesMovimientos  inner join tesMoviReversa on
tesMovimientos.tesMovimientos = tesMoviReversa.tesMoviReversa
INNER JOIN conAsientos  ON (conAsientos.conAsientos = tesMovimientos.tesMovimientos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE 
	tesMoviReversa.tesMovimientos = @ptesMovimientos

-- TiposCambio
-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos


-- genAtributosGenerales
Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'


GO
