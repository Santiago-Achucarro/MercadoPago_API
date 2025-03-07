DROP PROCEDURE espvenClieContactoKSKGuardar
GO
CREATE PROCEDURE espvenClieContactoKSKGuardar
(
@pCliente_Id bigint,
@pSucursal SucursalN,
@pNroContacto int,
@pInstragram varchar(120) = NULL,
@pFacebook varchar(120) = NULL,
@pLinkedin varchar(120) = NULL,
@pYoutube varchar(120) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espvenClieContactoKSK WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal) AND (NroContacto = @pNroContacto)))
BEGIN 
	UPDATE espvenClieContactoKSK
	SET		Instragram = @pInstragram,
		Facebook = @pFacebook,
		Linkedin = @pLinkedin,
		Youtube = @pYoutube
	WHERE (Cliente_Id = @pCliente_Id) AND (Sucursal = @pSucursal) AND (NroContacto = @pNroContacto)
END 
ELSE 
BEGIN 
	INSERT INTO espvenClieContactoKSK
	(
		Cliente_Id,
		Sucursal,
		NroContacto,
		Instragram,
		Facebook,
		Linkedin,
		Youtube
	)
	VALUES 
	(
		@pCliente_Id,
		@pSucursal,
		@pNroContacto,
		@pInstragram,
		@pFacebook,
		@pLinkedin,
		@pYoutube
	)
END 

GO

DROP PROCEDURE espvenClieContactoKSKDatos
GO
CREATE PROCEDURE espvenClieContactoKSKDatos
(
@pCliente_Id bigint,
@pSucursal SucursalN,
@pNroContacto int
)
AS
SET NOCOUNT ON 

SELECT espvenClieContactoKSK.Cliente_Id, espvenClieContactoKSK.Sucursal, espvenClieContactoKSK.NroContacto,
	espvenClieContactoKSK.Instragram, espvenClieContactoKSK.Facebook, espvenClieContactoKSK.Linkedin, espvenClieContactoKSK.Youtube
FROM espvenClieContactoKSK 
INNER JOIN venClieContacto A  ON (A.Cliente_Id = espvenClieContactoKSK.Cliente_Id) AND (A.Sucursal = espvenClieContactoKSK.Sucursal) AND (A.NroContacto = espvenClieContactoKSK.NroContacto)
WHERE (A.Cliente_Id = @pCliente_Id)
AND (A.Sucursal = @pSucursal)
AND (A.NroContacto = @pNroContacto)
 
RETURN @@Error 

GO

DROP PROCEDURE espvenClieContactoKSKEliminar
GO
CREATE PROCEDURE espvenClieContactoKSKEliminar
(
@pCliente_Id bigint,
@pSucursal SucursalN,
@pNroContacto int
)
AS
SET NOCOUNT ON 

DELETE FROM espvenClieContactoKSK 
WHERE (Cliente_Id = @pCliente_Id)
AND (Sucursal = @pSucursal)
AND (NroContacto = @pNroContacto)
 
 RETURN @@Error 

GO

GO
