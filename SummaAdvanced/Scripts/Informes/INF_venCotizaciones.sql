--exec INF_venCotizPrincipal 1,'VCOT',2,0,0,0,'0202','','',''
DROP PROCEDURE INF_venCotizPrincipal
GO
CREATE PROCEDURE INF_venCotizPrincipal  (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)

	AS

	

	Select venCotizSegmento.venCotizaciones, 
	dbo.Segmento(venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, 
	venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, 
	venCotizSegmento.Segmento4N) as SegmentoStr, 
	genSegmentos.Segmento_Id, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, 
	venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N, 
	venCotizaciones.Fecha, venCotizaciones.Fecha_Registro , venCotizaciones.Cambio,
	venClientes.Cliente_Id, ISNULL(venCotizCliente.RazonSocial, venClientes.RazonSocial) as RazonSocial, 
	ISNULL(venCotizCliente.CUIT, genEntidades.Cuit) Cuit,
	ISNULL(venCotizCliente.RazonSocial, venClieHabitual.NombreFantasia) as NombreFantasia , 
	ISNULL(venCotizCliente.Direccion1, venClieHabitual.Direccion1_Fact) Direccion1_Fact, 
	ISNULL(venCotizCliente.NroExterior, venClieHabitual.NroExterior_Fact) NroExterior_Fact,
	ISNULL(venCotizCliente.NroInterior, venClieHabitual.NroInterior_Fact) NroInterior_Fact,
	ISNULL(venCotizCliente.Direccion2, venClieHabitual.Direccion2_Fact ) as Direccion2_Fact, 
	ISNULL(venCotizCliente.Localidad, venClieHabitual.Localidad_Fact) Localidad_Fact, 
	ISNULL(venCotizCliente.CodigoPostal, venClieHabitual.CodPostal_Fact) CodPostal_Fact, 
	ISNULL(genProvinciasE.Provincia_Id, genProvincias.Provincia_Id) AS Provincia_Id_Fact,
	ISNULL(genProvinciasE.Descripcion, genProvincias.Descripcion) AS DescripcionProvincia_Id_Fact, 
	ISNULL(genProvinciasE.CodFiscal, genProvincias.CodFiscal) as CodFiscalProv,
	ISNULL(genPaisesE.Pais_Id, genPaises.Pais_Id) as Pais_Id_Fact, 
	ISNULL(genPaisesE.Descripcion, genPaises.Descripcion) as DescripcionPais_Id,
	ISNULL(genPaisesE.CodFiscal, genPaises.CodFiscal) as CodFiscalPais, 
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov,
	venCotizaciones.ImporteTotal as Importe, venCotizaciones.Observaciones, 
	venCotizaciones.UsoCfdi, 
	venCotizaciones.MetodoPago as FormaPago, EntidadBasica.Descripcion as DescripcionFormaPago,
	/*venCotizaciones.TipoProceso, venCotizaciones.TipoComite, venCotizaciones.idContabilidad,*/
	genMonedas.Moneda_Id, genMonedas.Descripcion AS DescripcionMoneda, 
		venCondPago.CondPagoCli_Id,	venCondPago.Descripcion DescripcionCondPago, ImporteTotal,
		venCotizaciones.Bonificacion1, venCotizaciones.Bonificacion2, venCotizaciones.Bonificacion3, 
		venCotizaciones.Bonificacion4, venCotizaciones.Bonificacion5, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as NombreUsuarios, 
		genUsuarios.Email as EMailUsuario, venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVendedor, 
		venCotizaciones.Vigencia, venClieHabitual.EMail as MailCliente, 
		venClieHabitual.Telefonos as TelefonoCliente,
		ROUND (venCotizaciones.ImporteTotal-sum(Impuestos.CantidadPedida * Impuestos.PrecioVenta),2)as Impuestos
	From venCotizSegmento
	inner join venCotizCuerpo as Impuestos on Impuestos.Cotizacion_Id=venCotizSegmento.venCotizaciones
	Inner join genSegmentos on venCotizSegmento.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN venCotizaciones ON venCotizaciones.venCotizaciones = venCotizSegmento.venCotizaciones
	INNER JOIN genEntidades ON genEntidades.genEntidades =venCotizaciones.Cliente_Id 
	Inner join venClientes ON venClientes.genEntidades = genEntidades.genEntidades 
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venCotizaciones.Cliente_Id and 
		venClieHabitual.Sucursal =venCotizaciones.Sucursal
	INNER JOIN genProvincias ON	genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
	INNER JOIN genPaises ON	genPaises.genPaises = venClieHabitual.Pais_Id_Fact
	INNER JOIN venSubTipoMov ON	venSubTipoMov.venSubTipoMov = venCotizaciones.SubTipoMov_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = venCotizaciones.Moneda_Id
	/*left join genEntidadesBasicasValor NEntidadBasica on NEntidadBasica.Entidad_Id=7 and NEntidadBasica.Dominio_Id='MX' and NEntidadBasica.Clave=venCotizaciones.NMetodoPago*/
	left join genEntidadesBasicasValor EntidadBasica on EntidadBasica.Entidad_Id=6 and EntidadBasica.Dominio_Id='MX' and EntidadBasica.Clave=venCotizaciones.MetodoPago
	inner join venTipoMov on venTipoMov.venTipoMov=venSubTipoMov.venTipoMov
	Inner Join venCondFiscal On venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
	Inner Join venCondPago On venCondPago.venCondPago = venCotizaciones.CondPagoCli_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores = venCotizaciones.Vendedor_Id
	inner join genUsuarios ON  genUsuarios.genUsuarios = venCotizaciones.Usuario_Id
	LEFT join (venCotizCliente  INNER JOIN genProvincias genProvinciasE ON 
		genProvinciasE.genProvincias = venCotizCliente.Provincia_Id
		INNER JOIN genPaises genPaisesE ON genPaisesE.genPaises = venCotizCliente.Pais_Id)
		ON  venCotizCliente.Cotizacion_Id = venCotizaciones.venCotizaciones
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		venCotizSegmento.Segmento1C = @pSegmento1C and 
		venCotizSegmento.Segmento2C = @pSegmento2C and 
		venCotizSegmento.Segmento3C = @pSegmento3C and 
		venCotizSegmento.Segmento4C = @pSegmento4C and 
		venCotizSegmento.Segmento1N = @pSegmento1N and 
		venCotizSegmento.Segmento2N = @pSegmento2N and  
		venCotizSegmento.Segmento3N = @pSegmento3N and  
		venCotizSegmento.Segmento4N = @pSegmento4N 
			group by 
		  venCotizSegmento.venCotizaciones, 
	dbo.Segmento(venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, 
	venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, 
	venCotizSegmento.Segmento4N) , 
	genSegmentos.Segmento_Id, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, 
	venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N, 
	venCotizaciones.Fecha, venCotizaciones.Fecha_Registro , venCotizaciones.Cambio,
	venClientes.Cliente_Id, ISNULL(venCotizCliente.RazonSocial, venClientes.RazonSocial), 
	ISNULL(venCotizCliente.CUIT, genEntidades.Cuit),
	ISNULL(venCotizCliente.RazonSocial, venClieHabitual.NombreFantasia) , 
	ISNULL(venCotizCliente.Direccion1, venClieHabitual.Direccion1_Fact) , 
	ISNULL(venCotizCliente.NroExterior, venClieHabitual.NroExterior_Fact),
	ISNULL(venCotizCliente.NroInterior, venClieHabitual.NroInterior_Fact),
	ISNULL(venCotizCliente.Direccion2, venClieHabitual.Direccion2_Fact ) , 
	ISNULL(venCotizCliente.Localidad, venClieHabitual.Localidad_Fact) , 
	ISNULL(venCotizCliente.CodigoPostal, venClieHabitual.CodPostal_Fact) , 
	ISNULL(genProvinciasE.Provincia_Id, genProvincias.Provincia_Id) ,
	ISNULL(genProvinciasE.Descripcion, genProvincias.Descripcion), 

	ISNULL(genProvinciasE.CodFiscal, genProvincias.CodFiscal) ,
	ISNULL(genPaisesE.Pais_Id, genPaises.Pais_Id), 
	ISNULL(genPaisesE.Descripcion, genPaises.Descripcion),
	ISNULL(genPaisesE.CodFiscal, genPaises.CodFiscal), 
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion ,
	venCotizaciones.ImporteTotal, venCotizaciones.Observaciones, 
	venCotizaciones.UsoCfdi, 
	venCotizaciones.MetodoPago , EntidadBasica.Descripcion ,
	/*venCotizaciones.TipoProceso, venCotizaciones.TipoComite, venCotizaciones.idContabilidad,*/
	genMonedas.Moneda_Id, genMonedas.Descripcion , 
		venCondPago.CondPagoCli_Id,	venCondPago.Descripcion , ImporteTotal,
		venCotizaciones.Bonificacion1, venCotizaciones.Bonificacion2, venCotizaciones.Bonificacion3, 
		venCotizaciones.Bonificacion4, venCotizaciones.Bonificacion5, 
		genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, 
		genUsuarios.Email , venVendedores.Vendedor_Id, venVendedores.Nombre , 
		venCotizaciones.Vigencia, venClieHabitual.EMail, 
		venClieHabitual.Telefonos 

