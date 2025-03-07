DROP PROCEDURE comRIArticuloGuardar
GO
CREATE PROCEDURE comRIArticuloGuardar
(
@pcomReqInterno int,
@pRenglon_RI int,
@pProducto_Id varchar(25) = NULL,
@pFactor qCantidadD8,
@pCantidadOriginal qCantidadD8,
@pPrecioOriginal qMonedaD4,
@pDeposito_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comRIArticulo WHERE (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)))
BEGIN 
	UPDATE comRIArticulo
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		Factor = @pFactor,
		CantidadOriginal = @pCantidadOriginal,
		PrecioOriginal = @pPrecioOriginal,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
	WHERE (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)
END 
ELSE 
BEGIN 
	INSERT INTO comRIArticulo
	(
		comReqInterno,
		Renglon_RI,
		Producto_Id,
		Factor,
		CantidadOriginal,
		PrecioOriginal,
		Deposito_Id
	)
	VALUES 
	(
		@pcomReqInterno,
		@pRenglon_RI,
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pFactor,
		@pCantidadOriginal,
		@pPrecioOriginal,
		dbo.FuncFKstkDepositos(@pDeposito_Id)
	)
END 

GO

DROP PROCEDURE comRIArticuloDatos
GO
CREATE PROCEDURE comRIArticuloDatos
(
@pcomReqInterno int,
@pRenglon_RI int=null
)
AS
SET NOCOUNT ON 

SELECT comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad,
	comRICuerpo.Precio, comRICuerpo.CantidadRecibida, comRICuerpo.Observaciones, comRICuerpo.Pendiente,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed,

comRIArticulo.comReqInterno, stkProductos.Producto_Id,
	stkProductos.Descripcion as DescripcionProductos, comRIArticulo.Factor, comRIArticulo.CantidadOriginal, comRIArticulo.PrecioOriginal,
	stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos
FROM comRIArticulo 
INNER JOIN comRICuerpo  ON (comRICuerpo.comReqInterno = comRIArticulo.comReqInterno) AND (comRICuerpo.Renglon_RI = comRIArticulo.Renglon_RI)
inner join comReqInterno on comReqInterno.comReqInterno=comRICuerpo.comReqInterno
LEFT JOIN stkProductos  ON (stkProductos.stkProductos = comRIArticulo.Producto_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = comRIArticulo.Deposito_Id)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comRICuerpo.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comRICuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comRICuerpo.Centro2_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comRICuerpo.Medida_Id)
WHERE (comReqInterno.comReqInterno = @pcomReqInterno)
AND (comRIArticulo.Renglon_RI = isnull(@pRenglon_RI, comRIArticulo.Renglon_RI))
 
 RETURN @@Error 

GO

DROP PROCEDURE comRIArticuloEliminar
GO
CREATE PROCEDURE comRIArticuloEliminar
(
@pcomReqInterno int,
@pRenglon_RI int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comRIArticulo 
WHERE (comReqInterno = @pcomReqInterno)
AND (Renglon_RI = ISNULL(@pRenglon_RI,Renglon_RI))
 
 RETURN @@Error 

GO

GO
