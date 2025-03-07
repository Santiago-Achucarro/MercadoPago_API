-- INF_StockxAlmacen ' ','zzz',1
Drop Procedure INF_StockxAlmacen
GO
CREATE Procedure INF_StockxAlmacen
(
	@DepositoDesde VarChar(15),
	@DepositoHasta VarChar(15), 
	@Empresa int
)

AS

SELECT stkProductos.Producto_id, stkProductos.Descripcion, 
	stkDepositos.Deposito_id, stkDepositos.Descripcion as DescripcionDeposito,
	SUM(stkExistencia.Cantidad) as Cantidad, stkUniMed.Medida_Id, ISNULL(stkUbiAlmacenDefecto.Ubicacion_Id,'') Ubicacion_Id
From stkProductos inner join stkExistencia ON
stkProductos.stkProductos = stkExistencia.Producto_Id
inner join stkDepositos ON
stkDepositos.stkDepositos = stkExistencia.Deposito_Id
inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
LEFT JOIN stkUbiAlmacenDefecto on stkUbiAlmacenDefecto.Producto_Id = stkProductos.stkProductos AND 
			stkUbiAlmacenDefecto.Deposito_Id = stkDepositos.stkDepositos
WHERE
stkDepositos.Deposito_id between @DepositoDesde and @DepositoHasta AND 
stkExistencia.Cantidad <> 0 and 
stkExistencia.Empresa_id = @Empresa
GROUP BY stkProductos.Producto_id, stkProductos.Descripcion, 
stkDepositos.Deposito_id, stkDepositos.Descripcion , stkUbiAlmacenDefecto.Ubicacion_Id, 
stkUniMed.Medida_Id
ORDER BY 3,1

GO



