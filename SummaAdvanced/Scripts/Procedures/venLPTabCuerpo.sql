DROP PROCEDURE venLPTabCuerpoGuardar
GO
CREATE PROCEDURE venLPTabCuerpoGuardar
(
@pTabla_Id int,
@pHasta numeric(18,2),
@pValor numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venLPTabCuerpo WHERE (Tabla_Id = @pTabla_Id) AND (Hasta = @pHasta)))
BEGIN 
	UPDATE venLPTabCuerpo
	SET		Valor = @pValor
	WHERE (Tabla_Id = @pTabla_Id) AND (Hasta = ISNULL(@pHasta, Hasta))
END 
ELSE 
BEGIN 
	INSERT INTO venLPTabCuerpo
	(
		Tabla_Id,
		Hasta,
		Valor
	)
	VALUES 
	(
		@pTabla_Id,
		@pHasta,
		@pValor
	)
END 

GO

DROP PROCEDURE venLPTabCuerpoDatos
GO
CREATE PROCEDURE venLPTabCuerpoDatos
(
@pTabla_Id int,
@pHasta numeric(18,2) = NULL
)
AS
SET NOCOUNT ON 

SELECT venLPTabCuerpo.Tabla_Id, venLPTabCuerpo.Hasta, venLPTabCuerpo.Valor
FROM venLPTabCuerpo 
WHERE (Tabla_Id = @pTabla_Id)
AND (Hasta = ISNULL(@pHasta,Hasta))
 
RETURN @@Error 

GO

DROP PROCEDURE venLPTabCuerpoEliminar
GO
CREATE PROCEDURE venLPTabCuerpoEliminar
(
@pTabla_Id int,
@pHasta Numeric(18,2) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venLPTabCuerpo 
WHERE (Tabla_Id = @pTabla_Id) AND (Hasta = ISNULL(@pHasta, Hasta))
 
 RETURN @@Error 

GO



DROP PROCEDURE venLPTabCuerpoValor
GO

CREATE PROCEDURE venLPTabCuerpoValor
(
@pTabla_Id int,
@pHasta numeric(18,2) = NULL
)
AS
SET NOCOUNT ON 

SELECT venLPTabCuerpo.Tabla_Id, venLPTabCuerpo.Hasta, venLPTabCuerpo.Valor
FROM venLPTabCuerpo 
WHERE Tabla_Id = @pTabla_Id AND 
Hasta = (select min(Hasta) from  venLPTabCuerpo p1 where
	p1.Tabla_Id = @pTabla_Id and Hasta >= @pHasta)
 
RETURN @@Error 

GO
