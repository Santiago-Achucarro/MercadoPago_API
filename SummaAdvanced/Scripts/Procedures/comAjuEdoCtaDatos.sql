-- comAjuEdoCtaDatos ' ','ZZZZ', 6, 1
DROP Procedure comAjuEdoCtaDatos
GO
Create Procedure comAjuEdoCtaDatos
(
	@pProveeedDesde VarChar(15),
	@pProveeedHasta VarChar(15),
	@pMonto Numeric(18,2) ,
	@pEmpresa_Id Int
)

AS


SELECT @pProveeedDesde AS ProveeedDesde , ' ' as RazonSocialDesde, 
	@pProveeedHasta as ProveeedHasta, ' ' as RazonSocialHasta, 
	@pMonto as Monto, ' ' as CuentaDebe, ' ' as DescripcionCtaDebe, 
	' ' as CuentaHaber, ' ' as DescripcionCtaHaber, 
	' ' as Centro1_Id , ' ' as DescripcionCentro1, 
	' ' as Centro2_Id , ' ' as DescripcionCentro2 


SELECT comProveedores.Proveed_Id, genMonedas.Moneda_Id, comMovTipos.Signo,
	comMovProv.comMovProv, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,  genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,  genAsiSegmentos.Segmento4N) AS SegmentoStr,
	comProveedores.RazonSocial, 
	comMovprov.Fecha_CCP, genMovCuotas.CuotaNro, genMovCuotas.Importe*comMovTipos.Signo as Importe, 
	genMovCuotas.Saldo*comMovTipos.Signo as Saldo, 
	conAsientos.Cambio, conCuentas.Cuenta_Id
From comMovprov INNER JOIN conAsientos ON
comMovprov.comMovProv = conAsientos.conAsientos
INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN comProveedores ON
comProveedores.genEntidades = comMovprov.Proveed_Id
INNER JOIN genMovCuotas ON
genMovCuotas.Asiento_Id =conAsientos.conAsientos
INNER JOIN comMovTipos ON
comMovTipos.TipoMov = comMovprov.TipoMov
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And 
		conMovCont.Clase IN( 'PRO','ANTPR')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
Where
conAsientos.Anulado = 0 and 
genAsiSegmentos.Empresa_Id = @pEmpresa_Id  and 
comProveedores.Proveed_Id Between @pProveeedDesde AND @pProveeedHasta AND 
ABS(genMovCuotas.Saldo*conAsientos.Cambio) <= @pMonto  and 
genMovCuotas.Saldo*conAsientos.Cambio > 0 
order by  1,2,3,5
GO
 