GO


DROP PROCEDURE INF_venCotizCuerpo
GO
CREATE PROCEDURE INF_venCotizCuerpo (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)


	AS

	SELECT venCotizCuerpo.Renglon_Co, stkProductos.Producto_Id, stkProductos.UrlProd,
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		venCotizCuerpo.CantidadPedida, venCotizCuerpo.CantidadOriginal, 
		venCotizCuerpo.PrecioForm, venCotizCuerpo.PrecioLista, venCotizCuerpo.PrecioVenta, 
		venCotizCuerpo.Observaciones, 
		venCotizCuerpo.CantidadPedida*venCotizCuerpo.PrecioVenta SubTotal,
		stkDepositos.Deposito_Id
		
	from venCotizCuerpo inner join venCotizSegmento ON
		venCotizCuerpo.Cotizacion_Id = venCotizSegmento.venCotizaciones
		INNER JOIN genSegmentos ON 
		venCotizSegmento.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venCotizCuerpo.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venCotizCuerpo.Medida_Id
		inner join stkDepositos ON stkDepositos.stkDepositos = venCotizCuerpo.Deposito_Id
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		venCotizSegmento.Segmento1C = @pSegmento1C and 
		venCotizSegmento.Segmento2C = @pSegmento2C and 
		venCotizSegmento.Segmento3C = @pSegmento3C and 
		venCotizSegmento.Segmento4C = @pSegmento4C and 
		venCotizSegmento.Segmento1N = @pSegmento1N and 
		venCotizSegmento.Segmento2N = @pSegmento2N and  
		venCotizSegmento.Segmento3N = @pSegmento3N and  
		venCotizSegmento.Segmento4N = @pSegmento4N  
	ORDER BY 1

