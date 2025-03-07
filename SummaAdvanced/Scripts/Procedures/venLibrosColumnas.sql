DROP PROCEDURE venLibrosColumnasDatos
GO
CREATE PROCEDURE venLibrosColumnasDatos
(
@pvenLibros int,
@pColumna int=null
)
AS
SET NOCOUNT ON 

SELECT venLibros.venLibros, venLibros.Libro_Id, venLibros.Descripcion as DescripcionLibros, venLibrosColumnas.Columna, venLibrosColumnas.Titulo
FROM venLibrosColumnas 
INNER JOIN venLibros  ON (venLibros.venLibros = venLibrosColumnas.venLibros) 
WHERE (venLibros.venLibros = @pvenLibros)
AND (Columna = isnull(@pColumna,Columna))
 
 RETURN @@Error 

 GO


DROP PROCEDURE venLibrosColumnasGuardar
GO

CREATE PROCEDURE venLibrosColumnasGuardar
(
@pvenLibros int,
@pColumna int,
@pTitulo varchar(20)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venLibrosColumnas WHERE (venLibros = @pvenLibros) AND (Columna = @pColumna)))
BEGIN 
	UPDATE venLibrosColumnas
	SET		Titulo = @pTitulo
	WHERE (venLibros = @pvenLibros) AND (Columna = @pColumna)
END 
ELSE 
BEGIN 
	INSERT INTO venLibrosColumnas
	(
		venLibros,
		Columna,
		Titulo
	)
	VALUES 
	(
		@pvenLibros,
		@pColumna,
		@pTitulo
	)
END 
 
 
 RETURN @@Error 

GO

DROP PROCEDURE venLibrosColumnasEliminar
GO
CREATE PROCEDURE venLibrosColumnasEliminar
(
@pvenLibros int,
@pColumna int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venLibrosColumnas 
WHERE (venLibros = @pvenLibros)
AND (Columna = ISNULL(@pColumna, Columna))
 
 RETURN @@Error 

GO

GO
