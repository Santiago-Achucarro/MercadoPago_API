DROP PROCEDURE stkCFComImpInsertar
GO
CREATE PROCEDURE stkCFComImpInsertar
(
@pCFComp_Id int,
@pImpuesto_Id VarChar(5)
)
AS
BEGIN 
	INSERT INTO stkCFComImp
	(
		CFComp_Id,
		Impuesto_Id
	)
	VALUES 
	(
		@pCFComp_Id,
		dbo.FuncFKcomImpuestos(@pImpuesto_Id)
	)
END 

GO


DROP PROCEDURE stkCFComImpEliminar
GO
CREATE PROCEDURE stkCFComImpEliminar
(
@pCFComp_Id VarChar(5),
@pImpuesto_Id VarChar(5)=null
)
AS
SET NOCOUNT ON 

DELETE FROM stkCFComImp 
WHERE (CFComp_Id = dbo.FuncFKstkCondFisCompra(@pCFComp_Id))
AND ((@pImpuesto_Id is null) or (Impuesto_Id = dbo.FuncFKcomImpuestos(@pImpuesto_Id)))
 
 RETURN @@Error 

GO


