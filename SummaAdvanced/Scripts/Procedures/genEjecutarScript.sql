DROP PROCEDURE genEjecutarScript
GO

CREATE PROCEDURE genEjecutarScript
(
@pSentencias nvarchar(Max)
)
as

EXECUTE sp_executesql @pSentencias

GO