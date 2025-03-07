drop procedure swsPermisosDatos
go
create procedure swsPermisosDatos
(
    @pUsuario_Id varchar(25)
)
as
select genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres from genUsuarios where genUsuarios.Usuario_Id=@pUsuario_Id
select genUsuarios.genUsuarios, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, sisAccionesConfig.Accion_Id, sisAccionesConfig.Descripcion, cast(case when swsPermisos.Accion_Id is null then 0 else 1 end as bit) as Marca from genUsuarios
cross join swsAcciones
inner join sisAccionesConfig on sisAccionesConfig.Accion_Id=swsAcciones.Accion_Id
left join swsPermisos on swsPermisos.Accion_Id=swsAcciones.Accion_Id and swsPermisos.Usuario_Id=genUsuarios.genUsuarios
where genUsuarios.Usuario_Id=@pUsuario_Id
go

drop procedure swsPermisosGuardar
go
create procedure swsPermisosGuardar
(
    @pUsuario_Id varchar(25),
    @pAccion_Id varchar(200)
)
as
insert into swsPermisos (Usuario_Id, Accion_Id) VALUES(dbo.FuncFKgenUsuarios(@pUsuario_Id), @pAccion_Id)
go

drop procedure swsPermisosEliminar
go
create procedure swsPermisosEliminar
(
    @pUsuario_Id varchar(25)
)
as
delete swsPermisos where Usuario_Id=dbo.FuncFKgenUsuarios(@pUsuario_Id)