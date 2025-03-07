DROP PROCEDURE comOrdenCompTienePendEntrega 
GO
CREATE PROCEDURE comOrdenCompTienePendEntrega (
	@comOrdenComp Int 
)

AS

DECLARE @Cant INT

SET @Cant = (SELECT COUNT(1) FROM comOCCuerpo where 
	comOCCuerpo.comOrdenComp = @comOrdenComp and 
	comOCCuerpo.Pendiente = 1
	)
	
SELECT @comOrdenComp as comOrdenComp , cast(CASE WHEN @Cant > 0 then 1 else 0 end	as Bit) Pendiente
GO
	
