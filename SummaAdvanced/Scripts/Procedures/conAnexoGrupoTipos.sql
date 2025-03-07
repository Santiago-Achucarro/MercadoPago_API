Drop procedure conAnexoGrupoTiposInsertar
go
create procedure conAnexoGrupoTiposInsertar
(
@pGruposAne_Id varchar(5),
@pTipo_Id varchar(5)
)
as
set nocount on
insert into conAnexoGrupoTipos
(
GrupoAne_Id,
Tipo_id
)
values
(
@pGruposAne_Id,
@pTipo_Id
)
go

drop procedure conAnexoGrupoTiposEliminar
go
create procedure conAnexoGrupoTiposEliminar
(
@pGrupoAne_Id varchar(5),
@pTipo_Id varchar(5)=null
)
as
set nocount on
delete from conAnexoGrupoTipos
where GrupoAne_Id=@pGrupoAne_Id and isnull(@pTipo_Id,Tipo_Id) =Tipo_Id
go




