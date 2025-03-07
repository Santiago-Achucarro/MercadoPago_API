DROP Procedure impCerrar
GO
CREATE Procedure impCerrar
(
@Empresa_Id Int
)
as

SELECT FechaCierreImpuestos as UltimoCierre, 
conPeriodos.Fecha_Hasta as ProximoCierre, 
genEmpresas.FechaCierreCompras, genEmpresas.FechaCierreVentas
FROM genEmpresas 
INNER JOIN conPeriodos on
genEmpresas.genEmpresas = conPeriodos.Empresa_Id and 
DATEADD(dd,1,FechaCierreImpuestos) between conPeriodos.Fecha_Desde And conPeriodos.Fecha_Hasta
Where
	genEmpresas.genEmpresas = @Empresa_Id

GO