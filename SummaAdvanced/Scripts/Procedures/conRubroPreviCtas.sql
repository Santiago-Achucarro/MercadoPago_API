drop Procedure conRubroPreviCtasInsertar
go
create Procedure conRubroPreviCtasInsertar
(
@pRubroPrevi_Id varchar(5),
@pCuenta_Id varchar(25)
)
as
set nocount on
insert into conRubrosPreviCtas(RubroPrevi_Id,Cuenta_Id)
values(@pRubroPrevi_Id,dbo.FuncFKconCuentas(@pCuenta_Id))
go

drop procedure conRubroPreviCtasEliminar
go
create procedure conRubroPreviCtasEliminar
(
@pRubroPrevi_Id varchar(5)
)
as
set nocount on
delete from conRubrosPreviCtas where conRubrosPreviCtas.RubroPrevi_Id=@pRubroPrevi_Id
GO

