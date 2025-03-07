drop procedure genUsuariosSucursalDatos
go
create procedure genUsuariosSucursalDatos
(
    @pSucursal_Id Sucursal=null,
    @pEmpresa_Id varchar(15)=null,
    @pUsuario_Id varchar(25)=null
)
AS
select genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genEmpresas.Empresa_Id, genEmpresas.RazonSocial as DescripcionEmpresa, genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursal from genUsuariosSucursal
inner join genUsuarios on genUsuarios.genUsuarios=genUsuariosSucursal.Usuario_Id
inner join genEmpresas on genEmpresas.genEmpresas=genUsuariosSucursal.Empresa_Id
inner join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr=genUsuariosSucursal.Sucursal_Id
where genUsuarios.Usuario_Id=isnull(@pUsuario_Id,genUsuarios.Usuario_Id) AND
genSucursalesEmpr.Sucursal=isnull(@pSucursal_Id, genSucursalesEmpr.Sucursal) and
genEmpresas.Empresa_Id=isnull(@pEmpresa_Id, genEmpresas.Empresa_Id)
go

drop procedure genUsuariosSucursalInsertar
go
create procedure genUsuariosSucursalInsertar
(
    @pSucursal_Id Sucursal,
    @pEmpresa_Id varchar(15),
    @pUsuario_Id varchar(25)
)
AS
insert into genUsuariosSucursal
(
    Empresa_Id,
    Sucursal_Id,
    Usuario_Id
)
values
(
    dbo.FuncFKgenEmpresas(@pEmpresa_Id),
    dbo.FuncFKgenSucursalesEmpr(@pSucursal_Id),
    dbo.FuncFKgenUsuarios(@pUsuario_Id)
)
GO

drop procedure genUsuariosSucursalEliminar
go
create procedure genUsuariosSucursalEliminar
(
    @pSucursal_Id Sucursal=null,
    @pEmpresa_Id varchar(15)=null,
    @pUsuario_Id varchar(25)
)
AS
DELETE genUsuariosSucursal where Sucursal_Id=ISNULL(dbo.FuncFKgenSucursalesEmpr(@pSucursal_Id), Sucursal_Id) and
 Empresa_Id=ISNULL(dbo.FuncFKgenEmpresas(@pEmpresa_Id),Empresa_Id) and
  Usuario_Id=dbo.FuncFKgenUsuarios(@pUsuario_Id)
  go