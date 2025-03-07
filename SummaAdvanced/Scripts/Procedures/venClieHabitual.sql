DROP PROCEDURE venClieHabitualGuardar
GO
CREATE PROCEDURE venClieHabitualGuardar
(
@pgenEntidades bigint,
@pSucursal SucursalN,
@pNombreFantasia varchar(120),
@pDireccion1_Fact varchar(50),
@pDireccion2_Fact varchar(50),
@pLocalidad_Fact varchar(35),
@pCodPostal_Fact CodigoPostal,
@pProvincia_Id_Fact varchar(5) = NULL,
@pPais_Id_Fact smallint = NULL,
@pTelefonos varchar(100),
@pFax varchar(50),
@pEMail varchar(50),
@pDireccion1_Entr varchar(50),
@pDireccion2_Entr varchar(50),
@pLocalidad_Entr varchar(35),
@pCodPostal_Entr CodigoPostal,
@pProvincia_Id_Entr varchar(5) = NULL,
@pPais_Id_Entr smallint = NULL,
@pTipoClie_Id varchar(5) = NULL,
@pListaPrecio_Id varchar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pCondPagoCli_Id varchar(5) = NULL,
@pVendedor_Id VarChar(5) = NULL,
@pCobrador_Id VarChar(5) = NULL,
@pZona_Id varchar(5) = NULL,
@pRegion_Id varchar(5) = NULL,
@pContactos varchar(50),
@pInactivo Sino,
@pUsuario_Id_Alta int,
@pFechaAlta qFecha,
@pFechaUltContacto qFecha,
@pFechaModificacion qFecha,
@pObservaciones QMemo = NULL,
@pBonificacion1 qPorcentaje,
@pBonificacion2 qPorcentaje,
@pBonificacion3 qPorcentaje,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pClieConsolida VarChar(15) = NULL,
@pNroExterior_Fact varchar(10),
@pNroInterior_Fact varchar(10),
@pNroExterior_Entr varchar(10),
@pNroInterior_Entr varchar(10),
@pReclamos varchar(150),
@pMetodoDePago varchar(50),
@pNumCuenta varchar(150),
@pC_UsoCFDI varchar(3),
@pN_MetodoPago varchar(3),
@pUsaComplementoINE bit,
@pLongitudGPS numeric(19,13),
@pLatitudGPS numeric(19,13), 
@pc_ColoniaEntr VarChar(4) = NULL, 
@pc_LocalidadEntr VarChar(4) = NULL,
@pc_MunicipioEntr VarChar(3) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venClieHabitual WHERE (genEntidades = @pgenEntidades) AND (Sucursal = @pSucursal)))
BEGIN 
	UPDATE venClieHabitual
	SET		NombreFantasia = @pNombreFantasia,
		Direccion1_Fact = @pDireccion1_Fact,
		Direccion2_Fact = @pDireccion2_Fact,
		Localidad_Fact = @pLocalidad_Fact,
		CodPostal_Fact = @pCodPostal_Fact,
		Provincia_Id_Fact = dbo.FuncFKgenProvincias(@pProvincia_Id_Fact),
		Pais_Id_Fact = dbo.FuncFKgenPaises(@pPais_Id_Fact),
		Telefonos = @pTelefonos,
		Fax = @pFax,
		EMail = @pEMail,
		Direccion1_Entr = @pDireccion1_Entr,
		Direccion2_Entr = @pDireccion2_Entr,
		Localidad_Entr = @pLocalidad_Entr,
		CodPostal_Entr = @pCodPostal_Entr,
		Provincia_Id_Entr = dbo.FuncFKgenProvincias(@pProvincia_Id_Entr),
		Pais_Id_Entr = dbo.FuncFKgenPaises(@pPais_Id_Entr),
		TipoClie_Id = dbo.FuncFKvenTiposClie(@pTipoClie_Id),
		ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		CondPagoCli_Id = dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		Cobrador_Id = dbo.FuncFKvenCobradores(@pCobrador_Id),
		Zona_Id = dbo.FuncFKvenZona(@pZona_Id),
		Region_Id = dbo.FuncFKvenRegion(@pRegion_Id),
		Contactos = @pContactos,
		Inactivo = @pInactivo,
		Usuario_Id_Alta = @pUsuario_Id_Alta,
		-- FechaAlta = @pFechaAlta,
		FechaUltContacto = @pFechaUltContacto,
		FechaModificacion = dbo.FechaActual(),
		Observaciones = @pObservaciones,
		Bonificacion1 = @pBonificacion1,
		Bonificacion2 = @pBonificacion2,
		Bonificacion3 = @pBonificacion3,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		ClieConsolida = dbo.FuncFKvenClientes(@pClieConsolida),
		NroExterior_Fact = @pNroExterior_Fact,
		NroInterior_Fact = @pNroInterior_Fact,
		NroExterior_Entr = @pNroExterior_Entr,
		NroInterior_Entr = @pNroInterior_Entr,
		Reclamos = @pReclamos,
		MetodoDePago = @pMetodoDePago,
		NumCuenta = @pNumCuenta,
		C_UsoCFDI =@pC_UsoCFDI,
		N_MetodoPago=@pN_MetodoPago,
		UsaComplementoINE=@pUsaComplementoINE,
		LatitudGPS=@pLatitudGPS,
		LongitudGPS=@pLongitudGPS, 
		c_ColoniaEntr  = @pc_ColoniaEntr,
		c_LocalidadEntr = @pc_LocalidadEntr,
		c_MunicipioEntr  = @pc_MunicipioEntr
	WHERE (genEntidades = @pgenEntidades) AND (Sucursal = @pSucursal)
