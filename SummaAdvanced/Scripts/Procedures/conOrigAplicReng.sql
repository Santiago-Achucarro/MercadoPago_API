drop procedure conOrigAplicRengDatos
go
create procedure conOrigAplicRengDatos
(
@pGrupoOAF_Id varchar(5)
)
as
set nocount on

select GrupoOAF_Id,Empresa_Id,Destino,Origen,Descripcion, Cast( Case When Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) 
as PTodasEmpresas 
From conOrigAplicReng
where conOrigAplicReng.GrupoOAF_Id=@pGrupoOAF_Id

select GrupoOAF_Id,conCuentas.Cuenta_Id, conCuentas.Descripcion,NetoDebeHaber from conOrigAplicCtas 
inner join conCuentas on conCuentas.conCuentas=conOrigAplicCtas.Cuenta_Id
go


drop Procedure conOrigAplicRengGuardar
go
create Procedure conOrigAplicRengGuardar
(
@pGrupoOAF_Id varchar(5),
@pEmpresa_Id int,
@pDestino int,
@pOrigen int=null,
@pDescripcion varchar(100)
)
as
set nocount on
if(exists(select 1 from conOrigAplicReng where conOrigAplicReng.GrupoOAF_Id =@pGrupoOAF_Id))
begin
update conOrigAplicReng set Empresa_Id=@pEmpresa_Id, Destino=@pDestino,Origen=@pOrigen,Descripcion=@pDescripcion
end
else
begin
insert into conOrigAplicReng (GrupoOAF_Id,Empresa_Id,Destino,Origen,Descripcion)
values (@pGrupoOAF_Id,@pEmpresa_Id,@pDestino, 0,@pDescripcion)
end
go


drop procedure conOrigAplicRengEliminar
go
create procedure conOrigAplicRengEliminar
(
@pGrupoOaf_Id varchar(5)
)
as
delete from conOrigAplicReng where GrupoOAF_Id=@pGrupoOAF_Id
go
