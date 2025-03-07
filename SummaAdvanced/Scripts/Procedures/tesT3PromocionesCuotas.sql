DROP PROCEDURE tesT3PromocionesCuotasGuardar
GO
CREATE PROCEDURE tesT3PromocionesCuotasGuardar
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

GO

DROP PROCEDURE tesT3PromocionesCuotasDatos
GO
CREATE PROCEDURE tesT3PromocionesCuotasDatos
(
@ptesT3Promociones int,
@pCuota int = Null
)
AS
SET NOCOUNT ON 

SELECT tesT3Promociones.Promocion_Id, tesT3Promociones.Descripcion as DescripcionT3Promociones, tesT3PromocionesCuotas.Cuota, tesT3PromocionesCuotas.Coeficiente,
Cast(0 As Numeric(19,2)) ValorCuota, Cast(0 As Numeric(19,2)) Total
FROM tesT3PromocionesCuotas 
INNER JOIN tesT3Promociones  ON (tesT3Promociones.tesT3Promociones = tesT3PromocionesCuotas.tesT3Promociones)
WHERE tesT3PromocionesCuotas.tesT3Promociones = dbo.FuncFKtesT3Promociones(@ptesT3Promociones)
AND Cuota = isNull(@pCuota, Cuota)
 
RETURN @@Error 

GO

DROP PROCEDURE tesT3PromocionesCuotasEliminar
GO
CREATE PROCEDURE tesT3PromocionesCuotasEliminar
(
@pPromocion_Id int,
@pCuota int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesT3PromocionesCuotas 
WHERE (tesT3Promociones = dbo.FuncFKtesT3Promociones(@pPromocion_Id))
AND (Cuota = ISNULL(@pCuota, Cuota))
 
 RETURN @@Error 

GO

DROP PROCEDURE tesT3PromocionesCuotasCalcularCuotas
GO
CREATE PROCEDURE tesT3PromocionesCuotasCalcularCuotas
(
@pPromocion_Id int,
@pTotal qMonedaD2
)
AS
SET NOCOUNT ON 

SELECT tesT3Promociones.Promocion_Id, tesT3Promociones.Descripcion as DescripcionT3Promociones, tesT3PromocionesCuotas.Cuota, tesT3PromocionesCuotas.Coeficiente,
Round((@pTotal * tesT3PromocionesCuotas.Coeficiente) / tesT3PromocionesCuotas.Cuota, 2) ValorCuota, Round(@pTotal * tesT3PromocionesCuotas.Coeficiente, 2) Total
FROM tesT3PromocionesCuotas 
INNER JOIN tesT3Promociones  ON (tesT3Promociones.tesT3Promociones = tesT3PromocionesCuotas.tesT3Promociones)
WHERE tesT3PromocionesCuotas.tesT3Promociones = dbo.FuncFKtesT3Promociones(@pPromocion_Id)

 
RETURN @@Error 

GO