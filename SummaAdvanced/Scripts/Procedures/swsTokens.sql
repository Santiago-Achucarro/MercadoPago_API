drop procedure swsTokenDatos
go
create procedure swsTokenDatos
(
    @pToken varchar(40),
    @pAccion varchar(200)
)
as
select genUsuarios.genUsuarios, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, genEmpresas.genEmpresas, genEmpresas.Empresa_Id, swsTokens.ValidThru, swsTokens.Token, genInstalacion.Dominio_Id, genMonedas.Moneda_Id, swsPermisos.Accion_Id from swsTokens
inner join genUsuarios on genUsuarios.genUsuarios=swsTokens.Usuario_Id
inner join genEmpresas on genEmpresas.genEmpresas=swsTokens.Empresa_Id
inner join genMonedas on genMonedas.genMonedas=genEmpresas.Moneda_Id
cross join genInstalacion
left join swsPermisos on swsPermisos.Usuario_Id=genUsuarios.genUsuarios and swsPermisos.Accion_Id=@pAccion
where swsTokens.Token=@pToken
GO

drop procedure swsTokenGenerar
go
create procedure swsTokenGenerar
(
    @pEmpresa_Id varchar(15),
    @pUsuario_Id varchar(25)
)
as
select genEmpresas.genEmpresas, genEmpresas.Empresa_Id, genEmpresas.RazonSocial as DescripcionEmpresa, genUsuarios.genUsuarios, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
swsUsuarios.Password, '' as Token, '' as Base64Key from swsUsuarios 
inner join genUsuarios on genUsuarios.genUsuarios=swsUsuarios.Usuario_Id
cross join genEmpresas
where genEmpresas.Empresa_Id=@pEmpresa_Id and genUsuarios.Usuario_Id=@pUsuario_Id
go

DROP procedure swsTokenGuardar
go
create procedure swsTokenGuardar
(
    @pToken varchar(50),
    @pUsuario_Id varchar(25),
    @pValidThru datetime,
    @pEmpresa_Id varchar(15)
)
as
insert into swsTokens (Token, Empresa_Id, Usuario_Id, ValidThru)
VALUES
(
    @pToken,
    dbo.FuncFKgenEmpresas(@pEmpresa_Id),
    dbo.FuncFKgenUsuarios(@pUsuario_Id),
    @pValidThru
)
go

drop procedure swsTokenEliminarVencidos
go
create procedure swsTokenEliminarVencidos
(
    @pFecha datetime
)
AS
delete swsTokens where ValidThru<@pFecha
go