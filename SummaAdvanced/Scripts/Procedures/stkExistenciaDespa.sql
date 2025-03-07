DROP PROCEDURE stkExistenciaDespaSumar
GO
CREATE PROCEDURE stkExistenciaDespaSumar
(
@pProducto_Id varChar(25),
@pDeposito_Id varChar(15),
@pDespacho_Id varChar(20),
@pCantidad qCantidadD8,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkExistenciaDespa 
	WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND 
	Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id) AND Empresa_Id = @pEmpresa_Id))
BEGIN 
	UPDATE stkExistenciaDespa
	SET	 Cantidad = Cantidad + @pCantidad,
		Empresa_Id = @pEmpresa_Id
	WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND 
	Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id) AND 
	Empresa_Id = @pEmpresa_Id
END 
ELSE 
BEGIN 
	INSERT INTO stkExistenciaDespa
	(
		Producto_Id,
		Deposito_Id,
		Despacho_Id,
		Cantidad,
		Empresa_Id
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		dbo.FuncFKcomDespachos(@pDespacho_Id),
		@pCantidad,
		@pEmpresa_Id
	)
END 

GO

DROP PROCEDURE stkExistenciaDespaDatos
GO
CREATE PROCEDURE stkExistenciaDespaDatos
(
@pProducto_Id varChar(25),
@pDeposito_Id varChar(15),
@pDespacho_Id varChar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, comDespachos.Despacho_Id,
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	stkExistenciaDespa.Cantidad, stkExistenciaDespa.Empresa_Id
FROM stkExistenciaDespa 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkExistenciaDespa.Producto_Id)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkExistenciaDespa.Deposito_Id)
INNER JOIN comDespachos  ON (comDespachos.comDespachos = stkExistenciaDespa.Despacho_Id)
WHERE stkExistenciaDespa.Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND stkExistenciaDespa.Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
AND stkExistenciaDespa.Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id)
AND stkExistenciaDespa.Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO

DROP PROCEDURE stkExistenciaDespaEliminar
GO
CREATE PROCEDURE stkExistenciaDespaEliminar
(
@pProducto_Id varchar(25),
@pDeposito_Id varchar(15),
@pDespacho_Id int,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM stkExistenciaDespa 
WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
AND Despacho_Id = dbo.FuncFKcomDespachos(@pDespacho_Id)
AND Empresa_Id = @pEmpresa_Id
 
 RETURN @@Error 

GO

GO
