DROP procedure Inf_afiBajas
GO
Create procedure Inf_afiBajas
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@RubroDesde VarChar(5),
	@RubroHasta VarChar(5),
	@Empresa_Id int
)
AS

SELECT AfiRubros.Rubro_Id, AfiRubros.Descripcion as DescripcionRubro,
conAsientos.Fecha, afiActivoFijo.ActivoFijo_Id, afiActivoFijo.Descripcion,
AfiBajas.Monto, AfiBajas.Cantidad, AfiBajas.Monto , AfiBajas.MontoDepreciacion
from AfiBajas 
	INNER JOIN conAsientos ON AfiBajas.conAsientos = conAsientos.conAsientos
	INNER JOIN (SELECT DISTINCT afiMovimientos.afiActivoFijo, 
			afiMovimientos.conAsientos
	FROM afiMovimientos) afiMovimientos 
	ON afiMovimientos.conAsientos = conAsientos.conAsientos 
	INNER JOIN afiActivoFijo ON afiActivoFijo.afiActivoFijo =afiMovimientos.afiActivoFijo
	INNER JOIN AfiRubros ON  AfiRubros.AfiRubros = afiActivoFijo.Rubro_Id
where
	conAsientos.Anulado = 0 and
	conAsientos.Posteado= 1 and
	conAsientos.Fecha between @FechaDesde and @FechaHasta and 
	AfiRubros.Rubro_Id Between @RubroDesde and @RubroHasta and 
	conAsientos.Empresa_Id = @Empresa_Id
ORDER BY 1,3
GO


