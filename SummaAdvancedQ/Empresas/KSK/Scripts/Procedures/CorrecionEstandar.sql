
ALTER PROCEDURE [dbo].[tesT3PromocionesCuotasGuardar]
(
@ptesT3Promociones int,
@pCuota int,
@pCoeficiente qCantidadD8
)
AS
SET NOCOUNT ON 

INSERT INTO tesT3PromocionesCuotas
(
	tesT3Promociones,
	Cuota,
	Coeficiente
)
VALUES 
(
	dbo.FuncFKtesT3Promociones(@ptesT3Promociones),
	@pCuota,
	@pCoeficiente
)
