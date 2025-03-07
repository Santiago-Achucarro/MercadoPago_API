DROP PROCEDURE INF_venPediCabe 
GO
CREATE PROCEDURE INF_venPediCabe  (
    @Empresa_Id int, 
    @Segmento_Id VarChar(10), 
    @Segmento1N int,
    @Segmento2N int,
    @Segmento3N int,
    @Segmento4N int,
    @Segmento1C VarChar(20),
    @Segmento2C VarChar(20),
    @Segmento3C VarChar(20),
    @Segmento4C VarChar(20)

    )

    AS
    SELECT venPediSegmentos.venPedidos, 
    dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C,
    venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, 
    venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, 
    venPediSegmentos.Segmento4N) AS SegmentoStr, 
    genSegmentos.Segmento_Id, venPediSegmentos.Segmento1C,
    venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, 
    venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N, 
    venPedidos.Fecha, venPedidos.Fecha_Registro , venPedidos.Cambio,
    venClientes.Cliente_Id, venClientes.RazonSocial, genEntidades.Cuit,
    venClieHabitual.NombreFantasia, venClieHabitual.Direccion1_Fact, 
    venClieHabitual.NroExterior_Fact, venClieHabitual.NroInterior_Fact,
    venClieHabitual.Direccion2_Fact, venClieHabitual.Localidad_Fact, 
    venClieHabitual.CodPostal_Fact, genProvincias.Provincia_Id AS Provincia_Id_Fact,
    genProvincias.Descripcion AS DescripcionProvincia_Id_Fact, genProvincias.CodFiscal AS CodFiscalProv,
    genPaises.Pais_Id AS Pais_Id_Fact, genPaises.Descripcion AS DescripcionPais_Id,
	genPaises.CodFiscal AS CodFiscalPais, 
	venClieHabitual.Direccion1_Entr, 
    venClieHabitual.NroExterior_Entr, venClieHabitual.NroInterior_Entr,
    venClieHabitual.Direccion2_Entr, venClieHabitual.Localidad_Entr, 
    venClieHabitual.CodPostal_Entr, genProvinciasE.Provincia_Id AS Provincia_Id_Entr,
    genProvinciasE.Descripcion AS DescripcionProvincia_Id_Entr, genProvinciasE.CodFiscal AS CodFiscalProvEntr,
    genPaisesE.Pais_Id AS Pais_Id_Entr, genPaisesE.Descripcion AS DescripcionPais_Id_Entr,
    venSubTipoMov.SubTipoMov_Id, 
    venSubTipoMov.Descripcion AS DescripcionSubTipoMov,
    venPedidos.ImporteTotal AS Importe, venPedidos.Observaciones, 
    venPedidos.UsoCfdi, venPedidos.MetodoPago AS FormaPago, EntidadBasica.Descripcion as DescripcionFormaPago,
    /*venPedidos.TipoProceso, venPedidos.TipoComite, venPedidos.idContabilidad,*/
    genMonedas.Moneda_Id, genMonedas.Descripcion AS DescripcionMoneda, 
    venCondPago.CondPagoCli_Id,       venCondPago.Descripcion DescripcionCondPago, ImporteTotal, SubTotal, 
    venPedidos.ImporteTotal - ISNULL((SELECT SUM(ROUND(venPediCuerpo.CantidadPedida *venPediCuerpo.PrecioVenta,2))
		from venpediCuerpo where venPediCuerpo.venPedidos = venPedidos.venPedidos),0) AS Impuestos, 
	venPedidos.Bonificacion1, 
    venPedidos.Bonificacion2, venPedidos.Bonificacion3, venPedidos.Bonificacion4, venPedidos.Bonificacion5,
	venPedidos.CliOrdenCompra, venPedidos.ImpOtCargos, venPedidos.DescOtrosCargos
    FROM venPediSegmentos
    INNER JOIN genSegmentos ON venPediSegmentos.Segmento_Id = genSegmentos.genSegmentos
    INNER JOIN venPedidos ON venPedidos.venPedidos = venPediSegmentos.venPedidos
    INNER JOIN genEntidades ON genEntidades.genEntidades =venPedidos.Cliente_Id 
    INNER JOIN venClientes ON venClientes.genEntidades = genEntidades.genEntidades 
    INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venPedidos.Cliente_Id and 
            venClieHabitual.Sucursal =venPedidos.Sucursal
    INNER JOIN genProvincias ON       genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
    INNER JOIN genPaises ON    genPaises.genPaises = venClieHabitual.Pais_Id_Fact
    INNER JOIN genProvincias genProvinciasE ON       genProvinciasE.genProvincias = venClieHabitual.Provincia_Id_Entr
    INNER JOIN genPaises genPaisesE ON    genPaisesE.genPaises = venClieHabitual.Pais_Id_Entr
    INNER JOIN venSubTipoMov ON       venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
    INNER JOIN genMonedas ON genMonedas.genMonedas = venPedidos.Moneda_Id
    /*left join genEntidadesBasicasValor NEntidadBasica on NEntidadBasica.Entidad_Id=7 and NEntidadBasica.Dominio_Id='MX' and NEntidadBasica.Clave=venPedidos.NMetodoPago*/
    LEFT JOIN genEntidadesBasicasValor EntidadBasica on EntidadBasica.Entidad_Id=6 and EntidadBasica.Dominio_Id='MX' and EntidadBasica.Clave=venPedidos.MetodoPago
    INNER JOIN venTipoMov on venTipoMov.venTipoMov=venSubTipoMov.venTipoMov
    INNER JOIN venCondFiscal On venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
    INNER JOIN venCondPago On venCondPago.venCondPago = venPedidos.CondPagoCli_Id
    WHERE
			venPediSegmentos.Empresa_Id = @Empresa_Id And
            genSegmentos.Segmento_Id =  @Segmento_Id and
            venPediSegmentos.Segmento1C = @Segmento1C and 
            venPediSegmentos.Segmento2C = @Segmento2C and 
            venPediSegmentos.Segmento3C = @Segmento3C and 
            venPediSegmentos.Segmento4C = @Segmento4C and 
            venPediSegmentos.Segmento1N = @Segmento1N and 
            venPediSegmentos.Segmento2N = @Segmento2N and  
            venPediSegmentos.Segmento3N = @Segmento3N and  
            venPediSegmentos.Segmento4N = @Segmento4N 


