drop procedure wooMigracionFamilias
go
create procedure wooMigracionFamilias
(
    @pEmpresa_Id int
)
as
select stkFamilias, stkFamilias.Familia_Id, Descripcion, stkFamilias.Empresa_Id, Inactivo, Posteado, Usuario_Id, wooFamiliasId.wooCommerceId from stkFamilias
left join wooFamiliasId on wooFamiliasId.Familia_Id=stkFamilias.stkFamilias

where stkFamilias.Empresa_Id=@pEmpresa_Id or stkFamilias.empresa_Id is null
go

drop procedure wooFamiliasGuardarId
go
create procedure wooFamiliasGuardarId
(
    @pFamilia_Id varchar(25),
    @pwooCommerceId bigint
)
as
if exists( select 1 from wooFamiliasId where Familia_Id=dbo.FuncFKstkFamilias(@pFamilia_Id))
begin
update wooFamiliasId set wooCommerceId=@pwooCommerceId where Familia_Id=dbo.FuncFKstkFamilias(@pFamilia_Id)
end
else
begin
insert into wooFamiliasId(Familia_Id, wooCommerceId) values(dbo.FuncFKstkFamilias(@pFamilia_Id), @pwooCommerceId)
end
go
