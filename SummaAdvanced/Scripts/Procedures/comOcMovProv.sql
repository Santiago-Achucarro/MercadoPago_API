DROP PROCEDURE comOcMovProvGuardar
GO
CREATE PROCEDURE comOcMovProvGuardar
(
@pcomOrdenComp int,
@pcomMovProv bigint,
@pAnticipoNC Sino,
@pImporte qMonedaD2,
@pPorcentaje qPorcentaje,
@pDadoRestado Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOcMovProv WHERE (comOrdenComp = @pcomOrdenComp) AND (comMovProv = @pcomMovProv) AND (AnticipoNC = @pAnticipoNC)))
BEGIN 
	UPDATE comOcMovProv
	SET		Importe = @pImporte,
		Porcentaje = @pPorcentaje,
		DadoRestado = @pDadoRestado
	WHERE (comOrdenComp = @pcomOrdenComp) AND (comMovProv = @pcomMovProv) AND (AnticipoNC = @pAnticipoNC)
END 
ELSE 
BEGIN 
	INSERT INTO comOcMovProv
	(
		comOrdenComp,
		comMovProv,
		AnticipoNC,
		Importe,
		Porcentaje,
		DadoRestado
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pcomMovProv,
		@pAnticipoNC,
		@pImporte,
		@pPorcentaje,
		@pDadoRestado
	)
END 

GO

DROP PROCEDURE comOcMovProvDatos
GO
CREATE PROCEDURE comOcMovProvDatos
(
@pcomOrdenComp int,
@pcomMovProv bigint,
@pAnticipoNC Sino
)
AS
SET NOCOUNT ON 

SELECT comOcMovProv.comOrdenComp,
	comOcMovProv.comMovProv,	comOcMovProv.AnticipoNC, comOcMovProv.Importe,
	comOcMovProv.Porcentaje, comOcMovProv.DadoRestado
FROM comOcMovProv 
WHERE (comOcMovProv.comOrdenComp = @pcomOrdenComp)
AND (comOcMovProv.comMovProv = @pcomMovProv)
AND (comOcMovProv.AnticipoNC = @pAnticipoNC)
 
 RETURN @@Error 

GO

DROP PROCEDURE comOcMovProvEliminar
GO
CREATE PROCEDURE comOcMovProvEliminar
(
@pcomOrdenComp int,
@pcomMovProv bigint,
@pAnticipoNC Sino = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOcMovProv 
WHERE (comOrdenComp = @pcomOrdenComp)
AND (comMovProv = @pcomMovProv)
AND (AnticipoNC = ISNULL(@pAnticipoNC, AnticipoNC))
 
 RETURN @@Error 

GO

GO
