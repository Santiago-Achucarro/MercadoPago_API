DROP PROCEDURE stkSerieVencimientoGuardar
GO
CREATE PROCEDURE stkSerieVencimientoGuardar
(
@pProducto_Id varChar(25),
@pSerie varchar(25),
@pVencimiento qFecha,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkSerieVencimiento 
	WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND Serie = @pSerie AND Empresa_Id = @pEmpresa_Id))
BEGIN 
	UPDATE stkSerieVencimiento
	SET		Vencimiento = @pVencimiento,
		Empresa_Id = @pEmpresa_Id
	WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND Serie = @pSerie AND Empresa_Id = @pEmpresa_Id
END 
ELSE 
BEGIN 
	INSERT INTO stkSerieVencimiento
	(
		Producto_Id,
		Serie,
		Vencimiento,
		Empresa_Id
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pSerie,
		@pVencimiento,
		@pEmpresa_Id
	)
END 

GO

DROP PROCEDURE stkSerieVencimientoDatos
GO
CREATE PROCEDURE stkSerieVencimientoDatos
(
@pProducto_Id varChar(25),
@pSerie varchar(25),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkSerieVencimiento.Serie, stkSerieVencimiento.Vencimiento,
	stkSerieVencimiento.Empresa_Id
FROM stkSerieVencimiento 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkSerieVencimiento.Producto_Id)
WHERE stkSerieVencimiento.Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND Serie = @pSerie
AND stkSerieVencimiento.Empresa_Id = @pEmpresa_Id
 
 RETURN @@Error 

GO

DROP PROCEDURE stkSerieVencimientoEliminar
GO
CREATE PROCEDURE stkSerieVencimientoEliminar
(
@pProducto_Id varchar(25),
@pSerie varchar(25),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM stkSerieVencimiento 
WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND Serie = @pSerie
AND Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO
