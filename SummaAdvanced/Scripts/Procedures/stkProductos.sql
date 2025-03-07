DROP PROCEDURE stkProductosGuardar
GO
CREATE PROCEDURE stkProductosGuardar
(
@pProducto_Id varchar(25),
@pProducto_Id_Nuevo varchar(25),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(80),
@pDescripcionDetallada QMemo = NULL,
@pDescription QMemo = NULL,
@pMedida_Id varchar(5),
@pMedidaAlterna varChar(5) = NULL,
@pFactorAlterna qCantidadD8,
@pClase char(1),
@pClaseAlterna char(1),
@pCodigoBarra varchar(25),
@pTipo_Id varchar(5) = NULL,
@pFamilia_Id varChar(15) = Null,
@pGrupo_Id varChar(15) = Null,
@pTrabajaPorLotes Sino,
@pconVencimiento Sino,
@pSerializable Sino,
@pUsaDespachoImportacion Sino,
@pUmVenta varchar(5) = NULL,
@pCostoPromPond qMonedaD8,
@pCostoUltCompra qMonedaD8,
@pCostoReposicion qMonedaD8,
@pCostoStandard qMonedaD8,
@pCostoUltimoCierre qMonedaD8,
@pMonedaUltCompra varchar(3) = NULL,
@pPrecioUltCompra qMonedaD8,
@pUMCompra varchar(5) = NULL,
@pCtaCompra varchar(25) = NULL,
@pCtaAjuInventario varchar(25) = NULL,
@pCtaVenta varchar(25) = NULL,
@pCtaCredito varchar(25) = NULL,
@pCtaDescuento varchar(25) = NULL,
@pCtaCosto varchar(25) = NULL,
@pCtaVentaExt varchar(25) = NULL,
@pCtaCreditoExt varchar(25) = NULL,
@pCtaDescuentoExt varchar(25) = NULL,
@pCtaCostoExt varchar(25) = NULL,
@pFcha_Ult_Compra qFecha,
@pMargenExceso qPorcentaje,
@pTiempoEntrega smallint,
@pAcepta_Ventas Sino,
@pCFVenta_Id varchar(5) = NULL,
@pAcepta_Compras Sino,
@pCFComp_Id varchar(5) = NULL,
@pAcepta_Comis_Vta Sino,
@pDiasGarantia smallint,
@pImagen QMemo = NULL,
@pFechaUltModif qFechaHora,
@pImagenExtension varchar(5),
@pCodigoFiscal VarChar(20)=NULL,
@pFraccionArancelaria VarChar(20)=NULL,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino,
@pCtaConsumo varchar(25)=null,
@pObservaciones QMemo,
@pUlrProd varchar(max)=null,
@pClaveSTCC VarChar(6) = NULL,
@pMaterialPeligroso Bit, 
@pCveMaterialPeligroso VarChar(6) = NULL,
@pEmbalaje VarChar(6) = NULL,
@pPesoEnKg Numeric(18,4) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkProductos WHERE (Producto_Id = @pProducto_id)))
BEGIN 
	UPDATE stkProductos
	SET		@lIdentidad = stkProductos,
		Producto_Id = @pProducto_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		DescripcionDetallada = @pDescripcionDetallada,
		Description = @pDescription,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		MedidaAlterna = dbo.FuncFKstkUniMed(@pMedidaAlterna),
		FactorAlterna = @pFactorAlterna,
		Clase = @pClase,
		ClaseAlterna = @pClaseAlterna,
		CodigoBarra = @pCodigoBarra,
		Tipo_Id = dbo.FuncFKstkTipos(@pTipo_Id),
		Familia_Id = dbo.FuncFKstkFamilias(@pFamilia_Id),
		Grupo_Id = dbo.FuncFKstkGrupos(@pGrupo_Id),
		TrabajaPorLotes = @pTrabajaPorLotes,
		conVencimiento = @pconVencimiento,
		Serializable = @pSerializable,
		UsaDespachoImportacion = @pUsaDespachoImportacion,
		UmVenta = dbo.FuncFKstkUniMed(@pUmVenta),
		CostoPromPond = @pCostoPromPond,
		CostoUltCompra = @pCostoUltCompra,
		CostoReposicion = @pCostoReposicion,
		CostoStandard = @pCostoStandard,
		CostoUltimoCierre = @pCostoUltimoCierre,
		MonedaUltCompra = dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		PrecioUltCompra = @pPrecioUltCompra,
		UMCompra = dbo.FuncFKstkUniMed(@pUMCompra),
		CtaCompra = dbo.FuncFKconCuentas(@pCtaCompra),
		CtaAjuInventario = dbo.FuncFKconCuentas(@pCtaAjuInventario),
		CtaVenta = dbo.FuncFKconCuentas(@pCtaVenta),
		CtaCredito = dbo.FuncFKconCuentas(@pCtaCredito),
		CtaDescuento = dbo.FuncFKconCuentas(@pCtaDescuento),
		CtaCosto = dbo.FuncFKconCuentas(@pCtaCosto),
		CtaVentaExt = dbo.FuncFKconCuentas(@pCtaVentaExt),
		CtaCreditoExt = dbo.FuncFKconCuentas(@pCtaCreditoExt),
		CtaDescuentoExt = dbo.FuncFKconCuentas(@pCtaDescuentoExt),
		CtaCostoExt = dbo.FuncFKconCuentas(@pCtaCostoExt),
		Fcha_Ult_Compra = @pFcha_Ult_Compra,
		MargenExceso = @pMargenExceso,
		TiempoEntrega = @pTiempoEntrega,
		Acepta_Ventas = @pAcepta_Ventas,
		CFVenta_Id = dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		Acepta_Compras = @pAcepta_Compras,
		CFComp_Id = dbo.FuncFKstkCondFisCompra(@pCFComp_Id),
		Acepta_Comis_Vta = @pAcepta_Comis_Vta,
		DiasGarantia = @pDiasGarantia,
		FechaUltModif = @pFechaUltModif,
		ImagenExtension = @pImagenExtension,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado,
		Imagen = @pImagen, 
		CodigoFiscal = @pCodigoFiscal, 
		FraccionArancelaria =@pFraccionArancelaria,
		CtaConsumo=dbo.funcfkconCuentas(@pCtaConsumo),
		Observaciones=@pObservaciones,
		UrlProd=@pUlrProd, 
		ClaveSTCC = @pClaveSTCC,
		MaterialPeligroso  = @pMaterialPeligroso, 
		CveMaterialPeligroso = @pCveMaterialPeligroso,
		Embalaje = @pEmbalaje,
		PesoEnKg = @pPesoEnKg
	WHERE (Producto_Id = @pProducto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkProductos
	(
		Producto_Id,
		Empresa_Id,
		Descripcion,
		DescripcionDetallada,
		Description,
		Medida_Id,
		MedidaAlterna,
		FactorAlterna,
		Clase,
		ClaseAlterna,
		CodigoBarra,
		Tipo_Id,
		Familia_Id,
		Grupo_Id,
		TrabajaPorLotes,
		conVencimiento,
		Serializable,
		UsaDespachoImportacion,
		UmVenta,
		CostoPromPond,
		CostoUltCompra,
		CostoReposicion,
		CostoStandard,
		CostoUltimoCierre,
		MonedaUltCompra,
		PrecioUltCompra,
		UMCompra,
		CtaCompra,
		CtaAjuInventario,
		CtaVenta,
		CtaCredito,
		CtaDescuento,
		CtaCosto,
		CtaVentaExt,
		CtaCreditoExt,
		CtaDescuentoExt,
		CtaCostoExt,
		Fcha_Ult_Compra,
		MargenExceso,
		TiempoEntrega,
		Acepta_Ventas,
		CFVenta_Id,
		Acepta_Compras,
		CFComp_Id,
		Acepta_Comis_Vta,
		DiasGarantia,
		FechaUltModif,
		ImagenExtension,
		Inactivo,
		Usuario_Id,
		Posteado,
		Imagen, 
		CodigoFiscal,
		FraccionArancelaria,
		CtaConsumo,
		Observaciones,
		UrlProd,
		ClaveSTCC,
		MaterialPeligroso , 
		CveMaterialPeligroso,
		Embalaje,
		PesoEnKg
	)
	VALUES 
	(
		@pProducto_Id_Nuevo,
		@pEmpresa_Id,
		@pDescripcion,
		@pDescripcionDetallada,
		@pDescription,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		dbo.FuncFKstkUniMed(@pMedidaAlterna),
		@pFactorAlterna,
		@pClase,
		@pClaseAlterna,
		@pCodigoBarra,
		dbo.FuncFKstkTipos(@pTipo_Id),
		dbo.FuncFKstkFamilias(@pFamilia_Id),
		dbo.FuncFKstkGrupos(@pGrupo_Id),
		@pTrabajaPorLotes,
		@pconVencimiento,
		@pSerializable,
		@pUsaDespachoImportacion,
		dbo.FuncFKstkUniMed(@pUmVenta),
		@pCostoPromPond,
		@pCostoUltCompra,
		@pCostoReposicion,
		@pCostoStandard,
		@pCostoUltimoCierre,
		dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		@pPrecioUltCompra,
		dbo.FuncFKstkUniMed(@pUMCompra),
		dbo.FuncFKconCuentas(@pCtaCompra),
		dbo.FuncFKconCuentas(@pCtaAjuInventario),
		dbo.FuncFKconCuentas(@pCtaVenta),
		dbo.FuncFKconCuentas(@pCtaCredito),
		dbo.FuncFKconCuentas(@pCtaDescuento),
		dbo.FuncFKconCuentas(@pCtaCosto),
		dbo.FuncFKconCuentas(@pCtaVentaExt),
		dbo.FuncFKconCuentas(@pCtaCreditoExt),
		dbo.FuncFKconCuentas(@pCtaDescuentoExt),
		dbo.FuncFKconCuentas(@pCtaCostoExt),
		@pFcha_Ult_Compra,
		@pMargenExceso,
		@pTiempoEntrega,
		@pAcepta_Ventas,
		dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		@pAcepta_Compras,
		dbo.FuncFKstkCondFisCompra(@pCFComp_Id),
		@pAcepta_Comis_Vta,
		@pDiasGarantia,
		@pFechaUltModif,
		@pImagenExtension,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado,
		@pImagen, 
		@pCodigoFiscal, 
		@pFraccionArancelaria,
		dbo.FuncFKconCuentas(@pCtaConsumo),
		@pObservaciones,
		@pUlrProd,
		@pClaveSTCC,
		@pMaterialPeligroso , 
		@pCveMaterialPeligroso,
		@pEmbalaje,
		@pPesoEnKg
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO


DROP PROCEDURE stkProductosGuardarConMovimientos
GO
CREATE PROCEDURE stkProductosGuardarConMovimientos
(
@pProducto_Id varchar(25),
@pProducto_Id_Nueva varchar(25),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(80),
@pDescripcionDetallada QMemo = NULL,
@pDescription QMemo = NULL,
--@pMedida_Id varchar(5),
@pMedidaAlterna varChar(5) = NULL,
@pFactorAlterna qCantidadD8,
--@pClase char(1),
@pClaseAlterna char(1),
@pCodigoBarra varchar(25),
@pTipo_Id varchar(5) = NULL,
@pFamilia_Id varChar(15) = Null,
@pGrupo_Id varChar(15) = Null,
--@pTrabajaPorLotes Sino,
--@pconVencimiento Sino,
--@pSerializable Sino,
--@pUsaDespachoImportacion Sino,
@pUmVenta varchar(5) = NULL,
--@pCostoPromPond qMonedaD8,
--@pCostoUltCompra qMonedaD8,
@pCostoReposicion qMonedaD8,
--@pCostoStandard qMonedaD8,
--@pCostoUltimoCierre qMonedaD8,
@pMonedaUltCompra varchar(3) = NULL,
--@pPrecioUltCompra qMonedaD8,
@pUMCompra varchar(5) = NULL,
@pCtaCompra varchar(25) = NULL,
@pCtaAjuInventario varchar(25) = NULL,
@pCtaVenta varchar(25) = NULL,
@pCtaCredito varchar(25) = NULL,
@pCtaDescuento varchar(25) = NULL,
@pCtaCosto varchar(25) = NULL,
@pCtaVentaExt varchar(25) = NULL,
@pCtaCreditoExt varchar(25) = NULL,
@pCtaDescuentoExt varchar(25) = NULL,
@pCtaCostoExt varchar(25) = NULL,
--@pFcha_Ult_Compra qFecha,
@pMargenExceso qPorcentaje,
@pTiempoEntrega smallint,
@pAcepta_Ventas Sino,
@pCFVenta_Id varchar(5) = NULL,
@pAcepta_Compras Sino,
@pCFComp_Id varchar(5) = NULL,
@pAcepta_Comis_Vta Sino,
@pDiasGarantia smallint,
@pImagen QMemo = NULL,
@pFechaUltModif qFechaHora,
@pImagenExtension varchar(5),
@pCodigoFiscal VarChar(20)=NULL,
@pFraccionArancelaria VarChar(20)=NULL,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino,
@pCtaConsumo varchar(25),
@pObservaciones QMemo,
@pUlrProd varchar(max)=null, 
@pClaveSTCC VarChar(6) = NULL,
@pMaterialPeligroso Bit, 
@pCveMaterialPeligroso VarChar(6) = NULL,
@pEmbalaje VarChar(6) = NULL,
@pPesoEnKg Numeric(18,4) = NULL
)
AS
SET NOCOUNT ON 

DECLARE @lIdentidad int
--IF (EXISTS (SELECT 1 FROM stkProductos WHERE (Producto_Id = @pProducto_id)))

UPDATE stkProductos
SET	@lIdentidad = stkProductos,
	Producto_Id = @pProducto_Id_Nueva,
	Empresa_Id = @pEmpresa_Id,
	Descripcion = @pDescripcion,
	DescripcionDetallada = @pDescripcionDetallada,
	Description = @pDescription,
	--Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
	MedidaAlterna = dbo.FuncFKstkUniMed(@pMedidaAlterna),
	FactorAlterna = @pFactorAlterna,
	--Clase = @pClase,
	ClaseAlterna = @pClaseAlterna,
	CodigoBarra = @pCodigoBarra,
	Tipo_Id = dbo.FuncFKstkTipos(@pTipo_Id),
	Familia_Id = dbo.FuncFKstkFamilias(@pFamilia_Id),
	Grupo_Id = dbo.FuncFKstkGrupos(@pGrupo_Id),	--TrabajaPorLotes = @pTrabajaPorLotes,
	--conVencimiento = @pconVencimiento,
	--Serializable = @pSerializable,
	--UsaDespachoImportacion = @pUsaDespachoImportacion,
	UmVenta = dbo.FuncFKstkUniMed(@pUmVenta),
	--CostoPromPond = @pCostoPromPond,
	--CostoUltCompra = @pCostoUltCompra,
	CostoReposicion = @pCostoReposicion,
	--CostoStandard = @pCostoStandard,
	--CostoUltimoCierre = @pCostoUltimoCierre,
	MonedaUltCompra = dbo.FuncFKgenMonedas(@pMonedaUltCompra),
	--PrecioUltCompra = @pPrecioUltCompra,
	UMCompra = dbo.FuncFKstkUniMed(@pUMCompra),
	CtaCompra = dbo.FuncFKconCuentas(@pCtaCompra),
	CtaAjuInventario = dbo.FuncFKconCuentas(@pCtaAjuInventario),
	CtaVenta = dbo.FuncFKconCuentas(@pCtaVenta),
	CtaCredito = dbo.FuncFKconCuentas(@pCtaCredito),
	CtaDescuento = dbo.FuncFKconCuentas(@pCtaDescuento),
	CtaCosto = dbo.FuncFKconCuentas(@pCtaCosto),
	CtaVentaExt = dbo.FuncFKconCuentas(@pCtaVentaExt),
	CtaCreditoExt = dbo.FuncFKconCuentas(@pCtaCreditoExt),
	CtaDescuentoExt = dbo.FuncFKconCuentas(@pCtaDescuentoExt),
	CtaCostoExt = dbo.FuncFKconCuentas(@pCtaCostoExt),
	--Fcha_Ult_Compra = @pFcha_Ult_Compra,
	MargenExceso = @pMargenExceso,
	TiempoEntrega = @pTiempoEntrega,
	Acepta_Ventas = @pAcepta_Ventas,
	CFVenta_Id = dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
	Acepta_Compras = @pAcepta_Compras,
	CFComp_Id = dbo.FuncFKstkCondFisCompra(@pCFComp_Id),
	Acepta_Comis_Vta = @pAcepta_Comis_Vta,
	DiasGarantia = @pDiasGarantia,
	FechaUltModif = @pFechaUltModif,
	ImagenExtension = @pImagenExtension,
	Inactivo = @pInactivo,
	Usuario_Id = @pUsuario_Id,
	Posteado = @pPosteado,
	Imagen = @pImagen, 
	CodigoFiscal = @pCodigoFiscal, 
	FraccionArancelaria =@pFraccionArancelaria,
	CtaConsumo=dbo.FuncFKconCuentas(@pCtaConsumo),
	Observaciones=@pObservaciones,
	UrlProd=@pUlrProd,
	ClaveSTCC = @pClaveSTCC,
	MaterialPeligroso  = @pMaterialPeligroso, 
	CveMaterialPeligroso = @pCveMaterialPeligroso,
	Embalaje = @pEmbalaje,
	PesoEnKg = @pPesoEnKg
WHERE (Producto_Id = @pProducto_Id)

Select @lIdentidad as RetVal 

GO




DROP PROCEDURE stkProductosDatos
GO
CREATE PROCEDURE stkProductosDatos
(
@pProducto_id varchar(25)
)
AS
SET NOCOUNT ON 


SELECT stkProductos.stkProductos, stkProductos.Producto_Id, stkProductos.Empresa_Id, 
	Cast( Case When stkProductos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, stkUniMed.Medida_Id,
	stkUniMed.Descripcion as DescripcionUniMed, stkMedidaAlterna.Medida_Id MedidaAlterna, stkMedidaAlterna.Descripcion DescripcionMedidaAlterna,
	stkProductos.FactorAlterna, stkProductos.Clase, stkProductos.ClaseAlterna, stkProductos.CodigoBarra, stkTipos.Tipo_Id,
	stkTipos.Descripcion as DescripcionTipos, stkFamilias.Familia_Id, stkFamilias.Descripcion DescripcionFamilia,
	stkGrupos.Grupo_Id, stkGrupos.Descripcion DescripcionGrupo,	stkProductos.TrabajaPorLotes, stkProductos.conVencimiento,
	stkProductos.Serializable, stkProductos.UsaDespachoImportacion,
	UmVenta.Medida_Id as UmVenta, UmVenta.Descripcion as DescripcionUmVenta, stkProductos.CostoPromPond, stkProductos.CostoUltCompra,
	stkProductos.CostoReposicion, stkProductos.CostoStandard, stkProductos.CostoUltimoCierre,
	genMonedas.Moneda_Id MonedaUltCompra, genMonedas.Descripcion as DescripcionMonedas,
	stkProductos.PrecioUltCompra, UMCompra.Medida_Id as UMCompra, UMCompra.Descripcion as DescripcionUMCompra, 
	CtaCompra.Cuenta_Id as CtaCompra,CtaCompra.Descripcion as DescripcionCtaCompra, 
	CtaAjuInventario.Cuenta_Id as CtaAjuInventario, CtaAjuInventario.Descripcion as DescripcionCtaAjuInventario, 
	CtaVenta.Cuenta_Id as CtaVenta,	CtaVenta.Descripcion as DescripcionCtaVenta, 
	CtaCredito.Cuenta_Id as CtaCredito, CtaCredito.Descripcion as DescripcionCtaCredito, 
	CtaDescuento.Cuenta_Id as CtaDescuento,CtaDescuento.Descripcion as DescripcionCtaDescuento, 
	CtaCosto.Cuenta_Id as CtaCosto , CtaCosto.Descripcion as DescripcionCtaCosto, 
	CtaVentaExt.Cuenta_Id as CtaVentaExt ,	CtaVentaExt.Descripcion as DescripcionCtaVentaExt, 
	CtaCreditoExt.Cuenta_Id as CtaCreditoExt , CtaCreditoExt.Descripcion as DescripcionCtaCreditoExt, 
	CtaDescuentoExt.Cuenta_Id as CtaDescuentoExt ,CtaDescuentoExt.Descripcion as DescripcionCtaDescuentoExt, 
	CtaCostoExt.Cuenta_Id as CtaCostoExt , CtaCostoExt.Descripcion as DescripcionCtaCostoExt, 
	stkProductos.Fcha_Ult_Compra,
	stkProductos.MargenExceso, stkProductos.TiempoEntrega, stkProductos.Acepta_Ventas, stkCondFisVenta.CFVenta_Id,
	stkCondFisVenta.Descripcion as DescripcionCondFisVenta, stkProductos.Acepta_Compras, stkCondFisCompra.CFComp_Id, stkCondFisCompra.Descripcion as DescripcionCondFisCompra,
	stkProductos.Acepta_Comis_Vta, stkProductos.DiasGarantia, stkProductos.FechaUltModif, stkProductos.ImagenExtension,
	stkProductos.Imagen, stkProductos.CodigoFiscal, stkProductos.FraccionArancelaria, Cast(0 As Bit) TieneMovimientos,
	stkProductos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, stkProductos.Posteado,
	CtaConsumo.Cuenta_Id as CtaConsumo, CtaConsumo.Descripcion as DescripcionCtaConsumo, ' ' as Plantilla_Id, 
	' ' DescripcionPlantilla,Observaciones,UrlProd, stkProductos.ClaveSTCC, stkProductos.MaterialPeligroso , 
		stkProductos.CveMaterialPeligroso, stkProductos.Embalaje, stkProductos.PesoEnKg, wooProductosId.wooCommerceId
FROM stkProductos 
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkProductos.Medida_Id)
LEFT JOIN stkTipos  ON (stkTipos.stkTipos = stkProductos.Tipo_Id)
LEFT JOIN stkUniMed UmVenta ON (UmVenta.stkUniMed = stkProductos.UmVenta)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = stkProductos.MonedaUltCompra)
LEFT JOIN stkUniMed UMCompra ON (UMCompra.stkUniMed = stkProductos.UMCompra)
LEFT JOIN conCuentas  as CtaCompra ON (CtaCompra.conCuentas = stkProductos.CtaCompra)
LEFT JOIN conCuentas CtaAjuInventario ON (CtaAjuInventario.conCuentas = stkProductos.CtaAjuInventario)
LEFT JOIN conCuentas CtaVenta ON (CtaVenta.conCuentas = stkProductos.CtaVenta)
LEFT JOIN conCuentas CtaCredito ON (CtaCredito.conCuentas = stkProductos.CtaCredito)
LEFT JOIN conCuentas CtaDescuento ON (CtaDescuento.conCuentas = stkProductos.CtaDescuento)
LEFT JOIN conCuentas CtaCosto ON (CtaCosto.conCuentas = stkProductos.CtaCosto)
LEFT JOIN conCuentas CtaVentaExt ON (CtaVentaExt.conCuentas = stkProductos.CtaVentaExt)
LEFT JOIN conCuentas CtaCreditoExt ON (CtaCreditoExt.conCuentas = stkProductos.CtaCreditoExt)
LEFT JOIN conCuentas CtaDescuentoExt ON (CtaDescuentoExt.conCuentas = stkProductos.CtaDescuentoExt)
LEFT JOIN conCuentas CtaCostoExt ON (CtaCostoExt.conCuentas = stkProductos.CtaCostoExt)
LEFT JOIN stkCondFisVenta  ON (stkCondFisVenta.stkCondFisVenta = stkProductos.CFVenta_Id)
LEFT JOIN stkCondFisCompra  ON (stkCondFisCompra.stkCondFisCompra = stkProductos.CFComp_Id)
Left Join stkUniMed stkMedidaAlterna On stkMedidaAlterna.stkUniMed = stkProductos.MedidaAlterna
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkProductos.Usuario_Id)
Left Join stkFamilias On stkFamilias.stkFamilias = stkProductos.Familia_Id
Left Join stkGrupos On stkGrupos.stkGrupos = stkProductos.Grupo_Id
left join conCuentas CtaConsumo on CtaConsumo.conCuentas=stkProductos.CtaConsumo
left join wooProductosId on wooProductosId.Producto_Id=stkProductos.stkProductos
WHERE (stkProductos.Producto_id = @pProducto_id)
 

