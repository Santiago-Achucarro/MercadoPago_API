DROP PROCEDURE tesFFCobranzaOtrosGuardar
GO
CREATE PROCEDURE tesFFCobranzaOtrosGuardar
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pRenglon int,
@pDescripcion varchar(200),
@pMoneda_Id varchar(3),
@pMonto numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesFFCobranzaOtros WHERE 
	(tesFlujoFondo = @ptesFlujoFondo) AND 
	(Fecha = @pFecha) AND 
	(Renglon = @pRenglon)))
BEGIN 
	UPDATE tesFFCobranzaOtros
	SET		Descripcion = @pDescripcion,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Monto = @pMonto
	WHERE (tesFlujoFondo = @ptesFlujoFondo) AND (Fecha = @pFecha) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesFFCobranzaOtros
	(
		tesFlujoFondo,
		Fecha,
		Renglon,
		Descripcion,
		Moneda_Id,
		Monto
	)
	VALUES 
	(
		@ptesFlujoFondo,
		@pFecha,
		@pRenglon,
		@pDescripcion,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pMonto
	)
END 

GO

DROP PROCEDURE tesFFCobranzaOtrosDatos
GO
CREATE PROCEDURE tesFFCobranzaOtrosDatos
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT tesFlujoFondo.tesFlujoFondo, tesFFCobranzaOtros.Fecha, tesFFCobranzaOtros.Renglon, 
	tesFFCobranzaOtros.Descripcion, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	tesFFCobranzaOtros.Monto, tesFlujoFondo.FechaDesde, tesFlujoFondo.FechaHasta
FROM tesFFCobranzaOtros 
INNER JOIN tesFlujoFondo  ON (tesFlujoFondo.tesFlujoFondo = tesFFCobranzaOtros.tesFlujoFondo)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesFFCobranzaOtros.Moneda_Id)
WHERE (tesFFCobranzaOtros.tesFlujoFondo = @ptesFlujoFondo)
AND (tesFFCobranzaOtros.Fecha = @pFecha)
AND (tesFFCobranzaOtros.Renglon = @pRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE tesFFCobranzaOtrosEliminar
GO
CREATE PROCEDURE tesFFCobranzaOtrosEliminar
(
@ptesFlujoFondo bigint,
@pFechaDesde datetime ,
@pFechaHasta datetime 
)
AS
SET NOCOUNT ON 

DELETE FROM tesFFCobranzaOtros 
WHERE 
tesFlujoFondo = @ptesFlujoFondo AND 
Fecha between @pFechaDesde and @pFechaHasta
 
RETURN @@Error 

GO


