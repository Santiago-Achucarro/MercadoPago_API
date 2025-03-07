DROP PROCEDURE comRICuerpoGuardar
GO
CREATE PROCEDURE comRICuerpoGuardar
(
@pcomReqInterno int,
@pRenglon_RI int,
@pFechaNecesidad qFecha,
@pCantidad qCantidadD8,
@pPrecio qMonedaD4,
@pCantidadRecibida qCantidadD8,
@pObservaciones QMemo = NULL,
@pPendiente Sino,
@pCuenta_Id varchar(25) = NULL,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pMedida_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comRICuerpo WHERE (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)))
BEGIN 
	UPDATE comRICuerpo
	SET		FechaNecesidad = @pFechaNecesidad,
		Cantidad = @pCantidad,
		Precio = @pPrecio,
		CantidadRecibida = @pCantidadRecibida,
		Observaciones = @pObservaciones,
		Pendiente = @pPendiente,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id)
	WHERE (comReqInterno = @pcomReqInterno) AND (Renglon_RI = @pRenglon_RI)
END 
ELSE 
BEGIN 
	INSERT INTO comRICuerpo
	(
		comReqInterno,
		Renglon_RI,
		FechaNecesidad,
		Cantidad,
		Precio,
		CantidadRecibida,
		Observaciones,
		Pendiente,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		Medida_Id
	)
	VALUES 
	(
		@pcomReqInterno,
		@pRenglon_RI,
		@pFechaNecesidad,
		@pCantidad,
		@pPrecio,
		@pCantidadRecibida,
		@pObservaciones,
		@pPendiente,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		dbo.FuncFKstkUniMed(@pMedida_Id)
	)
END 

GO
DROP PROCEDURE comRICuerpoDatos
GO
CREATE PROCEDURE comRICuerpoDatos
(
@pcomReqInterno int,
@pRenglon_RI int
)
AS
SET NOCOUNT ON 

SELECT comRICuerpo.Renglon_RI, comRICuerpo.FechaNecesidad, comRICuerpo.Cantidad,
	comRICuerpo.Precio, comRICuerpo.CantidadRecibida, comRICuerpo.Observaciones, comRICuerpo.Pendiente,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed,
	comReqInterno.comReqInterno
FROM comRICuerpo 
INNER JOIN comReqInterno  ON (comReqInterno.comReqInterno = comRICuerpo.comReqInterno)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comRICuerpo.Cuenta_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comRICuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comRICuerpo.Centro2_Id)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comRICuerpo.Medida_Id)
WHERE (comReqInterno.comReqInterno = @pcomReqInterno)
AND (Renglon_RI = @pRenglon_RI)
 
 RETURN @@Error 

GO

DROP PROCEDURE comRICuerpoEliminar
GO
CREATE PROCEDURE comRICuerpoEliminar
(
@pcomReqInterno int,
@pRenglon_RI int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comRICuerpo 
WHERE (comReqInterno = @pcomReqInterno)
AND (Renglon_RI = ISNULL(@pRenglon_RI, Renglon_RI))
 
 RETURN @@Error 

GO

DROP PROCEDURE comRICuerpoRecibir
GO
CREATE PROCEDURE comRICuerpoRecibir
(
@pcomReqInterno int,
@pRenglon_RI int ,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 

Update comRICuerpo  set CantidadRecibida = CantidadRecibida + @pCantidad
WHERE (comReqInterno = @pcomReqInterno)
AND (Renglon_RI = @pRenglon_RI)

Update comRICuerpo  set Pendiente = 
	case when CantidadRecibida >= Cantidad then 0 else 1 end
WHERE (comReqInterno = @pcomReqInterno)
AND (Renglon_RI = @pRenglon_RI)

 
 RETURN @@Error 

GO

