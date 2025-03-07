DROP PROCEDURE stkExistenciaSumar
GO
CREATE PROCEDURE stkExistenciaSumar
(
@pEmpresa_Id Int,
@pProducto_Id VarChar(25),
@pDeposito_Id VarChar(15),
@pCantidad qCantidadD8,
@pCantidadReservada qCantidadD8,
@pCantidadAlterna qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkExistencia WHERE 
	Empresa_Id = @pEmpresa_Id And
	Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)))
	
BEGIN 
	UPDATE stkExistencia
	SET	Cantidad = Cantidad + @pCantidad,
		CantidadReservada = CantidadReservada  + @pCantidadReservada,
		CantidadAlterna = CantidadAlterna + @pCantidadAlterna
		WHERE Empresa_Id = @pEmpresa_Id And
			  Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
			  Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkExistencia
	(
		Empresa_Id,
		Producto_Id,
		Deposito_Id,
		Cantidad,
		CantidadReservada,
		CantidadAlterna
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pCantidad,
		@pCantidadReservada,
		@pCantidadAlterna
	)
END 

GO

DROP PROCEDURE stkExistenciaDatos
GO
CREATE PROCEDURE stkExistenciaDatos
(
@pEmpresa_Id Int,
@pProducto_Id VarChar(25),
@pDeposito_Id VarChar(15) = Null
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, 
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	stkExistencia.Cantidad, stkExistencia.CantidadReservada, stkExistencia.CantidadAlterna
FROM stkExistencia 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkExistencia.Producto_Id)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkExistencia.Deposito_Id)
WHERE stkExistencia.Empresa_Id = @pEmpresa_Id And stkProductos.Producto_Id = @pProducto_Id
AND stkDepositos.Deposito_Id = IsNull(@pDeposito_Id, stkDepositos.Deposito_Id)
 
 RETURN @@Error 

GO
