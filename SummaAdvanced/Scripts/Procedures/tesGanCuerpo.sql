DROP PROCEDURE tesGanCuerpoGuardar
GO
CREATE PROCEDURE tesGanCuerpoGuardar
(
@pTabla_Id int,
@pHasta qMonedaD2,
@pPorcentaje qPorcentaje,
@pMinimo qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesGanCuerpo WHERE (Tabla_Id = @pTabla_Id) AND (Hasta = @pHasta)))
BEGIN 
	UPDATE tesGanCuerpo
	SET		Porcentaje = @pPorcentaje,
		Minimo = @pMinimo
	WHERE (Tabla_Id = @pTabla_Id) AND (Hasta = @pHasta)
END 
ELSE 
BEGIN 
	INSERT INTO tesGanCuerpo
	(
		Tabla_Id,
		Hasta,
		Porcentaje,
		Minimo
	)
	VALUES 
	(
		@pTabla_Id,
		@pHasta,
		@pPorcentaje,
		@pMinimo
	)
END 

GO

DROP PROCEDURE tesGanCuerpoDatos
GO
CREATE PROCEDURE tesGanCuerpoDatos
(
@pTabla_Id int,
@pHasta qMonedaD2 = Null
)
AS
SET NOCOUNT ON 

SELECT tesGanancias.Tabla_Id, tesGanancias.Descripcion as DescripcionGanancias, tesGanCuerpo.Hasta, tesGanCuerpo.Porcentaje,
	tesGanCuerpo.Minimo
FROM tesGanCuerpo 
INNER JOIN tesGanancias  ON (tesGanancias.tesGanancias = tesGanCuerpo.Tabla_Id)
WHERE tesGanCuerpo.Tabla_Id = @pTabla_Id
AND Hasta = IsNull(@pHasta, Hasta)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesGanCuerpoEliminar
GO
CREATE PROCEDURE tesGanCuerpoEliminar
(
@pTabla_Id int,
@pHasta qMonedaD2 = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesGanCuerpo 
WHERE (Tabla_Id = @pTabla_Id)
AND (Hasta = ISNULL(@pHasta, Hasta))
 
 RETURN @@Error 

GO
