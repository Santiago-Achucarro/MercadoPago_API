DROP PROCEDURE genPaisesGuardar
GO
CREATE PROCEDURE genPaisesGuardar
(
@pPais_Id smallint,
@pPais_Id_Nuevo smallint,
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pCodFiscal varchar(3) = NULL,
@pDominio_Id char(2) = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genPaises WHERE (Pais_Id = @pPais_Id)))
BEGIN 
	UPDATE genPaises
	SET		@lIdentidad = genPaises,
		Pais_Id = @pPais_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		CodFiscal = @pCodFiscal,
		Dominio_Id = @pDominio_Id,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Pais_Id = @pPais_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genPaises
	(
		Pais_Id,
		Empresa_Id,
		Descripcion,
		CodFiscal,
		Dominio_Id,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pPais_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pCodFiscal,
		@pDominio_Id,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE genPaisesDatos
GO
CREATE PROCEDURE genPaisesDatos
(
@pPais_Id smallint
)
AS
SET NOCOUNT ON 

SELECT genPaises.genPaises, genPaises.Pais_Id, genPaises.Empresa_Id, Cast( Case When genPaises.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genPaises.Descripcion, genPaises.CodFiscal, genPaises.Dominio_Id, genDominios.Descripcion as DescripcionDominios,
	genPaises.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genPaises.Posteado
FROM genPaises 
LEFT JOIN genDominios  ON (genDominios.Dominio_Id = genPaises.Dominio_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genPaises.Usuario_Id)
WHERE (Pais_Id = @pPais_Id)
 


 Declare @pidentity bigint= dbo.FuncFKgenPaises(@pPais_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'genPaises'
 RETURN @@Error 

GO

DROP PROCEDURE genPaisesEliminar
GO
CREATE PROCEDURE genPaisesEliminar
(
@pPais_Id smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genPaises 
WHERE (Pais_Id = @pPais_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenPaises
GO

CREATE FUNCTION FuncFKgenPaises
(
@pPais_Id smallint
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genPaises FROM genPaises WHERE 
	Pais_Id = @pPais_Id
  RETURN @pIdentity
END


GO