SELECT stkUniMed.Medida_Id, stkArtiUM.Factor, stkArtiUM.CodigoBarra
FROM stkArtiUM 
INNER JOIN stkProductos ON stkArtiUM.Producto_id = stkProductos.stkProductos 
INNER JOIN stkUniMed ON stkArtiUM.Medida_id = stkUniMed.stkUniMed
WHERE (stkProductos.Producto_id = @pProducto_id)		

Declare @pidentity bigint= dbo.FuncFKstkProductos(@pProducto_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkProductos'
--Exec genAtributosGeneralesIdentityEspDatos @pidentity, 'stkProductos'
-- PARA V2 Se agrega esto
exec proProductosRecetaDatos @pProducto_Id
exec stkProductosComboDatos @pProducto_Id

exec genAdjuntosIdentityDatos 'stkProductos', 0

RETURN @@Error 

GO

DROP PROCEDURE stkProductosEliminar
GO
CREATE PROCEDURE stkProductosEliminar
(
@pProducto_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductos 
WHERE (Producto_Id = @pProducto_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkProductos
GO

CREATE FUNCTION FuncFKstkProductos
(
@pProducto_id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  
  SELECT @pIdentity = stkProductos 
  FROM stkProductos 
  WHERE Producto_id = @pProducto_id
  
  RETURN @pIdentity
END


GO

DROP PROCEDURE stkProductosTieneMovimientos 
GO
CREATE PROCEDURE stkProductosTieneMovimientos 
(
	@pProducto_id VarChar(25)
)
AS

SELECT count(1) as Cantidad
From stkMoviCuerpo 
INNER JOIN stkProductos ON stkMoviCuerpo.Producto_id = stkProductos.stkProductos
where stkProductos.Producto_id = @pProducto_id
	
GO
	
DROP PROCEDURE stkProductosCodFiscalGuardar
GO
CREATE PROCEDURE stkProductosCodFiscalGuardar
(
@pProducto_Id varchar(25),
@pCodigoFiscal VarChar(20)
)
AS
Update stkProductos set CodigoFiscal = @pCodigoFiscal Where Producto_Id = @pProducto_Id
GO
	
drop procedure stkProductosIdentityDatos
go
create procedure stkProductosIdentityDatos
(
	@pstkProductos  int
)
as
declare @lProducto_Id varchar(25)= (select Producto_Id from stkProductos where stkProductos=@pstkProductos)
exec stkProductosDatos @lProducto_Id
go


Drop procedure stkProductosDatosCodBarra
Go
Create procedure stkProductosDatosCodBarra
(
	@pCodBarra varchar(25)
)
As
Declare @lProducto_Id varchar(25) = (Select Producto_Id From stkProductos Where CodigoBarra = @pCodBarra)
Exec stkProductosDatos @lProducto_Id
Go
