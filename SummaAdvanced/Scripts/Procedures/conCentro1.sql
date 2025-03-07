DROP PROCEDURE conCentro1Guardar
GO
CREATE PROCEDURE conCentro1Guardar
(
@pCentro1_Id varchar(8),
@pCentro1_Id_Nuevo varchar(8),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pNivel smallint,
@pImputable Sino,
@pNotas QMemo = NULL,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conCentro1 WHERE (Centro1_Id = @pCentro1_Id)))
BEGIN 
	UPDATE conCentro1
	SET		@lIdentidad = conCentro1,
		Centro1_Id = @pCentro1_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Nivel = @pNivel,
		Imputable = @pImputable,
		Notas = @pNotas,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Centro1_Id = @pCentro1_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conCentro1
	(
		Centro1_Id,
		Empresa_Id,
		Descripcion,
		Nivel,
		Imputable,
		Notas,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCentro1_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pNivel,
		@pImputable,
		@pNotas,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE conCentro1Datos
GO
CREATE PROCEDURE conCentro1Datos
(
@pCentro1_Id varchar(8)
)
AS
SET NOCOUNT ON 

SELECT conCentro1.conCentro1, conCentro1.Centro1_Id, conCentro1.Empresa_Id, 
	Cast( Case When conCentro1.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	conCentro1.Descripcion, conCentro1.Nivel, conCentro1.Imputable, conCentro1.Notas,
	conCentro1.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, conCentro1.Posteado
FROM conCentro1 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conCentro1.Usuario_Id)
WHERE (Centro1_Id = @pCentro1_Id)
 


Declare @pidentity bigint= dbo.FuncFKconCentro1(@pCentro1_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'conCentro1'
RETURN @@Error 

GO

DROP PROCEDURE conCentro1Eliminar
GO
CREATE PROCEDURE conCentro1Eliminar
(
@pCentro1_Id varchar(8) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conCentro1 
WHERE (Centro1_Id = @pCentro1_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconCentro1
GO

CREATE FUNCTION FuncFKconCentro1
(
@pCentro1_Id varchar (8)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conCentro1 FROM conCentro1 WHERE 
	Centro1_Id = @pCentro1_Id
  RETURN @pIdentity
END


GO
