DROP PROCEDURE genTareasProgMensualesGuardar
GO
CREATE PROCEDURE genTareasProgMensualesGuardar
(
@pTareaProgramada_Id int,
@pEnero Sino,
@pFebrero Sino,
@pMarzo Sino,
@pAbril Sino,
@pMayo Sino,
@pJunio Sino,
@pJulio Sino,
@pAgosto Sino,
@pSeptiembre Sino,
@pOctubre Sino,
@pNoviembre Sino,
@pDiciembre Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genTareasProgMensuales WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgMensuales
	SET		Enero = @pEnero,
		Febrero = @pFebrero,
		Marzo = @pMarzo,
		Abril = @pAbril,
		Mayo = @pMayo,
		Junio = @pJunio,
		Julio = @pJulio,
		Agosto = @pAgosto,
		Septiembre = @pSeptiembre,
		Octubre = @pOctubre,
		Noviembre = @pNoviembre,
		Diciembre = @pDiciembre
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgMensuales
	(
		TareaProgramada_Id,
		Enero,
		Febrero,
		Marzo,
		Abril,
		Mayo,
		Junio,
		Julio,
		Agosto,
		Septiembre,
		Octubre,
		Noviembre,
		Diciembre
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pEnero,
		@pFebrero,
		@pMarzo,
		@pAbril,
		@pMayo,
		@pJunio,
		@pJulio,
		@pAgosto,
		@pSeptiembre,
		@pOctubre,
		@pNoviembre,
		@pDiciembre
	)
END 

GO

DROP PROCEDURE genTareasProgMensualesDatos
GO
CREATE PROCEDURE genTareasProgMensualesDatos
(
@pTareaProgramada_Id int
)
AS
SET NOCOUNT ON 

SELECT cast(1 as bit) EsPorDiaSemana
WHERE (Exists (select 1 
			  from genTareasProgMensualesXDiaSemana 
			  where (genTareasProgMensualesXDiaSemana.TareaProgramada_Id = @pTareaProgramada_Id)))
UNION
SELECT cast(0 as bit) EsPorDiaSemana
WHERE (Not Exists (select 1 
			  from genTareasProgMensualesXDiaSemana 
			  where (genTareasProgMensualesXDiaSemana.TareaProgramada_Id = @pTareaProgramada_Id)))


SELECT genTareasProgMensuales.Enero, genTareasProgMensuales.Febrero,
	genTareasProgMensuales.Marzo, genTareasProgMensuales.Abril, genTareasProgMensuales.Mayo, genTareasProgMensuales.Junio,
	genTareasProgMensuales.Julio, genTareasProgMensuales.Agosto, genTareasProgMensuales.Septiembre, genTareasProgMensuales.Octubre,
	genTareasProgMensuales.Noviembre, genTareasProgMensuales.Diciembre
FROM genTareasProgMensuales 
WHERE (genTareasProgMensuales.TareaProgramada_Id = @pTareaProgramada_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genTareasProgMensualesEliminar
GO
CREATE PROCEDURE genTareasProgMensualesEliminar
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgMensuales 
WHERE (TareaProgramada_Id = dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id))
 
 RETURN @@Error 

GO

GO
