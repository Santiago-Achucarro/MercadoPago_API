DROP PROCEDURE tesRecOfiAnulGuardar
GO
CREATE PROCEDURE tesRecOfiAnulGuardar
(
@pSucursal_Of Sucursal,
@pComprobante_Of int,
@pFechaAnulacion [QFecha],
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesRecOfiAnul WHERE (Sucursal_Of = @pSucursal_Of) AND (Comprobante_Of = @pComprobante_Of)))
BEGIN 
	UPDATE tesRecOfiAnul
	SET FechaAnulacion = @pFechaAnulacion, Usuario_Id = @pUsuario_Id
	WHERE (Sucursal_Of = @pSucursal_Of) AND (Comprobante_Of = @pComprobante_Of)
END 
ELSE 
BEGIN 
	INSERT INTO tesRecOfiAnul
	(
		Sucursal_Of,
		Comprobante_Of,
		FechaAnulacion,
		Usuario_Id
	)
	VALUES 
	(
		@pSucursal_Of,
		@pComprobante_Of,
		@pFechaAnulacion,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE tesRecOfiAnulDatos
GO
CREATE PROCEDURE tesRecOfiAnulDatos
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

SELECT tesRecOfiAnul.Sucursal_Of, tesRecOfiAnul.Comprobante_Of,
tesRecOfiAnul.FechaAnulacion, genUsuarios.genUsuarios, genUsuarios.Usuario_Id,
genUsuarios.Apellido_y_Nombres Descripcion
FROM tesRecOfiAnul 
INNER JOIN genUsuarios ON tesRecOfiAnul.Usuario_Id = genUsuarios.genUsuarios
WHERE Sucursal_Of = @pSucursal_Of AND 
Comprobante_Of = @pComprobante_Of

RETURN @@Error 
GO


DROP PROCEDURE tesRecOfiAnulEliminar
GO
CREATE PROCEDURE tesRecOfiAnulEliminar
(
@pSucursal_Of Sucursal,
@pComprobante_Of int
)
AS
SET NOCOUNT ON 

DELETE FROM tesRecOfiAnul
WHERE Sucursal_Of = @pSucursal_Of AND 
Comprobante_Of = @pComprobante_Of

RETURN @@Error 
GO


DROP PROCEDURE  tesRecOfiAnulVerifica
GO
CREATE PROCEDURE tesRecOfiAnulVerifica  
(  
@pSucursal_Of Sucursal,
@pComprobante_Of int  
)  
AS  
SET NOCOUNT ON   
SELECT Sucursal_Of Sucursal, Comprobante_Of Desde, 0 Hasta 
FROM tesRecOfiAnul
WHERE Sucursal_Of = @pSucursal_Of AND 
Comprobante_Of = @pComprobante_Of
GO


DROP PROCEDURE  tesRecOfiAnulControlComp
GO
CREATE PROCEDURE tesRecOfiAnulControlComp  
(  
@pSucursal_Of Sucursal,
@pComprobante_Of int  
)  
AS  
SET NOCOUNT ON   
SELECT Sucursal_Of Sucursal, Comprobante_Of Desde, 0 Hasta 
FROM tesMoviOficial 
WHERE Sucursal_Of = @pSucursal_Of AND 
Comprobante_Of = @pComprobante_Of AND
NOT EXISTS (SELECT 1 FROM conAsientosAnul 
WHERE tesMoviOficial.tesMovimientos = conAsientosAnul.Asiento_Id)
GO

