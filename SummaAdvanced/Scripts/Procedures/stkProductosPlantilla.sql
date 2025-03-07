DROP PROCEDURE stkProductosPlantillaGuardar
GO
CREATE PROCEDURE stkProductosPlantillaGuardar
(
@pPlantilla_Id varchar(25),
@pPlantilla_Id_Nuevo varchar(25),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(80),
@pMedida_Id varchar(5) = NULL,
@pMedidaAlterna varchar(5) = NULL,
@pFactorAlterna qCantidadD8,
@pClase char(1),
@pClaseAlterna char(1),
@pTipo_Id varchar(5) = NULL,
@pFamilia_Id varchar(15) = NULL,
@pGrupo_Id varchar(15) = NULL,
@pTrabajaPorLotes Sino,
@pconVencimiento Sino,
@pSerializable Sino,
@pUsaDespachoImportacion Sino,
@pUMVenta_Id varchar(5) = NULL,
@pMonedaUltCompra varchar(3) = NULL,
@pUMCompra_Id varchar(5) = NULL,
@pCtaCompra varchar(25) = NULL,
@pCtaAjuInventario varchar(25) = NULL,
@pCtaVenta varchar(25) = NULL,
@pCtaCredito varchar(25) = NULL,
@pCtaDescuento varchar(25) = NULL,
@pCtaCosto varchar(25) = NULL,
@pCtaVentasExt varchar(25) = NULL,
@pCtaCreditoExt varchar(25) = NULL,
@pCtaDescuentoExt varchar(25) = NULL,
@pCtaCostoExt varchar(25) = NULL,
@pMargenExceso qPorcentaje,
@pTiempoEntrega smallint,
@pAcepta_Ventas Sino,
@pCFVenta_Id varchar(5) = NULL,
@pAcepta_Compras Sino,
@pCFCompra_Id varchar(5) = NULL,
@pAcepta_Comis_Vta Sino,
@pDiasGarantia smallint,
@pCodigoFiscal varchar(20) = NULL,
@pFraccionArancelaria varchar(20) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pCtaConsumo varchar(25) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkProductosPlantilla WHERE (Plantilla_Id = @pPlantilla_Id)))
BEGIN 
	UPDATE stkProductosPlantilla
	SET		@lIdentidad = stkProductosPlantilla,
		Plantilla_Id = @pPlantilla_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		MedidaAlterna = dbo.FuncFKstkUniMed(@pMedidaAlterna),
		FactorAlterna = @pFactorAlterna,
		Clase = @pClase,
		ClaseAlterna = @pClaseAlterna,
		Tipo_Id = dbo.FuncFKstkTipos(@pTipo_Id),
		Familia_Id = dbo.FuncFKstkFamilias(@pFamilia_Id),
		Grupo_Id = dbo.FuncFKstkGrupos(@pGrupo_Id),
		TrabajaPorLotes = @pTrabajaPorLotes,
		conVencimiento = @pconVencimiento,
		Serializable = @pSerializable,
		UsaDespachoImportacion = @pUsaDespachoImportacion,
		UMVenta_Id = dbo.FuncFKstkUniMed(@pUMVenta_Id),
		MonedaUltCompra = dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		UMCompra_Id = dbo.FuncFKstkUniMed(@pUMCompra_Id),
		CtaCompra = dbo.FuncFKconCuentas(@pCtaCompra),
		CtaAjuInventario = dbo.FuncFKconCuentas(@pCtaAjuInventario),
		CtaVenta = dbo.FuncFKconCuentas(@pCtaVenta),
		CtaCredito = dbo.FuncFKconCuentas(@pCtaCredito),
		CtaDescuento = dbo.FuncFKconCuentas(@pCtaDescuento),
		CtaCosto = dbo.FuncFKconCuentas(@pCtaCosto),
		CtaVentasExt = dbo.FuncFKconCuentas(@pCtaVentasExt),
		CtaCreditoExt = dbo.FuncFKconCuentas(@pCtaCreditoExt),
		CtaDescuentoExt = dbo.FuncFKconCuentas(@pCtaDescuentoExt),
		CtaCostoExt = dbo.FuncFKconCuentas(@pCtaCostoExt),
		MargenExceso = @pMargenExceso,
		TiempoEntrega = @pTiempoEntrega,
		Acepta_Ventas = @pAcepta_Ventas,
		CFVenta_Id = dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		Acepta_Compras = @pAcepta_Compras,
		CFCompra_Id = dbo.FuncFKstkCondFisCompra(@pCFCompra_Id),
		Acepta_Comis_Vta = @pAcepta_Comis_Vta,
		DiasGarantia = @pDiasGarantia,
		CodigoFiscal = @pCodigoFiscal,
		FraccionArancelaria = @pFraccionArancelaria,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		CtaConsumo = dbo.FuncFKconCuentas(@pCtaConsumo)
	WHERE (Plantilla_Id = @pPlantilla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkProductosPlantilla
	(
		Plantilla_Id,
		Empresa_Id,
		Descripcion,
		Medida_Id,
		MedidaAlterna,
		FactorAlterna,
		Clase,
		ClaseAlterna,
		Tipo_Id,
		Familia_Id,
		Grupo_Id,
		TrabajaPorLotes,
		conVencimiento,
		Serializable,
		UsaDespachoImportacion,
		UMVenta_Id,
		MonedaUltCompra,
		UMCompra_Id,
		CtaCompra,
		CtaAjuInventario,
		CtaVenta,
		CtaCredito,
		CtaDescuento,
		CtaCosto,
		CtaVentasExt,
		CtaCreditoExt,
		CtaDescuentoExt,
		CtaCostoExt,
		MargenExceso,
		TiempoEntrega,
		Acepta_Ventas,
		CFVenta_Id,
		Acepta_Compras,
		CFCompra_Id,
		Acepta_Comis_Vta,
		DiasGarantia,
		CodigoFiscal,
		FraccionArancelaria,
		Inactivo,
		Posteado,
		Usuario_Id,
		CtaConsumo
	)
	VALUES 
	(
		@pPlantilla_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		dbo.FuncFKstkUniMed(@pMedidaAlterna),
		@pFactorAlterna,
		@pClase,
		@pClaseAlterna,
		dbo.FuncFKstkTipos(@pTipo_Id),
		dbo.FuncFKstkFamilias(@pFamilia_Id),
		dbo.FuncFKstkGrupos(@pGrupo_Id),
		@pTrabajaPorLotes,
		@pconVencimiento,
		@pSerializable,
		@pUsaDespachoImportacion,
		dbo.FuncFKstkUniMed(@pUMVenta_Id),
		dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		dbo.FuncFKstkUniMed(@pUMCompra_Id),
		dbo.FuncFKconCuentas(@pCtaCompra),
		dbo.FuncFKconCuentas(@pCtaAjuInventario),
		dbo.FuncFKconCuentas(@pCtaVenta),
		dbo.FuncFKconCuentas(@pCtaCredito),
		dbo.FuncFKconCuentas(@pCtaDescuento),
		dbo.FuncFKconCuentas(@pCtaCosto),
		dbo.FuncFKconCuentas(@pCtaVentasExt),
		dbo.FuncFKconCuentas(@pCtaCreditoExt),
		dbo.FuncFKconCuentas(@pCtaDescuentoExt),
		dbo.FuncFKconCuentas(@pCtaCostoExt),
		@pMargenExceso,
		@pTiempoEntrega,
		@pAcepta_Ventas,
		dbo.FuncFKstkCondFisVenta(@pCFVenta_Id),
		@pAcepta_Compras,
		dbo.FuncFKstkCondFisCompra(@pCFCompra_Id),
		@pAcepta_Comis_Vta,
		@pDiasGarantia,
		@pCodigoFiscal,
		@pFraccionArancelaria,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		dbo.FuncFKconCuentas(@pCtaConsumo)
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkProductosPlantillaDatos
GO
CREATE PROCEDURE stkProductosPlantillaDatos
(
@pPlantilla_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT stkProductosPlantilla.stkProductosPlantilla, stkProductosPlantilla.Plantilla_Id, stkProductosPlantilla.Plantilla_Id Plantilla_Id_Nueva, stkProductosPlantilla.Empresa_Id,
	Cast( Case When stkProductosPlantilla.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, stkProductosPlantilla.Descripcion, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed,
	MedidaAlterna.Medida_Id as MedidaAlterna, MedidaAlterna.Descripcion as DescripcionMedidaAlterna, stkProductosPlantilla.FactorAlterna, stkProductosPlantilla.Clase,
	stkProductosPlantilla.ClaseAlterna, stkTipos.Tipo_Id, stkTipos.Descripcion as DescripcionTipos, stkFamilias.Familia_Id,
	stkFamilias.Descripcion as DescripcionFamilias, stkGrupos.Grupo_Id, stkGrupos.Descripcion as DescripcionGrupos, stkProductosPlantilla.TrabajaPorLotes,
	stkProductosPlantilla.conVencimiento, stkProductosPlantilla.Serializable, stkProductosPlantilla.UsaDespachoImportacion, UMVenta.Medida_Id as UMVenta_Id,
	UMVenta.Descripcion as DescripcionUMVenta, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, UMCompra.Medida_Id as UMCompra_Id,
	UMCompra.Descripcion as DescripcionUMCompra, CtaCompra.Cuenta_Id as CtaCompra, CtaCompra.Descripcion as DescripcionCtaCompra, CtaAjuInventario.Cuenta_Id as CtaAjuInventario,
	CtaAjuInventario.Descripcion as DescripcionCtaAjuInventario, CtaCostoExt.Cuenta_Id as CtaCostoExt, CtaCostoExt.Descripcion as DescripcionCtaCostoExt,
    CtaVenta.Cuenta_Id as CtaVenta,	CtaVenta.Descripcion as DescripcionCtaVenta, CtaCredito.Cuenta_Id as CtaCredito, CtaCredito.Descripcion as DescripcionCtaCredito, CtaDescuento.Cuenta_Id as CtaDescuento,
	CtaDescuento.Descripcion as DescripcionCtaDescuento, CtaCosto.Cuenta_Id as CtaCosto, CtaCosto.Descripcion as DescripcionCtaCosto, CtaVentasExt.Cuenta_Id as CtaVentasExt,
	CtaVentasExt.Descripcion as DescripcionCtaVentasExt, CtaCreditoExt.Cuenta_Id as CtaCreditoExt, CtaCreditoExt.Descripcion as DescripcionCtaCreditoExt, CtaDescuentoExt.Cuenta_Id as CtaDescuentoExt,
	CtaDescuentoExt.Descripcion as DescripcionCtaDescuentoExt, stkProductosPlantilla.MargenExceso, stkProductosPlantilla.TiempoEntrega, stkProductosPlantilla.Acepta_Ventas,
	stkCondFisVenta.CFVenta_Id, stkCondFisVenta.Descripcion as DescripcionCondFisVenta, stkProductosPlantilla.Acepta_Compras, stkCondFisCompra.CFComp_Id,
	stkCondFisCompra.Descripcion as DescripcionCondFisCompra, stkProductosPlantilla.Acepta_Comis_Vta, stkProductosPlantilla.DiasGarantia, stkProductosPlantilla.CodigoFiscal,
	stkProductosPlantilla.FraccionArancelaria, stkProductosPlantilla.Inactivo, stkProductosPlantilla.Posteado, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, CtaConsumo.Cuenta_Id as CtaConsumo, CtaConsumo.Descripcion as DescripcionCtaConsumo
FROM stkProductosPlantilla 
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkProductosPlantilla.Medida_Id)
LEFT JOIN stkUniMed MedidaAlterna ON (MedidaAlterna.stkUniMed = stkProductosPlantilla.MedidaAlterna)
LEFT JOIN stkTipos  ON (stkTipos.stkTipos = stkProductosPlantilla.Tipo_Id)
LEFT JOIN stkFamilias  ON (stkFamilias.stkFamilias = stkProductosPlantilla.Familia_Id)
LEFT JOIN stkGrupos  ON (stkGrupos.stkGrupos = stkProductosPlantilla.Grupo_Id)
LEFT JOIN stkUniMed UMVenta ON (UMVenta.stkUniMed = stkProductosPlantilla.UMVenta_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = stkProductosPlantilla.MonedaUltCompra)
LEFT JOIN stkUniMed UMCompra ON (UMCompra.stkUniMed = stkProductosPlantilla.UMCompra_Id)
LEFT JOIN conCuentas CtaCompra ON (CtaCompra.conCuentas = stkProductosPlantilla.CtaCompra)
LEFT JOIN conCuentas CtaAjuInventario ON (CtaAjuInventario.conCuentas = stkProductosPlantilla.CtaAjuInventario)
LEFT JOIN conCuentas CtaVenta ON (CtaVenta.conCuentas = stkProductosPlantilla.CtaVenta)
LEFT JOIN conCuentas CtaCredito ON (CtaCredito.conCuentas = stkProductosPlantilla.CtaCredito)
LEFT JOIN conCuentas CtaDescuento ON (CtaDescuento.conCuentas = stkProductosPlantilla.CtaDescuento)
LEFT JOIN conCuentas CtaCosto ON (CtaCosto.conCuentas = stkProductosPlantilla.CtaCosto)
LEFT JOIN conCuentas CtaVentasExt ON (CtaVentasExt.conCuentas = stkProductosPlantilla.CtaVentasExt)
LEFT JOIN conCuentas CtaCreditoExt ON (CtaCreditoExt.conCuentas = stkProductosPlantilla.CtaCreditoExt)
LEFT JOIN conCuentas CtaDescuentoExt ON (CtaDescuentoExt.conCuentas = stkProductosPlantilla.CtaDescuentoExt)
LEFT JOIN conCuentas CtaCostoExt ON (CtaCostoExt.conCuentas = stkProductosPlantilla.CtaCostoExt)
LEFT JOIN stkCondFisVenta  ON (stkCondFisVenta.stkCondFisVenta = stkProductosPlantilla.CFVenta_Id)
LEFT JOIN stkCondFisCompra  ON (stkCondFisCompra.stkCondFisCompra = stkProductosPlantilla.CFCompra_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkProductosPlantilla.Usuario_Id)
LEFT JOIN conCuentas CtaConsumo ON (CtaConsumo.conCuentas = stkProductosPlantilla.CtaConsumo)
WHERE (Plantilla_Id = @pPlantilla_Id)
 


  Declare @pidentity bigint= dbo.FuncFKstkProductosPlantilla(@pPlantilla_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkProductosPlantilla'
 RETURN @@Error 

GO

DROP PROCEDURE stkProductosPlantillaEliminar
GO
CREATE PROCEDURE stkProductosPlantillaEliminar
(
@pPlantilla_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductosPlantilla 
WHERE (Plantilla_Id = @pPlantilla_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkProductosPlantilla
GO

CREATE FUNCTION FuncFKstkProductosPlantilla
(
@pPlantilla_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkProductosPlantilla FROM stkProductosPlantilla WHERE 
	Plantilla_Id = @pPlantilla_Id
  RETURN @pIdentity
END


GO
