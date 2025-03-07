Drop procedure espGenAsiSegDatosKSK
Go
Create procedure espGenAsiSegDatosKSK
(
@pvenMovimientos bigint
)
As
SET NOCOUNT ON

SELECT * FROM genAsiSegmentos WHERE Asiento_Id = @pvenMovimientos
GO
