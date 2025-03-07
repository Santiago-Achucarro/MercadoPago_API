select Reporte_Id, COUNT(1) cantidad , min(genReportes) genReportes
into #repe
from genReportes 
GROUP BY Reporte_Id
HAVING COUNT(1) > 1

Delete From genReportesSP Where genReportes In 
(
Select genReportes from genReportes where 
Reporte_Id In (select Reporte_Id from #repe)
and
genReportes > (select genReportes from #repe where
	#repe.Reporte_id = genReportes.Reporte_Id and
	genReportes.genReportes > #repe.genReportes )
)


Delete from genReportes where 
Reporte_Id In (select Reporte_Id from #repe)
and
genReportes > (select genReportes from #repe where
	#repe.Reporte_id = genReportes.Reporte_Id and
	genReportes.genReportes > #repe.genReportes )


DROP TABLE #repe
GO

CREATE UNIQUE NONCLUSTERED INDEX XAK1genReportes ON genReportes
( 
	Reporte_Id  ASC
)
go

INSERT INTO genVersion(Version) Values(1092.00)
GO