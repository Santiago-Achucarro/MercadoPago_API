DROP PROCEDURE espvenClieHabitualKSKGuardar
GO
CREATE PROCEDURE espvenClieHabitualKSKGuardar
(
@pCliente_Id bigint,
@pSucursal int,
@pCelular Varchar(35),
@pMes int,
@pDia int,
@pInstagram Varchar(50),
@pYoutube Varchar(50),
@pLinkedin Varchar(50),
@pFacebook Varchar(50)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espvenClieHabitualKSK WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal)))
BEGIN 
	UPDATE espvenClieHabitualKSK
	SET	Celular = @pCelular, 
		Mes = @pMes, 
		Dia = @pDia,
		Instagram = @pInstagram,
		YouTube = @pYoutube,
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
		YouTube,
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



DROP PROCEDURE espvenClieHabitualKSKEliminar
GO
CREATE PROCEDURE espvenClieHabitualKSKEliminar
(
@pCliente_Id bigint,
@pSucursal int
)
AS
SET NOCOUNT ON 

DELETE FROM espvenClieHabitualKSK 
WHERE (Cliente_Id = @pCliente_Id)
AND (Sucursal = @pSucursal)
 
RETURN @@Error 
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

Declare @pidentity bigint= dbo.FuncFKvenClientes(@pCliente_Id)

SELECT ISNULL(espvenClieHabitualKSK.Celular,'') Celular, ISNULL(espvenClieHabitualKSK.Mes,0) Mes,
ISNULL(espvenClieHabitualKSK.Dia,0) Dia, ISNULL(espvenClieHabitualKSK.Instagram,'') Instagram,
ISNULL(espvenClieHabitualKSK.Youtube,'') Youtube, ISNULL(espvenClieHabitualKSK.Linkedin,'') Linkedin,
ISNULL(espvenClieHabitualKSK.Facebook,'') Facebook
FROM venClieHabitual 
LEFT JOIN espvenClieHabitualKSK	ON venClieHabitual.genEntidades = espvenClieHabitualKSK.Cliente_Id AND
	espvenClieHabitualKSK.Sucursal = venClieHabitual.Sucursal 
WHERE (venClieHabitual.genEntidades = @pidentity)
AND (venClieHabitual.Sucursal = @pSucursal)

 
RETURN @@Error 
GO
