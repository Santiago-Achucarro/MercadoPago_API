-- UNIFICADAS V1 Y V2
-- FM 09/09/2021 vStkDepoExistencia cambi� que Empresa_Id lo saque de stkExistencia y no de stkProductos que pod�a estar en null y tra�a 2 registros --

Drop view vstkProductos
Go
Create view vstkProductos
As
Select stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Empresa_Id, stkProductos.Descripcion, 
IsNull(stkProductos.DescripcionDetallada, '') DescripcionDetallada, 
IsNull(stkProductos.Description, '') Description, stkUniMed.Medida_Id, IsNull(UnidadAlterna.Medida_Id, '') MedidaAlterna, stkProductos.FactorAlterna,
stkProductos.Clase, stkProductos.CodigoBarra, stkTipos.Tipo_Id, stkProductos.TrabajaPorLotes, stkProductos.Serializable, stkProductos.conVencimiento,
stkProductos.UsaDespachoImportacion, IsNull(UmVenta.Medida_Id, '') UmVenta, stkProductos.CostoPromPond, stkProductos.CostoUltCompra,
stkProductos.CostoStandard, IsNull(MonUltCpa.Moneda_Id, '') MonedaUltCompra, stkProductos.PrecioUltCompra, IsNull(UMCompra.Medida_Id, '') UmCompra,
IsNull(conCuentas.Cuenta_Id, '') CtaCompra, IsNull(CtaAjuInventario.Cuenta_Id, '') CtaAjuInventario, IsNull(CtaVenta.Cuenta_Id, '') CtaVenta,
IsNull(CtaCredito.Cuenta_Id, '') CtaCredito, IsNull(CtaDescuento.Cuenta_Id, '') CtaDescuento, IsNull(CtaCosto.Cuenta_Id, '') CtaCosto,
IsNull(CtaVentaExt.Cuenta_Id, '') CtaVentaExt, IsNull(CtaCreditoExt.Cuenta_Id, '') CtaCreditoExt, IsNull(CtaDescuentoExt.Cuenta_Id, '') CtaDescuentoExt,
IsNull(CtaCostoExt.Cuenta_Id, '') CtaCostoExt, stkProductos.Fcha_Ult_Compra, stkProductos.MargenExceso, stkProductos.TiempoEntrega,
stkProductos.Acepta_Ventas, IsNull(stkCondFisVenta.CFVenta_Id, '') CFVenta_Id, stkProductos.Acepta_Compras, IsNull(stkCondFisCompra.CFComp_Id, '') CFComp_Id,
stkProductos.Acepta_Comis_Vta, stkProductos.DiasGarantia, IsNull(stkProductos.Imagen, '') Imagen , stkProductos.FechaUltModif, 
stkProductos.ImagenExtension, stkProductos.Inactivo, stkProductos.Posteado, stkProductos.ClaseAlterna, 
stkFamilias.Familia_Id, stkGrupos.Grupo_Id, stkProductos.CostoReposicion, stkProductos.CodigoFiscal, 
stkProductos.FraccionArancelaria, stkProductos.Usuario_Id , conCuentasCons.Cuenta_Id as CtaConsumo, 
	stkproductos.CostoUltimoCierre,Observaciones, 
	-- se agrego esto
	stkProductos.MaterialPeligroso, ISNULL(stkProductos.CveMaterialPeligroso,'') CveMaterialPeligroso, 
	ISNULL(stkProductos.PesoEnKg,0) PesoEnKg, isnull(stkProductos.ClaveSTCC,'') as ClaveSTCC
	-- fin aj
From stkProductos
Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
Left Join stkUniMed UnidadAlterna On UnidadAlterna.stkUniMed = stkProductos.MedidaAlterna
Inner Join stkTipos On stkTipos.stkTipos = stkProductos.Tipo_Id
Left Join stkUniMed UMVenta On UmVenta.stkUniMed = stkProductos.UmVenta
Left Join genMonedas MonUltCpa On MonUltCpa.genMonedas = stkProductos.MonedaUltCompra
Left Join stkUniMed UMCompra On UMCompra.stkUniMed = stkProductos.UMCompra
Left Join conCuentas On conCuentas.conCuentas = stkProductos.CtaCompra
Left Join conCuentas CtaAjuInventario On CtaAjuInventario.conCuentas = stkProductos.CtaAjuInventario
Left Join conCuentas CtaVenta On CtaVenta.conCuentas = stkProductos.CtaVenta
Left Join conCuentas CtaCredito On CtaCredito.conCuentas = stkProductos.CtaCredito
Left Join conCuentas CtaDescuento On CtaDescuento.conCuentas = stkProductos.CtaDescuento
Left Join conCuentas CtaCosto On CtaCosto.conCuentas = stkProductos.CtaCosto
Left Join conCuentas CtaVentaExt On CtaVentaExt.conCuentas = stkProductos.CtaVentaExt
Left Join conCuentas CtaCreditoExt On CtaCreditoExt.conCuentas = stkProductos.CtaCreditoExt
Left Join conCuentas CtaDescuentoExt On CtaDescuentoExt.conCuentas = stkProductos.CtaDescuentoExt
Left Join conCuentas CtaCostoExt On CtaCostoExt.conCuentas = stkProductos.CtaCostoExt
Left Join stkCondFisVenta On stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
Left Join stkCondFisCompra On stkCondFisCompra.stkCondFisCompra = stkProductos.CFComp_Id
Left Join stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
Left join stkGrupos ON stkGrupos.stkGrupos  = stkProductos.Grupo_Id
Left Join conCuentas as conCuentasCons ON conCuentasCons.conCuentas = stkProductos.CtaConsumo 
Go



DROP VIEW [dbo].[vComOrdencomp] 
GO

CREATE VIEW [dbo].[vComOrdencomp] as 
SELECT comOrdenComp.comOrdenComp, 
	comProveedores.Proveed_id,comProveedores.RazonSocial,comOrdenComp.Fecha, 
	genMonedas.Moneda_Id, comOrdenComp.Estado_Id, 
		comConPago.CondPago_Id, comTipoPermi.TipoPermi_Id, 
			comTipoPermi.TipoCuerpo, comOCSegmentos1.Empresa_Id as Empresa, 
			comTipoPermi.Importaciones, comOrdenComp.Observaciones, 
			Convert(numeric(18,2), SUM(comOCCuerpo.Cantidad * comOCCuerpo.Precio)) as Monto
	FROM comOrdencomp INNER JOIN comProveedores 
		ON comProveedores.genEntidades = comOrdencomp.Proveed_Id
		INNER JOIN genMonedas ON 
		genMonedas.genMonedas = comOrdenComp.Moneda_Id
		INNER JOIN comConPago ON
		comConPago.comConPago = comOrdenComp.CondPago_Id
		INNER JOIN comTipoPermi ON
		comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id
		INNER JOIN comOCSegmentos as  comOCSegmentos1 ON
		comOCSegmentos1.comOrdenComp = comOrdenComp.comOrdenComp
		inner join comOCCuerpo ON comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp
GROUP BY  comOrdenComp.comOrdenComp, 
	comProveedores.Proveed_id,comProveedores.RazonSocial,comOrdenComp.Fecha, 
	genMonedas.Moneda_Id, comOrdenComp.Estado_Id, 
		comConPago.CondPago_Id, comTipoPermi.TipoPermi_Id, 
			comTipoPermi.TipoCuerpo, comOCSegmentos1.Empresa_Id ,
			comTipoPermi.Importaciones, comOrdenComp.Observaciones		

GO




DROP VIEW [dbo].[vGenLetrasCompras]
GO
CREATE VIEW [dbo].[vGenLetrasCompras]
AS
SELECT 'A' as Letra, 'A' as Descripcion
UNION
SELECT 'B' as Letra, 'B' as Descripcion
UNION
SELECT 'C' as Letra, 'C' as Descripcion
UNION
SELECT 'E' as Letra, 'E' as Descripcion


GO

DROP VIEW [dbo].[vGenLetrasVentas]
GO
CREATE VIEW [dbo].[vGenLetrasVentas]
AS
SELECT 'A' as Letra, 'A' as Descripcion
UNION
SELECT 'B' as Letra, 'B' as Descripcion
UNION
SELECT 'C' as Letra, 'C' as Descripcion
UNION
SELECT 'E' as Letra, 'E' as Descripcion


GO
DROP VIEW vGenSegmentosConfiguracion
GO

CREATE VIEW vGenSegmentosConfiguracion
AS
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden1N as Orden, 1 as Campo, 'N' AS Tipo,  Digitos1N as Digitos, 
TieneColumnaAutomatica , genSegmentos.Origen1N AS Origen,
CASE WHEN (genSegmentosNombres.Nombre1N is null OR ltrim(genSegmentosNombres.Nombre1N) = '') THEN 'Segmento1N' ELSE genSegmentosNombres.Nombre1N END  as Nombre, 
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 1 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen1N
WHERE 
	genSegmentos.Digitos1N > 0 
UNION ALL	
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden2N as Orden, 2 as Campo, 'N' AS Tipo, Digitos2N as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen2N AS Origen,
CASE WHEN (genSegmentosNombres.Nombre2N is null OR ltrim(genSegmentosNombres.Nombre2N) = '') THEN 'Segmento2N' ELSE genSegmentosNombres.Nombre2N END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 2 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen2N
WHERE 
	genSegmentos.Digitos2N > 0 
UNION ALL	
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden3N as Orden, 3 as Campo, 'N' AS Tipo, Digitos3N as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen3N AS Origen,
CASE WHEN (genSegmentosNombres.Nombre3N is null OR ltrim(genSegmentosNombres.Nombre3N) = '') THEN 'Segmento3N' ELSE genSegmentosNombres.Nombre3N END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 3 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen3N
WHERE 
	genSegmentos.Digitos3N > 0 
UNION ALL	
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden4N as Orden, 4 as Campo, 'N' AS Tipo, Digitos4N as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen4N AS Origen,
CASE WHEN (genSegmentosNombres.Nombre4N is null OR ltrim(genSegmentosNombres.Nombre4N) = '') THEN 'Segmento4N' ELSE genSegmentosNombres.Nombre4N END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 4 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen4N
WHERE 
	genSegmentos.Digitos4N > 0 
UNION ALL
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden1C as Orden, 1 as Campo, 'C' AS Tipo,  Digitos1C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen1C AS Origen,
CASE WHEN (genSegmentosNombres.Nombre1C is null OR ltrim(genSegmentosNombres.Nombre1C) = '') THEN 'Segmento1C' ELSE genSegmentosNombres.Nombre1C END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 5 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen1C
WHERE 
	genSegmentos.Digitos1C > 0 
UNION ALL	
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden2C as Orden, 2 as Campo, 'C' AS Tipo, Digitos2C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen2C AS Origen,
CASE WHEN (genSegmentosNombres.Nombre2C is null OR ltrim(genSegmentosNombres.Nombre2C) = '') THEN 'Segmento2C' ELSE genSegmentosNombres.Nombre2C END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 1 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen2C
WHERE 
	genSegmentos.Digitos2C > 0 
UNION ALL	
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden3C as Orden, 3 as Campo, 'C' AS Tipo, Digitos3C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen3C AS Origen,
CASE WHEN (genSegmentosNombres.Nombre3C is null OR ltrim(genSegmentosNombres.Nombre3C) = '') THEN 'Segmento3C' ELSE genSegmentosNombres.Nombre3C END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 1 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen3C
WHERE 
	genSegmentos.Digitos3C > 0
UNION ALL	
SELECT genSegmentos.genSegmentos, genSegmentos.Segmento_id, 
Orden4C as Orden, 4 as Campo, 'C' AS Tipo, Digitos4C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen4C AS Origen,
CASE WHEN (genSegmentosNombres.Nombre4C is null OR ltrim(genSegmentosNombres.Nombre4C) = '') THEN 'Segmento4C' ELSE genSegmentosNombres.Nombre4C END  as Nombre,  
CAST(CASE WHEN genSegmentos.HabilitaEdicion = 1 THEN 1 ELSE 0 END AS bit) as HabilitaEdicion
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen4C
WHERE 
	genSegmentos.Digitos4C > 0 


GO


DROP VIEW  vstkMoviCabe 
GO
CREATE VIEW  vstkMoviCabe as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
stkMoviCabe.SubTipomov_id,conAsientos.Posteado, disFormularios.Formulario_Id, stkMoviCabe.stkMoviCabe, 
genAsiSegmentos.Empresa_Id as Empresa, conAsientos.Anulado, genSucursalesEmpr.Sucursal as SucursalFiltro,
stkMoviCabe.Signo
from stkmovicabe 
Inner join conAsientos ON stkmovicabe.stkmovicabe = conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviCabe.stkMoviCabe
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
GO


DROP VIEW vvenPedidos 
GO
CREATE VIEW vvenPedidos AS 
	SELECT venpedidos.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento2C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N,
	venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) Segmento, venClientes.Cliente_Id, venClientes.RazonSocial, 
	venPedidos.Fecha, venPedidos.Posteado, venPedidos.Empresa_Id as Empresa , venSubTipoMov.SubTipoMov_Id, genMonedas.Moneda_Id,
	MonFactu.Moneda_Id MonedaFacturacion, venCondPago.CondPagoCli_Id, venListasPrecios.ListaPrecio_Id, venVendedores.Vendedor_Id,
	venFormaEntrega.FormaEntrega_Id, venPedidos.Estado, genUsuarios.Usuario_Id UsuarioAutoriz_Id, venPedidos.FechaAutorizo,
	venPedidos.Observaciones, venPedidos.ObservEstado, venPedidos.Motivo_Id, venPedidos.ImporteTotal, venPedidos.Bonificacion1,
	venPedidos.Bonificacion2, venPedidos.Bonificacion3, venPedidos.Bonificacion4, venPedidos.Bonificacion5,
	venPedidos.Dato1, venPedidos.Dato2, venPedidos.Dato3, venPedidos.FechaUltMod, venPedidos.CliOrdenCompra, venPedidos.venNroPedido, 
	venPedidos.FacturaAnticipo, venPedidos.TrabaDespacho, venPedidos.PorAnticipo, venPedidos.Anticipo, venPedidos.AnticipoPendiente,
	venPedidos.ObsAnticipo, venPedidos.TipoPrecioForm, venPedidos.CongelaCambio, venPedidos.Fecha_Registro, venPedidos.Cambio,
	venIncoterm.Incoterm_Id, venPedidos.SoloEntrega, venPedidos.MetodoPago, venPedidos.UsoCfdi
	From venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	INNER JOIN venClientes ON venPedidos.Cliente_Id = venClientes.genEntidades
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join genMonedas On genMonedas.genMonedas = venPedidos.Moneda_Id
	Inner Join genMonedas MonFactu On MonFactu.genMonedas = venPedidos.MonedaFacturacion
	Inner Join venCondPago On venCondPago.venCondPago = venPedidos.CondPagoCli_Id
	Inner Join venListasPrecios On venListasPrecios.venListasPrecios = venPedidos.ListaPrecio_Id
	Inner Join venVendedores On venVendedores.venVendedores = venPedidos.Vendedor_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	left Join genUsuarios On genUsuarios.genUsuarios = venPedidos.UsuarioAutoriz_Id
	Left Join venIncoterm On venIncoterm.venIncoterm_int = venPedidos.Incoterm_Id
GO	
	
DROP VIEW vClientesHabitual 
GO
CREATE VIEW vClientesHabitual as 
SELECT venClientes.Cliente_id, venClientes.RazonSocial, venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, 
rTrim(venClieHabitual.Direccion1_Fact) + ' ' + rTrim(venClieHabitual.Direccion2_Fact) + ' ' + rTrim(Cast(venClieHabitual.NroExterior_Fact As varChar(10))) + ' ' +
rTrim(Cast(venClieHabitual.NroInterior_Fact As varChar(10))) + ' ' + rTrim(venClieHabitual.Localidad_Fact) + ' ' + rTrim(genProvincias.Descripcion) DireccionFact,

rTrim(venClieHabitual.Direccion1_Entr) + ' ' + rTrim(venClieHabitual.Direccion2_Entr) + ' ' + rTrim(Cast(venClieHabitual.NroExterior_Entr As varChar(10))) + ' ' +
rTrim(Cast(venClieHabitual.NroInterior_Entr As varChar(10))) + ' ' + rTrim(venClieHabitual.Localidad_Entr) + ' ' + rTrim(genProvinciasEntr.Descripcion) Direccion,
	venCondPago.CondPagoCli_id, venListasPrecios.ListaPrecio_Id, genMonedas.Moneda_Id MonedaLista,
	venZona.Zona_Id, venVendedores.Vendedor_Id, venVendedores.Nombre Vendedor,
	venFormaEntrega.FormaEntrega_Id, venClientes.Posteado, venClieHabitual.Inactivo, venClientes.Empresa_Id,
	venClieHabitual.MetodoDePago, venClieHabitual.N_MetodoPago, venClieHabitual.C_UsoCFDI,venClieHabitual.UsaComplementoINE,

	ISNULL((SELECT genMonedas.Moneda_Id
from venClientesCtas, genMonedas 
Where 
	venClientesCtas.Cliente_Id = venClientes.genEntidades and 
	genMonedas.genMonedas = venClientesCtas.Moneda_Id and 
	venClientesCtas.ParaPedidos = 1), 
	(Select genMonedas.Moneda_Id From genMonedas, venClieHabitual venCH, venListasPrecios
	Where venListasPrecios.venListasPrecios = venCH.ListaPrecio_Id And genMonedas.genMonedas = venListasPrecios.Moneda_Id And
	venCH.genEntidades = venClieHabitual.genEntidades And venCH.Sucursal = venClieHabitual.Sucursal
	)
	) as MonedaPedido
FROM venClientes 
INNER JOIN venClieHabitual ON venClientes.genEntidades =  venClieHabitual.genEntidades
INNER JOIN venCondPago on venClieHabitual.CondPagoCli_id =  venCondPago.venCondPago 
INNER JOIN venListasPrecios ON venListasPrecios.venListasPrecios = venClieHabitual.ListaPrecio_Id
INNER JOIN genMonedas ON venListasPrecios.Moneda_Id = genMonedas.genMonedas
INNER JOIn venZona ON venZona.venZona = venClieHabitual.Zona_Id
INNER JOIN venVendedores ON venVendedores.venVendedores = venClieHabitual.Vendedor_Id
INNER JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venClieHabitual.FormaEntrega_Id
Inner Join genProvincias On genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
Inner Join genProvincias genProvinciasEntr On genProvinciasEntr.genProvincias = venClieHabitual.Provincia_Id_Entr

GO

DROP VIEW vProductoMedida 
GO
CREATE VIEW vProductoMedida 
AS
Select stkProductos.Producto_Id, stkUniMed.Medida_Id, stkUniMed.Descripcion, 
stkArtiUM.Factor, stkUniMed.Inactivo, stkUniMed.Posteado, stkUniMed.Empresa_Id
from stkArtiUM 
INNER JOIN stkProductos ON stkArtiUM.Producto_id = stkProductos.stkProductos
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkArtiUM.Medida_id
UNION ALL
Select stkProductos.Producto_Id, stkUniMed.Medida_Id, stkUniMed.Descripcion, 1, 
stkUniMed.Inactivo, stkUniMed.Posteado, stkUniMed.Empresa_Id
from stkProductos
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_id
GO


DROP VIEW vUltimaCompra 
GO
CREATE VIEW vUltimaCompra 
AS

SELECT stkProductos.stkProductos as Producto_id , 
	genMonedas.genMonedas ,  genMonedas.Moneda_Id, 
	case when stkProductosCostos.CostoUltCompra IS NULL THEN 
	case when stkProductos.MonedaUltCompra = genMonedas.genMonedas THEN
	stkProductos.PrecioUltCompra else 
	Convert(Numeric(18,4),stkProductos.CostoUltCompra / ISNULL(genTipoCambio.CambioCompra,1)) end 
	ELSE
	case when stkProductosCostos.MonedaUltCompra = genMonedas.genMonedas THEN
	stkProductosCostos.PrecioUltCompra else 
	Convert(Numeric(18,4),stkProductosCostos.CostoUltCompra / ISNULL(genTipoCambio.CambioCompra,1)) end END AS Costo, 
	genEmpresas.genEmpresas as Empresa_id
from stkProductos 
	CROSS JOIN genMonedas 
	Inner join genEmpresas On genEmpresas.genEmpresas = isnull(stkproductos.Empresa_Id, genEmpresas.genEmpresas )
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.UMCompra
	left join stkProductosCostos on
	stkProductos.stkProductos =stkProductosCostos.Producto_Id and 
	genEmpresas.genEmpresas = stkProductosCostos.Empresa_Id
	left outer join 
		(select Moneda_id, CambioCompra,Empresa_Id From genTipoCambio where
			genTipoCambio.Fecha = (select max(Fecha) from genTipoCambio g1 where
				g1.Moneda_Id = genTipoCambio.Moneda_Id)) AS genTipoCambio ON
				genTipoCambio.Moneda_id = genMonedas.genMonedas and 
				genTipoCambio.Empresa_Id = genEmpresas.genEmpresas
