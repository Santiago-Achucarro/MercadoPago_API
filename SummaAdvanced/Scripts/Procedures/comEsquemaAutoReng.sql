DROP PROCEDURE comEsquemaAutoRengGuardar
GO
CREATE PROCEDURE comEsquemaAutoRengGuardar
(
@pEsquemaAuto_Id varChar(10),
@pOrden int,
@pNivelAuto_Id varchar(5),
@pFormula varchar(max)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comEsquemaAutoReng WHERE EsquemaAuto_Id = dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id) AND Orden = @pOrden))
BEGIN 
	UPDATE comEsquemaAutoReng
	SET NivelAuto_Id = dbo.FuncFKcomNivelesAuto(@pNivelAuto_Id), Formula = @pFormula
	WHERE EsquemaAuto_Id = dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id) AND (Orden = @pOrden)
END 
ELSE 
BEGIN 
	INSERT INTO comEsquemaAutoReng
	(
		EsquemaAuto_Id,
		Orden,
		NivelAuto_Id,
		Formula
	)
	VALUES 
	(
		dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id),
		@pOrden,
		dbo.FuncFKcomNivelesAuto(@pNivelAuto_Id),
		@pFormula
	)
END 

GO

DROP PROCEDURE comEsquemaAutoRengDatos
GO
CREATE PROCEDURE comEsquemaAutoRengDatos
(
@pEsquemaAuto_Id varChar(10),
@pOrden int = Null
)
AS
SET NOCOUNT ON 

SELECT comEsquemaAuto.EsquemaAuto_Id, comEsquemaAuto.Descripcion as DescripcioncomEsquemaAuto, comEsquemaAutoReng.Orden, comNivelesAuto.NivelAuto_Id,
	comNivelesAuto.Descripcion as DescripcioncomNivelesAuto, comEsquemaAutoReng.Formula
FROM comEsquemaAutoReng 
INNER JOIN comEsquemaAuto ON (comEsquemaAuto.comEsquemaAuto = comEsquemaAutoReng.EsquemaAuto_Id)
LEFT JOIN comNivelesAuto ON (comNivelesAuto.ComNivelesAuto = comEsquemaAutoReng.NivelAuto_Id)
WHERE comEsquemaAuto.EsquemaAuto_Id = @pEsquemaAuto_Id
AND Orden = IsNull(@pOrden, Orden)
Order By comEsquemaAutoReng.Orden
 
RETURN @@Error 

GO

DROP PROCEDURE comEsquemaAutoRengEliminar
GO
CREATE PROCEDURE comEsquemaAutoRengEliminar
(
@pEsquemaAuto_Id varchar(10),
@pOrden int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comEsquemaAutoReng 
WHERE (EsquemaAuto_Id = dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id))
AND (Orden = ISNULL(@pOrden, Orden))
 
RETURN @@Error 

GO
