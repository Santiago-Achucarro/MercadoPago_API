DROP PROCEDURE stkProductosComboInsertar
GO
CREATE PROCEDURE stkProductosComboInsertar
(
@pCombo_Id varchar(25),
@pProducto_Id varchar(25),
@pCantidad qCantidadD8
)
AS
BEGIN 
	INSERT INTO stkProductosCombo
	(
		Combo_Id,
		Producto_Id,
		Cantidad
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pCombo_Id),
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pCantidad
	)
END 

GO

DROP PROCEDURE stkProductosComboDatos
GO
CREATE PROCEDURE stkProductosComboDatos
(
@pCombo_Id varchar(25),
@pProducto_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id as Combo_Id, stkProductos2.Producto_Id, stkProductos2.Descripcion as DescripcionProducto,
	stkProductosCombo.Cantidad
FROM stkProductosCombo 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkProductosCombo.Combo_Id)
INNER JOIN stkProductos stkProductos2 ON (stkProductos2.stkProductos = stkProductosCombo.Producto_Id)
WHERE (stkProductos.Producto_Id = @pCombo_Id)
AND (stkProductos2.Producto_Id = ISNULL(@pProducto_Id,stkProductos2.Producto_Id))
 
 RETURN @@Error 

GO

DROP PROCEDURE stkProductosComboEliminar
GO
CREATE PROCEDURE stkProductosComboEliminar
(
@pCombo_Id varchar(25),
@pProducto_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductosCombo 
WHERE (Combo_Id = dbo.FuncFKstkProductos(@pCombo_Id))
AND (@pProducto_Id is null or Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
 
 RETURN @@Error 

GO
