-- stkRemisionFacturaDatos 1,'FC',430,0,0,0,'F','0001','I',' '
DROP PROCEDURE stkRemisionFacturaDatos_Identity
GO

CREATE PROCEDURE stkRemisionFacturaDatos_Identity
(
@lIdentity int
)
AS
SET NOCOUNT ON 

SELECT venMovimientos.venMovimientos, genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C,
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, 
	conAsientos.Fecha FechaFactura,
	dbo.FechaActual() Fecha,
	venClientes.Cliente_Id, venClieHabitual.Sucursal, venClieHabitual.NombreFantasia,
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, 
	venVendedores.Vendedor_Id, 	venVendedores.Nombre as DescripcionVendedores, 
	conAsientos.Observaciones,	venMovimientos.Importe, 
	' ' Segmento_IdRem , 0 Segmento1NRem , 0 Segmento2NRem , 0 Segmento3NRem , 0 Segmento4NRem ,
	' ' Segmento1CRem , ' ' Segmento2CRem, ' ' Segmento3CRem, ' ' Segmento4CRem,	
	' ' as ArchivoPDFRem, ' ' as ArchivoXMLRem , 'S' as Tipomov, 
	venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega
	
FROM venMovimientos 
INNER JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id)
LEFT JOIN venClieHabitual  ON (venClieHabitual.genEntidades = venMovimientos.Cliente_Id) AND (venClieHabitual.Sucursal = venMovimientos.Sucursal)
Left Join venClientes On venMovimientos.Cliente_Id = venClientes.genEntidades
INNER JOIN  venMovConStock ON venMovConStock.venMovimientos =  venMovimientos.venMovimientos
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venMovConStock.ListaPrecio_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venMovimientos.Vendedor_Id)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
INNER JOIN conAsientos ON  conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN venFormaEntrega ON  venFormaEntrega.venFormaEntrega = venMovimientos.FormaEntrega_Id
WHERE 
conAsientos.Anulado = 0 AND 
conAsientos.Posteado = 1 AND 
venMovimientos.venMovimientos = @lIdentity


SELECT venMovimientos.venMovimientos, venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, 
	stkProductos.Descripcion as DescripcionProductos,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	venMovConStockCr.Factor,
	venMovConStockCr.CantOriginal, venMovConStockCr.CantEntregada, 
	venMovConStockCr.CantPendiente, venMovConStockCr.CantFacturada,
	venMovConStockCr.CantFacturada * 0 CantidadAEntregar,
	venMovConStockCr.CantPendiente/venMovConStockCr.Factor CantidadPendienteOrig,
	'' MedidaAlterna, venMovConStockCr.CantFacturada * 0 CantidadAFacturarAlterna,
	venMovConStockCr.CantFacturada * 0 CantidadAEntregarAlterna,
	venMovConStockCr.PrecioForm, venCondFiscal.CondFisc_Id AS CFVenta_Id, 
	venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, venMovConStockCr.FechaEntrega,
	venMovConStockCr.Bonificacion, venMovConStockCr.Observaciones,
	concentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	concentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2, 
	conCuentas.Cuenta_Id as CtaDebe_Id
FROM venMovConStockCr 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venMovConStockCr.venMovimientos)
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = venMovConStockCr.Producto_Id)
LEFT JOIN venCondFiscal ON venCondFiscal.venCondFiscal = stkProductos.CFVenta_Id 
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = venMovConStockCr.Medida_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venMovConStockCr.Deposito_Id)
Left Join conCentro1 On conCentro1.conCentro1 = venMovConStockCr.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venMovConStockCr.Centro2_Id
INNER JOIN conCuentas ON  conCuentas.conCuentas = stkProductos.CtaCosto
WHERE 
venMovConStockCr.CantPendiente > 0 AND 
venMovimientos.venMovimientos = @lIdentity
 

SELECT stkMoviCabe as VenPedidos, stkMoviSerie.Renglon, stkMoviSerie.Serie, stkMoviSerie.Cantidad,  
	stkSerieVencimiento.Vencimiento, ' ' as Ubicacion_Id
	FROM stkMoviSerie 
	inner join stkSerieVencimiento ON stkSerieVencimiento.Serie = stkMoviSerie.Serie 
	where 1=2

Exec genAtributosGeneralesIdentityDatos @lIdentity, 'venRemisionFacturas'

Exec stkMoviUbicacionDatos 0

GO

DROP PROCEDURE stkRemisionFacturaDatos
GO
CREATE PROCEDURE stkRemisionFacturaDatos
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

Declare @pIdentity int= (select Asiento_Id from 
	genAsiSegmentos INNER JOIN genSegmentos ON
	genAsiSegmentos.Segmento_id = genSegmentos.genSegmentos
	Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genSegmentos.Segmento_id = @pSegmento_id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C)

Exec stkRemisionFacturaDatos_Identity @pIdentity

RETURN @@Error
GO
