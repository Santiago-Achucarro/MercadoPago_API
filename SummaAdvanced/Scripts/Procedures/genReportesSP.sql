DROP PROCEDURE genReportesSPGuardar
GO
CREATE PROCEDURE genReportesSPGuardar
(
@pReporte_ID VarChar(50),
@pRenglon int,
@pStoreProcedure varchar(150),
@pDataTable varchar(100)
)
AS
SET NOCOUNT ON 


IF (EXISTS (SELECT 1 FROM genReportesSP WHERE (genReportes = dbo.FuncFKgenReportes(@pReporte_ID)) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE genReportesSP
	SET		StoreProcedure = @pStoreProcedure,
		DataTable = @pDataTable
	WHERE (genReportes = dbo.FuncFKgenReportes(@pReporte_ID)) AND (Renglon = @pRenglon)
END 

ELSE 
BEGIN 
	INSERT INTO genReportesSP
	(
		genReportes,
		Renglon,
		StoreProcedure,
		DataTable
	)
	VALUES 
	(
		dbo.FuncFKgenReportes(@pReporte_ID),
		@pRenglon,
		@pStoreProcedure,
		@pDataTable
	)
END 

GO

DROP PROCEDURE genReportesSPDatos
GO
CREATE PROCEDURE genReportesSPDatos
(
@pReporte_ID VarChar(50),
@pRenglon int=NULL
)
AS
SET NOCOUNT ON 

SELECT genReportesSP.genReportes,  genReportes.Reporte_Id, genReportesSP.Renglon, genReportesSP.StoreProcedure, genReportesSP.DataTable
FROM genReportesSP INNER JOIN genReportes ON
genReportesSP.genReportes = genReportes.genReportes
WHERE (genReportes.Reporte_id = @pReporte_ID)
AND (Renglon = ISNULL(@pRenglon,Renglon))
 
 RETURN @@Error 

GO

DROP PROCEDURE genReportesSPEliminar
GO
CREATE PROCEDURE genReportesSPEliminar
(
@pgenReportes int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genReportesSP 
WHERE (genReportes = @pgenReportes)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO


