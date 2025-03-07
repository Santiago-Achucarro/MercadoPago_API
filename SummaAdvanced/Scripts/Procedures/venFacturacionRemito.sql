-- venFacturacionRemitoDatos 31
-- venRemitosPendienteClieDatos   'A007',1,'PES',1



DROP PROCEDURE venFacturacionRemitoDatos
GO

CREATE PROCEDURE venFacturacionRemitoDatos
(
	@lIdentity bigint
)
AS
SET NOCOUNT ON 

SELECT stkRemitos.stkMoviCabe, 
	genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	ISNULL(venSubTipoMov.SubTipoMov_Id,' ') SubTipoMov_Id, 	ISNULL(venSubTipoMov.Descripcion,' ') as DescripcionSubTipoMov, 
		ISNULL(venPedidos.Fecha, conAsientos.Fecha) FechaPedido,
	dbo.FechaActual() Fecha,
	venClientes.Cliente_Id, venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, genMonedas.Moneda_Id,
	genMonedas.Descripcion as DescripcionMonedas, genMonedasFact.Moneda_Id MonedaFacturacion,
	genMonedasFact.Descripcion DescripcionMonFacturacion, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, venVendedores.Vendedor_Id, 
	venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, isnull(venPedidos.Estado,' ') as Estado,
	venPedidos.FechaAutorizo, venPedidos.Observaciones,
	venPedidos.ObservEstado, venPedidos.Motivo_Id, ISNULL(venPedidos.ImporteTotal,0) AS ImporteTotal, 
	ISNULL(venPedidos.Bonificacion1,0) Bonificacion1,
	ISNULL(venPedidos.Bonificacion2,0) Bonificacion2, ISNULL(venPedidos.Bonificacion3,0) Bonificacion3, 
	ISNULL(venPedidos.Bonificacion4,0) Bonificacion4, ISNULL(venPedidos.Bonificacion5,0) Bonificacion5,
	ISNULL(venPedidos.Dato1,0) Dato1, ISNULL(venPedidos.Dato2,0) Dato2, ISNULL(venPedidos.Dato3,0) as Dato3, 
	ISNULL(venPedidos.FechaUltMod, conasientos.FechaRegistro) FechaUltMod,
	ISNULL(venPedidos.CliOrdenCompra,' ') as CliOrdenCompra, venPedidos.venNroPedido, 
	Cast(ISNULL(venPedidos.FacturaAnticipo,0) as Bit) as FacturaAnticipo, 
	Cast(ISNULL(venPedidos.TrabaDespacho,0) as Bit) as TrabaDespacho,
	ISNULL(venPedidos.PorAnticipo,0) PorAnticipo, ISNULL(venPedidos.Anticipo,0) Anticipo, 
	ISNULL(venPedidos.AnticipoPendiente,0.00) as AnticipoPendiente, venPedidos.ObsAnticipo,
	ISNULL(venPedidos.TipoPrecioForm,'C') TipoPrecioForm, 
	Cast(ISNULL(venPedidos.CongelaCambio,0) as Bit) as  CongelaCambio, 
	ISNULL(VenPedidos.Fecha_Registro,conAsientos.FechaRegistro) Fecha_Registro, 
	ISNULL(venPedidos.Cambio,0) * 0 Cambio,
	ISNULL(venPedidos.Cambio,1) CambioMonedaOriginal,
	venIncoterm.Incoterm_Id, venIncoterm.Descripcion as DescripcionIncoterm,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	ISNULL(venPedidos.Posteado, conAsientos.Posteado) as Posteado, 
	Metodos.Clave MetodoPago , UsosCfdi.Clave UsoCfdi, UsosCfdi.Descripcion as DescripcionUsoCfdi, 
	Metodos.Descripcion as DescripcionMetodoPago,  Cast(1 as Bit) as Timbrar, 
	ISNULL(dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N),' ') as SegmentoStr,
	' ' Segmento_IdFact , 0 Segmento1NFact , 0 Segmento2NFact , 0 Segmento3NFact , 0 Segmento4NFact ,
	' ' Segmento1CFact , ' ' Segmento2CFact, ' ' Segmento3CFact, ' ' Segmento4CFact,	
	' ' as ArchivoPDF, ' ' as ArchivoXML, 
	' ' Segmento_IdNC , 0 Segmento1NNC , 0 Segmento2NNC , 0 Segmento3NNC , 0 Segmento4NNC ,
	' ' Segmento1CNC , ' ' Segmento2CNC, ' ' Segmento3CNC, ' ' Segmento4CNC,	
	' ' as ArchivoPDFNC, ' ' as ArchivoXMLNC, dbo.FechaActual() as Fecha_Nueva
