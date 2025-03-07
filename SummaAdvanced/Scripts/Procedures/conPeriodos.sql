DROP PROCEDURE conPeriodosGuardar
GO
CREATE PROCEDURE conPeriodosGuardar
(
@pEmpresa_Id int,
@pEjercicio smallint,
@pPeriodo smallint,
@pFecha_Desde datetime,
@pFecha_Hasta datetime,
@pEstado char(1)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conPeriodos WHERE (Ejercicio = @pEjercicio) AND (Periodo = @pPeriodo) AND (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE conPeriodos
	SET		Fecha_Desde = @pFecha_Desde,
		Fecha_Hasta = @pFecha_Hasta,
		Estado = @pEstado
	WHERE (Ejercicio = @pEjercicio) AND (Periodo = @pPeriodo) and 
		Empresa_Id = @pEmpresa_Id
END 
ELSE 
BEGIN 
	INSERT INTO conPeriodos
	(
		Empresa_Id,
		Ejercicio,
		Periodo,
		Fecha_Desde,
		Fecha_Hasta,
		Estado
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pEjercicio,
		@pPeriodo,
		@pFecha_Desde,
		@pFecha_Hasta,
		@pEstado
	)
END 

GO

DROP PROCEDURE conPeriodosDatos
GO
CREATE PROCEDURE conPeriodosDatos
(
@pEmpresa_Id int,
@pEjercicio smallint,
@pPeriodo smallint
)
AS
SET NOCOUNT ON 

SELECT conPeriodos.Ejercicio, conPeriodos.Periodo, conPeriodos.Fecha_Desde as Fecha, conPeriodos.Fecha_Desde,
	conPeriodos.Fecha_Hasta, conPeriodos.Estado
FROM conPeriodos 
WHERE conPeriodos.Ejercicio = @pEjercicio
AND conPeriodos.Periodo = @pPeriodo and 
Empresa_Id = @pEmpresa_Id
 
 RETURN @@Error 

GO

DROP PROCEDURE conPeriodosEliminar
GO
CREATE PROCEDURE conPeriodosEliminar
(
@pEmpresa_Id Int,
@pEjercicio smallint,
@pPeriodo smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conPeriodos 
WHERE 
Empresa_Id = @pEmpresa_id and 
(Ejercicio = @pEjercicio)
AND (Periodo = ISNULL(@pPeriodo, Periodo))
 
 RETURN @@Error 

GO
DROP PROCEDURE conPeriodosDatosFecha
GO
CREATE PROCEDURE conPeriodosDatosFecha
(
@pEmpresa_Id Int,
@pFecha DateTime
)
AS
SET NOCOUNT ON 

SELECT conPeriodos.Ejercicio, conPeriodos.Periodo, @pFecha as Fecha,  conPeriodos.Fecha_Desde,
	conPeriodos.Fecha_Hasta, conPeriodos.Estado
FROM conPeriodos 
WHERE @pFecha Between Fecha_Desde And Fecha_Hasta and 
	Empresa_Id = @pEmpresa_Id
 
RETURN @@Error 

GO


DROP PROCEDURE conPeriodosCambiarEstado
GO
CREATE PROCEDURE conPeriodosCambiarEstado
(
@pEmpresa_Id int,
@pEjercicio smallint,
@pPeriodo smallint,
@pEstado char(1)
)
AS
	UPDATE conPeriodos
	SET	Estado = @pEstado
	WHERE (Ejercicio = @pEjercicio) AND (Periodo = @pPeriodo) and 
		Empresa_Id = @pEmpresa_Id
GO
