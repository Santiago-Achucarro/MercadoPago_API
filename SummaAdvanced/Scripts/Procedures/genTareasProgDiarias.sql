DROP PROCEDURE genTareasProgDiariasGuardar
GO
CREATE PROCEDURE genTareasProgDiariasGuardar
(
@pTareaProgramada_Id int,
@pValor int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTareasProgDiarias WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgDiarias
	SET		Valor = @pValor
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgDiarias
	(
		TareaProgramada_Id,
		Valor
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pValor
	)
END 

GO

DROP PROCEDURE genTareasProgDiariasDatos
GO
CREATE PROCEDURE genTareasProgDiariasDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgDiarias.Valor
FROM genTareasProgDiarias 
INNER JOIN genTareasProgramadas  ON (genTareasProgramadas.genTareasProgramadas = genTareasProgDiarias.TareaProgramada_Id)
WHERE (genTareasProgDiarias.TareaProgramada_Id = @pTareaProgramada_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genTareasProgDiariasEliminar
GO
CREATE PROCEDURE genTareasProgDiariasEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgDiarias 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
