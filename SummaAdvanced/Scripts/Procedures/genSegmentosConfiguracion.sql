DROP PROCEDURE genSegmentosConfiguracion 
GO


CREATE PROCEDURE genSegmentosConfiguracion (
@pSegmento_id VarChar(10), 
@pEmpresa_Id Int)

AS

SELECT Orden1N as Orden, 1 as Campo, 'N' AS Tipo,  Digitos1N as Digitos, 
TieneColumnaAutomatica , genSegmentos.Origen1N AS Origen,
genSegmentosNombres.Nombre1N as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen1N
WHERE 
	genSegmentos.Digitos1N > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id 
UNION ALL	
SELECT Orden2N as Orden, 2 as Campo, 'N' AS Tipo, Digitos2N as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen2N AS Origen,
genSegmentosNombres.Nombre2N as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen2N
WHERE 
	genSegmentos.Digitos2N > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
UNION ALL	
SELECT Orden3N as Orden, 3 as Campo, 'N' AS Tipo, Digitos3N as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen3N AS Origen,
genSegmentosNombres.Nombre3N as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen3N
WHERE 
	genSegmentos.Digitos3N > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
UNION ALL	
SELECT Orden4N as Orden, 4 as Campo, 'N' AS Tipo, Digitos4N as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen4N AS Origen,
genSegmentosNombres.Nombre4N as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen4N
WHERE 
	genSegmentos.Digitos4N > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
UNION ALL
SELECT Orden1C as Orden, 1 as Campo, 'C' AS Tipo,  Digitos1C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen1C AS Origen,
genSegmentosNombres.Nombre1C as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen1C
WHERE 
	genSegmentos.Digitos1C > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
UNION ALL	
SELECT Orden2C as Orden, 2 as Campo, 'C' AS Tipo, Digitos2C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen2C AS Origen,
genSegmentosNombres.Nombre2C as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen2C
WHERE 
	genSegmentos.Digitos2C > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
UNION ALL	
SELECT Orden3C as Orden, 3 as Campo, 'C' AS Tipo, Digitos3C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen3C AS Origen,
genSegmentosNombres.Nombre3C as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen3C
WHERE 
	genSegmentos.Digitos3C > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
UNION ALL	
SELECT Orden4C as Orden, 4 as Campo, 'C' AS Tipo, Digitos4C as Digitos, 
Cast(0 as bit) TieneColumnaAutomatica , genSegmentos.Origen4C AS Origen,
genSegmentosNombres.Nombre4C as Nombre
FROM genSegmentos
	LEFT OUTER JOIN genSegmentosNombres ON
	genSegmentosNombres.Segmento_id = genSegmentos.genSegmentos
	left outer join genSegmentoOrigenes ON
	genSegmentoOrigenes.OriSeg_id = genSegmentos.Origen4C
WHERE 
	genSegmentos.Digitos4C > 0 and 
	genSegmentos.Segmento_id = @pSegmento_id
ORDER BY 1,2	
	
	
GO
	