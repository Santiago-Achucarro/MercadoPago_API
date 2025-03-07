DROP Procedure ImpCierreRetencionGuardar
GO
CREATE Procedure ImpCierreRetencionGuardar
(
@Fecha dateTime,
@Empresa_Id Int
)
as

UPDATE genGlobales SET fValor = @Fecha 
where Empresa_Id = @Empresa_Id and nombre_var = 'ImpCierreRetenciones'

GO





DROP Procedure ImpCierreRetencionDato
GO
CREATE Procedure ImpCierreRetencionDato
(
@Empresa_Id Int
)
as

SELECT fValor as UltimoCierre, 
getdate() ProximoCierre, @Empresa_Id Empresa_Id
FROM genGlobales 
where Empresa_Id = @Empresa_Id and nombre_var = 'ImpCierreRetenciones'

GO