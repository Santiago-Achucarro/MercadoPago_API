
-- INF_impControlCfdiSAT 1,' ','ZZZ','20220401','20220430',0
DROP PROCEDURE INF_impControlCfdiSAT
GO
CREATE PROCEDURE INF_impControlCfdiSAT
(
	@Empresa_Id Int,
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@SoloErrores Bit
)

AS
SELECT vComMovprov.Comprobante, vComMovprov.Fecha_CCP Fecha,
	impCfdiMetaDatos.Uuid, genMonedas.Moneda_Id, impCfdiMetaDatos.Monto,
	impCfdiMetaDatos.Estatus Estado, 
	impCfdiMetaDatos.FechaEmision,impCfdiMetaDatos.FechaCancelacion,
		case when impCfdiMetaDatos.FechaCancelacion IS null and 
			vComMovprov.Anulado = 0 THEN 'Correcto Vigente' 
			when impCfdiMetaDatos.FechaCancelacion IS NOT null and 
			vComMovprov.Anulado = 1 THEN 'Correcto Cancelado' 
			when impCfdiMetaDatos.FechaCancelacion IS NOT null and 
			vComMovprov.Anulado = 0 THEN 'Cancelado SAT y No en Summa' 
			else 'Cancelado Summa y No en SAT' 	end Estado,
				impCfdiMetaDatos.RfcEmisor,impCfdiMetaDatos.NombreEmisor
	FROM impCfdiMetaDatos	
		INNER JOIN vComMovprov ON vComMovprov.ClaveFiscal = impCfdiMetaDatos.Uuid 
		INNER JOIN conAsientos ON conAsientos.conAsientos = vComMovprov.comMovProv
		INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	WHERE
		vComMovprov.Fecha_CCP between @FechaDesde and @FechaHasta and
		vComMovprov.Empresa = @Empresa_Id and 
		vComMovprov.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		(@SoloErrores = 0 or 
			impCfdiMetaDatos.FechaCancelacion IS NOT null and vComMovprov.Anulado = 0)
UNION ALL

SELECT impCfdiMetaDatos.UUID, impCfdiMetaDatos.FechaEmision Fecha,
	impCfdiMetaDatos.Uuid, ' ' , impCfdiMetaDatos.Monto,
	impCfdiMetaDatos.Estatus Estado, 
	impCfdiMetaDatos.FechaEmision ,impCfdiMetaDatos.FechaCancelacion,
		'En el SAT y No en Summa' 	Estado, 
		impCfdiMetaDatos.RfcEmisor,impCfdiMetaDatos.NombreEmisor
	FROM impCfdiMetaDatos	
		inner join genEmpresas ON 
			genEmpresas.Cuit = impCfdiMetaDatos.RfcReceptor
		LEFT JOIN genEntidades ON RTRIM(LTRIM(genEntidades.Cuit)) = impCfdiMetaDatos.RfcEmisor
		LEFT JOIN comProveedores ON comProveedores.genEntidades = genEntidades.genEntidades
		WHERE NOT EXISTS(SELECT 1 FROM vComMovprov 
		where
			vComMovprov.ClaveFiscal = impCfdiMetaDatos.Uuid )
			AND impCfdiMetaDatos.FechaCancelacion IS null and 
			impCfdiMetaDatos.FechaEmision between @FechaDesde and @FechaHasta and
			genEmpresas.genEmpresas = @Empresa_Id and 
			ISNULL(comProveedores.Proveed_Id,'') between @ProveedDesde and @ProveedHasta 
ORDER BY 1,  2, 3

GO

