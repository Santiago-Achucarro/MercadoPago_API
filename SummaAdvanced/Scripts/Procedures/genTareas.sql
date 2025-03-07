DROP FUNCTION FuncFKgenTareas
GO

CREATE FUNCTION FuncFKgenTareas
(
@pTarea_Id varchar (80)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genTareas FROM genTareas WHERE 
	Tarea_Id = @pTarea_Id
  RETURN @pIdentity
END

GO

DROP PROCEDURE genTareasParametrosDatos
GO
CREATE PROCEDURE genTareasParametrosDatos
(
@pTarea_Id varchar (80)
)
AS
SET NOCOUNT ON 

SELECT genTareasParametros.Parametro, genTareasParametros.Descripcion, '' as Valor, genTareasParametros.Obligatorio
FROM genTareasParametros 
WHERE genTareasParametros.Tarea_Id = dbo.FuncFKgenTareas(@pTarea_Id) 

RETURN @@Error 

GO


