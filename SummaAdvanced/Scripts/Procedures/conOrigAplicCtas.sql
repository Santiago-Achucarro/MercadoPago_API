drop procedure conOrigAplicCtasInsertar
go
create procedure conOrigAplicCtasInsertar
(
@pGrupoOAF_Id varchar(5),
@pCuenta_Id varchar(25),
@pNetoDebeHaber varchar(1)
)
as
set nocount on
insert into conOrigAplicCtas (GrupoOAF_Id, Cuenta_Id, NetoDebeHaber)
values(@pGrupoOAF_Id,dbo.FuncFKconCuentas(@pCuenta_Id),@pNetoDebeHaber)
go

drop procedure conOrigAplicCtasEliminar
go
create procedure conOrigAplicCtasEliminar
(
@pGrupoOAF_Id varchar(5)
)
as
set nocount on
delete from conOrigAplicCtas where GrupoOAF_Id=@pGrupoOAF_Id
go
