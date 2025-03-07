DROP PROCEDURE [dbo].[inf_proRecetasPrincipal]
GO


create procedure [dbo].[inf_proRecetasPrincipal]
(
@RecetaDesde varchar(25),
@RecetaHasta varchar(25),
@Empresa_Id int
)
as

select proRecetas.Receta_Id, proRecetas.Descripcion, proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DescripcionCtroProd,
'Productos' Tipo, stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_Id,
stkUniMed.Descripcion as DescripcionUniMed,Cantidad
from proRecetasProd
inner join proRecetas on proRecetas=proRecetasProd.Receta_Id
left join stkProductos on stkProductos=proRecetasProd.Producto_Id
left join stkUniMed on stkUniMed=proRecetasProd.Medida_Id
left join proCentroProductivo on proCentroProductivo.proCentroProductivo=proRecetas.CtroProd_Id
where
	proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
	@Empresa_Id = isnull(proRecetas.Empresa_Id,@Empresa_Id)
union all
select proRecetas.Receta_Id,proRecetas.Descripcion, proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DesccripcionCtroProd,
'Recursos', proRecursos.Recurso_Id, proRecursos.Descripcion,'','',0
from proRecetasRecursos
inner join proRecetas on proRecetas.proRecetas=proRecetasRecursos.proRecetas
left join proRecursos on proRecursos.proRecursos=proRecetasRecursos.Recurso_Id
left join proCentroProductivo on proCentroProductivo.proCentroProductivo=proRecetas.CtroProd_Id
where
	proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
	@Empresa_Id = isnull(proRecetas.Empresa_Id,@Empresa_Id)
union all
select proRecetas.Receta_Id, proRecetas.Descripcion, proCentroProductivo.CtroProd_Id, proCentroProductivo.Descripcion as DesccripcionCtroProd,
'Trabajos Terceros', proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion, stkUniMed.Medida_Id,stkUniMed.Descripcion,
	proTrabajo3Prov.Cantidad
from proRecetasTrabajo3
inner join proRecetas on proRecetas=proRecetasTrabajo3.Receta_Id
left join proTrabajo3 on proTrabajo3=proRecetasTrabajo3.Trabajo3_Id
left join proCentroProductivo on proCentroProductivo.proCentroProductivo=proRecetas.CtroProd_Id
left join proTrabajo3Prov ON
proTrabajo3Prov.Trabajo3_Id = proTrabajo3.proTrabajo3 AND 
proTrabajo3Prov.Predeterminado = 1
left join stkUniMed ON 
stkUniMed.stkUniMed = proTrabajo3Prov.Medida_Id
where 
proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
@Empresa_Id = isnull(proRecetas.Empresa_Id,@Empresa_Id)
GO


