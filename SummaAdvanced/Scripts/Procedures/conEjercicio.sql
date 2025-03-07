DROP PROCEDURE conEjercicioGuardar
GO
CREATE PROCEDURE conEjercicioGuardar
(
@pEjercicio smallint,
@pFecha qFecha,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conEjercicio WHERE (Ejercicio = @pEjercicio)))
BEGIN 
	UPDATE conEjercicio
	SET		Fecha = @pFecha,
		Usuario_Id = @pUsuario_Id
	WHERE (Ejercicio = @pEjercicio)
END 
ELSE 
BEGIN 
	INSERT INTO conEjercicio
	(
		Ejercicio,
		Fecha,
		Usuario_Id
	)
	VALUES 
	(
		@pEjercicio,
		@pFecha,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE conEjercicioDatos
GO
CREATE PROCEDURE conEjercicioDatos
(
@pEjercicio smallint
)
AS
SET NOCOUNT ON 

SELECT conEjercicio.Ejercicio, conEjercicio.Fecha, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM conEjercicio 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conEjercicio.Usuario_Id)
WHERE (Ejercicio = @pEjercicio)
 
 RETURN @@Error 

GO

DROP PROCEDURE conEjercicioEliminar
GO
CREATE PROCEDURE conEjercicioEliminar
(
@pEjercicio smallint
)
AS
SET NOCOUNT ON 

DELETE FROM conEjercicio 
WHERE Ejercicio = @pEjercicio 
 
 RETURN @@Error 

GO
DROP PROCEDURE conEjercicioPeriodoDatos
GO
CREATE PROCEDURE conEjercicioPeriodoDatos
(
@pEjercicio smallint, 
@pEmpresa Int
)
AS
SET NOCOUNT ON 

SELECT conEjercicio.Ejercicio, conEjercicio.Fecha, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
Cast(isNull((Select nValor From genGlobales Where Nombre_Var = 'CONMESINICIOEJE' And Empresa_Id = @pEmpresa), 1) As int) MesInicioEjercicio,
Cast(isNull((Select nValor From genGlobales Where Nombre_Var = 'CONPERIODOS' And Empresa_Id = @pEmpresa), 12) As int) CantPeriodos,
(Select Count(1) From conPeriodos Where Empresa_Id = @pEmpresa) Ejercicios
FROM conEjercicio 
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = conEjercicio.Usuario_Id)
WHERE (Ejercicio = @pEjercicio)


SELECT conPeriodos.Ejercicio, conPeriodos.Periodo, conPeriodos.Fecha_Desde, conPeriodos.Fecha_Hasta, conPeriodos.Estado
From conPeriodos 
Where
		conPeriodos.Empresa_Id = @pEmpresa and
		conPeriodos.Ejercicio = @pEjercicio
 
RETURN @@Error 

GO



DROP PROCEDURE conEjercicioPeriodos
GO
CREATE PROCEDURE conEjercicioPeriodos
(
@pEmpresa Int
)
AS
SET NOCOUNT ON 

SELECT Cast(0 As smallint) Ejercicio, getDate() Fecha, '' Usuario_Id, '' DescripcionUsuario,
Cast(isNull((Select nValor From genGlobales Where Nombre_Var = 'CONMESINICIOEJE' And Empresa_Id = @pEmpresa), 1) As int) MesInicioEjercicio,
Cast(isNull((Select nValor From genGlobales Where Nombre_Var = 'CONPERIODOS' And Empresa_Id = @pEmpresa), 12) As int) CantPeriodos,
(Select Count(1) From conPeriodos Where Empresa_Id = @pEmpresa) Ejercicios



SELECT conPeriodos.Ejercicio, conPeriodos.Periodo, conPeriodos.Fecha_Desde, conPeriodos.Fecha_Hasta, conPeriodos.Estado
From conPeriodos 
Where conPeriodos.Empresa_Id = @pEmpresa
 
RETURN @@Error 

GO
