DROP PROCEDURE stkMoviCausaGuardar
GO
CREATE PROCEDURE stkMoviCausaGuardar
(
@pstkMoviCabe bigint,
@pCausa_Id varchar(5),
@pCentro1_Id varChar(8),
@pCentro2_Id varChar(8)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviCausa WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkMoviCausa
	SET		Causa_Id = dbo.FuncFKstkCausasMovi(@pCausa_Id), Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
			Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id)
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviCausa
	(
		stkMoviCabe,
		Causa_Id,
		Centro1_Id,
		Centro2_Id
	)
	VALUES 
	(
		@pstkMoviCabe,
		dbo.FuncFKstkCausasMovi(@pCausa_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id)
	)
END 

GO

DROP PROCEDURE stkMoviCausaDatos
GO
CREATE PROCEDURE stkMoviCausaDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviCausa.stkMoviCabe, stkCausasMovi.Causa_Id, stkCausasMovi.Descripcion as DescripcionCausasMovi,
conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
FROM stkMoviCausa 
INNER JOIN stkCausasMovi  ON (stkCausasMovi.stkCausasMovi = stkMoviCausa.Causa_Id)
Inner Join conCentro1 On stkMoviCausa.Centro1_Id = conCentro1.conCentro1
Inner Join conCentro2 On stkMoviCausa.Centro2_Id = conCentro2.conCentro2
WHERE (stkMoviCausa.stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviCausaEliminar
GO
CREATE PROCEDURE stkMoviCausaEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCausa 
WHERE (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO

GO
