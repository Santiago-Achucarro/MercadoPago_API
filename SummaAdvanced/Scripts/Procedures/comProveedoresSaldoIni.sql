DROP PROCEDURE comProveedoresSaldoIniDatos
GO
CREATE PROCEDURE comProveedoresSaldoIniDatos(
@ProveedDesde VarChar(15) ,
@ProveedHasta VarChar(15) , 
@pEmpresa_Id int
)

AS


SELECT @ProveedDesde as ProveedDesde, @ProveedHasta as ProveedHasta, @pEmpresa_Id as Empresa_Id, 
	' ' as  Archivo 


SELECT comMovprov.comMovprov as Renglon, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial,  comMovprov.comMovprov,
	comMovprov.Fecha_CCP,  comMovprov.TipoMov, comMovTipos.Descripcion DescripcionTM, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoStr, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genMovCuotas.CuotaNro,  genMovCuotas.Importe, genMovCuotas.FechaVencimiento, 
	comMovProv.ClaveFiscal,
	conAsientos.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda,
	--conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
	comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion DescripcionTipoCtaProv,
	comMovProv.TipoCompFE, comMovProv.Base_Ganancias, 
	Cast(Case When Max(Comprob.Asiento_Id) Is Null Then 0 Else 1 End + Case When Max(Comprob_Ap.Asiento_Id) Is Null Then 0 Else 1 End As Bit) Aplicado
	From comMovProv 
	inner join comProveedores ON commovprov.Proveed_Id = comProveedores.genEntidades
		inner join conAsientos ON conAsientos.conAsientos = commovprov.commovprov
		INNER JOIN genEmpresas ON genEmpresas.genEmpresas =conAsientos.Empresa_Id
		INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
		INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
		inner join conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos and conMovCont.Clase IN ('PRO', 'ANTPR')
		--INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
		INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
		INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = comMovprov.comMovProv
		Inner Join comProveedoresTipoPasivo On comProveedoresTipoPasivo.TipoCtaProv = comMovProv.TipoCtaProv
		Left Join genCancMov Comprob On Comprob.Asiento_Id = comMovProv.comMovProv
		Left Join genCancMov Comprob_Ap On Comprob_Ap.Asiento_Id_Ap = comMovProv.comMovProv

Where
	conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomProvSaldoIni') and 
	conAsientos.Anulado = 0 AND 
	comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id

Group By comMovprov.comMovprov, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial,  comMovprov.comMovprov,
	comMovprov.Fecha_CCP,  comMovprov.TipoMov, comMovTipos.Descripcion, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N), 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genMovCuotas.CuotaNro,  genMovCuotas.Importe, genMovCuotas.FechaVencimiento, 
	comMovProv.ClaveFiscal,
	conAsientos.Cambio, genMonedas.Moneda_Id, genMonedas.Descripcion,
	comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion,
	comMovProv.TipoCompFE, comMovProv.Base_Ganancias
-- IMPUESTOS


SELECT comMovprov.comMovprov as Renglon, comImpuestos.Impuesto_Id, comImpuestos.Descripcion, 
	comMovImpuestos.Base_Imponible, comMovImpuestos.Porcentaje, comMovImpuestos.Importe_Impuesto,
	comMovprov.comMovProv
	From comMovImpuestos inner join conAsientos ON
		conAsientos.conAsientos = comMovImpuestos.commovprov
		INNER JOIN comMovprov ON
		conAsientos.conAsientos = commovprov.commovprov
		inner join comProveedores ON
		commovprov.Proveed_Id = comProveedores.genEntidades
		INNER JOIN comImpuestos ON
		comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
		INNER JOIN genAsiSegmentos ON
		genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
Where
	conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmcomProvSaldoIni') and 
	conAsientos.Anulado = 0 AND 
	comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id


GO