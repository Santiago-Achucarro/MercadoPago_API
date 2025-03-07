DROP PROCEDURE comEmbGastosGuardar
GO
CREATE PROCEDURE comEmbGastosGuardar
(
@pcomEmbarques int,
@pRenglon int,
@pDetalle varchar(50),
@pImporteOriginal qMonedaD2,
@pImporte qMonedaD2,
@pMoneda_Id varchar(3),
@pCantidadImporte char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comEmbGastos WHERE (comEmbarques = @pcomEmbarques) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE comEmbGastos
	SET Detalle = @pDetalle,
		ImporteOriginal = @pImporteOriginal,
		Importe = @pImporte,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		CantidadImporte = @pCantidadImporte
	WHERE (comEmbarques = @pcomEmbarques) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comEmbGastos
	(
		comEmbarques,
		Renglon,
		Detalle,
		ImporteOriginal,
		Importe,
		Moneda_Id,
		CantidadImporte
	)
	VALUES 
	(
		@pcomEmbarques,
		@pRenglon,
		@pDetalle,
		@pImporteOriginal,
		@pImporte,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pCantidadImporte
	)
END 

GO

DROP PROCEDURE comEmbGastosDatos
GO
CREATE PROCEDURE comEmbGastosDatos
(
@pcomEmbarques int,
@pRenglon int = Null
)
AS
SET NOCOUNT ON 

SELECT comEmbarques.comEmbarques, comEmbGastos.Renglon, comEmbGastos.Detalle, comEmbGastos.ImporteOriginal, comEmbGastos.Importe,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, comEmbGastos.CantidadImporte
FROM comEmbGastos 
INNER JOIN comEmbarques  ON (comEmbarques.comEmbarques = comEmbGastos.comEmbarques)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = comEmbGastos.Moneda_Id)
WHERE (comEmbGastos.comEmbarques = @pcomEmbarques)
AND comEmbGastos.Renglon = IsNull(@pRenglon, comEmbGastos.Renglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE comEmbGastosEliminar
GO
CREATE PROCEDURE comEmbGastosEliminar
(
@pcomEmbarques int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comEmbGastos 
WHERE (comEmbarques = @pcomEmbarques)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
RETURN @@Error 

GO