/*where
	stkProductos.UMCompra = stkProductos.Medida_ID				
	*/

GO				
	

Drop view vStkExistencia
Go
Create view vStkExistencia
As
Select stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkExistencia.Cantidad, stkExistencia.CantidadReservada, stkExistencia.CantidadAlterna,
	stkExistencia.Empresa_Id
From stkExistencia
Inner Join stkProductos On stkProductos.stkProductos = stkExistencia.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkExistencia.Deposito_Id
Go

Drop view vgenContadorSegmento
Go
Create view vgenContadorSegmento
As
Select genContadorSegmento.Segmento2N, genContadorSegmento.Segmento3N, genContadorSegmento.Segmento4N,
genContadorSegmento.Segmento1C, genContadorSegmento.Segmento2C, genContadorSegmento.Segmento3C, genContadorSegmento.Segmento4C,
gensegmentos.Segmento_Id, genSegmentos.Descripcion, genContadorSegmento.Usuario_Id, genContadorSegmento.Empresa_Id
 From genContadorSegmento
Inner Join genSegmentos On genSegmentos.genSegmentos = genContadorSegmento.Segmento_Id



GO

DROP VIEW vconMetodos 
GO

CREATE VIEW vconMetodos  as 
Select 'MX' AS Dominio_Id, 1 as Metodo_Id, 'Tradicional' as Descripcion
UNION ALL
Select 'MX' AS Dominio_Id, 2 as Metodo_Id, 'Por Promedios' as Descripcion

GO


DROP VIEW vVenMovimientos 
GO
CREATE VIEW vVenMovimientos 
as
SELECT venMovimientos.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
conAsientos.Fecha, venMovimientos.venTipomov, 
ISNULL(venSubTipomov.SubTipomov_Id,'') SubTipomov_Id,
ISNULL(venClientes.Cliente_Id,'') Cliente_Id, 
ISNULL(venClientes.RazonSocial,'') RazonSocial, 
ISNULL(venSubTipomov.MueveStock,0) MueveStock ,
disFormularios.Formulario_Id , conAsientos.Empresa_Id as Empresa, conAsientos.Anulado,
	venMovimientos.Importe, venMovimientos.Saldo, venTipoMov.Signo,
	venVendedores.Vendedor_Id
FROM venMovimientos 
LEFT JOIN venSubTipomov ON venMovimientos.venSubTipomov_Id = venSubTipomov.venSubTipomov
left join venClientes	ON venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
LEFT OUTER JOIN disFormularios ON disFormularios.disFormularios= conAsientos.Formulario_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
left JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id

GO

DROP VIEW vtesFormularioCheque
GO
CREATE VIEW vtesFormularioCheque
AS
SELECT 0 as Formulario_Id,  'Cheque                    ' as Descripcion
UNION ALL
SELECT 1 as Formulario_Id,  'Cheque_Formulario_Continuo' as Descripcion
UNION ALL
SELECT 2 as Formulario_Id,  'Sin_Chequera' as Descripcion
GO

DROP VIEW vcomProveedoresCtasPasivo
GO
CREATE VIEW vcomProveedoresCtasPasivo
AS
Select comProveedoresCtasPasivo.TipoCtaProv, 
	comProveedoresTipoPasivo.Descripcion, 
	 comProveedores.Proveed_id, genMonedas.Moneda_Id,
		genMonedas.Descripcion as DescripcionMoneda, 
		conCuentas.Cuenta_id, conCuentas.Descripcion as DescripcionCuenta, 
		ISNULL(ctaPagoXAdelantado.Cuenta_Id,'') as ctaPagoXAdelantado, 
		ISNULL(ctaPagoXAdelantado.Descripcion,'') as DescripcionctaPagoXAdelantado
From 
comProveedoresCtasPasivo  inner join  comProveedoresTipoPasivo on
comProveedoresCtasPasivo.TipoCtaProv = comProveedoresTipoPasivo.TipoCtaProv
INNER JOIN comProveedores ON
comProveedores.genEntidades =  comProveedoresCtasPasivo.genEntidades
INNER JOIN conCuentas ON
conCuentas.conCuentas =  comProveedoresCtasPasivo.Cuenta_Id 
INNER JOIN genMonedas ON
comProveedoresCtasPasivo.Moneda_Id = genMonedas.genMonedas
LEFT OUTER JOIN conCuentas AS ctaPagoXAdelantado ON
ctaPagoXAdelantado.conCuentas =  comProveedoresCtasPasivo.ctaPagoXAdelantado
GO


DROP VIEW vComproveedores 
GO

CREATE VIEW vComproveedores 
AS
Select comProveedores.Proveed_id, comProveedores.RazonSocial, genEntidades.CUIT, comConPago.CondPago_Id, 
	comProveedores.Empresa_Id, comProveedores.NombreLegal, 
	comOrigenesFiscales.Origen_Id, comProveedores.Letra_Fact, MIN(comProveedoresCtasPasivo.TipoCtaProv) AS TipoCtaProv,
	comProveedores.Inactivo, comProveedores.Posteado, comProvTipos.ProvTipo_Id
From comProveedores inner join genEntidades on genEntidades.genEntidades = comProveedores.genEntidades
inner join comConPago ON comConPago.comConPago = comProveedores.CondPago_Id
inner join comOrigenesFiscales ON comOrigenesFiscales.comOrigenesFiscales = comProveedores.Origen_Id
inner join comProveedoresCtasPasivo On comProveedoresCtasPasivo.genEntidades = comProveedores.genEntidades
inner join comProvTipos ON comProvTipos.comProvTipos = comProveedores.ProvTipo_Id
Where comProveedores.Especializacion = 'H'
GROUP BY 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	genEntidades.CUIT, comConPago.CondPago_Id, 
	comProveedores.Empresa_Id, comProveedores.NombreLegal, 
	comOrigenesFiscales.Origen_Id,
	comProveedores.Letra_Fact, comProveedores.Inactivo, comProveedores.Posteado,
	comProvTipos.ProvTipo_Id

GO


DROP VIEW vComMovprov
GO

CREATE VIEW vComMovprov
AS

SELECT comMovProv.comMovProv, conAsientos.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	comMovprov.Tipomov, disFormularios.Formulario_Id, conAsientos.Empresa_Id as Empresa ,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante, comMovProv.TipoCtaProv, comMovProv.Fecha_CCP,
	comMovProv.Base_Ganancias, comMovProv.Importacion, comConPago.CondPago_Id, comCondFiscal.CondFiscal_Id, comOrigenesFiscales.Origen_Id,
	comMovProv.FechaFiscal, IsNull(comMovProv.ClaveFiscal, '') ClaveFiscal, comMovProv.VieneDeFiscal, comMovProv.XMLFiscal,
	comMovProv.Importe, comMovProv.Saldo, IsNull(comMovProv.TipoCompFE, 0) TipoCompFE, comMovProv.FacturaTesoreria, 
	conAsientos.Anulado
From comMovprov 
inner join comProveedores ON comMovprov.Proveed_Id = comProveedores.genEntidades
inner join conAsientos ON conAsientos.conAsientos = comMovprov.comMovProv
inner join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
left Join comConPago On comConPago.comConPago = comMovProv.ComCondPago_Id
left Join comCondFiscal On comCondFiscal.comCondFiscal = comMovProv.CondFiscal_Id
left Join comOrigenesFiscales On comOrigenesFiscales.comOrigenesFiscales = comMovProv.Origen_Id
GO


Drop view vvenListasPrecios
Go

Create view vvenListasPrecios
As
Select venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion, genMonedas.Moneda_Id, genMonedas.Descripcion DescripcionMoneda,
venListasPrecios.Inactivo, venListasPrecios.Posteado, venListasPrecios.Empresa_Id, venListasPrecios.UsuAutorizado
From venListasPrecios
Inner Join genMonedas On genMonedas.genMonedas = venListasPrecios.Moneda_Id
Go

Drop view vvenListasPrecProd
Go

Create view vvenListasPrecProd
As
Select venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion, genMonedas.Moneda_Id,
stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProducto, venListasPrecProd.PrecioLista, 
venListasPrecProd.Version, venListasVersion.VigenciaDesde, venListasVersion.VigenciaHasta
From venListasPrecProd
Inner Join venListasPrecios On venListasPrecProd.ListaPrecio_Id = venListasPrecios.venListasPrecios
Inner Join stkProductos On venListasPrecProd.Producto_Id = stkProductos.stkProductos
Inner Join genMonedas On genMonedas.genMonedas = venListasPrecios.Moneda_Id
INNER JOIN venListasVersion ON venListasVersion.ListaPrecio_Id =  venListasPrecProd.ListaPrecio_Id and 
	venListasVersion.Version = venListasPrecProd.Version
Go


Drop view vvenMovStkHist
Go
Create view vvenMovStkHist
As
Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) SegVentas, venMovStkHist.RenglonCuerpo,
dbo.Segmento(gasStock.Segmento_Id, gasStock.Segmento1C, gasStock.Segmento2C,
gasStock.Segmento3C, gasStock.Segmento4C, gasStock.Segmento1N, gasStock.Segmento2N, 
gasStock.Segmento3N, gasStock.Segmento4N) SegStock, venMovStkHist.Renglon, Cantidad, FacturaRemito
From venMovStkHist
Inner Join genAsiSegmentos On venMovStkHist.venMovimientos = genAsiSegmentos.Asiento_Id
Inner Join genAsiSegmentos gasStock On venMovStkHist.stkMoviCabe = gasStock.Asiento_Id
Go


Drop view vvenMovConStockCr
Go
Create view vvenMovConStockCr
As
Select venMovConStockCr.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) SegVentas,
venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, IsNull(stkDepositos.Deposito_Id, '') Deposito_Id, 
venMovConStockCr.Factor, venMovConStockCr.CantFacturada, stkUniMed.Medida_Id,
venMovConStockCr.CantEntregada, venMovConStockCr.CantPendiente, venMovConStockCr.CantOriginal, MedidaAlterna.Medida_Id MedidaAlterna,
venMovConStockCr.CantidadAlternaForm, venMovConStockCr.TipoPrecio, venMovConStockCr.PrecioForm, venMovConStockCr.PrecioLista,
venMovConStockCr.PrecioVenta, venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, venMovConStockCr.PrecioFormImpuestoTot, 
venMovConStockCr.ComiPorce, venMovConStockCr.Bonificacion, venMovConStockCr.Observaciones, venMovConStockCr.FechaEntrega,
venMovConStockCr.SubTotal, venMovConStockCr.SubTotalFormImpuesto /*, venMovConStockCr.CantidadAduana, venMovConStockCr.UnidadAduana,
venMovConStockCr.ValorUnitarioAduana, venMovConStockCr.ValorDolares */, conCentro1.Centro1_Id, conCentro2.Centro2_Id
From venMovConStockCr
Inner Join stkProductos On stkProductos.stkProductos = venMovConStockCr.Producto_Id
left Join stkDepositos On stkDepositos.stkDepositos = venMovConStockCr.Deposito_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = venMovConStockCr.Medida_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovConStockCr.venMovimientos
Left Join stkUniMed MedidaAlterna On MedidaAlterna.stkUniMed = venMovConStockCr.MedidaAlterna
Left Join conCentro1 On conCentro1.conCentro1 = venMovConStockCr.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venMovConStockCr.Centro2_Id
Go

Drop view vvenMovImpuestos
Go

Create view vvenMovImpuestos
As
Select venMovImpuestos.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) SegVentas, venMovImpuestos.conRenglon, venImpuestos.Impuesto_Id,
venMovImpuestos.Porcentaje, venMovImpuestos.BaseImponible, venMovImpuestos.Importe, venMovImpuestos.BaseImponibleMonedaNac
From venMovImpuestos
Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovImpuestos.venMovimientos
Go


Drop view vconAsientos
Go
Create view vconAsientos
As
Select conAsientos.conAsientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, genSegmentos.Segmento_Id,
conAsientos.Empresa_Id , Fecha, FechaRegistro, conAsientos.Usuario_Id,
genMonedas.Moneda_Id, conAsientos.Cambio, conAsientos.CambioMonedaOriginal, disFormularios.Formulario_Id, 
conAsientos.Anulado, conAsientos.Observaciones, conAsientos.Posteado
From conAsientos
Inner Join genUsuarios On genUsuarios.genUsuarios = conAsientos.Usuario_Id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
union all
Select conAsientos.conAsientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, genSegmentos.Segmento_Id,
conAsientos.Empresa_Id, Fecha, FechaRegistro, conAsientos.Usuario_Id,
genMonedas.Moneda_Id, conAsientos.Cambio, conAsientos.CambioMonedaOriginal, disFormularios.Formulario_Id, 
conAsientos.Anulado, conAsientos.Observaciones, conAsientos.Posteado
From conAsientos
Inner Join genUsuarios On genUsuarios.genUsuarios = conAsientos.Usuario_Id
Inner Join disFormularios On disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join comAsiSegmentosAnul as genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id

Go

Drop view vconMovCont
Go
Create view vconMovCont
As
Select genAsiSegmentos.Empresa_Id,
conMovCont.conAsientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conMovCont.Renglon, conCuentas.Cuenta_Id, 
conMovCont.LeyendaLibroMayor, conMovCont.Importe, conMovCont.ImporteMonedaOriginal, conMovCont.TipoMov,
conCentro1.Centro1_Id, conCentro2.Centro2_Id, conMovCont.Clase
From conMovCont
Inner Join conCuentas On conCuentas.conCuentas = conMovCont.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = conMovCont.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = conMovCont.Centro2_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conMovCont.conAsientos
Go


Drop view vvenMovConStockCrPed
Go

Create view vvenMovConStockCrPed
As
Select venMovConStockCrPed.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, 
venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) Pedido, venMovConStockCrPed.Renglon_Pe,
venMovConStockCrPed.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) venComprobante, venMovConStockCrPed.RenglonCuerpo, venMovConStockCrPed.venReparto,
dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, 
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Reparto
From venMovConStockCrPed
Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venMovConStockCrPed.venPedidos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovConStockCrPed.venMovimientos
Left Join venRepaSegmentos On venRepaSegmentos.venReparto = venMovConStockCrPed.venReparto
Go

Drop view vvenPediCuerpo
Go
Create view vvenPediCuerpo
As
Select venPediCuerpo.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, 
venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) Pedido, venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id,
stkUniMed.Medida_Id, stkDepositos.Deposito_Id, Factor, CantidadOriginal, CantidadPedida, CantidadRemitida, CantidadFacturada, PrecioForm,
PrecioLista, PrecioVenta, FechaEntrega, Especial, Bonificacion, venPediCuerpo.Observaciones, Pendiente, ReservaMercaderia,
conCentro1.Centro1_Id, conCentro2.Centro2_Id
From venPediCuerpo
Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPediCuerpo.venPedidos
Inner Join stkProductos On stkProductos.stkProductos = venPediCuerpo.Producto_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = venPediCuerpo.Medida_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = venPediCuerpo.Deposito_Id
Left Join conCentro1 On conCentro1.conCentro1 = venPediCuerpo.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = venPediCuerpo.Centro2_Id
Go

Drop view vstkMoviCuerpo
Go
Create view vstkMoviCuerpo
As
Select stkMoviCabe, 
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante,
Renglon, Fecha, stkDepositos.Deposito_Id, stkProductos.Producto_Id, stkUniMed.Medida_Id, stkMoviCuerpo.Factor,
stkMoviCuerpo.Cantidad, stkMoviCuerpo.CantidadForm, stkMoviCuerpo.CostoUnitario, stkMoviCuerpo.PrecioOriginal, stkMedidaAlterna.Medida_Id MedidaAlterna,
stkMoviCuerpo.CantidadAlternaForm, stkMoviCuerpo.Observaciones, stkMoviCuerpo.Descuento, stkMoviCuerpo.conRenglonDebe, stkMoviCuerpo.conRenglonHaber,
stkMoviCuerpo.RenglonCombo
From stkMoviCuerpo inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkMoviCuerpo.stkMoviCabe
Inner Join stkDepositos On stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Inner Join stkProductos On stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
Inner Join stkUniMed On stkUniMed.stkUniMed = stkMoviCuerpo.Medida_Id
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkMoviCuerpo.MedidaAlterna
Go

Drop view vvenPediRemitidos
Go
Create view vvenPediRemitidos
As
Select venPediRemitidos.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, 
venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) Pedido,
venPediRemitidos.Renglon_Pe, venPediRemitidos.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, venPediRemitidos.Renglon,
 venPediRemitidos.venReparto, dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, 
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Reparto
From venPediRemitidos
Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPediRemitidos.venPedidos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venPediRemitidos.stkMoviCabe
Left Join venRepaSegmentos On venRepaSegmentos.venReparto = venPediRemitidos.venReparto
Go

Drop view vvenRepaPedi
Go
Create view vvenRepaPedi
As
Select venRepaPedi.venReparto, dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, 
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Reparto, venRepaPedi.Renglon_Rep, 
venRepaPedi.venPedidos, dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, 
venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N) Pedido, venRepaPedi.Renglon_Pe,
venRepaPedi.CantidadForm, venRepaPedi.CantidadAlternaForm, venRepaPedi.Remitido, venRepaPedi.Facturado
From venRepaPedi
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venRepaPedi.venReparto
Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venRepaPedi.venPedidos
Go

Drop view vstkMoviCausa
Go
Create view vstkMoviCausa
As
Select stkMoviCausa.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, stkCausasMovi.Causa_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id
From stkMoviCausa
Inner Join stkCausasMovi On stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id
Left Join conCentro1 On conCentro1.conCentro1 = stkMoviCausa.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = stkMoviCausa.Centro2_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviCausa.stkMoviCabe
Go


Drop view vstkRemitos
Go
Create view vstkRemitos
As
Select stkRemitos.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, venClientes.Cliente_Id, stkRemitos.Sucursal,
	venClientes.RazonSocial,
venListasPrecios.ListaPrecio_Id, stkRemitos.HojaRuta_Id, conAsientos.Fecha, stkMoviCabe.SubTipoMov_Id,
	disFormularios.Formulario_Id,conAsientos.Posteado, conAsientos.Empresa_Id Empresa,
	conAsientos.Anulado, genSucursalesEmpr.Sucursal SucursalFiltro, 
	case when conAsientos.Anulado=1 then 'A' WHEN
	exists(select 1 from stkRemiPendFact where	stkRemiPendFact.stkMoviCabe = stkMoviCabe.stkMoviCabe AND 
		stkRemiPendFact.CantidadPendiente > 0) then 'P' ELSE 'F' END AS Estado
From stkRemitos
Inner Join venClientes On venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos =stkRemitos.stkMoviCabe
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe =stkRemitos.stkMoviCabe
INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Left Join venListasPrecios On venListasPrecios.venListasPrecios = stkRemitos.ListaPrecio_Id
Go


Drop view vstkRemitosPend
Go
Create view vstkRemitosPend
As
Select stkRemitos.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, venClientes.Cliente_Id, stkRemitos.Sucursal,
	venClientes.RazonSocial,
venListasPrecios.ListaPrecio_Id, stkRemitos.HojaRuta_Id, conAsientos.Fecha, stkMoviCabe.SubTipoMov_Id,
	disFormularios.Formulario_Id,conAsientos.Posteado, conAsientos.Empresa_Id Empresa,
	conAsientos.Anulado, genSucursalesEmpr.Sucursal SucursalFiltro
From stkRemitos
Inner Join venClientes On venClientes.genEntidades = stkRemitos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos =stkRemitos.stkMoviCabe
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN stkMoviCabe ON stkMoviCabe.stkMoviCabe =stkRemitos.stkMoviCabe
INNER JOIN disFormularios ON  disFormularios.disFormularios = conAsientos.Formulario_Id
INNER JOIN genSucursalesEmpr ON  genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Left Join venListasPrecios On venListasPrecios.venListasPrecios = stkRemitos.ListaPrecio_Id
Where
	Exists(select 1 from stkRemiPendFact where stkRemiPendFact.stkMoviCabe =  stkmovicabe.stkMoviCabe and stkRemiPendFact.CantidadPendiente >0)
Go





Drop view vstkRemiPendFact
Go
Create view vstkRemiPendFact
As
Select stkRemiPendFact.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito,
stkRemiPendFact.Renglon, stkRemiPendFact.CantidadPendiente
From stkRemiPendFact
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkRemiPendFact.stkMoviCabe
Go

