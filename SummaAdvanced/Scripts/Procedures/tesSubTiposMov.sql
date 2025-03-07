DROP PROCEDURE tesSubTiposMovGuardar
GO
CREATE PROCEDURE tesSubTiposMovGuardar
(
@pSubTipo_Id varchar(3),
@pSubTipo_Id_Nuevo varchar(3),
@pDescripcion varchar(60),
@pCantCopias smallint, 
@pTipomov Char(1), 
@pReporte_Id VarChar(50)=NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesSubTiposMov WHERE (SubTipo_Id = @pSubTipo_Id)))
BEGIN 
	UPDATE tesSubTiposMov
	SET		@lIdentidad = tesSubTiposMov,
		SubTipo_Id = @pSubTipo_Id_Nuevo,
		Descripcion = @pDescripcion,
		CantCopias = @pCantCopias, 
		Tipomov = @pTipomov, 
		genReportes = dbo.FuncFKgenReportes(@pReporte_Id)
	WHERE (SubTipo_Id = @pSubTipo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesSubTiposMov
	(
		SubTipo_Id,
		Descripcion,
		CantCopias, 
		Tipomov, 
		genReportes
	)
	VALUES 
	(
		@pSubTipo_Id,
		@pDescripcion,
		@pCantCopias,
		@pTipomov, 
		dbo.FuncFKgenReportes(@pReporte_Id)
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesSubTiposMovDatos
GO
CREATE PROCEDURE tesSubTiposMovDatos
(
@pSubTipo_Id varchar(3)
)
AS
SET NOCOUNT ON 

SELECT tesSubTiposMov.tesSubTiposMov, tesSubTiposMov.SubTipo_Id, 
	tesSubTiposMov.Descripcion, tesSubTiposMov.CantCopias,
		tesSubTiposMov.Tipomov, genReportes.Reporte_Id, 
			genReportes.Titulo
FROM tesSubTiposMov LEFT JOIN genReportes ON
tesSubTiposMov.genReportes = genReportes.genReportes

WHERE (SubTipo_Id = @pSubTipo_Id)
 


 Declare @pidentity bigint= dbo.FuncFKtesSubTiposMov(@pSubTipo_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesSubTiposMov'
 RETURN @@Error 

GO

DROP PROCEDURE tesSubTiposMovEliminar
GO
CREATE PROCEDURE tesSubTiposMovEliminar
(
@pSubTipo_Id varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesSubTiposMov 
WHERE (SubTipo_Id = @pSubTipo_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesSubTiposMov
GO

CREATE FUNCTION FuncFKtesSubTiposMov
(
@pSubTipo_Id varchar (3)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesSubTiposMov FROM tesSubTiposMov WHERE 
	SubTipo_Id = @pSubTipo_Id
  RETURN @pIdentity
END


GO
