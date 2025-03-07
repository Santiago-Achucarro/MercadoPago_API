DROP PROCEDURE espstkColorKSKGuardar
GO
CREATE PROCEDURE espstkColorKSKGuardar
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
IF (EXISTS (SELECT 1 FROM espstkColorTest WHERE (Color_Id = @pColor_Id)))
BEGIN 
	UPDATE espstkColorTest
	SET	@lIdentidad = espstkColorTest,
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
	INSERT INTO espstkColorTest
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

DROP PROCEDURE espstkColorKSKDatos
GO
CREATE PROCEDURE espstkColorKSKDatos
(
@pColor_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT espstkColorTest.espstkColorTest espstkColorKSK, espstkColorTest.Color_Id, espstkColorTest.Color_Id Color_Id_Nueva, espstkColorTest.Empresa_Id,
	Cast( Case When espstkColorTest.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, espstkColorTest.Descripcion, espstkColorTest.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, espstkColorTest.Posteado
FROM espstkColorTest 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = espstkColorTest.Usuario_Id)
WHERE (Color_Id = @pColor_Id)
 


 Declare @pidentity bigint= dbo.FuncFKespstkColorKSK(@pColor_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'espstkColorTest'
 RETURN @@Error 

GO

DROP PROCEDURE espstkColorKSKEliminar
GO
CREATE PROCEDURE espstkColorKSKEliminar
(
@pColor_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espstkColorTest 
WHERE (Color_Id = @pColor_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKespstkColorKSK
GO

CREATE FUNCTION FuncFKespstkColorKSK
(
@pColor_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = espstkColorTest FROM espstkColorTest WHERE 
	Color_Id = @pColor_Id
  RETURN @pIdentity
END


GO
