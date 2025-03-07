-- genPermisosUsuarioDatos 'ADMINSUMMA', 'MX', 1
DROP PROCEDURE genPermisosUsuarioDatos
GO
CREATE PROCEDURE genPermisosUsuarioDatos
(
	@pUsuario_id VarChar(25) , 
	@pDominio_Id VarChar(2), 
	@pEmpresa_Id  int
)
AS
DECLARE @pUsuarioint Int 
select Usuario_Id, Apellido_y_Nombres, EsSupervisor 
from genUsuarios
Where
genUsuarios.Usuario_Id= @pUsuario_id

SELECT @pUsuarioint = genUsuarios.genUsuarios
from genUsuarios
Where
genUsuarios.Usuario_Id = @pUsuario_id



SELECT genMenusOrden.Orden, gm.Orden, gm.Inactivo,
	gm.genMenus OrdenId,
	--cast (isnull((select max(m.orden) from genMenus m where m.orden < gm.orden and m.Nivel =  gm.Nivel - 1), -1) as int) as OrdenPadre,
	--cast (isnull((select max(m.genMenus) from genMenus m where m.genMenus < gm.genMenus and m.Nivel =  gm.Nivel - 1), -1) as int) as OrdenPadre,
	cast (isnull((select max(mmax.genMenus) from genMenus mmax where mmax.orden = (select max(m.orden) from genMenus m where m.orden < gm.orden and m.Nivel =  gm.Nivel - 1)), -1) as int) as OrdenPadre,
	gm.Nivel, 
	gm.Tipo, 
	disFormularios.Formulario_Id, 
	isnull(disFormularios.Titulo, gm.Opcion) as Opcion, 
		Convert(bit, ISNULL(Consultar,0)) Consultar , 
		Convert(bit,ISNULL(Actualizar,0)) Actualizar, 
		Convert(bit,ISNULL(Borrar,0)) Borrar, 
		Convert(bit,ISNULL(Postear,0)) Postear, 
		Convert(bit,ISNULL(ModificaCodigos,0)) ModificaCodigos , 
		Convert(bit,case when genPermisos.Empresa_Id is null then 1 else 0 end) as ParaTodasLasEmpresas,
		Convert(bit, ISNULL(Consultar,0)) ConsultarA , 
		Convert(bit,ISNULL(Actualizar,0)) ActualizarA, 
		Convert(bit,ISNULL(Borrar,0)) BorrarA, 
		Convert(bit,ISNULL(Postear,0)) PostearA, 
		Convert(bit,ISNULL(ModificaCodigos,0)) ModificaCodigosA , 
		Convert(bit,case when genPermisos.Empresa_Id is null then 1 else 0 end) as ParaTodasLasEmpresasA
FROM genMenus gm
LEFT OUTER JOIN disFormularios ON gm.Formulario_Id = disFormularios.disFormularios
LEFT OUTER JOIN genPermisos ON genPermisos.Usuario_id = @pUsuarioInt 
							and @pEmpresa_Id  = ISNULL(genPermisos.Empresa_Id, @pEmpresa_Id ) 
							and genPermisos.Formulario_Id = disFormularios.disFormularios

Inner Join genMenusOrden On genMenusOrden.Opcion = SUBSTRING(gm.Orden, 1, 1)
Where(disFormularios.Formulario_Id  IS NOT NULL  OR gm.Tipo = 'S') 
AND (Pais is null or Pais like '%'+@pDominio_Id+'%')
And gm.Inactivo = 0
ORDER BY 1, 2

select genPermisosEsp.Permiso_Id, genPermisosEsp.Descripcion as DescripcionPermiosEsp, 
	Cast(Case when genUsuarioPermisosEsp.Usuario_Id  IS null then 0 else 1 end as bit) as Marcado
FROM genUsuarios Cross join genPermisosEsp
left join genUsuarioPermisosEsp ON 
	genUsuarios.genUsuarios = genUsuarioPermisosEsp.Usuario_Id AND 
	genPermisosEsp.Permiso_Id = genUsuarioPermisosEsp.Permiso_Id
WHERE 
genUsuarios.Usuario_Id = @pUsuario_Id 
order by 1


GO

DROP PROCEDURE genPermisosUsuarioEliminar
GO
CREATE PROCEDURE genPermisosUsuarioEliminar
(
	@pUsuario_id VarChar(25) , 
	@pEmpresa_Id  int
)
AS
DECLARE @pUsuarioint Int 

SELECT @pUsuarioint = genUsuarios.genUsuarios
from genUsuarios
Where
genUsuarios.Usuario_Id = @pUsuario_id

DELETE FROM GenPermisos where
	genPermisos.Usuario_id = @pUsuarioInt and 
	@pEmpresa_Id  = ISNULL(genPermisos.Empresa_Id, @pEmpresa_Id) 
GO

-- exec genPermisosUsuarioDatos 'ADMINISumma', 'AR', 1