--genPermisosCopiar 1, 3

DROP PROCEDURE genPermisosCopiar
GO
CREATE PROCEDURE genPermisosCopiar
(
	@pUsuario_id VarChar(25) , 
	@pUsuarioN_Id VarChar(25)
)
AS
SET NOCOUNT ON
/*
DELETE FROM genPermisos 
	Where genPermisos.Usuario_Id = dbo.FuncFKgenUsuarios(@pUsuarioN_Id)
*/

INSERT INTO  genPermisos
	(Usuario_Id , 
	Formulario_Id , 
	Empresa_id,
	Consultar , 
	Actualizar , 
	Borrar , 
	Postear,
	ModificaCodigos
	) 
	SELECT dbo.FuncFKgenUsuarios(@pUsuarioN_id) as Usuario_Id,
		genPermisos.Formulario_Id, 
		genPermisos.Empresa_Id,
		genPermisos.Consultar, 
		genPermisos.Actualizar,
		genPermisos.Borrar,
		genPermisos.Postear,
		genPermisos.ModificaCodigos
FROM genPermisos
Left Join genPermisos YaExistentes On YaExistentes.Usuario_Id = dbo.FuncFKgenUsuarios(@pUsuarioN_Id) And
	YaExistentes.Formulario_Id = genPermisos.Formulario_Id
Where genPermisos.Usuario_id = dbo.FuncFKgenUsuarios(@pUsuario_Id) And YaExistentes.Postear Is Null

GO