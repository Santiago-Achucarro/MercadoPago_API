DROP PROCEDURE genClavesComunesDatos
GO

CREATE PROCEDURE genClavesComunesDatos
(
	@Clave VarChar(50)
)
AS

SELECT Clave from genClavesComunes WHERE Clave = @Clave

GO


