
-- INF_impControlCfdi 1,'20200401','20200430'
DROP PROCEDURE INF_impControlCfdi
GO
CREATE PROCEDURE INF_impControlCfdi
(
	@Empresa_Id Int, 
	@FechaDesde DateTime, 
	@FechaHasta DateTime
)

AS
SELECT 'En SummaAdv y No En el SAT' AS Tipo, 
vimpCFDIEmitidos.Folio, vimpCFDIEmitidos.Fecha, 
	vimpCFDIEmitidos.UUID, vimpCFDIEmitidos.TipoComprobante, vimpCFDIEmitidos.Anulado, 
	isnull(vimpCFDIEmitidos.FechaAnulacion,vimpCFDIEmitidos.Fecha) FechaAnulacion
FROM vimpCFDIEmitidos 
WHERE
		vimpCFDIEmitidos.Empresa_Id = @Empresa_Id and 
		vimpCFDIEmitidos.Fecha Between @FechaDesde and @FechaHasta and 
		Not exists(SELECT 1 FROM impCfdiMetaDatos WHERE
			impCfdiMetaDatos.UUID = vimpCFDIEmitidos.UUID AND 
			impCfdiMetaDatos.Empresa_Id = @Empresa_Id)
UNION ALL
SELECT 'En el SAT y no En SummaAdv' AS Tipo, 
' ' Folio, impCfdiMetaDatos.FechaEmision, 
	impCfdiMetaDatos.UUID, impCfdiMetaDatos.EfectoComprobante, 1-impCfdiMetaDatos.Estatus, 
	isnull(impCfdiMetaDatos.FechaCancelacion,impCfdiMetaDatos.FechaEmision)
FROM impCfdiMetaDatos
	INNER JOIN genEmpresas ON genEmpresas.genEmpresas = 	@Empresa_Id  and 		
			impCfdiMetaDatos.RfcEmisor = genEmpresas.Cuit
WHERE
	impCfdiMetaDatos.EfectoComprobante IN ('I','E') AND 
	impCfdiMetaDatos.Empresa_id = @Empresa_Id and 
	impCfdiMetaDatos.FechaEmision Between @FechaDesde and @FechaHasta  and 
	Not exists(SELECT 1 FROM vimpCFDIEmitidos WHERE
		vimpCFDIEmitidos.UUID =  impCfdiMetaDatos.UUID AND
		vimpCFDIEmitidos.Empresa_Id = @Empresa_Id)
UNION ALL
SELECT 'Cancelada SummaAdv y No En el SAT' AS Tipo, 
vimpCFDIEmitidos.Folio, vimpCFDIEmitidos.Fecha, 
	vimpCFDIEmitidos.UUID, vimpCFDIEmitidos.TipoComprobante, 1 Anulado, 
	vimpCFDIEmitidos.FechaAnulacion
FROM vimpCFDIEmitidos inner join impCfdiMetaDatos ON 
			impCfdiMetaDatos.UUID = vimpCFDIEmitidos.UUID  AND 
			vimpCFDIEmitidos.Empresa_Id = @Empresa_Id
	INNER JOIN genEmpresas ON genEmpresas.genEmpresas = 	@Empresa_Id  and 		
			impCfdiMetaDatos.RfcEmisor = genEmpresas.Cuit
WHERE
		vimpCFDIEmitidos.Empresa_Id = @Empresa_Id and 
		vimpCFDIEmitidos.Fecha Between @FechaDesde and @FechaHasta and 
		vimpCFDIEmitidos.Anulado = 1 AND 
		impCfdiMetaDatos.Estatus = 1
UNION ALL
SELECT 'Cancelada SAT y No En el SummaAdv' AS Tipo, 
vimpCFDIEmitidos.Folio, vimpCFDIEmitidos.Fecha, 
	vimpCFDIEmitidos.UUID, vimpCFDIEmitidos.TipoComprobante, 0 Anulado, 
	vimpCFDIEmitidos.FechaAnulacion
FROM vimpCFDIEmitidos inner join impCfdiMetaDatos ON 
			impCfdiMetaDatos.UUID = vimpCFDIEmitidos.UUID  AND 
			vimpCFDIEmitidos.Empresa_Id = @Empresa_Id 
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = 	@Empresa_Id  and 		
			impCfdiMetaDatos.RfcEmisor = genEmpresas.Cuit
WHERE
		vimpCFDIEmitidos.Empresa_Id = @Empresa_Id and 
		vimpCFDIEmitidos.Fecha Between @FechaDesde and @FechaHasta and 
		vimpCFDIEmitidos.Anulado = 0 AND 
		impCfdiMetaDatos.Estatus = 0
ORDER BY 1, 3, 2



GO

