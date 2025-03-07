DROP PROCEDURE stkMoviCabeCentroGuardar
GO
CREATE PROCEDURE stkMoviCabeCentroGuardar
(
@pstkMoviCabe bigint,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkMoviCabeCentro WHERE (stkMoviCabe = @pstkMoviCabe)))
BEGIN 
	UPDATE stkMoviCabeCentro
	SET		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id)
	WHERE (stkMoviCabe = @pstkMoviCabe)
END 
ELSE 
BEGIN 
	INSERT INTO stkMoviCabeCentro
	(
		stkMoviCabe,
		Centro1_Id,
		Centro2_Id
	)
	VALUES 
	(
		@pstkMoviCabe,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id)
	)
END 

GO

DROP PROCEDURE stkMoviCabeCentroDatos
GO
CREATE PROCEDURE stkMoviCabeCentroDatos
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

SELECT stkMoviCabeCentro.stkMoviCabe, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2
FROM stkMoviCabeCentro 
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = stkMoviCabeCentro.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = stkMoviCabeCentro.Centro2_Id)
WHERE (stkMoviCabe = @pstkMoviCabe)
 
 RETURN @@Error 

GO

DROP PROCEDURE stkMoviCabeCentroEliminar
GO
CREATE PROCEDURE stkMoviCabeCentroEliminar
(
@pstkMoviCabe bigint
)
AS
SET NOCOUNT ON 

DELETE FROM stkMoviCabeCentro WHERE (stkMoviCabe = @pstkMoviCabe)
 
RETURN @@Error 

GO
