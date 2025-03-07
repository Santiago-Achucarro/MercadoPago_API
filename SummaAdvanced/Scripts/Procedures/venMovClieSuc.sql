DROP PROCEDURE venMovClieSucGuardar
GO
CREATE PROCEDURE venMovClieSucGuardar
(
@pvenMovimientos bigint,
@pgenEntidades bigint,
@pSucursal SucursalN
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovClieSuc WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMovClieSuc
	SET		genEntidades = @pgenEntidades,
		Sucursal = @pSucursal
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMovClieSuc
	(
		venMovimientos,
		genEntidades,
		Sucursal
	)
	VALUES 
	(
		@pvenMovimientos,
		@pgenEntidades,
		@pSucursal
	)
END 

GO

DROP PROCEDURE venMovClieSucDatos
GO
CREATE PROCEDURE venMovClieSucDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venMovClieSuc.venMovimientos, venMovClieSuc.genEntidades, venMovClieSuc.Sucursal,
	venClieHabitual.NombreFantasia
FROM venMovClieSuc 
INNER JOIN venClieHabitual  ON (venClieHabitual.genEntidades = venMovClieSuc.genEntidades) AND (venClieHabitual.Sucursal = venMovClieSuc.Sucursal)
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovClieSucEliminar
GO
CREATE PROCEDURE venMovClieSucEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMovClieSuc 
WHERE (venMovimientos = @pvenMovimientos)
 
RETURN @@Error 

GO
