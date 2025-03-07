DROP PROCEDURE comEmbAsiCierreInsertar
GO
CREATE PROCEDURE comEmbAsiCierreInsertar
(
@pcomEmbarques bigint,
@pstkMoviCabe bigint,
@pCambio numeric(18,4)
)
AS
	INSERT INTO comEmbAsiCierre
	(
		comEmbarques,
		stkMoviCabe,
		Cambio
	)
	VALUES 
	(
		@pcomEmbarques,
		@pstkMoviCabe,
		@pCambio
	)

GO

DROP PROCEDURE comEmbAsiCierreDatos
GO
CREATE PROCEDURE comEmbAsiCierreDatos
(
@pcomEmbarques bigint=NULL,
@pstkMoviCabe bigint=NULL
)
AS
SET NOCOUNT ON 

SELECT comEmbAsiCierre.comEmbarques, comEmbAsiCierre.stkMoviCabe, comEmbAsiCierre.Cambio, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Empresa_Id, conAsientos.Fecha
FROM comEmbAsiCierre
INNER JOIN genAsiSegmentos ON comEmbAsiCierre.comEmbarques = genAsiSegmentos.Asiento_Id
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join conAsientos On conAsientos.conAsientos = comEmbAsiCierre.stkMoviCabe
WHERE (comEmbarques = ISNULL(@pcomEmbarques,comEmbarques))
	AND (stkMoviCabe = ISNULL(@pstkMoviCabe,stkMoviCabe))
 
 RETURN @@Error 

GO

DROP PROCEDURE comEmbAsiCierreEliminar
GO
CREATE PROCEDURE comEmbAsiCierreEliminar
(
@pcomEmbarques bigint,
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM comEmbAsiCierre 
WHERE (comEmbarques = @pcomEmbarques)
	AND (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO


