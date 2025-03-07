DROP PROCEDURE stkHojaDeRutaCuerpoGuardar
GO
CREATE PROCEDURE stkHojaDeRutaCuerpoGuardar
(
@pstkHojaDeRuta int,
@pconAsientos bigint
)
AS
BEGIN 
	INSERT INTO stkHojaDeRutaCuerpo
	(
		stkHojaDeRuta,
		conAsientos
	)
	VALUES 
	(
		@pstkHojaDeRuta,
		@pconAsientos
	)
END 

GO

DROP PROCEDURE stkHojaDeRutaCuerpoDatos
GO
CREATE PROCEDURE stkHojaDeRutaCuerpoDatos
(
@pstkHojaDeRuta int = null,
@pconAsientos bigint = null
)
AS
SET NOCOUNT ON 

SELECT stkHojaDeRutaCuerpo.stkHojaDeRuta, stkHojaDeRutaCuerpo.conAsientos, 
dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, 
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Comprobante, 
dbo.Segmento(stkHojaSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, stkHojaSegmentos.Segmento2C, 
stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, 
stkHojaSegmentos.Segmento2N, stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N) as HojaRuta 
FROM stkHojaDeRutaCuerpo 
inner join genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkHojaDeRutaCuerpo.conAsientos
inner join stkHojaSegmentos  ON  stkHojaSegmentos.stkHojaDeRuta = stkHojaDeRutaCuerpo.stkHojaDeRuta
WHERE 
stkHojaDeRutaCuerpo.stkHojaDeRuta = ISNULL(@pstkHojaDeRuta,stkHojaDeRutaCuerpo.stkHojaDeRuta) AND 
stkHojaDeRutaCuerpo.conAsientos =  ISNULL(@pconAsientos,stkHojaDeRutaCuerpo.conAsientos)
RETURN @@Error 

GO

DROP PROCEDURE stkHojaDeRutaCuerpoEliminar
GO
CREATE PROCEDURE stkHojaDeRutaCuerpoEliminar
(
@pstkHojaDeRuta int,
@pconAsientos bigint = null
)
AS
SET NOCOUNT ON 

DELETE FROM stkHojaDeRutaCuerpo 
WHERE (stkHojaDeRuta = @pstkHojaDeRuta)
AND (conAsientos = ISNULL(@pconAsientos,conAsientos))
 
RETURN @@Error 

GO

