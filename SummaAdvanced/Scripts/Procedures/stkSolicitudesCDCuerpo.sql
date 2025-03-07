DROP PROCEDURE stkSolicitudCDCuerpoGuardar
GO
CREATE PROCEDURE stkSolicitudCDCuerpoGuardar
(
@pstkSolicitudCD bigint,
@pRenglon Int ,
@pProducto_Id varchar(25) = NULL,
@pDepositoOrigen varchar(15) = NULL,
@pObservaciones varchar(max) = NULL,
@pCantidad qCantidadD8,
@pCantidadPendiente qCantidadD8,
@pMedida_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkSolicitudCDCuerpo WHERE (stkSolicitudCD = @pstkSolicitudCD and Renglon = @pRenglon)))
BEGIN 
	UPDATE stkSolicitudCDCuerpo
	SET		Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id),
		DepositoOrigen = dbo.FuncFKstkDepositos(@pDepositoOrigen),
		Observaciones = @pObservaciones,
		Cantidad = @pCantidad,
		CantidadPendiente = @pCantidadPendiente,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id)
	WHERE (stkSolicitudCD = @pstkSolicitudCD and 
		Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO stkSolicitudCDCuerpo
	(
		stkSolicitudCD,
		Renglon,
		Producto_Id,
		DepositoOrigen,
		Observaciones,
		Cantidad,
		CantidadPendiente,
		Medida_Id
	)
	VALUES 
	(
		@pstkSolicitudCD,
		@pRenglon,
		dbo.FuncFKstkProductos(@pProducto_Id),
		dbo.FuncFKstkDepositos(@pDepositoOrigen),
		@pObservaciones,
		@pCantidad,
		@pCantidadPendiente,
		dbo.FuncFKstkUniMed(@pMedida_Id)
	)
END 

GO

DROP PROCEDURE stkSolicitudCDCuerpoEliminar
GO
CREATE PROCEDURE stkSolicitudCDCuerpoEliminar
(
@pstkSolicitudCD bigint ,
@pRenglon INT = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkSolicitudCDCuerpo 
WHERE 
	stkSolicitudCD = @pstkSolicitudCD AND 
	Renglon = ISNULL(@pRenglon, Renglon)
 
 RETURN @@Error 

GO


