DROP PROCEDURE comTipoPermiGuardar
GO
CREATE PROCEDURE comTipoPermiGuardar
(
@pTipoPermi_Id varchar(5),
@pTipoPermi_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(80),
@pTipoCuerpo Char(1),
@pRequiereAutorizacion bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pImportaciones bit,
@pReporte_Id varchar(50)=null,
@pEsquemaAuto_Id varchar(10)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comTipoPermi WHERE (TipoPermi_Id = @pTipoPermi_Id)))
BEGIN 
	UPDATE comTipoPermi
	SET		@lIdentidad = comTipoPermi,
		TipoPermi_Id = @pTipoPermi_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		TipoCuerpo = @pTipoCuerpo,
		RequiereAutorizacion = @pRequiereAutorizacion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		Importaciones = @pImportaciones,
		Reporte_Id=dbo.FuncFKgenReportes(@pReporte_Id),
		EsquemaAuto_Id=dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id)
	WHERE (TipoPermi_Id = @pTipoPermi_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comTipoPermi
	(
		TipoPermi_Id,
		Empresa_Id,
		Descripcion,
		TipoCuerpo,
		RequiereAutorizacion,
		Inactivo,
		Usuario_Id,
		Posteado, 
		Importaciones,
		Reporte_Id,
		EsquemaAuto_Id
	)
	VALUES 
	(
		@pTipoPermi_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pTipoCuerpo,
		@pRequiereAutorizacion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pImportaciones,
		dbo.FuncFKgenReportes(@pReporte_Id),
		dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id)
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comTipoPermiDatos
GO
CREATE PROCEDURE comTipoPermiDatos
(
@pTipoPermi_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comTipoPermi.comTipoPermi, comTipoPermi.TipoPermi_Id, comTipoPermi.Empresa_Id, Cast( Case When comTipoPermi.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comTipoPermi.Descripcion, comTipoPermi.TipoCuerpo, comTipoPermi.RequiereAutorizacion, comTipoPermi.Inactivo,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comTipoPermi.Posteado, 
	comTipoPermi.Importaciones, genReportes.Reporte_Id, genReportes.Titulo as DescripcionReporte, comEsquemaAuto.EsquemaAuto_Id,
	comEsquemaAuto.Descripcion as DescripcionEsquemaAuto
FROM comTipoPermi 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comTipoPermi.Usuario_Id)
left join genReportes on comTipoPermi.Reporte_Id=genReportes.genReportes
left join comEsquemaAuto on comEsquemaAuto.comEsquemaAuto=comTipoPermi.EsquemaAuto_Id
WHERE (TipoPermi_Id = @pTipoPermi_Id)
 


  Declare @pidentity bigint= dbo.FuncFKcomTipoPermi(@pTipoPermi_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comTipoPermi'
 RETURN @@Error 

GO

DROP PROCEDURE comTipoPermiEliminar
GO
CREATE PROCEDURE comTipoPermiEliminar
(
@pTipoPermi_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comTipoPermi 
WHERE (TipoPermi_Id = @pTipoPermi_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomTipoPermi
GO

CREATE FUNCTION FuncFKcomTipoPermi
(
@pTipoPermi_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comTipoPermi FROM comTipoPermi WHERE 
	TipoPermi_Id = @pTipoPermi_Id
  RETURN @pIdentity
END


GO
