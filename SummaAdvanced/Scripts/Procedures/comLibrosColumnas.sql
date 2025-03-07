DROP PROCEDURE comLibrosColumnasGuardar
GO
CREATE PROCEDURE comLibrosColumnasGuardar
(
@pcomLibros int,
@pColumna int,
@pTitulo varchar(20)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comLibrosColumnas WHERE (comLibros = @pcomLibros) AND (Columna = @pColumna)))
BEGIN 
	UPDATE comLibrosColumnas
	SET		Titulo = @pTitulo
	WHERE (comLibros = @pcomLibros) AND (Columna = @pColumna)
END 
ELSE 
BEGIN 
	INSERT INTO comLibrosColumnas
	(
		comLibros,
		Columna,
		Titulo
	)
	VALUES 
	(
		@pcomLibros,
		@pColumna,
		@pTitulo
	)
END 

GO

DROP PROCEDURE comLibrosColumnasDatos
GO
CREATE PROCEDURE comLibrosColumnasDatos
(
@pcomLibros int,
@pColumna int=NULL
)
AS
SET NOCOUNT ON 

SELECT comLibrosColumnas.comLibros, comLIbros.Libro_Id, comLIbros.Descripcion as DescripcionLIbros, comLibrosColumnas.Columna,
	comLibrosColumnas.Titulo
FROM comLibrosColumnas 
INNER JOIN comLIbros  ON (comLIbros.comLibros = comLibrosColumnas.comLibros)
WHERE (comLibrosColumnas.comLibros = @pcomLibros)
AND (Columna = ISNULL(@pColumna,Columna))
 
 RETURN @@Error 

GO

DROP PROCEDURE comLibrosColumnasEliminar
GO
CREATE PROCEDURE comLibrosColumnasEliminar
(@pcomLibros int,
@pColumna int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comLibrosColumnas 
WHERE (comLibros = @pcomLibros)
AND (Columna = ISNULL(@pColumna, Columna))
 
 RETURN @@Error 

GO

GO
