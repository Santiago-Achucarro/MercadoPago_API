DROP PROCEDURE sueGananciasGuardar
GO
CREATE PROCEDURE sueGananciasGuardar
(
@pTabGan_Id int,
@pHasta qMonedaD2,
@pPorcentaje qPorcentaje,
@pMinimo qMonedaD2,
@pVer int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueGanancias WHERE (TabGan_Id = @pTabGan_Id) AND (Hasta = @pHasta)))
BEGIN 
	UPDATE sueGanancias
	SET		Porcentaje = @pPorcentaje,
		Minimo = @pMinimo,
		Ver=@pVer
	WHERE (TabGan_Id = @pTabGan_Id) AND (Hasta = @pHasta)
END 
ELSE 
BEGIN 
	INSERT INTO sueGanancias
	(
		TabGan_Id,
		Hasta,
		Porcentaje,
		Minimo,
		Ver
	)
	VALUES 
	(
		@pTabGan_Id,
		@pHasta,
		@pPorcentaje,
		@pMinimo,
		@pVer
	)
END 

GO



DROP PROCEDURE sueGananciasEliminar
GO
CREATE PROCEDURE sueGananciasEliminar
(
@pTabGan_Id int,
@pHasta qMonedaD2 = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueGanancias 
WHERE (TabGan_Id = @pTabGan_Id)
AND (Hasta = ISNULL(@pHasta, Hasta))
 
 RETURN @@Error 

GO

GO
