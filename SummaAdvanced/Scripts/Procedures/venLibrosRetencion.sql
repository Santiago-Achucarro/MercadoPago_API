DROP PROCEDURE venLibrosRetencionGuardar
GO
CREATE PROCEDURE venLibrosRetencionGuardar
(
@pvenLibros int,
@pColumna int,
@pCartera_Id varchar(5)
)
AS
SET NOCOUNT ON 

	INSERT INTO venLibrosRetencion
	(
		venLibros,
		Columna,
		Cartera_Id
	)
	VALUES 
	(
		@pvenLibros,
		@pColumna,
		dbo.FuncFKtesIdentifica(@pCartera_Id)
	)


GO

DROP PROCEDURE venLibrosRetencionDatos
GO
CREATE PROCEDURE venLibrosRetencionDatos
(
@pvenLibros int,
@pColumna int=null,
@pCartera_Id varchar(5)=null
)
AS
SET NOCOUNT ON 

SELECT venLibrosRetencion.venLibros,  venLibrosRetencion.Columna,  tesIdentifica.Cartera_Id,
	tesIdentifica.Descripcion as DescripcionIdentifica
FROM venLibrosRetencion 
INNER JOIN venLibrosColumnas  ON (venLibrosColumnas.venLibros = venLibrosRetencion.venLibros)  AND (venLibrosColumnas.Columna = venLibrosRetencion.Columna)
INNER JOIN tesIdentifica  ON (tesIdentifica.tesIdentifica = venLibrosRetencion.Cartera_Id)
WHERE (venLibrosRetencion.venLibros = @pvenLibros)
AND (venLibrosRetencion.Columna = isnull(@pColumna,venLibrosRetencion.Columna))
AND (tesIdentifica.Cartera_Id =isnull( @pCartera_Id,tesIdentifica.Cartera_Id))
 
 RETURN @@Error 

GO

DROP PROCEDURE venLibrosRetencionEliminar
GO
CREATE PROCEDURE venLibrosRetencionEliminar
(
@pvenLibros int,
@pColumna int=null,
@pCartera_Id varchar(5)=null
)
AS
SET NOCOUNT ON 

DELETE FROM venLibrosRetencion 
WHERE (venLibros = @pvenLibros)
AND (Columna = isnull(@pColumna,Columna))
AND (Cartera_Id =isnull( dbo.FuncFKtesIdentifica(@pCartera_Id),Cartera_Id))
 
 RETURN @@Error 

GO

GO
