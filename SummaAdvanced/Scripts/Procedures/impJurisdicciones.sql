DROP PROCEDURE impJurisdiccionesGuardar
GO
CREATE PROCEDURE impJurisdiccionesGuardar
(
@pJuris_Id varchar(3),
@pJuris_Id_Nuevo varchar(3),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(20),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM impJurisdicciones WHERE (Juris_Id = @pJuris_Id)))
BEGIN 
	UPDATE impJurisdicciones
	SET		@lIdentidad = impJurisdicciones,
		Juris_Id = @pJuris_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Juris_Id = @pJuris_Id)
END 
ELSE 
BEGIN 
	INSERT INTO impJurisdicciones
	(
		Juris_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pJuris_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE impJurisdiccionesDatos
GO
CREATE PROCEDURE impJurisdiccionesDatos
(
@pJuris_Id varchar(3)
)
AS
SET NOCOUNT ON 

SELECT impJurisdicciones.impJurisdicciones, impJurisdicciones.Juris_Id, impJurisdicciones.Empresa_Id, Cast( Case When impJurisdicciones.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	impJurisdicciones.Descripcion, impJurisdicciones.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	impJurisdicciones.Posteado
FROM impJurisdicciones 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = impJurisdicciones.Usuario_Id)
WHERE (Juris_Id = @pJuris_Id)
 


  Declare @pidentity bigint= dbo.FuncFKimpJurisdicciones(@pJuris_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'impJurisdicciones'
 RETURN @@Error 

GO

DROP PROCEDURE impJurisdiccionesEliminar
GO
CREATE PROCEDURE impJurisdiccionesEliminar
(
@pJuris_Id varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impJurisdicciones 
WHERE (Juris_Id = @pJuris_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKimpJurisdicciones
GO

CREATE FUNCTION FuncFKimpJurisdicciones
(
@pJuris_Id varchar (3)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = impJurisdicciones FROM impJurisdicciones WHERE 
	Juris_Id = @pJuris_Id
  RETURN @pIdentity
END


GO
