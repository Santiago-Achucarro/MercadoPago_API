DROP Procedure stkCataProductosDatos
GO
Create Procedure stkCataProductosDatos
(
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@Empresa_Id Int
)
AS

select	@ProductoDesde as ProductoDesde, @ProductoHasta ProductoHasta,
	@FamiliaDesde FamiliaDesde, @FamiliaHasta FamiliaHasta,
	@GrupoDesde GrupoDesde, @GrupoHasta GrupoHasta


Select Producto_Id,	Descripcion,	Clase,	Description,	DescripcionDetallada,	Tipo_Id,	
CodigoBarra,	CtaCompra,	CtaAjuInventario,	Familia_Id,	Grupo_Id,	Medida_Id,	Acepta_Compras AceptaCompras,	
Acepta_Ventas AceptaVentas,	Cast(case when Empresa_Id is null then 1 else 0 end as bit) PTodasEmpresas,	
Inactivo,	Posteado,	ClaseAlterna,	UsaDespachoImportacion,	
Serializable,	TrabajaPorLotes,	conVencimiento,	MedidaAlterna,	FactorAlterna,	CostoUltCompra CostoUltimaCompra,	
CostoPromPond,	CostoReposicion,	PrecioUltCompra,	MonedaUltCompra,	MargenExceso,	
TiempoEntrega,	CFComp_Id,	UMCompra,	CtaVenta,	CtaVentaExt,	CtaCredito,	CtaCreditoExt,	
CtaDescuento,	CtaDescuentoExt,	CtaCosto,	CtaCostoExt,	UmVenta,	DiasGarantia,	
Acepta_Comis_Vta,	CFVenta_Id,	CodigoFiscal,	FraccionArancelaria,	Fcha_Ult_Compra FechaUltCompra, 
MaterialPeligroso, CveMaterialPeligroso, 
PesoEnKg, ClaveSTCC
from vstkproductos 

Where 
	isnull(Familia_Id, ' ') Between @FamiliaDesde and @FamiliaHasta and 
	isnull(Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and 
	Producto_Id Between @ProductoDesde And @ProductoHasta and 
	ISNULL(Empresa_Id ,@Empresa_Id) = @Empresa_Id
order by 1

SELECT stkProductos.Producto_Id,	stkUniMed.Medida_Id,	
	stkArtiUM.Factor,	stkArtiUM.CodigoBarra CodigoBarras
FROM stkArtiUM 
INNER JOIN stkProductos ON stkArtiUM.Producto_Id = stkProductos.stkProductos
INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkArtiUM.Medida_Id
left JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
left JOIN stkGrupos ON  stkGrupos.stkGrupos = stkProductos.Grupo_Id
Where 
	ISNULL(stkFamilias.Familia_Id,' ')  Between @FamiliaDesde and @FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and 
	stkProductos.Producto_Id Between @ProductoDesde And @ProductoHasta and 
	ISNULL(stkProductos.Empresa_Id ,@Empresa_Id) = @Empresa_Id

order by 1,2

select COMBO.Producto_Id, stkProductos.Producto_Id Producto_Componente,	stkproductosCombo.Cantidad
from stkproductosCombo 
	INNER JOIN stkproductos COMBO ON  COMBO.stkproductos =stkproductosCombo.Combo_id
	INNER JOIN stkproductos ON  stkproductos.stkproductos =stkproductosCombo.Producto_Id
	left JOIN stkFamilias ON  stkFamilias.stkFamilias = COMBO.Familia_Id
	left JOIN stkGrupos ON  stkGrupos.stkGrupos = COMBO.Grupo_Id
WHERE
	ISNULL(stkFamilias.Familia_Id,' ')  Between @FamiliaDesde and @FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and 
	COMBO.Producto_Id Between @ProductoDesde And @ProductoHasta and 
	ISNULL(COMBO.Empresa_Id ,@Empresa_Id) = @Empresa_Id
order by 1,2


GO

