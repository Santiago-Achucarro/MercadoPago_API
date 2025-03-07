DROP PROCEDURE genTareasProgMensualesXDiaGuardar
GO
CREATE PROCEDURE genTareasProgMensualesXDiaGuardar
(
@pTareaProgramada_Id int,
@pDia_1 Sino,
@pDia_2 Sino,
@pDia_3 Sino,
@pDia_4 Sino,
@pDia_5 Sino,
@pDia_6 Sino,
@pDia_7 Sino,
@pDia_8 Sino,
@pDia_9 Sino,
@pDia_10 Sino,
@pDia_11 Sino,
@pDia_12 Sino,
@pDia_13 Sino,
@pDia_14 Sino,
@pDia_15 Sino,
@pDia_16 Sino,
@pDia_17 Sino,
@pDia_18 Sino,
@pDia_19 Sino,
@pDia_20 Sino,
@pDia_21 Sino,
@pDia_22 Sino,
@pDia_23 Sino,
@pDia_24 Sino,
@pDia_25 Sino,
@pDia_26 Sino,
@pDia_27 Sino,
@pDia_28 Sino,
@pDia_29 Sino,
@pDia_30 Sino,
@pDia_31 Sino,
@pUltimo Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTareasProgMensualesXDia WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgMensualesXDia
	SET		Dia_1 = @pDia_1,
		Dia_2 = @pDia_2,
		Dia_3 = @pDia_3,
		Dia_4 = @pDia_4,
		Dia_5 = @pDia_5,
		Dia_6 = @pDia_6,
		Dia_7 = @pDia_7,
		Dia_8 = @pDia_8,
		Dia_9 = @pDia_9,
		Dia_10 = @pDia_10,
		Dia_11 = @pDia_11,
		Dia_12 = @pDia_12,
		Dia_13 = @pDia_13,
		Dia_14 = @pDia_14,
		Dia_15 = @pDia_15,
		Dia_16 = @pDia_16,
		Dia_17 = @pDia_17,
		Dia_18 = @pDia_18,
		Dia_19 = @pDia_19,
		Dia_20 = @pDia_20,
		Dia_21 = @pDia_21,
		Dia_22 = @pDia_22,
		Dia_23 = @pDia_23,
		Dia_24 = @pDia_24,
		Dia_25 = @pDia_25,
		Dia_26 = @pDia_26,
		Dia_27 = @pDia_27,
		Dia_28 = @pDia_28,
		Dia_29 = @pDia_29,
		Dia_30 = @pDia_30,
		Dia_31 = @pDia_31,
		Ultimo = @pUltimo
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgMensualesXDia
	(
		TareaProgramada_Id,
		Dia_1,
		Dia_2,
		Dia_3,
		Dia_4,
		Dia_5,
		Dia_6,
		Dia_7,
		Dia_8,
		Dia_9,
		Dia_10,
		Dia_11,
		Dia_12,
		Dia_13,
		Dia_14,
		Dia_15,
		Dia_16,
		Dia_17,
		Dia_18,
		Dia_19,
		Dia_20,
		Dia_21,
		Dia_22,
		Dia_23,
		Dia_24,
		Dia_25,
		Dia_26,
		Dia_27,
		Dia_28,
		Dia_29,
		Dia_30,
		Dia_31,
		Ultimo
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pDia_1,
		@pDia_2,
		@pDia_3,
		@pDia_4,
		@pDia_5,
		@pDia_6,
		@pDia_7,
		@pDia_8,
		@pDia_9,
		@pDia_10,
		@pDia_11,
		@pDia_12,
		@pDia_13,
		@pDia_14,
		@pDia_15,
		@pDia_16,
		@pDia_17,
		@pDia_18,
		@pDia_19,
		@pDia_20,
		@pDia_21,
		@pDia_22,
		@pDia_23,
		@pDia_24,
		@pDia_25,
		@pDia_26,
		@pDia_27,
		@pDia_28,
		@pDia_29,
		@pDia_30,
		@pDia_31,
		@pUltimo
	)
END 

GO

DROP PROCEDURE genTareasProgMensualesXDiaDatos
GO
CREATE PROCEDURE genTareasProgMensualesXDiaDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgMensualesXDia.Dia_1, genTareasProgMensualesXDia.Dia_2,
	genTareasProgMensualesXDia.Dia_3, genTareasProgMensualesXDia.Dia_4, genTareasProgMensualesXDia.Dia_5, genTareasProgMensualesXDia.Dia_6,
	genTareasProgMensualesXDia.Dia_7, genTareasProgMensualesXDia.Dia_8, genTareasProgMensualesXDia.Dia_9, genTareasProgMensualesXDia.Dia_10,
	genTareasProgMensualesXDia.Dia_11, genTareasProgMensualesXDia.Dia_12, genTareasProgMensualesXDia.Dia_13, genTareasProgMensualesXDia.Dia_14,
	genTareasProgMensualesXDia.Dia_15, genTareasProgMensualesXDia.Dia_16, genTareasProgMensualesXDia.Dia_17, genTareasProgMensualesXDia.Dia_18,
	genTareasProgMensualesXDia.Dia_19, genTareasProgMensualesXDia.Dia_20, genTareasProgMensualesXDia.Dia_21, genTareasProgMensualesXDia.Dia_22,
	genTareasProgMensualesXDia.Dia_23, genTareasProgMensualesXDia.Dia_24, genTareasProgMensualesXDia.Dia_25, genTareasProgMensualesXDia.Dia_26,
	genTareasProgMensualesXDia.Dia_27, genTareasProgMensualesXDia.Dia_28, genTareasProgMensualesXDia.Dia_29, genTareasProgMensualesXDia.Dia_30,
	genTareasProgMensualesXDia.Dia_31, genTareasProgMensualesXDia.Ultimo
FROM genTareasProgMensualesXDia 
WHERE (genTareasProgMensualesXDia.TareaProgramada_Id = @pTareaProgramada_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genTareasProgMensualesXDiaEliminar
GO
CREATE PROCEDURE genTareasProgMensualesXDiaEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgMensualesXDia 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
