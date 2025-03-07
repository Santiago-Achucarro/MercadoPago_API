DROP PROCEDURE genReportesDatosTodos
GO

CREATE PROCEDURE genReportesDatosTodos
AS

SET NOCOUNT ON 

SELECT genReportes.genReportes, genReportes.Reporte_Id,genReportes.Reporte_Id as Reporte_Id_Nueva,
		genReportes.Titulo, genReportes.Carpeta, genReportes.Rpt, 
		genReportes.Estandar, genReportes.Local, genReportes.StoreProcedure, genReportes.TipoReporte, 
			genReportes.TamanioHoja, genReportes.AnchoHoja, genReportes.AltoHoja
FROM genReportes 
order by 2
RETURN @@Error 

GO
