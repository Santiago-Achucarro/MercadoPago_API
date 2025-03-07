DROP PROCEDURE stkUbiAlmacenDefectoGuardar
GO
CREATE PROCEDURE stkUbiAlmacenDefectoGuardar
(
@pEmpresa_Id Int,
@pDeposito_Id VarChar(15),
@pProducto_Id varchar(25),
@pUbicacion_Id varchar(25),
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkUbiAlmacenDefecto WHERE Empresa_Id = @pEmpresa_Id and  
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND 
		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)))
BEGIN 
	UPDATE stkUbiAlmacenDefecto
	SET		Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
			Usuario_Id = @pUsuario_Id
	WHERE Empresa_Id = @pEmpresa_Id and 
	(Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)) AND 
			(Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id))
END 
ELSE 
BEGIN 
	INSERT INTO stkUbiAlmacenDefecto
	(
		Empresa_Id,
		Deposito_Id,
		Producto_Id,
		Ubicacion_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE stkUbiAlmacenDefectoDatos
GO
CREATE PROCEDURE stkUbiAlmacenDefectoDatos
(
@pEmpresa_Id Int,
@pDeposito_Id VarChar(15),
@pProducto_Id VarChar(25) = null
)
AS
SET NOCOUNT ON 

SELECT stkDepositos.Deposito_Id, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUbicaciones.Ubicacion_Id
FROM stkUbiAlmacenDefecto 
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkUbiAlmacenDefecto.Deposito_Id)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkUbiAlmacenDefecto.Producto_Id)
INNER JOIN stkUbicaciones ON (stkUbicaciones.stkUbicaciones = stkUbiAlmacenDefecto.Ubicacion_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkUbiAlmacenDefecto.Usuario_Id)
WHERE 
stkUbiAlmacenDefecto.Empresa_Id = @pEmpresa_Id and 
(stkDepositos.Deposito_Id = @pDeposito_Id)
AND (stkProductos.Producto_Id =ISNULL(@pProducto_Id,stkProductos.Producto_Id))
 
RETURN @@Error 

GO

DROP PROCEDURE stkUbiAlmacenDefectoEliminar
GO
CREATE PROCEDURE stkUbiAlmacenDefectoEliminar
(
@pEmpresa_Id Int,
@pDeposito_Id varchar(15),
@pProducto_Id varchar(25) = null
)
AS
SET NOCOUNT ON 

DELETE FROM stkUbiAlmacenDefecto 
WHERE 
Empresa_Id = @pEmpresa_Id and 
Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
AND ( Producto_Id IS NULL OR (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)))
 
RETURN @@Error 

GO

DROP PROCEDURE stkUbiAlmacenDatos
GO
CREATE PROCEDURE stkUbiAlmacenDatos
(
	@pEmpresa_Id Int,
	@pDeposito_Id VarChar(5)
)
AS

SELECT stkDepositos.Deposito_Id, stkDepositos.Descripcion,  ' ' ParaPegar
From stkDepositos 
WHERE
	stkDepositos.Deposito_Id= @pDeposito_Id


SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUbicaciones.Ubicacion_Id
FROM stkUbiAlmacenDefecto 
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkUbiAlmacenDefecto.Deposito_Id)
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkUbiAlmacenDefecto.Producto_Id)
INNER JOIN stkUbicaciones ON (stkUbicaciones.stkUbicaciones = stkUbiAlmacenDefecto.Ubicacion_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkUbiAlmacenDefecto.Usuario_Id)
WHERE 
stkUbiAlmacenDefecto.Empresa_Id = @pEmpresa_Id and 
(stkDepositos.Deposito_Id = @pDeposito_Id)

ORDER BY 1
GO


