DROP PROCEDURE venFormaEntregaGuardar
GO
CREATE PROCEDURE venFormaEntregaGuardar
(
@pFormaEntrega_id varchar(3),
@pFormaEntrega_id_Nuevo varchar(3),
@pEmpresa_Id int = NULL,
@pRazonSocial varchar(35),
@pDireccion varchar(35),
@pLocalidad varchar(35),
@pProvincia_Id varchar(5) = NULL,
@pPais_Id smallint = NULL,
@pTelefono varchar(35),
@pCuit varchar(25),
@pCondFisc_id varchar(5) = NULL,
@pSeguro money,
@pContacto varchar(20),
@pCargo varchar(20),
@pEmail varchar(80) = NULL,
@pExcluirDelReparto bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pUsaCartaPorte Bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venFormaEntrega WHERE (FormaEntrega_id = @pFormaEntrega_id)))
BEGIN 
	UPDATE venFormaEntrega
	SET		@lIdentidad = venFormaEntrega,
		FormaEntrega_id = @pFormaEntrega_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		RazonSocial = @pRazonSocial,
		Direccion = @pDireccion,
		Localidad = @pLocalidad,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		Pais_Id = dbo.FuncFKgenPaises(@pPais_Id),
		Telefono = @pTelefono,
		Cuit = @pCuit,
		CondFisc_id = dbo.FuncFKcomCondFiscal(@pCondFisc_id),
		Seguro = @pSeguro,
		Contacto = @pContacto,
		Cargo = @pCargo,
		Email = @pEmail,
		ExcluirDelReparto = @pExcluirDelReparto,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		UsaCartaPorte = @pUsaCartaPorte
	WHERE (FormaEntrega_id = @pFormaEntrega_id)
END 
ELSE 
BEGIN 
	INSERT INTO venFormaEntrega
	(
		FormaEntrega_id,
		Empresa_Id,
		RazonSocial,
		Direccion,
		Localidad,
		Provincia_Id,
		Pais_Id,
		Telefono,
		Cuit,
		CondFisc_id,
		Seguro,
		Contacto,
		Cargo,
		Email,
		ExcluirDelReparto,
		Inactivo,
		Usuario_Id,
		Posteado, 
		UsaCartaPorte

	)
	VALUES 
	(
		@pFormaEntrega_id,
		@pEmpresa_Id,
		@pRazonSocial,
		@pDireccion,
		@pLocalidad,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		dbo.FuncFKgenPaises(@pPais_Id),
		@pTelefono,
		@pCuit,
		dbo.FuncFKcomCondFiscal(@pCondFisc_id),
		@pSeguro,
		@pContacto,
		@pCargo,
		@pEmail,
		@pExcluirDelReparto,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pUsaCartaPorte
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venFormaEntregaDatos
GO
CREATE PROCEDURE venFormaEntregaDatos
(
@pFormaEntrega_id varchar(3)
)
AS
SET NOCOUNT ON 

SELECT venFormaEntrega.venFormaEntrega, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.Empresa_Id, Cast( Case When venFormaEntrega.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venFormaEntrega.RazonSocial, venFormaEntrega.Direccion, venFormaEntrega.Localidad, genProvincias.Provincia_Id,
	genProvincias.Descripcion as DescripcionProvincias, genPaises.Pais_Id, genPaises.Descripcion as DescripcionPaises, venFormaEntrega.Telefono,
	venFormaEntrega.Cuit, comCondFiscal.CondFiscal_Id CondFisc_Id, comCondFiscal.Descripcion as DescripcionCondFiscal, venFormaEntrega.Seguro,
	venFormaEntrega.Contacto, venFormaEntrega.Cargo, venFormaEntrega.Email, venFormaEntrega.ExcluirDelReparto,
	venFormaEntrega.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venFormaEntrega.Posteado, venFormaEntrega.UsaCartaPorte
FROM venFormaEntrega 
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = venFormaEntrega.Provincia_Id)
LEFT JOIN genPaises  ON (genPaises.genPaises = venFormaEntrega.Pais_Id)
LEFT JOIN comCondFiscal  ON (comCondFiscal.comCondFiscal = venFormaEntrega.CondFisc_id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venFormaEntrega.Usuario_Id)
WHERE (FormaEntrega_id = @pFormaEntrega_id)
 


  Declare @pidentity bigint= dbo.FuncFKvenFormaEntrega(@pFormaEntrega_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venFormaEntrega'
 RETURN @@Error 

GO

DROP PROCEDURE venFormaEntregaEliminar
GO
CREATE PROCEDURE venFormaEntregaEliminar
(
@pFormaEntrega_id varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venFormaEntrega 
WHERE (FormaEntrega_id = @pFormaEntrega_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenFormaEntrega
GO

CREATE FUNCTION FuncFKvenFormaEntrega
(
@pFormaEntrega_id varchar (3)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venFormaEntrega FROM venFormaEntrega WHERE 
	FormaEntrega_id = @pFormaEntrega_id
  RETURN @pIdentity
END


GO
