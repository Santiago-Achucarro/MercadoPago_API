DROP PROCEDURE venVendedoresGuardar
GO
CREATE PROCEDURE venVendedoresGuardar
(
@pvenVendedores bigint,
@pVendedor_Id varchar(5),
@pVendedor_Id_Nueva varchar(5),
@pEmpresa_Id int = NULL,
@pNombre varchar(35),
@pComision numeric(5,2),
@pComisionxSuperv numeric(5,2),
@pSupervisor_Id varChar(5)=null,
@pPisoDeVentas numeric(18,2),
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pFacturaCobrada bit,
@pConAnticipos bit,
@pSinImpuestos bit,
@pInactivo bit,
@pUsuario varChar(25)=null,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venVendedores WHERE (venVendedores = @pvenVendedores)))
BEGIN 
	UPDATE venVendedores
	SET		Vendedor_id = @pVendedor_Id_Nueva,
		Empresa_Id = @pEmpresa_Id,
		Nombre = @pNombre,
		Comision = @pComision,
		ComisionxSuperv = @pComisionxSuperv,
		Supervisor_Id = dbo.FuncFKVenVendedores(@pSupervisor_Id),
		PisoDeVentas = @pPisoDeVentas,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		FacturaCobrada = @pFacturaCobrada,
		ConAnticipos = @pConAnticipos,
		SinImpuestos = @pSinImpuestos,
		Inactivo = @pInactivo,
		Usuario = dbo.FuncFKgenUsuarios(@pUsuario),
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (venVendedores = @pvenVendedores)
END 
ELSE 
BEGIN 
	INSERT INTO venVendedores
	(
		venVendedores,
		Vendedor_Id,
		Empresa_Id,
		Nombre,
		Comision,
		ComisionxSuperv,
		Supervisor_Id,
		PisoDeVentas,
		Centro1_Id,
		Centro2_Id,
		FacturaCobrada,
		ConAnticipos,
		SinImpuestos,
		Inactivo,
		Usuario, 
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pvenVendedores,
		@pVendedor_Id_Nueva,
		@pEmpresa_Id,
		@pNombre,
		@pComision,
		@pComisionxSuperv,
		dbo.FuncFKVenVendedores(@pSupervisor_Id),
		@pPisoDeVentas,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pFacturaCobrada,
		@pConAnticipos,
		@pSinImpuestos,
		@pInactivo,
		dbo.FuncFKgenUsuarios(@pUsuario),
		@pUsuario_Id,
		@pPosteado
	)
END 

GO