Drop view vstkHojaDeRuta
Go
Create view vstkHojaDeRuta
As
Select stkHojaDeRuta.stkHojaDeRuta, ISNULL(venFormaEntrega.FormaEntrega_id,'') FormaEntrega_id, 
ISNULL(venFormaEntrega.RazonSocial,'') RazonSocial, FechaRegistro, 
ISNULL(venCamiones.Patente_Id,' ') as Patente_Id, 
ISNULL(venAcoplados.Patente_Id,' ') as PatenteAcoplado,
dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, 
venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Reparto, 
stkHojaDeRuta.Estado
From stkHojaDeRuta
Left Join venRepaSegmentos On venRepaSegmentos.venReparto = stkHojaDeRuta.venReparto
left Join venCamiones On venCamiones.venCamiones = stkHojaDeRuta.Patente_Id
Left Join venCamiones venAcoplados On venAcoplados.venCamiones = stkHojaDeRuta.PatenteAcoplado
LEFT JOIN venFormaEntrega ON stkHojaDeRuta.FormaEntrega_id = venFormaEntrega.venFormaEntrega
Go



Drop view vgenAsiSegmentos
GO
Create view vgenAsiSegmentos
As
Select genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Asiento_Id
From genAsiSegmentos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Go

DROP VIEW  vtesMovimientos
GO
CREATE VIEW  vtesMovimientos as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
tesSubTiposMov.SubTipo_Id, conAsientos.Posteado, disFormularios.Formulario_Id, tesMovimientos.tesMovimientos, 
conAsientos.Anulado, genAsiSegmentos.Empresa_Id as Empresa, genSucursalesEmpr.Sucursal SucursalMov
From tesMovimientos
Inner join conAsientos ON tesMovimientos.tesMovimientos= conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
inner join tesSubTiposMov ON tesMovimientos.SubTipo_id = tesSubTiposMov.tesSubTiposMov
Inner Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
GO

DROP VIEW  vtesMovimientosTodasSuc
GO
CREATE VIEW  vtesMovimientosTodasSuc as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
tesSubTiposMov.SubTipo_Id, conAsientos.Posteado, disFormularios.Formulario_Id, tesMovimientos.tesMovimientos, 
conAsientos.Anulado, genAsiSegmentos.Empresa_Id as Empresa, Cast(Null As varChar(5)) SucursalMov
From tesMovimientos
Inner join conAsientos ON tesMovimientos.tesMovimientos= conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
inner join tesSubTiposMov ON tesMovimientos.SubTipo_id = tesSubTiposMov.tesSubTiposMov

GO


Drop view vstkExistenciaDespa
Go
Create view vstkExistenciaDespa
As
Select stkProductos.Producto_Id, stkDepositos.Deposito_Id, comDespachos.Despacho_Id, stkExistenciaDespa.Cantidad, stkExistenciaDespa.Empresa_Id
From stkExistenciaDespa
Inner Join stkProductos On stkProductos.stkProductos = stkExistenciaDespa.Producto_Id
Inner Join comDespachos On comDespachos.comDespachos = stkExistenciaDespa.Despacho_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkExistenciaDespa.Deposito_Id
Go

Drop view vstkMoviDespa
Go
Create view vstkMoviDespa
As
Select stkMoviDespa.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, stkMoviDespa.Renglon, comDespachos.Despacho_Id, stkMoviDespa.Cantidad
From stkMoviDespa
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviDespa.stkMoviCabe
Inner Join comDespachos On comDespachos.comDespachos = stkMoviDespa.Despacho_Id
Go


Drop view vstkExistenciaSerie
Go
Create view vstkExistenciaSerie
As
Select stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkExistenciaSerie.Serie, stkExistenciaSerie.Cantidad, stkExistenciaSerie.Empresa_Id
From stkExistenciaSerie
Inner Join stkProductos On stkProductos.stkProductos = stkExistenciaSerie.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkExistenciaSerie.Deposito_Id
Go


Drop view vstkMoviSerie
GO
Create view vstkMoviSerie
As
Select stkMoviSerie.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, stkMoviSerie.Renglon, stkMoviSerie.Serie, stkMoviSerie.Cantidad
From stkMoviSerie
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviSerie.stkMoviCabe
Go


Drop view vstkExistenciaSerieVto
Go
Create view vstkExistenciaSerieVto
As
Select stkExistenciaSerie.Empresa_Id, stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkExistenciaSerie.Serie,
stkExistenciaSerie.Cantidad, stkSerieVencimiento.Vencimiento
From stkExistenciaSerie
Left Join stkSerieVencimiento On stkSerieVencimiento.Producto_Id = stkExistenciaSerie.Producto_Id And
	stkSerieVencimiento.Serie = stkExistenciaSerie.Serie And stkSerieVencimiento.Empresa_Id = stkExistenciaSerie.Empresa_Id
Inner Join stkProductos On stkProductos.stkProductos = stkExistenciaSerie.Producto_Id
Inner Join stkDepositos On stkDepositos.stkDepositos = stkExistenciaSerie.Deposito_Id
Go


drop view vComImpuestos 
GO
Create view vComImpuestos 
as

SELECT comImpuestos.comImpuestos, comImpuestos.Empresa_Id, comImpuestos.Impuesto_Id, comImpuestos.Descripcion, 
	comImpuestos.TipoImpuesto, comImpuestos.Formulacalc,
	comImpuestos.Posteado, 
	comImpuestos.Inactivo, CtaDebe.Cuenta_Id AS CtaDebe, 
	CtaHaber.Cuenta_ID AS CtaHaber, CtaReversion.Cuenta_Id CtaReversion, comImpuestos.Porcentaje,
	comImpuestos.Fecha_Desde, comImpuestos.Fecha_Hasta, comImpuestos.Depende_de, comImpuestos.VaAlCosto,
	comImpuestos.PorAcreditacion, genUsuarios.Usuario_Id
	FROM comImpuestos 
	INNER JOIN conCuentas AS CtaDebe ON comImpuestos.CtaDebe = CtaDebe.conCuentas 
	INNER JOIN conCuentas AS CtaHaber ON comImpuestos.CtaHaber = CtaHaber.conCuentas
	Left Join conCuentas CtaReversion On comImpuestos.CtaReversion = CtaReversion.conCuentas
	Inner Join genUsuarios On genUsuarios.genUsuarios = comImpuestos.Usuario_Id
GO

drop view vComprovAnexo
GO
Create view vComProvAnexo
AS
/*
SELECT genEntidades.CUIT as Codigo, genEntidades.CUIT, comProvAnexo.RazonSocial,genEntidades.TipoDoc,
	genEntidades.idFiscal,Direccion1,Direccion2,Cod_Postal,genProvincias.Provincia_id,
	comCondFiscal.CondFiscal_Id, Localidad
FROM genEntidades INNER JOIN comProvAnexo ON 
	genEntidades.genEntidades = comProvAnexo.genEntidades 
	INNER JOIN genProvincias on 
	comProvAnexo.Provincia_Id = genProvincias.genProvincias 
	INNER JOIN comCondFiscal ON 
	comCondFiscal.comCondFiscal = comProvAnexo.CondFiscal_Id
union all
*/
SELECT comProveedores.Proveed_Id as Codigo, genEntidades.CUIT,  comProveedores.RazonSocial,genEntidades.TipoDoc,
	genEntidades.idFiscal, Direccion1,Direccion2, comProveedores.CodigoPostal as Cod_Postal,
	genProvincias.Provincia_Id, comCondFiscal.CondFiscal_Id, Localidad, comOrigenesFiscales.Origen_Id,
	comProveedores.Inactivo, comProveedores.Empresa_Id, comProveedores.Posteado
FROM genEntidades 
INNER JOIN comProveedores ON genEntidades.genEntidades = comProveedores.genEntidades 
LEFT JOIN genProvincias on comProveedores.Provincia_Id = genProvincias.genProvincias 
LEFT JOIN comCondFiscal ON comCondFiscal.comCondFiscal = comProveedores.CondFiscal_Id
LEFT Join comOrigenesFiscales On comOrigenesFiscales.comOrigenesFiscales = comProveedores.Origen_Id
GO



DROP VIEW vComMovPAnexo
GO

CREATE VIEW vComMovPAnexo
AS
SELECT genEntidades.CUIT,comProvAnexo.RazonSocial,
	Direccion1,Direccion2,Cod_Postal,genProvincias.Provincia_id,
	comCondFiscal.CondFiscal_Id, Localidad, conMovCont.TipoMov, 
		comMovpAnexo.Fecha_Ane, comMovpAnexo.Asiento_Id
FROM comMovpAnexo INNER JOIN comProvAnexo ON 
	comMovpAnexo.ProvAnexo = comProvAnexo.genEntidades
	INNER JOIN genEntidades ON
	genEntidades.genEntidades = comProvAnexo.genEntidades 
	INNER JOIN genProvincias on 
	comProvAnexo.Provincia_Id = genProvincias.genProvincias 
	INNER JOIN comCondFiscal ON 
	comCondFiscal.comCondFiscal = comProvAnexo.CondFiscal_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = comMovpAnexo.tesRengMovi_Id and 
	conMovCont.Renglon = comMovpAnexo.RenglonRengMovi
GO



Drop view vconAsientosCon
Go

Create view vconAsientosCon
As
Select conAsientos.conAsientos, conAsientos.Empresa_Id Empresa,
conAsientosCon.LeyendaLibroDiario,
Fecha, FechaRegistro, 
disFormularios.Formulario_Id, Anulado, conAsientos.Posteado
From conAsientos INNER JOIN conAsientosCon ON
conAsientos.conAsientos = conAsientosCon.conAsientos
Inner Join disFormularios On 
disFormularios.disFormularios = conAsientos.Formulario_Id
Go


DROP VIEW tesTiposMov
GO

CREATE VIEW tesTiposmov as
	select 'I' AS Tipomov,  'Ingreso' AS Descripcion
	Union 
	select 'E' AS Tipomov,  'Egreso' AS Descripcion


GO

Drop VIEW vvcomProveedoresCtas
Go
CREATE VIEW vvcomProveedoresCtas
AS
Select comProveedoresCtasPasivo.genEntidades, comProveedores.Proveed_Id, comProveedoresCtasPasivo.TipoCtaProv, 
comProveedoresTipoPasivo.Descripcion DescripcionTipoPasivo,
		genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, 
		conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
		ISNULL(CuentaAnticipo.Cuenta_Id,'') as CtaAnticipo, 
		ISNULL(CuentaAnticipo.Descripcion,'') as DescripcionCtaAnticipo,
		ISNULL(conCuentas1.Cuenta_Id,'') as CtaPasivo, 
		ISNULL(conCuentas1.Descripcion,'') as DescripcionCtaPasivo
From comProveedoresCtasPasivo
INNER JOIN comProveedores ON comProveedores.genEntidades = comProveedoresCtasPasivo.genEntidades
Inner Join comProveedoresTipoPasivo On comProveedoresTipoPasivo.TipoCtaProv = comProveedoresCtasPasivo.TipoCtaProv
LEFT JOIN conCuentas ON conCuentas.conCuentas =  comProveedoresCtasPasivo.ctaPagoXAdelantado
LEFT JOIN conCuentas conCuentas1 ON conCuentas1.conCuentas =  comProveedoresCtasPasivo.Cuenta_Id
Left Join conCuentas CuentaAnticipo On CuentaAnticipo.conCuentas = comProveedoresCtasPasivo.CtaAnticipo
INNER JOIN genMonedas ON comProveedoresCtasPasivo.Moneda_Id = genMonedas.genMonedas
Go

Drop view vcomMovDetalle
Go
Create view vcomMovDetalle
AS
Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, comMovDetalle.comMovProv, Renglon, Detalle, Importe,
conCuentas.Cuenta_Id, IsNull(conCentro1.Centro1_Id, '') Centro1_Id, IsNull(conCentro2.Centro2_Id, '') Centro2_Id,
IsNull(conBaseDistri.Base_Id, '') Base_Id
From comMovDetalle
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovDetalle.comMovProv
Inner Join conCuentas On conCuentas.conCuentas = comMovDetalle.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = comMovDetalle.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = comMovDetalle.Centro2_Id
Left Join conBaseDistri On conBaseDistri.conBaseDistri = comMovDetalle.Base_Id
Go

Drop view vconCuentas
Go
Create view vconCuentas
As
Select conCuentas, Cuenta_Id, IsNull(genEmpresas.Empresa_Id, '') Empresa_Id, IsNull(Tipo_Id, '') Tipo_Id, conCuentas.Descripcion,
conCuentas.Rubro_Id, Imputable, Nivel, Naturaleza, IsNull(conBaseDistri.Base_Id, '') Base_Id, IsNull(conGruposCont.Grupo_Id, '') Grupo_Id,
IsNull(conCuadro1Filas.Cuadro1Fila_Id, '') CuadroFila_Id, IsNull(ReservadaPor, '') ReservadaPor, Fecha_Reserva,
IsNull(conSubCuentas.SubCuenta_Id, '') SubCuenta_Id, NoSeReserva, IsNull(conSituPatri.Rubro_Balance, '') Rubro_Balance,
conCuentas.Ajustable, Notas, IsNull(genMonedas.Moneda_Id, '') Moneda_Id, IsNull(conIndicesAjustes.Indice_Id, '') Indice_Id, Metodo,
EliminaConsolida, conCuentas.Inactivo, IsNull(TipoSAT_Id, '') TipoSAT_Id, genUsuarios.Usuario_Id, conCuentas.Posteado
From conCuentas
Left Join genEmpresas On genEmpresas.genEmpresas = conCuentas.Empresa_Id
Left Join conBaseDistri On conBaseDistri.conBaseDistri = conCuentas.Base_Id
Left Join conGruposCont On conGruposCont.conGruposCont = conCuentas.Grupo_Id
Left Join conCuadro1Filas On conCuadro1Filas.conCuadro1Filas = conCuentas.Cuadro1Fila_Id
Left Join conSubCuentas On conSubCuentas.conSubCuentas = conCuentas.SubCuenta_Id
Left Join conSituPatri On conSituPatri.Rubro_Balance = conCuentas.Rubro_Balance
Left Join genMonedas On genMonedas.genMonedas = conCuentas.Moneda_Id
Left Join conIndicesAjustes On conIndicesAjustes.conIndicesAjuste = conCuentas.Indice_Id
Inner Join genUsuarios On genUsuarios.genUsuarios = conCuentas.Usuario_Id
Go

Drop view vgenCancMov
Go
Create view vgenCancMov
As
Select genCancMov.Asiento_Id, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, genCancMov.CuotaNro,
genCancMov.Asiento_Id_Ap, dbo.Segmento(genAsiSegmentosAp.Segmento_Id, genAsiSegmentosAp.Segmento1C, genAsiSegmentosAp.Segmento2C,
genAsiSegmentosAp.Segmento3C, genAsiSegmentosAp.Segmento4C, genAsiSegmentosAp.Segmento1N, genAsiSegmentosAp.Segmento2N,
genAsiSegmentosAp.Segmento3N, genAsiSegmentosAp.Segmento4N) SegmentoAp, genCancMov.CuotaNro_Ap,
genCancMov.NroAplicacion, genUsuarios.Usuario_Id, genCancMov.FechaAplicacion, genCancMov.Importe, genCancMov.Importe_Ap, genCancMov.AsientoApli_Id,
	genCancMov.Importacion, genCancMov.EsAplicOriginal, genCancMov.AsieDifCambio_Id
From genCancMov
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = genCancMov.Asiento_Id
Inner Join genAsiSegmentos genAsiSegmentosAp On genAsiSegmentosAp.Asiento_Id = genCancMov.Asiento_Id_Ap
Inner Join genUsuarios On genUsuarios.genUsuarios = genCancMov.Usuario_Id
Go



Drop view vgenMovCuotas
Go
Create view vgenMovCuotas
As
Select genMovCuotas.Asiento_Id, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo
From genMovCuotas
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = genMovCuotas.Asiento_Id
Go

Drop view vcomPagosHabilitados
Go
Create view vcomPagosHabilitados
As
Select comPagosHabilitados.comMovProv, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Factura, comPagosHabilitados.Secuencia,
genUsuarios.Usuario_Id, comPagosHabilitados.FechaHabilitacion, comPagosHabilitados.ImporteHabilitado,
dbo.Segmento(genAsiTes.Segmento_Id, genAsiTes.Segmento1C, genAsiTes.Segmento2C,
genAsiTes.Segmento3C, genAsiTes.Segmento4C, genAsiTes.Segmento1N, genAsiTes.Segmento2N,
genAsiTes.Segmento3N, genAsiTes.Segmento4N) Pago, comPagosHabilitados.Importe1, comPagosHabilitados.Importe2,
comPagosHabilitados.Importe3
From comPagosHabilitados
Inner Join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comPagosHabilitados.comMovProv
Inner Join genUsuarios On genUsuarios.genUsuarios = comPagosHabilitados.Usuario_Id
Left Join genAsiSegmentos genAsiTes On genAsiTes.Asiento_Id = comPagosHabilitados.tesMovimientos
Go


DROP VIEW comParaSugerido
GO
CREATE VIEW comParaSugerido
AS
SELECT  genEntidades.Cuit, comMovDetalle.Detalle, 
				conCuentas.Cuenta_Id, conCuentas.Descripcion, 
				conCentro1.Centro1_Id, conCentro2.Centro2_Id
				FROM 
				comMovDetalle inner join comMovProv ON
				comMovDetalle.comMovProv = comMovProv.comMovProv
				INNER JOIN conMovCont ON 
				conMovCont.conAsientos =comMovDetalle.comMovProv AND 
				conMovCont.Renglon = comMovDetalle.Renglon
				INNER JOIN conCuentas ON
				conCuentas.conCuentas = conMovCont.Cuenta_Id
				LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
				LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
				inner join genEntidades ON
				genEntidades.genEntidades = comMovprov.Proveed_Id
				
GO


Drop view vcomMovImpuestos
Go
Create view vcomMovImpuestos
As
Select comMovImpuestos.comMovProv, comMovImpuestos.conRenglon, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante, comImpuestos.Impuesto_Id, comMovImpuestos.Porcentaje,
comMovImpuestos.Base_Imponible, comMovImpuestos.Importe_Impuesto
From comMovImpuestos
Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovImpuestos.comMovProv
Go

Drop view vtesRengMoviRetProv
Go
Create view vtesRengMoviRetProv
As
Select tesRengMoviRetProv.tesMovimientos, tesRengMoviRetProv.conRenglon, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante, tesRengMoviRetProv.Porcentaje, tesRengMoviRetProv.Exencion,
tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Acum, tesRengMoviRetProv.TRet, tesRengMoviRetProv.AcumTot, 
dbo.Segmento(genAsiFactura.Segmento_Id, genAsiFactura.Segmento1C, genAsiFactura.Segmento2C, genAsiFactura.Segmento3C, genAsiFactura.Segmento4C, 
genAsiFactura.Segmento1N, genAsiFactura.Segmento2N, genAsiFactura.Segmento3N, genAsiFactura.Segmento4N) Factura
From tesRengMoviRetProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesRengMoviRetProv.tesMovimientos
Inner Join genAsiSegmentos genAsiFactura On genAsiFactura.Asiento_Id = tesRengMoviRetProv.tesMovimientos
Go

Drop view vtesBPLink
Go
Create view vtesBPLink
As
Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante, tesBPlink.tesMovimientos, tesBPlink.conRenglon, tesBPlink.Estado_Id,
tesBPlink.Secuencia, tesBPlink.tesCheqProp, tesIdentifica.Cartera_Id, tesCheqProp.numCheque, tesCheqProp.Chequera_Id,
tesCheqProp.FechaVencimiento
From tesBPlink
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesBPlink.tesMovimientos
Inner Join tesCheqProp On tesCheqProp.tesCheqProp = tesBPlink.tesCheqProp
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id
Go


DROP VIEW vComproveedoresAnexo
GO

CREATE VIEW vComproveedoresAnexo
AS
Select comProveedores.Proveed_Id, comProveedores.RazonSocial, genEntidades.CUIT, comConPago.CondPago_Id, 
	comProveedores.Empresa_Id, comProveedores.NombreLegal, comOrigenesFiscales.Origen_Id, comProveedores.Letra_Fact, 
	MIN(comProveedoresCtasPasivo.TipoCtaProv) AS TipoCtaProv
From comProveedores 
Inner join genEntidades on genEntidades.genEntidades = comProveedores.genEntidades
Inner join comConPago ON comConPago.comConPago = comProveedores.CondPago_Id
Inner join comOrigenesFiscales ON comOrigenesFiscales.comOrigenesFiscales = comProveedores.Origen_Id
Inner join comProveedoresCtasPasivo On comProveedoresCtasPasivo.genEntidades = comProveedores.genEntidades
Where comProveedores.Especializacion = 'A'
GROUP BY 
	comProveedores.Proveed_id, comProveedores.RazonSocial, 
	genEntidades.CUIT, comConPago.CondPago_Id, 
	comProveedores.Empresa_Id, comProveedores.NombreLegal, 
	comOrigenesFiscales.Origen_Id,
	comProveedores.Letra_Fact

GO

