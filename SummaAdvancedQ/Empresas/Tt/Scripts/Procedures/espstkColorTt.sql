DROP PROCEDURE espstkColorTtGuardar
GO
CREATE PROCEDURE espstkColorTtGuardar
(
@pColor_Id varchar(15),
@pColor_Id_Nuevo varchar(15),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM espstkColorTt WHERE (Color_Id = @pColor_Id)))
BEGIN 
	UPDATE espstkColorTt
	SET		@lIdentidad = espstkColorTt,
		Color_Id = @pColor_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Color_Id = @pColor_Id)
END 
ELSE 
BEGIN 
	INSERT INTO espstkColorTt
	(
		Color_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pColor_Id,
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

DROP PROCEDURE espstkColorTtDatos
GO
CREATE PROCEDURE espstkColorTtDatos
(
@pColor_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT espstkColorTt.espstkColorTt, espstkColorTt.Color_Id, espstkColorTt.Color_Id Color_Id_Nueva, espstkColorTt.Empresa_Id,
	Cast( Case When espstkColorTt.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, espstkColorTt.Descripcion, espstkColorTt.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, espstkColorTt.Posteado
FROM espstkColorTt 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = espstkColorTt.Usuario_Id)
WHERE (Color_Id = @pColor_Id)
 


  Declare @pidentity bigint= dbo.FuncFKespstkColorTt(@pColor_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'espstkColorTt'
 RETURN @@Error 

GO

DROP PROCEDURE espstkColorTtEliminar
GO
CREATE PROCEDURE espstkColorTtEliminar
(
@pColor_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espstkColorTt 
WHERE (Color_Id = @pColor_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKespstkColorTt
GO

CREATE FUNCTION FuncFKespstkColorTt
(
@pColor_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = espstkColorTt FROM espstkColorTt WHERE 
	Color_Id = @pColor_Id
  RETURN @pIdentity
END


GO
