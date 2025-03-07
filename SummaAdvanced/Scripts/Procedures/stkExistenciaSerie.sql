
DROP PROCEDURE stkExistenciaSerieDatos
GO
CREATE PROCEDURE stkExistenciaSerieDatos
(
@pProducto_Id varChar(25),
@pDeposito_Id varChar(15),
@pSerie varchar(25),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	stkExistenciaSerie.Serie, stkExistenciaSerie.Cantidad, stkExistenciaSerie.Empresa_Id
FROM stkExistenciaSerie 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkExistenciaSerie.Producto_Id)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkExistenciaSerie.Deposito_Id)
WHERE stkExistenciaSerie.Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND stkExistenciaSerie.Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
AND Serie = @pSerie
AND stkExistenciaSerie.Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO

DROP PROCEDURE stkExistenciaSerieEliminar
GO
CREATE PROCEDURE stkExistenciaSerieEliminar
(
@pProducto_Id varchar(25),
@pDeposito_Id varchar(15),
@pSerie varchar(25) = NULL,
@pEmpresa_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkExistenciaSerie 
WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
AND Serie = ISNULL(@pSerie, Serie)
AND Empresa_Id = ISNULL(@pEmpresa_Id, Empresa_Id)
 
 RETURN @@Error 

GO


DROP PROCEDURE stkExistenciaSerieSumar
GO
CREATE PROCEDURE stkExistenciaSerieSumar
(
@pProducto_Id varChar(25),
@pDeposito_Id varChar(15),
@pSerie varchar(25),
@pCantidad qMonedaD8,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkExistenciaSerie 
	WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND 
	Serie = @pSerie AND 
	Empresa_Id = @pEmpresa_Id))
BEGIN 
	UPDATE stkExistenciaSerie
	SET Cantidad = Cantidad + @pCantidad
	WHERE Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND 
	Serie = @pSerie AND Empresa_Id = @pEmpresa_Id
END 
ELSE 
BEGIN 
	INSERT INTO stkExistenciaSerie
	(
		Producto_Id,
		Deposito_Id,
		Serie,
		Cantidad,
		Empresa_Id
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pSerie,
		@pCantidad,
		@pEmpresa_Id
	)
END 

GO
