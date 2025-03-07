DROP PROCEDURE Inf_genPermisos 
GO
CREATE PROCEDURE Inf_genPermisos (
@UsuarioDesde VarChar(25), 
@UsuarioHasta VarChar(25), 
@Empresa Int
)
as

SELECT genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, 
	genMenus.Orden, 	
	disFormularios.Formulario_Id, disFormularios.Titulo, 
	genPermisos.Consultar, genPermisos.Actualizar, genPermisos.Borrar, 
	genPermisos.Postear, genPermisos.ModificaCodigos, '  ' AS Grupo
FROM genPermisos inner join disFormularios ON
genPermisos.Formulario_Id =disFormularios.disFormularios
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = genPermisos.Usuario_Id
INNER JOIN genMenus ON
genMenus.Formulario_id = disFormularios.disFormularios
Where
genUsuarios.Usuario_Id between @UsuarioDesde And @UsuarioHasta
UNION ALL
SELECT genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, 
	genMenus.Orden, 
	disFormularios.Formulario_Id, disFormularios.Titulo, 
	genPermisos.Consultar, genPermisos.Actualizar, genPermisos.Borrar, 
	genPermisos.Postear, genPermisos.ModificaCodigos, Grupo.Usuario_Id AS Grupo
FROM genPermisos inner join disFormularios ON
genPermisos.Formulario_Id =disFormularios.disFormularios
INNER JOIN genGrupos ON
genGrupos.Grupo_Id =genPermisos.Usuario_Id
INNER JOIN genUsuarios as Grupo on 
Grupo.genUsuarios = genGrupos.Grupo_Id
INNER JOIN genUsuarios ON
genUsuarios.genUsuarios = genGrupos.Usuario_Id
INNER JOIN genMenus ON
genMenus.Formulario_id = disFormularios.disFormularios

Where
	genUsuarios.Usuario_Id between @UsuarioDesde And @UsuarioHasta AND 
	ISNULL(genPermisos.Empresa_Id,@Empresa) = @Empresa
ORDER BY 1, 3

go