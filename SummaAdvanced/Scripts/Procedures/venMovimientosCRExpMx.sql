DROP PROCEDURE venMovimientosCRExpMxGuardar
GO
CREATE PROCEDURE venMovimientosCRExpMxGuardar
(
@pvenMovimientos bigint,
@pRenglonCuerpo smallint,
@pCantidadAduana numeric(18,4),
@pUnidadAduana varchar(2),
@pValorUnitarioAduana numeric(18,4),
@pValorDolares numeric(18,4)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovimientosCRExpMx WHERE (venMovimientos = @pvenMovimientos) AND (RenglonCuerpo = @pRenglonCuerpo)))
BEGIN 
	UPDATE venMovimientosCRExpMx
	SET		CantidadAduana = @pCantidadAduana,
		UnidadAduana = @pUnidadAduana,
		ValorUnitarioAduana = @pValorUnitarioAduana,
		ValorDolares = @pValorDolares
	WHERE (venMovimientos = @pvenMovimientos) AND (RenglonCuerpo = @pRenglonCuerpo)
END 
ELSE 
BEGIN 
	INSERT INTO venMovimientosCRExpMx
	(
		venMovimientos,
		RenglonCuerpo,
		CantidadAduana,
		UnidadAduana,
		ValorUnitarioAduana,
		ValorDolares
	)
	VALUES 
	(
		@pvenMovimientos,
		@pRenglonCuerpo,
		@pCantidadAduana,
		@pUnidadAduana,
		@pValorUnitarioAduana,
		@pValorDolares
	)
END 

GO

DROP PROCEDURE venMovimientosCRExpMxDatos
GO
CREATE PROCEDURE venMovimientosCRExpMxDatos
(
@pvenMovimientos bigint,
@pRenglonCuerpo smallint
)
AS
SET NOCOUNT ON 

SELECT venMovimientosCRExpMx.venMovimientos, venMovimientosCRExpMx.RenglonCuerpo, venMovimientosCRExpMx.CantidadAduana, venMovimientosCRExpMx.UnidadAduana,
	venMovimientosCRExpMx.ValorUnitarioAduana, venMovimientosCRExpMx.ValorDolares
FROM venMovimientosCRExpMx 
WHERE (venMovimientos = @pvenMovimientos)
AND (RenglonCuerpo = @pRenglonCuerpo)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovimientosCRExpMxEliminar
GO
CREATE PROCEDURE venMovimientosCRExpMxEliminar
(
@pvenMovimientos bigint = NULL,
@pRenglonCuerpo smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venMovimientosCRExpMx 
WHERE (venMovimientos = ISNULL(@pvenMovimientos, venMovimientos))
AND (RenglonCuerpo = ISNULL(@pRenglonCuerpo, RenglonCuerpo))
 
 RETURN @@Error 

GO

GO
