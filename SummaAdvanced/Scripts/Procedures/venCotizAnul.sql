DROP PROCEDURE venCotizAnulGuardar
GO
CREATE PROCEDURE venCotizAnulGuardar
(
@pCotizacion_Id int = NULL,
@pFecha datetime = NULL,
@pOperacion char(1) = NULL,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCotizAnul WHERE venCotizAnul.Cotizacion_Id=@pCotizacion_Id))
BEGIN 
	UPDATE venCotizAnul
	SET		Cotizacion_Id = @pCotizacion_Id,
		Fecha = dbo.FechaActual(),
		Operacion = @pOperacion,
		Usuario_Id = @pUsuario_Id
	WHERE venCotizAnul.Cotizacion_Id=@pCotizacion_Id
END 
ELSE 
BEGIN 
	INSERT INTO venCotizAnul
	(
		Cotizacion_Id,
		Fecha,
		Operacion,
		Usuario_Id
	)
	VALUES 
	(
		@pCotizacion_Id,
		dbo.FechaActual(),
		@pOperacion,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE venCotizAnulDatos
GO
CREATE PROCEDURE venCotizAnulDatos
(
@pCotizacion_Id int
)
AS
SET NOCOUNT ON 

SELECT venCotizaciones.venCotizaciones, venCotizAnul.Fecha, venCotizAnul.Operacion, venCotizAnul.Usuario_Id
FROM venCotizAnul 
LEFT JOIN venCotizaciones  ON (venCotizaciones.venCotizaciones = venCotizAnul.Cotizacion_Id)
WHERE  venCotizAnul.Cotizacion_Id=@pCotizacion_Id
 RETURN @@Error 

GO

DROP PROCEDURE venCotizAnulEliminar
GO
CREATE PROCEDURE venCotizAnulEliminar
(
@pCotizacion_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM venCotizAnul 
WHERE  venCotizAnul.Cotizacion_Id=@pCotizacion_Id
 RETURN @@Error 

GO

GO
