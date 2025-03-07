DROP PROCEDURE espProductosColorTalleTestGuardar
GO
CREATE PROCEDURE espProductosColorTalleTestGuardar
(
@pProducto_Id varchar(25),
@pColor_Id varchar(15),
@pTalle_Id varchar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espProductosColorTalleTest WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)))) 
BEGIN 
	UPDATE espProductosColorTalleTest
	SET		Color_Id = dbo.FuncFKespstkColorTest(@pColor_Id),
		Talle_Id = dbo.FuncFKespstkTalleTest(@pTalle_Id)
	WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
END 
ELSE 
BEGIN 
	INSERT INTO espProductosColorTalleTest
	(
		Producto_Id,
		Color_Id,
		Talle_Id
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKespstkColorTest(@pColor_Id),
		dbo.FuncFKespstkTalleTest(@pTalle_Id)
	)
END 

GO

DROP PROCEDURE espProductosColorTalleTestDatos
GO
CREATE PROCEDURE espProductosColorTalleTestDatos
(
@pProducto_Id VARCHAR (25)
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, espstkColorTest.Color_Id, espstkColorTest.Descripcion as DescripcionstkColorTest,
	espstkTalleTest.Talle_Id, espstkTalleTest.Descripcion as DescripcionstkTalleTest
FROM espProductosColorTalleTest 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = espProductosColorTalleTest.Producto_Id)
INNER JOIN espstkColorTest  ON (espstkColorTest.espstkColorTest = espProductosColorTalleTest.Color_Id)
INNER JOIN espstkTalleTest  ON (espstkTalleTest.espstkTalleTest = espProductosColorTalleTest.Talle_Id)
WHERE (stkProductos.Producto_Id = @pProducto_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE espProductosColorTalleTestEliminar
GO
CREATE PROCEDURE espProductosColorTalleTestEliminar
(
@pProducto_Id varchar(25)
)
AS
SET NOCOUNT ON 

DELETE FROM espProductosColorTalleTest 
WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
 
 RETURN @@Error 

GO

GO
