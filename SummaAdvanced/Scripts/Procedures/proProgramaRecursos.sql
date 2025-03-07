--proProgramaSubRecursosDatos 1, 'MA', '20190801','20190801','P',1
drop procedure proProgramaSubRecursosDatos
go
create procedure proProgramaSubRecursosDatos
(
@pEmpresa_Id int,
@pRecurso_Id varchar(25)=null,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pPendHist char, 
@pSoloEnProd bit

)
as
select @pRecurso_Id as Recurso_Id, proRecursos.Descripcion as DescripcionRecurso,
@pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta, @pPendHist as PendHist, 
@pSoloEnProd as  SoloEnProd, 
' ' as SubRecurso_Id, ' ' as DescripcionSubRecurso
from proRecursos 
Where
	proRecursos.Recurso_Id = @pRecurso_Id
	

	
Select proOrden.proOrden, proOrdenRecursos.Renglon, dbo.Segmento(proOrdenSegmento.Segmento_Id, proOrdenSegmento.Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N) as SegmentoSTR,
proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecursos, 
proOrdenRecursos.Cantidad as CantidadRecurso, 
proOrden.CantidadIngresada, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida, 
proOrden.FechaEmision, proOrden.FechaNecesidad, proOrden.FechaProduccion,
proOrden.FechaFin, SUM(proOrdenSubRecurso.Cantidad) as CantidadSubRecurso, 
0 as RenglonInt
From proOrdenRecursos
inner join proOrden on proOrden.proOrden=proOrdenRecursos.proOrden
left join stkUniMed on stkUniMed=proOrden.Medida_Id
inner join proOrdenSegmento on proOrdenSegmento.proOrden=proOrden.proOrden
inner join proRecursos on proRecursos.proRecursos=proOrdenRecursos.Recurso_Id
left join proOrdenSubRecurso on proOrden.proOrden=proOrdenSubRecurso.proOrden and 
								proOrdenSubRecurso.Renglon=proOrdenRecursos.Renglon
left join proSubRecursos on proSubRecursos.proSubRecursos=proOrdenSubRecurso.SubRecurso_Id
where
proRecursos.UsaSubRecurso = 1 and 
proOrdenSegmento.Empresa_Id=@pEmpresa_Id and
proRecursos.Recurso_Id=@pRecurso_Id  and
((@pPendHist='H' and proOrden.FechaProduccion between @pFechaDesde and @pFechaHasta) or
(@pPendHist='P' and proOrdenSubRecurso.SubRecurso_Id is null)) and 
(@pSoloEnProd=0 or proOrden.FechaProduccion IS NOT NULL)
group by proOrden.proOrden, proOrdenRecursos.Renglon, proOrdenSegmento.Segmento_Id, proOrdenSegmento.Segmento1C,Segmento2C,Segmento3C,Segmento4C,Segmento1N,Segmento2N,Segmento3N,Segmento4N,
proRecursos.Recurso_Id, proRecursos.Descripcion , 
proOrdenRecursos.Cantidad , 
proOrden.CantidadIngresada, stkUniMed.Medida_Id, stkUniMed.Descripcion , 
proOrden.FechaEmision, proOrden.FechaNecesidad, proOrden.FechaProduccion,
proOrden.FechaFin
ORDER BY 3,2

SELECT proOrdenSubRecurso.proOrden, proOrdenSubRecurso.Renglon, 
	proSubRecursos.SubRecurso_Id, proSubRecursos.Descripcion,
	proOrdenSubRecurso.Cantidad, 0 as RenglonInt
from proOrdenSubRecurso inner join proSubRecursos ON
	proOrdenSubRecurso.SubRecurso_Id =  proSubRecursos.proSubRecursos
	inner join proOrden on 
	proOrden.proOrden = proOrdenSubRecurso.proOrden
	INNER JOIN proOrdenRecursos ON
	proOrdenRecursos.proOrden =proOrdenSubRecurso.proOrden AND 
	proOrdenRecursos.Renglon =  proOrdenSubRecurso.Renglon
	INNER JOIN proOrdenSegmento ON
	proOrdenSegmento.proOrden = proOrden.proOrden
	INNER JOIN proRecursos ON
	proRecursos.proRecursos = proOrdenRecursos.Recurso_Id
Where 
proOrdenSegmento.Empresa_Id=@pEmpresa_Id and
proRecursos.Recurso_Id=@pRecurso_Id  and
((@pPendHist='H' and proOrden.FechaProduccion between @pFechaDesde and @pFechaHasta) or
(@pPendHist='P' and proOrdenSubRecurso.SubRecurso_Id is null)) and 
(@pSoloEnProd=0 or proOrden.FechaProduccion IS NOT NULL)

go


drop procedure proProgramaSubRecursosGuardar
go
create procedure proProgramaSubRecursosGuardar
(
@pOrden int,
@pSubRecurso_Id varchar(25),
@pRenglon int,
@pCantidad qCantidadD8
)
as
insert into proOrdenSubRecurso (proOrden,Renglon, SubRecurso_Id, Cantidad) values (@pOrden, @pRenglon, dbo.FuncFKproSubRecursos(@pSubRecurso_Id),@pCantidad)
go


drop procedure proProgramaSubRecursosEliminar
go
create procedure proProgramaSubRecursosEliminar
(
@proOrden int,
@pRecurso_id varchar(25),
@pRenglon int
)
as
delete proOrdenSubRecurso 
Where	
	proOrden = @proOrden and
	Renglon = @pRenglon and 
	Exists(SELECT 1 FROM proOrdenRecursos, proRecursos where
		proOrdenRecursos.proOrden = proOrdenSubRecurso.proOrden and 
		proOrdenRecursos.Renglon = proOrdenSubRecurso.Renglon and 
		proOrdenRecursos.Recurso_Id =  proRecursos.proRecursos  and
		proRecursos.Recurso_Id = @pRecurso_id)
go