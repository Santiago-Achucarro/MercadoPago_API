DROP PROCEDURE genAtriGralesClasesDatos
GO
CREATE PROCEDURE genAtriGralesClasesDatos
(
@pTabla_Id varchar(60)
)
AS
SET NOCOUNT ON 

SELECT genAtriGralesClases.Tabla_Id, genAtriGralesClases.Descripcion
FROM genAtriGralesClases 
WHERE genAtriGralesClases.Tabla_Id = @pTabla_Id

SELECT genAtributosGenerales.AtributoNro, genAtributosGenerales.Tabla_Id, 
genAtributosGenerales.Descripcion, genAtributosGenerales.Tipo, genAtributosGenerales.EnGrilla
FROM genAtriGralesClases 
INNER JOIN genAtributosGenerales ON genAtributosGenerales.Tabla_Id = genAtriGralesClases.Tabla_Id
WHERE genAtributosGenerales.Tabla_Id = @pTabla_Id
ORDER BY 1 
RETURN @@Error 
GO
