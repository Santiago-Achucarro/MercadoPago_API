-- PARA V2
DROP PROCEDURE venFacturacionPedidoDatos_Identity
GO

CREATE PROCEDURE venFacturacionPedidoDatos_Identity
(
@lIdentity int
)
AS
SET NOCOUNT ON 

SELECT venPedidos.venPedidos, venPediSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N,
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C,
	venPediSegmentos.Segmento4C,
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, venPedidos.Fecha FechaPedido,
	dbo.FechaActual() Fecha,
	venClientes.Cliente_Id, venPedidos.Sucursal, venClieHabitual.NombreFantasia, genMonedas.Moneda_Id,
	genMonedas.Descripcion as DescripcionMonedas, genMonedasFact.Moneda_Id MonedaFacturacion,
	genMonedasFact.Descripcion DescripcionMonFacturacion, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
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
	venPedidos.TipoPrecioForm, venPedidos.CongelaCambio, venPedidos.Fecha_Registro, venPedidos.Cambio * 0 Cambio,
	venPedidos.Cambio CambioMonedaOriginal,
	venIncoterm.Incoterm_Id, venIncoterm.Descripcion as DescripcionIncoterm,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venPedidos.Posteado, 
	venPedidos.MetodoPago , venpedidos.UsoCfdi, UsosCfdi.Descripcion as DescripcionUsoCfdi, 
	Metodos.Descripcion as DescripcionMetodoPago, case when venPedidos.MetodoPago='99'then 'PUE' else 'PPD' end as N_MetodoPago, 
	 Cast(1 as Bit) as Timbrar, 
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) as SegmentoStr,
	' ' Segmento_IdFact , 0 Segmento1NFact , 0 Segmento2NFact , 0 Segmento3NFact , 0 Segmento4NFact ,
	' ' Segmento1CFact , ' ' Segmento2CFact, ' ' Segmento3CFact, ' ' Segmento4CFact,	
	' ' as ArchivoPDF, ' ' as ArchivoXML, 
	' ' Segmento_IdNC , 0 Segmento1NNC , 0 Segmento2NNC , 0 Segmento3NNC , 0 Segmento4NNC ,
	' ' Segmento1CNC , ' ' Segmento2CNC, ' ' Segmento3CNC, ' ' Segmento4CNC,	
	' ' as ArchivoPDFNC, ' ' as ArchivoXMLNC,
	' ' Segmento_IdRem , 0 Segmento1NRem , 0 Segmento2NRem , 0 Segmento3NRem , 0 Segmento4NRem ,
	' ' Segmento1CRem , ' ' Segmento2CRem, ' ' Segmento3CRem, ' ' Segmento4CRem,	
	' ' as ArchivoPDFRem, ' ' as ArchivoXMLRem, 0*venPedidos.SubTotal SubTotal, 0*venPedidos.SubTotalBonif SubTotalBonif,
	0*venPedidos.SubTotal Total, 	ImpOtCargos, DescOtrosCargos, DatoOtCargos, conCtaOtCargos.Cuenta_Id CtaOtrosCargos, conCtaOtCargos.Descripcion DescCtaOtrosCargos
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
Left Join conCuentas conCtaOtCargos On conCtaOtCargos.conCuentas = venPedidos.CtaOtrosCargos
WHERE venPedidos.venPedidos = @lIdentity

exec venFacturacionPedidoCuerpoDatos  @lIdentity

SELECT stkMoviCabe as VenPedidos, stkMoviSerie.Renglon, stkMoviSerie.Serie, stkMoviSerie.Cantidad,  
	stkSerieVencimiento.Vencimiento, '' as Ubicacion_Id, Cast(0 as numeric(19,8)) Existencia, Cast(0 as bit) Marcado
FROM stkMoviSerie 
inner join stkSerieVencimiento ON stkSerieVencimiento.Serie = stkMoviSerie.Serie 
	where 1=2

