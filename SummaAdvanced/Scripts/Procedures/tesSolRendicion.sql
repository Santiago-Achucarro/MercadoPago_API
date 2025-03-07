DROP PROCEDURE tesSolRendicionInsertar
GO
CREATE PROCEDURE tesSolRendicionInsertar
(
@ptesMovimientos bigint,
@ptesSolicitud bigint
)
AS
SET NOCOUNT ON 
	INSERT INTO tesSolRendicion
	(
		tesMovimientos,
		tesSolicitud
	)
	VALUES 
	(
		@ptesMovimientos,
		@ptesSolicitud
	)
GO

DROP PROCEDURE tesSolRendicionDatos
GO
CREATE PROCEDURE tesSolRendicionDatos
(
@ptesMovimientos bigint=NULL, 
@ptesSolicitud bigInt=NULL
)
AS
SET NOCOUNT ON 

SELECT tesSolRendicion.tesMovimientos, tesSolRendicion.tesSolicitud
FROM tesSolRendicion 
WHERE tesMovimientos = isnull(@ptesMovimientos,tesMovimientos) and 
	  tesSolicitud = ISNULL(@ptesSolicitud, tesSolicitud)
 
RETURN @@Error 

GO

DROP PROCEDURE tesSolRendicionEliminar
GO
CREATE PROCEDURE tesSolRendicionEliminar
(
@ptesMovimientos bigint 
)
AS
SET NOCOUNT ON 

DELETE FROM tesSolRendicion 
WHERE tesMovimientos = @ptesMovimientos
 
RETURN @@Error 

GO

GO
