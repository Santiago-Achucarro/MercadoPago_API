DROP PROCEDURE tesTalonariosGuardar
GO
CREATE PROCEDURE tesTalonariosGuardar
(
@pSucursal Sucursal,
@pDesde int,
@pHasta int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesTalonarios WHERE (Sucursal = @pSucursal) AND (Desde = @pDesde)))
BEGIN 
	UPDATE tesTalonarios
	SET Hasta = @pHasta
	WHERE (Sucursal = @pSucursal) AND (Desde = @pDesde)
END 
ELSE 
BEGIN 
	INSERT INTO tesTalonarios
	(
		Sucursal,
		Desde,
		Hasta
	)
	VALUES 
	(
		@pSucursal,
		@pDesde,
		@pHasta
	)
END 

GO

DROP PROCEDURE tesTalonariosDatos
GO
CREATE PROCEDURE tesTalonariosDatos
(
@pSucursal Sucursal,
@pDesde int
)
AS
SET NOCOUNT ON 

SELECT tesTalonarios.Sucursal, tesTalonarios.Desde,
	tesTalonarios.Hasta
FROM tesTalonarios 
WHERE tesTalonarios.Sucursal = @pSucursal
AND tesTalonarios.Desde = @pDesde

RETURN @@Error 
GO

DROP PROCEDURE tesTalonariosEliminar
GO
CREATE PROCEDURE tesTalonariosEliminar
(
@pSucursal Sucursal,
@pDesde int
)
AS
SET NOCOUNT ON 

DELETE FROM tesTalonarios
WHERE Sucursal = @pSucursal AND
Desde = @pDesde
 
RETURN @@Error 
GO


DROP PROCEDURE tesTalonariosVerifica
GO
CREATE PROCEDURE tesTalonariosVerifica  
(  
@pSucursal Sucursal,  
@pDesde int,  
@pHasta int  
)  
AS  
SET NOCOUNT ON   
SELECT Sucursal, Desde, Hasta FROM tesTalonarios   
WHERE Sucursal = @pSucursal AND   
  (Desde <> @pDesde or Hasta <> @pHasta ) and   
 ((@pDesde>=Desde  AND @pDesde<=Hasta) OR  
 (@pHasta>=Desde  AND @pHasta<=Hasta)) 
GO


DROP PROCEDURE  tesTalonariosVeriCobra
GO
CREATE PROCEDURE tesTalonariosVeriCobra  
(  
@pSucursal Sucursal,  
@pDesde int
)  
AS  
SET NOCOUNT ON   
SELECT Sucursal, Desde, 0 Hasta FROM tesTalonCobrador
WHERE Sucursal = @pSucursal AND   
  Desde = @pDesde
GO


DROP PROCEDURE  tesTalonariosVeriComp
GO
CREATE PROCEDURE tesTalonariosVeriComp  
(  
@pSucursal Sucursal,  
@pDesde int
)  
AS  
SET NOCOUNT ON   
SELECT Sucursal, Desde, 0 Hasta FROM tesTalonarios  
WHERE tesTalonarios.Sucursal = @pSucursal AND
tesTalonarios.Desde <= @pDesde AND 
tesTalonarios.Hasta >= @pDesde
GO


