--exec Inf_espvenClientesKSK 'A0001','A0001','','ZZZZZ','','ZZZZZZZZ',1


--los parametros son los filtros del informe
-- 1 sp
-- 2 common para crear el dataset a mano y al finla SIEMPRE TIENE QUE TENER DS
-- 3 eL NOMBRE DEL DATATABLE SIEMPRE SE DEBE LLAMAR PRINCIPAL
-- 4 El dataset tiene que tener los campos de los parametros es decir de los filtros
-- 5 ir al diseñador para hacer el formulario (los formularios de info siempre empiezan con rpt)
-- el combo del formulario que estas creando es tipo informe
-- buscas la dll de reportescomon de la empresa y nada mas
-- una vez que estas diseñando, le pones a todos la lupita

DROP PROCEDURE Inf_espvenClientesKSK
GO
CREATE PROCEDURE Inf_espvenClientesKSK
(
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@ZonaDesde VarChar(5),
	@ZonaHasta VarChar(5),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Posteados bit
)
AS	
SELECT venClientes.Cliente_Id, venClientes.RazonSocial, 
venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion DescCondF,
venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial DescFE,
venVendedores.Vendedor_Id, venVendedores.Nombre,
venZona.Zona_Id, venZona.Descripcion DescZona
FROM venClientes 
INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades 
INNER JOIN venCondFiscal ON venClientes.CondFisc_id = venCondFiscal.venCondFiscal
INNER JOIN venFormaEntrega ON venClieHabitual.FormaEntrega_Id = venFormaEntrega.venFormaEntrega
INNER JOIN venVendedores ON venClieHabitual.Vendedor_Id = venVendedores.venVendedores
INNER JOIN venZona ON venClieHabitual.Zona_Id = venZona.venZona
WHERE venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND
venVendedores.Vendedor_Id BETWEEN @VendedorDesde AND @VendedorHasta AND
venZona.Zona_Id BETWEEN @ZonaDesde AND @ZonaHasta AND
venClientes.Posteado = @Posteados
GO


