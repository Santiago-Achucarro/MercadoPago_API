DROP PROCEDURE tesSolicitudPago
GO
-- tesCobranzasDatos 1
CREATE PROCEDURE tesSolicitudPago
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
SET NOCOUNT ON 

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
	
	EXECUTE tesMovimientosDatos @ptesMovimientos

Exec tesRengMoviDHDatos @ptesMovimientos, 1, NULL
Exec tesRengMoviDHDatos @ptesMovimientos, 2, NULL

Exec tesRengConciliacDatos @ptesMovimientos, NULL,1
Exec tesRengConciliacDatos @ptesMovimientos, NULL,2
Exec tesMovimientosCambio @ptesMovimientos

SELECT tesSolSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
tesSolSegmentos.Segmento1N,tesSolSegmentos.Segmento2N,tesSolSegmentos.Segmento3N,
tesSolSegmentos.Segmento4N,tesSolSegmentos.Segmento1C,tesSolSegmentos.Segmento2C,
tesSolSegmentos.Segmento3C,tesSolSegmentos.Segmento4C,
tesSolSegmentos.tesSolicitud as tesMovimientos, 
tesSolicitud.Fecha, tesSolicitud.Monto as Monto, 
		tesSolicitantes.Solicitante_Id Entidad_Id, tesSolicitantes.Nombre EntidadDescripcion 
from
	tesSolicitud INNER JOIN tesSolSegmentos ON 
	tesSolicitud.tesSolicitud = tesSolSegmentos.tesSolicitud 
	INNER JOIN tesSolicitantes ON
	tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id
	INNER JOIN tesSolPago ON 
	tesSolPago.tesSolicitud = tesSolicitud.tesSolicitud
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = tesSolSegmentos.Segmento_Id
	WHERE
	tesSolPago.tesMovimientos = @ptesMovimientos


Exec genAtributosGeneralesIdentityDatos @ptesMovimientos, 'tesMovimientos'

go

