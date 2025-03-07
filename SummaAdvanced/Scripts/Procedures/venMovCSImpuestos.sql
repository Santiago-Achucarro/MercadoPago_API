DROP PROCEDURE venMovCSImpuestosGuardar
GO
CREATE PROCEDURE venMovCSImpuestosGuardar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int,
@pImpuesto_Id varChar(5),
@pImporte qMonedaD2,
@pImporteMonedaNac qMonedaD2,
@pPorcentaje qPorcentaje,
@pBaseImponible qMonedaD2,
@pBaseImponibleMonedaNac qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venMovCSImpuestos WHERE venMovimientos = @pvenMovimientos AND 
RenglonCuerpo = @pRenglonCuerpo AND Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id)))
BEGIN 
	UPDATE venMovCSImpuestos
	SET Importe = @pImporte,
		ImporteMonedaNac = @pImporteMonedaNac,
		Porcentaje = @pPorcentaje,
		BaseImponible = @pBaseImponible,
		BaseImponibleMonedaNac = @pBaseImponibleMonedaNac
	WHERE venMovimientos = @pvenMovimientos AND RenglonCuerpo = @pRenglonCuerpo AND Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venMovCSImpuestos
	(
		venMovimientos,
		RenglonCuerpo,
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
		@pRenglonCuerpo,
		dbo.FuncFKvenImpuestos(@pImpuesto_Id),
		@pImporte,
		@pImporteMonedaNac,
		@pPorcentaje,
		@pBaseImponible,
		@pBaseImponibleMonedaNac
	)
END 

GO

DROP PROCEDURE venMovCSImpuestosDatos
GO
CREATE PROCEDURE venMovCSImpuestosDatos
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = Null,
@pImpuesto_Id VarChar(5) = Null
)
AS
SET NOCOUNT ON 

SELECT venMovCSImpuestos.venMovimientos, venMovCSImpuestos.RenglonCuerpo, venImpuestos.Impuesto_Id,
	venImpuestos.Descripcion as DescripcionImpuestos, venMovCSImpuestos.Importe, venMovCSImpuestos.ImporteMonedaNac,
	venMovCSImpuestos.Porcentaje, venMovCSImpuestos.BaseImponible, venMovCSImpuestos.BaseImponibleMonedaNac
FROM venMovCSImpuestos 
INNER JOIN venMovConStockCr  ON (venMovConStockCr.venMovimientos = venMovCSImpuestos.venMovimientos) AND 
(venMovConStockCr.RenglonCuerpo = venMovCSImpuestos.RenglonCuerpo)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venMovCSImpuestos.Impuesto_Id)
WHERE 
venMovCSImpuestos.venMovimientos = @pvenMovimientos
AND venMovCSImpuestos.RenglonCuerpo = IsNull(@pRenglonCuerpo, venMovCSImpuestos.RenglonCuerpo)
AND venImpuestos.Impuesto_Id = IsNull(@pImpuesto_Id, venImpuestos.Impuesto_Id)
Order By 2

RETURN @@Error 

GO

DROP PROCEDURE venMovCSImpuestosEliminar
GO
CREATE PROCEDURE venMovCSImpuestosEliminar
(
@pvenMovimientos bigint,
@pRenglonCuerpo int = null,
@pImpuesto_Id varchar(5) = Null
)
AS
SET NOCOUNT ON 

Delete From venMovCSImpuestos
Where venMovimientos = @pvenMovimientos
	AND RenglonCuerpo = IsNull(@pRenglonCuerpo, RenglonCuerpo)
	AND Impuesto_Id = isNull(dbo.FuncFKvenImpuestos(@pImpuesto_Id), Impuesto_Id)


--If @pImpuesto_Id Is Null
--	DELETE FROM venMovCSImpuestos 
--	WHERE venMovimientos = @pvenMovimientos
--	AND RenglonCuerpo = @pRenglonCuerpo
--Else
--	DELETE FROM venMovCSImpuestos 
--	WHERE venMovimientos = @pvenMovimientos
--	AND RenglonCuerpo = IsNull(@pRenglonCuerpo, RenglonCuerpo)
--	AND Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id)
 
 RETURN @@Error 

GO
