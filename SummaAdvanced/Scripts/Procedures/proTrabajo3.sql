DROP PROCEDURE proTrabajo3Guardar
GO
CREATE PROCEDURE proTrabajo3Guardar
(
@pTrabajo3_Id varchar(25),
@pTrabajo3_Id_Nuevo varchar(25),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pCuenta_Id varchar(25) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proTrabajo3 WHERE (Trabajo3_Id = @pTrabajo3_Id)))
BEGIN 
	UPDATE proTrabajo3
	SET		@lIdentidad = proTrabajo3,
		Trabajo3_Id = @pTrabajo3_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Trabajo3_Id = @pTrabajo3_Id)
END 
ELSE 
BEGIN 
	INSERT INTO proTrabajo3
	(
		Trabajo3_Id,
		Empresa_Id,
		Descripcion,
		Cuenta_Id,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pTrabajo3_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE proTrabajo3Datos
GO
CREATE PROCEDURE proTrabajo3Datos
(
@pTrabajo3_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT proTrabajo3.proTrabajo3, proTrabajo3.Trabajo3_Id, proTrabajo3.Empresa_Id,
	Cast( Case When proTrabajo3.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, proTrabajo3.Descripcion, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	proTrabajo3.Inactivo, proTrabajo3.Posteado, proTrabajo3.Usuario_Id
FROM proTrabajo3 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = proTrabajo3.Cuenta_Id)
WHERE (Trabajo3_Id = @pTrabajo3_Id)
 


  Declare @pidentity bigint= dbo.FuncFKproTrabajo3(@pTrabajo3_Id)
  exec proTrabajo3ProvDatos @pTrabajo3_Id,null
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'proTrabajo3'
 RETURN @@Error 

GO

DROP PROCEDURE proTrabajo3Eliminar
GO
CREATE PROCEDURE proTrabajo3Eliminar
(
@pTrabajo3_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proTrabajo3 
WHERE (Trabajo3_Id = @pTrabajo3_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKproTrabajo3
GO

CREATE FUNCTION FuncFKproTrabajo3
(
@pTrabajo3_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proTrabajo3 FROM proTrabajo3 WHERE 
	Trabajo3_Id = @pTrabajo3_Id
  RETURN @pIdentity
END


GO
