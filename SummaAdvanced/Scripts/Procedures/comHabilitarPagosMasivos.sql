
-- comHabilitarPagosMasivosDatos ' ','ZZZ','PES','20200120',1

Drop procedure comHabilitarPagosMasivosDatos
Go

Create procedure comHabilitarPagosMasivosDatos
(
@pProveed_IdDesde varChar(15),
@pProveed_IdHasta varChar(15),
@pMoneda_Id varChar(5),
@pFechaHasta datetime,
@pEmpresa_Id int
)
As
Select @pProveed_IdDesde as ProveedorDesde,@pProveed_IdHasta as ProveedorHasta,  genMonedas.Moneda_Id, genMonedas.Descripcion,  0.00 as Total,@pFechaHasta as FechaHasta
From genMonedas where genMonedas.Moneda_Id = @pMoneda_Id




SELECT comProveedores.Proveed_Id,comProveedores.RazonSocial, comMovProv.comMovProv, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	genMonedas.Moneda_Id, genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo,
	Convert(Numeric(18,2), genMovCuotas.Saldo*conAsientos.Cambio) as SaldoOri, conAsientos.Cambio,
	1 Secuencia, 0 Usuario_Id, ' ' Apellido_y_Nombres, conCuentas.Cuenta_Id, comMovProv.TipoCtaProv, comMovProv.Fecha_CCP,
	ISNULL(comPagosHabilitados.FechaHabilitacion, dbo.FechaActual()) FechaHabilitacion, ISNULL(comPagosHabilitados.ImporteHabilitado, genMovCuotas.Saldo * 0) ImporteHabilitado, Cast(0 as bigint) tesMovimientos,
	dbo.func_TipoCambio(conCuentas.Moneda_Id, dbo.FechaActual(), @pEmpresa_Id) as CambioPago,
	genMovCuotas.Saldo * 0 Importe1, genMovCuotas.Saldo * 0 Importe2, genMovCuotas.Saldo * 0 Importe3, genMovCuotas.FechaVencimiento
FROM comMovProv
INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'PRO'
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
Inner Join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovprov.comMovprov
Inner Join genMovCuotas On genMovCuotas.Asiento_Id = comMovProv.comMovProv
INNER JOIN comProveedores on comProveedores.genEntidades= comMovProv.Proveed_Id
left JOIN comPagosHabilitados ON comMovProv.comMovProv = comPagosHabilitados.comMovProv and
		  comPagosHabilitados.tesMovimientos IS NULL
Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv 
WHERE comProveedores.Proveed_Id Between @pProveed_IdDesde and @pProveed_IdHasta 
And conAsientos.Empresa_Id = @pEmpresa_Id And conAsientos.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)
And genMovCuotas.Saldo > 0 And comMovTipos.Signo = -1
and genMovCuotas.FechaVencimiento <= @pFechaHasta
And tesRengMovicomMovProv.tesMovimientos Is Null
And conAsientos.Posteado = 1 And conAsientos.Anulado = 0
ORDER by  genMovCuotas.FechaVencimiento
Go




