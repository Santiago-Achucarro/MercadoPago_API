DROP PROCEDURE venClientesSaldoIniDatos
GO
CREATE PROCEDURE venClientesSaldoIniDatos(
@ClienteDesde VarChar(15) ,
@ClienteHasta VarChar(15) , 
@pEmpresa_Id int
)

AS


SELECT @ClienteDesde as ClienteDesde, @ClienteHasta as ClienteHasta, @pEmpresa_Id as Empresa_Id, 
	' ' as  Archivo , 0 AS ClienteActual, ' ' Termino, ' ' Mensaje


SELECT venMovimientos.venMovimientos as Renglon, 
	venClientes.Cliente_Id, venClientes.RazonSocial,  venMovimientos.venMovimientos,
	conAsientos.Fecha,  venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion DescripcionTM, genSucursalesEmpr.Sucursal SucursalComp,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genMovCuotas.CuotaNro,  genMovCuotas.Importe, genMovCuotas.FechaVencimiento,venMovimientosFiscal.ClaveFiscal,
	conAsientos.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda,
	--conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
	venMovimientos.Sucursal,
	Cast(Case When Max(Comprob.Asiento_Id) Is Null Then 0 Else 1 End + Case When Max(Comprob_Ap.Asiento_Id) Is Null Then 0 Else 1 End As Bit) Aplicado
	From venMovimientos 
	inner join venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
		inner join conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
		INNER JOIN genEmpresas ON genEmpresas.genEmpresas =conAsientos.Empresa_Id
		INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
		INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
		inner join conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos and conMovCont.Clase IN ('CLI', 'ANTCL')
		--INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
		INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
		INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
		Inner Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
		left join venMovimientosFiscal on venMovimientosFiscal.venMovimientos=venMovimientos.venMovimientos
		Left Join genCancMov Comprob On Comprob.Asiento_Id = venMovimientos.venMovimientos
		Left Join genCancMov Comprob_Ap On Comprob_Ap.Asiento_Id_Ap = venMovimientos.venMovimientos
Where
	conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmvenClientesSaldoIni') and 
	conAsientos.Anulado = 0 AND 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id

Group By
venMovimientos.venMovimientos, 
	venClientes.Cliente_Id, venClientes.RazonSocial,  venMovimientos.venMovimientos,
	conAsientos.Fecha,  venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion, genSucursalesEmpr.Sucursal,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N), 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genMovCuotas.CuotaNro,  genMovCuotas.Importe, genMovCuotas.FechaVencimiento,venMovimientosFiscal.ClaveFiscal,
	conAsientos.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion,
	--conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
	venMovimientos.Sucursal
-- IMPUESTOS


SELECT venMovimientos.venMovimientos as Renglon, venImpuestos.Impuesto_Id, venImpuestos.Descripcion, 
	venMovImpuestos.BaseImponible, venMovImpuestos.Porcentaje, venMovImpuestos.Importe,
	venMovimientos.venMovimientos
	From venMovImpuestos 
	inner join conAsientos ON conAsientos.conAsientos = venMovImpuestos.venMovimientos
	INNER JOIN venMovimientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	inner join venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
	INNER JOIN venImpuestos ON venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
Where
	conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmvenClientesSaldoIni') and 
	conAsientos.Anulado = 0 AND 
	venClientes.Cliente_Id between @ClienteDesde and @ClienteHasta and 
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id

select ' ' as Cliente_Id

GO