FROM stkRemitos 
INNER JOIN conAsientos ON 
conAsientos.conAsientos = stkRemitos.stkMoviCabe
inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER Join venClientes On stkRemitos.Cliente_Id = venClientes.genEntidades
INNER JOIN venClieHabitual  ON (venClieHabitual.genEntidades = stkRemitos.Cliente_Id) AND (venClieHabitual.Sucursal = stkRemitos.Sucursal)
LEFT JOIN (SELECT DISTINCT venPedidos, stkMoviCabe FROM venPediRemitidos) AS venPediRemitidos on
venPediRemitidos.stkMoviCabe = stkRemitos.stkMoviCabe
	LEFT join venPedidos ON 
	venPedidos.venPedidos =  venPediRemitidos.venPedidos 
LEFT JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id)
INNER JOIN genMonedas  ON genMonedas.genMonedas = ISNULL(venPedidos.Moneda_Id,genEmpresas.Moneda_Id)
INNER Join genMonedas genMonedasFact On genMonedasFact.genMonedas = ISNULL(venPedidos.MonedaFacturacion,genEmpresas.Moneda_Id)
INNER JOIN venCondPago  ON venCondPago.venCondPago = ISNULL(venPedidos.CondPagoCli_Id, venClieHabitual.CondPagoCli_Id)
INNER JOIN venListasPrecios  ON venListasPrecios.venListasPrecios = ISNULL(venPedidos.ListaPrecio_Id, venClieHabitual.ListaPrecio_Id)
LEFT JOIN venVendedores  ON venVendedores.venVendedores = ISNULL(venPedidos.Vendedor_Id, venClieHabitual.Vendedor_Id)
LEFT JOIN venFormaEntrega  ON venFormaEntrega.venFormaEntrega = ISNULL(venPedidos.FormaEntrega_Id, venClieHabitual.FormaEntrega_Id)
LEFT JOIN venIncoterm  ON venIncoterm.venIncoterm_int = venPedidos.Incoterm_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = ISNULL(venPedidos.Usuario_Id, conAsientos.Usuario_Id)
LEFT JOIN venPediSegmentos ON venPediSegmentos.venPedidos = venPedidos.venPedidos
LEFT JOIN genEntidadesBasicasValor as UsosCfdi ON
UsosCfdi.Entidad_Id = 4 AND 
UsosCfdi.Dominio_Id = 'MX' AND 
UsosCfdi.Clave = ISNULL(venPedidos.UsoCfdi, venClieHabitual.C_UsoCFDI)
LEFT JOIN genEntidadesBasicasValor as Metodos ON
Metodos.Entidad_Id = 6 AND 
Metodos.Dominio_Id = 'MX' AND 
Metodos.Clave = ISNULL(venPedidos.MetodoPago, venClieHabitual.MetodoDePago)
WHERE 
conAsientos.Anulado = 0 and 
conAsientos.Posteado = 1 and 
stkRemitos.stkMoviCabe = @lIdentity

Exec venFacturacionRemitoCuerpo @lIdentity
Exec genAtributosGeneralesIdentityDatos @lIdentity, 'stkMoviCabe'
GO

GO
DROP PROCEDURE venFacturacionRemitoCuerpo
GO
CREATE PROCEDURE venFacturacionRemitoCuerpo
(
	@lIdentity bigint
)
as
SELECT stkRemitos.stkMoviCabe, stkRemiPendFact.Renglon,
	isnull(venPedidos.venPedidos,0) venPedidos , isnull(venPediCuerpo.Renglon_Pe,0) as Renglon_Pe, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	ISNULL(venPediCuerpo.Factor, stkMoviCuerpo.Factor) as Factor ,
	ISNULL(venPediCuerpo.CantidadOriginal, stkMoviCuerpo.CantidadForm) as CantidadOriginal, 
	ISNULL(venPediCuerpo.CantidadPedida, stkMoviCuerpo.Cantidad)  as CantidadPedida, 
	ISNULL(venPediCuerpo.CantidadRemitida, stkMoviCuerpo.Cantidad) as CantidadRemitida, 
	ISNULL(venPediCuerpo.CantidadFacturada,stkMoviCuerpo.Cantidad-stkRemiPendFact.CantidadPendiente) as  CantidadFacturada, 
	stkRemiPendFact.CantidadPendiente, 	stkMoviCuerpo.Cantidad * 0 CantidadAFacturar, 
	'' MedidaAlterna, stkMoviCuerpo.Cantidad * 0 CantidadAFacturarAlterna,
	ISNULL(venPediCuerpo.PrecioForm, stkMoviCuerpo.PrecioOriginal) as  PrecioForm, 
	stkCondFisVenta.CFVenta_Id AS CFVenta_Id, 
	ISNULL(venPediCuerpo.PrecioLista,stkMoviCuerpo.PrecioOriginal) as PrecioLista,
	ISNULL(venPediCuerpo.PrecioVenta,stkMoviCuerpo.PrecioOriginal) as  PrecioVenta, 
	ISNULL(venPediCuerpo.FechaEntrega, conAsientos.Fecha) as FechaEntrega,
	Cast(ISNULL(venPediCuerpo.Especial,0) as Bit) as Especial,
	ISNULL(venPediCuerpo.Bonificacion,0) AS Bonificacion,
	 ISNULL(venPediCuerpo.Observaciones,stkMoviCuerpo.Observaciones) as Observaciones,
	Cast(ISNULL(venPediCuerpo.Pendiente,1) as Bit) as  Pendiente ,
	Cast(ISNULL(venPediCuerpo.ReservaMercaderia,0)  as Bit) as  ReservaMercaderia,
	concentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	concentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2, 
	stkMoviCuerpo.CostoUnitario
