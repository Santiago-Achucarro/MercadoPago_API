DROP PROCEDURE conInfDefiniblesGuardar
GO
CREATE PROCEDURE conInfDefiniblesGuardar
(
@pInforme_Id varchar(15),
@pInforme_Id_Nuevo varchar(15),
@pDescripcion varchar(80),
@pUsuario_Id int ,
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conInfDefinibles WHERE (Informe_Id = @pInforme_Id)))
BEGIN 
	UPDATE conInfDefinibles
	SET		@lIdentidad = conInfDefinibles,
		Informe_Id = @pInforme_Id_Nuevo,
		Descripcion = @pDescripcion,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado
	WHERE (Informe_Id = @pInforme_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conInfDefinibles
	(
		Informe_Id,
		Descripcion,
		Usuario_Id,
		Empresa_Id,
		Inactivo,
		Posteado
	)
	VALUES 
	(
		@pInforme_Id,
		@pDescripcion,
		@pUsuario_Id,
		@pEmpresa_Id,
		@pInactivo,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE conInfDefiniblesDatos
GO
CREATE PROCEDURE conInfDefiniblesDatos
(
@pInforme_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT conInfDefinibles.conInfDefinibles, conInfDefinibles.Informe_Id, conInfDefinibles.Descripcion, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, conInfDefinibles.Informe_Id Informe_Id_Nueva, conInfDefinibles.Empresa_Id, Cast( Case When conInfDefinibles.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	conInfDefinibles.Inactivo, conInfDefinibles.Posteado
FROM conInfDefinibles 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = conInfDefinibles.Usuario_Id)
WHERE (Informe_Id = @pInforme_Id)
 
 Exec  conInfDefFilasDatos @pInforme_Id, NULL
 Exec  conInfDefCuentasDatos @pInforme_Id, NULL

 Declare @pidentity bigint= dbo.FuncFKconInfDefinibles(@pInforme_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'conInfDefinibles'
 RETURN @@Error 

GO

DROP PROCEDURE conInfDefiniblesEliminar
GO
CREATE PROCEDURE conInfDefiniblesEliminar
(
@pInforme_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conInfDefinibles 
WHERE (Informe_Id = @pInforme_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconInfDefinibles
GO

CREATE FUNCTION FuncFKconInfDefinibles
(
@pInforme_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conInfDefinibles FROM conInfDefinibles WHERE 
	Informe_Id = @pInforme_Id
  RETURN @pIdentity
END


GO
