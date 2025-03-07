DROP PROCEDURE venMovimientosFiscalINEGuardar
GO
CREATE PROCEDURE venMovimientosFiscalINEGuardar
(
@pvenMovimientos bigint,
@pClaveIdentidad varchar(3) ,
@pidContabilidad numeric(6,0) ,
@pAmbito varchar(9) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovimientosFiscalINE WHERE (venMovimientos = @pvenMovimientos) AND (ClaveIdentidad = @pClaveIdentidad) AND (idContabilidad = @pidContabilidad)))
BEGIN 
	UPDATE venMovimientosFiscalINE
	SET		Ambito = @pAmbito
	WHERE (venMovimientos = @pvenMovimientos) AND (ClaveIdentidad = @pClaveIdentidad) AND (idContabilidad = @pidContabilidad)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosFiscalINE
	(
		venMovimientos,
		ClaveIdentidad,
		idContabilidad,
		Ambito
	)
	VALUES 
	(
		@pvenMovimientos,
		@pClaveIdentidad,
		@pidContabilidad,
		@pAmbito
	)
END 

GO

DROP PROCEDURE venMovimientosFiscalINEDatos
GO
CREATE PROCEDURE venMovimientosFiscalINEDatos
(
@pvenMovimientos bigint,
@pClaveIdentidad varchar(3) = NULL,
@pidContabilidad numeric(5) = NULL
)
AS
SET NOCOUNT ON 

SELECT venMovimientosFiscalINE.venMovimientos, venMovimientosFiscalINE.ClaveIdentidad, venMovimientosFiscalINE.idContabilidad, venMovimientosFiscalINE.Ambito
FROM venMovimientosFiscalINE 
WHERE (venMovimientos = @pvenMovimientos)
AND (ClaveIdentidad = ISNULL(@pClaveIdentidad,ClaveIdentidad))
AND (idContabilidad = ISNULL(@pidContabilidad,idContabilidad))
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosFiscalINEEliminar
GO
CREATE PROCEDURE venMovimientosFiscalINEEliminar
(
@pvenMovimientos bigint = NULL,
@pClaveIdentidad varchar(3) = NULL,
@pidContabilidad numeric(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosFiscalINE 
WHERE (venMovimientos = ISNULL(@pvenMovimientos, venMovimientos))
AND (ClaveIdentidad = ISNULL(@pClaveIdentidad, ClaveIdentidad))
AND (idContabilidad = ISNULL(@pidContabilidad, idContabilidad))
 
 RETURN @@Error 

GO

GO
