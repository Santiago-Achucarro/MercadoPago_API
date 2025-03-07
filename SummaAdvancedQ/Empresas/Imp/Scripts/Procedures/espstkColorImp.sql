DROP PROCEDURE espstkColorImpGuardar
GO
CREATE PROCEDURE espstkColorImpGuardar
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
IF (EXISTS (SELECT 1 FROM espstkColorImp WHERE (Color_Id = @pColor_Id)))
BEGIN 
	UPDATE espstkColorImp
	SET		@lIdentidad = espstkColorImp,
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
	INSERT INTO espstkColorImp
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

DROP PROCEDURE espstkColorImpDatos
GO
CREATE PROCEDURE espstkColorImpDatos
(
@pColor_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT espstkColorImp.espstkColorImp, espstkColorImp.Color_Id, espstkColorImp.Color_Id Color_Id_Nueva, espstkColorImp.Empresa_Id,
	Cast( Case When espstkColorImp.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, espstkColorImp.Descripcion, espstkColorImp.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, espstkColorImp.Posteado
FROM espstkColorImp 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = espstkColorImp.Usuario_Id)
WHERE (Color_Id = @pColor_Id)
 


  Declare @pidentity bigint= dbo.FuncFKespstkColorImp(@pColor_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'espstkColorImp'
 RETURN @@Error 

GO

DROP PROCEDURE espstkColorImpEliminar
GO
CREATE PROCEDURE espstkColorImpEliminar
(
@pColor_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espstkColorImp 
WHERE (Color_Id = @pColor_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKespstkColorImp
GO

CREATE FUNCTION FuncFKespstkColorImp
(
@pColor_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = espstkColorImp FROM espstkColorImp WHERE 
	Color_Id = @pColor_Id
  RETURN @pIdentity
END


GO
