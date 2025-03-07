DROP PROCEDURE stkProductosCostosGuardar
GO
CREATE PROCEDURE stkProductosCostosGuardar
(
@pProducto_Id VarChar(25),
@pEmpresa_Id int,
@pCostoPromPond numeric(19,8),
@pCostoUltCompra numeric(19,8),
@pCostoStandard numeric(19,8),
@pUsuario_Id int,
@pMonedaUltCompra varchar(3),
@pPrecioUltCompra numeric(19,8),
@pFecha_Ult_Compra datetime
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkProductosCostos WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) 
		AND (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE stkProductosCostos
	SET	Empresa_Id = @pEmpresa_Id,
		CostoPromPond = @pCostoPromPond,
		CostoUltCompra = @pCostoUltCompra,
		CostoStandard = @pCostoStandard,
		Usuario_Id = @pUsuario_Id,
		FechaUltModif = GETDATE(),
		MonedaUltCompra = dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		PrecioUltCompra = @pPrecioUltCompra,
		Fecha_Ult_Compra = @pFecha_Ult_Compra
	WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkProductosCostos
	(
		Producto_Id,
		Empresa_Id,
		CostoPromPond,
		CostoUltCompra,
		CostoStandard,
		Usuario_Id,
		FechaUltModif,
		MonedaUltCompra,
		PrecioUltCompra,
		Fecha_Ult_Compra
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pEmpresa_Id,
		@pCostoPromPond,
		@pCostoUltCompra,
		@pCostoStandard,
		@pUsuario_Id,
		GETDATE(),
		dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		@pPrecioUltCompra,
		@pFecha_Ult_Compra
	)
END 

GO

DROP PROCEDURE stkProductosCostosDatos
GO
CREATE PROCEDURE stkProductosCostosDatos
(
@pProducto_Id VarChar(25),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, stkProductosCostos.Empresa_Id, stkProductosCostos.CostoPromPond,
	stkProductosCostos.CostoUltCompra, stkProductosCostos.CostoStandard, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	stkProductosCostos.FechaUltModif, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, stkProductosCostos.PrecioUltCompra,
	stkProductosCostos.Fecha_Ult_Compra
FROM stkProductosCostos 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkProductosCostos.Producto_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkProductosCostos.Usuario_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = stkProductosCostos.MonedaUltCompra)
WHERE (stkProductos.Producto_Id = @pProducto_Id)
AND (stkProductosCostos.Empresa_Id = @pEmpresa_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkProductosCostosEliminar
GO
CREATE PROCEDURE stkProductosCostosEliminar
(
@pProducto_Id varchar(25),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductosCostos 
WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
AND (Empresa_Id = @pEmpresa_Id)
 
RETURN @@Error 

GO

GO
