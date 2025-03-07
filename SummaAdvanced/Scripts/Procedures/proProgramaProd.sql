
drop procedure proProgramaProdCalc
go
create procedure proProgramaProdCalc
(
@pProductoDesde varchar(25),
@pProductoHasta varchar(25),
@pFechaDesde datetime,
@pFechaHasta datetime,
@pDeposito varchar(15),
@pFechaHastaPedidos datetime,
@pFamiliaDesde varchar(15),
@pFamiliaHasta varchar(15),
@pGrupoDesde varchar(15),
@pGrupoHasta varchar(15),
@pDescripcion varchar(80),
@pEmpresa_Id int
)
as
select stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, stkUniMed.Medida_Id, 
stkUniMed.Descripcion as DescripcionMedida, 
isnull((select sum(venPediCuerpo.CantidadPedida) from venPediCuerpo
inner join venPedidos on venPedidos.venPedidos=venPediCuerpo.venPedidos
where venPediCuerpo.Producto_Id=stkProductos.stkProductos  and
venPedidos.Estado='P'),0) as Pedidos,
isnull((select (stkExistencia.Cantidad) from stkExistencia where
stkExistencia.Producto_Id=stkProductos.stkProductos and stkExistencia.Deposito_Id=stkDepositos.stkDepositos),0) as Stock, 
cast(0 as numeric(18,4)) as MinNecesario,
stkMaxMin.Minimo, cast(0 as numeric) as OrdProducto, 
isnull((select sum(proOrden.Cantidad-proOrden.CantidadTerminada) from proOrden
where proOrden.Producto_Id=stkProductos.stkProductos and 
proOrden.Anulado=0 and proOrden.FechaProduccion between @pFechaDesde and @pFechaHasta),cast(0 as numeric)) as Faltantes, 
stkMaxMin.Maximo, 
isnull((select sum(proOrdenProd.Cantidad) from proOrdenProd inner join proOrden on proOrden.proOrden=proOrdenProd.proOrden
where proOrdenProd.Producto_Id=stkProductos.stkProductos and proOrdenProd.Deposito_Id=stkDepositos.stkDepositos and
proOrden.Anulado=0 and proOrden.FechaProduccion between DATEADD(DAY,-90,@pFechaDesde) and @pFechaDesde),cast(0 as numeric)) as Ult90Dias, 
0 as ProdPeriodo, proRecetas.Receta_Id
from stkProductos 
inner join proProductosReceta on 
proProductosReceta.Producto_Id = stkProductos.stkProductos and
proProductosReceta.Principal = 1
Inner Join proRecetas On proRecetas.proRecetas = proProductosReceta.Receta_Id
inner join stkDepositos on stkDepositos.Deposito_Id=@pDeposito
left join stkFamilias on stkProductos.Familia_Id=stkFamilias
left join stkGrupos on stkGrupos=stkProductos.Grupo_Id
inner join stkUniMed on stkUniMed=stkProductos.Medida_Id
left join stkMaxMin on stkMaxMin.Producto_Id=stkProductos and stkMaxMin.Deposito_Id=stkDepositos
left join proOrdenProd on proOrdenProd.Deposito_Id=@pDeposito and 
	exists(select 1 from proOrden where proOrden.proOrden=proOrdenProd.proOrden and
		proOrden.FechaProduccion between @pFechaDesde and @pFechaHasta)
where 
	isnull(stkGrupos.Grupo_Id, ' ') between @pGrupoDesde and @pGrupoHasta and
	isnull(stkFamilias.Familia_Id,' ') between @pFamiliaDesde and @pFamiliaHasta
group by stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_Id, stkUniMed.Descripcion, Minimo, Maximo,
stkProductos.stkProductos, stkDepositos.stkDepositos, proRecetas.Receta_Id

go

drop procedure proProgramaProduccionDatos
go
create procedure proProgramaProduccionDatos
(
@pSegmento_Id varchar(10),
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pFechaHastaPedidos DateTime,
@pEmpresa_Id Int
)
as
declare @lIdentity int = (select proProgramasSegmento.proProgramas from proProgramasSegmento where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N and Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and Segmento3C=@pSegmento3C and Segmento4C=@pSegmento4C and
proProgramasSegmento.Empresa_Id = @pEmpresa_Id
)
PRINT @lIdentity
exec proProgramaProduccionDatosInt @lIdentity, @pFechaHastaPedidos
go

