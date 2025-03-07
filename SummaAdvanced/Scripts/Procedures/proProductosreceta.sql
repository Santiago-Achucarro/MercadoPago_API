DROP PROCEDURE proProductosRecetaGuardar
GO
CREATE PROCEDURE proProductosRecetaGuardar
(
@pProducto_Id varchar(25),
@pReceta_Id varchar(25),
@pPrincipal bit = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proProductosReceta WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND (Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id))))
BEGIN 
	UPDATE proProductosReceta
	SET		Principal = @pPrincipal
	WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND (Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id))
END 
ELSE 
BEGIN 
	INSERT INTO proProductosReceta
	(
		Producto_Id,
		Receta_Id,
		Principal
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKproRecetas(@pReceta_Id),
		@pPrincipal
	)
END 

GO

DROP PROCEDURE proProductosRecetaDatos
GO
CREATE PROCEDURE proProductosRecetaDatos
(
@pProducto_Id varchar(25)=null,
@pReceta_Id varchar(25)=null
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionReceta, proProductosReceta.Principal
FROM proProductosReceta 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = proProductosReceta.Producto_Id)
inner join proRecetas on proRecetas=proProductosReceta.Receta_Id
WHERE (stkProductos.Producto_Id = isnull(@pProducto_Id,stkProductos.Producto_Id))
AND (proRecetas.Receta_Id = isnull(@pReceta_Id, proRecetas.Receta_Id))
Order By proProductosReceta.Principal Desc -- Que primero salga la receta principal 13715 --
 
RETURN @@Error 

GO

DROP PROCEDURE proProductosRecetaEliminar
GO
CREATE PROCEDURE proProductosRecetaEliminar
(
@pProducto_Id varchar(25),
@pReceta_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proProductosReceta 
WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
AND ((Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id)) or @pReceta_Id IS NULL )
 
 RETURN @@Error 

GO

