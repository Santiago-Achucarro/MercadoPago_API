DROP PROCEDURE stkProductosCostoCierreSucursalGuardar
GO
CREATE PROCEDURE stkProductosCostoCierreSucursalGuardar
(
@pEmpresa_Id int,
@pFecha qFecha,
@pSucursal VarChar(4),
@pProducto_Id VarChar(25),
@pCosto qMonedaD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkProductosCostoCierreSucursal WHERE 
	(Empresa_Id = @pEmpresa_Id) AND (Fecha = @pFecha) AND 
	(Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)) AND 
	(Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))))
BEGIN 
	UPDATE stkProductosCostoCierreSucursal
	SET		Empresa_Id = @pEmpresa_Id,
		Costo = @pCosto
	WHERE (Empresa_Id = @pEmpresa_Id) AND (Fecha = @pFecha) AND 
		(Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal)) AND 
		(Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
END 
ELSE 
BEGIN 
	INSERT INTO stkProductosCostoCierreSucursal
	(
		Empresa_Id,
		Fecha,
		Sucursal,
		Producto_Id,
		Costo
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pFecha,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pCosto
	)
END 

GO

DROP PROCEDURE stkProductosCostoCierreSucursalDatos
GO
CREATE PROCEDURE stkProductosCostoCierreSucursalDatos
(
@pEmpresa_Id int,
@pFecha qFecha,
@pSucursal VarChar(4),
@pProducto_Id VarChar(25)
)
AS
SET NOCOUNT ON 

SELECT stkProductosCostoCierreSucursal.Empresa_Id, 
	stkProductosCostoCierreSucursal.Fecha, genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr,
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, 
	stkProductosCostoCierreSucursal.Costo
FROM stkProductosCostoCierreSucursal 
INNER JOIN genSucursalesEmpr  ON (genSucursalesEmpr.genSucursalesEmpr = stkProductosCostoCierreSucursal.Sucursal)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkProductosCostoCierreSucursal.Producto_Id)
WHERE (stkProductosCostoCierreSucursal.Empresa_Id = @pEmpresa_Id)
AND (stkProductosCostoCierreSucursal.Fecha = @pFecha)
AND (genSucursalesEmpr.Sucursal = @pSucursal)
AND (stkproductos.Producto_Id = @pProducto_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE stkProductosCostoCierreSucursalEliminar
GO
CREATE PROCEDURE stkProductosCostoCierreSucursalEliminar
(
@pEmpresa_Id int,
@pFecha qFecha,
@pSucursal VarChar(4),
@pProducto_Id VarChar(25)
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductosCostoCierreSucursal 
WHERE (Empresa_Id = @pEmpresa_Id)
AND (Fecha = ISNULL(@pFecha, Fecha))
AND (Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal))
AND (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
 
 RETURN @@Error 

GO

GO
