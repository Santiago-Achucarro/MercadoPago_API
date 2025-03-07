DROP PROCEDURE sueArchivosTxtCuerpoGuardar
GO
CREATE PROCEDURE sueArchivosTxtCuerpoGuardar
(
@pArchivo_Id varchar(15),
@pColumna int,
@pFormula QMemo,
@pTipo char(1),
@pLongitud smallint,
@pDecimales smallint,
@pRelleno char(2),
@pDescripcion varchar(60),
@pOrden smallint,
@pFormato varchar(25) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueArchivosTxtCuerpo WHERE (sueArchivosTxt =dbo.FuncFKsueArchivosTxt(@pArchivo_Id)) AND (Columna = @pColumna)))
BEGIN 
	UPDATE sueArchivosTxtCuerpo
	SET		Formula = @pFormula,
		Tipo = @pTipo,
		Longitud = @pLongitud,
		Decimales = @pDecimales,
		Relleno = @pRelleno,
		Descripcion = @pDescripcion,
		Orden = @pOrden,
		Formato = @pFormato
	WHERE (sueArchivosTxt = dbo.FuncFKsueArchivosTxt(@pArchivo_Id)) AND (Columna = @pColumna)
END 
ELSE 
BEGIN 
	INSERT INTO sueArchivosTxtCuerpo
	(
		sueArchivosTxt,
		Columna,
		Formula,
		Tipo,
		Longitud,
		Decimales,
		Relleno,
		Descripcion,
		Orden,
		Formato
	)
	VALUES 
	(
		dbo.FuncFKsueArchivosTxt(@pArchivo_Id),
		@pColumna,
		@pFormula,
		@pTipo,
		@pLongitud,
		@pDecimales,
		@pRelleno,
		@pDescripcion,
		@pOrden,
		@pFormato
	)
END 

GO

DROP PROCEDURE sueArchivosTxtCuerpoDatos
GO
CREATE PROCEDURE sueArchivosTxtCuerpoDatos
(
@pArchivo_Id varchar(15),
@pColumna int = null
)
AS
SET NOCOUNT ON 

SELECT sueArchivosTxt.Descripcion as DescripcionCabecera, sueArchivosTxtCuerpo.Columna, sueArchivosTxtCuerpo.Formula, sueArchivosTxtCuerpo.Tipo,
	sueArchivosTxtCuerpo.Longitud, sueArchivosTxtCuerpo.Decimales, sueArchivosTxtCuerpo.Relleno, sueArchivosTxtCuerpo.Descripcion,
	sueArchivosTxtCuerpo.Orden, sueArchivosTxtCuerpo.Formato
FROM sueArchivosTxtCuerpo 
INNER JOIN sueArchivosTxt  ON (sueArchivosTxt.sueArchivosTxt = sueArchivosTxtCuerpo.sueArchivosTxt)
WHERE (sueArchivosTxt.Archivo_Id = @pArchivo_Id)
AND (Columna = ISNULL(@pColumna, Columna))
 
 RETURN @@Error 

GO

DROP PROCEDURE sueArchivosTxtCuerpoEliminar
GO
CREATE PROCEDURE sueArchivosTxtCuerpoEliminar
(
@pArchivo_Id varchar(15),
@pColumna int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueArchivosTxtCuerpo 
WHERE (sueArchivosTxt = dbo.FuncFKsueArchivosTxt(@pArchivo_Id))
AND (Columna = ISNULL(@pColumna, Columna))
 
 RETURN @@Error 

GO

GO
