DROP PROCEDURE venPedidosConsultaDrillDown
GO
CREATE PROCEDURE venPedidosConsultaDrillDown
(
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
As

Declare @lIdentity int = (select venPedidos from venPediSegmentos
	Where
	venPediSegmentos.Empresa_id = @pEmpresa_id and 
	venPediSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	venPediSegmentos.Segmento1N = @pSegmento1N and 
	venPediSegmentos.Segmento2N = @pSegmento2N and 
	venPediSegmentos.Segmento3N = @pSegmento3N and 
	venPediSegmentos.Segmento4N = @pSegmento4N and 
	venPediSegmentos.Segmento1C = @pSegmento1C and 
	venPediSegmentos.Segmento2C = @pSegmento2C and 
	venPediSegmentos.Segmento3C = @pSegmento3C and 
	venPediSegmentos.Segmento4C = @pSegmento4C)

SELECT venPedidos.venPedidos, venPediSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N,
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C,
	venPediSegmentos.Segmento4C, 
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) Segmento,
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, venPedidos.Fecha,
	venClientes.Cliente_Id, venPedidos.Sucursal, venClieHabitual.NombreFantasia, genMonedas.Moneda_Id,
	genMonedas.Descripcion as DescripcionMonedas, genMonedasFact.Moneda_Id MonedaFacturacion, genMonedas.Descripcion DescripcionMonFacturacion,
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, venVendedores.Vendedor_Id, 
	venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, venPedidos.Estado,
	genUsuarioAutoriz.Usuario_Id UsuarioAutoriz_Id, genUsuarioAutoriz.Apellido_y_Nombres as DescripcionUsuarioAutoriz,
	venPedidos.FechaAutorizo, venPedidos.Observaciones,
	venPedidos.ObservEstado, venPedidos.Motivo_Id, venPedidos.ImporteTotal, venPedidos.Bonificacion1,
	venPedidos.Bonificacion2, venPedidos.Bonificacion3, venPedidos.Bonificacion4, venPedidos.Bonificacion5,
	venPedidos.Dato1, venPedidos.Dato2, venPedidos.Dato3, venPedidos.FechaUltMod,
	venPedidos.CliOrdenCompra, venPedidos.venNroPedido, venPedidos.FacturaAnticipo, venPedidos.TrabaDespacho,
	venPedidos.PorAnticipo, venPedidos.Anticipo, venPedidos.AnticipoPendiente, venPedidos.ObsAnticipo,
	venPedidos.TipoPrecioForm, venPedidos.CongelaCambio, venPedidos.Fecha_Registro, venPedidos.Cambio,
	venIncoterm.Incoterm_Id, venIncoterm.Descripcion as DescripcionIncoterm, venPedidos.SoloEntrega,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venPedidos.Posteado, 
	venPedidos.MetodoPago , venpedidos.UsoCfdi, UsosCfdi.Descripcion as DescripcionUsoCfdi, 
	Metodos.Descripcion as DescripcionMetodoPago, venPedidos.SubTotal, venPedidos.SubTotalBonif,
	genSucursalesEmpr.Sucursal SucursalUsu
FROM venPedidos 
INNER JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id)
LEFT JOIN venClieHabitual  ON (venClieHabitual.genEntidades = venPedidos.Cliente_Id) AND (venClieHabitual.Sucursal = venPedidos.Sucursal)
Left Join venClientes On venPedidos.Cliente_Id = venClientes.genEntidades
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venPedidos.Moneda_Id)
Left Join genMonedas genMonedasFact On genMonedasFact.genMonedas = venPedidos.MonedaFacturacion
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venPedidos.CondPagoCli_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venPedidos.ListaPrecio_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venPedidos.Vendedor_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id)
LEFT JOIN genUsuarios genUsuarioAutoriz  ON (genUsuarioAutoriz.genUsuarios = venPedidos.UsuarioAutoriz_Id)
LEFT JOIN venIncoterm  ON (venIncoterm.venIncoterm_int = venPedidos.Incoterm_Id)
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = venPedidos.Usuario_Id)
INNER JOIN venPediSegmentos ON venPediSegmentos.venPedidos = venPedidos.venPedidos
INNER JOIN genSegmentos ON venPediSegmentos.Segmento_Id = genSegmentos.genSegmentos
LEFT JOIN genEntidadesBasicasValor as UsosCfdi ON
UsosCfdi.Entidad_Id = 4 AND 
UsosCfdi.Dominio_Id = 'MX' AND 
UsosCfdi.Clave = venPedidos.UsoCfdi
LEFT JOIN genEntidadesBasicasValor as Metodos ON
Metodos.Entidad_Id = 6 AND 
Metodos.Dominio_Id = 'MX' AND 
Metodos.Clave = venPedidos.MetodoPago
Left Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = venPedidos.SucursalUsu
WHERE venPedidos.venPedidos = @lIdentity

