drop Procedure inf_tesMovimientosDHPrincipal
GO
Create Procedure inf_tesMovimientosDHPrincipal
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
	@Segmento4C VarChar(20)
)
AS

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id =@Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

-- Principal
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N) as SegmentoSTR,
tesMovimientos.tesMovimientos, tesSubTiposMov.Tipomov, 
conAsientos.Fecha,conAsientos.FechaRegistro, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescrpcionMoneda,  conAsientos.Cambio, 
	conAsientos.CambioMonedaOriginal, conAsientos.Anulado, 
	conAsientos.Observaciones, conAsientos.Posteado,
	disFormularios.Formulario_Id, disFormularios.Descripcion as DescripcionFormulario,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion as DescripcionSubTiposMov, 
	tesMovimientos.Fecha_Real, 
	venClientes.Cliente_Id, venClientes.RazonSocial as RazonSocialCliente,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as RazonSocialProveedor, genUsuarios.Apellido_y_Nombres as Usuario,
	Convert(Numeric(18,2), 0) as TotalDebe,
	Convert(Numeric(18,2), 0) as TotalHaber,
	Convert(Numeric(18,2), 0) as TotalHabilitado
FROM tesMovimientos 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = tesMovimientos.tesMovimientos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN tesSubTiposMov  ON (tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id)
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
LEFT OUTER JOIN (venMovimientos INNER JOIN venClientes ON
	venMovimientos.Cliente_Id = venClientes.genEntidades) ON 
	venMovimientos.venMovimientos = tesMovimientos.tesMovimientos
LEFT OUTER JOIN (comMovprov INNER JOIN comProveedores ON
	comMovprov.Proveed_Id = comProveedores.genEntidades) ON 
	comMovprov.comMovprov = tesMovimientos.tesMovimientos
inner join genUsuarios on conAsientos.Usuario_Id=genUsuarios.genUsuarios
WHERE (tesMovimientos = @ptesMovimientos)

go

drop Procedure inf_tesMovimientosDHProve
GO
Create Procedure inf_tesMovimientosDHProve
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
	@Segmento4C VarChar(20)
)
AS

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id =@Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

select comProveedores.Proveed_Id, comProveedores.RazonSocial, genEntidades.Cuit,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento4N) as SegmentoSTR, conAsientos.Fecha, Detalle, conCuentas.Cuenta_Id,
conCentro1.Centro1_Id, conCentro2.Centro2_Id, comMovDetalle.Importe from tesmovimientos


inner join tesRengMovicomMovProv on tesRengMovicomMovProv.tesMovimientos=tesMovimientos.tesMovimientos
inner join commovprov on tesRengMovicomMovProv.comMovProv=comMovProv.comMovProv
inner join commovdetalle on comMovDetalle.comMovProv=comMovProv.comMovProv
inner join comProveedores on comMovProv.Proveed_Id=comProveedores.genEntidades
inner join conCuentas on comMovDetalle.Cuenta_Id=conCuentas.conCuentas
left join conCentro1 on comMovDetalle.Centro1_Id=conCentro1.conCentro1
left join conCentro2 on conCentro2.conCentro2=comMovDetalle.Centro2_Id
inner join genEntidades on genEntidades.genEntidades=comProveedores.genEntidades
inner join conAsientos on conAsientos.conAsientos=comMovDetalle.comMovProv
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id= conAsientos.conAsientos
where tesMovimientos.tesMovimientos=@ptesMovimientos
union 
select comProveedores.Proveed_Id, comProveedores.RazonSocial, genEntidades.Cuit, 
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento4N), conAsientos.Fecha, conCuentas.Descripcion,
conCuentas.Cuenta_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, conMovCont.Importe from tesMovimientos
inner join tesRengMovicomMovProv on tesRengMovicomMovProv.tesMovimientos=tesMovimientos.tesMovimientos
inner join commovprov on tesRengMovicomMovProv.comMovProv=comMovProv.comMovProv
inner join comMovImpuestos on comMovImpuestos.comMovProv=comMovProv.comMovProv
inner join comProveedores on comMovProv.Proveed_Id=comProveedores.genEntidades
inner join conMovCont on conMovCont.conAsientos=comMovImpuestos.comMovProv and conMovCont.Renglon=comMovImpuestos.conRenglon
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas
left join conCentro1 on conMovCont.Centro1_Id=conCentro1.conCentro1
left join conCentro2 on conMovCont.Centro2_Id=conCentro2.conCentro2
inner join genEntidades on genEntidades.genEntidades=comProveedores.genEntidades
inner join conAsientos on conAsientos.conAsientos=conMovCont.conAsientos
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id= conAsientos.conAsientos
where tesMovimientos.tesMovimientos=@ptesMovimientos
go