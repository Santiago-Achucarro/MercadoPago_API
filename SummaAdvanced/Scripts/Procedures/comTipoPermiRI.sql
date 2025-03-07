DROP PROCEDURE comTipoPermiRIGuardar
GO
CREATE PROCEDURE comTipoPermiRIGuardar
(
@pTipoPermiRI_Id varchar(5),
@pTipoPermiRI_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pEsquemaAuto_Id varchar(10) = NULL,
@pTipoCuerpo char(1),
@pReporte_Id varchar(50) = NULL,
@pTipoRI char(1),
@pUsuarioAutorizado_Id varchar(25) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pGeneraOC bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comTipoPermiRI WHERE (TipoPermiRI_Id = @pTipoPermiRI_Id)))
BEGIN 
	UPDATE comTipoPermiRI
	SET		@lIdentidad = comTipoPermiRI,
		TipoPermiRI_Id = @pTipoPermiRI_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		EsquemaAuto_Id = dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id),
		TipoCuerpo = @pTipoCuerpo,
		Reporte_Id = dbo.FuncFKgenReportes(@pReporte_Id),
		TipoRI = @pTipoRI,
		UsuarioAutorizado_Id = dbo.FuncFKgenUsuarios(@pUsuarioAutorizado_Id),
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		GeneraOC=@pGeneraOC
	WHERE (TipoPermiRI_Id = @pTipoPermiRI_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comTipoPermiRI
	(
		TipoPermiRI_Id,
		Empresa_Id,
		Descripcion,
		EsquemaAuto_Id,
		TipoCuerpo,
		Reporte_Id,
		TipoRI,
		UsuarioAutorizado_Id,
		Inactivo,
		Posteado,
		Usuario_Id,
		GeneraOC
	)
	VALUES 
	(
		@pTipoPermiRI_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id),
		@pTipoCuerpo,
		dbo.FuncFKgenReportes(@pReporte_Id),
		@pTipoRI,
		dbo.FuncFKgenUsuarios(@pUsuarioAutorizado_Id),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pGeneraOC
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comTipoPermiRIDatos
GO
CREATE PROCEDURE comTipoPermiRIDatos
(
@pTipoPermiRI_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comTipoPermiRI.comTipoPermiRI, comTipoPermiRI.TipoPermiRI_Id, comTipoPermiRI.Empresa_Id,
	Cast( Case When comTipoPermiRI.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, comTipoPermiRI.Descripcion, comEsquemaAuto.EsquemaAuto_Id, comEsquemaAuto.Descripcion as DescripcionEsquemaAuto,
	comTipoPermiRI.TipoCuerpo, comTipoPermiRI.TipoRI, UsuAutorizacion.Usuario_Id as UsuarioAutoriz,
	UsuAutorizacion.Apellido_y_Nombres as DescripcionUsuarioAutoriz, comTipoPermiRI.Inactivo, comTipoPermiRI.Posteado, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genReportes.Reporte_Id, genReportes.Titulo as DescripcionReporte,
	comTipoPermiRI.GeneraOC
FROM comTipoPermiRI 
LEFT JOIN comEsquemaAuto  ON (comEsquemaAuto.comEsquemaAuto = comTipoPermiRI.EsquemaAuto_Id)
LEFT JOIN genReportes  ON (genReportes.genReportes = comTipoPermiRI.Reporte_Id)
LEFT JOIN genUsuarios UsuAutorizacion ON (UsuAutorizacion.genUsuarios = comTipoPermiRI.UsuarioAutorizado_Id)
LEFT JOIN genUsuarios ON (genUsuarios.genUsuarios = comTipoPermiRI.Usuario_Id)
WHERE (TipoPermiRI_Id = @pTipoPermiRI_Id)
 


  Declare @pidentity bigint= dbo.FuncFKcomTipoPermiRI(@pTipoPermiRI_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comTipoPermiRI'
 RETURN @@Error 

GO

DROP PROCEDURE comTipoPermiRIEliminar
GO
CREATE PROCEDURE comTipoPermiRIEliminar
(
@pTipoPermiRI_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comTipoPermiRI 
WHERE (TipoPermiRI_Id = @pTipoPermiRI_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomTipoPermiRI
GO

CREATE FUNCTION FuncFKcomTipoPermiRI
(
@pTipoPermiRI_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comTipoPermiRI FROM comTipoPermiRI WHERE 
	TipoPermiRI_Id = @pTipoPermiRI_Id
  RETURN @pIdentity
END


GO
