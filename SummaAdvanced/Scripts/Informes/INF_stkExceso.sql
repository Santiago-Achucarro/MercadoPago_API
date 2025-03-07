-- INF_stkExceso ' ','ZZZ',' ','ZZZZ', 1
DROP PROCEDURE INF_stkExceso
GO
CREATE PROCEDURE INF_stkExceso
(
	@DepositoDesde VarChar(5),
	@DepositoHasta VarChar(5),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa Int
)
AS

SELECT stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepo, 
	stkProductos.Producto_Id, stkProductos.Descripcion AS DescripcionProducto, 
	ISNULL(stkExistencia.Cantidad,0) as Stock, stkMaxMin.Maximo, 
	ISNULL(stkExistencia.Cantidad,0) - stkMaxMin.Maximo as Exceso
FROM stkProductos inner join stkMaxMin ON
stkProductos.stkProductos = stkMaxMin.Producto_Id and 
stkMaxMin.Empresa_Id = @Empresa
inner join stkDepositos ON
stkDepositos.stkDepositos = stkMaxMin.Deposito_Id
left join stkExistencia ON
stkExistencia.Producto_Id = stkProductos.stkProductos and
stkExistencia.Deposito_Id = stkDepositos.stkDepositos and 
stkExistencia.Empresa_Id = @Empresa
WHERE
	ISNULL(stkProductos.Empresa_Id , @Empresa) = @Empresa and
	stkProductos.Producto_Id between @ProductoDesde And @ProductoHasta AND
	stkDepositos.Deposito_Id between @DepositoDesde And @DepositoHasta and 
	stkProductos.Inactivo = 0 and 
	stkProductos.Posteado = 1 AND 
	stkDepositos.Inactivo = 0 and 
	stkDepositos.Posteado = 1 and 
	stkMaxMin.Maximo < ISNULL(stkExistencia.Cantidad,0)
ORDER BY 1, 3