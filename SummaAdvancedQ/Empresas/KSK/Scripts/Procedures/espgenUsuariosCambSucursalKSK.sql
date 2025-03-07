Drop procedure espgenUsuariosCambSucursalKSK
go

Create procedure espgenUsuariosCambSucursalKSK
(
    @pSucursal_Id int,  
    @pUsuario_Id varchar(25)
)
as
Update genUsuarios Set Sucursal= @pSucursal_Id Where Usuario_Id = @pUsuario_Id
go

Drop procedure espgenSucursalCookieKSK
Go
Create procedure espgenSucursalCookieKSK
As
Select '' Sucursal_Id, '' Descripcion
Go

