drop procedure sueVariablesMasivoDatos
go
create procedure sueVariablesMasivoDatos
(
@pLegajoDesde int,
@pLegajoHasta int,
@pConceptoDesde int,
@pConceptoHasta int,
@pGrupoFuente int=null,
@pGrupoDestino int,
@pEmpresa_Id INT
)
as
select @pLegajoDesde as Legajo_Desde, @pLegajoHasta as Legajo_Hasta, @pConceptoDesde as Concepto_Desde, @pConceptoHasta as Concepto_Hasta,
@pGrupoFuente as Grupo_Fuente, @pGrupoDestino as Grupo_Destino
go

drop procedure sueVariablesMasivoEliminarDatos
go
create procedure sueVariablesMasivoEliminarDatos
(
@pLegajoDesde int,
@pLegajoHasta int,
@pConceptoDesde int,
@pConceptoHasta int,
@pGrupoDesde int,
@pGrupoHasta int
)
as
select @pLegajoDesde as Legajo_Desde, @pLegajoHasta as Legajo_Hasta, @pConceptoDesde as Concepto_Desde, @pConceptoHasta as Concepto_Hasta,
@pGrupoDesde as Grupo_Desde, @pGrupoHasta as Grupo_Hasta
go

drop procedure sueVariableCopiar
go
create procedure sueVariableCopiar
(
@pLegajoOrigen int,
@pLegajoDesde int,
@pLegajoHasta int,
@pConceptoDesde int,
@pConceptoHasta int,
@pGrupoDesde int,
@pGrupoHasta int
)
as
select @pLegajoOrigen as Legajo_Origen, @pLegajoDesde as Legajo_Desde, @pLegajoHasta as Legajo_Hasta, @pConceptoDesde as Concepto_Desde, @pConceptoHasta as Concepto_Hasta,
@pGrupoDesde as Grupo_Desde, @pGrupoHasta as Grupo_Hasta

go

drop procedure sueVariableCopiarGuardar
go
create procedure sueVariableCopiarGuardar
(
@pLegajoOrigen int,
@pLegajoDesde int,
@pLegajoHasta int,
@pConceptoDesde int,
@pConceptoHasta int,
@pGrupoDesde int,
@pGrupoHasta int,
@pUsuario_Id bigint,
@pEmpresa_Id Int
)
as
insert into sueVariable (Legajo, Concepto_Id, Grupo_Id, Usuario_Id, FechaRegistro) (
select suePersonal.genEntidades,sueConceptos.sueConceptos, sueGrupos.sueGrupos, @pUsuario_Id, dbo.FechaActual() from sueConceptos
inner join sueGrupos on sueGrupos.Grupo_Id between @pGrupoDesde and @pGrupoHasta
inner join suePersonal on suePersonal.Legajo between @pLegajoDesde and @pLegajoHasta 
where 
suePersonal.Empresa_Id =  @pEmpresa_Id and 
not exists (select 1 from sueVariable where sueConceptos.sueConceptos=sueVariable.Concepto_Id and
suePersonal.genEntidades=sueVariable.Legajo and sueGrupos.sueGrupos=sueVariable.Grupo_Id) and
sueConceptos.Concepto_Id between @pConceptoDesde and @pConceptoHasta
and exists (select 1 from sueVariable 
inner join suePersonal veripers on veripers.genEntidades=sueVariable.Legajo
inner join sueConceptos veriConce on veriConce.sueConceptos=sueVariable.Concepto_Id
inner join sueGrupos veriGrupo on veriGrupo.sueGrupos=sueVariable.Grupo_Id
where veripers.Legajo=@pLegajoOrigen and 
veriConce.sueConceptos =sueConceptos.sueConceptos and 
veriGrupo.sueGrupos =sueGrupos.sueGrupos)
)
go

drop procedure sueVariablesMasivoGuardar
go
create procedure sueVariablesMasivoGuardar
(
@pLegajoDesde int,
@pLegajoHasta int,
@pConceptoDesde int,
@pConceptoHasta int,
@pGrupoFuente int=null,
@pGrupoDestino int,
@pUsuario_Id bigint,
@pEmpresa_Id Int
)
as
insert into sueVariable (Legajo, Grupo_Id, Concepto_Id, Usuario_Id, FechaRegistro)
select suePersonal.genEntidades, dbo.FuncFKsueGrupos(@pGrupoDestino) , sueConceptos.sueConceptos, @pUsuario_Id, dbo.FechaActual() from suePersonal
inner join sueConceptos on sueConceptos.Concepto_Id between @pConceptoDesde and @pConceptoHasta

where 
Legajo between @pLegajoDesde and @pLegajoHasta and 
suePersonal.Empresa_Id = @pEmpresa_Id and 
not exists (select 1 from sueVariable where sueVariable.Legajo=suePersonal.genEntidades and sueConceptos.sueConceptos=sueVariable.Concepto_Id and dbo.FuncFKsueGrupos(@pGrupoDestino)=sueVariable.Grupo_Id) 
go


drop procedure sueVariablesMasivoEliminar
go
create procedure sueVariablesMasivoEliminar
(
@pLegajoDesde int,
@pLegajoHasta int,
@pConceptoDesde int,
@pConceptoHasta int,
@pGrupoDesde int,
@pGrupoHasta int,
@pEmpresa_Id Int
)
as
delete Variable from sueVariable Variable 
inner join suePersonal on suePersonal.genEntidades=Variable.Legajo 
inner join sueGrupos on sueGrupos.sueGrupos=Variable.Grupo_Id
inner join sueConceptos on sueConceptos.sueConceptos=Variable.Concepto_Id
where suePersonal.Legajo between @pLegajoDesde and @pLegajoHasta and
sueGrupos.Grupo_Id between @pGrupoDesde and @pGrupoHasta and
sueConceptos.Concepto_Id between @pConceptoDesde and @pConceptoHasta and 
suePersonal.Empresa_Id = @pEmpresa_Id
go