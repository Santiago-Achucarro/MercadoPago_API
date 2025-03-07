-- Inf_stkEnsambles ' ','zzz',1
DROP PROCEDURE Inf_stkEnsambles
GO
CREATE PROCEDURE Inf_stkEnsambles(
	@EnsambleDesde VarChar(25),
	@EnsambleHasta VarChar(25),
	@Empresa_Id Int
)
AS
SELECT Ensables.Producto_Id Ensamble , Ensables.Descripcion as DescripcionEnsamble,
stkProductos.Producto_Id, stkProductos.Descripcion, stkProductosCombo.Cantidad, 
	isnull(stkProductosCostos.CostoUltCompra, stkProductos.CostoUltCompra) as CostoUltCompra, 
	isnull(stkProductosCostos.CostoPromPond, stkProductos.CostoPromPond) as CostoReposicion
FROM stkProductos as Ensables 
INNER JOIN stkProductosCombo ON stkProductosCombo.Combo_Id = Ensables.stkProductos
INNER JOIN stkProductos ON  stkProductosCombo.Producto_Id = stkProductos.stkProductos
LEFT JOIN stkProductosCostos ON stkProductosCostos.Producto_Id =stkProductos.stkProductos
WHERE
	Ensables.Producto_Id Between @EnsambleDesde and @EnsambleHasta and 
	@Empresa_Id = ISNULL(Ensables.Empresa_Id,@Empresa_Id)
order by 1,3
GO


