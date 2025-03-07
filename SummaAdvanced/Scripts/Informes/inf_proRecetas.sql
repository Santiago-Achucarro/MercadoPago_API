-- inf_proRecetas ' ','ZZZ', 1,1,1,1
DROP PROCEDURE inf_proRecetas
GO
CREATE PROCEDURE inf_proRecetas
(
 @RecetaDesde VarChar(25),
 @RecetaHasta VarChar(25),
 @IncProductos bit,
 @IncTrabajos3 bit,
 @IncRecursos bit,
 @Empresa_Id int
)

as

SELECT proRecetas.Receta_Id, proRecetas.Descripcion, 
	1 as TIPO, 	 'Consumos' as DescripcionAgrupador, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProd, 
	proRecetasProd.Cantidad, stkUniMed.Medida_Id

from proRecetas inner join proRecetasProd ON 
proRecetas.proRecetas = proRecetasProd.Receta_Id
inner join stkProductos ON 
stkProductos.stkProductos = proRecetasProd.Producto_Id
INNER JOIN  stkUniMed ON
stkUniMed.stkUniMed = proRecetasProd.Medida_Id
Where
proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
ISNULL(proRecetas.Empresa_Id,@Empresa_Id) = @Empresa_Id and 
proRecetasProd.EntradaSalida= 'C'
UNION ALL
SELECT proRecetas.Receta_Id, proRecetas.Descripcion, 
	4 as TIPO, 	 'Prodcciones' as DescripcionAgrupador, 
	stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProd, 
	proRecetasProd.Cantidad, stkUniMed.Medida_Id

from proRecetas inner join proRecetasProd ON 
proRecetas.proRecetas = proRecetasProd.Receta_Id
inner join stkProductos ON 
stkProductos.stkProductos = proRecetasProd.Producto_Id
INNER JOIN  stkUniMed ON
stkUniMed.stkUniMed = proRecetasProd.Medida_Id
Where
proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
ISNULL(proRecetas.Empresa_Id,@Empresa_Id) = @Empresa_Id AND 
proRecetasProd.EntradaSalida= 'P'
union all
SELECT proRecetas.Receta_Id, proRecetas.Descripcion, 
	2 as TIPO, 	 'Trabajos_3' as DescripcionAgrupador, 
	proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion as DescripcionProd, 
	ISNULL(proTrabajo3Prov.Cantidad,0) AS Cantidad , ISNULL(stkUniMed.Medida_Id, '  ') as Medida_Id

from proRecetas inner join proRecetasTrabajo3 ON 
proRecetas.proRecetas = proRecetasTrabajo3.Receta_Id
inner join proTrabajo3 ON 
proTrabajo3.proTrabajo3 = proRecetasTrabajo3.Trabajo3_Id
left join proTrabajo3Prov ON
proTrabajo3Prov.Trabajo3_Id = proTrabajo3.proTrabajo3 AND 
proTrabajo3Prov.Predeterminado = 1
left join stkUniMed ON 
stkUniMed.stkUniMed = proTrabajo3Prov.Medida_Id
Where
proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
ISNULL(proRecetas.Empresa_Id,@Empresa_Id) = @Empresa_Id 
UNION ALL
SELECT proRecetas.Receta_Id, proRecetas.Descripcion, 
	3 as TIPO, 	 'Recursos' as DescripcionAgrupador, 
	proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionProd, 
	proRecetasRecursos.Cantidad Cantidad, '  '
From proRecetas inner join proRecetasRecursos ON 
proRecetas.proRecetas = proRecetasRecursos.proRecetas
inner join proRecursos ON 
proRecursos.proRecursos = proRecetasRecursos.Recurso_Id
Where
proRecetas.Receta_Id between @RecetaDesde and @RecetaHasta and
ISNULL(proRecetas.Empresa_Id,@Empresa_Id) = @Empresa_Id 
Order By 1, 3
	

