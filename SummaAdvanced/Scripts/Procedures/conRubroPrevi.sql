drop Procedure conRubroPreviDatos
go
create Procedure conRubroPreviDatos
(
@pRubroPrevi_Id varchar(5)
)
as
set nocount on
select RubroPrevi_Id, Descripcion, ActivoPasivo,Corriente,Orden,Empresa_Id from conRubrosPrevi
where RubroPrevi_Id=@pRubroPrevi_Id

select conCuentas.Cuenta_Id,conCuentas.Descripcion as DescripcionCuenta from conRubrosPreviCtas
inner join conCuentas on conCuentas.conCuentas=conRubrosPreviCtas.Cuenta_Id
where RubroPrevi_Id=@pRubroPrevi_Id
go
drop Procedure conRubroPreviGuardar
go
create Procedure conRubroPreviGuardar
(
@pRubroPrevi_Id varchar(5),
@pDescripcion varchar(100),
@pEmpresa_Id int,
@pActivoPasivo char(1),
@pCorriente sino,
@pOrden int
)
as
set nocount on
if( exists(select 1 from conRubrosPrevi where RubroPrevi_Id=@pRubroPrevi_Id))
begin
update conRubrosPrevi set Descripcion=@pDescripcion, Empresa_Id=@pEmpresa_Id, ActivoPasivo=@pActivoPasivo,
Corriente=@pCorriente,Orden=@pOrden
end
else
begin
insert into conRubrosPrevi (RubroPrevi_Id,Descripcion,Empresa_Id,ActivoPasivo,Corriente,Orden)
values(@pRubroPrevi_Id,@pDescripcion,@pEmpresa_Id,@pActivoPasivo,@pCorriente,@pOrden)
end
go
drop procedure conRubroPreviEliminar
go
create procedure conRubroPreviEliminar
(
@pRubroPrevi_Id varchar(5)
)
as
delete from conRubrosPrevi where RubroPrevi_Id=@pRubroPrevi_Id
go