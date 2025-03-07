DROP PROCEDURE venMatPeligrosoMXGuardar
GO
CREATE PROCEDURE venMatPeligrosoMXGuardar
(
@pClaveSat varchar(8)
)
AS
SET NOCOUNT ON 
	INSERT INTO venMatPeligrosoMX
	(
		ClaveSat
	)
	VALUES 
	(
		@pClaveSat
	)

GO

DROP PROCEDURE venMatPeligrosoMXDatos
GO
CREATE PROCEDURE venMatPeligrosoMXDatos
(
@pClaveSat varchar(8)
)
AS
SET NOCOUNT ON 

SELECT venMatPeligrosoMX.ClaveSat
FROM venMatPeligrosoMX 
WHERE (ClaveSat = @pClaveSat)
 
RETURN @@Error 

GO

DROP PROCEDURE venMatPeligrosoMXEliminar
GO
CREATE PROCEDURE venMatPeligrosoMXEliminar
(
@pClaveSat varchar(8) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMatPeligrosoMX 
WHERE (ClaveSat = ISNULL(@pClaveSat, ClaveSat))
 
 RETURN @@Error 

GO

GO
