--tesMovimientosOtrosEgresos 1, 'TES',0,0,0,0,' ',' ',' ',' '

drop Procedure tesMovimientosOtrosEgresos
GO
Create Procedure tesMovimientosOtrosEgresos
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
)
AS

Declare @ptesMovimientos as BigInt
SET @ptesMovimientos = (Select tesMovimientos.tesMovimientos from 
	tesMovimientos INNER JOIN genAsiSegmentos ON
	tesMovimientos.tesMovimientos = genAsiSegmentos.Asiento_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C )

-- Principal
EXECUTE tesMovimientosDatos @ptesMovimientos

-- Debe
Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
-- Haber
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

-- ConciliacDebe
Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
-- ConciliacHaber
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2

-- FactAneCuerpoDebe , FactAneImpuestoDebe
Exec tesFactAnexoMovDatos @pTesMovimientos, 1
-- FactAneCuerpoHaber, FactAneImpuestoHaber
Exec tesFactAnexoMovDatos @pTesMovimientos, 2


-- Reversa
-- para Reversion de OP
SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
tesMovimientos.tesMovimientos
FROM tesMovimientos 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = tesMovimientos.tesMovimientos)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE 1=2

-- TiposCambio
-- TIPOS DE CAMBIO
Exec tesMovimientosCambio @ptesMovimientos
-- genAtributosGenerales
Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'



GO
