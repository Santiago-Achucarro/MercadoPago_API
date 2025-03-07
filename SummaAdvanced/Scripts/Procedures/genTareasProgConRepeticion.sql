DROP PROCEDURE genTareasProgConRepeticionGuardar
GO
CREATE PROCEDURE genTareasProgConRepeticionGuardar
(
@pTareaProgramada_Id int,
@pValor int,
@pUnidadMedida varchar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTareasProgConRepeticion WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgConRepeticion
	SET		Valor = @pValor,
		UnidadMedida = @pUnidadMedida
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgConRepeticion
	(
		TareaProgramada_Id,
		Valor,
		UnidadMedida
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pValor,
		@pUnidadMedida
	)
END 

GO

DROP PROCEDURE genTareasProgConRepeticionDatos
GO
CREATE PROCEDURE genTareasProgConRepeticionDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgConRepeticion.Valor, genTareasProgConRepeticion.UnidadMedida
FROM genTareasProgConRepeticion 
INNER JOIN genTareasProgramadas  ON (genTareasProgramadas.genTareasProgramadas = genTareasProgConRepeticion.TareaProgramada_Id)
WHERE (genTareasProgConRepeticion.TareaProgramada_Id = @pTareaProgramada_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genTareasProgConRepeticionEliminar
GO
CREATE PROCEDURE genTareasProgConRepeticionEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgConRepeticion 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
