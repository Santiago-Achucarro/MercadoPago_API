DROP PROCEDURE genProvinciasGuardar
GO
CREATE PROCEDURE genProvinciasGuardar
(
@pProvincia_Id varchar(5),
@pProvincia_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pCodFiscal varchar(3),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genProvincias WHERE (Provincia_Id = @pProvincia_Id)))
BEGIN 
	UPDATE genProvincias
	SET		@lIdentidad = genProvincias,
		Provincia_Id = @pProvincia_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		CodFiscal = @pCodFiscal,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Provincia_Id = @pProvincia_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genProvincias
	(
		Provincia_Id,
		Empresa_Id,
		Descripcion,
		CodFiscal,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pProvincia_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pCodFiscal,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE genProvinciasDatos
GO
CREATE PROCEDURE genProvinciasDatos
(
@pProvincia_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT genProvincias.genProvincias, genProvincias.Provincia_Id, genProvincias.Empresa_Id, Cast( Case When genProvincias.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genProvincias.Descripcion, genProvincias.CodFiscal, genProvincias.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genProvincias.Posteado
FROM genProvincias 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genProvincias.Usuario_Id)
WHERE (Provincia_Id = @pProvincia_Id)
 


 Declare @pidentity bigint= dbo.FuncFKgenProvincias(@pProvincia_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'genProvincias'
 RETURN @@Error 

GO

DROP PROCEDURE genProvinciasEliminar
GO
CREATE PROCEDURE genProvinciasEliminar
(
@pProvincia_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genProvincias 
WHERE (Provincia_Id = @pProvincia_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenProvincias
GO

CREATE FUNCTION FuncFKgenProvincias
(
@pProvincia_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genProvincias FROM genProvincias WHERE 
	Provincia_Id = @pProvincia_Id
  RETURN @pIdentity
END


GO
