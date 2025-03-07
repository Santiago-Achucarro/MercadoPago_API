DROP PROCEDURE venClientesCtasPlantillaGuardar
GO
CREATE PROCEDURE venClientesCtasPlantillaGuardar
(
@pPlantilla_Id varchar(15),
@pMoneda_Id varchar(3),
@pCuentaDxVtas varchar(25) = NULL,
@pCtaFactAnticipo varchar(25) = NULL,
@pCtaAnticipo varchar(25) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venClientesCtasPlantilla WHERE Plantilla_Id = dbo.FuncFKvenClientesPlantilla(@pPlantilla_Id) AND Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)))
BEGIN 
	UPDATE venClientesCtasPlantilla
	SET CuentaDxVtas = dbo.FuncFKconCuentas(@pCuentaDxVtas),
		CtaFactAnticipo = dbo.FuncFKconCuentas(@pCtaFactAnticipo),
		CtaAnticipo = dbo.FuncFKconCuentas(@pCtaAnticipo)
	WHERE Plantilla_Id = dbo.FuncFKvenClientesPlantilla(@pPlantilla_Id) AND Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venClientesCtasPlantilla
	(
		Plantilla_Id,
		Moneda_Id,
		CuentaDxVtas,
		CtaFactAnticipo,
		CtaAnticipo
	)
	VALUES 
	(
		dbo.FuncFKvenClientesPlantilla(@pPlantilla_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKconCuentas(@pCuentaDxVtas),
		dbo.FuncFKconCuentas(@pCtaFactAnticipo),
		dbo.FuncFKconCuentas(@pCtaAnticipo)
	)
END 

GO

DROP PROCEDURE venClientesCtasPlantillaDatos
GO
CREATE PROCEDURE venClientesCtasPlantillaDatos
(
@pPlantilla_Id VarChar(15),
@pMoneda_Id VarChar(5) = Null
)
AS
SET NOCOUNT ON 

SELECT venClientesPlantilla.Plantilla_Id, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas,
	CuentaDxVtas.Cuenta_Id CuentaDxVtas, CuentaDxVtas.Descripcion as DescripcionCuentaDxVtas, CtaFactAnticipo.Cuenta_Id CtaFactAnticipo,
	CtaFactAnticipo.Descripcion as DescripcionCtaFactAnticipo, CtaAnticipo.Cuenta_Id CtaAnticipo, CtaAnticipo.Descripcion as DescripcionCtaAnticipo
FROM venClientesCtasPlantilla 
INNER JOIN venClientesPlantilla  ON (venClientesPlantilla.venClientesPlantilla = venClientesCtasPlantilla.Plantilla_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = venClientesCtasPlantilla.Moneda_Id)
LEFT JOIN conCuentas CuentaDxVtas ON (CuentaDxVtas.conCuentas = venClientesCtasPlantilla.CuentaDxVtas)
LEFT JOIN conCuentas CtaFactAnticipo ON (CtaFactAnticipo.conCuentas = venClientesCtasPlantilla.CtaFactAnticipo)
LEFT JOIN conCuentas CtaAnticipo ON (CtaAnticipo.conCuentas = venClientesCtasPlantilla.CtaAnticipo)
WHERE (venClientesPlantilla.Plantilla_Id = @pPlantilla_Id)
AND genMonedas.Moneda_Id = IsNull(@pMoneda_Id, genMonedas.Moneda_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE venClientesCtasPlantillaEliminar
GO
CREATE PROCEDURE venClientesCtasPlantillaEliminar
(
@pPlantilla_Id varchar(15),
@pMoneda_Id varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venClientesCtasPlantilla 
WHERE Plantilla_Id = dbo.FuncFKvenClientesPlantilla(@pPlantilla_Id)
AND Moneda_Id = IsNull(dbo.FuncFKgenMonedas(@pMoneda_Id), Moneda_Id)
 
RETURN @@Error 

GO

