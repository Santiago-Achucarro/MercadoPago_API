DROP Procedure AfiFijoCerrar 
GO
CREATE Procedure AfiFijoCerrar
(
@Empresa_Id Int
)
as

SELECT FechaCierreActivoFijo as UltimoCierre, 
conPeriodos.Fecha_Hasta as ProximoCierre
FROM genEmpresas 
INNER JOIN conPeriodos on
genEmpresas.genEmpresas = conPeriodos.Empresa_Id and 
DATEADD(dd,1,FechaCierreActivoFijo) between conPeriodos.Fecha_Desde And conPeriodos.Fecha_Hasta
Where
	genEmpresas.genEmpresas = @Empresa_Id

GO