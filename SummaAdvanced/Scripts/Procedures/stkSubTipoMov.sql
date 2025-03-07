DROP PROCEDURE stkSubTipoMovGuardar
GO
CREATE PROCEDURE stkSubTipoMovGuardar
(
@pSubTipoMov_Id varchar(5),
@pDescripcion varchar(50),
@pConsumo bit,
@pCantCopias smallint,
@pTipoMov varchar(2),
@pReporte_Id VarChar(50)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkSubTipoMov WHERE (SubTipoMov_Id = @pSubTipoMov_Id)))
BEGIN 
	UPDATE stkSubTipoMov
	SET		
		Descripcion = @pDescripcion,
		Consumo = @pConsumo,
		CantCopias = @pCantCopias,
		TipoMov = @pTipoMov, 
		Reporte_Id = dbo.FuncFKgenReportes(@pReporte_Id)
	WHERE (SubTipoMov_Id = @pSubTipoMov_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkSubTipoMov
	(
		SubTipoMov_Id,
		Descripcion,
		Consumo,
		CantCopias,
		TipoMov, 
		Reporte_Id 
	)
	VALUES 
	(
		@pSubTipoMov_Id,
		@pDescripcion,
		@pConsumo,
		@pCantCopias,
		@pTipoMov,
		dbo.FuncFKgenReportes(@pReporte_Id)
	)
	
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkSubTipoMovDatos
GO
CREATE PROCEDURE stkSubTipoMovDatos
(
@pSubTipoMov_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT stkSubTipoMov.SubTipoMov_Id, stkSubTipoMov.Descripcion, stkSubTipoMov.Consumo,
	stkSubTipoMov.CantCopias, stkTiposMov.TipoMov, stkTiposMov.Descripcion as DescripcionTiposMov, 
	genReportes.Reporte_Id, genReportes.Titulo as DescripcionReporte
FROM stkSubTipoMov 
INNER JOIN stkTiposMov  ON 
	stkTiposMov.Tipomov = stkSubTipoMov.TipoMov
LEFT OUTER JOIN genReportes on
genReportes.genReportes = stkSubTipoMov.Reporte_Id
WHERE SubTipoMov_Id = @pSubTipoMov_Id


 
 RETURN @@Error 


GO

DROP PROCEDURE stkSubTipoMovEliminar
GO
CREATE PROCEDURE stkSubTipoMovEliminar
(
@pSubTipoMov_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkSubTipoMov 
WHERE (SubTipoMov_Id = @pSubTipoMov_Id)
 
RETURN @@Error 

GO

