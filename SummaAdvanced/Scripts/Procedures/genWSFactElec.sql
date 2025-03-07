DROP PROCEDURE genWSFactElecDatos
GO
CREATE PROCEDURE genWSFactElecDatos
(
@pTipoFE varchar(5)
)
AS
SET NOCOUNT ON 

SELECT genWSFactElec.TipoFE, genWSFactElec.Descripcion
FROM genWSFactElec 
WHERE (TipoFE = @pTipoFE)
 
 RETURN @@Error 

GO
