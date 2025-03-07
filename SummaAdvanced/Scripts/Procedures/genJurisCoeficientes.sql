DROP PROCEDURE genJurisCoeficientesGuardar
GO
CREATE PROCEDURE genJurisCoeficientesGuardar
(
@pgenEntidades bigint,
@pJuris_Id varChar(3),
@pSituacion char(1),
@pCoeficiente qMonedaD4,
@pExencion qPorcentaje,
@pFechaHasta qFecha = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genJurisCoeficientes WHERE (genEntidades = @pgenEntidades) AND Juris_Id = dbo.FuncFKimpJurisdicciones(@pJuris_Id)))
BEGIN 
	UPDATE genJurisCoeficientes
	SET Situacion = @pSituacion,
		Coeficiente = @pCoeficiente,
		Exencion = @pExencion,
		FechaHasta = @pFechaHasta
	WHERE (genEntidades = @pgenEntidades) AND (Juris_Id = dbo.FuncFKimpJurisdicciones(@pJuris_Id))
END 
ELSE 
BEGIN 
	INSERT INTO genJurisCoeficientes
	(
		genEntidades,
		Juris_Id,
		Situacion,
		Coeficiente,
		Exencion,
		FechaHasta
	)
	VALUES 
	(
		@pgenEntidades,
		dbo.FuncFKimpJurisdicciones(@pJuris_Id),
		@pSituacion,
		@pCoeficiente,
		@pExencion,
		@pFechaHasta
	)
END 

GO

DROP PROCEDURE genJurisCoeficientesDatos
GO
CREATE PROCEDURE genJurisCoeficientesDatos
(
@pgenEntidades bigint,
@pJuris_Id varChar(3) = Null
)
AS
SET NOCOUNT ON 

SELECT genEntidades.genEntidades, 
	impJurisdicciones.Juris_Id, impJurisdicciones.Descripcion as DescripcionJurisdicciones, genJurisCoeficientes.Situacion,
	genJurisCoeficientes.Coeficiente, genJurisCoeficientes.Exencion, genJurisCoeficientes.FechaHasta
FROM genJurisCoeficientes 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = genJurisCoeficientes.genEntidades)
INNER JOIN impJurisdicciones  ON (impJurisdicciones.impJurisdicciones = genJurisCoeficientes.Juris_Id)
WHERE (genJurisCoeficientes.genEntidades = @pgenEntidades)
AND genJurisCoeficientes.Juris_Id = IsNull(dbo.FuncFKimpJurisdicciones(@pJuris_Id), genJurisCoeficientes.Juris_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE genJurisCoeficientesEliminar
GO
CREATE PROCEDURE genJurisCoeficientesEliminar
(
@pgenEntidades bigint,
@pJuris_Id varchar(3) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM genJurisCoeficientes 
WHERE genEntidades = @pgenEntidades 
AND Juris_Id = IsNull(dbo.FuncFKimpJurisdicciones(@pJuris_Id), Juris_Id)
 
 RETURN @@Error 

GO
