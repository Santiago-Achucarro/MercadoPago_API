DROP PROCEDURE venMovimientosCFDIRGuardar
GO
CREATE PROCEDURE venMovimientosCFDIRGuardar
(
@pvenMovimientos bigint,
@pvenMovimientosR bigint,
@pTipoRelacion char(2) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovimientosCFDIR WHERE (venMovimientos = @pvenMovimientos) AND (venMovimientosR = @pvenMovimientosR)))
BEGIN 
	UPDATE venMovimientosCFDIR
	SET TipoRelacion = @pTipoRelacion
	WHERE (venMovimientos = @pvenMovimientos) AND (venMovimientosR = @pvenMovimientosR)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosCFDIR
	(
		venMovimientos,
		venMovimientosR,
		TipoRelacion
	)
	VALUES 
	(
		@pvenMovimientos,
		@pvenMovimientosR,
		@pTipoRelacion
	)
END 

GO

DROP PROCEDURE venMovimientosCFDIRDatos
GO
CREATE PROCEDURE venMovimientosCFDIRDatos
(
@pvenMovimientos bigint = null,
@pvenMovimientosR bigint = null
)
AS
SET NOCOUNT ON 

SELECT venMovimientosCFDIR.venMovimientos, venMovimientosCFDIR.venMovimientosR, venMovimientosCFDIR.TipoRelacion,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
genAsiSegmentos.Segmento4C, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento
FROM venMovimientosCFDIR 
INNER JOIN venMovimientos ON (venMovimientos.venMovimientos = venMovimientosCFDIR.venMovimientos)
INNER JOIN venMovimientos venMovimientos2 ON (venMovimientos2.venMovimientos = venMovimientosCFDIR.venMovimientosR)
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovimientos2.venMovimientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE venMovimientosCFDIR.venMovimientos = IsNull(@pvenMovimientos, venMovimientosCFDIR.venMovimientos)
AND venMovimientosCFDIR.venMovimientosR = IsNull(@pvenMovimientosR, venMovimientosCFDIR.venMovimientosR)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosCFDIREliminar
GO
CREATE PROCEDURE venMovimientosCFDIREliminar
(
@pvenMovimientos bigint = null,
@pvenMovimientosR bigint = null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosCFDIR 
WHERE venMovimientosCFDIR.venMovimientos = IsNull(@pvenMovimientos, venMovimientosCFDIR.venMovimientos)
AND venMovimientosCFDIR.venMovimientosR = IsNull(@pvenMovimientosR, venMovimientosCFDIR.venMovimientosR)
 
RETURN @@Error 

GO
