DROP PROCEDURE genTareasProgSemanalesGuardar
GO
CREATE PROCEDURE genTareasProgSemanalesGuardar
(
@pTareaProgramada_Id int,
@pValor int,
@pLunes Sino,
@pMartes Sino,
@pMiercoles Sino,
@pJueves Sino,
@pViernes Sino,
@pSabado Sino,
@pDomingo Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTareasProgSemanales WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgSemanales
	SET		Valor = @pValor,
		Lunes = @pLunes,
		Martes = @pMartes,
		Miercoles = @pMiercoles,
		Jueves = @pJueves,
		Viernes = @pViernes,
		Sabado = @pSabado,
		Domingo = @pDomingo
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgSemanales
	(
		TareaProgramada_Id,
		Valor,
		Lunes,
		Martes,
		Miercoles,
		Jueves,
		Viernes,
		Sabado,
		Domingo
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pValor,
		@pLunes,
		@pMartes,
		@pMiercoles,
		@pJueves,
		@pViernes,
		@pSabado,
		@pDomingo
	)
END 

GO

DROP PROCEDURE genTareasProgSemanalesDatos
GO
CREATE PROCEDURE genTareasProgSemanalesDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgSemanales.Valor
FROM genTareasProgSemanales 
WHERE (genTareasProgSemanales.TareaProgramada_Id = @pTareaProgramada_Id)

SELECT genTareasProgSemanales.Lunes,
	genTareasProgSemanales.Martes, genTareasProgSemanales.Miercoles, genTareasProgSemanales.Jueves, genTareasProgSemanales.Viernes,
	genTareasProgSemanales.Sabado, genTareasProgSemanales.Domingo
FROM genTareasProgSemanales 
WHERE (genTareasProgSemanales.TareaProgramada_Id = @pTareaProgramada_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genTareasProgSemanalesEliminar
GO
CREATE PROCEDURE genTareasProgSemanalesEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgSemanales 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
