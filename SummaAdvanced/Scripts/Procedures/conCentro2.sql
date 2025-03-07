DROP PROCEDURE conCentro2Guardar
GO
CREATE PROCEDURE conCentro2Guardar
(
@pCentro2_Id varchar(8),
@pCentro2_Id_Nuevo varchar(8),
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
IF (EXISTS (SELECT 1 FROM conCentro2 WHERE (Centro2_Id = @pCentro2_Id)))
BEGIN 
	UPDATE conCentro2
	SET		@lIdentidad = conCentro2,
		Centro2_Id = @pCentro2_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Nivel = @pNivel,
		Imputable = @pImputable,
		Notas = @pNotas,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Centro2_Id = @pCentro2_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conCentro2
	(
		Centro2_Id,
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
		@pCentro2_Id,
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

DROP PROCEDURE conCentro2Datos
GO
CREATE PROCEDURE conCentro2Datos
(
@pCentro2_Id varchar(8)
)
AS
SET NOCOUNT ON 

SELECT conCentro2.conCentro2, conCentro2.Centro2_Id, conCentro2.Empresa_Id, Cast( Case When conCentro2.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	conCentro2.Descripcion, conCentro2.Nivel, conCentro2.Imputable, conCentro2.Notas,
	conCentro2.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, conCentro2.Posteado
FROM conCentro2 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conCentro2.Usuario_Id)
WHERE (Centro2_Id = @pCentro2_Id)
 


  Declare @pidentity bigint= dbo.FuncFKconCentro2(@pCentro2_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'conCentro2'
 RETURN @@Error 

GO

DROP PROCEDURE conCentro2Eliminar
GO
CREATE PROCEDURE conCentro2Eliminar
(
@pCentro2_Id varchar(8) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conCentro2 
WHERE (Centro2_Id = @pCentro2_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconCentro2
GO

CREATE FUNCTION FuncFKconCentro2
(
@pCentro2_Id varchar (8)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conCentro2 FROM conCentro2 WHERE 
	Centro2_Id = @pCentro2_Id
  RETURN @pIdentity
END


GO
