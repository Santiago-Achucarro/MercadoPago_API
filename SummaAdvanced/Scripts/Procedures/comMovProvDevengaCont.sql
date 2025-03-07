DROP PROCEDURE comMovProvDevengaContGuardar
GO
CREATE PROCEDURE comMovProvDevengaContGuardar
(
@pcomMovProv bigint,
@pconAsientos bigint
)
AS
SET NOCOUNT ON 

INSERT INTO comMovProvDevengaCont
(
	comMovProv,
	conAsientos
)
VALUES 
(
	@pcomMovProv,
	@pconAsientos
)

GO

DROP PROCEDURE comMovProvDevengaContDatos
GO
CREATE PROCEDURE comMovProvDevengaContDatos
(
@pcomMovProv bigint,
@pconAsientos bigint = Null
)
AS
SET NOCOUNT ON 

SELECT comMovProvDevengaCont.comMovProv, comMovProvDevengaCont.conAsientos, genAsiSegmentos.Segmento_Id,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Asiento, conAsientos.Fecha, SUM(conMovCont.Importe) Importe
FROM comMovProvDevengaCont
Inner Join conAsientos On conAsientos.conAsientos = comMovProvDevengaCont.conAsientos
Inner Join conMovCont On conMovCont.conAsientos = comMovProvDevengaCont.conAsientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovProvDevengaCont.conAsientos
WHERE comMovProv = @pcomMovProv
AND comMovProvDevengaCont.conAsientos = isNull(@pconAsientos, comMovProvDevengaCont.conAsientos)
and conMovCont.TipoMov = 1
Group By comMovProvDevengaCont.comMovProv, comMovProvDevengaCont.conAsientos, genAsiSegmentos.Segmento_Id,
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N), conAsientos.Fecha
 
RETURN @@Error 

GO

DROP PROCEDURE comMovProvDevengaContEliminar
GO
CREATE PROCEDURE comMovProvDevengaContEliminar
(
@pcomMovProv bigint,
@pconAsientos bigint = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProvDevengaCont 
WHERE comMovProv = @pcomMovProv
AND conAsientos = isNull(@pconAsientos, conAsientos)
 
 RETURN @@Error 

GO
