DROP PROCEDURE tesSolicitantesGuardar
GO
CREATE PROCEDURE tesSolicitantesGuardar
(
@pgenEntidades bigint,
@pSolicitante_Id varchar(5),
@pSolicitante_Id_Nueva varchar(5),
@pEmpresa_Id int = NULL,
@pNombre varchar(120),
@pInactivo bit,
@pPosteado bit,
@pBanco_Id varchar(3) = NULL,
@pCuenta varchar(18) = NULL,
@pUsuario_Id int,
@pFechaCarga datetime
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesSolicitantes WHERE (genEntidades = @pgenEntidades)))
BEGIN 
	UPDATE tesSolicitantes
	SET		Solicitante_Id = @pSolicitante_Id_Nueva,
		Empresa_Id = @pEmpresa_Id,
		Nombre = @pNombre,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Banco_Id = dbo.FuncFKtesBancos(@pBanco_Id),
		Cuenta = @pCuenta,
		Usuario_Id = @pUsuario_Id,
		FechaCarga = @pFechaCarga
	WHERE (genEntidades = @pgenEntidades)
END 
ELSE 
BEGIN 
	INSERT INTO tesSolicitantes
	(
		genEntidades,
		Solicitante_Id,
		Empresa_Id,
		Nombre,
		Inactivo,
		Posteado,
		Banco_Id,
		Cuenta,
		Usuario_Id,
		FechaCarga
	)
	VALUES 
	(
		@pgenEntidades,
		@pSolicitante_Id,
		@pEmpresa_Id,
		@pNombre,
		@pInactivo,
		@pPosteado,
		dbo.FuncFKtesBancos(@pBanco_Id),
		@pCuenta,
		@pUsuario_Id,
		@pFechaCarga
	)
	
END 

GO

DROP PROCEDURE tesSolicitantesDatos
GO
CREATE PROCEDURE tesSolicitantesDatos
(
@pSolicitante_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT genEntidades.Cuit, genEntidades.IdFiscal, genEntidades.TipoDoc, 
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Solicitante_Id Solicitante_Id_Nueva, 
	tesSolicitantes.Empresa_Id, Cast( Case When tesSolicitantes.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	tesSolicitantes.Nombre, tesSolicitantes.Inactivo, tesSolicitantes.Posteado, tesBancos.Banco_Id,
	tesBancos.Descripcion as DescripcionBancos, tesSolicitantes.Cuenta, genUsuarios.Usuario_Id, 
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	tesSolicitantes.FechaCarga, genEntidades.genEntidades
FROM tesSolicitantes 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = tesSolicitantes.genEntidades)
LEFT JOIN tesBancos  ON (tesBancos.tesBancos = tesSolicitantes.Banco_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesSolicitantes.Usuario_Id)
WHERE (tesSolicitantes.Solicitante_Id = @pSolicitante_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE tesSolicitantesEliminar
GO
CREATE PROCEDURE tesSolicitantesEliminar
(
@pSolicitante_Id varchar(25)
)
AS
SET NOCOUNT ON 

DELETE FROM tesSolicitantes 
WHERE (Solicitante_Id = @pSolicitante_Id)
 
RETURN @@Error 

GO


DROP FUNCTION FuncFKtesSolicitantes
GO

CREATE FUNCTION FuncFKtesSolicitantes
(
@pSolicitante_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genEntidades FROM tesSolicitantes WHERE 
	Solicitante_Id = @pSolicitante_Id
  RETURN @pIdentity
END


GO


DROP PROCEDURE tesSolicitantesDatosId
GO
CREATE PROCEDURE tesSolicitantesDatosId
(
	@ptesSolicitante bigint
)
AS
SET NOCOUNT ON 

SELECT genEntidades.Cuit, genEntidades.IdFiscal, genEntidades.TipoDoc, 
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Solicitante_Id Solicitante_Id_Nueva, 
	tesSolicitantes.Empresa_Id, Cast( Case When tesSolicitantes.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	tesSolicitantes.Nombre, tesSolicitantes.Inactivo, tesSolicitantes.Posteado, tesBancos.Banco_Id,
	tesBancos.Descripcion as DescripcionBancos, tesSolicitantes.Cuenta, genUsuarios.Usuario_Id, 
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	tesSolicitantes.FechaCarga, genEntidades.genEntidades
FROM tesSolicitantes 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = tesSolicitantes.genEntidades)
LEFT JOIN tesBancos  ON (tesBancos.tesBancos = tesSolicitantes.Banco_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesSolicitantes.Usuario_Id)
WHERE (tesSolicitantes.genEntidades = @ptesSolicitante)
 
 RETURN @@Error 

GO
