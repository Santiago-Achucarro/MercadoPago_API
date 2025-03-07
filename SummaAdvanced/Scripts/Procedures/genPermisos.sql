Drop Procedure genPermisosGuardar
GO
Create Procedure genPermisosGuardar
(
@pUsuario_Id VarChar(25), 
@pFormulario_Id VarChar(45), 
@pEmpresa_id int=null,
@pConsultar Sino, 
@pActualizar Sino, 
@pBorrar Sino, 
@pPostear Sino, 
@pModificaCodigos SiNO 
) 
AS 



SET NOCOUNT ON  
IF (EXISTS (SELECT 1 FROM genPermisos WHERE 
	Usuario_Id = dbo.FuncFkgenUsuarios(@pUsuario_Id) and 
	Formulario_Id = dbo.FuncFKdisformularios(@pFormulario_Id)
))
BEGIN 
	UPDATE genPermisos SET 
	Empresa_id = @pEmpresa_id,
	Consultar = @pConsultar, 
	Actualizar = @pActualizar, 
	Borrar = @pBorrar, 
	Postear = @pPostear , 
	ModificaCodigos = @pModificaCodigos
	WHERE 
	Usuario_Id = dbo.FuncFkgenUsuarios(@pUsuario_Id) and 
	Formulario_Id = dbo.FuncFKdisformularios(@pFormulario_Id)
 
END 
ELSE
BEGIN
	INSERT INTO  genPermisos
	(Usuario_Id , 
	Formulario_Id , 
	Empresa_id,
	Consultar , 
	Actualizar , 
	Borrar , 
	Postear,
	ModificaCodigos ) 
	Values 
	(dbo.FuncFkgenUsuarios(@pUsuario_Id) , 
	dbo.FuncFKdisformularios(@pFormulario_Id), 
	@pEmpresa_id,
	@pConsultar , 
	@pActualizar , 
	@pBorrar , 
	@pPostear,
	@pModificaCodigos ) 
END
RETURN @@Error 

GO
Drop Procedure genPermisosDatos
GO
CREATE PROCEDURE genPermisosDatos(
@pUsuario_Id int,
@pEmpresa_id int,
@pFormulario_Id VarChar(45)=null 
)
AS

SELECT  Usuario_id, Formulario_Id,   Descripcion,
	CAST(max(PTodasEmpresas) as bit) PTodasEmpresas, 
	CAST(max(Consultar) as bit) Consultar, 
	CAST(max(Actualizar) as bit) Actualizar, 
	CAST(max(Borrar) as bit) Borrar, 
	CAST(max(Postear) as bit) Postear, 
	CAST(max(ModificaCodigos) as bit) ModificaCodigos
