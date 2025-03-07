DROP PROCEDURE proSubRecursosGuardar
GO
CREATE PROCEDURE proSubRecursosGuardar
(
@pSubRecurso_Id varchar(25),
@pSubRecurso_Id_Nuevo varchar(25),
@pRecurso_Id varchar(25),
@pDescripcion varchar(60),
@pCapacidad qCantidadD8,
@pCosto qMonedaD4,
@pPredeterminado Sino,
@pInactivo Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proSubRecursos WHERE (SubRecurso_Id = @pSubRecurso_Id)))
BEGIN 
	UPDATE proSubRecursos
	SET		@lIdentidad = proSubRecursos,
		SubRecurso_Id = @pSubRecurso_Id_Nuevo,
		Recurso_Id = dbo.FuncFKproRecursos(@pRecurso_Id),
		Descripcion = @pDescripcion,
		Capacidad = @pCapacidad,
		Costo = @pCosto,
		Predeterminado = @pPredeterminado,
		Inactivo = @pInactivo
	WHERE (SubRecurso_Id = @pSubRecurso_Id)
END 
ELSE 
BEGIN 
	INSERT INTO proSubRecursos
	(
		SubRecurso_Id,
		Recurso_Id,
		Descripcion,
		Capacidad,
		Costo,
		Predeterminado,
		Inactivo
	)
	VALUES 
	(
		@pSubRecurso_Id,
		dbo.FuncFKproRecursos(@pRecurso_Id),
		@pDescripcion,
		@pCapacidad,
		@pCosto,
		@pPredeterminado,
		@pInactivo
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE proSubRecursosDatos
GO
CREATE PROCEDURE proSubRecursosDatos
(
@pRecurso_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT proSubRecursos.proSubRecursos, proSubRecursos.SubRecurso_Id, proSubRecursos.SubRecurso_Id SubRecurso_Id_Nueva, proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecursos,
	proSubRecursos.Descripcion, proSubRecursos.Capacidad, proSubRecursos.Costo, proSubRecursos.Predeterminado,
	proSubRecursos.Inactivo
FROM proSubRecursos 
INNER JOIN proRecursos  ON (proRecursos.proRecursos = proSubRecursos.Recurso_Id)
WHERE (proRecursos.Recurso_Id = @pRecurso_Id)
 
 RETURN @@Error 

GO


DROP PROCEDURE proSubRecursosUNODatos
GO
CREATE PROCEDURE proSubRecursosUNODatos
(
@pSubRecurso_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT proSubRecursos.proSubRecursos, proSubRecursos.SubRecurso_Id, proSubRecursos.SubRecurso_Id SubRecurso_Id_Nueva, proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecursos,
	proSubRecursos.Descripcion, proSubRecursos.Capacidad, proSubRecursos.Costo, proSubRecursos.Predeterminado,
	proSubRecursos.Inactivo
FROM proSubRecursos 
INNER JOIN proRecursos  ON (proRecursos.proRecursos = proSubRecursos.Recurso_Id)
WHERE 
proSubRecursos.SubRecurso_Id = @pSubRecurso_Id
 
 RETURN @@Error 

GO

DROP PROCEDURE proSubRecursosEliminar
GO
CREATE PROCEDURE proSubRecursosEliminar
(
@pRecurso_Id varchar(25),
@pSubRecurso_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proSubRecursos 
WHERE proSubRecursos.Recurso_Id=dbo.FuncFKproRecursos(@pRecurso_Id) and (SubRecurso_Id = isnull(@pSubRecurso_Id,SubRecurso_Id))
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKproSubRecursos
GO

CREATE FUNCTION FuncFKproSubRecursos
(

@pSubRecurso_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proSubRecursos FROM proSubRecursos WHERE 
	SubRecurso_Id = @pSubRecurso_Id
  RETURN @pIdentity
END


GO
