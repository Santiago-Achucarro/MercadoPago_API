-- inf_stkProductos ' ','zzz',1
DROP PROCEDURE inf_stkProductos
GO

CREATE PROCEDURE inf_stkProductos

(
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@Empresa_Id Int
)

as
select stkProductos,Producto_Id,Empresa_Id,Descripcion,DescripcionDetallada,Description,Medida_Id,MedidaAlterna,FactorAlterna,Clase,ClaseAlterna,
CodigoBarra,Tipo_Id,Familia_Id,Grupo_Id,
TrabajaPorLotes,conVencimiento,Serializable,UsaDespachoImportacion,UmVenta,CostoPromPond,CostoUltCompra,CostoStandard,CostoReposicion,CostoUltimoCierre,
MonedaUltCompra,PrecioUltCompra,UMCompra,CtaCompra,CtaAjuInventario,CtaVenta,CtaCredito,CtaDescuento,CtaCosto,CtaVentaExt,CtaCreditoExt,CtaDescuentoExt,
CtaCostoExt,Fcha_Ult_Compra,MargenExceso,TiempoEntrega,Acepta_Ventas,CFVenta_Id,Acepta_Compras,CFComp_Id,Acepta_Comis_Vta,
DiasGarantia,FechaUltModif,Inactivo,Posteado,CtaConsumo ,Usuario_Id,CodigoFiscal,FraccionArancelaria
from vstkProductos
where Producto_Id between @ProductoDesde and @ProductoHasta and
	isnull(Empresa_Id,@Empresa_Id) = @Empresa_Id and 
	isnull(Familia_Id,'') Between @FamiliaDesde and @FamiliaHasta and 
	isnull(Grupo_Id,'') Between @GrupoDesde and @GrupoHasta
GO





