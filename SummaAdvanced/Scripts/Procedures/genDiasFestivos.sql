drop procedure genDiasFestivosDatos
go
create procedure genDiasFestivosDatos
as
select 1 as NoUsado
select Fecha,Descripcion from genDiasFestivos
go

drop procedure  genDiasFestivosEliminar
go
create procedure genDiasFestivosEliminar
as
delete genDiasFestivos
go

drop procedure  genDiasFestivosGuardar
go
create procedure genDiasFestivosGuardar
(
    @pFecha datetime,
    @pDescripcion varchar(30)
)
as
insert into genDiasFestivos(Fecha, Descripcion) VALUEs (@pFecha, @pDescripcion)
go


drop procedure genDiasFestivosFechaDatos
go
create procedure genDiasFestivosFechaDatos
(
	@Fecha DateTime
)
as

select Fecha,Descripcion from genDiasFestivos
Where 
	genDiasFestivos.Fecha = @Fecha
go
