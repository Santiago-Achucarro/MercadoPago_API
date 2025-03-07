DROP PROCEDURE espvenClieHabitualKSKGuardar
GO
CREATE PROCEDURE espvenClieHabitualKSKGuardar
(
@pCliente_Id bigint,
@pSucursal SucursalN,
@pCelular varchar(35),
@pMes int,
@pDia int,
@pInstagram varchar(50),
@pYoutube varchar(50),
@pLinkedin varchar(50),
@pFacebook varchar(50)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espvenClieHabitualKSK WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal)))
BEGIN 
	UPDATE espvenClieHabitualKSK
	SET		Celular = @pCelular,
		Mes = @pMes,
		Dia = @pDia,
		Instagram = @pInstagram,
		Youtube = @pYoutube,
		Linkedin = @pLinkedin,
		Facebook = @pFacebook
	WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal)
END 
ELSE 
BEGIN 
	INSERT INTO espvenClieHabitualKSK
	(
		Cliente_Id,
		Sucursal,
		Celular,
		Mes,
		Dia,
		Instagram,
		Youtube,
		Linkedin,
		Facebook
	)
	VALUES 
	(
		@pCliente_Id,
		@pSucursal,
		@pCelular,
		@pMes,
		@pDia,
		@pInstagram,
		@pYoutube,
		@pLinkedin,
		@pFacebook
	)
END 

GO

DROP PROCEDURE espvenClieHabitualKSKDatos
GO
CREATE PROCEDURE espvenClieHabitualKSKDatos
(
@pCliente_Id bigint,
@pSucursal SucursalN
)
AS
SET NOCOUNT ON 

SELECT espvenClieHabitualKSK.Celular,
	espvenClieHabitualKSK.Mes, espvenClieHabitualKSK.Dia, espvenClieHabitualKSK.Instagram, espvenClieHabitualKSK.Youtube,
	espvenClieHabitualKSK.Linkedin, espvenClieHabitualKSK.Facebook
FROM espvenClieHabitualKSK 
INNER JOIN venClieHabitual  ON (venClieHabitual.genEntidades = espvenClieHabitualKSK.Cliente_Id) AND (venClieHabitual.Sucursal = espvenClieHabitualKSK.Sucursal)
WHERE (Cliente_Id = @pCliente_Id)
AND (espvenClieHabitualKSK.Sucursal = @pSucursal)
 
RETURN @@Error 

GO

DROP PROCEDURE espvenClieHabitualKSKEliminar
GO
CREATE PROCEDURE espvenClieHabitualKSKEliminar
(
@pCliente_Id bigint,
@pSucursal SucursalN
)
AS
SET NOCOUNT ON 

DELETE FROM espvenClieHabitualKSK 
WHERE (Cliente_Id = @pCliente_Id)
AND (Sucursal = @pSucursal)
 
 RETURN @@Error 

GO

GO