GO


DROP PROCEDURE INF_venPediCuerpo
GO
CREATE PROCEDURE INF_venPediCuerpo (
	@Empresa_Id int, 
	@Segmento_Id VarChar(10), 
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
	)
	AS
	SELECT venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		venPediCuerpo.CantidadPedida, venPediCuerpo.CantidadOriginal, 
		venPediCuerpo.PrecioForm, venPediCuerpo.PrecioLista, venPediCuerpo.PrecioVenta, 
		venPediCuerpo.Observaciones, venPediCuerpo.Bonificacion, 
		venPediCuerpo.CantidadPedida*venPediCuerpo.PrecioVenta SubTotal, venPediCuerpo.FechaEntrega
	FROM venPediCuerpo 
		INNER JOIN venPediSegmentos ON venPediCuerpo.venPedidos = venPediSegmentos.venPedidos
		INNER JOIN genSegmentos ON venPediSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON stkProductos.stkProductos = venPediCuerpo.Producto_Id
		INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
		INNER JOIN stkUniMed AS MedidaMov ON MedidaMov.stkUniMed = venPediCuerpo.Medida_Id
	WHERE
		venPediSegmentos.Empresa_Id = @Empresa_Id And
		genSegmentos.Segmento_Id =  @Segmento_Id and
		venPediSegmentos.Segmento1C = @Segmento1C and 
		venPediSegmentos.Segmento2C = @Segmento2C and 
		venPediSegmentos.Segmento3C = @Segmento3C and 
		venPediSegmentos.Segmento4C = @Segmento4C and 
		venPediSegmentos.Segmento1N = @Segmento1N and 
		venPediSegmentos.Segmento2N = @Segmento2N and  
		venPediSegmentos.Segmento3N = @Segmento3N and  
		venPediSegmentos.Segmento4N = @Segmento4N  
	ORDER BY 1

GO


