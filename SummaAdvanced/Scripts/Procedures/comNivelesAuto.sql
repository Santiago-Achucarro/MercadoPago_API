DROP PROCEDURE comNivelesAutoGuardar
GO
CREATE PROCEDURE comNivelesAutoGuardar
(
@pNivelAuto_Id varchar(5),
@pNivelAuto_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(100),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comNivelesAuto WHERE (NivelAuto_Id = @pNivelAuto_Id)))
BEGIN 
	UPDATE comNivelesAuto
	SET @lIdentidad = ComNivelesAuto,
		NivelAuto_Id = @pNivelAuto_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado=@pPosteado
	WHERE (NivelAuto_Id = @pNivelAuto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comNivelesAuto
	(
		NivelAuto_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pNivelAuto_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO



DROP PROCEDURE comNivelesAutoDatos
GO
CREATE PROCEDURE comNivelesAutoDatos
(
@pNivelAuto_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comNivelesAuto.ComNivelesAuto, comNivelesAuto.NivelAuto_Id,
comNivelesAuto.Empresa_Id, Cast( Case When comNivelesAuto.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, 
comNivelesAuto.Descripcion, comNivelesAuto.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
comNivelesAuto.Posteado
FROM comNivelesAuto 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comNivelesAuto.Usuario_Id)
WHERE (NivelAuto_Id = @pNivelAuto_Id)

Exec comNivelesAutoUsuDatos @pNivelAuto_Id

Declare @pidentity bigint= dbo.FuncFKcomNivelesAuto(@pNivelAuto_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comNivelesAuto'
RETURN @@Error 

GO


DROP PROCEDURE comNivelesAutoEliminar
GO
CREATE PROCEDURE comNivelesAutoEliminar
(
@pNivelAuto_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM comNivelesAuto 
WHERE (NivelAuto_Id = @pNivelAuto_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomNivelesAuto
GO

CREATE FUNCTION FuncFKcomNivelesAuto
(
@pNivelAuto_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = ComNivelesAuto FROM comNivelesAuto WHERE 
	NivelAuto_Id = @pNivelAuto_Id
  RETURN @pIdentity
END


GO

