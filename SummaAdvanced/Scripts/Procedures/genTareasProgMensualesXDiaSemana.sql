DROP PROCEDURE genTareasProgMensualesXDiaSemanaGuardar
GO
CREATE PROCEDURE genTareasProgMensualesXDiaSemanaGuardar
(
@pTareaProgramada_Id int,
@pPrimero Sino,
@pSegundo Sino,
@pTercero Sino,
@pCuarto Sino,
@pUltimo Sino,
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
IF (EXISTS (SELECT 1 FROM genTareasProgMensualesXDiaSemana WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgMensualesXDiaSemana
	SET		Primero = @pPrimero,
		Segundo = @pSegundo,
		Tercero = @pTercero,
		Cuarto = @pCuarto,
		Ultimo = @pUltimo,
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
	INSERT INTO genTareasProgMensualesXDiaSemana
	(
		TareaProgramada_Id,
		Primero,
		Segundo,
		Tercero,
		Cuarto,
		Ultimo,
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
		@pPrimero,
		@pSegundo,
		@pTercero,
		@pCuarto,
		@pUltimo,
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

DROP PROCEDURE genTareasProgMensualesXDiaSemanaDatos
GO
CREATE PROCEDURE genTareasProgMensualesXDiaSemanaDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgMensualesXDiaSemana.Primero, genTareasProgMensualesXDiaSemana.Segundo,
	genTareasProgMensualesXDiaSemana.Tercero, genTareasProgMensualesXDiaSemana.Cuarto, genTareasProgMensualesXDiaSemana.Ultimo
FROM genTareasProgMensualesXDiaSemana 
WHERE (genTareasProgMensualesXDiaSemana.TareaProgramada_Id = @pTareaProgramada_Id)

SELECT genTareasProgMensualesXDiaSemana.Lunes,	genTareasProgMensualesXDiaSemana.Martes, genTareasProgMensualesXDiaSemana.Miercoles, 
	genTareasProgMensualesXDiaSemana.Jueves, genTareasProgMensualesXDiaSemana.Viernes,
	genTareasProgMensualesXDiaSemana.Sabado, genTareasProgMensualesXDiaSemana.Domingo
FROM genTareasProgMensualesXDiaSemana 
WHERE (genTareasProgMensualesXDiaSemana.TareaProgramada_Id = @pTareaProgramada_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genTareasProgMensualesXDiaSemanaEliminar
GO
CREATE PROCEDURE genTareasProgMensualesXDiaSemanaEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgMensualesXDiaSemana 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
