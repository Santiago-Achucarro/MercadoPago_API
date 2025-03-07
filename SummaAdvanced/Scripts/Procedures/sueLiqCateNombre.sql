drop procedure sueLiqCategoDatos
go
create procedure sueLiqCategoDatos
(
@pCategoria_Id varchar(5),
@pEmpresa_Id int,
@pFecha datetime
)
as
select Categoria_Id, Descripcion as DescripcionCate, @pFecha as Fecha from sueCategorias
where Categoria_Id=@pCategoria_Id
select sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre, 
Fecha_Desde, isnull(Valor,0) as Valor, sueLiqImpCatego.Usuario_Id, 0 as Empresa_Id from sueCateNombre
left join sueLiqImpCatego on sueCateNombre.CateNombre_Id=sueLiqImpCatego.CateNombre_Id and dbo.FuncFKsueCategorias(@pCategoria_Id)=sueLiqImpCatego.Categoria_Id and @pFecha between Fecha_Desde and Fecha_Hasta
left join sueCategorias on sueCategorias.sueCategorias=sueLiqImpCatego.Categoria_Id
where sueCateNombre.PorEmpresa=0
union all
select sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre, 
Fecha_Desde, isnull(Valor,0), sueLiqEmpCatego.Usuario_Id, sueLiqEmpCatego.Empresa_Id from sueCateNombre
left join sueLiqEmpCatego on sueCateNombre.CateNombre_Id=sueLiqEmpCatego.CateNombre_Id and sueLiqEmpCatego.Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Empresa_Id=@pEmpresa_Id and 
@pFecha between Fecha_Desde and Fecha_Hasta
left join sueCategorias on sueCategorias.sueCategorias=sueLiqEmpCatego.Categoria_Id
where sueCateNombre.PorEmpresa=1
go

drop procedure sueLiqImpCategoGuardar
go
create procedure sueLiqImpCategoGuardar
(
@pCateNombre int,
@pCategoria_Id varchar(5),
@pFecha_Desde datetime,
@pValor qMonedaD4,
@pUsuario_Id int,
@pEmpresa_Id int
)
as
--Si no habia valor para esta variable asigno la fecha de incio de summa
set @pFecha_Desde= case when exists(select 1 from sueLiqImpCatego where CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Fecha_Hasta='29990101') then (@pFecha_Desde) else (select FechaInicioSumma from genEmpresas where genEmpresas=@pEmpresa_Id) end
-- si no cambio nada del valor actual no hago nada
if not exists(select 1 from sueLiqImpCatego where Fecha_Hasta='29990101' and CateNombre_Id=@pCateNombre and Valor=@pValor and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id))
begin
-- si solo camio el valor hago un update
if exists(select 1 from sueLiqImpCatego where Fecha_Hasta='29990101' and Fecha_Desde=@pFecha_Desde and CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id))
begin
update sueLiqImpCatego set Valor=@pValor where Fecha_Hasta='29990101' and Fecha_Desde=@pFecha_Desde and CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id)
end
else
begin
update sueLiqImpCatego set Fecha_Hasta=DATEADD(dd,-1,@pFecha_Desde) where CateNombre_Id=@pCateNombre and Fecha_Hasta='29990101'
insert into sueLiqImpCatego (CateNombre_Id, Categoria_Id, Valor, Usuario_Id, Fecha_Desde, Fecha_Hasta) values (@pCateNombre, dbo.FuncFKsueCategorias(@pCategoria_Id), @pValor, @pUsuario_Id, @pFecha_Desde, '29990101')
end
end
go

drop procedure sueLiqImpCategoGuardar
go
create procedure sueLiqImpCategoGuardar
(
@pCateNombre int,
@pCategoria_Id varchar(5),
@pFecha_Desde datetime,
@pValor qMonedaD4,
@pUsuario_Id int,
@pEmpresa_Id int
)
as
--Si no habia valor para esta variable asigno la fecha de incio de summa
set @pFecha_Desde= case when exists(select 1 from sueLiqImpCatego where CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Fecha_Hasta='29990101') then (@pFecha_Desde) else (select FechaInicioSumma from genEmpresas where genEmpresas=@pEmpresa_Id) end
-- si no cambio nada del valor actual no hago nada
if not exists(select 1 from sueLiqImpCatego where Fecha_Hasta='29990101' and CateNombre_Id=@pCateNombre and Valor=@pValor and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id))
begin
-- si solo camio el valor hago un update
if exists(select 1 from sueLiqImpCatego where Fecha_Hasta='29990101' and Fecha_Desde = @pFecha_Desde and CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id))
begin
update sueLiqImpCatego set Valor=@pValor where Fecha_Hasta='29990101' and Fecha_Desde=@pFecha_Desde and CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id)
end
else
begin
update sueLiqImpCatego set Fecha_Hasta=DATEADD(dd,-1,@pFecha_Desde) where CateNombre_Id=@pCateNombre and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Fecha_Hasta='29990101'
insert into sueLiqImpCatego (CateNombre_Id, Categoria_Id, Valor, Usuario_Id, Fecha_Desde, Fecha_Hasta) values (@pCateNombre, dbo.FuncFKsueCategorias(@pCategoria_Id), @pValor, @pUsuario_Id, @pFecha_Desde, '29990101')
end
end
go

