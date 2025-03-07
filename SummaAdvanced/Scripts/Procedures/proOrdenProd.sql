DROP PROCEDURE proOrdenProdGuardar
GO
CREATE PROCEDURE proOrdenProdGuardar
(
@pproOrden int,
@pRenglon int,
@pProducto_Id varchar(25),
@pEntradaSalida char(1),
@pMedida_Id varchar(5),
@pCantidad qCantidadD8,
@pPorcentajeCosto qPorcentaje,
@pDeposito_Id varchar(15) = NULL,
@pTomaDepoT3 Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenProd WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE proOrdenProd
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		EntradaSalida = @pEntradaSalida,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Cantidad = @pCantidad,
		PorcentajeCosto = @pPorcentajeCosto,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		TomaDepoT3 = @pTomaDepoT3
	WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenProd
	(
		proOrden,
		Renglon,
		Producto_Id,
		EntradaSalida,
		Medida_Id,
		Cantidad,
		PorcentajeCosto,
		Deposito_Id,
		TomaDepoT3
	)
	VALUES 
	(
		@pproOrden,
		@pRenglon,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pEntradaSalida,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pCantidad,
		@pPorcentajeCosto,
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pTomaDepoT3
	)
END 

GO

DROP PROCEDURE proOrdenProdDatos
GO
CREATE PROCEDURE proOrdenProdDatos
(
@pproOrden int,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT proOrdenProd.proOrden, proOrdenProd.Renglon, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, proOrdenProd.EntradaSalida,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, proOrdenProd.Cantidad, proOrdenProd.PorcentajeCosto, stkDepositos.Deposito_Id,
	stkDepositos.Descripcion as DescripcionDepositos, proOrdenProd.TomaDepoT3
FROM proOrdenProd 
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = proOrdenProd.Deposito_Id)
inner join stkProductos on stkProductos=proOrdenProd.Producto_Id
inner join stkUniMed on stkUniMed=proOrdenProd.Medida_Id
WHERE (proOrden = @pproOrden)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE proOrdenProdEliminar
GO
CREATE PROCEDURE proOrdenProdEliminar
(
@pproOrden int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenProd 
WHERE (proOrden = @pproOrden)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