DROP VIEW vstkInventarios
GO
CREATE VIEW vstkInventarios as 
SELECT stkInventarios.stkInventarios, stkInventarios.FechaInventario, stkDepositos.Deposito_Id, stkDepositos.Descripcion,
	stkInvenSegmentos.Empresa_Id as Empresa 
	FROM stkInventarios INNER JOIN stkDepositos 
		ON stkInventarios.Deposito_Id = stkDepositos.stkDepositos
		inner join stkInvenSegmentos on 
		stkInvenSegmentos.stkInventarios = stkInventarios.stkInventarios
		
go
DROP VIEW vcomProveedoresTipoPasivoAnti
GO

CREATE VIEW [dbo].[vcomProveedoresTipoPasivoAnti]
AS
Select Distinct comProveedores.Proveed_Id, comProveedoresCtasPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion
From 
comProveedoresCtasPasivo  
INNER JOIN comProveedores ON comProveedores.genEntidades = comProveedoresCtasPasivo.genEntidades
INNER JOIN comProveedoresTipoPasivo ON comProveedoresTipoPasivo.TipoCtaProv = comProveedoresCtasPasivo.TipoCtaProv
Where Not comProveedoresCtasPasivo.CtaAnticipo Is Null

GO
drop view vconAnexosGrupos
go
create view vconAnexosGrupos
as
select conAnexosGrupos.GrupoAne_Id,conAnexosGrupos.Descripcion,  conAnexosOrigenes.Origen,
conAnexosOrigenes.Descripcion as DescripcionOrigen, conAnexosOrigenes.TipoRubro
 from conAnexosGrupos inner join conAnexosOrigenes on conAnexosGrupos.Origen=conAnexosOrigenes.Origen
go

drop view vconTiposContables
go
create view vconTiposContables
as
select Tipo_Id, conTiposContables.Descripcion, Tipo, conRubros.Rubro_Id from conTiposContables inner join conRubros on conTiposContables.Rubro_Id=conRubros.Rubro_Id
UNION ALL
select Tipo_Id, conTiposContables.Descripcion, 'IM', conRubros.Rubro_Id Tipo from conTiposContables inner join conRubros on conTiposContables.Rubro_Id=conRubros.Rubro_Id
WHERE
conRubros.Tipo = 'OE'
go



Drop view vcomEmbarques
GO
create view vcomEmbarques AS
select comEmbarques, TipoTransporte, NroOrdenExterior, 
	FechaEmbarque, FechaArribo,PesoTotal, Estado_id , 
	genAsiSegmentos.Empresa_Id AS Empresa, 
	conAsientos.Fecha, conAsientos.Anulado
	from comEmbarques inner join genAsiSegmentos ON
	comEmbarques.comEmbarques = genAsiSegmentos.Asiento_Id
	inner join conAsientos ON
	conAsientos.conAsientos =comEmbarques.comEmbarques
GO




DROP VIEW vstkProductosCom
GO

CREATE VIEW vstkProductosCom
AS
SELECT SPOrig.Producto_Id,SPOrig.Descripcion,
	vUltimaCompra.Empresa_Id,SPOrig.Posteado,Acepta_Compras,UMCompra,Costo,Moneda_Id,MedidaAlterna,Inactivo, 
	SPOrig.Familia_Id, SPOrig.Grupo_Id, SPOrig.Observaciones, SPOrig.CodigoBarra
	FROM vstkProductos SPOrig INNER JOIN  vUltimaCompra ON 
	vUltimaCompra.Producto_id = SPOrig.stkProductos

GO


DROP VIEW  vstkMoviCabeCD 
GO
CREATE VIEW  vstkMoviCabeCD as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
vstkMoviCabe.SubTipomov_id,conAsientos.Posteado, disFormularios.Formulario_Id, vstkMoviCabe.stkMoviCabe, 
genAsiSegmentos.Empresa_Id as Empresa, conAsientos.Anulado
from vstkMoviCabe 
Inner join conAsientos ON vstkmovicabe.stkmovicabe = conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = vstkMoviCabe.stkMoviCabe
where exists(select 1 from stkEnTransito where stkEntransito.stkMoviCabe=vstkMoviCabe.stkMoviCabe and  stkEnTransito.stkMoviCabeEntr is null)
GO


DROP VIEW vstkProductosCostoCierre
GO

CREATE VIEW vstkProductosCostoCierre as
SELECT stkProductos.Producto_Id, stkProductosCostoCierre.Empresa_Id, stkProductosCostoCierre.Fecha, stkProductosCostoCierre.Costo
from stkProductosCostoCierre inner join stkProductos ON
stkProductosCostoCierre.Producto_Id = stkProductos.stkProductos
go

Drop view vvenMovimientosCFDIR
Go

Create view vvenMovimientosCFDIR
As
Select venMovimientosCFDIR.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Comprobante,
venMovimientosCFDIR.venMovimientosR, dbo.Segmento(genAsiRelacionado.Segmento_Id, genAsiRelacionado.Segmento1C, genAsiRelacionado.Segmento2C,
genAsiRelacionado.Segmento3C, genAsiRelacionado.Segmento4C, genAsiRelacionado.Segmento1N, genAsiRelacionado.Segmento2N,
genAsiRelacionado.Segmento3N, genAsiRelacionado.Segmento4N) Relacionado, isNull(TipoRelacion, '') TipoRelacion
From venMovimientosCFDIR
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovimientosCFDIR.venMovimientos
Inner Join genAsiSegmentos genAsiRelacionado On genAsiRelacionado.Asiento_Id = venMovimientosCFDIR.venMovimientosR
Go



DROP View vConAsientosGen
GO
Create View vConAsientosGen
AS
SELECT conAsientos.Fecha, conAsientos.FechaRegistro, genAsiSegmentos.Empresa_Id as Empresa, 
	disFormularios.Formulario_Id, conAsientos.Anulado, conAsientos.conAsientos as Asiento_Id, 
	conAsientos.Posteado
From conAsientos INNER JOIN genAsiSegmentos ON
	conAsientos.conAsientos =  genAsiSegmentos.Asiento_Id 
	inner join disFormularios ON
	disFormularios.disFormularios = conAsientos.Formulario_Id
GO

DROP view vconTiposOrigen
GO
Create view vconTiposOrigen
AS
SELECT 'GAS' Origen, 'Gasto' Descripcion
union
SELECT 'COS' Origen, 'Costo' Descripcion
union
SELECT 'ING' Origen, 'Ingresos' Descripcion
union
SELECT 'OI' Origen, 'Otros Ingresos' Descripcion
union
SELECT 'OE' Origen, 'Otros Egresos' Descripcion
GO

Drop view vconOAFDestinos
GO
Create view vconOAFDestinos
AS
SELECT 10 Destino, 'Gastos que no significan Variacion del Capital Corriente' as Descripcion
UNION
SELECT 20,'Movimientos Patrimoniales'
UNION
SELECT 30,'Aplicaciones de Capital Corriente'
GO


DROP VIEW vtesRengmovi
GO
CREATE VIEW vtesRengmovi
AS
SELECT tesRengmovi.tesMovimientos, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as Comprobante,
tesRengMovi.conRenglon,  
tesIdentifica.Cartera_Id, tesIdentifica.Descripcion DescripcionCartera, tesRengMovi.Cambio,
		conMovCont.Importe, conMovCont.ImporteMonedaOriginal, 
		conMovCont.TipoMov, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
		conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionC1, 
		conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionC2
FROM tesRengmovi inner join conMovcont ON
tesRengmovi.tesMovimientos = conMovCont.conAsientos and 
tesRengmovi.conRenglon = conMovCont.Renglon
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_Id
LEFT JOIN conCentro1 ON 
conCentro1.conCentro1 = conMovCont.Centro1_Id
LEFT JOIN conCentro2 ON 
conCentro2.conCentro2 = conMovCont.Centro2_Id
INNER JOIN tesIdentifica ON
tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = tesRengMovi.tesMovimientos
GO


Drop view vtesCfdiCobranza
GO

CREATE View vtesCfdiCobranza 
AS

SELECT tesCFDICobranza.tesCFDICobranza,		
dbo.Segmento(TesCFDICobranzaSegmentos.Segmento_Id, 
	TesCFDICobranzaSegmentos.Segmento1C,TesCFDICobranzaSegmentos.Segmento2C,
	TesCFDICobranzaSegmentos.Segmento3C, TesCFDICobranzaSegmentos.Segmento4C,
	TesCFDICobranzaSegmentos.Segmento1N,TesCFDICobranzaSegmentos.Segmento2N,
	TesCFDICobranzaSegmentos.Segmento3N, TesCFDICobranzaSegmentos.Segmento4N) as Segmento,
	TesCFDICobranzaSegmentos.Empresa_Id AS Empresa, 
venClientes.Cliente_Id, venClientes.RazonSocial , 
	tesCFDICobranza.Fecha, tesCFDICobranza.SelloDigital, 
	tesCFDICobranza.Xml, tesCFDICobranza.Cadena, 
	tesCFDICobranza.NoCertificado, tesCFDICobranza.UUID, 
	tesCFDICobranza.FechaTimbrado, tesCFDICobranza.SelloSat, 
	tesCFDICobranza.NoCertificadoSat, tesCFDICobranza.RfcProvCertif, 
	tesCFDICobranza.Leyenda, tesCFDICobranza.Anulada
 FROM tesCFDICobranza inner join venClientes ON
 tesCFDICobranza.Cliente_Id = venClientes.genEntidades
 INNER JOIN TesCFDICobranzaSegmentos ON 
 TesCFDICobranzaSegmentos.TesCFDICobranza = tesCFDICobranza.tesCFDICobranza

 
GO

DROP view vcomImpPagados
GO
CREATE view vcomImpPagados
as
select DISTINCT conasientos.Fecha, comMovProv.comMovprov ,  comProveedores.Proveed_id, 
	comProveedores.genEntidades, impTipoImpuesto.CodigoFiscal as Tipo,
	comMovImpAcredita.tesMovimientos, 
	conasientos.Empresa_Id, comMovImpAcredita.Asiento_id
From comMovImpAcredita INNER join conasientos ON
comMovImpAcredita.Asiento_id = conasientos.conasientos
INNER JOIN comMovprov ON 
comMovprov.comMovprov = comMovImpAcredita.comMovprov
INNER JOIN comProveedores ON 
comProveedores.genEntidades = comMovprov.Proveed_id
INNER JOIN comImpuestos ON
comImpuestos.comImpuestos =  comMovImpAcredita.Impuesto_Id
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto =comImpuestos.TipoImpuesto
INNER JOIN conAsientos conAsientosp ON 
comMovprov.comMovprov = conAsientosp.conAsientos
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientosp.Anulado = 0 and 
	conAsientosp.Posteado = 1 
union all
select conasientos.Fecha, comMovProv.comMovprov ,  comProveedores.Proveed_id, 
	comProveedores.genEntidades, impTipoImpuesto.CodigoFiscal as Tipo,
	null tesMovimientos, 
	conasientos.Empresa_Id, null Asiento_id
From conAsientos
INNER JOIN comMovprov ON 
comMovprov.comMovprov = conAsientos.conAsientos
INNER JOIN comProveedores ON 
comProveedores.genEntidades = comMovprov.Proveed_id
INNER JOIN  comMovImpuestos ON comMovImpuestos.comMovProv = comMovProv.comMovProv
INNER JOIN comImpuestos ON
comImpuestos.comImpuestos =  comMovImpuestos.Impuesto_Id
INNER JOIN impTipoImpuesto ON
impTipoImpuesto.TipoImpuesto =comImpuestos.TipoImpuesto
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	comImpuestos.PorAcreditacion = 0
UNION ALL
select DISTINCT conasientosp.Fecha, comMovProv.comMovprov ,  comProveedores.Proveed_id, 
	comProveedores.genEntidades, 'EX' as Tipo,
	tesMovimientos.tesMovimientos, 
	conasientos.Empresa_Id, null Asiento_id
From conasientos 
INNER JOIN comMovprov ON 
comMovprov.comMovprov = conAsientos.conAsientos
INNER JOIN comProveedores ON 
comProveedores.genEntidades = comMovprov.Proveed_id
inner join genCancMov ON genCancMov.Asiento_Id_Ap = comMovProv.comMovProv
inner join conAsientos conAsientosP ON conAsientosP.conAsientos = genCancMov.Asiento_Id
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = conAsientosP.conAsientos 
Where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientosp.Anulado = 0 and 
	conAsientosp.Posteado = 1 and
	comMovProv.TipoMov = 'F' AND 
	not exists(SELECT 1 FROM comMovImpuestos where 
		comMovImpuestos.comMovProv = comMovProv.comMovProv )

GO



DROP VIEW vcuentasRango
GO
CREATE VIEW vcuentasRango
AS

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.TipoSat_Id, conCuentas.Nivel , conCuentas.Imputable,
	conCuentas.Empresa_Id, conCuentas.Rubro_Id, conCuentas.Rubro_Balance,
	ISNULL((Select MIN(ConCuentas1.Cuenta_Id) FROM ConCuentas ConCuentas1 WHERE
		ConCuentas1.Cuenta_Id > conCuentas.Cuenta_id and 
		ConCuentas1.Nivel <= conCuentas.Nivel) ,'ZZZZZZZZZZZZZZZZZZZZZZZZ') AS CuentaHasta, 
		conCuentas.Naturaleza
FROM conCuentas
GO


DROP VIEW vstkProductosCostosSucursal
GO

CREATE VIEW vstkProductosCostosSucursal as
SELECT stkProductos.Producto_Id, stkProductos.Descripcion,	
genSucursalesEmpr.Sucursal, stkProductosCostosSucursal.Empresa_Id, 
	stkProductosCostosSucursal.CostoPromPond, stkProductosCostosSucursal.CostoUltCompra,
		stkProductosCostosSucursal.CostoStandard, stkProductosCostosSucursal.Fecha_Ult_Compra, 
		genMonedas.Moneda_Id MonedaUltCompra, stkProductosCostosSucursal.FechaUltModif, stkProductosCostosSucursal.Usuario_Id
	FROM stkProductosCostosSucursal INNER JOIN stkProductos ON 
	stkProductosCostosSucursal.Producto_Id = stkProductos.stkProductos
	INNER JOIN genSucursalesEmpr ON
	genSucursalesEmpr.genSucursalesEmpr =stkProductosCostosSucursal.Sucursal
	LEFT JOIN genMonedas ON 
	genMonedas.genMonedas =stkProductosCostosSucursal.MonedaUltCompra

GO


DROP VIEW vstkProductosCostos
GO

CREATE VIEW vstkProductosCostos as
SELECT stkProductos.Producto_Id, stkProductos.Descripcion,	
	stkProductosCostos.Empresa_Id, 
	stkProductosCostos.CostoPromPond, stkProductosCostos.CostoUltCompra,
		stkProductosCostos.CostoStandard, stkProductosCostos.Fecha_Ult_Compra, 
		genMonedas.Moneda_Id MonedaUltCompra, stkProductosCostos.FechaUltModif, stkProductosCostos.Usuario_Id
	FROM stkProductosCostos INNER JOIN stkProductos ON 
	stkProductosCostos.Producto_Id = stkProductos.stkProductos
	LEFT JOIN genMonedas ON 
	genMonedas.genMonedas =stkProductosCostos.MonedaUltCompra

GO

Drop View vtesRengMovicomMovProv
Go

Create view vtesRengMovicomMovProv
As
Select tesRengMovicomMovProv.*,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as OP,
	dbo.Segmento(genAsicomMovProv.Segmento_Id, genAsicomMovProv.Segmento1C,
	genAsicomMovProv.Segmento2C, genAsicomMovProv.Segmento3C, genAsicomMovProv.Segmento4C,
	genAsicomMovProv.Segmento1N, genAsicomMovProv.Segmento2N, genAsicomMovProv.Segmento3N,
	genAsicomMovProv.Segmento4N) as Comprobante
From tesRengMovicomMovProv
Inner Join tesRengmovi On tesRengmovi.tesMovimientos = tesRengMovicomMovProv.tesMovimientos And
	tesRengmovi.conRenglon = tesRengMovicomMovProv.Renglon
Inner Join ComMovprov On ComMovprov.comMovProv = tesRengMovicomMovProv.comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesRengMovicomMovProv.tesMovimientos
Inner Join genAsiSegmentos genAsicomMovProv On genAsicomMovProv.Asiento_Id = tesRengMovicomMovProv.comMovProv
Go

Drop View vtesIdentifica
Go
Create View vtesIdentifica
As
Select tesIdentifica.tesIdentifica, Cartera_Id, tesIdentifica.Empresa_Id, tesTiposId.TipoCartera, tesIdentifica.Descripcion,
conCuentas.Cuenta_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, genMonedas.Moneda_Id, genUsuarios.Usuario_Id UsuarioAmo,
ModiCent1, ModiCent2, CtaValET.Cuenta_Id CtaValEnTransito, Reservado, VaAlCashFlow, tesIdentifica.Inactivo,
genUsuCreador.Usuario_Id, tesIdentifica.Posteado
From tesIdentifica
Inner Join tesTiposId On tesTiposId.tesTiposId = tesIdentifica.TipoCartera
Left Join conCuentas On conCuentas.conCuentas = tesIdentifica.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = tesIdentifica.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = tesIdentifica.Centro2_Id
Left Join genMonedas On genMonedas.genMonedas = tesIdentifica.Moneda_Id
Left Join genUsuarios On genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo
Left Join conCuentas CtaValET On CtaValET.conCuentas = tesIdentifica.CtaValEnTransito
Left Join genUsuarios genUsuCreador On genUsuCreador.genUsuarios = tesIdentifica.Usuario_Id
Go


Drop view vtesCheqTerceros
Go
Create view vtesCheqTerceros
As
Select tesCheqTerceros, tesIdentifica.Cartera_Id, tesBancos.Banco_Id, tesCheqTerceros.Clearing, SecuenciaActual, ClearingDias, FechaVencimiento,
FechaAcreditacion, FechaConciliacion, sucBanco, numCheque, tesCheqTerceros.Estado_Id, IsNull(venClientes.Cliente_Id, '') Cliente_Id, 
cuentaBanco, BancoConc.Cartera_Id BancoConc, tesCheqTerceros.NumeroConc, BancoVta.Cartera_Id BancoConcVta, tesCheqTerceros.NumeroConcVta, tesCheqTerceros.Empresa_Id
From tesCheqTerceros
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesCheqTerceros.Cartera_Id
Inner Join tesBancos On tesBancos.tesBancos = tesCheqTerceros.Banco_Id
Left Join venClientes On venClientes.genEntidades = tesCheqTerceros.Cliente_Id
Left Join tesIdentifica BancoConc On BancoConc.tesIdentifica = tesCheqTerceros.BancoConc
Left Join tesIdentifica BancoVta On BancoVta.tesIdentifica = tesCheqTerceros.BancoConcVta
Go


Drop view vtesCTlink
Go

Create view vtesCTlink
As
Select tesCTlink.tesMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as OP, conRenglon, Estado_Id, Secuencia, tesCTlink.tesCheqTerceros
From tesCTlink
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesCTlink.tesMovimientos
Go

Drop view vtesConciliacion
Go
Create view vtesConciliacion
As
Select tesConciliacion.Empresa_Id, tesIdentifica.Cartera_Id tesIdentifica, NumeroConc, FechaConciliacion, ExtractoCierre, ExtractoApertura, ContableApertura,
ContableCierre, tesConciliacion.Posteado, genUsuarios.Usuario_Id
From tesConciliacion
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesConciliacion.tesIdentifica
Inner Join genUsuarios On genUsuarios.genUsuarios = tesConciliacion.Usuario_Id
Go

Drop view vtesRengConcilEsp
Go

Create view vtesRengConcilEsp
As
Select tesRengConcilEsp.Empresa_Id, tesIdentifica.tesIdentifica, NumeroConc, tesMovimientos,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as OP, conRenglon, Importe
From tesRengConcilEsp
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesRengConcilEsp.tesIdentifica
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesRengConcilEsp.tesMovimientos
Go

Drop view vtesRengConciliac
Go

Create view vtesRengConciliac
As
Select tesRengConciliac.tesMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) as OP, conRenglon, Saldo
From tesRengConciliac
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesRengConciliac.tesMovimientos
Go

Drop view vtesCheqProp
Go
Create view vtesCheqProp
As
Select tesCheqProp.tesCheqProp, tesCheqProp.Empresa_Id, tesIdentifica.Cartera_Id, tesCheqProp.Chequera_Id, tesCheqProp.numCheque,
tesCheqProp.FechaVencimiento, tesCheqProp.FechaDebito, tesCheqProp.aLaOrden, tesCheqProp.Estado_Id, tesCheqProp.SecuenciaActual,
tesCheqProp.Cuit, conCuentas.Cuenta_Id CuentaDestino, tesBancos.Banco_Id BancoDestino, tesCheqProp.BancoDestinoExt
From tesCheqProp
Inner Join tesIdentifica On tesIdentifica.tesIdentifica = tesCheqProp.Cartera_Id
Left Join conCuentas On conCuentas.conCuentas = tesCheqProp.CuentaDestino
Left Join tesBancos On tesBancos.tesBancos = tesCheqProp.BancoDestino
Go



