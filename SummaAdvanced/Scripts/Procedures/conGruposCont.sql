Drop Procedure conGruposContGuardar
GO
CREATE PROCEDURE conGruposContGuardar
(
@pGrupo_Id varchar(5),
@pGrupo_Id_Nuevo varchar(5),
@pEmpresa_Id int,
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conGruposCont WHERE 
(Grupo_Id = @pGrupo_Id
)))
BEGIN 
		UPDATE conGruposCont
		SET	@lIdentidad = conGruposCont,
			Grupo_Id = @pGrupo_Id_Nuevo,
			Empresa_Id = @pEmpresa_Id,
			Descripcion = @pDescripcion,
			Inactivo = @pInactivo,
			Usuario_Id = @pUsuario_Id,
			Posteado = @pPosteado
		WHERE Grupo_Id = @pGrupo_Id
END 
ELSE 
BEGIN 
	INSERT INTO conGruposCont
	(   Grupo_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado )
	VALUES 
	(	@pGrupo_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int)	
END 
Select @lIdentidad as RetVal 


GO
Drop Procedure conGruposContDatos
GO
CREATE PROCEDURE conGruposContDatos(
@pGrupo_Id varchar (5)
)
AS
DECLARE @pIdentidad INT 

set @pIdentidad= (SELECT conGruposCont FROM conGruposCont WHERE 
	conGruposCont.Grupo_Id = @pGrupo_Id)

SELECT conGruposCont.conGruposCont, conGruposCont.Grupo_Id, conGruposCont.Empresa_Id, Cast( Case When conGruposCont.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	conGruposCont.Descripcion, conGruposCont.Inactivo, genUsuarios.Usuario_Id, 
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, conGruposCont.Posteado
FROM conGruposCont 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conGruposCont.Usuario_Id)
WHERE (Grupo_Id = @pGrupo_Id)


Execute conGrupoCentroDatos @pIdentidad, null, null
Exec genAtributosGeneralesIdentityDatos @pIdentidad, 'conGruposCont'

GO
Drop Procedure conGruposContEliminar
GO
Create Procedure conGruposContEliminar(
@pGrupo_Id varchar (5)
 
) 
AS 
SET NOCOUNT ON  
DELETE FROM conGruposCont 
	 Where 
	conGruposCont.Grupo_Id = @pGrupo_Id
 
 RETURN @@Error 

GO

Drop Function FuncFKconGruposCont
GO

Create Function FuncFKconGruposCont
(
@pGrupo_Id varchar (5)
)
Returns int

As
Begin
  Declare @pIdentity int
  Select @pIdentity = conGruposCont From conGruposCont Where 
	Grupo_Id = @pGrupo_Id
  Return @pIdentity
End


GO