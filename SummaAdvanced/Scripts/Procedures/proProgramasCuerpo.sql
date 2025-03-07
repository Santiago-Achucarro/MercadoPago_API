
drop procedure proProgramasCuerpoDatos
go
create procedure proProgramasCuerpoDatos
(
@pproProgramas int
)
as
select proProgramas, Renglon, stkProductos.Producto_Id, Cantidad, proProgramasCuerpo.Observaciones, FechaNecesidad, Confirmado, proRecetas.Receta_Id from proProgramasCuerpo
inner join stkProductos on stkProductos=proProgramasCuerpo.Producto_Id
inner join proRecetas on proRecetas=proProgramasCuerpo.Receta_Id
where
proProgramasCuerpo.proProgramas=@pproProgramas
go

drop procedure proProgramasCuerpoGuardar
go
create procedure proProgramasCuerpoGuardar
(
@pproProgramas int,
@pRenglon int, 
@pProducto_Id varchar(25),
@pCantidad qCantidadD8, 
@pObservaciones varchar(max), 
@pFechaNecesidad datetime, 
@pConfirmado bit, 
@pReceta_Id varchar(25)
)
as

set @pRenglon = ISNULL((SELECT MAX(Renglon) from proProgramasCuerpo where proProgramas = @pproProgramas),0)+1

insert into proProgramasCuerpo (proProgramas,Renglon,Producto_Id, Cantidad, Observaciones, FechaNecesidad, Confirmado, Receta_Id)
values(@pproProgramas, @pRenglon, dbo.FuncFKstkProductos(@pProducto_Id), @pCantidad,
@pObservaciones, @pFechaNecesidad, @pConfirmado, dbo.FuncFKproRecetas(@pReceta_Id))
go

drop procedure proProgramasCuerpoEliminar
go
create procedure proProgramasCuerpoEliminar
(
@pproProgramas int,
@pRenglon int =null
)
as
delete proProgramasCuerpo where proProgramasCuerpo.proProgramas=@pproProgramas and
proProgramasCuerpo.Renglon=isnull(@pRenglon, proProgramasCuerpo.Renglon) and
proProgramasCuerpo.Confirmado=0
go


drop procedure proProgramasCuerpoPendDatos
go
create procedure proProgramasCuerpoPendDatos
(
@pproProgramas int, 
@pFechaDesde DateTime,
@pFechaHasta DateTime 
)
as
select proProgramas, Renglon, 
	stkProductos.Producto_Id, Cantidad, proProgramasCuerpo.Observaciones, FechaNecesidad, Confirmado, 
	proRecetas.Receta_Id 
	From proProgramasCuerpo
inner join stkProductos on stkProductos=proProgramasCuerpo.Producto_Id
inner join proRecetas on proRecetas=proProgramasCuerpo.Receta_Id
where
proProgramasCuerpo.proProgramas=@pproProgramas and 
proProgramasCuerpo.Confirmado = 0 and 
proProgramasCuerpo.FechaNecesidad between @pFechaDesde And @pFechaHasta

go



drop procedure proProgramasCuerpoConfirmar
go
create procedure proProgramasCuerpoConfirmar
(
@pproProgramas int,
@pRenglon int , 
@pConfirmado bit
)
as
Update proProgramasCuerpo set Confirmado = @pConfirmado 
where 
proProgramasCuerpo.proProgramas=@pproProgramas and
proProgramasCuerpo.Renglon=@pRenglon

go


Drop Procedure proOrdenesProgramaEliminar
GO

Create Procedure proOrdenesProgramaEliminar
(
 @proProgramas int, 
 @FechaDesde DateTime, 
 @FechaHasta DateTime
)
as

select proProgramaOrden.proProgramas, proProgramaOrden.Renglon,proProgramaOrden.proOrden
	INTO #TempOrden
	from proProgramaOrden, proProgramasCuerpo, proOrden 
		Where
		proProgramaOrden.proProgramas = proProgramasCuerpo.proProgramas and 
		proProgramaOrden.Renglon = proProgramaOrden.Renglon and
		proOrden.proOrden =  proProgramaOrden.proOrden and 
		proProgramasCuerpo.FechaNecesidad between @FechaDesde And @FechaHasta and 
		proOrden.FechaProduccion IS NULL AND 
		proProgramaOrden.proProgramas = @proProgramas

DELETE FROM proProgramaOrden 
	Where exists(select 1 from #TempOrden where 
		#TempOrden.proOrden = proProgramaOrden.proOrden and 
		#TempOrden.proProgramas = proProgramaOrden.proProgramas and 
		#TempOrden.Renglon = proProgramaOrden.Renglon)

DELETE FROM proOrdenProd 
	Where exists(select 1 from #TempOrden where #TempOrden.proOrden = proOrdenProd.proOrden)
	
DELETE FROM proOrdenRecursos
	Where exists(select 1 from #TempOrden where #TempOrden.proOrden = proOrdenRecursos.proOrden)

DELETE FROM proOrdenTrabajos3
	Where exists(select 1 from #TempOrden where #TempOrden.proOrden = proOrdenTrabajos3.proOrden)

DELETE FROM proOrdenSegmento
	Where exists(select 1 from #TempOrden where #TempOrden.proOrden = proOrdenSegmento.proOrden)

DELETE FROM proOrden
	Where exists(select 1 from #TempOrden where #TempOrden.proOrden = proOrden.proOrden)


Update proProgramasCuerpo SET Confirmado = 0 
	Where exists(select 1 from #TempOrden where 
		#TempOrden.proProgramas = proProgramasCuerpo.proProgramas and
		#TempOrden.Renglon = proProgramasCuerpo.Renglon )

GO

