DROP PROCEDURE genAtributosValoresAuditFechaDatos
GO
CREATE PROCEDURE genAtributosValoresAuditFechaDatos
(
@pIdentity_Id bigint,
@pAtributoNro int,
@pTabla_Id varchar(60),
@pFecha datetime
)
AS
SET NOCOUNT ON 

SELECT genAtributosValoresAudit.Identity_Id, genAtributosValoresAudit.AtributoNro, genAtributosValoresAudit.Tabla_Id, genAtributosValoresAudit.FechaDesde Fecha,
	genAtributosValoresAudit.FechaDesde, genAtributosValoresAudit.FechaHasta, genAtributosValoresAudit.ValorN, genAtributosValoresAudit.ValorC, genAtributosValoresAudit.ValorF
FROM genAtributosValoresAudit 
WHERE (Identity_Id = @pIdentity_Id)
AND (AtributoNro = @pAtributoNro)
AND (Tabla_Id = @pTabla_Id)
AND (@pFecha Between FechaDesde And FechaHasta)
 
RETURN @@Error 

GO
