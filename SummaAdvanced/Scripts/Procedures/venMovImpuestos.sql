DROP PROCEDURE venMovImpuestosGuardar
GO
CREATE PROCEDURE venMovImpuestosGuardar
(
@pvenMovimientos bigint,
@pconRenglon int,
@pImpuesto_Id varchar(5),
@pPorcentaje qPorcentaje,
@pBaseImponible qMonedaD2,
@pImporte qMonedaD2,
@pBaseImponibleMonedaNac qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovImpuestos WHERE (venMovimientos = @pvenMovimientos) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE venMovImpuestos
	SET		Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id),
		Porcentaje = @pPorcentaje,
		BaseImponible = @pBaseImponible,
		Importe = @pImporte,
		BaseImponibleMonedaNac = @pBaseImponibleMonedaNac
	WHERE (venMovimientos = @pvenMovimientos) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venMovImpuestos
	(
		venMovimientos,
		conRenglon,
		Impuesto_Id,
		Porcentaje,
		BaseImponible,
		Importe,
		BaseImponibleMonedaNac
	)
	VALUES 
	(
		@pvenMovimientos,
		@pconRenglon,
		dbo.FuncFKvenImpuestos(@pImpuesto_Id),
		@pPorcentaje,
		@pBaseImponible,
		@pImporte,
		@pBaseImponibleMonedaNac
	)
END 

GO

DROP PROCEDURE venMovImpuestosDatos
GO
CREATE PROCEDURE venMovImpuestosDatos
(
@pvenMovimientos bigint,
@pconRenglon int = Null
)
AS
SET NOCOUNT ON 

SELECT venMovImpuestos.venMovimientos, venMovImpuestos.conRenglon,
	venImpuestos.Impuesto_Id, venImpuestos.Descripcion as DescripcionImpuestos, venMovImpuestos.Porcentaje,
	venMovImpuestos.BaseImponible, venMovImpuestos.Importe, venMovImpuestos.BaseImponibleMonedaNac,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.TipoMov, conMovCont.Clase, conMovCont.Importe as ImporteContable
FROM venMovImpuestos 
INNER JOIN conMovCont  ON (conMovCont.conAsientos = venMovImpuestos.venMovimientos) AND (conMovCont.Renglon = venMovImpuestos.conRenglon)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id)
	INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.cuenta_Id 
	Left JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
	Left JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
WHERE (venMovimientos = @pvenMovimientos)
AND (conRenglon = IsNull(@pconRenglon, conRenglon))
Order By 2

 RETURN @@Error 

GO

DROP PROCEDURE venMovImpuestosEliminar
GO
CREATE PROCEDURE venMovImpuestosEliminar
(
@pvenMovimientos bigint,
@pconRenglon int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venMovImpuestos 
WHERE (venMovimientos = @pvenMovimientos)
AND (conRenglon = IsNull(@pconRenglon, conRenglon))
 
 RETURN @@Error 

GO

GO
