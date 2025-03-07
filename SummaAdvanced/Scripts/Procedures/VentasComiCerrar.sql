--- VentasComiCerrar 1
DROP Procedure VentasComiCerrar
GO
CREATE Procedure VentasComiCerrar
(
@Empresa_Id Int
)
AS

SELECT FechaCierreComi as UltimoCierre, 
DATEADD(MM,1,FechaCierreComi) as ProximoCierre
FROM genEmpresas 
INNER JOIN conPeriodos on
genEmpresas.genEmpresas = conPeriodos.Empresa_Id and 
DATEADD(dd,1,FechaCierreComi) between conPeriodos.Fecha_Desde And conPeriodos.Fecha_Hasta
WHERE
	genEmpresas.genEmpresas = @Empresa_Id
GO