FROM stkRemitos inner join stkRemiPendFact ON
	stkRemitos.stkMoviCabe = stkRemiPendFact.stkMoviCabe
	INNER JOIN conAsientos ON conAsientos.conAsientos =stkRemiPendFact.stkMoviCabe
	INNER JOIN stkMoviCuerpo ON  stkMoviCuerpo.stkMoviCabe = stkRemiPendFact.stkMoviCabe and 
						     stkMoviCuerpo.Renglon = stkRemiPendFact.Renglon 
LEFT JOIN ( venPediRemitidos INNER JOIN venPediCuerpo  ON 
	venPediCuerpo.venPedidos = venPediRemitidos.venPedidos and 
	venPediCuerpo.Renglon_Pe = venPediRemitidos.Renglon_Pe 
	INNER JOIN venPedidos  ON venPedidos.venPedidos = venPediCuerpo.venPedidos 
	) ON 
	venPediRemitidos.stkMoviCabe = stkRemiPendFact.stkMoviCabe and
	venPediRemitidos.Renglon = stkRemiPendFact.Renglon
INNER JOIN stkProductos  ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
INNER JOIN stkCondFisVenta ON stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id 
INNER JOIN stkUniMed  ON stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
INNER  JOIN stkDepositos  ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Left Join conCentro1 On conCentro1.conCentro1 = venPediCuerpo.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venPediCuerpo.Centro2_Id
WHERE 
stkRemiPendFact.CantidadPendiente > 0 AND 
stkRemitos.stkMoviCabe = @lIdentity
 

SELECT stkMoviSerie.stkMoviCabe , stkMoviSerie.Renglon, stkMoviSerie.Serie, stkMoviSerie.Cantidad / stkMoviCuerpo.Factor Cantidad,
	stkSerieVencimiento.Vencimiento
	FROM stkRemitos 
	inner join stkRemiPendFact ON stkRemitos.stkMoviCabe = stkRemiPendFact.stkMoviCabe
	INNER JOIN stkMoviSerie ON stkMoviSerie.stkMoviCabe = stkRemiPendFact.stkMoviCabe AND stkMoviSerie.Renglon = stkRemiPendFact.Renglon
	INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND stkMoviCuerpo.Renglon = stkMoviSerie.Renglon
	Inner Join conAsientos On conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe
	inner join stkSerieVencimiento ON stkSerieVencimiento.Serie = stkMoviSerie.Serie And stkSerieVencimiento.Producto_Id = stkMoviCuerpo.Producto_Id And
		stkSerieVencimiento.Empresa_Id = conAsientos.Empresa_Id
	where 
	stkRemiPendFact.CantidadPendiente > 0 AND 
	stkRemitos.stkMoviCabe = @lIdentity

GO

