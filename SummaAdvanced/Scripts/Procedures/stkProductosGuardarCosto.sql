DROP PROCEDURE stkProductosGuardarCosto
GO
CREATE PROCEDURE stkProductosGuardarCosto(
	@Producto_Id VarChar(25),
	@CostoPromPond Numeric(18,4),
	@CostoUltCompra Numeric(18,4),
	@PrecioUltCompra Numeric(18,4),
	@MonedaUltCompra VarChar(5)
)
as

Update stkProductos set CostoPromPond = @CostoPromPond, CostoUltCompra = @CostoUltCompra, 
	PrecioUltCompra = @PrecioUltCompra, MonedaUltCompra = dbo.FuncFKgenMonedas(@MonedaUltCompra)
	WHERE 
		Producto_Id = @Producto_Id
GO