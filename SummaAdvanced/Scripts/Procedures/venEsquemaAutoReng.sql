DROP PROCEDURE venEsquemaAutoRengGuardar
GO
CREATE PROCEDURE venEsquemaAutoRengGuardar
(
@pEsquemaAuto_Id varChar(10),
@pOrden int,
@pNivelAuto_Id varchar(5),
@pFormula varchar(max)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venEsquemaAutoReng WHERE EsquemaAuto_Id = dbo.FuncFKvenEsquemaAuto(@pEsquemaAuto_Id) AND Orden = @pOrden))
BEGIN 
	UPDATE venEsquemaAutoReng
	SET NivelAuto_Id = dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id), Formula = @pFormula
	WHERE EsquemaAuto_Id = dbo.FuncFKvenEsquemaAuto(@pEsquemaAuto_Id) AND (Orden = @pOrden)
END 
ELSE 
BEGIN 
	INSERT INTO venEsquemaAutoReng
	(
		EsquemaAuto_Id,
		Orden,
		NivelAuto_Id,
		Formula
	)
	VALUES 
	(
		dbo.FuncFKvenEsquemaAuto(@pEsquemaAuto_Id),
		@pOrden,
		dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id),
		@pFormula
	)
END 

GO

DROP PROCEDURE venEsquemaAutoRengDatos
GO
CREATE PROCEDURE venEsquemaAutoRengDatos
(
@pEsquemaAuto_Id varChar(5),
@pOrden int = Null
)
AS
SET NOCOUNT ON 

SELECT venEsquemaAuto.EsquemaAuto_Id, venEsquemaAuto.Descripcion as DescripcioncomEsquemaAuto, venEsquemaAutoReng.Orden, venNivelesAuto.NivelAuto_Id,
	venNivelesAuto.Descripcion as DescripcioncomNivelesAuto, venEsquemaAutoReng.Formula
FROM venEsquemaAutoReng 
INNER JOIN venEsquemaAuto ON (venEsquemaAuto.venEsquemaAuto = venEsquemaAutoReng.EsquemaAuto_Id)
LEFT JOIN venNivelesAuto ON (venNivelesAuto.venNivelesAuto = venEsquemaAutoReng.NivelAuto_Id)
WHERE venEsquemaAuto.EsquemaAuto_Id = @pEsquemaAuto_Id
AND Orden = IsNull(@pOrden, Orden)
Order By venEsquemaAutoReng.Orden
 
RETURN @@Error 

GO

DROP PROCEDURE venEsquemaAutoRengEliminar
GO
CREATE PROCEDURE venEsquemaAutoRengEliminar
(
@pEsquemaAuto_Id varchar(10),
@pOrden int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venEsquemaAutoReng 
WHERE (EsquemaAuto_Id = dbo.FuncFKvenEsquemaAuto(@pEsquemaAuto_Id))
AND (Orden = ISNULL(@pOrden, Orden))
 
RETURN @@Error 

GO
