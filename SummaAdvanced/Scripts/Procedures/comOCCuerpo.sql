DROP PROCEDURE comOCCuerpoGuardar
GO
CREATE PROCEDURE comOCCuerpoGuardar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8,
@pCantidad_Recibida qCantidadD8,
@pCantidad_Embarcada qCantidadD8,
@pCantidad_Facturada qCantidadD8,
@pFecha_Entrega qFecha,
@pPrecio qMonedaD8,
@pPendiente Sino,
@pCantidad_Creditos qCantidadD8,
@pMedida_Id varchar(5) = NULL,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL, 
@pCantidadConsignada qCantidadD8, 
@pObservaciones VarChar(max) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOCCuerpo WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)))
BEGIN 
	UPDATE comOCCuerpo
	SET		Cantidad = @pCantidad,
		Cantidad_Recibida = @pCantidad_Recibida,
		Cantidad_Embarcada = @pCantidad_Embarcada,
		Cantidad_Facturada = @pCantidad_Facturada,
		Fecha_Entrega = @pFecha_Entrega,
		Precio = @pPrecio,
		Pendiente = @pPendiente,
		Cantidad_Creditos = @pCantidad_Creditos,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id), 
		CantidadConsignada = @pCantidadConsignada, 
		Observaciones = @pObservaciones
	WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)
END 
ELSE 
BEGIN 
	INSERT INTO comOCCuerpo
	(
		comOrdenComp,
		Renglon_OC,
		Cantidad,
		Cantidad_Recibida,
		Cantidad_Embarcada,
		Cantidad_Facturada,
		Fecha_Entrega,
		Precio,
		Pendiente,
		Cantidad_Creditos,
		Medida_Id,
		Centro1_Id,
		Centro2_Id,
		CantidadConsignada, 
		Observaciones
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pRenglon_OC,
		@pCantidad,
		@pCantidad_Recibida,
		@pCantidad_Embarcada,
		@pCantidad_Facturada,
		@pFecha_Entrega,
		@pPrecio,
		@pPendiente,
		@pCantidad_Creditos,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id), 
		@pCantidadConsignada, 
		@pObservaciones
	)
END 

GO

DROP PROCEDURE comOCCuerpoDatos
GO
CREATE PROCEDURE comOCCuerpoDatos
(
@pcomOrdenComp int,
@pRenglon_OC int= null
)
AS
SET NOCOUNT ON 

SELECT comOCCuerpo.Renglon_OC, comOCCuerpo.Cantidad, comOCCuerpo.Cantidad_Recibida, comOcCuerpo.Cantidad_Embarcada,
	comOCCuerpo.Cantidad_Facturada, comOCCuerpo.Fecha_Entrega, comOCCuerpo.Precio, comOCCuerpo.Pendiente,
	comOCCuerpo.Cantidad_Creditos, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
		comOCCuerpo.comOrdencomp, comOCCuerpo.CantidadConsignada, 
			comOCCuerpo.Observaciones
FROM comOCCuerpo 
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp)
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOCCuerpo.Medida_Id)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = comOCCuerpo.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = comOCCuerpo.Centro2_Id)
WHERE (comOCCuerpo.comOrdenComp = @pcomOrdenComp)
AND (comOCCuerpo.Renglon_OC = isnull(@pRenglon_OC, comOCCuerpo.Renglon_OC))
ORDER BY 1 
 RETURN @@Error 

GO

DROP PROCEDURE comOCCuerpoEliminar
GO
CREATE PROCEDURE comOCCuerpoEliminar
(
@pcomOrdenComp int,
@pRenglon_OC int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOCCuerpo 
WHERE (comOrdenComp = @pcomOrdenComp)
AND (Renglon_OC = ISNULL(@pRenglon_OC, Renglon_OC))
 
 RETURN @@Error 

GO

DROP PROCEDURE comOCCuerpoRecibir
GO

CREATE PROCEDURE comOCCuerpoRecibir
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
as

UPDATE comOcCuerpo Set Cantidad_Recibida = Cantidad_Recibida + @pCantidad
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC

UPDATE comOcCuerpo Set Pendiente = Case when Cantidad_Recibida >= Cantidad 
	Then 0 else 1 end  
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC 
		
GO


DROP PROCEDURE comOCCuerpoEmbarcar
GO

CREATE PROCEDURE comOCCuerpoEmbarcar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
as

UPDATE comOcCuerpo Set Cantidad_Embarcada = Cantidad_Embarcada + @pCantidad
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC
Go


DROP PROCEDURE comOCCuerpoFacturar
GO

CREATE PROCEDURE comOCCuerpoFacturar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
as

UPDATE comOcCuerpo Set Cantidad_Facturada = Cantidad_Facturada + @pCantidad
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC

GO

DROP PROCEDURE comOCCuerpoCeditos
GO

CREATE PROCEDURE comOCCuerpoCeditos
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
as

UPDATE comOcCuerpo Set Cantidad_Creditos = Cantidad_Creditos + @pCantidad
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC

GO


DROP PROCEDURE comOCCuerpoConsignar
GO

CREATE PROCEDURE comOCCuerpoConsignar
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pCantidad qCantidadD8
)
as

UPDATE comOcCuerpo Set CantidadConsignada = CantidadConsignada + @pCantidad
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC
		
GO


DROP PROCEDURE comOCCuerpoActuPendiente
GO

CREATE PROCEDURE comOCCuerpoActuPendiente
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pPendiente Bit
)
as

UPDATE comOcCuerpo Set Pendiente = @pPendiente
	Where comOrdenComp = @pComOrdenComp And 
		Renglon_OC = @pRenglon_OC
		
GO



DROP PROCEDURE comOCCuerpoActuFecha
GO
CREATE PROCEDURE comOCCuerpoActuFecha
(
@pcomOrdenComp int,
@pRenglon_OC int,
@pFecha_Entrega qFecha
)
AS
	UPDATE comOCCuerpo
	SET Fecha_Entrega = @pFecha_Entrega
	WHERE (comOrdenComp = @pcomOrdenComp) AND (Renglon_OC = @pRenglon_OC)

GO
