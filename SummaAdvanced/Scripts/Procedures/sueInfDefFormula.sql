DROP PROCEDURE sueInfDefFormulasGuardar
GO
CREATE PROCEDURE sueInfDefFormulasGuardar
(
@psueInfDefinibles int,
@pColumna int,
@pAlias varchar(10),
@pTitulo varchar(50),
@pFormula varchar(max),
@pFormato varchar(20),
@pAncho numeric(6,2),
@pOrden int,
@pTipo varchar(1),
@pCheckCero sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueInfDefFormulas WHERE (sueInfDefinibles = @psueInfDefinibles) AND (Columna = @pColumna)))
BEGIN 
	UPDATE sueInfDefFormulas
	SET Alias = @pAlias,
		Titulo = @pTitulo,
		Formula = @pFormula,
		Formato = @pFormato,
		Ancho = @pAncho,
		Orden = @pOrden,
		Tipo = @pTipo,
		CheckCero = @pCheckCero
	WHERE (sueInfDefinibles = @psueInfDefinibles) AND (Columna = @pColumna)
END 
ELSE 
BEGIN 
	INSERT INTO sueInfDefFormulas
	(
		sueInfDefinibles,
		Columna,
		Alias,
		Titulo,
		Formula,
		Formato,
		Ancho,
		Orden,
		Tipo,
		CheckCero
	)
	VALUES 
	(
		@psueInfDefinibles,
		@pColumna,
		@pAlias,
		@pTitulo,
		@pFormula,
		@pFormato,
		@pAncho,
		@pOrden,
		@pTipo,
		@pCheckCero
	)
END 

GO

DROP PROCEDURE sueInfDefFormulasDatos
GO
CREATE PROCEDURE sueInfDefFormulasDatos
(
@psueInfDefinibles varchar(15),
@pColumna int=null
)
AS
SET NOCOUNT ON 

SELECT sueInfDefinibles.Informe_Id, sueInfDefinibles.Descripcion as DescripcionInfDefinibles, sueInfDefFormulas.Columna, sueInfDefFormulas.Alias,
	sueInfDefFormulas.Titulo, sueInfDefFormulas.Formula, sueInfDefFormulas.Formato, sueInfDefFormulas.Ancho,
	sueInfDefFormulas.Orden, sueInfDefFormulas.Tipo, sueInfDefFormulas.CheckCero
FROM sueInfDefFormulas 
INNER JOIN sueInfDefinibles  ON (sueInfDefinibles.sueInfDefinibles = sueInfDefFormulas.sueInfDefinibles)
WHERE sueInfDefinibles.Informe_Id = @psueInfDefinibles
AND Columna = ISNULL(@pColumna,Columna)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueInfDefFormulasEliminar
GO
CREATE PROCEDURE sueInfDefFormulasEliminar
(
@pInforme_Id varchar(15),
@pColumna int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueInfDefFormulas 
WHERE (sueInfDefinibles = dbo.FuncFKsueInfDefinibles(@pInforme_Id))
AND (Columna = ISNULL(@pColumna, Columna))
 
 RETURN @@Error 

GO

GO
