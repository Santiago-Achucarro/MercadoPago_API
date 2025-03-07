--conAnexosGruposDatos 'COS'
DROP PROCEDURE conAnexosGruposDatos
GO
CREATE PROCEDURE conAnexosGruposDatos
(
@pGrupoAne_Id varchar(5)
)
as
select conAnexosGrupos.GrupoAne_ID, conAnexosGrupos.Descripcion, orden, conAnexosGrupos.Origen,
conAnexosOrigenes.Descripcion as DescripcionOrigen, conAnexosOrigenes.TipoRubro as VerifTipo,
conAnexosGrupos.Description
From conAnexosGrupos INNER JOIN conAnexosOrigenes on conAnexosGrupos.Origen=conAnexosOrigenes.Origen
where conAnexosGrupos.GrupoAne_Id=@pGrupoAne_Id

SELECT conAnexoGrupoTipos.Tipo_Id, conTiposContables.Descripcion, conRubros.Tipo
FROM conAnexoGrupoTipos
INNER JOIN conTiposContables on conAnexoGrupoTipos.Tipo_Id= conTiposContables.Tipo_Id
inner join conRubros on conTiposContables.Rubro_Id=conRubros.Rubro_Id
WHERE 
conAnexoGrupoTipos.GrupoAne_Id=@pGrupoAne_Id
go

drop PROCEDURE conAnexosGruposGuardar
go
CREATE PROCEDURE conAnexosGruposGuardar
(
@pGrupoAne_Id varchar(5),
@pDescripcion varchar(60),
@pOrden int,
@pOrigen int, 
@pDescription VarChar(60)
)
as
set nocount on
if(exists(select 1 from conAnexosGrupos where GrupoAne_Id=@pGrupoAne_Id))
begin
update conAnexosGrupos
set Descripcion=@pDescripcion, Orden=@pOrden, Origen=@pOrigen , 
Description = @pDescription
WHERE GrupoAne_Id=@pGrupoAne_Id
end
else
begin
insert into conAnexosGrupos
(
GrupoAne_Id,
Descripcion,
Orden,
Origen,
Description
)
values
(
@pGrupoAne_Id,
@pDescripcion,
@pOrden,
@pOrigen, 
@pDescription
)
end
go

drop procedure conAnexosGruposEliminar
go
create procedure conAnexosGruposEliminar
(
@pGrupoAne_Id varchar (25)
)
as
set nocount on
delete from conAnexosGrupos where GrupoAne_Id=@pGrupoAne_Id
go
