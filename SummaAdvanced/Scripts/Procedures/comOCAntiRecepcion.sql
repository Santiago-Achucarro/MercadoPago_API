DROP PROCEDURE comOCAntiRecepcionInsertar
GO
CREATE PROCEDURE comOCAntiRecepcionInsertar
(
@pcomAntiRecepcion bigint,
@pcomOcRecepcion bigint = NULL
)
AS
SET NOCOUNT ON 
	INSERT INTO comOCAntiRecepcion
	(
		comAntiRecepcion,
		comOcRecepcion
	)
	VALUES 
	(
		@pcomAntiRecepcion,
		@pcomOcRecepcion
	)

GO

DROP PROCEDURE comOCAntiRecepcionDatos
GO
CREATE PROCEDURE comOCAntiRecepcionDatos
(
@pcomAntiRecepcion bigint
)
AS
SET NOCOUNT ON 

SELECT comOCAntiRecepcion.comAntiRecepcion, comOCAntiRecepcion.comOcRecepcion
FROM comOCAntiRecepcion 
WHERE (comAntiRecepcion = @pcomAntiRecepcion)
 
RETURN @@Error 

GO

DROP PROCEDURE comOCAntiRecepcionEliminar
GO
CREATE PROCEDURE comOCAntiRecepcionEliminar
(
@pcomAntiRecepcion bigint 
)
AS
SET NOCOUNT ON 

DELETE FROM comOCAntiRecepcion 
WHERE comAntiRecepcion = @pcomAntiRecepcion
 
RETURN @@Error 

GO

GO
