-- exec inf_stkMaterialEnPers 0,99999,' ','zzz',1
DROP PROCEDURE inf_stkMaterialEnPers
GO

CREATE PROCEDURE inf_stkMaterialEnPers
(
	@LegajoDesde Int, 
	@LegajoHasta Int, 
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa_Id int
)
AS

SELECT suePersonal.Legajo, suePersonal.Nombres +', '+suePersonal.ApellidoPaterno +
	CASE WHEN suePersonal.ApellidoPaterno = ' ' THEN '' ELSE ', ' end +suePersonal.ApellidoMaterno as Nombre,
stkProductos.Producto_Id, stkProductos.Descripcion, 
SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) as Cantidad , stkUniMed.Medida_Id
FROM  stkMoviCabe 
	INNER JOIN stkMoviCuerpo ON stkMoviCuerpo.stkMoviCabe =stkMoviCabe.stkMoviCabe
	INNER JOIN stkMoviLega ON  stkMoviLega.stkMoviCabe =stkMoviCabe.stkMoviCabe
	INNER JOIN conAsientos ON  conAsientos.conAsientos =stkMoviCabe.stkMoviCabe
	INNER JOIN suePersonal ON suePersonal.genEntidades = stkMoviLega.Legajo 
	INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
	INNER JOIN stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
WHERE
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	suePersonal.Legajo bETWEEN @LegajoDesde AND @LegajoHasta AND 
	stkProductos.Producto_Id Between @ProductoDesde AND @ProductoHasta
GROUP BY suePersonal.Legajo, suePersonal.Nombres ,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno ,
stkProductos.Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_Id
HAVING SUM(stkMoviCuerpo.Cantidad* stkMoviCabe.Signo) > 0
order by 1,3
GO
	