
-- exec suegruposDatos 1
DROP PROCEDURE sueGruposGuardar
GO
CREATE PROCEDURE sueGruposGuardar
(
@pGrupo_Id int,
@pGrupo_Id_Nuevo int,
@pDescripcion varchar(100),
@pEmpresa_Id int = NULL,
@pSegmento_Id varchar(10) = NULL,
@pPeriodo_Id char(1) = NULL,
@pCtaSueldoAPagar varchar(25) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueGrupos WHERE (Grupo_Id = @pGrupo_Id)))
BEGIN 
	UPDATE sueGrupos
	SET		@lIdentidad = sueGrupos,
		Grupo_Id = @pGrupo_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id),
		Periodo_Id = @pPeriodo_Id,
		CtaSueldoAPagar = dbo.FuncFKconCuentas(@pCtaSueldoAPagar),
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Grupo_Id = @pGrupo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueGrupos
	(
		Grupo_Id,
		Descripcion,
		Empresa_Id,
		Segmento_Id,
		Periodo_Id,
		CtaSueldoAPagar,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pGrupo_Id,
		@pDescripcion,
		@pEmpresa_Id,
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		@pPeriodo_Id,
		dbo.FuncFKconCuentas(@pCtaSueldoAPagar),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueGruposDatos
GO
CREATE PROCEDURE sueGruposDatos
(
@pGrupo_Id int
)
AS
SET NOCOUNT ON 

SELECT sueGrupos.sueGrupos, sueGrupos.Grupo_Id, sueGrupos.Descripcion, sueGrupos.Grupo_Id Grupo_Id_Nueva,
	sueGrupos.Empresa_Id, Cast( Case When sueGrupos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, genSegmentos.Segmento_Id, 
	genSegmentos.Descripcion as DescripcionSegmento, suePeriodicidad.Periodo_Id, suePeriodicidad.Descripcion as DescripcionPeriodo,
	conCuentas.Cuenta_Id as CtaSueldoAPagar, conCuentas.Descripcion as DescripcionCtaSueldoAPagar, sueGrupos.Inactivo, sueGrupos.Posteado,
	sueGrupos.Usuario_Id
FROM sueGrupos 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = sueGrupos.CtaSueldoAPagar)
left join genSegmentos on genSegmentos.genSegmentos=sueGrupos.Segmento_Id
left join suePeriodicidad on suePeriodicidad.Periodo_Id=sueGrupos.Periodo_Id
WHERE (sueGrupos.Grupo_Id = @pGrupo_Id)
 


  Declare @pidentity bigint= dbo.FuncFKsueGrupos(@pGrupo_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueGrupos'
 RETURN @@Error 

GO

DROP PROCEDURE sueGruposEliminar
GO
CREATE PROCEDURE sueGruposEliminar
(
@pGrupo_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueGrupos 
WHERE (Grupo_Id = @pGrupo_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsueGrupos
GO

CREATE FUNCTION FuncFKsueGrupos
(
@pGrupo_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueGrupos FROM sueGrupos WHERE 
	Grupo_Id = @pGrupo_Id
  RETURN @pIdentity
END


GO
