DROP PROCEDURE genTareasProgParametrosGuardar
GO
CREATE PROCEDURE genTareasProgParametrosGuardar
(
@pTareaProgramada_Id int,
@pParametro varchar(40),
@pValor varchar(80) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTareasProgParametros WHERE (TareaProgramada_Id = @pTareaProgramada_Id) AND (Parametro = @pParametro)))
BEGIN 
	UPDATE genTareasProgParametros
	SET		Valor = @pValor		   
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id) AND (Parametro = @pParametro) 
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgParametros
	(
		TareaProgramada_Id,
		Parametro,
		Valor
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pParametro,
		@pValor
	)
END 

GO

DROP PROCEDURE genTareasProgParametrosDatos
GO
CREATE PROCEDURE genTareasProgParametrosDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgParametros.Parametro, genTareasParametros.Descripcion, genTareasProgParametros.Valor, genTareasParametros.Obligatorio
FROM genTareasProgParametros 
INNER JOIN genTareasProgramadas ON (genTareasProgramadas.genTareasProgramadas = genTareasProgParametros.TareaProgramada_Id)
INNER JOIN genTareasParametros ON (genTareasParametros.Tarea_Id = genTareasProgramadas.Tarea_Id)  AND (genTareasParametros.Parametro = genTareasProgParametros.Parametro)
WHERE (genTareasProgParametros.TareaProgramada_Id = @pTareaProgramada_Id)
UNION 
SELECT genTareasParametros.Parametro, genTareasParametros.Descripcion, '', genTareasParametros.Obligatorio
FROM genTareasParametros 
INNER JOIN genTareasProgramadas ON (genTareasParametros.Tarea_Id = genTareasProgramadas.Tarea_Id)
WHERE (genTareasProgramadas.genTareasProgramadas = @pTareaProgramada_Id) 
AND NOT EXISTS (SELECT 1 
				FROM genTareasProgParametros 
				WHERE genTareasProgParametros.TareaProgramada_Id = @pTareaProgramada_Id
				AND genTareasProgParametros.Parametro = genTareasParametros .Parametro)

RETURN @@Error 

GO

DROP PROCEDURE genTareasProgParametrosEliminar
GO
CREATE PROCEDURE genTareasProgParametrosEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgParametros 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