DROP PROCEDURE venVendedoresDatos
GO
CREATE PROCEDURE venVendedoresDatos
(
@pVendedor_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT  venVendedores.venVendedores, venVendedores.Vendedor_Id, genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal,
	venVendedores.Empresa_Id, 
Cast( Case When venVendedores.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venVendedores.Nombre, venVendedores.Comision, venVendedores.ComisionxSuperv,
	Supervisor.Vendedor_id Supervisor_Id,  Supervisor.Nombre as NombreSupervisor,
	venVendedores.PisoDeVentas, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, venVendedores.FacturaCobrada,
	venVendedores.ConAnticipos, venVendedores.SinImpuestos, venVendedores.Inactivo, 
	Usuario.Usuario_id as Usuario, Usuario.Apellido_y_Nombres as DescripcionUsuario,
	IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
	IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
	IsNull(venCobradores.Cobrador_Id, '') Cobrador_Id, IsNull( venCobradores.Nombre, '') CobNombre,
	IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre,
	genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario_Id, 
	venVendedores.Posteado 
FROM venVendedores 
	INNER JOIN genEntidades  ON genEntidades.genEntidades = venVendedores.venVendedores
	LEFT JOIN venVendedores  as Supervisor ON Supervisor.venVendedores = venVendedores.Supervisor_Id
	LEFT JOIN conCentro1  ON conCentro1.conCentro1 = venVendedores.Centro1_Id
	LEFT JOIN conCentro2  ON conCentro2.conCentro2 = venVendedores.Centro2_Id
	LEFT JOIN genUsuarios as Usuario ON Usuario.genUsuarios = venVendedores.Usuario
	Inner Join genUsuarios  ON genUsuarios.genUsuarios = venVendedores.Usuario_id
Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
Left Outer Join venCobradores On venCobradores.venCobradores = genEntidades.genEntidades
Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades
WHERE venVendedores.Vendedor_id = @pVendedor_id

 Declare @pidentity bigint= dbo.FuncFKvenVendedores (@pVendedor_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venVendedores'
 RETURN @@Error 

GO

DROP PROCEDURE venVendedoresDatosId
GO
CREATE PROCEDURE venVendedoresDatosId
(
@pIdentity bigint
)
AS
SET NOCOUNT ON 

SELECT  venVendedores.venVendedores, venVendedores.Vendedor_Id, genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal,
	venVendedores.Empresa_Id, 
Cast( Case When venVendedores.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venVendedores.Nombre, venVendedores.Comision, venVendedores.ComisionxSuperv,
	Supervisor.Vendedor_id Supervisor_Id,  Supervisor.Nombre as NombreSupervisor,
	venVendedores.PisoDeVentas, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, venVendedores.FacturaCobrada,
	venVendedores.ConAnticipos, venVendedores.SinImpuestos, venVendedores.Inactivo, 
	Usuario.Usuario_id as Usuario, Usuario.Apellido_y_Nombres as DescripcionUsuario,
	IsNull(venClientes.Cliente_Id, '') Cliente_Id, IsNull(venClientes.RazonSocial, '') ClieRazonSocial,
	IsNull(comProveedores.Proveed_Id, '') Proveed_Id, IsNull(comProveedores.RazonSocial, '') ProvRazonSocial,
	IsNull(venCobradores.Cobrador_Id, '') Cobrador_Id, IsNull( venCobradores.Nombre, '') CobNombre,
	IsNull(SuePersonal.Legajo, 0) Legajo, IsNull(suePersonal.ApellidoPaterno, '') SueNombre,
	genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario_Id, 
	venVendedores.Posteado 
FROM venVendedores 
	INNER JOIN genEntidades  ON genEntidades.genEntidades = venVendedores.venVendedores
	LEFT JOIN venVendedores  as Supervisor ON Supervisor.venVendedores = venVendedores.Supervisor_Id
	LEFT JOIN conCentro1  ON conCentro1.conCentro1 = venVendedores.Centro1_Id
	LEFT JOIN conCentro2  ON conCentro2.conCentro2 = venVendedores.Centro2_Id
	LEFT JOIN genUsuarios as Usuario ON Usuario.genUsuarios = venVendedores.Usuario
	Inner Join genUsuarios  ON genUsuarios.genUsuarios = venVendedores.Usuario_id
Left Outer Join venClientes On venClientes.genEntidades = genEntidades.genEntidades
Left Outer Join comProveedores On comProveedores.genEntidades = genEntidades.genEntidades
Left Outer Join venCobradores On venCobradores.venCobradores = genEntidades.genEntidades
Left Outer Join suePersonal On suePersonal.genEntidades = genEntidades.genEntidades
WHERE venVendedores.venVendedores = @pIdentity

Exec genAtributosGeneralesIdentityDatos @pIdentity, 'venVendedores'
RETURN @@Error 

GO

DROP PROCEDURE venVendedoresEliminar
GO
CREATE PROCEDURE venVendedoresEliminar
(
@pVendedor_id VarChar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM venVendedores 
WHERE (Vendedor_id = @pVendedor_id)
 
 RETURN @@Error 

GO

GO
DROP FUNCTION FuncFKvenVendedores
GO
CREATE FUNCTION FuncFKvenVendedores
(
@pVendedor_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venVendedores FROM venVendedores WHERE 
	Vendedor_id = @pVendedor_id
  RETURN @pIdentity
END


GO