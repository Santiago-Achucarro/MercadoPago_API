DROP PROCEDURE stkFamiliasGuardar
GO
CREATE PROCEDURE stkFamiliasGuardar
(
@pFamilia_Id varchar(15),
@pFamilia_Id_Nuevo varchar(15),
@pDescripcion varchar(60),
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int,
@pPorcentaje1 numeric(5,2),
@pPorcentaje2 numeric(5,2),
@pPorcentaje3 numeric(5,2),
@pPorcentaje4 numeric(5,2)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkFamilias WHERE (Familia_Id = @pFamilia_Id)))
BEGIN 
	UPDATE stkFamilias
	SET		@lIdentidad = stkFamilias,
		Familia_Id = @pFamilia_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Porcentaje1 = @pPorcentaje1,
		Porcentaje2 = @pPorcentaje2,
		Porcentaje3 = @pPorcentaje3,
		Porcentaje4 = @pPorcentaje4
	WHERE (Familia_Id = @pFamilia_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkFamilias
	(
		Familia_Id,
		Descripcion,
		Empresa_Id,
		Inactivo,
		Posteado,
		Usuario_Id,
		Porcentaje1,
		Porcentaje2,
		Porcentaje3,
		Porcentaje4
	)
	VALUES 
	(
		@pFamilia_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pPorcentaje1,
		@pPorcentaje2,
		@pPorcentaje3,
		@pPorcentaje4
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkFamiliasDatos
GO
CREATE PROCEDURE stkFamiliasDatos
(
@pFamilia_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT stkFamilias.stkFamilias, stkFamilias.Familia_Id, stkFamilias.Descripcion, 
	stkFamilias.Empresa_Id, Cast( Case When stkFamilias.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, 
	stkFamilias.Inactivo, stkFamilias.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	wooFamiliasId.wooCommerceId, stkFamilias.Porcentaje1, stkFamilias.Porcentaje2, stkFamilias.Porcentaje3, stkFamilias.Porcentaje4
FROM stkFamilias 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkFamilias.Usuario_Id)
LEFT JOIN wooFamiliasId on wooFamiliasId.Familia_Id=stkFamilias.stkFamilias
WHERE (stkFamilias.Familia_Id = @pFamilia_Id)
 
  Declare @pidentity bigint= dbo.FuncFKstkFamilias(@pFamilia_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkFamilias'
 RETURN @@Error 
GO


DROP PROCEDURE stkFamiliasEliminar
GO
CREATE PROCEDURE stkFamiliasEliminar
(
	@pFamilia_Id varchar(15) 
)
AS
SET NOCOUNT ON 

DELETE FROM stkFamilias 
WHERE (Familia_Id = @pFamilia_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkFamilias
GO

CREATE FUNCTION FuncFKstkFamilias
(
@pFamilia_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkFamilias FROM stkFamilias WHERE 
	Familia_Id = @pFamilia_Id
  RETURN @pIdentity
END


GO
