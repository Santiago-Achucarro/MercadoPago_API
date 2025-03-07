DROP PROCEDURE VenCondPagoCuotasGuardar
GO
CREATE PROCEDURE VenCondPagoCuotasGuardar
(
@pCondPagoCli_id int,
@pRenglon int,
@pDias int = NULL,
@pPorcentaje qPorcentaje
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM VenCondPagoCuotas WHERE (CondPagoCli_id = @pCondPagoCli_id) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE VenCondPagoCuotas
	SET		Dias = @pDias,
		Porcentaje = @pPorcentaje
	WHERE (CondPagoCli_id = @pCondPagoCli_id) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO VenCondPagoCuotas
	(
		CondPagoCli_id,
		Renglon,
		Dias,
		Porcentaje
	)
	VALUES 
	(
		@pCondPagoCli_id,
		@pRenglon,
		@pDias,
		@pPorcentaje
	)
END 

GO

DROP PROCEDURE VenCondPagoCuotasDatos
GO
CREATE PROCEDURE VenCondPagoCuotasDatos
(
@pCondPagoCli_id varChar(5),
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT venCondPago.venCondPago, 
VenCondPagoCuotas.CondPagoCli_id, venCondPago.Descripcion as DescripcionCondPago, VenCondPagoCuotas.Renglon, VenCondPagoCuotas.Dias,
	VenCondPagoCuotas.Porcentaje
FROM VenCondPagoCuotas 
INNER JOIN venCondPago  ON (venCondPago.venCondPago = VenCondPagoCuotas.CondPagoCli_id)
WHERE (venCondPago.CondPagoCli_id = @pCondPagoCli_id)
AND (VenCondPagoCuotas.Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE VenCondPagoCuotasEliminar
GO
CREATE PROCEDURE VenCondPagoCuotasEliminar
(
@pCondPagoCli_id VarChar(5),
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM VenCondPagoCuotas 
WHERE (CondPagoCli_id = dbo.FuncFKvenCondPago(@pCondPagoCli_id))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
