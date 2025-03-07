DROP PROCEDURE venNivelesAutoGuardar
GO
CREATE PROCEDURE venNivelesAutoGuardar
(
@pNivelAuto_Id varchar(5),
@pNivelAuto_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(100),
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venNivelesAuto WHERE (NivelAuto_Id = @pNivelAuto_Id)))
BEGIN 
	UPDATE venNivelesAuto
	SET @lIdentidad = venNivelesAuto,
		NivelAuto_Id = @pNivelAuto_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (NivelAuto_Id = @pNivelAuto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venNivelesAuto
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



DROP PROCEDURE venNivelesAutoDatos
GO
CREATE PROCEDURE venNivelesAutoDatos
(
@pNivelAuto_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venNivelesAuto.venNivelesAuto, venNivelesAuto.NivelAuto_Id,  
venNivelesAuto.Empresa_Id, Cast( Case When venNivelesAuto.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, 
venNivelesAuto.Descripcion, venNivelesAuto.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
venNivelesAuto.Posteado
FROM venNivelesAuto 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venNivelesAuto.Usuario_Id)
WHERE (NivelAuto_Id = @pNivelAuto_Id)

Exec venNivelesAutoUsuDatos @pNivelAuto_Id

Declare @pidentity bigint= dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venNivelesAuto'
RETURN @@Error 

GO


DROP PROCEDURE venNivelesAutoEliminar
GO
CREATE PROCEDURE venNivelesAutoEliminar
(
@pNivelAuto_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM venNivelesAuto 
WHERE (NivelAuto_Id = @pNivelAuto_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenNivelesAuto
GO

CREATE FUNCTION FuncFKvenNivelesAuto
(
@pNivelAuto_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venNivelesAuto FROM venNivelesAuto WHERE 
	NivelAuto_Id = @pNivelAuto_Id
  RETURN @pIdentity
END


GO