exec venPediCuerpoDatos  @lIdentity

Exec genAtributosGeneralesIdentityDatos @lIdentity, 'venPedidos'

-- Consulta de stock --
SELECT getdate() as Fecha, '' Producto_Id, '' Descripcion, 0.00 as Existencia, 
	0.00 as Compras, 0.00 as Embarques,	
		0.00 as Pedidos, 0.00 as TransitoLocal,
		0.00 as Final, '' as Deposito_Id

Select '' as Entidad_Id, '' as Descripcion, '' SegmentoSTR, 0.00 as Cantidad


-- Autorizaciones --
Select venNPAutorizando.venPedidos, venNPAutorizando.Secuencia, venNivelesAuto.NivelAuto_Id,
venNivelesAuto.Descripcion DescripcionNivelesAuto, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres DescripciongenUsuarios,
venNPAutorizando.Fecha, venNPAutorizando.TipoApro
From venNPAutorizando
Inner Join venNivelesAuto On venNivelesAuto.venNivelesAuto = venNPAutorizando.NivelAuto_Id
Inner Join genUsuarios On genUsuarios.genUsuarios = venNPAutorizando.Usuario_Id
Where venNPAutorizando.venPedidos = @lIdentity

-- Esquema --
Select venPedidos.venPedidos, venEsquemaAuto.EsquemaAuto_Id, venEsquemaAuto.Descripcion DescripcionEsquema 
From venPedidos
inner join venSubTipoMov ON venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
Left Join venEsquemaAuto On venEsquemaAuto.venEsquemaAuto = venSubTipoMov.EsquemaAuto_Id
Where venPedidos.venPedidos = @lIdentity
/*
Select MVendedor, MFormaE, MListaP, MBonifDato, MBonifReng, MPrecioReng From venPediValiComer Where venPedidos = @lIdentity
select 0.00 as Disponible, 0.00 as LimiteCredito
exec venPedidosPendClie ''
*/

-- Remitos --
Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Relacionado, 	
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venPediRemitidos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venPediRemitidos.stkMoviCabe
Inner Join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN conAsientos ON venPediRemitidos.stkMoviCabe = conAsientos.conAsientos
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
WHERE venPediRemitidos.venPedidos = @lIdentity And genMenus.Orden = '239010'
Union All
-- Facturas --
Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Relacionado,
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venMovConStockCrPed
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovConStockCrPed.venMovimientos
Inner Join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN conAsientos ON venMovConStockCrPed.venMovimientos = conAsientos.conAsientos
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
Where venMovConStockCrPed.venPedidos = @lIdentity And genMenus.Orden = '539910'
UNION 
Select Distinct dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Relacionado,
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venPediFacturados
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venPediFacturados.venMovimientos
Inner Join genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN conAsientos ON venPediFacturados.venMovimientos = conAsientos.conAsientos
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
Where venPediFacturados.venPedidos = @lIdentity And genMenus.Orden = '539910'
Union All
-- Repartos --
Select Distinct dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N,
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Relacionado,
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
From venRepaPedi
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venRepaPedi.venReparto
Inner Join genSegmentos ON genSegmentos.genSegmentos = venRepaSegmentos.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
Where venRepaPedi.venPedidos = @lIdentity And genMenus.Orden = '52103020' --##
Union All
-- Cotizaciones --
Select Distinct dbo.Segmento(venCotizSegmento.Segmento_Id, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C,
venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C, venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N,
venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N) Relacionado,
genSegmentos.Segmento_Id, disFormularios.Formulario_Id, disFormularios.Descripcion
FROM venCotizPedidos
INNER JOIN venCotizSegmento ON venCotizPedidos.Cotizacion_Id = venCotizSegmento.venCotizaciones
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = venCotizSegmento.Segmento_Id
Cross Join (genMenus Inner Join disFormularios On disFormularios.disFormularios = genMenus.Formulario_Id)
Where venCotizPedidos.Pedido_Id = @lIdentity And genMenus.Orden = '524010' --##

RETURN @@Error
GO
