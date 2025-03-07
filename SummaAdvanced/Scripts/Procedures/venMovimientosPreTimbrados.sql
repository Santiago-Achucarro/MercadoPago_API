DROP PROCEDURE venMovimientosPreTimbradosGuardar
GO
CREATE PROCEDURE venMovimientosPreTimbradosGuardar
(
@pvenMovimientos bigint,
@pSucursal Sucursal,
@pComprobante_Id int,
@pSegmento1N bigint,
@pDetalle QMemo = NULL
)
AS
SET NOCOUNT ON

-- Puede haber pasado que una factura asigno un numero de comprobante de Afip y luego no se guardo en Summa pero --
-- quedo guardado el numero en esta tabla y que no haya ido a la Afip entonces puede ser que otra factura genere --
-- el mismo numero de comprobante entonces busco ese numero y lo reemplazo por otro que nunca se va a repetir --
-- Por eso Segmento1N es bigint y no int --
Update venMovimientosPreTimbrados Set Segmento1N = -venMovimientos Where Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal) And 
																	Comprobante_Id = @pComprobante_Id And Segmento1N = @pSegmento1N

IF (EXISTS (SELECT 1 FROM venMovimientosPreTimbrados WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovimientosPreTimbrados
	SET	Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		Comprobante_Id = @pComprobante_Id,
		Segmento1N = @pSegmento1N,
		Detalle = @pDetalle
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosPreTimbrados
	(
		venMovimientos,
		Sucursal,
		Comprobante_Id,
		Segmento1N,
		Detalle
	)
	VALUES 
	(
		@pvenMovimientos,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		@pComprobante_Id,
		@pSegmento1N,
		@pDetalle
	)
END 

GO

DROP PROCEDURE venMovimientosPreTimbradosDatos
GO
CREATE PROCEDURE venMovimientosPreTimbradosDatos
(
@pSucursal Sucursal,
@pComprobante_Id int,
@pSegmento1N bigint
)
AS
SET NOCOUNT ON 

SELECT venMovimientosPreTimbrados.venMovimientos, genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr,
	venMovimientosPreTimbrados.Comprobante_Id, genTiposCompAfip.Descripcion as DescripcionTiposCompAfip, venMovimientosPreTimbrados.Segmento1N, venMovimientosPreTimbrados.Detalle
FROM venMovimientosPreTimbrados 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venMovimientosPreTimbrados.venMovimientos)
Inner JOIN genSucursalesEmpr  ON (genSucursalesEmpr.genSucursalesEmpr = venMovimientosPreTimbrados.Sucursal)
Inner JOIN genTiposCompAfip  ON (genTiposCompAfip.Comprobante_Id = venMovimientosPreTimbrados.Comprobante_Id)
WHERE genSucursalesEmpr.Sucursal = @pSucursal And venMovimientosPreTimbrados.Comprobante_Id = @pComprobante_Id And venMovimientosPreTimbrados.Segmento1N = @pSegmento1N
 
RETURN @@Error 

GO

DROP PROCEDURE venMovimientosPreTimbradosEliminar
GO
CREATE PROCEDURE venMovimientosPreTimbradosEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosPreTimbrados 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosPreTimbradosGuardarDetalle
GO
CREATE PROCEDURE venMovimientosPreTimbradosGuardarDetalle
(
@pvenMovimientos bigint,
@pDetalle QMemo
)
AS
SET NOCOUNT ON

Update venMovimientosPreTimbrados Set Detalle = @pDetalle Where venMovimientos = @pvenMovimientos
Go
