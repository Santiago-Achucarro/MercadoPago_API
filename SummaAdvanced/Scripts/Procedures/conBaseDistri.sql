DROP PROCEDURE conBaseDistriGuardar
GO
CREATE PROCEDURE conBaseDistriGuardar
(
@pBase_Id varchar(5),
@pBase_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pMedida_Id varchar(3),
@pInactivo Sino,
@pUsuario_Id int = NULL,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conBaseDistri WHERE (Base_Id = @pBase_Id)))
BEGIN 
	UPDATE conBaseDistri
	SET		@lIdentidad = conBaseDistri,
		Base_Id = @pBase_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Medida_Id = @pMedida_Id,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Base_Id = @pBase_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conBaseDistri
	(
		Base_Id,
		Empresa_Id,
		Descripcion,
		Medida_Id,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pBase_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pMedida_Id,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal

GO

DROP PROCEDURE conBaseDistriDatos
GO
CREATE PROCEDURE conBaseDistriDatos
(
@pBase_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT conBaseDistri.conBaseDistri, conBaseDistri.Base_Id, conBaseDistri.Empresa_Id, 
	Cast( Case When conBaseDistri.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	conBaseDistri.Descripcion, conBaseDistri.Medida_Id, conBaseDistri.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, conBaseDistri.Posteado
FROM conBaseDistri 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = conBaseDistri.Usuario_Id)
WHERE (Base_Id = @pBase_Id)
 


Declare @pidentity bigint= dbo.FuncFKconBaseDistri(@pBase_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'conBaseDistri'

SELECT conCentro1.Centro1_id, conCentro1.Descripcion as DescripcionCentro1,
	conBaseCentro.Valor
FROM conBaseCentro 
INNER JOIN conCentro1 ON (conCentro1.conCentro1 = conBaseCentro.Centro1_Id)
WHERE (Base_Id = @pidentity)
 
 RETURN @@Error 

GO

DROP PROCEDURE conBaseDistriEliminar
GO
CREATE PROCEDURE conBaseDistriEliminar
(
@pBase_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conBaseDistri 
WHERE (Base_Id = @pBase_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconBaseDistri
GO

CREATE FUNCTION FuncFKconBaseDistri
(
@pBase_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conBaseDistri FROM conBaseDistri WHERE 
	Base_Id = @pBase_Id
  RETURN @pIdentity
END


GO
