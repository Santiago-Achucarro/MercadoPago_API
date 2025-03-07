DROP PROCEDURE Inf_SueLibroFlia
GO
CREATE PROCEDURE Inf_SueLibroFlia
(
	@Segmento_Id VarChar(10),
	@Segmento1N INT, 
	@Segmento2N INT, 
	@Segmento3N INT, 
	@Segmento4N INT, 
	@Segmento1C VarChar(25), 
	@Segmento2C VarChar(25), 
	@Segmento3C VarChar(25), 
	@Segmento4C VarChar(25), 
	@Empresa_Id Int, 
	@LegajoDesde Int ,
	@LegajoHasta Int, 
	@TipoPagoDesde VARCHAR(5),
	@TipoPagoHasta VARCHAR(5),
	@Centro1Desde VARCHAR(8),
	@Centro1Hasta VARCHAR(8),
	@ConvenioDesde VARCHAR(5),
	@ConvenioHasta VARCHAR(5),
	@SucursalDesde VARCHAR(4),
	@SucursalHasta VARCHAR(4)
)
AS
SELECT sueFamiliares.Legajo, sueFamiliares.NroDoc, sueFamiliares.ApellidoyNombre, 
sueFamiliares.Sexo, sueFamiliares.FechaNacimiento 
FROM suePersonal
INNER JOIN sueFamiliares ON suePersonal.genEntidades = sueFamiliares.Legajo
WHERE suePersonal.Legajo BETWEEN  @LegajoDesde And @LegajoHasta
GO

