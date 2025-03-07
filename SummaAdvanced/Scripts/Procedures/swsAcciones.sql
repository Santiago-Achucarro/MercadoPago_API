drop procedure swsAccionesGuardar
go
create procedure swsAccionesGuardar
(
    @pAccion_Id varchar(200)
)
as
if not exists(select 1 from swsAcciones where Accion_Id=@pAccion_Id)
begin
insert into swsAcciones(Accion_Id) VALUEs (@pAccion_Id)
end
go