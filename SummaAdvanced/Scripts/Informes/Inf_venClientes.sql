	-- Inf_venClientes  1, ' ','ZZZ',' ','zzz'
DROP PROCEDURE Inf_venClientes 
GO
CREATE PROCEDURE Inf_venClientes 
(
	@Empresa Int, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15), 
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5)
)
AS

SELECT venClientes.Cliente_id, venClientes.RazonSocial, 
	venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, 
	genEntidades.Cuit, genEntidades.TipoDoc, genEntidades.IdFiscal,
	venCondPago.CondPagoCli_id, venCondPago.Descripcion as DescripcionCondPago, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionLP,
	venZona.Zona_Id, venZona.Descripcion AS DescripcionZona, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVend,
	venFormaEntrega.FormaEntrega_Id,  venFormaEntrega.RazonSocial as DescripcionFormaEntrega,
	venClientes.Posteado, venClieHabitual.Inactivo, venClientes.Empresa_Id,
	venClieHabitual.MetodoDePago, CASE WHEN venClieHabitual.MetodoDePago = '99' THEN 'PPD' ELSE 'PUE' END AS NMetodoPago, 
	venClientes.LimiteCredito, genMonedas.Moneda_Id, venClientes.Bonificacion1, 
	venClientes.Bonificacion2, venClientes.Bonificacion3,  venCondFiscal.CondFisc_Id, 
	venClieHabitual.Direccion1_Fact, venClieHabitual.NroExterior_Fact, 
	venClieHabitual.NroInterior_Fact, 	venClieHabitual.Direccion2_Fact, 
	venClieHabitual.Localidad_Fact, venClieHabitual.CodPostal_Fact, 
	genProvincias.Provincia_Id as Provincia_id_Fact, 
	genPaises.Pais_Id as Pais_Id_Fact, venCobradores.Cobrador_Id, 
	venClieHabitual.EMail, venClieHabitual.Telefonos , 
	isnull(conCentro1.Centro1_Id,'') Centro1_Id, isnull(conCentro1.Descripcion,'') DescripcionC1,
	isnull(conCentro2.Centro2_Id,'') Centro2_Id, isnull(conCentro2.Descripcion,'') Descripcion21,
	venClientes.Regimen
FROM venClientes 
INNER JOIN genEntidades ON genEntidades.genEntidades = venClientes.genEntidades
INNER JOIN venClieHabitual ON venClientes.genEntidades =  venClieHabitual.genEntidades
INNER JOIN venCondPago on venClieHabitual.CondPagoCli_id =  venCondPago.venCondPago 
INNER JOIN venListasPrecios ON venListasPrecios.venListasPrecios = venClieHabitual.ListaPrecio_Id
INNER JOIn venZona ON venZona.venZona = venClieHabitual.Zona_Id
INNER JOIN venVendedores ON venVendedores.venVendedores = venClieHabitual.Vendedor_Id
INNER JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venClieHabitual.FormaEntrega_Id
INNER JOIN genMonedas ON genMonedas.genMonedas =venClientes.MonedaLimCred
INNER JOIN venCondFiscal ON venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
INNER JOIN genPaises ON genPaises.genPaises = venClieHabitual.Pais_Id_Fact
INNER JOIN venCobradores ON venCobradores.venCobradores =  venClieHabitual.Cobrador_Id
LEFT JOIN conCentro1 ON conCentro1.conCentro1 = venClieHabitual.Centro1_Id
LEFT JOIN conCentro2 ON conCentro2.conCentro2 = venClieHabitual.Centro2_Id
WHERE
	@Empresa = ISNULL(venClientes.Empresa_Id,@Empresa) and 
	venClientes.Cliente_Id Between @ClienteDesde And @ClienteHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde And @VendedorHasta
ORDER BY 2

GO