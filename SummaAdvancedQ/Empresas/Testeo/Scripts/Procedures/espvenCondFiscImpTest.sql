DROP PROCEDURE espvenCondFiscImpTestGuardar
GO
CREATE PROCEDURE espvenCondFiscImpTestGuardar
(
@pvenCondFiscal int,
@pvenImpuestos varchar (5),
@pObservacion varchar(max)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espvenCondFiscImpTest WHERE (venCondFiscal = @pvenCondFiscal) AND (venImpuestos = dbo.FuncFKvenImpuestos (@pvenImpuestos))))
BEGIN 
	UPDATE espvenCondFiscImpTest
	SET		Observacion = @pObservacion
	WHERE (venCondFiscal = @pvenCondFiscal) AND (venImpuestos =dbo.FuncFKvenImpuestos (@pvenImpuestos))
END 
ELSE 
BEGIN 
	INSERT INTO espvenCondFiscImpTest
	(
		venCondFiscal,
		venImpuestos,
		Observacion
	)
	VALUES 
	(
		@pvenCondFiscal,
		dbo.FuncFKvenImpuestos (@pvenImpuestos),
		@pObservacion
	)
END 

GO

DROP PROCEDURE espvenCondFiscImpTestDatos
GO
CREATE PROCEDURE espvenCondFiscImpTestDatos
(
@pvenCondFiscal int,
@pvenImpuestos varchar(5) = NULL
)
AS
SET NOCOUNT ON 

SELECT espvenCondFiscImpTest.venCondFiscal, venImpuestos.Impuesto_Id ,espvenCondFiscImpTest.Observacion
FROM espvenCondFiscImpTest 
INNER JOIN venImpuestos ON (venImpuestos.venImpuestos = espvenCondFiscImpTest.venImpuestos)
WHERE (venCondFiscal = @pvenCondFiscal)
AND (venImpuestos.Impuesto_Id = @pvenImpuestos OR @pvenImpuestos IS NULL)
 
 RETURN @@Error 

GO

DROP PROCEDURE espvenCondFiscImpTestEliminar
GO
CREATE PROCEDURE espvenCondFiscImpTestEliminar
(
@pvenCondFiscal int,
@pvenImpuestos varchar (5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espvenCondFiscImpTest 
WHERE (venCondFiscal = @pvenCondFiscal)
AND (venImpuestos = dbo.FuncFKvenImpuestos (@pvenImpuestos) OR @pvenImpuestos IS NULL)
 
 RETURN @@Error 

GO

GO


