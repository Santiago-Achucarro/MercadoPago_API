DROP PROCEDURE comMovProvDevengaGuardar
GO
CREATE PROCEDURE comMovProvDevengaGuardar
(
@pcomMovProv bigint,
@pVigenciaDesde qFecha,
@pVigenciaHasta qFecha,
@pImporteADevengar qMonedaD2,
@pCtaADevengar varchar(25) = NULL
)
AS
SET NOCOUNT ON 

INSERT INTO comMovProvDevenga
(
	comMovProv,
	VigenciaDesde,
	VigenciaHasta,
	ImporteADevengar,
	CtaADevengar
)
VALUES 
(
	@pcomMovProv,
	@pVigenciaDesde,
	@pVigenciaHasta,
	@pImporteADevengar,
	dbo.FuncFKconCuentas(@pCtaADevengar)
)
GO

DROP PROCEDURE comMovProvDevengaDatos
GO
CREATE PROCEDURE comMovProvDevengaDatos
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
Declare @pcomMovProv bigint = (select Asiento_Id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C )

Exec comMovProvDatosSinStock @pEmpresa_Id, @pSegmento_Id, @pSegmento1N, @pSegmento2N, @pSegmento3N, @pSegmento4N, @pSegmento1C, @pSegmento2C, @pSegmento3C, @pSegmento4C

SELECT comMovProvDevenga.comMovProv, comMovProvDevenga.VigenciaDesde, comMovProvDevenga.VigenciaHasta,
	comMovProvDevenga.ImporteADevengar, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas
FROM comMovProvDevenga 
INNER JOIN comMovProv  ON (comMovProv.comMovProv = comMovProvDevenga.comMovProv)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = comMovProvDevenga.CtaADevengar)
WHERE (comMovProvDevenga.comMovProv = @pcomMovProv)

Exec comMovProvDevengaCtasDatos @pcomMovProv

Exec comMovProvDevengaContDatos @pcomMovProv
 
RETURN @@Error 

GO

DROP PROCEDURE comMovProvDevengaEliminar
GO
CREATE PROCEDURE comMovProvDevengaEliminar
(
@pcomMovProv bigint
)
AS
SET NOCOUNT ON 

DELETE FROM comMovProvDevenga 
WHERE (comMovProv = @pcomMovProv)
 
RETURN @@Error 

GO
