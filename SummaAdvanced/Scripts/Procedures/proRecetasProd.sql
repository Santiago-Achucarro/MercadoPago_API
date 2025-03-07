DROP PROCEDURE proRecetasProdGuardar
GO
CREATE PROCEDURE proRecetasProdGuardar
(
@pReceta_Id varchar(25),
@pRenglon int,
@pProducto_Id varchar(25),
@pEntradaSalida char(1),
@pMedida_Id varchar(5) = NULL,
@pFormula varchar(max),
@pCantidad qCantidadD8,
@pPorcentajeCosto qPorcentaje,
@pDeposito_Id varchar(15) = NULL,
@pObservaciones varchar(max) = NULL,
@pTomaDepoT3 Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proRecetasProd WHERE (Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id)) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE proRecetasProd
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		EntradaSalida = @pEntradaSalida,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Formula = @pFormula,
		Cantidad = @pCantidad,
		PorcentajeCosto = @pPorcentajeCosto,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		Observaciones = @pObservaciones,
		TomaDepoT3 = @pTomaDepoT3
	WHERE (Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id)) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO proRecetasProd
	(
		Receta_Id,
		Renglon,
		Producto_Id,
		EntradaSalida,
		Medida_Id,
		Formula,
		Cantidad,
		PorcentajeCosto,
		Deposito_Id,
		Observaciones,
		TomaDepoT3
	)
	VALUES 
	(
		dbo.FuncFKproRecetas(@pReceta_Id),
		@pRenglon,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pEntradaSalida,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pFormula,
		@pCantidad,
		@pPorcentajeCosto,
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pObservaciones,
		@pTomaDepoT3
	)
END 

GO

DROP PROCEDURE proRecetasProdDatos
GO
CREATE PROCEDURE proRecetasProdDatos
(
@pReceta_Id int,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionReceta, proRecetasProd.Renglon, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, proRecetasProd.EntradaSalida,
	stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida_Id, proRecetasProd.Formula, proRecetasProd.Cantidad, proRecetasProd.PorcentajeCosto,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, proRecetasProd.Observaciones, proRecetasProd.TomaDepoT3
FROM proRecetasProd 
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = proRecetasProd.Deposito_Id)
left join stkProductos on stkProductos=proRecetasProd.Producto_Id
left join stkUniMed on stkUniMed.stkUniMed=proRecetasProd.Medida_Id
inner join proRecetas on proRecetas=proRecetasProd.Receta_Id
WHERE (proRecetas = @pReceta_Id)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE proRecetasProdEliminar
GO
CREATE PROCEDURE proRecetasProdEliminar
(
@pReceta_Id varchar(25),
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proRecetasProd 
WHERE (Receta_Id = dbo.FuncFKproRecetas(@pReceta_Id))
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
