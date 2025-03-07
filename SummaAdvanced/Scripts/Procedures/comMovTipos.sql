DROP PROCEDURE comMovTiposDatos
GO
CREATE PROCEDURE comMovTiposDatos
(
@pTipoMov char(1)
)
AS
SET NOCOUNT ON 

SELECT comMovTipos.TipoMov, comMovTipos.Descripcion, comMovTipos.Signo
FROM comMovTipos 
WHERE (TipoMov = @pTipoMov)
 
 RETURN @@Error 

GO
