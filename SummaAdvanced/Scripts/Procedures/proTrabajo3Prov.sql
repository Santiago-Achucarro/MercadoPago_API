DROP PROCEDURE proTrabajo3ProvGuardar
GO
CREATE PROCEDURE proTrabajo3ProvGuardar
(
@pTrabajo3_Id varchar(25),
@pRenglon int,
@pProveedor_Id varchar(15) = NULL,
@pMoneda_Id varchar(3) = NULL,
@pPrecio qMonedaD4,
@pMedida_Id varchar(5) = NULL,
@pCantidad qCantidadD8,
@pPredeterminado Sino, 
@pDeposito_Id VarChar(5)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proTrabajo3Prov WHERE (Trabajo3_Id = dbo.FuncFKproTrabajo3(@pTrabajo3_Id)) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE proTrabajo3Prov
	SET		Proveedor_Id = dbo.FuncFKcomProveedores(@pProveedor_Id),
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Precio = @pPrecio,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Cantidad = @pCantidad,
		Predeterminado = @pPredeterminado, 
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
	WHERE (Trabajo3_Id = dbo.FuncFKproTrabajo3(@pTrabajo3_Id)) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO proTrabajo3Prov
	(
		Trabajo3_Id,
		Renglon,
		Proveedor_Id,
		Moneda_Id,
		Precio,
		Medida_Id,
		Cantidad,
		Predeterminado,
		Deposito_Id 
	)
	VALUES 
	(
		dbo.FuncFKproTrabajo3(@pTrabajo3_Id),
		@pRenglon,
		dbo.FuncFKcomProveedores(@pProveedor_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pPrecio,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pCantidad,
		@pPredeterminado,
		dbo.FuncFKstkDepositos(@pDeposito_Id)
	)
END 

GO

DROP PROCEDURE proTrabajo3ProvDatos
GO
CREATE PROCEDURE proTrabajo3ProvDatos
(
@pTrabajo3_Id varchar(25),
@pRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion, proTrabajo3Prov.Renglon, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveed,
genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMoneda, proTrabajo3Prov.Precio, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, proTrabajo3Prov.Cantidad,
	proTrabajo3Prov.Predeterminado, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito
FROM proTrabajo3Prov 
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = proTrabajo3Prov.Medida_Id)
inner join proTrabajo3 on proTrabajo3.proTrabajo3=proTrabajo3Prov.Trabajo3_Id
left join comProveedores on comProveedores.genEntidades=proTrabajo3Prov.Proveedor_Id
left join genMonedas on genMonedas.genMonedas=proTrabajo3Prov.Moneda_Id
left join stkDepositos ON stkDepositos.stkDepositos = proTrabajo3Prov.Deposito_Id
WHERE (proTrabajo3.Trabajo3_Id = @pTrabajo3_Id)
AND (Renglon = isnull(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE proTrabajo3ProvEliminar
GO
CREATE PROCEDURE proTrabajo3ProvEliminar
(
@pTrabajo3_Id varchar(25),
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proTrabajo3Prov 
WHERE (Trabajo3_Id = dbo.FuncFKproTrabajo3(@pTrabajo3_Id))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
