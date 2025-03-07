DROP PROCEDURE venCobradoresGuardar
GO
CREATE PROCEDURE venCobradoresGuardar
(
@pvenCobradores bigint,
@pCobrador_Id varchar(5),
@pCobrador_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pNombre varchar(35),
@pComision numeric(5),
@pLimiteComision numeric(9),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCobradores WHERE (venCobradores = @pvenCobradores)))
BEGIN 
	UPDATE venCobradores
	SET		Cobrador_Id = @pCobrador_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Nombre = @pNombre,
		Comision = @pComision,
		LimiteComision = @pLimiteComision,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (venCobradores = @pvenCobradores)
END 
ELSE 
BEGIN 
	INSERT INTO venCobradores
	(
		venCobradores,
		Cobrador_Id,
		Empresa_Id,
		Nombre,
		Comision,
		LimiteComision,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pvenCobradores,
		@pCobrador_Id_Nuevo,
		@pEmpresa_Id,
		@pNombre,
		@pComision,
		@pLimiteComision,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
END 

GO

DROP PROCEDURE venCobradoresDatos
GO
CREATE PROCEDURE venCobradoresDatos
(
@pCobrador_id varchar (5)
)
AS
SET NOCOUNT ON 

SELECT venCobradores.venCobradores, genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal,
	venCobradores.Cobrador_Id, venCobradores.Empresa_Id, Cast( Case When venCobradores.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venCobradores.Nombre, venCobradores.Comision, venCobradores.LimiteComision,
IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
IsNull(venVendedores.Vendedor_Id, '') Vendedor_Id, IsNull(venVendedores.Nombre, '') VenNombre,
IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre,
	venCobradores.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCobradores.Posteado
FROM venCobradores 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCobradores.Usuario_Id)
INNER JOIN genEntidades ON genEntidades.genEntidades = venCobradores.venCobradores
 Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
 Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
 Left Outer Join venVendedores On venVendedores.venVendedores = genEntidades.genEntidades
 Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades

WHERE (venCobradores.Cobrador_Id = @pCobrador_Id)

 Declare @pidentity bigint= dbo.FuncFKvenCobradores(@pCobrador_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCobradores'
 RETURN @@Error 

GO

DROP PROCEDURE venCobradoresDatosId
GO
CREATE PROCEDURE venCobradoresDatosId
(
@pIdentity bigint
)
AS
SET NOCOUNT ON 

SELECT venCobradores.venCobradores, genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal,
	venCobradores.Cobrador_Id, venCobradores.Empresa_Id, Cast( Case When venCobradores.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venCobradores.Nombre, venCobradores.Comision, venCobradores.LimiteComision,
IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
IsNull(venVendedores.Vendedor_Id, '') Vendedor_Id, IsNull(venVendedores.Nombre, '') VenNombre,
IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre,
	venCobradores.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCobradores.Posteado
FROM venCobradores 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCobradores.Usuario_Id)
INNER JOIN genEntidades ON genEntidades.genEntidades = venCobradores.venCobradores
 Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
 Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
 Left Outer Join venVendedores On venVendedores.venVendedores = genEntidades.genEntidades
 Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades
WHERE venCobradores.venCobradores = @pIdentity

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCobradores'
RETURN @@Error 

GO

DROP PROCEDURE venCobradoresEliminar
GO
CREATE PROCEDURE venCobradoresEliminar
(
@pCobrador_Id VarChar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM venCobradores 
WHERE Cobrador_Id = @pCobrador_Id
 
 RETURN @@Error 

GO

GO
DROP FUNCTION FuncFKvenCobradores
GO

CREATE FUNCTION FuncFKvenCobradores
(
@pCobrador_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venCobradores FROM venCobradores WHERE 
	Cobrador_Id = @pCobrador_Id
  RETURN @pIdentity
END


GO