END 
ELSE 
BEGIN 
	INSERT INTO venClieHabitual
	(
		genEntidades,
		Sucursal,
		NombreFantasia,
		Direccion1_Fact,
		Direccion2_Fact,
		Localidad_Fact,
		CodPostal_Fact,
		Provincia_Id_Fact,
		Pais_Id_Fact,
		Telefonos,
		Fax,
		EMail,
		Direccion1_Entr,
		Direccion2_Entr,
		Localidad_Entr,
		CodPostal_Entr,
		Provincia_Id_Entr,
		Pais_Id_Entr,
		TipoClie_Id,
		ListaPrecio_Id,
		FormaEntrega_Id,
		CondPagoCli_Id,
		Vendedor_Id,
		Cobrador_Id,
		Zona_Id,
		Region_Id,
		Contactos,
		Inactivo,
		Usuario_Id_Alta,
		FechaAlta,
		FechaUltContacto,
		FechaModificacion,
		Observaciones,
		Bonificacion1,
		Bonificacion2,
		Bonificacion3,
		Centro1_Id,
		Centro2_Id,
		ClieConsolida,
		NroExterior_Fact,
		NroInterior_Fact,
		NroExterior_Entr,
		NroInterior_Entr,
		Reclamos,
		MetodoDePago,
		NumCuenta,
		C_UsoCFDI,
		N_MetodoPago,
		UsaComplementoINE,
		LatitudGPS,
		LongitudGPS,
		c_ColoniaEntr , 
		c_LocalidadEntr,
		c_MunicipioEntr
	)
	VALUES 
	(
		@pgenEntidades,
		@pSucursal,
		@pNombreFantasia,
		@pDireccion1_Fact,
		@pDireccion2_Fact,
		@pLocalidad_Fact,
		@pCodPostal_Fact,
		dbo.FuncFKgenProvincias(@pProvincia_Id_Fact),
		dbo.FuncFKgenPaises(@pPais_Id_Fact),
		@pTelefonos,
		@pFax,
		@pEMail,
		@pDireccion1_Entr,
		@pDireccion2_Entr,
		@pLocalidad_Entr,
		@pCodPostal_Entr,
		dbo.FuncFKgenProvincias(@pProvincia_Id_Entr),
		dbo.FuncFKgenPaises(@pPais_Id_Entr),
		dbo.FuncFKvenTiposClie(@pTipoClie_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenCobradores(@pCobrador_Id),
		dbo.FuncFKvenZona(@pZona_Id),
		dbo.FuncFKvenRegion(@pRegion_Id),
		@pContactos,
		@pInactivo,
		@pUsuario_Id_Alta,
		dbo.FechaActual(),
		@pFechaUltContacto,
		dbo.FechaActual(),
		@pObservaciones,
		@pBonificacion1,
		@pBonificacion2,
		@pBonificacion3,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		dbo.FuncFKvenClientes(@pClieConsolida),
		@pNroExterior_Fact,
		@pNroInterior_Fact,
		@pNroExterior_Entr,
		@pNroInterior_Entr,
		@pReclamos,
		@pMetodoDePago,
		@pNumCuenta,
		@pC_UsoCFDI,
		@pN_MetodoPago,
		@pUsaComplementoINE,
		@pLongitudGPS,
		@pLatitudGPS, 
		@pc_ColoniaEntr , 
		@pc_LocalidadEntr,
		@pc_MunicipioEntr
	)
END 

GO

DROP PROCEDURE venClieHabitualDatos
GO
CREATE PROCEDURE venClieHabitualDatos
(
@pCliente_Id VarChar(15),
@pSucursal SucursalN
)
AS
SET NOCOUNT ON 

SELECT venClieHabitual.genEntidades, venClientes.Cliente_Id, 
	venClieHabitual.Sucursal, 
	 genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal, venClientes.Empresa_Id, 
	Cast (Case When venClientes.Empresa_Id IS NULL THEN 1 ELSE 0 END as BIT) AS PTodasEmpresas,
	venClientes.RazonSocial,
	venClientes.SucursalPredeter, 
	venCondFiscal.CondFisc_Id, 	venCondFiscal.Descripcion as DescripcionCondFiscal, 
	venClientes.LimiteCredito, genMonedas.Moneda_Id MonedaLimCred,
	venCategCredito.CategCred_Id, venCategCredito.Descripcion as DescripcionCategCredito,
	venClientes.Bonificacion1, venClientes.Bonificacion2, venClientes.Bonificacion3, 
	venClientes.Puntual,
	venClieEstados.Estado_Id, venClieEstados.Descripcion as DescripcionClieEstados, 
	venClientes.GeneraDebito, venClientes.Siempre,
	venClientes.CongelaCambio, venClientes.IBrutos, venClientes.Situacion,
	venClientes.FacturaCredito, venClientes.MontoFacturaCredito, venClientes.CbuBanco,
	venClieHabitual.NombreFantasia,
	venClieHabitual.Direccion1_Fact, venClieHabitual.Direccion2_Fact, venClieHabitual.Localidad_Fact, venClieHabitual.CodPostal_Fact,
	Provincia_Id_Fact.Provincia_Id as Provincia_Id_Fact, Provincia_Id_Fact.Descripcion as DescripcionProvincia_Id_Fact, 
	Pais_Id_Fact.Pais_Id as Pais_Id_Fact, Pais_Id_Fact.Descripcion as DescripcionPais_Id_Fact,
	venClieHabitual.Telefonos, venClieHabitual.Fax, venClieHabitual.EMail, venClieHabitual.Direccion1_Entr,
	venClieHabitual.Direccion2_Entr, venClieHabitual.Localidad_Entr, venClieHabitual.CodPostal_Entr, 
	Provincia_Id_Entr.Provincia_Id as Provincia_Id_Entr ,Provincia_Id_Entr.Descripcion as DescripcionProvincia_Id_Entr, 
	Pais_Id_Entr.Pais_Id as Pais_Id_Entr, Pais_Id_Entr.Descripcion as DescripcionPais_Id_Entr, 
	venTiposClie.TipoClie_Id,venTiposClie.Descripcion as DescripcionTiposClie, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, 
	venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega, 
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
	venVendedores.Vendedor_Id,venVendedores.Nombre as DescripcionVendedores, 
	venCobradores.Cobrador_Id, venCobradores.Nombre as DescripcionCobradores, 
	venZona.Zona_Id,	venZona.Descripcion as DescripcionZona, 
	venRegion.Region_Id, venRegion.Descripcion as DescripcionRegion, 
	venClieHabitual.Contactos,	venClieHabitual.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venClieHabitual.FechaAlta,
	venClieHabitual.FechaUltContacto, venClieHabitual.FechaModificacion, venClieHabitual.Observaciones, 
	venClieHabitual.Bonificacion1 AS BonificacionS1, venClieHabitual.Bonificacion2 AS  BonificacionS2, 
	venClieHabitual.Bonificacion3 AS BonificacionS3, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	ClieConsolida.Cliente_Id ClieConsolida, ClieConsolida.RazonSocial as DescripcionClieConsolida, 
	venClieHabitual.NroExterior_Fact, venClieHabitual.NroInterior_Fact,
	venClieHabitual.NroExterior_Entr, venClieHabitual.NroInterior_Entr, venClieHabitual.Reclamos, venClieHabitual.MetodoDePago,
	venClieHabitual.NumCuenta, genPaises.Dominio_Id, venClientes.Posteado, C_UsoCFDI,N_MetodoPago,UsaComplementoINE, venClientes.LimiteCredito,
	venClieHabitual.LatitudGPS, venClieHabitual.LongitudGPS,venClieHabitual.c_ColoniaEntr , venClieHabitual.c_LocalidadEntr,
		venClieHabitual.c_MunicipioEntr, venClientes.Regimen
FROM venClieHabitual 
INNER JOIN venClientes  ON (venClientes.genEntidades = venClieHabitual.genEntidades)
inner join genEntidades ON venClientes.genEntidades = genEntidades.genEntidades 
LEFT JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = venClientes.CondFisc_Id)
LEFT JOIN venCategCredito  ON (venCategCredito.venCategCredito = venClientes.CategCred_Id)
LEFT JOIN venClieEstados  ON (venClieEstados.venClieEstados = venClientes.Estado_Id)
LEFT JOIN genProvincias  as Provincia_Id_Fact ON (Provincia_Id_Fact.genProvincias = venClieHabitual.Provincia_Id_Fact)
LEFT JOIN genPaises  as Pais_Id_Fact ON (Pais_Id_Fact.genPaises = venClieHabitual.Pais_Id_Fact)
LEFT JOIN genProvincias Provincia_Id_Entr ON (Provincia_Id_Entr.genProvincias = venClieHabitual.Provincia_Id_Entr)
LEFT JOIN genPaises Pais_Id_Entr ON (Pais_Id_Entr.genPaises = venClieHabitual.Pais_Id_Entr)
LEFT JOIN venTiposClie  ON (venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venClieHabitual.ListaPrecio_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venClieHabitual.FormaEntrega_Id)
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venClieHabitual.CondPagoCli_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venClieHabitual.Vendedor_Id)
LEFT JOIN venCobradores  ON (venCobradores.venCobradores = venClieHabitual.Cobrador_Id)
LEFT JOIN venZona  ON (venZona.venZona = venClieHabitual.Zona_Id)
LEFT JOIN venRegion  ON (venRegion.venRegion = venClieHabitual.Region_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venClieHabitual.Usuario_Id_Alta)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = venClieHabitual.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = venClieHabitual.Centro2_Id)
LEFT JOIN venClientes   as ClieConsolida ON (ClieConsolida.genEntidades = venClieHabitual.ClieConsolida)
Left Join genPaises On venClieHabitual.Pais_Id_Fact = genPaises.genPaises
Left Join genMonedas On genMonedas.genMonedas = venClientes.MonedaLimCred
WHERE (venClientes.Cliente_Id = @pCliente_Id)
AND (venClieHabitual.Sucursal = @pSucursal)
 
 SELECT 	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	CuentaDxVtas.Cuenta_Id as CuentaDxVtas, CuentaDxVtas.Descripcion as DescripcionCuentaDxVtas, 
	CtaFactAnticipo.Cuenta_Id as CtaFactAnticipo, CtaFactAnticipo.Descripcion as DescripcionCtaFactAnticipo,
	CtaAnticipo.Cuenta_Id as CtaAnticipo , CtaAnticipo.Descripcion as DescripcionCtaAnticipo,
	venClientesCtas.ParaFactura, venClientesCtas.ParaPedidos
