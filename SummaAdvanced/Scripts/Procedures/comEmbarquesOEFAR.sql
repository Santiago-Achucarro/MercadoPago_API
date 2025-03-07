-- exec comEmbarquesOEFAR 311
DROP PROCEDURE comEmbarquesOEFAR 
GO
CREATE PROCEDURE comEmbarquesOEFAR 
(
	@comEmbarques bigint
)
AS

SELECT SUM(IMPORTE) as Monto FROM 
(

-- Embaruqes 

SELECT SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3))  AS Importe
FROM conMovCont 
inner join comEmbarques ON conMovCont.conAsientos = comEmbarques.comEmbarques
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
WHERE
	clase = 'OEFAR' and
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	comEmbarques.comEmbarques = @comEmbarques
-- RECPECION
UNION ALL
SELECT SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) 
FROM conMovCont 
inner join stkMoviEmbarque ON conMovCont.conAsientos = stkMoviEmbarque.stkMoviCabe
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
WHERE
	clase = 'OEFAR' and
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	stkMoviEmbarque.comEmbarques = @comEmbarques
-- FACTURAS DE ORDEN DE EMBARQUE
UNION ALL
SELECT SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) 
FROM conMovCont 
inner join comMovProvEmb ON conMovCont.conAsientos = comMovProvEmb.comMovProv
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
WHERE
	clase = 'OEFAR' and
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	comMovProvEmb.comEmbarques = @comEmbarques
UNION ALL
SELECT SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) 
FROM conMovCont 
inner join comEmbAsiCierre ON conMovCont.conAsientos = comEmbAsiCierre.stkMoviCabe 
Inner Join conAsientos On conAsientos.conAsientos = conMovCont.conAsientos
WHERE
	clase = 'OEFAR' and
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	comEmbAsiCierre.comEmbarques = @comEmbarques
	) AS XXX

	
GO



