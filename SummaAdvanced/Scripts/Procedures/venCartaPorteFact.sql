DROP PROCEDURE venCartaPorteFactGuardar
GO
CREATE PROCEDURE venCartaPorteFactGuardar
(
@pvenMovimientosFactCP bigint,
@pvenMovimientosFact bigint = NULL,
@pParada int,
@pDistanciaRecorrida numeric (5,2),
@pFechaHoraLLegada qFecha
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCartaPorteFact WHERE (venMovimientosFactCP = @pvenMovimientosFactCP and venMovimientosFact = @pvenMovimientosFact)))
BEGIN 
	UPDATE venCartaPorteFact
	SET		
		Parada=@pParada,
		DistanciaRecorrida=@pDistanciaRecorrida,
		FechaHoraLLegada=@pFechaHoraLLegada
	
	WHERE (venMovimientosFactCP = @pvenMovimientosFactCP and venMovimientosFact = @pvenMovimientosFact)
END 
ELSE 
BEGIN 
	INSERT INTO venCartaPorteFact
	(
		venMovimientosFactCP,
		venMovimientosFact,
		Parada,
		DistanciaRecorrida,
		FechaHoraLLegada
	)
	VALUES 
	(
		@pvenMovimientosFactCP,
		@pvenMovimientosFact,
		@pParada,
		@pDistanciaRecorrida,
		@pFechaHoraLLegada
	)
END 

GO
-- exec venCartaPorteFactDatosFact  1, 'FC', 2127,0,0,0,'F','0202','I',' '
DROP PROCEDURE venCartaPorteFactDatosFact 
GO
CREATE PROCEDURE venCartaPorteFactDatosFact
(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

SELECT venCartaPorteFact.venMovimientosFactCP, venCartaPorteFact.venMovimientosFact, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
from venCartaPorteFact
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = venCartaPorteFact.venMovimientosFact)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN genSegmentos  ON  genSegmentos.genSegmentos =genAsiSegmentos.Segmento_Id
where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C

SELECT genSegmentos.Segmento_Id as Segmento_Id,
	genAsiSegmentos.Segmento1C Segmento1C,genAsiSegmentos.Segmento2C Segmento2C,
	genAsiSegmentos.Segmento3C Segmento3C,genAsiSegmentos.Segmento4C Segmento4C,
	genAsiSegmentos.Segmento1N Segmento1N ,genAsiSegmentos.Segmento2N Segmento2N, 
	genAsiSegmentos.Segmento3N Segmento3N, genAsiSegmentos.Segmento4N Segmento4N, 
	genAsiSegmentos.Asiento_Id
FROM venCartaPorteFact 
INNER JOIN venMovimientos venMovimientosFact ON (venMovimientosFact.venMovimientos = venCartaPorteFact.venMovimientosFact)
INNER JOIN genAsiSegmentos genAsiSegmentosFact ON genAsiSegmentosFact.Asiento_Id = venMovimientosFact.venMovimientos
INNER JOIN genSegmentos genSegmentosFact ON  genSegmentosFact.genSegmentos =genAsiSegmentosFact.Segmento_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientosFact.venMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venCartaPorteFact.venMovimientosFactCP
INNER JOIN genSegmentos  ON  genSegmentos.genSegmentos =genAsiSegmentos.Segmento_Id
WHERE 
	conAsientos.Anulado = 0 and 
	genAsiSegmentosFact.Empresa_Id = @pEmpresa_Id and 
	genSegmentosFact.Segmento_Id = @pSegmento_Id and 
	genAsiSegmentosFact.Segmento1N = @pSegmento1N and 
	genAsiSegmentosFact.Segmento2N = @pSegmento2N and 
	genAsiSegmentosFact.Segmento3N = @pSegmento3N and 
	genAsiSegmentosFact.Segmento4N = @pSegmento4N and 
	genAsiSegmentosFact.Segmento1C = @pSegmento1C and 
	genAsiSegmentosFact.Segmento2C = @pSegmento2C and 
	genAsiSegmentosFact.Segmento3C = @pSegmento3C and 
	genAsiSegmentosFact.Segmento4C = @pSegmento4C
 
RETURN @@Error 

GO

DROP PROCEDURE venCartaPorteFactEliminar
GO
CREATE PROCEDURE venCartaPorteFactEliminar
(
@pvenMovimientosFactCP bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venCartaPorteFact 
WHERE (venMovimientosFactCP = @pvenMovimientosFactCP)
 
 RETURN @@Error 

GO

DROP PROCEDURE venCartaPorteFactDatos
GO
CREATE PROCEDURE venCartaPorteFactDatos
(
@pvenMovimientosFactCP bigint
)
AS
SET NOCOUNT ON 

SELECT venCartaPorteFact.venMovimientosFact, venCartaPorteFact.venMovimientosFactCP 
FROM venCartaPorteFact 
WHERE (venMovimientosFactCP = @pvenMovimientosFactCP)
 
RETURN @@Error 

GO
