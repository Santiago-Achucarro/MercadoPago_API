DROP PROCEDURE tesCausasRechazoGuardar
GO
CREATE PROCEDURE tesCausasRechazoGuardar
(
@pCausa_Id varchar(5),
@pCausa_Id_Nueva varchar(5),
@pDescripcion varchar(150), 
@pEmpresa_Id int=NULL,
@pUsuario_Id int, 
@pPosteado bit,
@pInactivo bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesCausasRechazo WHERE Causa_Id = @pCausa_Id))
BEGIN 
	UPDATE tesCausasRechazo
	SET		@lIdentidad = tesCausasRechazo,
		Causa_Id = @pCausa_Id_Nueva,
		Descripcion = @pDescripcion, 
		Empresa_Id = @pEmpresa_Id,
		Usuario_Id = @pUsuario_Id, 
		Posteado = @pUsuario_Id,
		Inactivo = @pInactivo,
		FechaModificacion = dbo.FechaActual()
	WHERE 
		Causa_Id = @pCausa_Id
END 
ELSE 
BEGIN 
	INSERT INTO tesCausasRechazo
	(
		Causa_Id,
		Descripcion,
		Empresa_Id,
		Usuario_Id,
		Posteado,
		Inactivo, 
		FechaModificacion
	)
	VALUES 
	(
		@pCausa_Id_Nueva,
		@pDescripcion,
		@pEmpresa_id,
		@pUsuario_Id,
		@pPosteado,
		@pInactivo,
		dbo.FechaActual()
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesCausasRechazoDatos
GO
CREATE PROCEDURE tesCausasRechazoDatos
(
	@pCausa_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT tesCausasRechazo.tesCausasRechazo, tesCausasRechazo.Causa_Id, tesCausasRechazo.Causa_Id as Causa_Id_Nueva,
	tesCausasRechazo.Descripcion, tesCausasRechazo.Empresa_Id, 
		Cast(Case when tesCausasRechazo.Empresa_Id is NULL THEN 1 ELSE 0 END as bit) as ParaTodasEmpresas,
		tesCausasRechazo.Posteado, tesCausasRechazo.Inactivo, 
		genUsuarios.Usuario_Id, tesCausasRechazo.FechaModificacion
FROM tesCausasRechazo inner join genUsuarios on genUsuarios.genUsuarios = tesCausasRechazo.Usuario_Id

WHERE  
	tesCausasRechazo.Causa_Id = @pCausa_Id


 Declare @pidentity int= dbo.FuncFKtesCausasRechazo(@pCausa_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesCausasRechazo'
 RETURN @@Error 

GO

DROP PROCEDURE tesCausasRechazoEliminar
GO
CREATE PROCEDURE tesCausasRechazoEliminar
(
	@pCausa_Id VarChar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesCausasRechazo 
WHERE  Causa_Id = 	@pCausa_Id 
RETURN @@Error 

GO

DROP FUNCTION FuncFKtesCausasRechazo
GO

CREATE FUNCTION FuncFKtesCausasRechazo
(
	@pCausa_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesCausasRechazo FROM tesCausasRechazo WHERE 
		Causa_Id = @pCausa_Id

  RETURN @pIdentity
END


GO
