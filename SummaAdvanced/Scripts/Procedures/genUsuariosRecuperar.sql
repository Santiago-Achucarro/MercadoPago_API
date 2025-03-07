drop procedure genUsuariosRecuperar
go
create procedure genUsuariosRecuperar
(
    @pUsuario_Id varchar(25),
    @pEmpresa_Id varchar(15)
)
as
select genUsuarios.genUsuarios, genUsuarios.Usuario_Id, genEmpresas.Empresa_Id, genUsuarios.Email, genEmpresas.Correo as EmailEmpresa, genEmpresas.Servidor, genEmpresas.Seguridad, 
genEmpresas.Puerto, genEmpresas.Clave, '' as ClaveNueva,
genusuarios.Email as EmailUsuario from genusuarios
cross join genEmpresas
where genEmpresas.Empresa_Id=@pEmpresa_Id and genUsuarios.Usuario_Id=@pUsuario_Id
go
