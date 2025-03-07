DROP PROCEDURE tesMoviOficialGuardar	
GO
CREATE PROCEDURE tesMoviOficialGuardar
(
@ptesMovimientos bigint,
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesMoviOficial WHERE (tesMovimientos = @ptesMovimientos)))
BEGIN 
	UPDATE tesMoviOficial
	SET Sucursal_Of = @pSucursal_Of,
	Comprobante_Of = @pComprobante_Of
	WHERE (tesMovimientos = @ptesMovimientos) 
END 
ELSE 
BEGIN 
	INSERT INTO tesMoviOficial
	(
		tesMovimientos,
		Sucursal_Of,
		Comprobante_Of
	)
	VALUES 
	(
		@ptesMovimientos,
		@pSucursal_Of,
		@pComprobante_Of
	)
END 
GO

DROP PROCEDURE tesMoviOficialDatos
GO
CREATE PROCEDURE tesMoviOficialDatos
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

SELECT tesMoviOficial.Sucursal_Of, tesMoviOficial.Comprobante_Of,
	tesMoviOficial.tesMovimientos
FROM tesMoviOficial 
WHERE tesMoviOficial.Sucursal_Of = @pSucursal_Of
AND tesMoviOficial.Comprobante_Of = @pComprobante_Of

RETURN @@Error 
GO



DROP PROCEDURE tesMoviOficialEliminar
GO
CREATE PROCEDURE tesMoviOficialEliminar
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

DELETE FROM tesMoviOficial
WHERE Sucursal_Of = @pSucursal_Of AND
Comprobante_Of = @pComprobante_Of
 
RETURN @@Error 
GO


DROP PROCEDURE tesMoviOficialValidar
GO
CREATE PROCEDURE tesMoviOficialValidar
(  
@pSucursal Sucursal,  
@pDesde int
)  
AS  
SET NOCOUNT ON   
SELECT Sucursal_of Sucursal, Comprobante_of Desde, 0 Hasta 
FROM tesMoviOficial
WHERE Sucursal_Of = @pSucursal AND
Comprobante_Of = @pDesde 
GO







