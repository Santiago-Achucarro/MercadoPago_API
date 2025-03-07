DROP PROCEDURE proCausasGuardar
GO
CREATE PROCEDURE proCausasGuardar
(
@pCausa_Id varchar(5),
@pCausa_Id_Nueva varchar(5),
@pDescripcion varchar(100),
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proCausas WHERE proCausas.Causa_Id=@pCausa_Id))
BEGIN 
	UPDATE proCausas
	SET		@lIdentidad = proCausas,
		Causa_Id = @pCausa_Id_Nueva,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE proCausas.Causa_Id=@pCausa_Id
END 
ELSE 
BEGIN 
	INSERT INTO proCausas
	(
		Causa_Id,
		Descripcion,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pCausa_Id,
		@pDescripcion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE proCausasDatos
GO
CREATE PROCEDURE proCausasDatos
(
@pCausa_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT proCausas.proCausas, proCausas.Causa_Id,proCausas.Causa_Id as Causa_Id_Nueva, proCausas.Descripcion, proCausas.Inactivo,
	proCausas.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM proCausas 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = proCausas.Usuario_Id)
WHERE  proCausas.Causa_Id=@pCausa_Id


  Declare @pidentity bigint= dbo.FuncFKproCausas(@pCausa_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'proCausas'
 RETURN @@Error 

GO

DROP PROCEDURE proCausasEliminar
GO
CREATE PROCEDURE proCausasEliminar
(
@pCausa_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM proCausas 
WHERE  @pCausa_Id=proCausas.Causa_Id
 RETURN @@Error 

GO

drop FUNCTION FuncFKproCausas
go
CREATE FUNCTION FuncFKproCausas
(
@pCausa_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proCausas FROM proCausas WHERE 
	Causa_Id = @pCausa_Id
  RETURN @pIdentity
END

GO
