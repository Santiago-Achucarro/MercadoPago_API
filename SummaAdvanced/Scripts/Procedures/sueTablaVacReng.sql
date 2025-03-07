DROP PROCEDURE sueTablaVacRengGuardar
GO
CREATE PROCEDURE sueTablaVacRengGuardar
(
@pTablaVac_Id VarChar(5),
@pAntiguedad int,
@pDias int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueTablaVacReng WHERE (TablaVac_Id = dbo.FuncFKsueTablaVacacion(@pTablaVac_Id)) AND 
		(Antiguedad = @pAntiguedad)))
BEGIN 
	UPDATE sueTablaVacReng
	SET		Dias = @pDias
	WHERE (TablaVac_Id = dbo.FuncFKsueTablaVacacion(@pTablaVac_Id)) AND (Antiguedad = @pAntiguedad)
END 
ELSE 
BEGIN 
	INSERT INTO sueTablaVacReng
	(
		TablaVac_Id,
		Antiguedad,
		Dias
	)
	VALUES 
	(
		dbo.FuncFKsueTablaVacacion(@pTablaVac_Id),
		@pAntiguedad,
		@pDias
	)
END 

GO

DROP PROCEDURE sueTablaVacRengDatos
GO
CREATE PROCEDURE sueTablaVacRengDatos
(
@pTablaVac_Id VarChar(5),
@pAntiguedad int = NULL
)
AS
SET NOCOUNT ON 

SELECT sueTablaVacacion.TablaVac_Id, sueTablaVacacion.Descripcion as DescripcionTablaVacacion, sueTablaVacReng.Antiguedad, sueTablaVacReng.Dias
FROM sueTablaVacReng 
INNER JOIN sueTablaVacacion  ON (sueTablaVacacion.sueTablaVacacion = sueTablaVacReng.TablaVac_Id)
WHERE (sueTablaVacacion.TablaVac_Id = @pTablaVac_Id)
AND (Antiguedad = ISNULL(@pAntiguedad,Antiguedad))
 
 RETURN @@Error 

GO

DROP PROCEDURE sueTablaVacRengEliminar
GO
CREATE PROCEDURE sueTablaVacRengEliminar
(
@pTablaVac_Id varchar(5),
@pAntiguedad int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueTablaVacReng 
WHERE (TablaVac_Id = dbo.FuncFKsueTablaVacacion(@pTablaVac_Id))
AND (Antiguedad = ISNULL(@pAntiguedad, Antiguedad))
 
 RETURN @@Error 

GO

GO
