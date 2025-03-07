DROP PROCEDURE tesSolPagoInsertar
GO
CREATE PROCEDURE tesSolPagoInsertar
(
@ptesSolicitud bigint,
@ptesMovimientos bigint
)
AS
BEGIN
	INSERT INTO tesSolPago
	(
		tesSolicitud,
		tesMovimientos
	)
	VALUES 
	(
		@ptesSolicitud,
		@ptesMovimientos
	)
END 

GO

DROP PROCEDURE tesSolPagoDatos
GO
CREATE PROCEDURE tesSolPagoDatos
(
	@ptesSolicitud bigint = NULL, 
	@ptesMovimientos bigint = NULL
)
AS
SET NOCOUNT ON 

SELECT tesSolPago.tesSolicitud, tesSolPago.tesMovimientos
FROM tesSolPago 
WHERE 
	tesSolicitud = isnull(@ptesSolicitud, tesSolicitud) and 
	tesMovimientos = IsNull(@ptesMovimientos, tesMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesSolPagoEliminar
GO
CREATE PROCEDURE tesSolPagoEliminar
(
	@ptesSolicitud bigint , 
	@ptesMovimientos bigint 
)
AS
SET NOCOUNT ON 

DELETE FROM tesSolPago 
	WHERE tesMovimientos = @ptesMovimientos and 
		tesSolicitud = @ptesSolicitud
 
 RETURN @@Error 

GO