drop procedure proProgramaProduccionDatosInt
go
create procedure proProgramaProduccionDatosInt
(
@pproProgramaProduccion int,
@pFechaHastaPedidos datetime
)
as
select gensegmentos.Segmento_Id, proProgramasSegmento.Segmento1N, proProgramasSegmento.Segmento2N,
proProgramasSegmento.Segmento3N, proProgramasSegmento.Segmento4N, proProgramasSegmento.Segmento1C,
proProgramasSegmento.Segmento2C, proProgramasSegmento.Segmento3C, proProgramasSegmento.Segmento4C,
proProgramas.proProgramas, proProgramas.Descripcion, proProgramas.Empresa_Id, Fecha, FechaDesde, FechaHasta, stkDepositos.Deposito_Id, ProductoDesde, 
ProductoHasta, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, GrupoDesde, GrupoHasta, FamiliaDesde, 
FamiliaHasta, proProgramas.Usuario_Id, @pFechaHastaPedidos as FechaHastaPedidos
from proProgramas
inner join stkDepositos on stkDepositos=proProgramas.Deposito_Id
inner join proProgramasSegmento on proProgramasSegmento.proProgramas= proProgramas.proProgramas
inner join genSegmentos on gensegmentos.genSegmentos=proProgramasSegmento.Segmento_Id
where proProgramas.proProgramas=@pproProgramaProduccion

select 0 as Columna, getdate() as Fecha

go

drop procedure proProgramaProduccionGuardar
go
create procedure proProgramaProduccionGuardar
(
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pproPrograma int,
@pDescripcion varchar(80),
@pEmpresa_Id int,
@pFecha datetime,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pDeposito_Id varchar(15),
@pProductoDesde varchar(25),
@pProductoHasta varchar(25),
@pLunes bit,
@pMartes bit,
@pMiercoles bit,
@pJueves bit,
@pViernes bit,
@pSabado bit,
@pDomingo bit,
@pGrupoDesde varchar(15),
@pGrupoHasta varchar(15),
@pFamiliaDesde varchar(15),
@pFamiliaHasta varchar(15),
@pUsuario_Id int
)
as
DECLARE @lIdentidad int = (Select proProgramas
 from proProgramasSegmento
 Where
	proProgramasSegmento.Empresa_id = @pEmpresa_Id and 
	proProgramasSegmento.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	proProgramasSegmento.Segmento1N = @pSegmento1N and 
	proProgramasSegmento.Segmento2N = @pSegmento2N and 
	proProgramasSegmento.Segmento3N = @pSegmento3N and 
	proProgramasSegmento.Segmento4N = @pSegmento4N and 
	proProgramasSegmento.Segmento1C = @pSegmento1C and 
	proProgramasSegmento.Segmento2C = @pSegmento2C and 
	proProgramasSegmento.Segmento3C = @pSegmento3C and 
	proProgramasSegmento.Segmento4C = @pSegmento4C )

IF (EXISTS (SELECT 1 FROM proProgramas WHERE proProgramas.proProgramas=@lIdentidad))

begin
update proProgramas set
Descripcion=Descripcion, Empresa_Id=@pEmpresa_Id, Fecha=dbo.FechaActual(), FechaDesde=@pFechaDesde, FechaHasta=@pFechaHasta,
Deposito_Id=dbo.FuncFKstkDepositos(@pDeposito_Id), ProductoDesde=@pProductoDesde, ProductoHasta=@pProductoHasta, Lunes=@pLunes, Martes=@pMartes,
Miercoles=@pMiercoles, Jueves=@pJueves, Viernes=@pViernes, Sabado=@pSabado, Domingo=@pDomingo, GrupoDesde=@pGrupoDesde,
GrupoHasta=@pGrupoHasta, FamiliaDesde=@pFamiliaDesde, FamiliaHasta=@pFamiliaHasta, Usuario_Id=@pUsuario_Id
where @lIdentidad=proProgramas
end
else
begin
insert proProgramas
(
Descripcion, Empresa_Id, Fecha, FechaDesde, FechaHasta, Deposito_Id, ProductoDesde, ProductoHasta, 
Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo,
GrupoDesde, GrupoHasta, FamiliaDesde, FamiliaHasta, Usuario_Id
)
values
(
@pDescripcion,
@pEmpresa_Id,
@pFecha,
@pFechaDesde, @pFechaHasta,
dbo.FuncFKstkDepositos(@pDeposito_Id),
@pProductoDesde, @pProductoHasta,
@pLunes, @pMartes, @pMiercoles, @pJueves, @pViernes, @pSabado, @pDomingo,
@pGrupoDesde, @pGrupoHasta,
@pFamiliaDesde, @pFamiliaHasta,
@pUsuario_Id
)

SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 
go

