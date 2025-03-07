DROP PROCEDURE tesBancosGuardar
GO
CREATE PROCEDURE tesBancosGuardar
(
@pBanco_Id varchar(3),
@pBanco_Id_Nuevo varchar(3),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pRFC Varchar(14)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesBancos WHERE (Banco_Id = @pBanco_Id)))
BEGIN 
	UPDATE tesBancos
	SET		@lIdentidad = tesBancos,
		Banco_Id = @pBanco_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		RFC = @pRFC
	WHERE (Banco_Id = @pBanco_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesBancos
	(
		Banco_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado, 
		RFC
	)
	VALUES 
	(
		@pBanco_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado,
		@pRFC
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesBancosDatos
GO
CREATE PROCEDURE tesBancosDatos
(
@pBanco_Id varchar(3)
)
AS
SET NOCOUNT ON 

SELECT tesBancos.tesBancos, tesBancos.Banco_Id, tesBancos.Empresa_Id, Cast( Case When tesBancos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpreas,
	tesBancos.Descripcion, tesBancos.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	tesBancos.Posteado, tesBancos.RFC 
FROM tesBancos 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesBancos.Usuario_Id)
WHERE (Banco_Id = @pBanco_Id)
 


  Declare @pidentity bigint= dbo.FuncFKtesBancos(@pBanco_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesBancos'
 RETURN @@Error 

GO

DROP PROCEDURE tesBancosEliminar
GO
CREATE PROCEDURE tesBancosEliminar
(
@pBanco_Id varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesBancos 
WHERE (Banco_Id = @pBanco_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesBancos
GO

CREATE FUNCTION FuncFKtesBancos
(
@pBanco_Id varchar (3)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesBancos FROM tesBancos WHERE 
	Banco_Id = @pBanco_Id
  RETURN @pIdentity
END


GO