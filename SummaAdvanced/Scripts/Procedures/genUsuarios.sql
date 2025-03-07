

DROP PROCEDURE genUsuariosGuardar
GO
CREATE PROCEDURE genUsuariosGuardar
(
@pUsuario_Id varchar(25),
@pUsuario_Id_Nuevo varchar(25),
@pEmpresa_Id int = NULL,
@pApellido_y_Nombres varchar(36),
@pTipoUsuario char(1),
@pSucursal char(4) = NULL,
@pClave_de_Acceso int,
@pCargo varchar(50),
@pUltCambioPass datetime,
@pIntentos smallint,
@pEmail varchar(150) = NULL,
@pUsuarioCarga int,
@pPtoEmision char(3) = NULL,
@pCambiarClave bit,
@pMalClave smallint,
@pEsSupervisor bit,
@pCultura varchar(5) = Null,
@pInactivo bit,
@pPosteado bit, 
@pMultiplesLogins Bit,
@pCliente_Id VarChar(15)= NULL,
@pProveed_Id VarChar(15)= NULL,
@pVendedor_Id VarChar(5)= NULL,
@pCobrador_Id VarChar(5)= NULL,
@pLegajo int= NULL,
@pRestringeHorarios SiNo,
@pFirma varchar(max),
@pImagenFirma varchar(max)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genUsuarios WHERE (Usuario_Id = @pUsuario_Id)))
BEGIN 
	UPDATE genUsuarios
	SET		@lIdentidad = genUsuarios,
		Usuario_Id = @pUsuario_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Apellido_y_Nombres = @pApellido_y_Nombres,
		TipoUsuario = @pTipoUsuario,
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		Clave_de_Acceso = @pClave_de_Acceso,
		Cargo = @pCargo,
		UltCambioPass = @pUltCambioPass,
		Intentos = @pIntentos,
		Email = @pEmail,
		UsuarioCarga = @pUsuarioCarga,
		PtoEmision = @pPtoEmision,
		CambiarClave = @pCambiarClave,
		MalClave = @pMalClave,
		EsSupervisor = @pEsSupervisor,
		Cultura = @pCultura,
		Inactivo = @pInactivo,
		Posteado = @pPosteado, 
		MultiplesLogins = @pMultiplesLogins,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id),
		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		Cobrador_Id = dbo.FuncFKvenCobradores(@pCobrador_Id),
		Legajo = dbo.FuncFKsuePersonal(@pLegajo),
		RestringeHorarios=@pRestringeHorarios,
		Firma=@pFirma,
		ImagenFirmaB64=@pImagenFirma
	WHERE (Usuario_Id = @pUsuario_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genUsuarios
	(
		Usuario_Id,
		Empresa_Id,
		Apellido_y_Nombres,
		TipoUsuario,
		Sucursal,
		Clave_de_Acceso,
		Cargo,
		UltCambioPass,
		Intentos,
		Email,
		UsuarioCarga,
		PtoEmision,
		CambiarClave,
		MalClave,
		EsSupervisor,
		Cultura,
		Inactivo,
		Posteado, 
		MultiplesLogins,
		Cliente_Id ,
		Proveed_Id,
		Vendedor_Id,
		Cobrador_Id,
		Legajo ,
		RestringeHorarios,
		Firma,
		ImagenFirmaB64
	)
	VALUES 
	(
		@pUsuario_Id_Nuevo,
		@pEmpresa_Id,
		@pApellido_y_Nombres,
		@pTipoUsuario,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		@pClave_de_Acceso,
		@pCargo,
		@pUltCambioPass,
		@pIntentos,
		@pEmail,
		@pUsuarioCarga,
		@pPtoEmision,
		@pCambiarClave,
		@pMalClave,
		@pEsSupervisor,
		@pCultura,
		@pInactivo,
		@pPosteado, 
		@pMultiplesLogins,
		dbo.FuncFKvenClientes(@pCliente_Id),
		dbo.FuncFKcomProveedores(@pProveed_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenCobradores(@pCobrador_Id),
		dbo.FuncFKsuePersonal(@pLegajo),
		@pRestringeHorarios,
		@pFirma,
		@pImagenFirma
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO
-- genUsuariosDatos 'ALMACEN2'
DROP PROCEDURE genUsuariosDatos
GO
CREATE PROCEDURE genUsuariosDatos
(
@pUsuario_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT genUsuarios.genUsuarios, genUsuarios.Usuario_Id, genUsuarios.Empresa_Id, 
	Cast( Case When genUsuarios.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genUsuarios.Apellido_y_Nombres, genUsuarios.TipoUsuario, genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr,
	genUsuarios.Clave_de_Acceso, genUsuarios.Cargo, genUsuarios.UltCambioPass, genUsuarios.Intentos,
	genUsuarios.Email, genUsuarios.UsuarioCarga, genUsuarios.PtoEmision, genUsuarios.CambiarClave,
	genUsuarios.MalClave, genUsuarios.EsSupervisor, genUsuarios.Cultura, genCulturas.Descripcion As DescripcionCultura,
	genUsuarios.Inactivo, genUsuarios.Posteado, 
	'' as Clave1, '' as Clave2 , genUsuarios.MultiplesLogins, 
	venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionCliente,
	comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedor,
	venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedor, 
	venCobradores.Cobrador_Id, venCobradores.Nombre as DescripcionCobrador,
	suePersonal.Legajo, suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno+','+suePersonal.Nombres as DescripcionLegajo,
	RestringeHorarios, Firma, ImagenFirmaB64
FROM genUsuarios 
LEFT JOIN genSucursalesEmpr  ON (genSucursalesEmpr.genSucursalesEmpr = genUsuarios.Sucursal)
Left Join genCulturas On genCulturas.Cultura = genUsuarios.Cultura
LEFT JOIN venClientes ON venClientes.genEntidades = genUsuarios.Cliente_Id
LEFT JOIN comProveedores ON comProveedores.genEntidades = genUsuarios.Proveed_Id
LEFT JOIN venVendedores ON venVendedores.venVendedores = genUsuarios.Vendedor_Id
LEFT JOIN venCobradores ON venCobradores.venCobradores = genUsuarios.Cobrador_Id
LEFT JOIN suePersonal ON suePersonal.genEntidades = genUsuarios.Legajo
WHERE (genUsuarios.Usuario_Id = @pUsuario_Id)
 


 Declare @pidentity bigint= dbo.FuncFKgenUsuarios(@pUsuario_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'genUsuarios'
 
 SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial
 from comProveedores inner join genEntidades ON 
 comProveedores.genEntidades = genEntidades.genEntidades
 WHERE
 genEntidades.genEntidades = @pidentity
 
 
 SELECT venClientes.Cliente_Id, venClientes.RazonSocial
 from venClientes inner join genEntidades ON 
 venClientes.genEntidades = genEntidades.genEntidades
 WHERE
 genEntidades.genEntidades = @pidentity
 
 
 SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno Apellido_y_Nombre 
 from suePersonal inner join genEntidades ON 
 suePersonal.genEntidades = genEntidades.genEntidades
 WHERE
 genEntidades.genEntidades = @pidentity
 
 
 SELECT venVendedores.Vendedor_Id, venVendedores.Nombre
 from venVendedores inner join genEntidades ON 
 venVendedores.venVendedores = genEntidades.genEntidades
 WHERE
 genEntidades.genEntidades = @pidentity
 
 
 SELECT venCobradores.Cobrador_Id, venCobradores.Nombre
 from venCobradores inner join genEntidades ON 
 venCobradores.venCobradores = genEntidades.genEntidades
 WHERE
 genEntidades.genEntidades = @pidentity
 
EXEC genHorariosIngreso @pidentity, null
exec genAdjuntosIdentityDatos 'genUsuarios', @pidentity
exec genUsuariosSucursalDatos null,null, @pUsuario_Id
 RETURN @@Error 

GO

DROP PROCEDURE genUsuariosEliminar
GO
CREATE PROCEDURE genUsuariosEliminar
(
@pUsuario_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genUsuarios 
WHERE (Usuario_Id = @pUsuario_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenUsuarios
GO

CREATE FUNCTION FuncFKgenUsuarios
(
@pUsuario_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genUsuarios FROM genUsuarios WHERE 
	Usuario_Id = @pUsuario_Id
  RETURN @pIdentity
END


GO


DROP PROCEDURE genUsuariosCambiarClaveDatos
GO
CREATE PROCEDURE genUsuariosCambiarClaveDatos
AS
SELECT ' ' ClaveVieja, ' ' ClaveNueva1 , ' ' ClaveNueva2 
GO


DROP PROCEDURE genUsuariosCambiarClaveGuardar
GO
CREATE PROCEDURE genUsuariosCambiarClaveGuardar
( 
	@Usuario_Id int,
	@Clave int
)
AS


Update genUsuarios 
SET Clave_de_Acceso = @Clave,
	CambiarClave = 0, Intentos=0, MalClave = 0, 
		UltCambioPass = dbo.FechaActual()
Where genUsuarios = @Usuario_Id
GO


DROP PROCEDURE genUsuariosDatosInt
GO
CREATE PROCEDURE genUsuariosDatosInt
(
@pUsuario_Id int
)
AS

Declare @pCodigo VarChar(25) = (SELECT Usuario_id From genUsuarios Where genUsuarios=@pUsuario_Id)
EXEC genUsuariosDatos @pCodigo

GO




DROP PROCEDURE genUsuariosIntentosGuardar
GO
CREATE PROCEDURE genUsuariosIntentosGuardar
( 
	@Usuario_Id int, 
	@Intentos Int
)
AS

Update genUsuarios SET Intentos = @Intentos Where genUsuarios = @Usuario_Id
GO

DROP PROCEDURE genUsuariosMalClaveGuardar
GO
CREATE PROCEDURE genUsuariosMalClaveGuardar
( 
	@Usuario_Id int, 
	@MalClave Int
)
AS

Update genUsuarios SET MalClave = @MalClave Where genUsuarios = @Usuario_Id
GO


DROP PROCEDURE genUsuariosActualizarCorreo
GO
CREATE PROCEDURE genUsuariosActualizarCorreo
( 
	@Usuario_Id VarChar(25), 
	@Correo VarChar(150)
)
AS

Update genUsuarios SET Email = @Correo Where Usuario_Id = @Usuario_Id
GO






