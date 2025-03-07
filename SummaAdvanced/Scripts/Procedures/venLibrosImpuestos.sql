DROP PROCEDURE venLibrosImpuestosGuardar
GO
CREATE PROCEDURE venLibrosImpuestosGuardar
(
@pvenLibros int,
@pColumna int,
@pTipoRenglon varchar(2),
@pImpuesto_Id varchar(5)
)
AS
SET NOCOUNT ON 


	INSERT INTO venLibrosImpuestos
	(
		venLibros,
		Columna,
		TipoRenglon,
		Impuesto_Id
	)
	VALUES 
	(
		@pvenLibros,
		@pColumna,
		@pTipoRenglon,
		dbo.FuncFKvenImpuestos(@pImpuesto_Id)
	)

		
GO

DROP PROCEDURE venLibrosImpuestosDatos
GO
CREATE PROCEDURE venLibrosImpuestosDatos
(
@pvenLibros int,
@pColumna int=null,
@pTipoRenglon varchar(2)=null,
@pImpuesto_Id varchar(5)=null
)
AS
SET NOCOUNT ON 

SELECT venLibrosImpuestos.venLibros, venLibrosImpuestos.Columna,venLibrosImpuestos.TipoRenglon, venImpuestos.Impuesto_Id,
	venImpuestos.Descripcion as DescripcionImpuestos, impLibrosTiposRenglon.Descripcion as DescripcionTipoRenglon
FROM venLibrosImpuestos 
INNER JOIN venLibrosColumnas  ON (venLibrosColumnas.venLibros = venLibrosImpuestos.venLibros)  AND (venLibrosColumnas.Columna = venLibrosImpuestos.Columna)
INNER JOIN venImpuestos  ON (venImpuestos.venImpuestos = venLibrosImpuestos.Impuesto_Id)
INNER JOIN impLibrosTiposRenglon ON (venLibrosImpuestos.TipoRenglon =impLibrosTiposRenglon.TipoRenglon)
WHERE (venLibrosImpuestos.venLibros = @pvenLibros)
AND (venLibrosImpuestos.TipoRenglon =isnull(@pTipoRenglon,venLibrosImpuestos.TipoRenglon))
AND (venLibrosImpuestos.Columna = isnull(@pColumna,venLibrosImpuestos.Columna))
AND (venImpuestos.Impuesto_Id = isnull(@pImpuesto_Id,venImpuestos.Impuesto_Id ))

 RETURN @@Error 

GO

DROP PROCEDURE venLibrosImpuestosEliminar
GO

CREATE PROCEDURE venLibrosImpuestosEliminar
(
@pvenLibros int,
@pColumna int=null,
@pTipoRenglon varchar(2)=null,
@pImpuesto_Id varchar(5)=null
)
AS
SET NOCOUNT ON 

DELETE FROM venLibrosImpuestos 
WHERE (venLibros = @pvenLibros)
AND (Columna = isnull(@pColumna,Columna))
AND (TipoRenglon =isnull(@pTipoRenglon,TipoRenglon))
AND (Impuesto_Id = isnull(dbo.FuncFKvenImpuestos(@pImpuesto_Id),Impuesto_Id))

 RETURN @@Error 

GO

GO