DROP VIEW vstkProductosCostoCierreSucursal 
GO
CREATE VIEW vstkProductosCostoCierreSucursal AS
SELECT stkProductosCostoCierreSucursal.Empresa_Id, stkProductosCostoCierreSucursal.Fecha, 
	stkProductos.Producto_Id, genSucursalesEmpr.Sucursal,
		stkProductosCostoCierreSucursal.Costo FROM stkProductosCostoCierreSucursal INNER JOIN stkProductos ON 
stkProductosCostoCierreSucursal.Producto_Id = stkProductos.stkProductos 
INNER JOIN genSucursalesEmpr ON
genSucursalesEmpr.genSucursalesEmpr = stkProductosCostoCierreSucursal.Sucursal
GO

Drop view vcomProveedoresMonedas
Go
CREATE VIEW vcomProveedoresMonedas
AS
Select Distinct comProveedores.Proveed_Id, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, comProveedoresCtasPasivo.TipoCtaProv
From 
comProveedoresCtasPasivo  
INNER JOIN comProveedores ON comProveedores.genEntidades = comProveedoresCtasPasivo.genEntidades
INNER JOIN genMonedas ON comProveedoresCtasPasivo.Moneda_Id = genMonedas.genMonedas
Go

Drop view vconGruposCont
Go
Create view vconGruposCont
As
Select conGruposCont.conGruposCont, conGruposCont.Grupo_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id
From conGrupoCentro
Inner Join conGruposCont On conGruposCont.conGruposCont = conGrupoCentro.Grupo_Id
Inner Join conCentro1 On conCentro1.conCentro1 = conGrupoCentro.Centro1_Id
Inner Join conCentro2 On conCentro2.conCentro2 = conGrupoCentro.Centro2_Id
Go

Drop view vstkMoviOC
Go
Create view vstkMoviOC
As
Select stkMoviOC.stkMoviCabe, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,
	genAsiSegmentos.Segmento4N) SegStk, stkMoviOC.Renglon,
	dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C,
	comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N,
	comOCSegmentos.Segmento4N) OC, stkMoviOC.Renglon_OC, stkMoviOC.CantFactPendiente
From stkMoviOC
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviOC.stkMoviCabe
Inner Join comOCSegmentos On comOCSegmentos.comOrdenComp = stkMoviOC.comOrdenComp

GO

DROP view vvenReparto
GO
CREATE view vvenReparto
as
SELECT venReparto, venReparto.Empresa_Id Empresa, FechaReparto, FechaEntrega, 
	Deposito_Id,ZonaDesde, ZonaHasta, TipoClieDesde, TipoClieHasta, 
	ClienteDesde, ClienteHasta, DepoPedido_Id, Automatico, Cerrado , 
	ISNULL(venClientes.RazonSocial, ' ') AS RazonSocial
	FROM venReparto
	left join venCLientes ON venClientes.Cliente_Id = ClienteDesde
GO




DROP VIEW  vstkMoviCabeEntr
GO
CREATE VIEW  vstkMoviCabeEntr as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
dbo.Segmento(genAsiSegmentosSal.Segmento_Id, genAsiSegmentosSal.Segmento1C, genAsiSegmentosSal.Segmento2C,
genAsiSegmentosSal.Segmento3C, genAsiSegmentosSal.Segmento4C, genAsiSegmentosSal.Segmento1N, 
genAsiSegmentosSal.Segmento2N,genAsiSegmentosSal.Segmento3N, genAsiSegmentosSal.Segmento4N) SegmentoSal,
conAsientos.Fecha, conAsientos.Anulado,
vstkMoviCabe.SubTipomov_id,conAsientos.Posteado, disFormularios.Formulario_Id, vstkMoviCabe.stkMoviCabe, 
genAsiSegmentos.Empresa_Id as Empresa
from vstkMoviCabe 
Inner join conAsientos ON vstkmovicabe.stkmovicabe = conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = vstkMoviCabe.stkMoviCabe
INNER JOIN stkEnTransito ON stkEnTransito.stkMoviCabeEntr = vstkMoviCabe.stkMoviCabe
INNER JOIN genAsiSegmentos as genAsiSegmentosSal on genAsiSegmentosSal.Asiento_Id =stkEnTransito.stkMoviCabe

GO

Drop view vcomDespachos
Go
Create view vcomDespachos
As
Select comDespachos.comDespachos, comDespachos.Empresa_Id, comDespachos.Despacho_Id, comDespachos.Origen, comDespachos.Aduana, comDespachos.Fecha,
comDespachos.Anio, comDespachos.Patente, comDespachos.Pedimento, comDespachos.Cambio, comDespachos.FechaModificacion,
genMonedas.Moneda_Id, comDespachos.Usuario_Id
From comDespachos
Inner Join genMonedas On genMonedas.genMonedas = comDespachos.Moneda_Id
Go



DROP VIEW [dbo].[vstkMoviCuerpoReva]
GO



SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vstkMoviCuerpoReva]
as
select stkMoviCuerpoReva.stkMoviCabe, stkMoviCuerpoReva.Renglon, 
	conAsientos.Fecha, conAsientos.Anulado, stkProductos.Producto_Id, 
	stkProductos.Descripcion, stkMoviCuerpoReva.PUC_Actual, stkMoviCuerpoReva.PUC_Anterior, 
	stkMoviCuerpoReva.PPP_Actual, stkMoviCuerpoReva.PPP_Anterior, stkMoviCuerpoReva.STD_Actual, 
	stkMoviCuerpoReva.STD_Anterior, stkMoviCuerpoReva.ImporteAjuste, stkMoviCuerpoReva.ImporteAjusteCosto
 from stkMoviCuerpoReva INNER join conAsientos oN 
 stkMoviCuerpoReva.stkMoviCabe = conAsientos.conAsientos 
 inner join stkProductos on 
 stkProductos.stkProductos = stkMoviCuerpoReva.Producto_Id
GO


DROP VIEW vvenCamiones
GO
CREATE VIEW vvenCamiones
AS
SELECT venCamiones.venCamiones, venCamiones.Patente_Id, venCamiones.Descripcion,
venCamiones.Empresa_Id,
IsNull(genEmpresas.Empresa_Id, '') cEmpresa_Id,
venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial, 
venCamiones.CargaMaxima, venCamiones.Tara, venCamiones.Marca, 
venCamiones.Inspeccion, venCamiones.EsAcoplado, venCamiones.Inactivo,
venCamiones.Posteado 
FROM venCamiones
INNER JOIN venFormaEntrega ON venCamiones.FormaEntrega_Id = venFormaEntrega.venFormaEntrega
LEFT JOIN genEmpresas On genEmpresas.genEmpresas = venCamiones.Empresa_Id
GO


--- VISTAS DE V2
DROP VIEW vAfiRubros
GO

CREATE VIEW vAfiRubros 
AS

SELECT  AfiRubros.AfiRubros, AfiRubros.Rubro_Id, AfiRubros.Descripcion,
	AfiRubros.Tipo, AfiRubros.Empresa_Id, AfiRubros.VidaUtil, AfiRubros.VidaUtilFiscal, 
		ISNULL(CtaValorOrigen.Cuenta_Id,' ') as  CtaValorOrigen_id,
		ISNULL(CtaAmortAcum.Cuenta_Id, ' ') AS CtaAmortAcum_Id, 
		ISNULL(CtaAmortizacion.Cuenta_Id, ' ') AS  CtaAmortizacion_id, 
		AfiRubros.Digitos, AfiRubros.Posteado, AfiRubros.FechaAlta, 
		AfiRubros.Usuario_Id
FROM AfiRubros 
	left join conCuentas as CtaValorOrigen on 
			CtaValorOrigen.conCuentas = AfiRubros.CtaValorOrigen_Id
	left join conCuentas as CtaAmortAcum on 
			CtaAmortAcum.conCuentas = AfiRubros.CtaAmortAcum_Id
	left join conCuentas as CtaAmortizacion on 
			CtaAmortizacion.conCuentas = AfiRubros.CtaAmortizacion_Id

go
DROP VIEW vproTrabajo3
GO

CREATE VIEW vproTrabajo3 
AS
select proTrabajo3.Trabajo3_Id,Descripcion,proTrabajo3.Inactivo,proTrabajo3.Posteado,comProveedores.Proveed_Id from proTrabajo3
left join proTrabajo3Prov on proTrabajo3Prov.Trabajo3_Id=proTrabajo3.proTrabajo3
left join comProveedores on proTrabajo3Prov.Proveedor_Id=comProveedores.genEntidades and 
Predeterminado=1
go

Drop view vstkProductosCReceta
Go
Create view vstkProductosCReceta
As
Select stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Empresa_Id, stkProductos.Descripcion, 
stkUniMed.Medida_Id, stkProductos.Inactivo, stkProductos.Posteado, proRecetas.Receta_Id
From stkProductos
Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
inner join proProductosReceta on stkProductos=proProductosReceta.Producto_Id and 
	proProductosReceta.Principal = 1
inner join proRecetas ON proRecetas.proRecetas = proProductosReceta.Receta_Id

Go

drop view vvenCotizaciones
go
create view vvenCotizaciones
as
select Fecha, genMonedas.Moneda_Id, venClientes.Cliente_Id, venClientes.RazonSocial as Razonsocial, 
	venCotizaciones.venCotizaciones,venCotizaciones.Empresa_Id as Empresa, venCotizaciones.Estado, venCotizaciones.ImporteTotal, 
	venVendedores.Vendedor_Id, venVendedores.Nombre as NombreVe
from venCotizaciones 
left join genMonedas on genMonedas.genMonedas=venCotizaciones.Moneda_Id
left join venClientes on venClientes.genEntidades=venCotizaciones.Cliente_Id
INNER JOIN venVendedores ON venVendedores.venVendedores = venCotizaciones.Vendedor_Id
go

drop view vproProgramas
go
create view vproProgramas
as
select proProgramas, proProgramas.Descripcion, Fecha, stkDepositos.Deposito_Id, proProgramas.Usuario_Id, proProgramas.Empresa_Id as Empresa
from proProgramas
left join stkDepositos on stkDepositos=proProgramas.Deposito_Id
go

drop view vsueCategorias
go
create view vsueCategorias
as
select sueCategorias, Categoria_Id, sueCategorias.Descripcion, suePeriodicidad.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodicidad, Inactivo, Posteado, Usuario_Id from sueCategorias
left join suePeriodicidad on suePeriodicidad.Periodo_Id=sueCategorias.Periodo_Id
go

drop view vsueGrupos
go
create view vsueGrupos
as
select sueGrupos, Grupo_Id, sueGrupos.Descripcion, sueGrupos.Empresa_Id, genSegmentos.Segmento_Id, genSegmentos.Descripcion as DescripcionSegmento, suePeriodicidad.Periodo_Id,
suePeriodicidad.Descripcion as DescripcionPeriodo, CtaSueldoAPagar, sueGrupos.Inactivo, sueGrupos.Posteado, sueGrupos.Usuario_Id from sueGrupos
left join genSegmentos on genSegmentos.genSegmentos=sueGrupos.Segmento_Id
left join suePeriodicidad on suePeriodicidad.Periodo_Id=sueGrupos.Periodo_Id
go



Drop view vproRecetasProductos
Go
Create view vproRecetasProductos
As
Select proRecetas.Receta_Id, proRecetas.Descripcion, stkProductos.Producto_Id, proCentroProductivo.CtroProd_Id
From proProductosReceta 
inner join stkProductos on stkProductos=proProductosReceta.Producto_Id 
inner join proRecetas ON proRecetas.proRecetas = proProductosReceta.Receta_Id
Inner Join proCentroProductivo On proCentroProductivo.proCentroProductivo = proRecetas.CtroProd_Id

Go


DROP VIEW vstkMoviCuerpoReva
GO
CREATE VIEW vstkMoviCuerpoReva
as
select stkMoviCuerpoReva.stkMoviCabe, stkMoviCuerpoReva.Renglon, 
	conAsientos.Fecha, conAsientos.Anulado, stkProductos.Producto_Id, 
	stkProductos.Descripcion, stkMoviCuerpoReva.PUC_Actual, stkMoviCuerpoReva.PUC_Anterior, 
	stkMoviCuerpoReva.PPP_Actual, stkMoviCuerpoReva.PPP_Anterior, stkMoviCuerpoReva.STD_Actual, 
	stkMoviCuerpoReva.STD_Anterior, stkMoviCuerpoReva.ImporteAjuste
 from stkMoviCuerpoReva INNER join conAsientos oN 
 stkMoviCuerpoReva.stkMoviCabe = conAsientos.conAsientos 
 inner join stkProductos on 
 stkProductos.stkProductos = stkMoviCuerpoReva.Producto_Id
GO



DROP view vproProgramaCuerpo 
GO
CREATE view vproProgramaCuerpo 
as

select proProgramasCuerpo.proProgramas, 
	dbo.Segmento(proProgramasSegmento.Segmento_Id,  
	proProgramasSegmento.Segmento1C,proProgramasSegmento.Segmento2C, proProgramasSegmento.Segmento3C, proProgramasSegmento.Segmento4C,
	proProgramasSegmento.Segmento1N,proProgramasSegmento.Segmento2N, proProgramasSegmento.Segmento3N, proProgramasSegmento.Segmento4N) Segmento ,
	stkProductos.Producto_Id, stkProductos.Descripcion,
	proProgramasCuerpo.Cantidad, proProgramasCuerpo.FechaNecesidad, 
	proProgramasCuerpo.Confirmado, proRecetas.Receta_Id
	from proProgramasCuerpo INNER JOIN proProgramasSegmento on 
	proProgramasCuerpo.proProgramas =  proProgramasSegmento.proProgramas
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = proProgramasCuerpo.Producto_Id
	INNER JOIN proRecetas ON
	proRecetas.proRecetas = proProgramasCuerpo.Receta_Id
GO

DROP view vproOrden
GO
CREATE view vproOrden
as

SELECT proOrden.proOrden,  dbo.Segmento(proOrdenSegmento.Segmento_Id,  
	proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
	proOrdenSegmento.Segmento1N,proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) Segmento ,
	proOrdenSegmento.Empresa_Id, stkProductos.Producto_Id, stkProductos.Descripcion DescripcionProducto,
		proOrden.Anulado, proRecetas.Receta_Id, 
		proOrden.Cantidad, proOrden.CantidadIngresada, proOrden.CantidadProgramada, 
		proOrden.CantidadTerminada, proOrden.CierreAutomatico, proOrden.Factor, 
		proOrden.FechaEmision, proOrden.FechaFin, proOrden.FechaNecesidad, proOrden.FechaProduccion, 
		stkUniMed.Medida_Id, proOrden.Observaciones, proOrdenSegmento.Empresa_Id as Empresa
FROM proOrden INNER JOIN proOrdenSegmento ON  proOrden.proOrden = proOrdenSegmento.proOrden
	INNER JOIN stkProductos ON 
	stkProductos.stkProductos = proOrden.Producto_Id
	INNER JOIN proRecetas on 
	proRecetas.proRecetas = proOrden.Receta_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = proOrden.Medida_Id
GO



DROP view vproOrdenProd
GO
CREATE view vproOrdenProd
as

SELECT proOrdenProd.proOrden,  dbo.Segmento(proOrdenSegmento.Segmento_Id,  
	proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
	proOrdenSegmento.Segmento1N,proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) Segmento ,
	proOrdenProd.Renglon,
	proOrdenSegmento.Empresa_Id, stkProductos.Producto_Id, stkProductos.Descripcion,
		proOrdenProd.Cantidad, proOrdenProd.EntradaSalida ,		stkUniMed.Medida_Id,
		proOrdenProd.PorcentajeCosto, stkDepositos.Deposito_Id, proOrdenProd.TomaDepoT3
FROM proOrdenProd INNER JOIN proOrdenSegmento ON  proOrdenProd.proOrden = proOrdenSegmento.proOrden
	INNER JOIN stkProductos ON 
	stkProductos.stkProductos = proOrdenProd.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = proOrdenProd.Medida_Id
	inner join stkDepositos ON
	stkDepositos.stkDepositos = proOrdenProd.Deposito_Id
GO


DROP view vproOrdenRecursos
GO
CREATE view vproOrdenRecursos
as

SELECT proOrdenRecursos.proOrden,  dbo.Segmento(proOrdenSegmento.Segmento_Id,  
	proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
	proOrdenSegmento.Segmento1N,proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) Segmento ,
	proOrdenRecursos.Renglon,
	proOrdenSegmento.Empresa_Id, proRecursos.Recurso_Id, proRecursos.Descripcion,
		proOrdenRecursos.Cantidad
FROM proOrdenRecursos INNER JOIN proOrdenSegmento ON  proOrdenRecursos.proOrden = proOrdenSegmento.proOrden
	INNER JOIN proRecursos ON 
	proRecursos.proRecursos = proOrdenRecursos.Recurso_Id
	
GO

DROP view vproOrdenTrabajos3
GO
CREATE view vproOrdenTrabajos3
as

SELECT proOrdenTrabajos3.proOrden,  dbo.Segmento(proOrdenSegmento.Segmento_Id,  
	proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C, proOrdenSegmento.Segmento3C, proOrdenSegmento.Segmento4C,
	proOrdenSegmento.Segmento1N,proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) Segmento ,
	proOrdenTrabajos3.Renglon,
	proOrdenSegmento.Empresa_Id, proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion,
		comProveedores.Proveed_Id, comProveedores.RazonSocial, comProveedores.Inactivo, comProveedores.Posteado
FROM proOrdenTrabajos3 INNER JOIN proOrdenSegmento ON  proOrdenTrabajos3.proOrden = proOrdenSegmento.proOrden
	INNER JOIN proTrabajo3 ON 
	proTrabajo3.proTrabajo3 = proOrdenTrabajos3.proTrabajo3
	LEFT JOIN comProveedores ON 
	comProveedores.genEntidades = proOrdenTrabajos3.Proveed_Id
	
GO



DROP View vproTrabajo3Prov
GO
CREATE View vproTrabajo3Prov
AS
Select proTrabajo3.Trabajo3_Id, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	proTrabajo3Prov.Precio, genMonedas.Moneda_Id,  
	proTrabajo3Prov.Cantidad, stkUniMed.Medida_Id, comProveedores.Empresa_Id, 
	comProveedores.Inactivo, comProveedores.Posteado
from 
proTrabajo3Prov inner join proTrabajo3 ON
proTrabajo3Prov.Trabajo3_Id =  proTrabajo3.proTrabajo3 
INNER JOIN comProveedores ON 
comProveedores.genEntidades = proTrabajo3Prov.Proveedor_Id
INNER JOIN genMonedas ON
genMonedas.genMonedas =  proTrabajo3Prov.Moneda_Id
INNER JOIN stkUniMed ON 
stkUniMed.stkUniMed =  proTrabajo3Prov.Medida_Id
GO


DROP View vproSubRecursos
GO
CREATE View vproSubRecursos
AS
Select proSubRecursos.SubRecurso_Id, proSubRecursos.Descripcion, 
	proRecursos.Recurso_Id, proSubRecursos.Inactivo
from  proSubRecursos INNER JOIN proRecursos ON
proSubRecursos.Recurso_Id = proRecursos.proRecursos

GO

drop view vsueLiquidaciones
go
create view vsueLiquidaciones
as
select sueLiquidacion.sueLiquidacion as vsueLiquidacion, sueGrupos.Grupo_Id, 
sueGrupos.Descripcion as DescripcionGrupo, FechaPago, FechaDeposito, PeriodoDeposito, 
conCuentas.Cuenta_Id as CtaSueldosAPagar, conCuentas.Descripcion as DescripcionCtaSueldosAPagar, 
FechaInicial, FechaFinal, ISNULL(suePeriodicidad.Periodo_Id,'') Periodo_Id, 
suePeriodicidad.Descripcion as DescripcionPeriodo, Anio as vAnio, 
Mes as vMes, Quincena as vQuincena, Semana as vSemana, Decena as vDecena , Vez as vVez, FechaContabilizacion  ,
conAsientos.Empresa_Id as Empresa, conAsientos.Anulado
from sueLiquidacion
inner join sueGrupos on sueGrupos.sueGrupos=sueLiquidacion.Grupo_Id
inner join conCuentas on conCuentas.conCuentas=sueLiquidacion.CtaSueldosAPagar
LEFT JOIN suePeriodicidad on suePeriodicidad.Periodo_Id = sueLiquidacion.Periodo_Id --AO Lo hice Left para que funcione en AR 
INNER JOIN conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
LEFT JOIN suePagosHabi ON suePagosHabi.sueLiquidacion = sueLiquidacion.sueLiquidacion
go


