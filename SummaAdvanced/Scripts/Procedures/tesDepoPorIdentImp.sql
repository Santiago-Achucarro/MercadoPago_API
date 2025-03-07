DROP PROCEDURE tesDepoPorIdentImpGuardar
GO
CREATE PROCEDURE tesDepoPorIdentImpGuardar
(
@ptesMovimientos bigint,
@pImpuesto_Id varchar(5),
@pBaseImponible numeric(18,2),
@pImporte numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesDepoPorIdentImp WHERE (tesMovimientos = @ptesMovimientos) AND (Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id))))
BEGIN 
	UPDATE tesDepoPorIdentImp
	SET		BaseImponible = @pBaseImponible,
			Importe = @pImporte
	WHERE (tesMovimientos = @ptesMovimientos) AND (Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesDepoPorIdentImp
	(
		tesMovimientos,
		Impuesto_Id,
		BaseImponible,
		Importe
	)
	VALUES 
	(
		@ptesMovimientos,
		dbo.FuncFKvenImpuestos(@pImpuesto_Id),
		@pBaseImponible,
		@pImporte
	)
END 

GO

DROP PROCEDURE tesDepoPorIdentImpDatos
GO
CREATE PROCEDURE tesDepoPorIdentImpDatos
(
@ptesMovimientos bigint,
@pImpuesto_Id VarChar(5) = NULL
)
AS
SET NOCOUNT ON 

SELECT tesDepoPorIdentImp.tesMovimientos, venImpuestos.Impuesto_Id, venImpuestos.Descripcion as DescripcionImpuestos,
		tesDepoPorIdentImp.BaseImponible, tesDepoPorIdentImp.Importe
FROM tesDepoPorIdentImp 
INNER JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = tesDepoPorIdentImp.tesMovimientos)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = tesDepoPorIdentImp.Impuesto_Id)
WHERE (tesDepoPorIdentImp.tesMovimientos = @ptesMovimientos)
AND (venImpuestos.Impuesto_Id = ISNULL(@pImpuesto_Id,venImpuestos.Impuesto_Id))
 
RETURN @@Error 

GO

DROP PROCEDURE tesDepoPorIdentImpEliminar
GO
CREATE PROCEDURE tesDepoPorIdentImpEliminar
(
@ptesMovimientos bigint,
@pImpuesto_Id varchar(5) = null
)
AS
SET NOCOUNT ON 

DELETE FROM tesDepoPorIdentImp 
WHERE (tesMovimientos = @ptesMovimientos)
AND (@pImpuesto_Id IS NULL OR Impuesto_Id = dbo.FuncFKvenImpuestos(@pImpuesto_Id))
 
RETURN @@Error 

GO

GO