GO


DROP PROCEDURE INF_venCotizExpedi
GO
CREATE PROCEDURE INF_venCotizExpedi (
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)

	)
	as
	

SELECT genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion, genSucursalesEmpr.Serie,
		genSucursalesEmpr.Direccion, genSucursalesEmpr.Localidad, 
		genProvincias.Provincia_Id,genProvincias.Descripcion as DescripcionProvincia,
		genPaises.Pais_Id, genPaises.Descripcion as DescripcionPais,
		genSucursalesEmpr.CodigoPostal
		FROM venCotizaciones INNER JOIN venCotizSegmento ON 	venCotizSegmento.venCotizaciones= venCotizaciones.venCotizaciones
		INNER JOIN genUsuarios ON genUsuarios.genUsuarios = venCotizaciones.Usuario_Id
		LEFT JOIN genUsuariosSucursal ON genUsuariosSucursal.Usuario_Id = genUsuarios.genUsuarios AND 
					genUsuariosSucursal.Empresa_Id = venCotizaciones.Empresa_Id
		INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = ISNULL(genUsuariosSucursal.Sucursal_Id, genUsuarios.Sucursal)
		INNER JOIN genSegmentos ON genSegmentos.genSegmentos = venCotizSegmento.Segmento_Id
		INNER JOIN genProvincias ON  genProvincias.genProvincias = genSucursalesEmpr.Provincia_Id 
		INNER JOIN genPaises ON  genPaises.genPaises = genSucursalesEmpr.Pais_Id
		Where 
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		venCotizSegmento.Segmento1C = @pSegmento1C and 
		venCotizSegmento.Segmento2C = @pSegmento2C and 
		venCotizSegmento.Segmento3C = @pSegmento3C and 
		venCotizSegmento.Segmento4C = @pSegmento4C and 
		venCotizSegmento.Segmento1N = @pSegmento1N and 
		venCotizSegmento.Segmento2N = @pSegmento2N and  
		venCotizSegmento.Segmento3N = @pSegmento3N and  
		venCotizSegmento.Segmento4N = @pSegmento4N and
		venCotizSegmento.Empresa_Id = @pEmpresa_Id
		order by 2