drop view vsueLiquidacionesHabi
go
create view vsueLiquidacionesHabi
as
select sueLiquidacion.sueLiquidacion as vsueLiquidacion, sueGrupos.Grupo_Id, 
sueGrupos.Descripcion as DescripcionGrupo, FechaPago, FechaDeposito, PeriodoDeposito, 
conCuentas.Cuenta_Id as CtaSueldosAPagar, conCuentas.Descripcion as DescripcionCtaSueldosAPagar, 
FechaInicial, FechaFinal, ISNULL(suePeriodicidad.Periodo_Id,'') Periodo_Id, 
suePeriodicidad.Descripcion as DescripcionPeriodo, Anio as vAnio, 
Mes as vMes, Quincena as vQuincena, Semana as vSemana, Decena as vDecena , Vez as vVez, FechaContabilizacion  ,
conAsientos.Empresa_Id as Empresa, conAsientos.Anulado, 
suePagosHabi.Importe as MontoHabilitado
from sueLiquidacion
inner join sueGrupos on sueGrupos.sueGrupos=sueLiquidacion.Grupo_Id
inner join conCuentas on conCuentas.conCuentas=sueLiquidacion.CtaSueldosAPagar
LEFT JOIN suePeriodicidad on suePeriodicidad.Periodo_Id = sueLiquidacion.Periodo_Id --AO Lo hice Left para que funcione en AR 
INNER JOIN conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
INNER JOIN suePagosHabi ON suePagosHabi.sueLiquidacion = sueLiquidacion.sueLiquidacion
WHERE
	suePagosHabi.tesMovimientos IS NULL AND
	suePagosHabi.FechaHabilitacion IS NOT NULL
UNION ALL
select sueLiquidacion.sueLiquidacion as vsueLiquidacion, sueGrupos.Grupo_Id, 
sueGrupos.Descripcion as DescripcionGrupo, FechaPago, FechaDeposito, PeriodoDeposito, 
conCuentas.Cuenta_Id as CtaSueldosAPagar, conCuentas.Descripcion as DescripcionCtaSueldosAPagar, 
FechaInicial, FechaFinal, ISNULL(suePeriodicidad.Periodo_Id,'') Periodo_Id, 
suePeriodicidad.Descripcion as DescripcionPeriodo, Anio as vAnio, 
Mes as vMes, Quincena as vQuincena, Semana as vSemana, Decena as vDecena , Vez as vVez, FechaContabilizacion  ,
conAsientos.Empresa_Id as Empresa, conAsientos.Anulado, 
sum(suePagosHabiPorEmpleado.Importe) as MontoHabilitado
from sueLiquidacion
inner join sueGrupos on sueGrupos.sueGrupos=sueLiquidacion.Grupo_Id
inner join conCuentas on conCuentas.conCuentas=sueLiquidacion.CtaSueldosAPagar
LEFT JOIN suePeriodicidad on suePeriodicidad.Periodo_Id = sueLiquidacion.Periodo_Id --AO Lo hice Left para que funcione en AR 
INNER JOIN conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
INNER JOIN suePagosHabiPorEmpleado ON suePagosHabiPorEmpleado.sueLiquidacion = sueLiquidacion.sueLiquidacion
WHERE
	suePagosHabiPorEmpleado.tesMovimientos IS NULL AND
	suePagosHabiPorEmpleado.FechaHabilitacion IS NOT NULL
GROUP BY sueLiquidacion.sueLiquidacion , sueGrupos.Grupo_Id, 
sueGrupos.Descripcion , FechaPago, FechaDeposito, PeriodoDeposito, 
conCuentas.Cuenta_Id , conCuentas.Descripcion , 
FechaInicial, FechaFinal, suePeriodicidad.Periodo_Id, 
suePeriodicidad.Descripcion , Anio , Mes, Quincena , Semana , Decena , Vez , FechaContabilizacion  ,
conAsientos.Empresa_Id, conAsientos.Anulado
GO


drop view vconcuentasSinSc
GO
Create view vconcuentasSinSc
AS
select conCuentas.Cuenta_Id, conCuentas.Descripcion,
	conCuentas.Inactivo, conCuentas.Posteado, conCuentas.Empresa_Id
from concuentasSinSc inner join conCuentas ON 
concuentasSinSc.Cuenta_Id =  conCuentas.conCuentas
GO




DROP VIEW [dbo].[vimpLiquidacion] 
GO
CREATE VIEW [dbo].[vimpLiquidacion] as 
SELECT impLiquidacion.conAsientos, 
	impImpuestos.Impuesto_Id,impLiquidacion.FechaPago, 
	impLiquidacion.FechaDesde,impLiquidacion.FechaHasta,impLiquidacion.TotalaPagar,impLiquidacion.SePaga,
		 genAsiSegmentos1.Empresa_Id as Empresa	, 
		 CAST(CASE WHEN tesMovimientos IS NULL THEN 1 ELSE 0 END AS bit) AS Pendiente	, 
		 impImpuestos.Descripcion
	FROM impLiquidacion INNER JOIN impImpuestos 
		ON impLiquidacion.Impuesto_Id = impImpuestos.impImpuestos
		INNER JOIN genAsiSegmentos as  genAsiSegmentos1 ON
		impLiquidacion.conAsientos = genAsiSegmentos1.Asiento_Id
		inner join conasientos on conasientos.conasientos = impLiquidacion.conasientos
		where
			conasientos.Anulado = 0

GO



DROP VIEW vSueTerminada 
GO
CREATE VIEW vSueTerminada 
as
SELECT sueTerminada.sueliquidacion,
suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
	suePersonal.Nombres as Nombre, 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion, 
		sueTerminada.Dato, sueTerminada.Dato2, sueTerminada.Importe, sueTerminada.Signo, 
			sueConceptos.ColumnaRecibo
 FROM sueTerminada inner join suePersonal ON
	suePersonal.genEntidades = sueTerminada.Legajo
	INNER JOIN sueConceptos ON 
	sueConceptos.sueConceptos = sueTerminada.Concepto_Id
go	


DROP VIEW vSueMovCont
GO
CREATE VIEW vSueMovCont
as
SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno +','+suePersonal.ApellidoMaterno+','+
	suePersonal.Nombres as Nombre, 
		sueConceptos.Concepto_Id, sueConceptos.Descripcion, 
		conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
		conCentro1.Centro1_id, conCentro2.Centro2_Id, sueMovCont.Importe, 
		sueMovCont.sueliquidacion
 FROM sueMovCont inner join suePersonal ON
	suePersonal.genEntidades = sueMovCont.Legajo
	INNER JOIN sueConceptos ON 
	sueConceptos.sueConceptos = sueMovCont.Concepto_Id
	INNER JOIN conCuentas ON
	conCuentas.conCuentas = sueMovCont.Cuenta_Id
	INNER JOIN conCentro1 ON
	conCentro1.conCentro1 = sueMovCont.Centro1_Id
	INNER JOIN conCentro2 ON
	conCentro2.conCentro2 = sueMovCont.Centro2_Id

go


DROP VIEW vSueConcAcum
GO

CREATE VIEW vSueConcAcum 
AS

SELECT sueConcAcum.sueConcAcum, sueConceptos.Concepto_Id, sueConceptos.Descripcion DescripcionConcepto, 
	suePersonal.Legajo, suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno+','+
	suePersonal.Nombres as Nombres, sueConcAcum.Fecha, sueConcAcum.MontoTope, sueConcAcum.Anulado, 
	sueConcAcumSegmento.Empresa_Id as Empresa
FROM sueConcAcum 
	inner join sueConceptos ON sueConceptos.sueConceptos = sueConcAcum.Concepto_Id
	INNER JOIN suePersonal ON suePersonal.genEntidades = sueConcAcum.Legajo
	INNER JOIN sueConcAcumSegmento ON sueConcAcumSegmento.sueConcAcum = sueConcAcum.sueConcAcum
GO

drop view vcomTipoPermiRI
go
create view vcomTipoPermiRI
as
select TipoPermiRI_Id, comTipoPermiRI.Descripcion, comEsquemaAuto.EsquemaAuto_Id, comEsquemaAuto.Descripcion as DescripcionEsquemaAuto,
TipoRI, comTipoPermiRI.Inactivo, comTipoPermiRI.Posteado, TipoCuerpo, genReportes.Reporte_Id, genReportes.Titulo as DescripcionReporte
from comTipoPermiRI
left join comEsquemaAuto on comEsquemaAuto.comEsquemaAuto=comTipoPermiRI.EsquemaAuto_Id
left join genReportes on genReportes.genReportes=comTipoPermiRI.Reporte_Id
go

drop view vcomSubCategoria
go
create view vcomSubCategoria
as
select SubCategoria_Id, comCategorias.Descripcion, comCategorias.Categoria_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id from comSubCategorias
inner join comCategorias on comCategorias.comCategorias=comSubCategorias.Categoria_Id
left join conCentro1 on conCentro1.conCentro1=comSubCategorias.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=comSubCategorias.Centro2_Id
go


drop view vcomReqInterno
go
create view vcomReqInterno
as
select comReqInterno.comReqInterno, Fecha, comTipoPermiRI.TipoPermiRI_Id, comReqInterno.Observaciones, comProveedores.Proveed_Id, EstadoRI_Id, 
comReqInterno.Usuario_Id , comProveedores.RazonSocial, comRISegmento.Empresa_Id as Empresa, 
	comTipoPermiRI.GeneraOC
from comReqInterno
left join comTipoPermiRI on comTipoPermiRI.comTipoPermiRI=comReqInterno.TipoPermi_Id
left join comProveedores on comProveedores.genEntidades=comReqInterno.Proveed_Id
left join comRISegmento on comRISegmento.comReqInterno=comReqInterno.comReqInterno
go

drop view vcomSubCategoria
go
create view vcomSubCategoria
as
select comSubCategorias.SubCategoria_Id, comSubCategorias.Descripcion, comCategorias.Categoria_Id,
comCategorias.Descripcion as DescripcionCategoria
from comSubCategorias
inner join comCategorias on comCategorias.comCategorias=comSubCategorias.Categoria_Id

go

Drop view vvenClientes
Go
Create view vvenClientes
As
Select venClientes.genEntidades, venClientes.Cliente_Id, venClientes.Empresa_Id, 
IsNull(genEmpresas.Empresa_Id, '') cEmpresa_Id, venClientes.RazonSocial,
venClientes.SucursalPredeter, IsNull(venCondFiscal.CondFisc_Id, '') CondFisc_Id, venClientes.LimiteCredito, genEntidades.idFiscal, genEntidades.Cuit, genEntidades.TipoDoc,
IsNull(genMonedas.Moneda_Id, '') MonedaLimCred, IsNull(venCategCredito.CategCred_Id, '') CategCred_Id, venClientes.Bonificacion1,
venClientes.Bonificacion2, venClientes.Bonificacion3, venClientes.Puntual, IsNull(venClieEstados.Estado_Id, '') Estado_Id,
venClientes.GeneraDebito, venClientes.Siempre, venClientes.CongelaCambio, venClientes.IBrutos, venClientes.Situacion, venClientes.Posteado, 
Cast((SELECT MIN(Convert(int,Inactivo)) from venClieHabitual where venClieHabitual.genEntidades = venclientes.genEntidades) as bit) as Inactivo,
(Select NombreFantasia From venClieHabitual Where venClieHabitual.genEntidades = venClientes.genEntidades And venClieHabitual.Sucursal = venClientes.SucursalPredeter) 
	NombreFantasia, 
		(Select venVendedores.Vendedor_Id From venClieHabitual , venVendedores
		Where venClieHabitual.genEntidades = venClientes.genEntidades And 
			venClieHabitual.Sucursal = venClientes.SucursalPredeter and 
			venVendedores.venVendedores = venClieHabitual.Vendedor_Id)   as Vendedor_Id, 
			venCategCredito.TipoCredito, 
ISNULL((SELECT genMonedas.Moneda_Id
from venClientesCtas, genMonedas 
Where 
	venClientesCtas.Cliente_Id = venClientes.genEntidades and 
	genMonedas.genMonedas = venClientesCtas.Moneda_Id and 
	venClientesCtas.ParaPedidos = 1), '') as MonedaPedido,
ISNULL((SELECT genMonedas.Moneda_Id
from venClientesCtas, genMonedas 
Where 
	venClientesCtas.Cliente_Id = venClientes.genEntidades and 
	genMonedas.genMonedas = venClientesCtas.Moneda_Id and 
	venClientesCtas.ParaFactura = 1), '') as MonedaFactura
From venClientes
Inner Join genEntidades On genEntidades.genEntidades = venClientes.genEntidades
Left Join genEmpresas On genEmpresas.genEmpresas = venClientes.Empresa_Id
Left Join venCondFiscal On venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
Left Join genMonedas On genMonedas.genMonedas = venClientes.MonedaLimCred
Left Join venCategCredito On venCategCredito.venCategCredito = venClientes.CategCred_Id
Left Join venClieEstados On venClieEstados.venClieEstados = venClientes.Estado_Id


Go


DROP view vVenClientesVend
go
CREATE view vVenClientesVend
AS
Select vvenClientes.genEntidades, Cliente_Id, vvenClientes.Empresa_Id, cEmpresa_Id,RazonSocial, MIN(venClieHabitual.Sucursal) as SucursalPredeter,
vvenClientes.CondFisc_Id, LimiteCredito, idFiscal, Cuit, TipoDoc, MonedaLimCred, CategCred_Id,
vvenClientes.Bonificacion1,vvenClientes.Bonificacion2,vvenClientes.Bonificacion3,Puntual,Estado_Id,GeneraDebito
Siempre,CongelaCambio,IBrutos,Situacion,vvenClientes.Posteado,vvenClientes.Inactivo, max(venClieHabitual.NombreFantasia) as NombreFantasia , 
	venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVend, 
	vvenClientes.TipoCredito
from vvenClientes INNER JOIN venClieHabitual ON
	vvenClientes.genEntidades = venClieHabitual.genEntidades
	INNER JOIN venVendedores ON venVendedores.venVendedores = venClieHabitual.Vendedor_Id 
	
	WHERE
		venClieHabitual.Inactivo =0 
GROUP BY vvenClientes.genEntidades, Cliente_Id, vvenClientes.Empresa_Id, cEmpresa_Id,RazonSocial, 
vvenClientes.CondFisc_Id, LimiteCredito, idFiscal, Cuit, TipoDoc, MonedaLimCred, CategCred_Id,
vvenClientes.Bonificacion1,vvenClientes.Bonificacion2,vvenClientes.Bonificacion3,Puntual,Estado_Id,GeneraDebito,
Siempre,CongelaCambio,IBrutos,Situacion,vvenClientes.Posteado,vvenClientes.Inactivo,	
venVendedores.Vendedor_Id, venVendedores.Nombre , vvenClientes.TipoCredito

GO


DROP VIEW vstkExistenciaUbiSerie
GO
CREATE VIEW vstkExistenciaUbiSerie
AS
SELECT stkProductos.Producto_Id, stkDepositos.Deposito_Id, stkUbicaciones.Ubicacion_Id, 
		stkExistenciaUbiSerie.Serie, stkExistenciaUbiSerie.Cantidad, 
		stkExistenciaUbiSerie.Empresa_Id
FROM stkExistenciaUbiSerie INNER JOIN stkProductos ON 
	stkExistenciaUbiSerie.Producto_Id = stkProductos.stkProductos
	INNER JOIN stkDepositos ON 
	stkExistenciaUbiSerie.Deposito_Id = stkDepositos.stkDepositos
	INNER JOIN stkUbicaciones ON
	stkExistenciaUbiSerie.Ubicacion_Id = stkUbicaciones.stkUbicaciones
	WHERE 
		stkExistenciaUbiSerie.Cantidad > 0
GO


DROP VIEW vstkExistenciaUbi
GO
CREATE VIEW vstkExistenciaUbi
AS
SELECT stkProductos.Producto_Id, stkDepositos.Deposito_Id,
stkUbicaciones.Ubicacion_Id, 	stkExistenciaUbi.Cantidad, 
stkExistenciaUbi.Empresa_Id
FROM stkExistenciaUbi INNER JOIN stkProductos ON 
	stkExistenciaUbi.Producto_Id = stkProductos.stkProductos
	INNER JOIN stkDepositos ON 
	stkExistenciaUbi.Deposito_Id = stkDepositos.stkDepositos
	INNER JOIN stkUbicaciones ON
	stkExistenciaUbi.Ubicacion_Id = stkUbicaciones.stkUbicaciones
	WHERE
		stkExistenciaUbi.Cantidad > 0
GO




DROP VIEW vstkMoviUbicacion
GO
CREATE VIEW vstkMoviUbicacion
AS
SELECT stkMoviUbicacion.stkMoviCabe, stkMoviUbicacion.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkDepositos.Deposito_Id,
	stkUbicaciones.Ubicacion_Id, stkMoviUbicacion.Cantidad, stkMoviUbicacion.CantidadAlterna 
	FROM stkMoviUbicacion INNER JOIN stkUbicaciones ON
		stkUbicaciones.stkUbicaciones = stkMoviUbicacion.Ubicacion_Id
		INNER JOIN stkMoviCuerpo ON 
		stkMoviCuerpo.stkMoviCabe = stkMoviUbicacion.stkMoviCabe and
		stkMoviCuerpo.Renglon = stkMoviUbicacion.Renglon
		INNER JOIN stkProductos ON 
			stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		INNER JOIN stkDepositos ON 
			stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id

GO


DROP VIEW vstkMoviSerieUbicacion
GO
CREATE VIEW vstkMoviSerieUbicacion
AS
SELECT stkMoviSerieUbicacion.stkMoviCabe, stkMoviSerieUbicacion.Renglon, 
	stkProductos.Producto_Id, stkProductos.Descripcion, 
	stkDepositos.Deposito_Id,
	stkMoviSerieUbicacion.Serie,
	stkUbicaciones.Ubicacion_Id, stkMoviSerieUbicacion.Cantidad
	FROM stkMoviSerieUbicacion INNER JOIN stkUbicaciones ON
		stkUbicaciones.stkUbicaciones = stkMoviSerieUbicacion.Ubicacion_Id
		INNER JOIN stkMoviCuerpo ON 
		stkMoviCuerpo.stkMoviCabe = stkMoviSerieUbicacion.stkMoviCabe and
		stkMoviCuerpo.Renglon = stkMoviSerieUbicacion.Renglon
		INNER JOIN stkProductos ON 
			stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		INNER JOIN stkDepositos ON 
			stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
GO

GO

DROP VIEW vvenSubTipomov
GO

Create View vvenSubTipomov
AS

SELECT venSubTipomov.venSubTipomov, venSubTipomov.SubTipoMov_Id, venSubTipomov.Empresa_Id, 
	venSubTipomov.venTipoMov,  venSubTipomov.Descripcion, venSubTipomov.MueveStock, venSubTipomov.EsVentaContado,
		venSubTipomov.AdmiteDevolucion, venSubTipomov.ModificaPrecio, venSubTipomov.Reservado,  
		venSubTipomov.GeneraRemito, venSubTipomov.NCxDevolucion, venSubTipomov.PideCambio, 
		venSubTipomov.ModFecha, venSubTipomov.ModCondPago, venSubTipomov.ModVendedor,
		venSubTipomov.ModCobrador, venSubTipomov.PideObervaciones, venSubTipomov.CantidadCopias, 
		venSubTipomov.ModDeposito, venSubTipomov.ModListaPrecios, venSubTipomov.PideFechaEntrega,
		venSubTipomov.PideObsReng, venSubTipomov.ModCtaDefecto, venSubTipomov.ModCentro1, venSubTipomov.ModCentro2, 
		venSubTipomov.PideOtrosCargos, venSubTipomov.PermModCtaOtCar, venSubTipomov.FechaEntregaporRen, venSubTipomov.AdmiteFactsinEntr, 
		venSubTipomov.ModiUniMed, venSubTipomov.AfectaComCobra, venSubTipomov.MaxCantItems, venSubTipomov.EsPorDifPrecio, 
		venSubTipomov.AfectaEstadistica, venSubTipomov.ClaveAcceso, venSubTipomov.EsPorDifCambio, venSubTipomov.TipoPrecioForm, 
		venSubTipomov.SoloImpuestos, venSubTipomov.BajoCosto, venSubTipomov.Administrativa, venSubTipomov.PideReferencia, 
		venSubTipomov.PideOrdenCompra, venSubTipomov.PideCongelarCambio, venSubTipomov.PideMarcaReserva,
		venSubTipomov.PermiteSoloEntrega, venSubTipomov.CodigoFiscal, venSubTipomov.PidePredial, 
		venSubTipomov.PideCodProd, venSubTipomov.PideComExpoMX, venSubTipomov.Inactivo, 
		venSubTipomov.Posteado, venSubTipomov.Usuario_Id, venTipoMov.Signo, 
		conCuentas.Cuenta_Id as CtaDefecto, conCuentas.Descripcion as DescripcionCtaDefecto, 
		conCentro1.Centro1_Id, conCentro2.Centro2_Id, venSubTipoMov.PorCotizacion, venSubTipoMov.UsaCartaPorte,
		isNull(venOtcFormula.Formula_Id, '') CodFormula, isNull(venOtcFormula.Descripcion, '') DescFormula,
		CtaOTCargos.Cuenta_Id CtaOtrosCargos
		FROM 
			venSubTipomov 
			INNER JOIN venTipomov ON venTipomov.venTipomov = venSubTipoMov.venTipoMov
			LEFT JOIN conCuentas ON conCuentas.conCuentas = venSubTipoMov.CtaDefecto
			LEFT JOIN conCentro2 ON conCentro2.conCentro2 = venSubTipoMov.Centro2_Id
			LEFT JOIN conCentro1 ON conCentro1.conCentro1 = venSubTipoMov.Centro1_Id
			Left Join venOtcFormula On venOtcFormula.venOtcFormula = venSubTipoMov.codFormula
			Left Join conCuentas CtaOTCargos On CtaOTCargos.conCuentas = venSubTipoMov.CtaOtrosCargos
		
