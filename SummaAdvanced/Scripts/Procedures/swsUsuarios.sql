drop procedure swsUsuariosDatos
go
create procedure swsUsuariosDatos
(
    @pTodos SiNo
)
as
select @pTodos as Todos
select genUsuarios.genUsuarios, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, cast(case when swsUsuarios.Usuario_Id is null then 0 else 1 end as bit) as Marca from genUsuarios
left join swsUsuarios on swsUsuarios.Usuario_Id=genUsuarios.genUsuarios
where swsUsuarios.Usuario_Id is not null or @pTodos=1
go

drop procedure swsUsuariosGuardar
go
create procedure swsUsuariosGuardar
(
    @pUsuario_Id varchar(25)
)
as
insert into swsUsuarios(Usuario_Id, PASSWORD) values (dbo.FuncFKgenUsuarios(@pUsuario_Id),'')
go

drop procedure swsUsuariosEliminar
go
create procedure swsUsuariosEliminar
(
    @pUsuario_Id varchar(25) =null
)
as
delete swsUsuarios where swsUsuarios.Usuario_Id=ISNULL(dbo.FuncFKgenUsuarios(@pUsuario_Id), Usuario_Id)
GO


drop procedure swsUsuariosActuPassword
go
create procedure swsUsuariosActuPassword
(
    @pUsuario_Id varchar(25),
    @pPassword varchar(50)
)
as
update swsUsuarios set Password=@pPassword from swsUsuarios inner join genUsuarios on genUsuarios.genUsuarios=swsUsuarios.Usuario_Id
where genUsuarios.Usuario_Id=@pUsuario_Id
go
