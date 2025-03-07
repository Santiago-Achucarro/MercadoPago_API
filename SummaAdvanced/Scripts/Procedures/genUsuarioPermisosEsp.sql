DROP PROCEDURE genUsuarioPermisosEspGuardar
GO
CREATE PROCEDURE genUsuarioPermisosEspGuardar
(
@pUsuario_Id VarChar(25),
@pPermiso_Id int
)
AS
SET NOCOUNT ON 
	INSERT INTO genUsuarioPermisosEsp
	(
		Usuario_Id,
		Permiso_Id
	)
	VALUES 
	(
		dbo.FuncFKgenUsuarios(@pUsuario_Id),
		@pPermiso_Id
	)
GO
-- genUsuarioPermisosEspDatos 'ADMINSUMMA' ,1
DROP PROCEDURE genUsuarioPermisosEspDatos
GO
CREATE PROCEDURE genUsuarioPermisosEspDatos
(
@pUsuario_Id VarChar(25),
@pPermiso_Id int = NULL
)
AS
SET NOCOUNT ON 

SELECT genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	@pPermiso_Id  as Permiso_Id
FROM genUsuarios
Where
	genUsuarios.Usuario_Id = @pUsuario_Id 

select genPermisosEsp.Permiso_Id, genPermisosEsp.Descripcion as DescripcionPermiosEsp, 
	Cast(Case when genUsuarioPermisosEsp.Usuario_Id  IS null then 0 else 1 end as bit) as Marcado
FROM genUsuarios Cross join genPermisosEsp
INNER join genUsuarioPermisosEsp ON 
	genUsuarios.genUsuarios = genUsuarioPermisosEsp.Usuario_Id AND 
	genPermisosEsp.Permiso_Id = genUsuarioPermisosEsp.Permiso_Id
WHERE 
genUsuarios.Usuario_Id = @pUsuario_Id AND 
genPermisosEsp.Permiso_Id = isnull(@pPermiso_Id, genPermisosEsp.Permiso_Id)
order by 1
 
RETURN @@Error 

GO

DROP PROCEDURE genUsuarioPermisosEspEliminar
GO
CREATE PROCEDURE genUsuarioPermisosEspEliminar
(
@pUsuario_Id varchar(25),
@pPermiso_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genUsuarioPermisosEsp 
WHERE (Usuario_Id = dbo.FuncFKgenUsuarios(@pUsuario_Id))
AND (Permiso_Id = ISNULL( @pPermiso_Id,Permiso_Id))
 
 RETURN @@Error 

GO
