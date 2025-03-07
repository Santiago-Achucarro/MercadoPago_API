--- VentasCerrar 1
DROP Procedure VentasCerrar
GO
CREATE Procedure VentasCerrar
(
@Empresa_Id Int
)
as

SELECT FechaCierreVentas as UltimoCierre, 
conPeriodos.Fecha_Hasta as ProximoCierre
FROM genEmpresas 
INNER JOIN conPeriodos on
genEmpresas.genEmpresas = conPeriodos.Empresa_Id and 
DATEADD(dd,1,FechaCierreVentas) between conPeriodos.Fecha_Desde And conPeriodos.Fecha_Hasta
Where
	genEmpresas.genEmpresas = @Empresa_Id

GO