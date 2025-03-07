
---proExistencia 'MP-54-200NG', '00002', 1

DROP PROCEDURE proExistencia
GO
CREATE PROCEDURE proExistencia(
	@Producto_Id VarChar(25),
	@Deposito_Id VarChar(5),
	@Empresa_Id Int
	)
as

SELECT stkProductos.Producto_Id, stkDepositos.Deposito_Id, @Empresa_Id as Empresa_Id, 
ISNULL((SELECT SUM(Cantidad) from stkExistencia WHERE
		stkExistencia.Producto_Id = stkProductos.stkProductos and 
		stkExistencia.Deposito_Id = stkDepositos.stkDepositos and
		stkExistencia.Empresa_Id = @Empresa_Id),0) as Existencia, 
Convert(Numeric(18,4), ISNULL((SELECT SUM(proOrdenProd.Cantidad * (proOrden.Cantidad-proOrden.CantidadTerminada)/ proOrden.Cantidad *
	Case WHEN proOrdenProd.EntradaSalida = 'P' THEN 1 ELSE -1 END) 
	from proOrdenProd, proOrden, proOrdenSegmento 
		WHERE
		proOrden.proOrden = proOrdenProd.proOrden AND 
		proOrdenSegmento.proOrden = proOrden.proOrden and 
		proOrdenSegmento.Empresa_Id = @Empresa_Id and
		proOrdenProd.Producto_Id = stkProductos.stkProductos and 
		proOrdenProd.Deposito_Id = stkDepositos.stkDepositos and
		proOrden.Cantidad > proOrden.CantidadTerminada AND 
		proOrden.Anulado = 0 and 
		proOrden.FechaFin IS NULL ) ,0)) as Produccion
from stkProductos CROSS JOIN stkDepositos
where	
stkProductos.Producto_Id = @Producto_Id and 
stkDepositos.Deposito_Id = @Deposito_Id
