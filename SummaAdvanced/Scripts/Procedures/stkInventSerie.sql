--Exec stkInventSerieDatos 6

DROP PROCEDURE stkInventSerieGuardar
GO
CREATE PROCEDURE stkInventSerieGuardar
(
@pstkInventarios int,
@pProducto_Id VarChar(25),
@pSerie varchar(25),
@pCantidad qCantidadD8
)
AS

INSERT INTO stkInventSerie
(
	stkInventarios,
	Producto_Id,
	Serie,
	Cantidad
)
VALUES 
(
	@pstkInventarios,
	dbo.FuncFKstkProductos(@pProducto_Id),
	@pSerie,
	@pCantidad
)


GO

DROP PROCEDURE stkInventSerieDatos
GO
CREATE PROCEDURE stkInventSerieDatos
(
@pstkInventarios int
)
AS
SET NOCOUNT ON 

SELECT stkInventSerie.stkInventarios, stkProductos.Producto_Id, stkInventSerie.Serie, stkInventSerie.Cantidad
FROM stkInventSerie
Inner Join stkProductos On stkProductos.stkProductos = stkInventSerie.Producto_Id
WHERE stkInventarios = @pstkInventarios
 
RETURN @@Error 

GO

DROP PROCEDURE stkInventSerieEliminar
GO
CREATE PROCEDURE stkInventSerieEliminar
(
@pstkInventarios int,
@pProducto_Id VarChar(25) = Null,
@pSerie varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkInventSerie 
WHERE (stkInventarios = @pstkInventarios)
AND Producto_Id = isNull(dbo.FuncFKstkProductos(@pProducto_Id), Producto_Id)
AND (Serie = ISNULL(@pSerie, Serie))
 
RETURN @@Error 

GO
