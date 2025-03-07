DROP PROCEDURE espstkTalleImpGuardar
GO
CREATE PROCEDURE espstkTalleImpGuardar
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
IF (EXISTS (SELECT 1 FROM espstkTalleImp WHERE (Talle_Id = @pTalle_Id)))
BEGIN 
	UPDATE espstkTalleImp
	SET		@lIdentidad = espstkTalleImp,
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
	INSERT INTO espstkTalleImp
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

DROP PROCEDURE espstkTalleImpDatos
GO
CREATE PROCEDURE espstkTalleImpDatos
(
@pTalle_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT espstkTalleImp.espstkTalleImp, espstkTalleImp.Talle_Id, espstkTalleImp.Talle_Id Talle_Id_Nueva, espstkTalleImp.Empresa_Id,
	Cast( Case When espstkTalleImp.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, espstkTalleImp.Descripcion, espstkTalleImp.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, espstkTalleImp.Posteado
FROM espstkTalleImp 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = espstkTalleImp.Usuario_Id)
WHERE (Talle_Id = @pTalle_Id)
 


  Declare @pidentity bigint= dbo.FuncFKespstkTalleImp(@pTalle_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'espstkTalleImp'
 RETURN @@Error 

GO

DROP PROCEDURE espstkTalleImpEliminar
GO
CREATE PROCEDURE espstkTalleImpEliminar
(
@pTalle_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM espstkTalleImp 
WHERE (Talle_Id = @pTalle_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKespstkTalleImp
GO

CREATE FUNCTION FuncFKespstkTalleImp
(
@pTalle_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = espstkTalleImp FROM espstkTalleImp WHERE 
	Talle_Id = @pTalle_Id
  RETURN @pIdentity
END


GO
