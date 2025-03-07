DROP PROCEDURE stkExistenciaUbiSerieSumar
GO
CREATE PROCEDURE stkExistenciaUbiSerieSumar
(
@pEmpresa_Id Int,
@pProducto_Id VarChar(25),
@pDeposito_Id VarChar(15),
@pSerie VarChar(25),
@pUbicacion_Id VarChar(25),
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT * FROM stkExistenciaUbiSerie WHERE 
	Empresa_Id = @pEmpresa_Id And
	Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
	Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) AND
	Serie = @pSerie AND
	Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id)))
	
BEGIN 

	UPDATE stkExistenciaUbiSerie
	SET	Cantidad = Cantidad + @pCantidad
		WHERE Empresa_Id = @pEmpresa_Id And
			  Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id) AND 
			  Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) and 
			  Serie = @pSerie and 
			  Ubicacion_Id = dbo.FuncFKstkUbicaciones(@pUbicacion_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkExistenciaUbiSerie
	(
		Empresa_Id,
		Producto_Id,
		Deposito_Id,
		Serie,
		Ubicacion_Id,
		Cantidad
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pSerie,
		dbo.FuncFKstkUbicaciones(@pUbicacion_Id),
		@pCantidad
		
	)
END 

GO

DROP PROCEDURE stkExistenciaUbiSerieDatos
GO
CREATE PROCEDURE stkExistenciaUbiSerieDatos
(
@pEmpresa_Id Int,
@pProducto_Id VarChar(25),
@pDeposito_Id VarChar(15) = Null,
@pSerie VarChar(25) = Null,
@pUbicacion_Id VarChar(25) = Null
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, 
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos,
	stkExistenciaUbiSerie.Serie, stkSerieVencimiento.Vencimiento, stkUbicaciones.Ubicacion_Id,
	stkExistenciaUbiSerie.Cantidad
FROM stkExistenciaUbiSerie
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkExistenciaUbiSerie.Producto_Id)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkExistenciaUbiSerie.Deposito_Id)
INNER JOIN stkUbicaciones ON stkUbicaciones.stkUbicaciones = stkExistenciaUbiSerie.Ubicacion_Id
LEFT JOIN stkSerieVencimiento ON  stkSerieVencimiento.Serie = stkExistenciaUbiSerie.Serie
WHERE stkExistenciaUbiSerie.Empresa_Id = @pEmpresa_Id And stkProductos.Producto_Id = @pProducto_Id
AND stkDepositos.Deposito_Id = IsNull(@pDeposito_Id, stkDepositos.Deposito_Id)
AND stkUbicaciones.Ubicacion_Id = IsNull(@pUbicacion_Id, stkUbicaciones.Ubicacion_Id) 
AND stkExistenciaUbiSerie.Serie = ISNULL(@pSerie,stkExistenciaUbiSerie.Serie)
and stkExistenciaUbiSerie.Cantidad <> 0
order by 5, 8 desc  
RETURN @@Error 

GO
