DROP PROCEDURE stkArtiUMGuardar
GO
CREATE PROCEDURE stkArtiUMGuardar
(
@pProducto_Id VarChar(25),
@pMedida_Id VarChar(5),
@pFactor numeric(15,8),
@pCodigoBarra VarChar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkArtiUM 
	WHERE Producto_Id = dbo.FuncFKStkProductos(@pProducto_Id) AND 
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id)))
		
BEGIN 
	UPDATE stkArtiUM
	SET		Factor = @pFactor, CodigoBarra = @pCodigoBarra
	WHERE 
		Producto_Id = dbo.FuncFKStkProductos(@pProducto_Id) AND 
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkArtiUM
	(
		Producto_Id,
		Medida_Id,
		Factor, 
		CodigoBarra
	)
	VALUES 
	(
		dbo.FuncFKStkProductos(@pProducto_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pFactor, 
		@pCodigoBarra
	)
END 

GO

DROP PROCEDURE stkArtiUMDatos
GO
CREATE PROCEDURE stkArtiUMDatos
(
@pProducto_Id VarChar(25),
@pMedida_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed,
	stkArtiUM.Factor, stkArtiUM.CodigoBarra
FROM stkArtiUM 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkArtiUM.Producto_Id)
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = stkArtiUM.Medida_Id)
WHERE (stkProductos.Producto_Id = @pProducto_Id)
AND (stkUniMed.Medida_Id = @pMedida_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkArtiUMEliminar
GO
CREATE PROCEDURE stkArtiUMEliminar
(
@pProducto_id varchar(25),
@pMedida_id varchar(5)= null
)
AS
SET NOCOUNT ON 

DELETE FROM stkArtiUM 
WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_id))
AND (@pMedida_id  IS NULL OR Medida_Id = dbo.FuncFKstkUniMed(@pMedida_id))
 
 RETURN @@Error 

GO

