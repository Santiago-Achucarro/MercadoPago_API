DROP PROCEDURE stkInventDespachoInsertar
GO
CREATE PROCEDURE stkInventDespachoInsertar
(
@pstkInventarios int,
@pProducto_Id VarChar(25),
@pDespacho_Id varchar(20),
@pCantidad qCantidadD8
)
AS

INSERT INTO stkInventDespacho
(
	stkInventarios,
	Producto_Id,
	Despacho_Id,
	Cantidad
)
VALUES 
(
	@pstkInventarios,
	dbo.FuncFKstkProductos(@pProducto_Id),
	dbo.FuncFKcomDespachos(@pDespacho_Id),
	@pCantidad
)


GO

DROP PROCEDURE stkInventDespachoDatos
GO
CREATE PROCEDURE stkInventDespachoDatos
(
@pstkInventarios int
)
AS
SET NOCOUNT ON 

SELECT stkInventDespacho.stkInventarios, stkProductos.Producto_Id, comDespachos.Despacho_Id, stkInventDespacho.Cantidad
FROM stkInventDespacho
Inner Join stkProductos On stkProductos.stkProductos = stkInventDespacho.Producto_Id
INNER JOIN comDespachos ON (comDespachos.comDespachos = stkInventDespacho.Despacho_Id)
WHERE stkInventDespacho.stkInventarios = @pstkInventarios
 
RETURN @@Error 

GO

DROP PROCEDURE stkInventDespachoEliminar
GO
CREATE PROCEDURE stkInventDespachoEliminar
(
@pstkInventarios int,
@pProducto_Id VarChar(25) = Null,
@pDespacho_Id varchar(20) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM stkInventDespacho 
WHERE (stkInventarios = @pstkInventarios)
AND Producto_Id = isNull(dbo.FuncFKstkProductos(@pProducto_Id), Producto_Id)
AND Despacho_Id = isNull(dbo.FuncFKcomDespachos(@pDespacho_Id), Despacho_Id)
 
RETURN @@Error 

GO
