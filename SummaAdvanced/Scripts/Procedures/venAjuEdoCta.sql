DROP Procedure venAjuEdoCtaDatos
GO
Create Procedure venAjuEdoCtaDatos
(
	@pClienteDesde VarChar(15),
	@pClienteHasta VarChar(15),
	@pMonto Numeric(18,2) ,
	@pEmpresa_Id Int, 
	@pSucursalDesde VarChar(4),
	@pSucursalHasta VarChar(4)
)

AS


SELECT @pClienteDesde AS ClieDesde , ' ' as RazonSocialDesde, 
	@pClienteHasta as ClieHasta, ' ' as RazonSocialHasta, 
	@pMonto as Monto, ' ' as CuentaDebe, ' ' as DescripcionCtaDebe, 
	' ' as CuentaHaber, ' ' as DescripcionCtaHaber, 
	' ' as Centro1_Id , ' ' as DescripcionCentro1, 
	' ' as Centro2_Id , ' ' as DescripcionCentro2 , 
	'  'SucursalDesde, ' ' SucursalHasta, 
	' ' as Avance, 'N' AS Termino, 0 as Registro

	
SELECT venClientes.Cliente_Id, genMonedas.Moneda_Id, venTipoMov.Signo,
	venMovimientos.venMovimientos, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,  genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,  genAsiSegmentos.Segmento4N) AS SegmentoStr,
	venClientes.RazonSocial, 
	conAsientos.Fecha, genMovCuotas.CuotaNro, genMovCuotas.Importe*venTipoMov.Signo as Importe, 
	genMovCuotas.Saldo*venTipoMov.Signo as Saldo,
	conAsientos.Cambio, MIN(conCuentas.Cuenta_Id) Cuenta_Id
From venMovimientos INNER JOIN conAsientos ON
venMovimientos.venMovimientos = conAsientos.conAsientos
INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN venClientes ON
venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN genMovCuotas ON
genMovCuotas.Asiento_Id =conAsientos.conAsientos
INNER JOIN venSubTipoMov ON
DBO.FuncFKvenSubTipoMov(venSubTipoMov.SubTipoMov_Id) = venMovimientos.venSubTipoMov_Id
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And 
		conMovCont.Clase in( 'CLI','ANTCL')
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join venTipoMov on venTipoMov.venTipoMov=venMovimientos.venTipoMov
INNER JOIN genSucursalesEmpr ON
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Where
conAsientos.Anulado = 0 and 
genAsiSegmentos.Empresa_Id = @pEmpresa_Id  and 
venClientes.Cliente_Id Between @pClienteDesde AND @pClienteHasta AND 
ABS(genMovCuotas.Saldo*conAsientos.Cambio) <= @pMonto  and 
ABS(genMovCuotas.Saldo*conAsientos.Cambio) > 0  and 
genSucursalesEmpr.Sucursal between @pSucursalDesde and @pSucursalHasta
GROUP BY venClientes.Cliente_Id, genMonedas.Moneda_Id, venTipoMov.Signo,
	venMovimientos.venMovimientos, 
	genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,  genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,  genAsiSegmentos.Segmento4N,
	venClientes.RazonSocial, 
	conAsientos.Fecha, genMovCuotas.CuotaNro, genMovCuotas.Importe,venTipoMov.Signo , 
	genMovCuotas.Saldo,	conAsientos.Cambio
order by  1,2,3,5
GO
 