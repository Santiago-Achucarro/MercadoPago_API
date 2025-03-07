-- stkMoviCabeRevaDatos 1, 'STOCK',1,0,0,0,'RV',' ',' ',' '
DROP PROCEDURE stkMoviCabeRevaDatos 
go
CREATE PROCEDURE stkMoviCabeRevaDatos (
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
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
Declare @pstkMoviCabe bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )
	
EXEC stkMoviCabeSoloDatos @pstkMoviCabe

EXEC stkMoviCuerpoRevaDatos @pstkMoviCabe

Exec genAtributosGeneralesIdentityDatos @pstkMoviCabe, 'stkMoviCabe' 
-- para Agregar al Asiento
SELECT conCuentas.Cuenta_id, 0 as Tipomov, 0.00 as Importe, ' ' as Clase
FROM conCuentas 
Where
	1=2

-- cuentas de Ajuste
SELECT conCuentas.Cuenta_id CtaDebe, conCuentas.Cuenta_id CtaHaber
FROM conCuentas 
Where
	1=2

EXEC stkmoviCabeCentroDatos @pstkMoviCabe

go

