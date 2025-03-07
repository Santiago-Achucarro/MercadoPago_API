DROP PROCEDURE impFormulasGuardar
GO
CREATE PROCEDURE impFormulasGuardar
(
@pImpuesto_Id varchar(5),
@pRenglon smallint,
@pCuenta_Id varchar(25),
@pDetalle varchar(80),
@pDebeHaberAmbos char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impFormulas WHERE (impImpuestos = dbo.FuncFKimpImpuestos(@pImpuesto_Id)) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE impFormulas
	SET		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Detalle = @pDetalle,
		DebeHaberAmbos = @pDebeHaberAmbos
	WHERE (impImpuestos = dbo.FuncFKimpImpuestos(@pImpuesto_Id)) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO impFormulas
	(
		impImpuestos,
		Renglon,
		Cuenta_Id,
		Detalle,
		DebeHaberAmbos
	)
	VALUES 
	(
		dbo.FuncFKimpImpuestos(@pImpuesto_Id),
		@pRenglon,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pDetalle,
		@pDebeHaberAmbos
	)
END 

GO

DROP PROCEDURE impFormulasDatos
GO
CREATE PROCEDURE impFormulasDatos
(
@pImpuesto_Id varchar(5),
@pRenglon smallint
)
AS
SET NOCOUNT ON 

SELECT impImpuestos.Descripcion as DescripcionImpuestos, impFormulas.Renglon, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	impFormulas.Detalle, impFormulas.DebeHaberAmbos
FROM impFormulas 
INNER JOIN impImpuestos  ON (impImpuestos.impImpuestos = impFormulas.impImpuestos)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = impFormulas.Cuenta_Id)
WHERE 
impImpuestos.Impuesto_Id	= @pImpuesto_Id
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE impFormulasEliminar
GO
CREATE PROCEDURE impFormulasEliminar
(
@pImpuesto_Id varchar(5),
@pRenglon smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impFormulas 
WHERE (impImpuestos = dbo.FuncFKimpImpuestos(@pImpuesto_Id))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
