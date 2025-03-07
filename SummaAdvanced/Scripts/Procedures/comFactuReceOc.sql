DROP PROCEDURE comFactuReceOcGuardar
GO
CREATE PROCEDURE comFactuReceOcGuardar
(
@pcomMovProv bigint,
@pcomOrdenComp int,
@pRenglon_OC int,
@pcomOcRecepcion bigint,
@pconRenglon int,
@pCantidad qCantidadD8
)
AS
SET NOCOUNT ON 

	INSERT INTO comFactuReceOc
	(
		comMovProv,
		comOrdenComp,
		Renglon_OC,
		comOcRecepcion,
		conRenglon,
		Cantidad
	)
	VALUES 
	(
		@pcomMovProv,
		@pcomOrdenComp,
		@pRenglon_OC,
		@pcomOcRecepcion,
		@pconRenglon,
		@pCantidad
	)

GO

DROP PROCEDURE comFactuReceOcDatos
GO
CREATE PROCEDURE comFactuReceOcDatos
(
@pcomMovProv bigint
)
AS
SET NOCOUNT ON

Select @pcomMovProv comMovProv, 0 comOrdenComp, 0 Renglon_OC

SELECT 0 Renglon_OC, comFactuReceOc.comOcRecepcion, comFactuReceOc.conRenglon, comFactuReceOc.Cantidad, conAsientos.Cambio
FROM comFactuReceOc 
INNER JOIN comMovPOC  ON comMovPOC.comMovProv = comFactuReceOc.comMovProv AND comMovPOC.comOrdenComp = comFactuReceOc.comOrdenComp AND 
	comMovPOC.Renglon_OC = comFactuReceOc.Renglon_OC
INNER JOIN comOcReceCuerpo  ON comOcReceCuerpo.comOcRecepcion = comFactuReceOc.comOcRecepcion AND comOcReceCuerpo.conRenglon = comFactuReceOc.conRenglon
Inner Join conAsientos On conAsientos.conAsientos = comOcReceCuerpo.comOcRecepcion
WHERE comFactuReceOc.comMovProv = @pcomMovProv
 
RETURN @@Error 

GO

DROP PROCEDURE comFactuReceOcEliminar
GO
CREATE PROCEDURE comFactuReceOcEliminar
(
@pcomMovProv bigint,
@pcomOrdenComp int = Null,
@pRenglon_OC int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comFactuReceOc 
WHERE comMovProv = @pcomMovProv And
comFactuReceOc.comOrdenComp = IsNull(@pcomOrdenComp, comFactuReceOc.comOrdenComp)
AND comFactuReceOc.Renglon_OC = IsNull(@pRenglon_OC, comFactuReceOc.Renglon_OC)
 
 RETURN @@Error 

GO


DROP PROCEDURE comFactuReceOcCalcularPendiente
GO
CREATE PROCEDURE comFactuReceOcCalcularPendiente
(
@pcomOrdenComp int,
@pRenglon_OC int
)
AS
SET NOCOUNT ON 

Select Cast(0 As bigint) comMovProv, @pcomOrdenComp comOrdenComp, @pRenglon_OC Renglon_OC

SELECT @pRenglon_OC Renglon_OC, comOcReceCuerpo.comOcRecepcion, comOcReceCuerpo.conRenglon, comOcReceCuerpo.CantFactPendiente Cantidad, conAsientos.Cambio
FROM comOcReceCuerpo
Inner Join conAsientos On conAsientos.conAsientos = comOcReceCuerpo.comOcRecepcion
WHERE comOcReceCuerpo.comOrdenComp = @pcomOrdenComp
AND comOcReceCuerpo.Renglon_OC = @pRenglon_OC

RETURN @@Error 

GO