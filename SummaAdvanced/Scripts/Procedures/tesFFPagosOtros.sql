DROP PROCEDURE tesFFPagosOtrosGuardar
GO
CREATE PROCEDURE tesFFPagosOtrosGuardar
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pRenglon int,
@pDescripcion varchar(200),
@pTipo char(1),
@pImpuesto_Id VarChar(5) = NULL,
@pMoneda_Id varchar(3),
@pMonto numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesFFPagosOtros WHERE 
	(tesFlujoFondo = @ptesFlujoFondo) AND 
	(Fecha = @pFecha) AND 
	(Renglon = @pRenglon)))
BEGIN 
	UPDATE tesFFPagosOtros
	SET		Descripcion = @pDescripcion,
		Tipo = @pTipo,
		Impuesto_Id = dbo.FuncFKimpImpuestos(@pImpuesto_Id),
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Monto = @pMonto
	WHERE (tesFlujoFondo = @ptesFlujoFondo) AND 
		(Fecha = @pFecha) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO tesFFPagosOtros
	(
		tesFlujoFondo,
		Fecha,
		Renglon,
		Descripcion,
		Tipo,
		Impuesto_Id,
		Moneda_Id,
		Monto
	)
	VALUES 
	(
		@ptesFlujoFondo,
		@pFecha,
		@pRenglon,
		@pDescripcion,
		@pTipo,
		dbo.FuncFKimpImpuestos(@pImpuesto_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pMonto
	)
END 

GO

DROP PROCEDURE tesFFPagosOtrosDatos
GO
CREATE PROCEDURE tesFFPagosOtrosDatos
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT tesFlujoFondo.tesFlujoFondo , tesFFPagosOtros.Fecha, tesFFPagosOtros.Renglon, 
	tesFFPagosOtros.Descripcion, tesFFPagosOtros.Tipo, 
	impImpuestos.Impuesto_Id, impImpuestos.Descripcion as DescripcionImpuesto,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	tesFFPagosOtros.Monto
FROM tesFFPagosOtros 
INNER JOIN tesFlujoFondo  ON (tesFlujoFondo.tesFlujoFondo = tesFFPagosOtros.tesFlujoFondo)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesFFPagosOtros.Moneda_Id)
LEFT JOIN impImpuestos ON impImpuestos.impImpuestos = tesFFPagosOtros.Impuesto_Id
WHERE (tesFFPagosOtros.tesFlujoFondo = @ptesFlujoFondo)
AND (tesFFPagosOtros.Fecha = @pFecha)
AND (tesFFPagosOtros.Renglon = @pRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE tesFFPagosOtrosEliminar
GO
CREATE PROCEDURE tesFFPagosOtrosEliminar
(
@ptesFlujoFondo bigint,
@pFechaDesde datetime ,
@pFechaHasta datetime
)
AS
SET NOCOUNT ON 

DELETE FROM tesFFPagosOtros 
WHERE (tesFlujoFondo = @ptesFlujoFondo)
AND (Fecha Between @pFechaDesde and @pFechaHasta)
 
RETURN @@Error 

GO


