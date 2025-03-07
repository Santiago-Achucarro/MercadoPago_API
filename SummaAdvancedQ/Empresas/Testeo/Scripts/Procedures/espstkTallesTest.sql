DROP PROCEDURE espstkTalleTestGuardar
GO
CREATE PROCEDURE espstkTalleTestGuardar
(
@pTalle_Id varchar(15),
@pTalle_Id_Nuevo varchar(15),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM espstkTalleTest WHERE (Talle_Id = @pTalle_Id)))
BEGIN 
	UPDATE espstkTalleTest
	SET		@lIdentidad = espstkTalleTest,
		Talle_Id = @pTalle_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Talle_Id = @pTalle_Id)
END 
ELSE 
BEGIN 
	INSERT INTO espstkTalleTest
	(
		Talle_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pTalle_Id,
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

DROP PROCEDURE espstkTalleTestDatos
GO
CREATE PROCEDURE espstkTalleTestDatos
(
@pTalle_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT espstkTalleTest.espstkTalleTest, espstkTalleTest.Talle_Id, espstkTalleTest.Talle_Id Talle_Id_Nueva, espstkTalleTest.Empresa_Id,
	Cast( Case When espstkTalleTest.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, espstkTalleTest.Descripcion, espstkTalleTest.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, espstkTalleTest.Posteado
FROM espstkTalleTest 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = espstkTalleTest.Usuario_Id)
WHERE (Talle_Id = @pTalle_Id)
 


Declare @pidentity bigint= dbo.FuncFKespstkTalleTest(@pTalle_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'espstkTalleTest'
RETURN @@Error 

GO

DROP PROCEDURE espstkTalleTestEliminar
GO
CREATE PROCEDURE espstkTalleTestEliminar
(
@pTalle_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espstkTalleTest 
WHERE (Talle_Id = @pTalle_Id)
 
RETURN @@Error 

GO

DROP FUNCTION FuncFKespstkTalleTest
GO

CREATE FUNCTION FuncFKespstkTalleTest
(
@pTalle_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = espstkTalleTest FROM espstkTalleTest WHERE 
	Talle_Id = @pTalle_Id
  RETURN @pIdentity
END


GO
