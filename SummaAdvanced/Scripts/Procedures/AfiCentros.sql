DROP PROCEDURE AfiCentrosGuardar
GO
CREATE PROCEDURE AfiCentrosGuardar
(
@pActivoFijo_Id int,
@pCentro1_Id varchar(8),
@pCentro2_Id varchar(8),
@pPorcentaje numeric(5,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM AfiCentros WHERE (ActivoFijo_Id = @pActivoFijo_Id) AND 
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id) AND Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id)))
BEGIN 
	UPDATE AfiCentros
	SET		Porcentaje = @pPorcentaje
	WHERE Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id) AND Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id)
END 
ELSE 
BEGIN 
	INSERT INTO AfiCentros
	(
		ActivoFijo_Id,
		Centro1_Id,
		Centro2_Id,
		Porcentaje
	)
	VALUES 
	(
		@pActivoFijo_Id,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pPorcentaje
	)
END 

GO

DROP PROCEDURE AfiCentrosDatos
GO
CREATE PROCEDURE AfiCentrosDatos
(
@pActivoFijo_Id int,
@pCentro1_Id varchar(8)=NULL,
@pCentro2_Id varchar(8)=NULL
)
AS
SET NOCOUNT ON 

SELECT AfiCentros.ActivoFijo_Id, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2, AfiCentros.Porcentaje
FROM AfiCentros 
INNER JOIN afiActivoFijo  ON (afiActivoFijo.AfiActivoFijo = AfiCentros.ActivoFijo_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = AfiCentros.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = AfiCentros.Centro2_Id)
WHERE (afiActivoFijo.afiActivoFijo = @pActivoFijo_Id)
AND (conCentro1.Centro1_Id = isNull(@pCentro1_Id,conCentro1.Centro1_Id))
AND (conCentro2.Centro2_Id = isNull(@pCentro2_Id,conCentro2.Centro2_Id))
 
RETURN @@Error 

GO

DROP PROCEDURE AfiCentrosEliminar
GO
CREATE PROCEDURE AfiCentrosEliminar
(
@pActivoFijo_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM AfiCentros 
WHERE (ActivoFijo_Id = @pActivoFijo_Id)
 
 RETURN @@Error 

GO

GO
