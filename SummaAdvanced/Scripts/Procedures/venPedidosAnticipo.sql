-- venPedidosAnticipoDatos  1,'NP',2,0,0,0,'0001',' ',' ',' '
DROP PROCEDURE venPedidosAnticipoDatos
GO
CREATE PROCEDURE venPedidosAnticipoDatos
(

@pEmpresa_Id int, 
@pSegmento_id VarChar(10), 
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

 SELECT venPedidos.venPedidos, venPediSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N,
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C,
	venPediSegmentos.Segmento4C, 
	isnull(venSubTipoMov.SubTipoMov_Id,' ') AS SubTipoMov_Id, 
	isnull(venSubTipoMov.Descripcion,' ') as DescripcionSubTipoMov, venPedidos.Fecha,
	dbo.FechaActual() as FechaFactura, 
	venClientes.Cliente_Id, venPedidos.Sucursal, venClieHabitual.NombreFantasia, genMonedas.Moneda_Id,
	genMonedas.Descripcion as DescripcionMonedas, 
	genMonedasFact.Moneda_Id MonedaFacturacion, genMonedas.Descripcion DescripcionMonFacturacion,
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, venPedidos.Estado,
	genUsuarioAutoriz.Usuario_Id UsuarioAutoriz_Id, genUsuarioAutoriz.Apellido_y_Nombres as DescripcionUsuarioAutoriz,
	venPedidos.FechaAutorizo, venPedidos.Observaciones,
	venPedidos.ImporteTotal, 
	venPedidos.CliOrdenCompra, venPedidos.venNroPedido, 
	venPedidos.FacturaAnticipo, venPedidos.PorAnticipo, venPedidos.Anticipo, venPedidos.AnticipoPendiente, 
	venPedidos.ObsAnticipo,	venPedidos.CongelaCambio, venPedidos.Cambio, venPedidos.Posteado, 
	venPedidos.MetodoPago , venpedidos.UsoCfdi, UsosCfdi.Descripcion as DescripcionUsoCfdi, 
	Metodos.Descripcion as DescripcionMetodoPago, Cast(1 as Bit) as Timbrar , 
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) as SegmentoStr, 
		' ' Segmento_IdFact , 0 Segmento1NFact , 0 Segmento2NFact , 0 Segmento3NFact , 0 Segmento4NFact ,
	' ' Segmento1CFact , ' ' Segmento2CFact, ' ' Segmento3CFact, ' ' Segmento4CFact,	
	' ' as ArchivoPDF, ' ' as ArchivoXML
FROM venPedidos 
LEFT JOIN venSubTipoMov  ON (venSubTipoMov.SubTipoMov_Id='FC')
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
WHERE 
	venPediSegmentos.Empresa_id = @pEmpresa_id and 
	venPediSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	venPediSegmentos.Segmento1N = @pSegmento1N and 
	venPediSegmentos.Segmento2N = @pSegmento2N and 
	venPediSegmentos.Segmento3N = @pSegmento3N and 
	venPediSegmentos.Segmento4N = @pSegmento4N and 
	venPediSegmentos.Segmento1C = @pSegmento1C and 
	venPediSegmentos.Segmento2C = @pSegmento2C and 
	venPediSegmentos.Segmento3C = @pSegmento3C and 
	venPediSegmentos.Segmento4C = @pSegmento4C
GO
