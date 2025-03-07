DROP PROCEDURE stkEnTransitoGuardar
GO
CREATE PROCEDURE stkEnTransitoGuardar
(
@pstkMoviCabe bigint,
@pstkMoviCabeEntr bigint = NULL,
@pDeposito_Id varchar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkEnTransito WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkEnTransito
	SET		stkMoviCabeEntr = @pstkMoviCabeEntr,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id)
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkEnTransito
	(
		stkMoviCabe,
		stkMoviCabeEntr,
		Deposito_Id
	)
	VALUES 
	(
		@pstkMoviCabe,
		@pstkMoviCabeEntr,
		dbo.FuncFKstkDepositos(@pDeposito_Id)
	)
END 

GO

DROP PROCEDURE stkEnTransitoDatos
GO
CREATE PROCEDURE stkEnTransitoDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT stkEnTransito.stkMoviCabe, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentosEntr.Segmento1N Segmento1NEntr, genAsiSegmentosEntr.Segmento2N Segmento2NEntr, 
genAsiSegmentosEntr.Segmento3N Segmento3NEntr, genAsiSegmentosEntr.Segmento4N Segmento4NEntr,
stkEnTransito.stkMoviCabeEntr,
genAsiSegmentosEntr.Segmento1C Segmento1CEntr, genAsiSegmentosEntr.Segmento2C Segmento2CEntr, 
genAsiSegmentosEntr.Segmento3C Segmento3CEntr, genAsiSegmentosEntr.Segmento4C Segmento4CEntr,
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos
FROM stkEnTransito 
INNER JOIN genAsiSegmentos  ON (genAsiSegmentos.Asiento_id = stkEnTransito.stkMoviCabe)
LEFT JOIN genAsiSegmentos genAsiSegmentosEntr ON (genAsiSegmentosEntr.Asiento_id = stkEnTransito.stkMoviCabeEntr)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkEnTransito.Deposito_Id)
WHERE (stkEnTransito.stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO

DROP PROCEDURE stkEnTransitoDatosEntr
GO
CREATE PROCEDURE stkEnTransitoDatosEntr
(
@pstkMoviCabeEntr bigint
)
AS
SET NOCOUNT ON 

SELECT stkEnTransito.stkMoviCabe, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
genAsiSegmentosEntr.Segmento1N Segmento1NEntr, genAsiSegmentosEntr.Segmento2N Segmento2NEntr, 
genAsiSegmentosEntr.Segmento3N Segmento3NEntr, genAsiSegmentosEntr.Segmento4N Segmento4NEntr,
stkEnTransito.stkMoviCabeEntr,
genAsiSegmentosEntr.Segmento1C Segmento1CEntr, genAsiSegmentosEntr.Segmento2C Segmento2CEntr, 
genAsiSegmentosEntr.Segmento3C Segmento3CEntr, genAsiSegmentosEntr.Segmento4C Segmento4CEntr,
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos
FROM stkEnTransito 
INNER JOIN genAsiSegmentos  ON (genAsiSegmentos.Asiento_id = stkEnTransito.stkMoviCabe)
LEFT JOIN genAsiSegmentos genAsiSegmentosEntr ON (genAsiSegmentosEntr.Asiento_id = stkEnTransito.stkMoviCabeEntr)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkEnTransito.Deposito_Id)
WHERE (stkEnTransito.stkMoviCabeEntr = @pstkMoviCabeEntr)
 
RETURN @@Error 

GO

DROP PROCEDURE stkEnTransitoEliminar
GO
CREATE PROCEDURE stkEnTransitoEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkEnTransito 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO

GO
