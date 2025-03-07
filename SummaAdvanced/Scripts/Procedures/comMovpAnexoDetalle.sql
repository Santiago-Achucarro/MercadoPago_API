DROP PROCEDURE comMovpAnexoDetalleGuardar
GO
CREATE PROCEDURE comMovpAnexoDetalleGuardar
(
@pAsiento_Id bigint,
@pRenglon int,
@pImporte qMonedaD2,
@pCuenta_Id varchar(25) = NULL,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pBase_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comMovpAnexoDetalle WHERE (Asiento_Id = @pAsiento_Id) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE comMovpAnexoDetalle
	SET		Importe = @pImporte,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Base_Id = dbo.FuncFKconBaseDistri(@pBase_Id)
	WHERE (Asiento_Id = @pAsiento_Id) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comMovpAnexoDetalle
	(
		Asiento_Id,
		Renglon,
		Importe,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		Base_Id
	)
	VALUES 
	(
		@pAsiento_Id,
		@pRenglon,
		@pImporte,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		dbo.FuncFKconBaseDistri(@pBase_Id)
	)
END 

GO

DROP PROCEDURE comMovpAnexoDetalleDatos
GO
CREATE PROCEDURE comMovpAnexoDetalleDatos
(
@pAsiento_Id bigint,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT comMovpAnexoDetalle.Asiento_Id, comMovpAnexoDetalle.Renglon, comMovpAnexoDetalle.Importe,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, conBaseDistri.Base_Id, conBaseDistri.Descripcion as DescripcionBaseDistri
FROM comMovpAnexoDetalle 
INNER JOIN comMovpAnexo  ON (comMovpAnexo.Asiento_Id = comMovpAnexoDetalle.Asiento_Id)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comMovpAnexoDetalle.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comMovpAnexoDetalle.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comMovpAnexoDetalle.Centro2_Id)
LEFT JOIN conBaseDistri  ON (conBaseDistri.conBaseDistri = comMovpAnexoDetalle.Base_Id)
WHERE (comMovpAnexoDetalle.Asiento_Id = @pAsiento_Id)
AND (comMovpAnexoDetalle.Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE comMovpAnexoDetalleEliminar
GO
CREATE PROCEDURE comMovpAnexoDetalleEliminar
(
@pAsiento_Id bigint,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comMovpAnexoDetalle 
WHERE (Asiento_Id = @pAsiento_Id)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
