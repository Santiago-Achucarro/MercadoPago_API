DROP PROCEDURE genReportesGuardar
GO
CREATE PROCEDURE genReportesGuardar
(
@pReporte_Id varchar(50),
@pReporte_Id_Nueva varchar(50),
@pTitulo varchar(80),
@pCarpeta VARCHAR(200) = NULL,
@pRpt varchar(200),
@pEstandar bit = NULL, 
@pLocal bit = NULL, 
@pStoreProcedure VarChar(200),
@pTipoReporte varChar(10) = Null, 
@pTamanioHoja Varchar(15) = Null, 
@pAnchoHoja Int = Null,
@pAltoHoja Int = Null 
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genReportes WHERE Reporte_Id = @pReporte_Id))
BEGIN 
	UPDATE genReportes
	SET @lIdentidad = genReportes,
		Reporte_Id = @pReporte_Id_Nueva ,
		Titulo = @pTitulo,
		Carpeta = @pCarpeta,
		Rpt = @pRpt,
		Estandar = @pEstandar,
		Local = @pLocal, 
		StoreProcedure = @pStoreProcedure,
		TipoReporte = @pTipoReporte, 
		TamanioHoja = @pTamanioHoja, 
		AnchoHoja = @pAnchoHoja, 
		AltoHoja = @pAltoHoja
	WHERE 
		Reporte_Id = @pReporte_Id 
END 
ELSE 
BEGIN 
	INSERT INTO genReportes
	(
		Reporte_Id,
		Titulo,
		Carpeta,
		Rpt,
		Estandar,
		Local, 
		StoreProcedure,
		TipoReporte,
		TamanioHoja,
		AnchoHoja, 
		AltoHoja
	)
	VALUES 
	(
		@pReporte_Id_Nueva,
		@pTitulo,
		@pCarpeta,
		@pRpt,
		@pEstandar,
		@pLocal, 
		@pStoreProcedure,
		@pTipoReporte, 
		@pTamanioHoja, 
		@pAnchoHoja, 
		@pAltoHoja
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE genReportesDatos
GO
CREATE PROCEDURE genReportesDatos
(
	@pReporte_Id varchar(50)
)
AS

SET NOCOUNT ON 

SELECT genReportes.genReportes, genReportes.Reporte_Id,genReportes.Reporte_Id as Reporte_Id_Nueva,
 genReportes.Titulo, genReportes.Carpeta, genReportes.Rpt, 
		genReportes.Estandar, genReportes.Local, genReportes.StoreProcedure, genReportes.TipoReporte, 
			genReportes.TamanioHoja, genReportes.AnchoHoja, genReportes.AltoHoja
FROM genReportes 
WHERE  
	Reporte_Id = @pReporte_Id 

Exec genReportesSPDatos @pReporte_id

RETURN @@Error 

GO

DROP PROCEDURE genReportesEliminar
GO
CREATE PROCEDURE genReportesEliminar
(
	@pReporte_Id varchar(50)
)
AS
SET NOCOUNT ON 

DELETE FROM genReportes WHERE Reporte_Id = @pReporte_Id 
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenReportes
GO

CREATE FUNCTION FuncFKgenReportes
(
	@pReporte_Id varchar(50)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genReportes FROM genReportes WHERE 
	Reporte_Id = @pReporte_Id
  RETURN @pIdentity
END


GO
