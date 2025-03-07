DROP PROCEDURE stkCFVenImpInsertar
GO
CREATE PROCEDURE stkCFVenImpInsertar
(
@pCFVenta_Id int,
@pImpuesto_Id VarChar(5)
)
AS
SET NOCOUNT ON 
BEGIN 
	INSERT INTO stkCFVenImp
	(
		CFVenta_Id,
		Impuesto_Id
	)
	VALUES 
	(
		@pCFVenta_Id,
		dbo.FuncFkvenImpuestos(@pImpuesto_Id)
	)
END 

GO


DROP PROCEDURE stkCFVenImpEliminar
GO
CREATE PROCEDURE stkCFVenImpEliminar
(
@pCfVenta_Id VarChar(5),
@pImpuesto_Id VarChar(5)=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkCFVenImp 
WHERE (CFVenta_Id = dbo.FuncFKstkCondFisVenta(@pCfVenta_id)) AND 
((@pImpuesto_Id is null) or (Impuesto_Id = dbo.FuncFkVenImpuestos(@pImpuesto_Id)))
 
 RETURN @@Error 

GO

GO