GO



DROP VIEW vtesSolicitud
GO
CREATE View vtesSolicitud AS

SELECT tesSolicitud.tesSolicitud, tesSolicitud.Fecha, tesSolicitud.FechaAutorizo, 
	tesSolicitud.Estado, tesSolicitud.Causa, tesSolicitud.Monto,  
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre, 
	tesSolSegmentos.Empresa_Id as Empresa
from tesSolicitud INNER JOIN tesSolicitantes ON
tesSolicitud.Solicitante_Id = tesSolicitantes.genEntidades
INNER JOIN tesSolSegmentos ON
tesSolSegmentos.tesSolicitud = tesSolicitud.tesSolicitud
GO


drop view vvenClientesCons
go
create view vvenClientesCons

as


select venclieHabitual.genEntidades as Padre, venClieHabitual.genEntidades as Hijo
from venclieHabitual

UNION
select venclieHabitual.ClieConsolida as Padre , venClieHabitual.genEntidades as Hijo
from venclieHabitual

UNION
select venclieHabitual.genEntidades as Padre, venClieHabitual.ClieConsolida as Hijo
from venclieHabitual

go


Drop view vvenClieHabitual 
GO

Create view vvenClieHabitual as

SELECT venClientes.genEntidades,  venClientes.Cliente_Id,  venClientes.Empresa_Id, 
venClientes.RazonSocial, venClientes.SucursalPredeter , venCondFiscal.CondFisc_Id, 
venClientes.LimiteCredito ,  genMonedas.Moneda_Id MonedaLimCred, venCategCredito.CategCred_Id,
venClientes.Bonificacion1, venClientes.Bonificacion2, venClientes.Bonificacion3,
venClientes.Puntual,venClientes.Estado_Id, venClientes.GeneraDebito,
venClientes.Siempre, venClientes.CongelaCambio, venClientes.IBrutos,
venClientes.Situacion, venClientes.Posteado, venClientes.FacturaCredito,
venClientes.MontoFacturaCredito, venClientes.CbuBanco, 
venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, 
venClieHabitual.Direccion1_Fact,venClieHabitual.NroExterior_Fact, 
venClieHabitual.NroInterior_Fact ,venClieHabitual.Direccion2_Fact,
venClieHabitual.Localidad_Fact, venClieHabitual.CodPostal_Fact,
genProvinciasF.Provincia_Id Provincia_Id_Fact , genPaisesF.Pais_Id Pais_Id_Fact,
venClieHabitual.Telefonos, venClieHabitual.Fax, venClieHabitual.EMail,
venClieHabitual.Direccion1_Entr, venClieHabitual.NroExterior_Entr, 
venClieHabitual.NroInterior_Entr,venClieHabitual.Direccion2_Entr, 
venClieHabitual.Localidad_Entr, venClieHabitual.CodPostal_Entr,
genProvinciasE.Provincia_Id Provincia_Id_Entr , genPaisesE.Pais_Id Pais_Id_Entr,
venTiposClie.TipoClie_Id, venListasPrecios.ListaPrecio_Id, 
venFormaEntrega.FormaEntrega_Id, venCondPago.CondPagoCli_Id, 
venVendedores.Vendedor_Id, venCobradores.Cobrador_Id, 
venZona.Zona_Id, venRegion.Region_Id,
venClieHabitual.Contactos, genUsuarios.Usuario_Id Usuario_Id_Alta,
venClieHabitual.FechaAlta,venClieHabitual.FechaUltContacto, venClieHabitual.FechaModificacion,
venClieHabitual.Observaciones, venClieHabitual.Bonificacion1 Bonificacion1S, 
venClieHabitual.Bonificacion2 Bonificacion2S, venClieHabitual.Bonificacion3 Bonificacion3S,
conCentro1.Centro1_Id ,conCentro2.Centro2_Id , venClientesC.Cliente_Id ClieConsolida,
venClieHabitual.Reclamos, venClieHabitual.MetodoDePago, venClieHabitual.NumCuenta,
venClieHabitual.C_UsoCFDI, venClieHabitual.N_MetodoPago, venClieHabitual.UsaComplementoINE,
venClieHabitual.Inactivo, venClieHabitual.LatitudGPS,venClieHabitual.LongitudGPS
FROM venClientes
	INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades
	INNER JOIN genEntidades ON genEntidades.genEntidades = venClieHabitual.genEntidades
	INNER JOIN venCondFiscal ON venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = venClientes.MonedaLimCred
	INNER JOIN venCategCredito ON venCategCredito.venCategCredito = venClientes.CategCred_Id
	INNER JOIN genProvincias genProvinciasF ON genProvinciasF.genProvincias = venClieHabitual.Provincia_Id_Fact 
	INNER JOIN genProvincias genProvinciasE ON genProvinciasE.genProvincias = venClieHabitual.Provincia_Id_Entr 
	INNER JOIN genPaises genPaisesF ON genPaisesF.genPaises = venClieHabitual.Pais_Id_Fact
	INNER JOIN genPaises genPaisesE ON genPaisesE.genPaises = venClieHabitual.Pais_Id_Entr 
	INNER JOIN venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	INNER JOIN venListasPrecios ON venListasPrecios.venListasPrecios = venClieHabitual.ListaPrecio_Id
	INNER JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venClieHabitual.FormaEntrega_Id
	INNER JOIN venCondPago ON venCondPago.venCondPago = venClieHabitual.CondPagoCli_Id
	INNER JOIN venVendedores ON venVendedores.venVendedores  = venClieHabitual.Vendedor_Id
	INNER JOIN venCobradores ON venCobradores.venCobradores =  venClieHabitual.Cobrador_Id
	INNER JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
	INNER JOIN venRegion ON venRegion.venRegion =  venClieHabitual.Region_Id
	INNER JOIN genUsuarios ON genUsuarios.genUsuarios = venClieHabitual.Usuario_Id_Alta
	LEFT JOIN conCentro1 ON  conCentro1.conCentro1 = venClieHabitual.Centro1_Id
	LEFT JOIN conCentro2 ON  conCentro2.conCentro2 = venClieHabitual.Centro2_Id
	LEFT JOIN venClientes as venClientesC ON venClientesC.genEntidades = venClieHabitual.ClieConsolida


GO


DROP VIEW vSuePersonal
GO

CREATE VIEW vSuePersonal
AS

SELECT Legajo, ApellidoPaterno+','+ApellidoMaterno+','+Nombres as Nombres ,Inactivo,Posteado, Empresa_Id
FROM suePersonal
GO


DROP VIEW vStkDepoExistencia
GO
CREATE VIEW vStkDepoExistencia
AS
SELECT stkDepositos.Deposito_Id,stkDepositos.Descripcion, ISNULL(stkExistencia.Cantidad,0) AS Cantidad, 
		ISNULL(stkExistencia.CantidadReservada,0) AS CantidadReservada, 
	     stkDepositos.Inactivo,stkDepositos.Posteado, stkExistencia.Empresa_Id, stkProductos.Producto_Id, 
		 stkDepositos.GrupoUsuarios, stkDepositos.AdmiteVentas, stkdepositos.UsaUbicacion
FROM 
		stkDepositos CROSS JOIN stkProductos 
		 left join stkExistencia ON stkExistencia.Producto_Id = stkProductos.stkProductos and 
		 stkExistencia.Deposito_Id = stkDepositos.stkDepositos 
	where
	stkDepositos.Inactivo = 0 

GO


DROP VIEW vStkProductosVen 
GO
CREATE VIEW vStkProductosVen 
AS	
	SELECT stkProductos.Producto_Id, stkProductos.Descripcion,
	venListasPrecios.ListaPrecio_id, 
	Convert(Numeric(18,4), venListasPrecProd.PrecioLista *
		isnull(stkArtiUM.Factor, 1)) as PrecioLista, 
	stkUniMed.Medida_Id, stkCondFisVenta.CFVenta_Id, stkProductos.Inactivo, stkProductos.Posteado, stkProductos.Empresa_Id, 
	ISNULL(stkUniMedA.Medida_Id,' ') as MedidaAlterna, stkProductos.Clase, 
	ISNULL(stkFamilias.Familia_Id, ' ') as Familia_Id, ISNULL(stkFamilias.Descripcion,' ') DescripcionFamilia,
	ISNULL(stkGrupos.Grupo_Id, ' ') as Grupo_Id, ISNULL(stkGrupos.Descripcion,' ') DescripcionGrupo, Observaciones, 
	venListasVersion.VigenciaDesde, venListasVersion.VigenciaHasta, stkProductos.CodigoBarra
	From stkProductos INNER JOIN venListasPrecProd ON stkProductos.stkProductos = venListasPrecProd.Producto_Id
		INNER JOIN venListasPrecios ON venListasPrecios.venListasPrecios = venListasPrecProd.ListaPrecio_Id
		INNER JOIN venListasVersion ON  venListasVersion.ListaPrecio_Id = venListasPrecProd.ListaPrecio_Id AND 
		venListasVersion.Version = venListasPrecProd.Version
		INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.UMVenta
		INNER JOIN stkCondFisVenta ON stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id
		LEFT OUTER JOIN stkArtiUM on stkArtiUM.Producto_Id = stkProductos.stkProductos and 
			stkArtiUM.Medida_Id = stkProductos.UMVenta
		LEFT JOIN stkUniMed  as stkUniMedA on
			stkUniMedA.stkUniMed = stkproductos.MedidaAlterna
		LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
		LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
GO


DROP VIEW vimpCFDIEmitidos
GO
CREATE VIEW vimpCFDIEmitidos
as
Select 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, 
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) AS Folio, conAsientos.Fecha,
venMovimientosFiscal.ClaveFiscal UUID, 
	case when venMovimientos.Importe = 0 THEN 'T' 
	when venTipoMov.Signo =1 THEN 'I' ELSE 'E' END AS TipoComprobante, 
	CAST(case when conAsientosA.conAsientos IS NOT NULL THEN 1 ELSE
	conAsientos.Anulado END AS BIT) Anulado  , conAsientos.Empresa_Id, isnull(conAsientosAnul.FechaAnulacion,conasientosA.Fecha) as FechaAnulacion

FROM venMovimientosFiscal 
	INNER JOIN venMovimientos ON venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos 
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	LEFT JOIN conAsientosAnul ON  conAsientosAnul.Asiento_Id = conAsientos.conAsientos
	LEFT JOIN (genAsiSegmentos genAsiSegmentosA INNER JOIN conasientos  conasientosA ON 
		conasientosA.conAsientos =genAsiSegmentosA.Asiento_Id ) ON
		genAsiSegmentosA.Segmento_Id = genAsiSegmentos.Segmento_Id AND 
		genAsiSegmentosA.Segmento1C = CASE genAsiSegmentos.Segmento1C WHEN 'F' THEN 'V' WHEN 'R' THEN 'W' ELSE ' ' END AND
		genAsiSegmentosA.Segmento2C =genAsiSegmentos.Segmento2C AND 
		genAsiSegmentosA.Segmento3C =genAsiSegmentos.Segmento3C AND 
		genAsiSegmentosA.Segmento4C =genAsiSegmentos.Segmento4C AND 
		genAsiSegmentosA.Segmento1N =genAsiSegmentos.Segmento1N AND 
		genAsiSegmentosA.Segmento2N =genAsiSegmentos.Segmento2N AND 
		genAsiSegmentosA.Segmento3N =genAsiSegmentos.Segmento3N AND 
		genAsiSegmentosA.Segmento4N =genAsiSegmentos.Segmento4N AND
		genAsiSegmentosA.Empresa_Id=genAsiSegmentos.Empresa_Id AND
		conasientosA.Anulado = 0 and conasientosA.Posteado = 1

UNION ALL
select dbo.Segmento(tesCFDICobranzaSegmentos.Segmento_Id, tesCFDICobranzaSegmentos.Segmento1C, 
	tesCFDICobranzaSegmentos.Segmento2C, tesCFDICobranzaSegmentos.Segmento3C, tesCFDICobranzaSegmentos.Segmento4C, 
	tesCFDICobranzaSegmentos.Segmento1N, tesCFDICobranzaSegmentos.Segmento2N, tesCFDICobranzaSegmentos.Segmento3N, 
	tesCFDICobranzaSegmentos.Segmento4N) AS Folio,
		tesCFDICobranza.Fecha, 
tesCFDICobranza.UUID, 'P' , Case when tesCFDICobranza.Anulada = '  ' then 0 else 1 end, 
tesCFDICobranzaSegmentos.Empresa_Id, isnull(tesCFDICobranza.FechaCancelacion, tesCFDICobranza.Fecha)
from tesCFDICobranza 
	inner join tesCFDICobranzaSegmentos ON tesCFDICobranzaSegmentos.tesCFDICobranza = tesCFDICobranza.tesCFDICobranza
UNION ALL -- RETENCIONES
select Convert(VarChar(100),impRetencionesCfdi.Folio) AS Folio,
		impRetencionesCfdi.FechaExp, 
impRetencionesCfdi.UUID, 'R' , impRetencionesCfdi.Cancelado, impRetencionesCfdi.Empresa_Id, 
isnull(impRetencionesCfdi.FechaCancelacion, impRetencionesCfdi.FechaExp)
from impRetencionesCfdi 
UNION ALL -- Sueldos
SELECT Convert(VarChar(100),sueNominaCfdi.Folio), sueNominaCfdi.Fecha, sueNominaCfdi.UUID, 
	'N' , sueNominaCfdi.Anulada, conAsientos.Empresa_Id, 
	ISNULL(sueNominaCfdi.FechaCancelacion, sueNominaCfdi.Fecha)
FROM sueNominaCfdi 	
	inner join sueLiquidacion ON sueLiquidacion.sueLiquidacion = sueNominaCfdi.sueLiquidacion
	inner join conAsientos ON  conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
GO

Drop view vconCuentasActualizacion
Go
Create view vconCuentasActualizacion
As
Select conCuentas.Cuenta_Id,conCuentas.Descripcion,conCuentas.Nivel,conCuentas.Imputable,conCuentas.Inactivo,conCuentas.Posteado,conCuentas.Rubro_Id,
	conCuentas.Empresa_Id, ReservadaPor, conCuentas.SubCuenta_Id
From conCuentas
Inner Join conRubros On conRubros.Rubro_Id = conCuentas.Rubro_Id
Where conCuentas.SubCuenta_Id Is Null And 
(conRubros.Tipo Not In ('GAS', 'COS') OR conCuentas.Nivel <= 2)
Union All
Select conCuentas.Cuenta_Id,conCuentas.Descripcion,conCuentas.Nivel,conCuentas.Imputable,conCuentas.Inactivo,conCuentas.Posteado,conCuentas.Rubro_Id,
	conCuentas.Empresa_Id, ReservadaPor, conCuentas.SubCuenta_Id
From conCuentas
Inner Join conRubros On conRubros.Rubro_Id = conCuentas.Rubro_Id
Where conCuentas.SubCuenta_Id Is Null And conRubros.Tipo In ('GAS', 'COS') And conCuentas.Nivel > 2
Go






DROP VIEW  vtesCobranzas
GO
CREATE VIEW  vtesCobranzas as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
tesSubTiposMov.SubTipo_Id, conAsientos.Posteado, disFormularios.Formulario_Id, tesMovimientos.tesMovimientos, 
conAsientos.Anulado, genAsiSegmentos.Empresa_Id as Empresa, genSucursalesEmpr.Sucursal SucursalMov, 
venClientes.Cliente_Id, venClientes.RazonSocial
From tesMovimientos
Inner join conAsientos ON tesMovimientos.tesMovimientos= conAsientos.conAsientos
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
inner join tesSubTiposMov ON tesMovimientos.SubTipo_id = tesSubTiposMov.tesSubTiposMov
inner join venMovimientos ON venMovimientos.venMovimientos = tesMovimientos.tesMovimientos 
inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
GO


DROP VIEW  vtesCobranzasTodas
GO
CREATE VIEW  vtesCobranzasTodas as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
tesSubTiposMov.SubTipo_Id, conAsientos.Posteado, disFormularios.Formulario_Id, tesMovimientos.tesMovimientos, 
conAsientos.Anulado, genAsiSegmentos.Empresa_Id as Empresa, Cast(Null As varChar(5)) SucursalMov, 
venClientes.Cliente_Id, venClientes.RazonSocial
From tesMovimientos
Inner join conAsientos ON tesMovimientos.tesMovimientos= conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
inner join tesSubTiposMov ON tesMovimientos.SubTipo_id = tesSubTiposMov.tesSubTiposMov
inner join venMovimientos ON venMovimientos.venMovimientos = tesMovimientos.tesMovimientos 
inner join venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
GO



DROP VIEW  vtesPagosProv
GO
CREATE VIEW  vtesPagosProv as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
tesSubTiposMov.SubTipo_Id, conAsientos.Posteado, disFormularios.Formulario_Id, tesMovimientos.tesMovimientos, 
conAsientos.Anulado, genAsiSegmentos.Empresa_Id as Empresa, genSucursalesEmpr.Sucursal SucursalMov, 
comProveedores.Proveed_Id, comProveedores.RazonSocial
From tesMovimientos
Inner join conAsientos ON tesMovimientos.tesMovimientos= conAsientos.conAsientos
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
inner join tesSubTiposMov ON tesMovimientos.SubTipo_id = tesSubTiposMov.tesSubTiposMov
inner join comMovprov ON comMovprov.comMovprov = tesMovimientos.tesMovimientos 
inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_Id
GO



DROP VIEW  vtesPagosProvTodas
GO
CREATE VIEW  vtesPagosProvTodas as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
tesSubTiposMov.SubTipo_Id, conAsientos.Posteado, disFormularios.Formulario_Id, tesMovimientos.tesMovimientos, 
conAsientos.Anulado, genAsiSegmentos.Empresa_Id as Empresa, Cast(Null As varChar(5)) SucursalMov, 
comProveedores.Proveed_Id, comProveedores.RazonSocial
From tesMovimientos
Inner join conAsientos ON tesMovimientos.tesMovimientos= conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = tesMovimientos.tesMovimientos
inner join tesSubTiposMov ON tesMovimientos.SubTipo_id = tesSubTiposMov.tesSubTiposMov
inner join comMovprov ON comMovprov.comMovprov = tesMovimientos.tesMovimientos 
inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_Id
GO


DROP VIEW  vstkRemitosProv
GO
CREATE VIEW  vstkRemitosProv as
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, conAsientos.Fecha, 
stkMoviCabe.SubTipomov_id,conAsientos.Posteado, disFormularios.Formulario_Id, stkMoviCabe.stkMoviCabe, 
genAsiSegmentos.Empresa_Id as Empresa, conAsientos.Anulado, genSucursalesEmpr.Sucursal as SucursalFiltro, 
comProveedores.Proveed_Id, comProveedores.RazonSocial, stkMoviProv.RemitoProv
from stkmovicabe 
Inner join conAsientos ON stkmovicabe.stkmovicabe = conAsientos.conAsientos
INNER Join disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkMoviCabe.stkMoviCabe
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN stkMoviProv ON  stkMoviProv.stkMoviCabe = stkMoviCabe.stkMoviCabe
INNER JOIN comProveedores ON comProveedores.genEntidades = stkMoviProv.Proveed_Id
GO

DROP VIEW vgenSucursalesEmpr
GO
Create VIEW vgenSucursalesEmpr
as
SELECT genSucursalesEmpr.*, genEmpresas.Empresa_Id as EmpresaSTR
FROM 
genSucursalesEmpr
left JOIN genEmpresas ON genSucursalesEmpr.Empresa_Id =genEmpresas.genEmpresas
GO

drop VIEW vconMovContRes
GO
-- Ingresos
CREATE VIEW vconMovContRes
AS

SELECT Fecha, Empresa_Id, conCuentas, Cuenta_Id, Tipo_Id, Descripcion, 
	conCentro1, Centro1_Id, conCentro2, Centro2_Id, Especial, SUM(Monto) as Monto, 
		sum(Debe) as Debe, SUM(Haber) as Haber
