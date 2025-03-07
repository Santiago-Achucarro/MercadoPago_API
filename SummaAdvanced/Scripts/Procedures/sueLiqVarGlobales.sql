drop procedure sueLiqVarGlobalesDatos
go
create procedure sueLiqVarGlobalesDatos
(
@pFecha datetime,
@pEmpresa_Id int
)
as
select @pFecha as Fecha

select sueVarGlobales.VarGlobal_Id, sueVarGlobales.Descripcion as DescripcionVarGlobal, 
Fecha_Desde, isnull(Valor,0) as Valor, sueLiqVarGlobales.Usuario_Id, 0 as Empresa_Id,sueLiqVarGlobales.Ver from sueVarGlobales
left join sueLiqVarGlobales on sueVarGlobales.VarGlobal_Id=sueLiqVarGlobales.VarGlobal_Id and @pFecha between Fecha_Desde and Fecha_Hasta
where sueVarGlobales.PorEmpresa=0
union all
select sueVarGlobales.VarGlobal_Id, sueVarGlobales.Descripcion as DescripcionVarGlobal,
Fecha_Desde, isnull(Valor,0) as Valor, sueLiqVarEmpGlobales.Usuario_Id, sueLiqVarEmpGlobales.Empresa_Id,null as Ver from sueVarGlobales
left join sueLiqVarEmpGlobales on sueVarGlobales.VarGlobal_Id=sueLiqVarEmpGlobales.VarGlobal_Id and
sueLiqVarEmpGlobales.Empresa_Id=@pEmpresa_Id and
@pFecha between Fecha_Desde and Fecha_Hasta
where sueVarGlobales.PorEmpresa=1
order by 1
go

drop procedure sueLiqVarGlobalesGuardar
go
create procedure sueLiqVarGlobalesGuardar
(
@pVarGlobal_Id int,
@pFecha_Desde datetime,
@pValor qMonedaD4,
@pUsuario_Id int,
@pEmpresa_Id int,
@pVer int
)
as
--Si no habia valor para esta variable asigno la fecha de incio de summa
set @pFecha_Desde= case when exists(select 1 from sueLiqVarGlobales where VarGlobal_Id=@pVarGlobal_Id and Fecha_Hasta='29990101') then (@pFecha_Desde) else (select FechaInicioSumma from genEmpresas where genEmpresas=@pEmpresa_Id) end
-- si no cambio nada del valor actual no hago nada
if not exists(select 1 from sueLiqVarGlobales where Fecha_Hasta='29990101' and VarGlobal_Id=@pVarGlobal_Id and Valor=@pValor)
begin
-- si el valor actual tiene la misma fecha desde solo cambio el valor
if exists (select 1 from sueLiqVarEmpGlobales where Fecha_Desde=@pFecha_Desde and Fecha_Hasta='29990101' and VarGlobal_Id=@pVarGlobal_Id)
begin
update sueLiqVarEmpGlobales set Valor=@pValor where Fecha_Desde=@pFecha_Desde and Fecha_Hasta='29990101' and VarGlobal_Id=@pVarGlobal_Id
end
else
begin
update sueLiqVarGlobales set Fecha_Hasta=DATEADD(dd,-1,@pFecha_Desde) where VarGlobal_Id=@pVarGlobal_Id and Fecha_Hasta='29990101'
insert into sueLiqVarGlobales (VarGlobal_Id, Valor, Usuario_Id, Fecha_Desde, Fecha_Hasta,Ver) values (@pVarGlobal_Id, @pValor, @pUsuario_Id, @pFecha_Desde, '29990101',@pVer)
end
end
go

