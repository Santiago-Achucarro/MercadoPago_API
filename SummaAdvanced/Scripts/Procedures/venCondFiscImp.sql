DROP PROCEDURE venCondFiscImpInsertar
GO
CREATE PROCEDURE venCondFiscImpInsertar
(
@pvenCondFiscal int,
@Impuesto_id VarChar(5)
)
AS
BEGIN 
	INSERT INTO venCondFiscImp
	(
		venCondFiscal,
		venImpuestos
	)
	VALUES 
	(
		@pvenCondFiscal,
		dbo.FuncFKvenImpuestos(@Impuesto_id)
	)
END 

GO

DROP PROCEDURE venCondFiscImpDatos
GO
CREATE PROCEDURE venCondFiscImpDatos
(
@pCondFisc_id VarChar(5),
@pImpuesto_id VarChar(5) = Null
)
AS
SET NOCOUNT ON 

SELECT venCondFiscImp.venCondFiscal,
	venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion as DescripcionCondFiscal, 
	venImpuestos.Impuesto_Id, venImpuestos.Descripcion as DescripcionImpuestos
FROM venCondFiscImp 
INNER JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = venCondFiscImp.venCondFiscal)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venCondFiscImp.venImpuestos)
WHERE (venCondFiscal.CondFisc_id = @pCondFisc_id)
AND (venImpuestos.Impuesto_id = IsNull(@pImpuesto_Id, venImpuestos.Impuesto_Id))
 
 RETURN @@Error 

GO

DROP PROCEDURE venCondFiscImpEliminar
GO
CREATE PROCEDURE venCondFiscImpEliminar
(
@pCondFisc_id varchar(5),
@pImpuesto_id varchar(5) = null
)
AS
SET NOCOUNT ON 

DELETE FROM venCondFiscImp 
WHERE venCondFiscal = dbo.FuncFKvenCondFiscal(@pCondFisc_id)
AND venImpuestos = IsNull(dbo.FuncFKvenImpuestos(@pImpuesto_id), venImpuestos)
 
 RETURN @@Error 

GO

GO
