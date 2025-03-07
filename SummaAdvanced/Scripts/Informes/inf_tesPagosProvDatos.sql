-- tesCobranzasDatos 1
Drop PROCEDURE inf_tesPagosProvDatos
Go
Create PROCEDURE inf_tesPagosProvDatos
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


SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
		genUsuarios.Apellido_y_Nombres as Usuario,
tesMovimientos.tesMovimientos, tesSubTiposMov.Tipomov, 
conAsientos.Fecha,conAsientos.FechaRegistro, genMonedas.Moneda_Id, 
	genMonedas.Descripcion as DescrpcionMoneda,  conAsientos.Cambio, 
	conAsientos.CambioMonedaOriginal, conAsientos.Anulado, 
	conAsientos.Observaciones, conAsientos.Posteado,
	disFormularios.Formulario_Id, disFormularios.Descripcion as DescripcionFormulario,
	tesSubTiposMov.SubTipo_Id, tesSubTiposMov.Descripcion as DescripcionSubTiposMov, 
	tesMovimientos.Fecha_Real, 
	venClientes.Cliente_Id, venClientes.RazonSocial as RazonSocialCliente,genEntidadesclie.Cuit CuitClie,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as RazonSocialProveedor,comProveedores.Direccion1, comProveedores.Direccion2,genProvincias.Descripcion as ProvinciaProv,
	genPaises.Descripcion as PaisProv,genEntidadesProv.Cuit CuitProv,
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
inner join genProvincias on genProvincias.genProvincias=comProveedores.Provincia_Id
inner join genPaises on genPaises.genPaises=comProveedores.Pais
LEFT OUTER JOIN genEntidades genEntidadesProv on genEntidadesProv.genEntidades = comProveedores.genEntidades
LEFT OUTER JOIN genEntidades genEntidadesClie on genEntidadesClie.genEntidades = venClientes.genEntidades
WHERE (tesMovimientos = @ptesMovimientos)


Go


