DROP PROCEDURE stkInventCuerpoInsertar
GO
CREATE PROCEDURE stkInventCuerpoInsertar
(
@pstkInventarios int,
@pProducto_Id VarChar(25),
@pCantidad numeric(15,8),
@pCantidadAlterna numeric(15,8)
)
AS
	INSERT INTO stkInventCuerpo
	(
		stkInventarios,
		Producto_Id,
		Cantidad,
		CantidadAlterna
	)
	VALUES 
	(
		@pstkInventarios,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pCantidad,
		@pCantidadAlterna
	)

GO

DROP PROCEDURE stkInventCuerpoEliminar
GO
CREATE PROCEDURE stkInventCuerpoEliminar
(
@pstkInventarios int,
@pProducto_Id VarChar(25) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM stkInventCuerpo 
WHERE (stkInventarios = @pstkInventarios)
AND (@pProducto_Id IS NULL OR Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
 
 RETURN @@Error 

GO

GO