Exec genAtributosGeneralesIdentityDatos @lIdentity, 'venFacturacionPedidos'
Exec stkMoviUbicacionDatos 0
GO



-- venFacturacionPedidoDatos 1, 'NP', 1,0,0,0,'0001',' ',' ',' '
DROP PROCEDURE venFacturacionPedidoDatos
GO
CREATE PROCEDURE venFacturacionPedidoDatos
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
AS
SET NOCOUNT ON 

Declare @pIdentity int= (select venPedidos from venPediSegmentos
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

Exec venFacturacionPedidoDatos_Identity @pIdentity

RETURN @@Error
GO


DROP PROCEDURE venFacturacionPedidoCuerpoDatos
GO
CREATE PROCEDURE venFacturacionPedidoCuerpoDatos
(
@pvenPedidos int,
@pRenglon_Pe int=null
)
AS
SET NOCOUNT ON 

SELECT venPedidos.venPedidos, venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	venPediCuerpo.Factor,
	venPediCuerpo.CantidadOriginal, venPediCuerpo.CantidadPedida, venPediCuerpo.CantidadRemitida, venPediCuerpo.CantidadFacturada,
	venPediCuerpo.CantidadFacturada * 0 CantidadAFacturar, venPediCuerpo.CantidadFacturada * 0 CantidadAEntregar,
	venPediCuerpo.CantidadPedida - case when venPedidos.SoloEntrega=1 then venPediCuerpo.CantidadRemitida else venPediCuerpo.CantidadFacturada end as CantidadPendiente,
	stkMedidaAlterna.Medida_Id MedidaAlterna, venPediCuerpo.CantidadFacturada * 0 CantidadAFacturarAlterna,
	venPediCuerpo.CantidadFacturada * 0 CantidadAEntregarAlterna,
	venPediCuerpo.PrecioForm, venCondFiscal.CondFisc_Id AS CFVenta_Id, 
	venPediCuerpo.PrecioLista, venPediCuerpo.PrecioVenta, venPediCuerpo.FechaEntrega,
	venPediCuerpo.Especial, venPediCuerpo.Bonificacion, venPediCuerpo.Observaciones,
	venPediCuerpo.Pendiente, venPediCuerpo.ReservaMercaderia, concentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	concentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
FROM venPediCuerpo 
INNER JOIN venPedidos  ON (venPedidos.venPedidos = venPediCuerpo.venPedidos)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venPediCuerpo.Producto_Id)
LEFT JOIN venCondFiscal ON venCondFiscal.venCondFiscal = stkProductos.CFVenta_Id 
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venPediCuerpo.Medida_Id)
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkProductos.MedidaAlterna
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venPediCuerpo.Deposito_Id)
Left Join conCentro1 On conCentro1.conCentro1 = venPediCuerpo.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venPediCuerpo.Centro2_Id

WHERE 
venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadFacturada > 0 AND 
venPediCuerpo.Pendiente = 1 and 
venPedidos.venPedidos = @pvenPedidos
AND Renglon_Pe = IsNull(@pRenglon_Pe, Renglon_Pe)
 
RETURN @@Error 

GO

DROP PROCEDURE venPedidosFacturaAnticipo
GO
CREATE PROCEDURE venPedidosFacturaAnticipo
(
	@pVenPedidos int
)
AS

SELECT venPediFacturados.venMovimientos, venPediFacturados.venPedidos, 
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
from venPediFacturados inner join venMovimientos ON
venPediFacturados.venMovimientos = venMovimientos.venMovimientos 
INNER JOIN venSubTipoMov ON
venSubTipoMov.venSubTipoMov = venmovimientos.venSubTipoMov_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE
	conAsientos.Anulado = 0 AND 
	venSubTipoMov.MueveStock = 0 and 
	venMovimientos.venTipoMov = 'F' AND 
	venPediFacturados.venPedidos = @pVenPedidos
GO





