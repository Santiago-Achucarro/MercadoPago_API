-- INF_StkProdSinMovimientos  '20170701','20170822', ' ','ZZZ', 1
DROP PROCEDURE INF_StkProdSinMovimientos 
GO
CREATE PROCEDURE INF_StkProdSinMovimientos (
@FechaDesde DateTime,
@FechaHasta DateTime,
@ProductoDesde VarChar(25),
@ProductoHasta VarChar(25),
@Empresa Int,
@FamiliaDesde varchar(15),
@FamiliaHasta varchar(15),
@GrupoDesde varchar(15),
@GrupoHasta varchar(15)
)

AS

SELECT DISTINCT stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto
	from stkProductos inner join stkExistencia ON
	stkExistencia.Producto_Id = stkProductos.stkProductos AND
	stkExistencia.Empresa_Id = @Empresa
	left join stkFamilias on stkProductos.Familia_Id= stkFamilias.stkFamilias
	left join stkGrupos on stkProductos.Grupo_Id=stkGrupos.stkGrupos
WHERE
stkProductos.Producto_Id between @ProductoDesde AND @ProductoHasta AND 
ISNULL(stkProductos.Empresa_id,@Empresa) = @Empresa and
isnull(stkFamilias.Familia_Id,'') between @FamiliaDesde and @FamiliaHasta and
isnull(stkGrupos.Grupo_Id,'') between @GrupoDesde and @GrupoHasta and

stkProductos.Clase IN ('E','-') AND
Not Exists(SELECT 1 FROM stkMoviCabe INNER JOIN stkMoviCuerpo ON 
	stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe And
	stkMoviCuerpo.Producto_id = stkProductos.stkProductos
	INNER JOIN conAsientos ON
	conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
	Where
		conAsientos.Anulado = 0 and 
		conAsientos.Fecha between @FechaDesde and @FechaHasta and 
		conAsientos.Empresa_Id = @Empresa)
ORDER BY 1
GO