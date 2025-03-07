DROP PROCEDURE sueInfDefiniblesGuardar
GO
CREATE PROCEDURE sueInfDefiniblesGuardar
(
@pInforme_Id varchar(15),
@pInforme_Id_Nuevo varchar(15),
@pDescripcion varchar(100),
@pAgrupadoPor varchar(3),
@pTamanioHoja varchar(2) = NULL,
@pHorizontal Sino,
@pUm varchar(2),
@pLegajoDesde int,
@pLegajoHasta int,
@pSucursalDesde varchar(4),
@pSucursalHasta varchar(4),
@pConvenioDesde varchar(5),
@pConvenioHasta varchar(5),
@pAnchoNombre int,
@pCentro1Desde varchar(8),
@pCentro1Hasta varchar(8),
@pCentro2Desde varchar(8),
@pCentro2Hasta varchar(8),
@pUsuario_Id int,
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueInfDefinibles WHERE (Informe_Id = @pInforme_Id)))
BEGIN 
	UPDATE sueInfDefinibles
	SET		@lIdentidad = sueInfDefinibles,
		Informe_Id = @pInforme_Id_Nuevo,
		Descripcion = @pDescripcion,
		AgrupadoPor = @pAgrupadoPor,
		TamanioHoja = @pTamanioHoja,
		Horizontal = @pHorizontal,
		Um = @pUm,
		LegajoDesde = @pLegajoDesde,
		LegajoHasta = @pLegajoHasta,
		SucursalDesde = @pSucursalDesde,
		SucursalHasta = @pSucursalHasta,
		ConvenioDesde = @pConvenioDesde,
		ConvenioHasta = @pConvenioHasta,
		AnchoNombre = @pAnchoNombre,
		Centro1Desde = @pCentro1Desde,
		Centro1Hasta = @pCentro1Hasta,
		Centro2Desde = @pCentro2Desde,
		Centro2Hasta = @pCentro2Hasta,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado
	WHERE (Informe_Id = @pInforme_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueInfDefinibles
	(
		Informe_Id,
		Descripcion,
		AgrupadoPor,
		TamanioHoja,
		Horizontal,
		Um,
		LegajoDesde,
		LegajoHasta,
		SucursalDesde,
		SucursalHasta,
		ConvenioDesde,
		ConvenioHasta,
		AnchoNombre,
		Centro1Desde,
		Centro1Hasta,
		Centro2Desde,
		Centro2Hasta,
		Usuario_Id,
		Empresa_Id,
		Inactivo,
		Posteado
	)
	VALUES 
	(
		@pInforme_Id,
		@pDescripcion,
		@pAgrupadoPor,
		@pTamanioHoja,
		@pHorizontal,
		@pUm,
		@pLegajoDesde,
		@pLegajoHasta,
		@pSucursalDesde,
		@pSucursalHasta,
		@pConvenioDesde,
		@pConvenioHasta,
		@pAnchoNombre,
		@pCentro1Desde,
		@pCentro1Hasta,
		@pCentro2Desde,
		@pCentro2Hasta,
		@pUsuario_Id,
		@pEmpresa_Id,
		@pInactivo,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueInfDefiniblesDatos
GO
CREATE PROCEDURE sueInfDefiniblesDatos
(
@pInforme_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT sueInfDefinibles.sueInfDefinibles, sueInfDefinibles.Informe_Id, sueInfDefinibles.Descripcion, sueInfDefinibles.AgrupadoPor,
	sueInfDefinibles.TamanioHoja, genTamanioHoja.Descripcion as DescripcionTamanioHoja, sueInfDefinibles.Horizontal, sueInfDefinibles.Um,
	sueInfDefinibles.LegajoDesde, sueInfDefinibles.LegajoHasta, sueInfDefinibles.SucursalDesde, sueInfDefinibles.SucursalHasta,
	sueInfDefinibles.ConvenioDesde, sueInfDefinibles.ConvenioHasta, sueInfDefinibles.AnchoNombre, sueInfDefinibles.Centro1Desde,
	sueInfDefinibles.Centro1Hasta, sueInfDefinibles.Centro2Desde, sueInfDefinibles.Centro2Hasta, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, sueInfDefinibles.Empresa_Id, Cast( Case When sueInfDefinibles.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	sueInfDefinibles.Inactivo, sueInfDefinibles.Posteado
FROM sueInfDefinibles 
LEFT JOIN genTamanioHoja  ON (genTamanioHoja.TamanioHoja = sueInfDefinibles.TamanioHoja)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueInfDefinibles.Usuario_Id)
WHERE (Informe_Id = @pInforme_Id)
 
exec sueInfDefFormulasDatos @pInforme_Id, null
--@pInforme_Id


  Declare @pidentity bigint= dbo.FuncFKsueInfDefinibles(@pInforme_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueInfDefinibles'
 RETURN @@Error 

GO

DROP PROCEDURE sueInfDefiniblesEliminar
GO
CREATE PROCEDURE sueInfDefiniblesEliminar
(
@pInforme_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueInfDefinibles 
WHERE (Informe_Id = @pInforme_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsueInfDefinibles
GO

CREATE FUNCTION FuncFKsueInfDefinibles
(
@pInforme_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueInfDefinibles FROM sueInfDefinibles WHERE 
	Informe_Id = @pInforme_Id
  RETURN @pIdentity
END


GO