-- venRemitosPendienteClieDatos '001',1,'PES',1
DROP Procedure venRemitosPendienteClieDatos
GO
CREATE Procedure venRemitosPendienteClieDatos
(
	@Cliente_Id VarChar(15),
	@Sucursal Int ,
	@Moneda_Id VarChar(5),
	@Empresa_Id Int

)
AS
select venClientes.Cliente_Id, venClientes.RazonSocial, venclieHabitual.Sucursal,
	'  ' SubTipoMov_Id, '  ' as DescripcionSubTipoMov, 
	Convert(DateTime, null) FechaPedido,
	genMonedas.Moneda_Id,genMonedas.Descripcion as DescripcionMonedas, 
	genMonedasFact.Moneda_Id MonedaFacturacion,
	genMonedasFact.Descripcion DescripcionMonFacturacion, 
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, venVendedores.Vendedor_Id, 
	venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, ' ' Estado,
	' ' Observaciones, 0.00 Dato1, 0.00 Dato2, 0.00 Dato3, 
	'  ' CliOrdenCompra, ' ' venNroPedido, 
	' ' TipoPrecioForm, Cast(0 as Bit) CongelaCambio, 0.00 Cambio,
	1.00 CambioMonedaOriginal,
	'  ' Incoterm_Id, ' ' as DescripcionIncoterm,
	venClieHabitual.MetodoDePago MetodoPago , venClieHabitual.C_UsoCFDI UsoCfdi, UsosCfdi.Descripcion as DescripcionUsoCfdi, 
	Metodos.Descripcion as DescripcionMetodoPago,  Cast(1 as Bit) as Timbrar, 
	' ' Segmento_IdFact , 0 Segmento1NFact , 0 Segmento2NFact , 0 Segmento3NFact , 0 Segmento4NFact ,
	' ' Segmento1CFact , ' ' Segmento2CFact, ' ' Segmento3CFact, ' ' Segmento4CFact,	
	' ' as ArchivoPDF, ' ' as ArchivoXML, 0.0 as Total, dbo.FechaActual() as FechaNueva
from venClientes INNER JOIN venClieHabitual ON
	venClientes.genEntidades = venClieHabitual.genEntidades AND
	venClieHabitual.Sucursal = @Sucursal
LEFT JOIN genMonedas  ON (genMonedas.Moneda_Id = @Moneda_Id)
Left Join genMonedas genMonedasFact On genMonedasFact.Moneda_Id = @Moneda_Id
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venClieHabitual.CondPagoCli_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venClieHabitual.ListaPrecio_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venClieHabitual.Vendedor_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venClieHabitual.FormaEntrega_Id)
LEFT JOIN genEntidadesBasicasValor as UsosCfdi ON
UsosCfdi.Entidad_Id = 4 AND 
UsosCfdi.Dominio_Id = 'MX' AND 
UsosCfdi.Clave = venClieHabitual.C_UsoCFDI
LEFT JOIN genEntidadesBasicasValor as Metodos ON
Metodos.Entidad_Id = 6 AND 
Metodos.Dominio_Id = 'MX' AND 
Metodos.Clave = venClieHabitual.MetodoDePago
WHERE 
venClientes.Cliente_Id = @Cliente_Id

SELECT CAST(0 as bit) as Marca, 
	stkRemitos.stkMoviCabe, conAsientos.Fecha,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
		, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
		, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Remito,
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C
		, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N
		, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) AS Pedido,
		genMonedas.Moneda_Id,
	isnull(SUM(venpediCuerpo.PrecioVenta * stkRemiPendFact.CantidadPendiente), 
		SUM(stkMoviCuerpo.PrecioOriginal * stkRemiPendFact.CantidadPendiente/ stkMoviCuerpo.Factor)) as Monto

from stkRemitos INNER JOIN stkRemiPendFact ON 
stkRemitos.stkMoviCabe = stkRemiPendFact.stkMoviCabe 
INNER JOIN conAsientos ON 
conAsientos.conAsientos = stkRemitos.stkMoviCabe 
INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
INNER JOIN venClientes on 
venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe = stkRemiPendFact.StkmoviCabe and 
		stkMoviCuerpo.Renglon  = stkRemiPendFact.Renglon
LEFT JOIN ( venPediRemitidos INNER JOIN venPedidos ON 
venPedidos.venPedidos = venPediRemitidos.venPedidos
INNER JOIN venPediCuerpo ON
venPediCuerpo.venPedidos = venPediRemitidos.venPedidos AND
venPediCuerpo.Renglon_Pe = venPediRemitidos.Renglon_Pe
inner join venPediSegmentos ON
venPediSegmentos.venPedidos = venPedidos.venPedidos)
ON
venPediRemitidos.stkMoviCabe = stkRemiPendFact.stkMoviCabe and 
venPediRemitidos.Renglon = stkRemiPendFact.Renglon
INNER JOIN genMonedas ON 
genMonedas.genMonedas = ISNULL(venPedidos.Moneda_id, conasientos.Moneda_Id)
Where
	stkRemiPendFact.CantidadPendiente > 0 and
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 AND
	conAsientos.Empresa_Id = @Empresa_Id and 
	venClientes.Cliente_Id = @Cliente_Id and 
	genMonedas.Moneda_Id = @Moneda_Id
GROUP BY stkRemitos.stkMoviCabe, conAsientos.Fecha,
		genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
		, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
		, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C
		, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N
		, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N,
		genMonedas.Moneda_Id

-- solo para Taer las Estructura
Exec venFacturacionRemitoCuerpo 0

GO