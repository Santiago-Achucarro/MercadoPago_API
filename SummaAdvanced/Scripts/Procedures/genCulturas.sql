DROP PROCEDURE genCulturasDatos
GO
CREATE PROCEDURE genCulturasDatos
(
@pCultura varchar(5)
)
AS
SET NOCOUNT ON 

SELECT genCulturas.Cultura, genCulturas.Descripcion
FROM genCulturas 
WHERE (Cultura = @pCultura)
 
 RETURN @@Error 

GO
