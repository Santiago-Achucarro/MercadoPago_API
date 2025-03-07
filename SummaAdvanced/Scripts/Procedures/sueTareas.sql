DROP PROCEDURE sueTareasGuardar
GO
CREATE PROCEDURE sueTareasGuardar
(
@pTarea_Id varchar(5),
@pTarea_Id_Nuevo varchar(5),
@pDescripcion varchar(100),
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pEmpresas int =null
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueTareas WHERE (Tarea_Id = @pTarea_Id)))
BEGIN 
	UPDATE sueTareas
	SET		@lIdentidad = sueTareas,
		Tarea_Id = @pTarea_Id_Nuevo,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id = @pEmpresas
	WHERE (Tarea_Id = @pTarea_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueTareas
	(
		Tarea_Id,
		Descripcion,
		Inactivo,
		Posteado,
		Usuario_Id,
		Empresa_Id
	)
	VALUES 
	(
		@pTarea_Id,
		@pDescripcion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pEmpresas
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueTareasDatos
GO
CREATE PROCEDURE sueTareasDatos
(
@pTarea_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT sueTareas.sueTareas, sueTareas.Tarea_Id, sueTareas.Descripcion, sueTareas.Inactivo,
	sueTareas.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, sueTareas.Empresa_Id,
	cast(case when sueTareas.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas
FROM sueTareas 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueTareas.Usuario_Id)
WHERE (Tarea_Id = @pTarea_Id)
 


  Declare @pidentity bigint= dbo.FuncFKsueTareas(@pTarea_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueTareas'
 RETURN @@Error 

GO

DROP PROCEDURE sueTareasEliminar
GO
CREATE PROCEDURE sueTareasEliminar
(
@pTarea_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueTareas 
WHERE (Tarea_Id = @pTarea_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsueTareas
GO

CREATE FUNCTION FuncFKsueTareas
(
@pTarea_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueTareas FROM sueTareas WHERE 
	Tarea_Id = @pTarea_Id
  RETURN @pIdentity
END


GO
