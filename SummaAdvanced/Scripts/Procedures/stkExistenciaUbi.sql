DROP PROCEDURE stkExistenciaUbiSumar
GO
CREATE PROCEDURE stkExistenciaUbiSumar
(
@pEmpresa_Id Int,
@pProducto_Id VarChar(25),
@pDeposito_Id VarChar(15),
@pUbicacion_Id VarChar(25),
@pCantidad qCantidadD8,
@pCantidadReservada qCantidadD8,
@pCantidadAlterna qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM stkExistenciaUbi WHERE 
	Empresa_Id = @pEmpresa_Id And
	Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND
	Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id)))
	
BEGIN 

	UPDATE stkExistenciaUbi
	SET	Cantidad = Cantidad + @pCantidad,
		CantidadReservada = CantidadReservada  + @pCantidadReservada,
		CantidadAlterna = CantidadAlterna + @pCantidadAlterna
		WHERE Empresa_Id = @pEmpresa_Id And
			  Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
			  Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) and 
			  Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkExistenciaUbi
	(
		Empresa_Id,
		Producto_Id,
		Deposito_Id,
		Ubicacion_Id,
		Cantidad,
		CantidadReservada,
		CantidadAlterna
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pCantidad,
		@pCantidadReservada,
		@pCantidadAlterna
	)
END 

GO

DROP PROCEDURE stkExistenciaUbiDatos
GO
CREATE PROCEDURE stkExistenciaUbiDatos
(
@pEmpresa_Id Int,
@pProducto_Id VarChar(25),
@pDeposito_Id VarChar(15) = Null,
@pUbicacion_Id VarChar(25) = Null
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, 
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	stkUbicaciones.Ubicacion_Id,
	stkExistenciaUbi.Cantidad, stkExistenciaUbi.CantidadReservada, stkExistenciaUbi.CantidadAlterna
FROM stkExistenciaUbi 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkExistenciaUbi.Producto_Id)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkExistenciaUbi.Deposito_Id)
INNER JOIN stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkExistenciaUbi.Ubicacion_Id
WHERE stkExistenciaUbi.Empresa_Id = @pEmpresa_Id And stkProductos.Producto_Id = @pProducto_Id
AND stkDepositos.Deposito_Id = IsNull(@pDeposito_Id, stkDepositos.Deposito_Id)
AND stkUbicaciones.Ubicacion_Id = IsNull(@pUbicacion_Id, stkUbicaciones.Ubicacion_Id) and 
stkExistenciaUbi.Cantidad <> 0
order by 6  
RETURN @@Error 

GO
