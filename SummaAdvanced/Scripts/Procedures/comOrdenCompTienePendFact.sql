DROP PROCEDURE comOrdenCompTienePendFact 
GO
CREATE PROCEDURE comOrdenCompTienePendFact (
	@comOrdenComp Int 
)

AS

DECLARE @Cant INT

SET @Cant = (SELECT COUNT(1) FROM comOCCuerpo where 
	comOCCuerpo.comOrdenComp = @comOrdenComp and 
	comOCCuerpo.Cantidad_Facturada - comOCCuerpo.Cantidad_Creditos < comOCCuerpo.Cantidad
	)
	
SELECT @comOrdenComp as comOrdenComp , cast(CASE WHEN @Cant > 0 then 1 else 0 end	as Bit) Pendiente
GO
	