FROM 
(
SELECT genUsuarios.genUsuarios as Usuario_id, 
	disFormularios.Formulario_Id,  disFormularios.Descripcion, 
	CASE WHEN genPermisos.Empresa_id is null then 0 else 1 end as PTodasEmpresas,
	cast(genPermisos.Consultar as bit) as Consultar, 	
	cast(genPermisos.Actualizar as bit) as Actualizar, 
	cast(genPermisos.Borrar as bit) as Borrar, 
	cast(genPermisos.Postear as bit) as Postear, 
	cast(genPermisos.ModificaCodigos as bit) as ModificaCodigos
 FROM genPermisos  INNER JOIN disFormularios
	ON disFormularios.disFormularios=genPermisos.Formulario_Id
 INNER JOIN genUsuarios
	ON genUsuarios.genUsuarios=genPermisos.Usuario_Id
 Where 
	genPermisos.Usuario_Id = @pUsuario_Id and 
	isnull(genPermisos.Empresa_id,@pEmpresa_id) = @pEmpresa_id and 
	disFormularios.Formulario_Id = ISNULL(@pFormulario_Id, disFormularios.Formulario_Id)  
	
UNION ALL
SELECT genUsuarios.genUsuarios as Usuario_id, 
	disFormularios.Formulario_Id,  disFormularios.Descripcion, 
	CASE WHEN genUsuarios.Empresa_Id is null then 0 else 1 end as PTodasEmpresas,
	1 AS Consultar,  1 AS Actualizar, 
	1 as Borrar, 1 as Postear, 1 as ModificaCodigos
 FROM disFormularios CROSS JOIN  genUsuarios
 WHERE
	genUsuarios.EsSupervisor=1  And
	 genUsuarios.genUsuarios=@pUsuario_Id  and 
	 disFormularios.Formulario_Id = ISNULL(@pFormulario_Id, disFormularios.Formulario_Id)  and 
	 isnull(genUsuarios.Empresa_id,@pEmpresa_id) = @pEmpresa_id
	
UNION ALL
SELECT genUsuarios.genUsuarios as Usuario_id, 
	disFormularios.Formulario_Id, disFormularios.Descripcion, 
	CASE WHEN genPermisos.Empresa_id is null then 0 else 1 end as PTodasEmpresas,
	genPermisos.Consultar, 	genPermisos.Actualizar, 
	genPermisos.Borrar, genPermisos.Postear, genPermisos.ModificaCodigos
 FROM genPermisos  INNER JOIN disFormularios
	ON disFormularios.disFormularios=genPermisos.Formulario_Id
 INNER JOIN genGrupos
	ON genGrupos.Grupo_id =genPermisos.Usuario_Id
INNER JOIN genUsuarios ON
		genUsuarios.genUsuarios = genGrupos.Usuario_id
 Where 
	genUsuarios.genUsuarios = @pUsuario_Id and 
	disFormularios.Formulario_Id = ISNULL(@pFormulario_Id, disFormularios.Formulario_Id)  and 
	isnull(genPermisos.Empresa_id,@pEmpresa_id) = @pEmpresa_id ) AS XXX
group by Usuario_id, Formulario_Id, Descripcion


GO
Drop Procedure genPermisosEliminar
GO
Create Procedure genPermisosEliminar(
@pUsuario_Id int, 
@pFormulario_Id VarChar(45) 
 
) 
AS 
SET NOCOUNT ON  


DELETE FROM genPermisos 
	 Where 
	genPermisos.Usuario_Id = @pUsuario_Id and 
	genPermisos.Formulario_Id = isnull(dbo.FuncFKgenOrigenes(@pFormulario_Id),genPermisos.Formulario_Id)
 
RETURN @@Error 

GO

Drop Procedure genPermisosDatosTodos
GO
CREATE PROCEDURE genPermisosDatosTodos(
@pUsuario_Id VarChar(25)
)
AS



SELECT genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres 
from genUsuarios where 
genUsuarios.Usuario_Id = @pUsuario_Id

SELECT disFormularios.Formulario_Id ,  disFormularios.Descripcion as DescripcionFormulario,  
	disFormularios.disFormularios, genPermisos.Empresa_id, 
	Cast(ISNULL(genPermisos.Consultar,0) as Bit) AS Consultar  , 
	Cast(isnull(genPermisos.Actualizar,0) as Bit) as Actualizar, 
	Cast(IsNull(genPermisos.Borrar,0) as Bit) as Borrar , 
	Cast(IsNull(genPermisos.Postear ,0) as Bit) as Postear, 
	Cast(IsNull(genPermisos.ModificaCodigos,0) as Bit) ModificaCodigos
 FROM disFormularios LEFT OUTER JOIN 
	(genPermisos INNER JOIN genUsuarios  ON 
		genPermisos.Usuario_Id = genUsuarios.genUsuarios ) on
		disFormularios.disFormularios=genPermisos.Formulario_Id and 
		genUsuarios.Usuario_Id = @pUsuario_Id

GO




--genPermisosDatosTodos 'ADMINSUMMA'

