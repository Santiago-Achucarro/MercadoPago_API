DROP PROCEDURE comLibrosImpuestosGuardar
GO
CREATE PROCEDURE comLibrosImpuestosGuardar
(
@pcomLibros int,
@pColumna int,
@pImpuesto_Id varchar(5),
@pTipoRenglon varchar(2)
)
as
	INSERT INTO comLibrosImpuestos
	(
		comLibros,
		Columna,
		Impuesto_Id,
		TipoRenglon
	)
	VALUES 
	(
		@pcomLibros,
		@pColumna,
		dbo.FuncFKcomImpuestos(@pImpuesto_Id),
		@pTipoRenglon
	)


GO

DROP PROCEDURE comLibrosImpuestosDatos
GO
CREATE PROCEDURE comLibrosImpuestosDatos
(
@pcomLibros int,
@pColumna int=NULL,
@pImpuesto_Id varchar(5)=NULL,
@pTipoRenglon varchar(2)=NULL
)
AS
SET NOCOUNT ON 

SELECT comLibrosImpuestos.comLibros, comLibrosImpuestos.Columna,  comImpuestos.Impuesto_Id,
	comImpuestos.Descripcion as DescripcionImpuestos, comLibrosImpuestos.TipoRenglon, impLibrosTiposRenglon.Descripcion as DescripcionTipoImpuesto
FROM comLibrosImpuestos 
INNER JOIN comLibrosColumnas  ON (comLibrosColumnas.comLibros = comLibrosImpuestos.comLibros) AND (comLibrosColumnas.Columna = comLibrosImpuestos.Columna)
INNER JOIN comImpuestos  ON (comImpuestos.comImpuestos = comLibrosImpuestos.Impuesto_Id)
INNER JOIN impLibrosTiposRenglon  ON (impLibrosTiposRenglon.TipoRenglon = comLibrosImpuestos.TipoRenglon)
WHERE (comlibrosImpuestos.comLibros = @pcomLibros)
AND (comlibrosImpuestos.Columna = ISNULL(@pColumna,comlibrosImpuestos.Columna))
AND (comlibrosImpuestos.Impuesto_Id =ISNULL( @pImpuesto_Id,comlibrosImpuestos.Impuesto_Id))
AND (comlibrosImpuestos.TipoRenglon = ISNULL(@pTipoRenglon,comlibrosImpuestos.TipoRenglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE comLibrosImpuestosEliminar
GO
CREATE PROCEDURE comLibrosImpuestosEliminar
(
@pcomLibros int,
@pColumna int=null,
@pImpuesto_Id varchar(5)=null,
@pTipoRenglon varchar(2)=null
)
AS
SET NOCOUNT ON 

DELETE FROM comLibrosImpuestos 
WHERE (comLibros = @pcomLibros)
AND (Columna = ISNULL(@pColumna, Columna))
AND (Impuesto_Id =ISNULL( dbo.FuncFKcomImpuestos(@pImpuesto_Id),Impuesto_Id))
AND (TipoRenglon = ISNULL(@pTipoRenglon,TipoRenglon))
 
 RETURN @@Error 

GO

GO
