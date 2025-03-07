DROP PROCEDURE venMovSSImpuestosGuardar
GO
CREATE PROCEDURE venMovSSImpuestosGuardar
(
@pvenMovimientos bigint,
@pconRenglon int,
@pImpuesto_Id varChar(5),
@pImporte qMonedaD2,
@pImporteMonedaNac qMonedaD2,
@pPorcentaje qPorcentaje,
@pBaseImponible qMonedaD2,
@pBaseImponibleMonedaNac qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovSSImpuestos WHERE venMovimientos = @pvenMovimientos AND conRenglon = @pconRenglon AND 
	Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id)))
BEGIN 
	UPDATE venMovSSImpuestos
	SET Importe = @pImporte,
		ImporteMonedaNac = @pImporteMonedaNac,
		Porcentaje = @pPorcentaje,
		BaseImponible = @pBaseImponible,
		BaseImponibleMonedaNac = @pBaseImponibleMonedaNac
	WHERE venMovimientos = @pvenMovimientos AND conRenglon = @pconRenglon AND Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venMovSSImpuestos
	(
		venMovimientos,
		conRenglon,
		Impuesto_Id,
		Importe,
		ImporteMonedaNac,
		Porcentaje,
		BaseImponible,
		BaseImponibleMonedaNac
	)
	VALUES 
	(
		@pvenMovimientos,
		@pconRenglon,
		dbo.FuncFKvenImpuestos(@pImpuesto_Id),
		@pImporte,
		@pImporteMonedaNac,
		@pPorcentaje,
		@pBaseImponible,
		@pBaseImponibleMonedaNac
	)
END 

GO

DROP PROCEDURE venMovSSImpuestosDatos
GO
CREATE PROCEDURE venMovSSImpuestosDatos
(
@pvenMovimientos bigint,
@pconRenglon int = NULL,
@pImpuesto_Id varChar(5) = null
)
AS
SET NOCOUNT ON 

SELECT venMovSSImpuestos.venMovimientos, venMovSSImpuestos.conRenglon, venImpuestos.Impuesto_Id,
	venImpuestos.Descripcion as DescripcionImpuestos, venMovSSImpuestos.Importe, venMovSSImpuestos.ImporteMonedaNac,
	venMovSSImpuestos.Porcentaje, venMovSSImpuestos.BaseImponible, venMovSSImpuestos.BaseImponibleMonedaNac
FROM venMovSSImpuestos 
INNER JOIN venMovDetalle ON venMovDetalle.venMovimientos = venMovSSImpuestos.venMovimientos AND 
venMovDetalle.conRenglon = venMovSSImpuestos.conRenglon
INNER JOIN venImpuestos ON venImpuestos.venImpuestos = venMovSSImpuestos.Impuesto_Id
WHERE venMovSSImpuestos.venMovimientos = @pvenMovimientos
AND venMovSSImpuestos.conRenglon = isnull(@pconRenglon, venMovSSImpuestos.conRenglon) 
AND venMovSSImpuestos.Impuesto_Id = Isnull(dbo.FuncFKvenImpuestos( @pImpuesto_Id), venMovSSImpuestos.Impuesto_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE venMovSSImpuestosEliminar
GO
CREATE PROCEDURE venMovSSImpuestosEliminar
(
@pvenMovimientos bigint,
@pconRenglon int = Null,
@pImpuesto_Id varchar(5) = Null
)
AS
SET NOCOUNT ON

DELETE FROM venMovSSImpuestos 
WHERE venMovimientos = @pvenMovimientos
AND conRenglon = isNull(@pconRenglon, conRenglon)
AND Impuesto_Id = isNull(dbo.FuncFKvenImpuestos(@pImpuesto_Id), Impuesto_Id)

--If @pImpuesto_Id Is Null
--	DELETE FROM venMovSSImpuestos 
--	WHERE (venMovimientos = @pvenMovimientos)
--	AND (conRenglon = @pconRenglon)
--Else
--	DELETE FROM venMovSSImpuestos 
--	WHERE (venMovimientos = @pvenMovimientos)
--	AND (conRenglon = @pconRenglon)
--	AND (Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id))
 
 RETURN @@Error 

GO