drop procedure sueLiqVarEmpGlobalesGuardar
go
create procedure sueLiqVarEmpGlobalesGuardar
(
@pVarGlobal_Id int,
@pFecha_Desde datetime,
@pValor qMonedaD4,
@pUsuario_Id int,
@pEmpresa_Id int
)
as
--Si no habia valor para esta variable asigno la fecha de incio de summa
set @pFecha_Desde= case when exists(select 1 from sueLiqVarEmpGlobales where VarGlobal_Id=@pVarGlobal_Id and Empresa_Id=@pEmpresa_Id and Fecha_Hasta='29990101') then (@pFecha_Desde) else (select FechaInicioSumma from genEmpresas where genEmpresas=@pEmpresa_Id) end
--Si no Cambio ningun dato del valor actual no hago nada
if not exists(select 1 from sueLiqVarEmpGlobales where Fecha_Hasta='29990101' and VarGlobal_Id=@pVarGlobal_Id and Valor=@pValor and Empresa_Id= @pEmpresa_Id)
begin
-- si la el valor actual tiene la misma fecha desde solo actualizo el valor
if exists (select 1 from sueLiqVarEmpGlobales where Fecha_Desde=@pFecha_Desde and Fecha_Hasta='29990101' and VarGlobal_Id=@pVarGlobal_Id and Empresa_Id= @pEmpresa_Id)
begin
update sueLiqVarEmpGlobales set Valor=@pValor where Fecha_Desde=@pFecha_Desde and Fecha_Hasta='29990101' and VarGlobal_Id=@pVarGlobal_Id and Empresa_Id= @pEmpresa_Id
end
else
begin
update sueLiqVarEmpGlobales set Fecha_Hasta=DATEADD(dd,-1,@pFecha_Desde) where VarGlobal_Id=@pVarGlobal_Id and Fecha_Hasta='29990101' and Empresa_Id=@pEmpresa_Id
insert into sueLiqVarEmpGlobales (VarGlobal_Id, Valor, Usuario_Id, Fecha_Desde, Fecha_Hasta, Empresa_Id) values (@pVarGlobal_Id, @pValor, @pUsuario_Id, @pFecha_Desde, '29990101', @pEmpresa_Id)
end
end
go

drop procedure sueLiqVarGlobalesEliminar
go
create procedure sueLiqVarGlobalesEliminar
(
@pVarGlobal_Id int
)
as
delete sueLiqVarGlobales where @pVarGlobal_Id=VarGlobal_Id
go

drop procedure sueLiqVarEmpGlobalesEliminar
go
create procedure sueLiqVarEmpGlobalesEliminar
(
@pVarGlobal_Id int,
@pEmpresa_Id int
)
as
delete sueLiqVarEmpGlobales where @pVarGlobal_Id=VarGlobal_Id and Empresa_Id=@pEmpresa_Id
go

drop procedure sueLiqVarGlobalHistorico
go
create procedure sueLiqVarGlobalHistorico
(
@pVarGlobal_Id int,
@pEmpresa_Id int
)
as
select @pVarGlobal_Id as VarGlobal_Id
select sueVarGlobales.VarGlobal_Id, sueVarGlobales.Descripcion as DescripcionVarGlobal, 
Fecha_Desde, Valor, sueLiqVarGlobales.Usuario_Id, 0 as Empresa_Id,Ver from sueLiqVarGlobales
inner join sueVarGlobales on sueVarGlobales.VarGlobal_Id=sueLiqVarGlobales.VarGlobal_Id
where 
sueVarGlobales.VarGlobal_Id=@pVarGlobal_Id
union all
select sueVarGlobales.VarGlobal_Id, sueVarGlobales.Descripcion as DescripcionVarGlobal,
Fecha_Desde, Valor, sueLiqVarEmpGlobales.Usuario_Id, sueLiqVarEmpGlobales.Empresa_Id,Null as Ver from sueLiqVarEmpGlobales
inner join sueVarGlobales on sueVarGlobales.VarGlobal_Id=sueLiqVarEmpGlobales.VarGlobal_Id

where 
sueLiqVarEmpGlobales.Empresa_Id=@pEmpresa_Id and
sueVarGlobales.VarGlobal_Id=@pVarGlobal_Id
go

