DROP PROCEDURE tesTalonCobradorGuardar
GO
CREATE PROCEDURE tesTalonCobradorGuardar
(
@pSucursal Sucursal,
@pDesde int,
@pCobrador bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesTalonCobrador WHERE (Sucursal = @pSucursal) AND (Desde = @pDesde)))
BEGIN 
	UPDATE tesTalonCobrador
	SET Cobrador_id = @pCobrador
	WHERE (Sucursal = @pSucursal) AND (Desde = @pDesde)
END 
ELSE 
BEGIN 
	INSERT INTO tesTalonCobrador
	(
		Sucursal,
		Desde,
		Cobrador_Id
	)
	VALUES 
	(
		@pSucursal,
		@pDesde,
		@pCobrador
	)
END 
GO

DROP PROCEDURE tesTalonCobradorDatos
GO
CREATE PROCEDURE tesTalonCobradorDatos
(
@pSucursal Sucursal,
@pDesde int
)
AS
SET NOCOUNT ON 

SELECT tesTalonarios.Sucursal, tesTalonarios.Desde,
	ISNULL(venCobradores.venCobradores,0) venCobradores, 
	ISNULL(venCobradores.Cobrador_Id,'') Cobrador_Id, 
	ISNULL(venCobradores.Nombre,'') Descripcion
FROM tesTalonarios 
LEFT JOIN tesTalonCobrador ON tesTalonarios.Sucursal = tesTalonCobrador.Sucursal AND
	tesTalonarios.Desde = tesTalonCobrador.Desde
LEFT JOIN venCobradores ON tesTalonCobrador.Cobrador_Id = venCobradores.venCobradores
WHERE tesTalonarios.Sucursal = @pSucursal
AND tesTalonarios.Desde = @pDesde

RETURN @@Error 
GO


DROP PROCEDURE tesTalonCobradorVeriCobrador
GO
CREATE PROCEDURE tesTalonCobradorVeriCobrador  
(  
@pSucursal Sucursal,  
@pDesde int,
@pCobrador bigint
)  
AS  
SET NOCOUNT ON   
SELECT tesTalonarios.Sucursal, 
tesTalonarios.Desde, 0 Hasta 
FROM tesTalonarios 
INNER JOIN tesTalonCobrador ON
tesTalonarios.Sucursal = tesTalonCobrador.Sucursal AND
tesTalonarios.Desde = tesTalonCobrador.Desde
WHERE tesTalonarios.Sucursal = @pSucursal AND
tesTalonarios.Desde <= @pDesde AND 
tesTalonarios.Hasta >= @pDesde AND
tesTalonCobrador.Cobrador_Id = @pCobrador
GO




