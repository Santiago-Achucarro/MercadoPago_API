DROP PROCEDURE venLPTablaGuardar
GO
CREATE PROCEDURE venLPTablaGuardar
(
@pTabla_Id int,
@pDescripcion varchar(120)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venLPTabla WHERE (Tabla_Id = @pTabla_Id)))
BEGIN 
	UPDATE venLPTabla
	SET		Descripcion = @pDescripcion
	WHERE (Tabla_Id = @pTabla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venLPTabla
	(
		Tabla_Id,
		Descripcion
	)
	VALUES 
	(
		@pTabla_Id,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE venLPTablaDatos
GO
CREATE PROCEDURE venLPTablaDatos
(
@pTabla_Id int
)
AS
SET NOCOUNT ON 

SELECT venLPTabla.Tabla_Id, venLPTabla.Descripcion
FROM venLPTabla 
WHERE (Tabla_Id = @pTabla_Id)

Exec venLPTabCuerpoDatos @pTabla_Id, null
 
RETURN @@Error 

GO

DROP PROCEDURE venLPTablaEliminar
GO
CREATE PROCEDURE venLPTablaEliminar
(
@pTabla_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venLPTabla 
WHERE (Tabla_Id = ISNULL(@pTabla_Id, Tabla_Id))
 
 RETURN @@Error 

GO

