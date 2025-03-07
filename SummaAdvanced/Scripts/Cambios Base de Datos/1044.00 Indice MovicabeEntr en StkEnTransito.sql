CREATE NONCLUSTERED INDEX idxStkEntransitoEntrada
	ON stkEnTransito (stkMoviCabeEntr)
GO

INSERT INTO genVersion (Version) Values(1044.00)
GO
