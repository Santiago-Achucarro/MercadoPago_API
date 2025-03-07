DROP PROCEDURE venMoviAnticipoGuardar
GO
CREATE PROCEDURE venMoviAnticipoGuardar
(
@pvenMovimientos bigint,
@pPorcentaje qPorcentaje,
@pImporte qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMoviAnticipo WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE venMoviAnticipo
	SET		Porcentaje = @pPorcentaje,
		Importe = @pImporte
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO venMoviAnticipo
	(
		venMovimientos,
		Porcentaje,
		Importe
	)
	VALUES 
	(
		@pvenMovimientos,
		@pPorcentaje,
		@pImporte
	)
END 

GO

DROP PROCEDURE venMoviAnticipoDatos
GO
CREATE PROCEDURE venMoviAnticipoDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT venMoviAnticipo.venMovimientos,  venMoviAnticipo.Porcentaje, venMoviAnticipo.Importe
FROM venMoviAnticipo 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venMoviAnticipo.venMovimientos)
WHERE (venMoviAnticipo.venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMoviAnticipoEliminar
GO
CREATE PROCEDURE venMoviAnticipoEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venMoviAnticipo 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

GO