from (
SELECT conAsientos.Fecha, conAsientos.Empresa_Id, 
	conCuentas.conCuentas, 	conCuentas.Cuenta_Id, 
	conCuentas.Tipo_Id, conCuentas.Descripcion,
	conCentro1.conCentro1, ISNULL(conCentro1.Centro1_Id,'') Centro1_Id, 
	conCentro2.conCentro2, isnull(conCentro2.Centro2_Id, '') Centro2_Id,
	conAsientos.Especial,
	Sum(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Monto, 
	SUM(Case when conMovCont.TipoMov=1 then conMovCont.Importe else 0 end ) as Debe,
	SUM(Case when conMovCont.TipoMov=2 then conMovCont.Importe else 0 end ) as Haber
from conAsientos 
	inner join conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN conCentro1 ON conCentro1.conCentro1 = ISNULL(conMovCont.Centro1_Id,1)
	INNER JOIN conCentro2 ON conCentro2.conCentro2 = ISNULL(conMovCont.Centro2_Id,1)
	INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
	where
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado =1 and 
		genEmpresas.FechaInicioSumma <= conAsientos.Fecha
GROUP BY conAsientos.Fecha, conAsientos.Empresa_Id, 
	conCuentas.conCuentas, 	conCuentas.Cuenta_Id, 
	conCentro1.conCentro1, conCentro1.Centro1_Id, 
	conCentro2.conCentro2, conCentro2.Centro2_Id, 
	conAsientos.Especial, conCuentas.Tipo_Id, conCuentas.Descripcion
union all
SELECT conAsientos.Fecha, conAsientos.Empresa_Id, 
	conCuentas.conCuentas, 	conCuentas.Cuenta_Id, 
	conCuentas.Tipo_Id, conCuentas.Descripcion,
	conCentro1.conCentro1, conCentro1.Centro1_Id, 
	conCentro2.conCentro2, conCentro2.Centro2_Id, 
	conAsientos.Especial,
	Sum(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Monto,
	SUM(Case when conMovCont.TipoMov=1 then conMovCont.Importe else 0 end ) as Debe,
	SUM(Case when conMovCont.TipoMov=2 then conMovCont.Importe else 0 end ) as Haber
from conAsientos 
	inner join conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN conCentro1 ON conCentro1.conCentro1 = ISNULL(conMovCont.Centro1_Id,1)
	INNER JOIN conCentro2 ON conCentro2.conCentro2 = ISNULL(conMovCont.Centro2_Id,1)
	INNER JOIN genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
	INNER JOIN conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
	where
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado =1 
		and 	genEmpresas.FechaInicioSumma > conAsientos.Fecha 
GROUP BY conAsientos.Fecha, conAsientos.Empresa_Id, 
	conCuentas.conCuentas, 	conCuentas.Cuenta_Id, 
	conCentro1.conCentro1, conCentro1.Centro1_Id, 
	conCentro2.conCentro2, conCentro2.Centro2_Id, 
	conAsientos.Especial, conCuentas.Tipo_Id, conCuentas.Descripcion) as xxx
group by Fecha, Empresa_Id, conCuentas, Cuenta_Id, Tipo_Id, Descripcion, 
	conCentro1, Centro1_Id, conCentro2, Centro2_Id, Especial

GO

DROP VIEW vstkSolicitudCD
GO

CREATE VIEW vstkSolicitudCD
AS
SELECT stkSolicitudCD.Fecha,stkSolicitudCD.stkSolicitudCD,
stkSolicitudCD.Estado, stkDepositos.Deposito_Id
FROM stkSolicitudCD 
inner join stkDepositos ON stkDepositos.stkDepositos =stkSolicitudCD.DepositoDestino
GO

DROP VIEW vtesFlujoFondo
GO

CREATE VIEW vtesFlujoFondo
AS
SELECT FechaDesde,FechaHasta,Periodo, tesFlujoFondo
FROM tesFlujoFondo

GO

Drop view vsueLiquidacionesLega
Go
Create view vsueLiquidacionesLega
As
Select Distinct sueLiquidacion.sueLiquidacion as vsueLiquidacion, sueGrupos.Grupo_Id, 
sueGrupos.Descripcion as DescripcionGrupo, FechaPago, FechaDeposito, PeriodoDeposito, 
conCuentas.Cuenta_Id as CtaSueldosAPagar, conCuentas.Descripcion as DescripcionCtaSueldosAPagar, 
FechaInicial, FechaFinal, suePeriodicidad.Periodo_Id, 
suePeriodicidad.Descripcion as DescripcionPeriodo, Anio as vAnio, 
Mes as vMes, Quincena as vQuincena, Semana as vSemana, Decena as vDecena , Vez as vVez, FechaContabilizacion  ,
conAsientos.Empresa_Id as Empresa, conAsientos.Anulado, suePersonal.Legajo
From sueLiquidacion
Inner join sueGrupos on sueGrupos.sueGrupos=sueLiquidacion.Grupo_Id
Inner join conCuentas on conCuentas.conCuentas=sueLiquidacion.CtaSueldosAPagar
Left join suePeriodicidad on suePeriodicidad.Periodo_Id=sueLiquidacion.Periodo_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = sueLiquidacion.sueLiquidacion
Inner Join sueTerminada On sueTerminada.sueLiquidacion = sueLiquidacion.sueLiquidacion
Inner Join suePersonal On suePersonal.genEntidades = sueTerminada.Legajo
go


DROP VIEW vgenUsuariosLogueados 
go
CREATE VIEW vgenUsuariosLogueados 
AS
SELECT genUsuarios.Usuario_Id, genUsuariosLogueados.FechaLogin, genUsuariosLogueados.Caduca, 
genUsuariosLogueados.Token, genUsuariosLogueados.UltEmpresa, 
	genUsuarios.Cliente_Id
from genUsuariosLogueados INNER JOIN genUsuarios ON 
genUsuariosLogueados.Usuario_Id = genUsuarios.genUsuarios
WHERE
	genUsuariosLogueados.Caduca > GETDATE()
go


drop view vswsUsuarios
go
create view vswsUsuarios
as
select genUsuarios.Usuario_Id,Apellido_y_Nombres,Inactivo,Posteado,Empresa_Id,TipoUsuario from swsUsuarios
inner join genUsuarios on genUsuarios.genUsuarios=swsUsuarios.Usuario_Id
go


DROP VIEW vVenCanjeNotas
GO
CREATE VIEW vVenCanjeNotas
as
SELECT venMovimientos.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
conAsientos.Fecha, venMovimientos.venTipomov, 
venSubTipomov.SubTipomov_Id, venClientes.Cliente_Id, venClientes.RazonSocial, venSubTipomov.MueveStock,
disFormularios.Formulario_Id , conAsientos.Empresa_Id as Empresa, conAsientos.Anulado,
	venMovimientos.Importe, venMovimientos.Saldo, venTipoMov.Signo,
	venVendedores.Vendedor_Id
FROM venMovimientos INNER JOIN venSubTipomov ON venMovimientos.venSubTipomov_Id = venSubTipomov.venSubTipomov
inner join venClientes	ON venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
LEFT OUTER JOIN disFormularios ON disFormularios.disFormularios= conAsientos.Formulario_Id
INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
INNER JOIN venVendedores ON venVendedores.venVendedores = venMovimientos.Vendedor_Id
where NOT EXISTS(SELECT 1 FROM venCanjeNotas inner join conAsientos ON
			venCanjeNotas.venMovimientosFC = conAsientos.conAsientos
			where
			venCanjeNotas.venMovimientos = venMovimientos.venMovimientos aND
			conAsientos.Anulado = 0)
			and Segmento3C='N'
GO



DROP VIEW vstkDepositos
GO
CREATE VIEW vstkDepositos
AS
SELECT stkDepositos.Deposito_Id,stkDepositos.Descripcion, stkDepositos.Empresa_Id, 
	isnull(genSucursalesEmpr.Sucursal,'') Sucursal, stkDepositos.Direccion, 
	ISNULL(conCentro1.Centro1_Id,'') Centro1_Id , 
	ISNULL(conCentro2.Centro2_Id,'') Centro2_Id ,  
	stkDepositos.AdmiteVentas, stkDepositos.Consignacion,stkDepositos.Inactivo, stkDepositos.Posteado,
	stkDepositos.UsaUbicacion
FROM 
		stkDepositos 
		left join genSucursalesEmpr ON stkDepositos.Sucursal = genSucursalesEmpr.genSucursalesEmpr
		Left join conCentro1 ON  conCentro1.conCentro1 = stkDepositos.Centro1_Id
		Left join conCentro2 ON  conCentro2.conCentro2 = stkDepositos.Centro2_Id
	where
	stkDepositos.Inactivo = 0 

GO

DROP VIEW vgenMenusFormularios 
GO
CREATE VIEW vgenMenusFormularios 
AS

SELECT disFormularios.disFormularios, disFormularios.Formulario_Id, 
	STUFF(
    (SELECT ' / ' + m2.Opcion
    FROM genMenus m2 
    WHERE (m2.nivel < m1.Nivel) and (SUBSTRING(m2.Orden, 1, m2.nivel) = SUBSTRING(m1.Orden, 1, m2.nivel))
    FOR XML PATH ('')), 1,3, '') + ' / ' + m1.opcion as Opcion
FROM genMenus m1
INNER JOIN disFormularios on disFormularios.disFormularios = m1.Formulario_Id
WHERE m1.tipo = 'C'

GO


DROP VIEW vdisControlesXFormulario 
GO
CREATE VIEW vdisControlesXFormulario 
AS

SELECT disFormularios.Formulario_Id, c2.Texto as Solapa, c1.Control_Id, c1.TituloLabel as Titulo, c1.TipoControl
FROM disControles c1
INNER JOIN disFormularios on disFormularios.disFormularios = c1.Formulario_Id
INNER JOIN disControles c2 on c2.Formulario_Id = c1.Formulario_Id and c2.Control_Id = c1.ControlParent_Id
WHERE ((c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioLupaAdv') OR 
	   (c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioTxtEditor') OR 
	   (c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor') OR 
	   (c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioDatePicker') OR 
	   (c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioGridView'))
UNION 
SELECT disFormularios.Formulario_Id, c2.Texto as Solapa, c1.Control_Id, c1.Texto as Titulo, c1.TipoControl
FROM disControles c1
INNER JOIN disFormularios on disFormularios.disFormularios = c1.Formulario_Id
INNER JOIN disControles c2 on c2.Formulario_Id = c1.Formulario_Id and c2.Control_Id = c1.ControlParent_Id
WHERE ((c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioCheck')  OR 
	   (c1.TipoControl = 'SummaAdvDisenio.Controles.DisenioBoton'))
UNION
SELECT disFormularios.Formulario_Id, c1.ControlParent_Id as Solapa, c1.Control_Id, c1.Texto as Titulo, c1.TipoControl
FROM disControles c1
INNER JOIN disFormularios on disFormularios.disFormularios = c1.Formulario_Id
WHERE (c1.TipoControl = 'System.Windows.Forms.TabPage') 
UNION
SELECT disFormularios.Formulario_Id, disControles.ControlParent_Id as Solapa, c1.Control_Id + '.' + c1.NombreCampo, ISNULL(disControles.TituloLabel,'') + '.' + c1.Titulo, 'Columna'
FROM disControlesGrillaColumnas c1
INNER JOIN disControles on disControles.Formulario_Id = c1.Formulario_Id AND disControles.Control_Id = c1.Control_Id
INNER JOIN disFormularios on disFormularios.disFormularios = c1.Formulario_Id

GO


DROP VIEW vgenMenus
GO

Create View vgenMenus
AS

SELECT Orden, Empresa_Id, Nivel, isnull(disFormularios.Descripcion, Opcion)  Opcion, Tipo, 
	disFormularios.Formulario_Id, FrmEspecial, Pais, Orientacion, Reporte_Id, Especial, genMenus
FROM genMenus
	left join disFormularios on genMenus.Formulario_Id = disFormularios.disFormularios
GO


DROP VIEW vvenCartaPorte
GO
CREATE VIEW vvenCartaPorte
as
SELECT venMovimientos.venMovimientos, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
conAsientos.Fecha, venCamiones.Patente_Id Camion_Id, 
venOperadores.Operador_Id,
disFormularios.Formulario_Id , conAsientos.Empresa_Id as Empresa, conAsientos.Anulado
FROM venCompCartaPorte
INNER JOIN venMovimientos ON venCompCartaPorte.venmovimientos = venmovimientos.venmovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
LEFT OUTER JOIN disFormularios ON disFormularios.disFormularios= conAsientos.Formulario_Id
INNER JOIN venCamiones ON   venCamiones.venCamiones = venCompCartaPorte.Camion_Id
INNER JOIN venOperadores ON venOperadores.venOperadores =venCompCartaPorte.Operador_Id

GO

Drop view vcomProveedoresTipoPasivoRet
GO
Create view vcomProveedoresTipoPasivoRet
As
Select 0 TipoCtaProv, 'Todos' Descripcion
Union All
Select TipoCtaProv, Descripcion
From comProveedoresTipoPasivo
GO

Drop View vtesIdBanco
Go
Create View vtesIdBanco
As
Select tesIdentifica.tesIdentifica, tesIdentifica.Cartera_Id, tesIdentifica.Empresa_Id, tesTiposId.TipoCartera, tesIdentifica.Descripcion,
conCuentas.Cuenta_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, genMonedas.Moneda_Id, genUsuarios.Usuario_Id UsuarioAmo,
ModiCent1, ModiCent2, CtaValET.Cuenta_Id CtaValEnTransito, Reservado, VaAlCashFlow, tesIdentifica.Inactivo,
genUsuCreador.Usuario_Id, tesIdentifica.Posteado, tesIdBancoPropio.ChequeraPredeter, genReportes.Reporte_Id RepoCheq_Id
From tesIdentifica
Inner Join tesTiposId On tesTiposId.tesTiposId = tesIdentifica.TipoCartera
inner join tesIdBancoPropio ON tesIdBancoPropio.Cartera_Id = tesIdentifica.tesIdentifica
inner join genReportes ON genReportes.genReportes = tesIdBancoPropio.RepoCheq_Id
Left Join conCuentas On conCuentas.conCuentas = tesIdentifica.Cuenta_Id
Left Join conCentro1 On conCentro1.conCentro1 = tesIdentifica.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = tesIdentifica.Centro2_Id
Left Join genMonedas On genMonedas.genMonedas = tesIdentifica.Moneda_Id
Left Join genUsuarios On genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo
Left Join conCuentas CtaValET On CtaValET.conCuentas = tesIdentifica.CtaValEnTransito
Left Join genUsuarios genUsuCreador On genUsuCreador.genUsuarios = tesIdentifica.Usuario_Id
Go
DROP VIEW vvenAbonos
GO
CREATE VIEW vvenAbonos
AS 
	SELECT venAbonos.venAbonos, dbo.Segmento(venAbonosSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,
	venAbonosSegmentos.Segmento2C, venAbonosSegmentos.Segmento4C, venAbonosSegmentos.Segmento1N, venAbonosSegmentos.Segmento2N,
	venAbonosSegmentos.Segmento3N, venAbonosSegmentos.Segmento4N) Segmento, venClientes.Cliente_Id, venClientes.RazonSocial, 
	venAbonos.FechaInicio, venAbonos.FechaFin, venAbonos.FechaUltFacturacion, venAbonos.FechaProxFacturacion,
	venAbonos.Posteado, venAbonos.Empresa_Id as Empresa , venSubTipoMov.SubTipoMov_Id, genMonedas.Moneda_Id,
	MonFactu.Moneda_Id MonedaFacturacion, venCondPago.CondPagoCli_Id, venListasPrecios.ListaPrecio_Id, venVendedores.Vendedor_Id,
	venFormaEntrega.FormaEntrega_Id, genUsuarios.Usuario_Id, venAbonos.Frecuencia,
	venAbonos.Observaciones, venAbonos.ImporteTotal, venAbonos.Bonificacion1,
	venAbonos.Bonificacion2, venAbonos.Bonificacion3, venAbonos.Bonificacion4, venAbonos.Bonificacion5,
	venAbonos.Dato1, venAbonos.Dato2, venAbonos.Dato3,
	venAbonos.FechaRegistro
	From venAbonos
	Inner Join venAbonosSegmentos On venAbonosSegmentos.venAbonos = venAbonos.venAbonos
	INNER JOIN venClientes ON venAbonos.Cliente_Id = venClientes.genEntidades
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venAbonos.SubTipoMov_Id
	Inner Join genMonedas On genMonedas.genMonedas = venAbonos.Moneda_Id
	Inner Join genMonedas MonFactu On MonFactu.genMonedas = venAbonos.MonedaFacturacion
	Inner Join venCondPago On venCondPago.venCondPago = venAbonos.CondPagoCli_Id
	Inner Join venListasPrecios On venListasPrecios.venListasPrecios = venAbonos.ListaPrecio_Id
	Inner Join venVendedores On venVendedores.venVendedores = venAbonos.Vendedor_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venAbonos.FormaEntrega_Id
	left Join genUsuarios On genUsuarios.genUsuarios = venAbonos.Usuario_Id
GO	

DROP VIEW vvenAbonosCiclo
GO
CREATE VIEW vvenAbonosCiclo
AS 
SELECT venAbonosFacturacion.venAbonosFacturacion, dbo.Segmento(venAbonosFactuSegmentos.Segmento_Id, venAbonosFactuSegmentos.Segmento1C, venAbonosFactuSegmentos.Segmento2C,
venAbonosFactuSegmentos.Segmento2C, venAbonosFactuSegmentos.Segmento4C, venAbonosFactuSegmentos.Segmento1N, venAbonosFactuSegmentos.Segmento2N,
venAbonosFactuSegmentos.Segmento3N, venAbonosFactuSegmentos.Segmento4N) Ciclo, venAbonosFactuSegmentos.Empresa_Id,
venAbonosFacturacion.FechaDesde, venAbonosFacturacion.FechaHasta,
isNull(venAbonosFacturacion.ClienteDesde, '') ClienteDesde, isNull(venClientesD.RazonSocial, '') ClienteDesdeDescripcion, 
isNull(venAbonosFacturacion.ClienteHasta, '') ClienteHasta, isNull(venClientesD.RazonSocial, '') ClienteHastaDescripcion, 
isNull(VendedorDesde, '') VendedorDesde, isNull(venVendedoresD.Nombre, '') VendedorDesdeDescripcion, 
isNull(VendedorHasta, '') VendedorHasta, isNull(venVendedoresH.Nombre, '') VendedorHastaDescripcion, 
isNull(MonedaDesde, '') MonedaDesde, isNull(genMonedasD.Descripcion, '') MonedaDesdeDescripcion, 
isNull(MonedaHasta, '') MonedaHasta, isNull(genMonedasH.Descripcion, '') MonedaHastaDescripcion
From venAbonosFacturacion
Inner Join venAbonosFactuSegmentos On venAbonosFactuSegmentos.venAbonosFacturacion = venAbonosFacturacion.venAbonosFacturacion
Left Join venClientes venClientesD ON venAbonosFacturacion.ClienteDesde = venClientesD.Cliente_Id
Left Join venClientes venClientesH ON venAbonosFacturacion.ClienteDesde = venClientesH.Cliente_Id
Left Join venVendedores venVendedoresD On venVendedoresD.Vendedor_Id = venAbonosFacturacion.VendedorDesde
Left Join venVendedores venVendedoresH On venVendedoresH.Vendedor_Id = venAbonosFacturacion.VendedorDesde
Left Join genMonedas genMonedasD On genMonedasD.Moneda_Id = venAbonosFacturacion.MonedaDesde
Left Join genMonedas genMonedasH On genMonedasH.Moneda_Id = venAbonosFacturacion.MonedaDesde

GO	

-- Creo una vista con las recetas de cada producto devolviendo primero la receta principal --
Drop view vstkRecetaProducto
Go
Create view vstkRecetaProducto
As
Select stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Empresa_Id, stkProductos.Descripcion, 
stkUniMed.Medida_Id, stkProductos.Inactivo, stkProductos.Posteado, proRecetas.Receta_Id, proProductosReceta.Principal, proCentroProductivo.CtroProd_Id
From proRecetas
inner join proProductosReceta on proProductosReceta.Receta_Id = proRecetas.proRecetas
inner join stkProductos on stkProductos.stkProductos=proProductosReceta.Producto_Id And proProductosReceta.Principal = 1
Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
Inner Join proCentroProductivo On proCentroProductivo.proCentroProductivo = proRecetas.CtroProd_Id
Union All
Select stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Empresa_Id, stkProductos.Descripcion, 
stkUniMed.Medida_Id, stkProductos.Inactivo, stkProductos.Posteado, proRecetas.Receta_Id, proProductosReceta.Principal, proCentroProductivo.CtroProd_Id
From proRecetas
inner join proProductosReceta on proProductosReceta.Receta_Id = proRecetas.proRecetas
inner join stkProductos on stkProductos.stkProductos=proProductosReceta.Producto_Id And proProductosReceta.Principal = 0
Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
Inner Join proCentroProductivo On proCentroProductivo.proCentroProductivo = proRecetas.CtroProd_Id

Go