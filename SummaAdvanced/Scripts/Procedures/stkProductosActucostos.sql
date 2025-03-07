-- Este metodo se usa para acutalizar el costo de forma provisoria hasta el cierre unicamente
DROP PROCEDURE stkProductosActucostos
GO
CREATE PROCEDURE stkProductosActucostos (
	@Producto_id VarChar(25), 
	@Cantidad  Numeric(19,8), 
	@Costo Numeric(19,8), 
	@CostoOriginal Numeric(19,8), 
	@Moneda_Id VarChar(3)
)	
AS

Declare @Costoactual Numeric(19,8) 
Declare @CantidadActual Numeric(19,8) 
 
SELECT @CostoActual = IsNull(SUM(stkExistencia.Cantidad*stkProductos.CostoPromPond), 0),
	@CantidadActual = IsNull(SUM(stkExistencia.Cantidad), 0)
From stkProductos
left join (stkExistencia INNER JOIN stkDepositos ON 
	stkDepositos.stkDepositos = stkExistencia.Deposito_Id and 
		stkDepositos.consCompra_Venta <> 1 ) ON 
		stkProductos.stkProductos = stkExistencia.Producto_Id
Where
	stkProductos.Producto_id = @Producto_id 
	

UPDATE stkProductos set CostoPromPond = (@CostoActual +@Cantidad*@CostoOriginal) /(@CantidadActual+@Cantidad), 
		CostoUltCompra = @Costo, PrecioUltCompra = @CostoOriginal, 
		MonedaUltCompra = dbo.FuncFkgenMonedas(@Moneda_Id)
		Where
		stkProductos.Producto_Id = @Producto_id 

SELECT @CostoActual/(@CantidadActual+@Cantidad) AS PPP
GO