FROM venClientesCtas 
INNER JOIN venClientes  ON (venClientes.genEntidades = venClientesCtas.Cliente_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = venClientesCtas.Moneda_Id)
INNER JOIN conCuentas  as CuentaDxVtas ON (CuentaDxVtas.conCuentas = venClientesCtas.CuentaDxVtas)
INNER JOIN conCuentas CtaFactAnticipo ON (CtaFactAnticipo.conCuentas = venClientesCtas.CtaFactAnticipo)
INNER JOIN conCuentas CtaAnticipo ON (CtaAnticipo.conCuentas = venClientesCtas.CtaAnticipo)
WHERE (venClientes.Cliente_Id = @pCliente_Id)
order by 1 


Declare @pidentity bigint= dbo.FuncFKvenClientes(@pCliente_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venClientes'

exec genJurisCoeficientesDatos @pIdentity
exec venclieContactoDatos @pIdentity, @pSucursal
exec genAdjuntosIdentityDatos 'venClientes', 0
 
 RETURN @@Error 

GO

DROP PROCEDURE venClieHabitualEliminar
GO
CREATE PROCEDURE venClieHabitualEliminar
(
@pCliente_Id VarChar(15),
@pSucursal SucursalN = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venClieHabitual 
WHERE genEntidades = dbo.FuncFKvenClientes(@pCliente_Id)
AND Sucursal = ISNULL(@pSucursal, Sucursal)
 
 RETURN @@Error 

GO

GO
