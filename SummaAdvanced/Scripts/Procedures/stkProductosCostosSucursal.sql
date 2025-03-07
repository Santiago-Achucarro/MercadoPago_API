DROP PROCEDURE stkProductosCostosSucursalGuardar
GO
CREATE PROCEDURE stkProductosCostosSucursalGuardar
(
@pSucursal VarChar(4),
@pProducto_Id VarChar(25),
@pEmpresa_Id int,
@pMonedaUltCompra VarChar(5)=null,
@pCostoPromPond qMonedaD8,
@pCostoUltCompra qMonedaD8,
@pCostoStandard qMonedaD8,
@pPrecioUltCompra qMonedaD8,
@pFecha_Ult_Compra qFechaHora,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkProductosCostosSucursal WHERE 
	(Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)) AND 
	(Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND 
	(Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE stkProductosCostosSucursal
	SET		Empresa_Id = @pEmpresa_Id,
		MonedaUltCompra = dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		CostoPromPond = @pCostoPromPond,
		CostoUltCompra = @pCostoUltCompra,
		CostoStandard = @pCostoStandard,
		FechaUltModif = dbo.FechaActual(),
		PrecioUltCompra = @pPrecioUltCompra,
		Fecha_Ult_Compra = @pFecha_Ult_Compra,
		Usuario_Id = @pUsuario_Id
	WHERE (Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)) AND 
		(Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND 
		(Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkProductosCostosSucursal
	(
		Sucursal,
		Producto_Id,
		Empresa_Id,
		MonedaUltCompra,
		CostoPromPond,
		CostoUltCompra,
		CostoStandard,
		FechaUltModif,
		PrecioUltCompra,
		Fecha_Ult_Compra,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pEmpresa_Id,
		dbo.FuncFKgenMonedas(@pMonedaUltCompra),
		@pCostoPromPond,
		@pCostoUltCompra,
		@pCostoStandard,
		dbo.FechaActual(),
		@pPrecioUltCompra,
		@pFecha_Ult_Compra,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE stkProductosCostosSucursalDatos
GO
CREATE PROCEDURE stkProductosCostosSucursalDatos
(
@pSucursal VarChar(4),
@pProducto_Id VarChar(25),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
	stkProductosCostosSucursal.Empresa_Id, genMonedas.Moneda_Id, stkProductosCostosSucursal.CostoPromPond, stkProductosCostosSucursal.CostoUltCompra,
	stkProductosCostosSucursal.CostoStandard, stkProductosCostosSucursal.FechaUltModif, stkProductosCostosSucursal.PrecioUltCompra, stkProductosCostosSucursal.Fecha_Ult_Compra,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM stkProductosCostosSucursal 
INNER JOIN genSucursalesEmpr  ON (genSucursalesEmpr.genSucursalesEmpr = stkProductosCostosSucursal.Sucursal)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkProductosCostosSucursal.Producto_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkProductosCostosSucursal.Usuario_Id)
LEFT JOIN genMonedas ON genMonedas.genMonedas = stkProductosCostosSucursal.MonedaUltCompra
WHERE (genSucursalesEmpr.Sucursal = @pSucursal)
AND (stkProductos.Producto_Id = @pProducto_Id)
AND (stkProductosCostosSucursal.Empresa_Id = @pEmpresa_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkProductosCostosSucursalEliminar
GO
CREATE PROCEDURE stkProductosCostosSucursalEliminar
(
@pSucursal Sucursal,
@pProducto_Id varchar(25),
@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductosCostosSucursal 
WHERE (Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal))
AND (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
AND (Empresa_Id = @pEmpresa_Id)
 
 RETURN @@Error 

GO


