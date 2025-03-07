
DROP PROCEDURE comMovDetalleGuardar
GO
CREATE PROCEDURE comMovDetalleGuardar
(
@pcomMovProv bigint,
@pRenglon int,
@pDetalle varchar(250),
@pImporte qMonedaD2,
@pCuenta_id varChar(25)= NULL,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pBase_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comMovDetalle WHERE (comMovProv = @pcomMovProv) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE comMovDetalle
	SET		Detalle = @pDetalle,
		Importe = @pImporte,
		Cuenta_id = dbo.FuncFKconCuentas(@pCuenta_id),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Base_Id = dbo.FuncFKconBaseDistri(@pBase_Id)
	WHERE (comMovProv = @pcomMovProv) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comMovDetalle
	(
		comMovProv,
		Renglon,
		Detalle,
		Importe,
		Cuenta_id,
		Centro1_Id,
		Centro2_Id,
		Base_Id
	)
	VALUES 
	(
		@pcomMovProv,
		@pRenglon,
		@pDetalle,
		@pImporte,
		dbo.FuncFKconCuentas(@pCuenta_id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		dbo.FuncFKconBaseDistri(@pBase_Id)
	)
END 

GO

DROP PROCEDURE comMovDetalleDatos
GO
CREATE PROCEDURE comMovDetalleDatos
(
@pcomMovProv bigint,
@pRenglon int=null
)
AS
SET NOCOUNT ON 


SELECT comMovDetalle.comMovProv, comMovDetalle.Renglon, comMovDetalle.Detalle,
	comMovDetalle.Importe, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, 	conCentro2.Descripcion as DescripcionCentro2, 
	conBaseDistri.Base_Id, conBaseDistri.Descripcion as DescripcionBaseDistri
FROM comMovDetalle 
INNER JOIN comMovProv  ON (comMovProv.comMovProv = comMovDetalle.comMovProv)
LEFT JOIN conCuentas ON (conCuentas.conCuentas = comMovDetalle.Cuenta_id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comMovDetalle.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comMovDetalle.Centro2_Id)
LEFT JOIN conBaseDistri  ON (conBaseDistri.conBaseDistri = comMovDetalle.Base_Id)
WHERE (comMovProv.comMovProv = @pcomMovProv)
AND (Renglon = ISNULL(@pRenglon,Renglon))
order by 2
 
 RETURN @@Error 

GO

DROP PROCEDURE comMovDetalleEliminar
GO
CREATE PROCEDURE comMovDetalleEliminar
(
@pcomMovProv bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comMovDetalle 
WHERE (comMovProv = @pcomMovProv)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

