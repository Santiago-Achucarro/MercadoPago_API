DROP PROCEDURE proMovCierreTrabajos3Insertar
GO
CREATE PROCEDURE proMovCierreTrabajos3Insertar
(
@pproMovCierreOrden bigint,
@pRenglon int,
@pTrabajo3_Id varchar(25),
@pCantidad qCantidadD8,
@pMoneda_Id varchar(3),
@pProveed_Id VarChar(15),
@pPrecio qMonedaD4, 
@pPrecioOriginal qMonedaD4 
)
AS
SET NOCOUNT ON 

	INSERT INTO proMovCierreTrabajos3
	(
		proMovCierreOrden,
		Renglon,
		Trabajo3_Id,
		Cantidad,
		Moneda_Id,
		Proveed_Id,
		Precio, 
		PrecioOriginal
	)
	VALUES 
	(
		@pproMovCierreOrden,
		@pRenglon,
		dbo.FuncFKproTrabajo3(@pTrabajo3_Id),
		@pCantidad,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKcomProveedores(@pProveed_Id),
		@pPrecio, 
		@pPrecioOriginal
	)
GO

DROP PROCEDURE proMovCierreTrabajos3Datos
GO
CREATE PROCEDURE proMovCierreTrabajos3Datos
(
@pproMovCierreOrden bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

SELECT proMovCierreTrabajos3.proMovCierreOrden,  proMovCierreTrabajos3.Renglon,
	proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion as DescripcionTrabajo3, 
	proMovCierreTrabajos3.Cantidad,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial ,
	proMovCierreTrabajos3.Precio, proMovCierreTrabajos3.PrecioOriginal
FROM proMovCierreTrabajos3 
INNER JOIN proMovCierreOrden  ON (proMovCierreOrden.proMovCierreOrden = proMovCierreTrabajos3.proMovCierreOrden)
INNER JOIN proTrabajo3  ON (proTrabajo3.proTrabajo3 = proMovCierreTrabajos3.Trabajo3_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = proMovCierreTrabajos3.Moneda_Id)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = proMovCierreTrabajos3.Proveed_Id)
WHERE (proMovCierreTrabajos3.proMovCierreOrden = @pproMovCierreOrden)
AND (proMovCierreTrabajos3.Renglon = ISNULL(@pRenglon,proMovCierreTrabajos3.Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE proMovCierreTrabajos3Eliminar
GO
CREATE PROCEDURE proMovCierreTrabajos3Eliminar
(
@pproMovCierreOrden bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proMovCierreTrabajos3 
WHERE (proMovCierreOrden = @pproMovCierreOrden)
AND (proMovCierreTrabajos3.Renglon = ISNULL(@pRenglon,proMovCierreTrabajos3.Renglon))
 
 RETURN @@Error 

GO

GO