drop procedure sueLiqEmpCategoGuardar
go
create procedure sueLiqEmpCategoGuardar
(
@pCateNombre_Id int,
@pCategoria_Id varchar(5),
@pFecha_Desde datetime,
@pValor qMonedaD4,
@pUsuario_Id int,
@pEmpresa_Id int
)
as
--Si no habia valor para esta variable asigno la fecha de incio de summa
set @pFecha_Desde= case when exists(select 1 from sueLiqEmpCatego where CateNombre_Id=@pCateNombre_Id and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Fecha_Hasta='29990101' and Empresa_Id=@pEmpresa_Id) then (@pFecha_Desde) else (select FechaInicioSumma from genEmpresas where genEmpresas=@pEmpresa_Id) end
-- si no cambio nada del valor actual no hago nada
if not exists(select 1 from sueLiqEmpCatego where Fecha_Hasta='29990101' and CateNombre_Id=@pCateNombre_Id and Valor=@pValor and Empresa_Id= @pEmpresa_Id and dbo.FuncFKsueCategorias(@pCategoria_Id)=Categoria_Id)
begin
-- si solo camio el valor hago un update
if exists(select 1 from sueLiqEmpCatego where Fecha_Hasta='29990101' and Fecha_Desde = @pFecha_Desde and CateNombre_Id=@pCateNombre_Id and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Empresa_Id=@pEmpresa_Id)
begin
update sueLiqEmpCatego set Valor=@pValor where Fecha_Hasta='29990101' and CateNombre_Id=@pCateNombre_Id and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and Empresa_Id=@pEmpresa_Id
end
else
begin
update sueLiqEmpCatego set Fecha_Hasta=DATEADD(dd,-1,@pFecha_Desde) where CateNombre_Id=@pCateNombre_Id and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and  Fecha_Hasta='29990101' and Empresa_Id=@pEmpresa_Id
insert into sueLiqEmpCatego (CateNombre_Id, Categoria_Id, Valor, Usuario_Id, Fecha_Desde, Fecha_Hasta, Empresa_Id) values (@pCateNombre_Id, dbo.FuncFKsueCategorias(@pCategoria_Id), @pValor, @pUsuario_Id, @pFecha_Desde, '29990101', @pEmpresa_Id)
end
end
go 

drop procedure sueLiqImpCategoEliminar
go
create procedure sueLiqImpCategoEliminar
(
@pCategoria_Id varchar(5),
@pCateNombre int
)
as
delete sueLiqImpCatego where dbo.FuncFKsueCategorias(@pCategoria_Id)=CateNombre_Id and sueLiqImpCatego.CateNombre_Id=@pCateNombre
go

drop procedure sueLiqEmpCategoEliminar
go
create procedure sueLiqEmpCategoEliminar
(
@pCateNombre_Id int,
@pCategoria_Id varchar(5),
@pEmpresa_Id int
)
as
delete sueLiqEmpCatego where @pCateNombre_Id=CateNombre_Id and Empresa_Id=@pEmpresa_Id and Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id)
go

drop procedure sueLiqCateNombreHistorico
go
create procedure sueLiqCateNombreHistorico
(
@pCategoria_Id varchar(5),
@pCateNombre int,
@pEmpresa_Id int
)
as
select Categoria_Id, sueCategorias.Descripcion as DescripcionCate, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre from sueCategorias
inner join sueCateNombre on sueCateNombre.CateNombre_Id=@pCateNombre
where Categoria_Id=@pCategoria_Id
select sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre, 
Fecha_Desde, Valor, sueLiqImpCatego.Usuario_Id, 0 as Empresa_Id from sueLiqImpCatego
inner join sueCategorias on sueCategorias.sueCategorias=sueLiqImpCatego.Categoria_Id
inner join sueCateNombre on sueCateNombre.CateNombre_Id=sueLiqImpCatego.CateNombre_Id
where sueCategorias.Categoria_Id=@pCategoria_Id and
sueCateNombre.CateNombre_Id=@pCateNombre

union all
select sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre, 
Fecha_Desde, Valor, sueLiqEmpCatego.Usuario_Id, sueLiqEmpCatego.Empresa_Id from sueLiqEmpCatego
inner join sueCategorias on sueCategorias.sueCategorias=sueLiqEmpCatego.Categoria_Id
inner join sueCateNombre on sueCateNombre.CateNombre_Id=sueLiqEmpCatego.CateNombre_Id
where sueCategorias.Categoria_Id=@pCategoria_Id and
sueLiqEmpCatego.Empresa_Id=@pEmpresa_Id and
sueCateNombre.CateNombre_Id=@pCateNombre
go

