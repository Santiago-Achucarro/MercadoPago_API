DROP PROCEDURE suePuestosGuardar
GO
CREATE PROCEDURE suePuestosGuardar
(
@pPuesto_Id varchar(5),
@pPuesto_Id_Nueva varchar(5),
@pDescripcion varchar(20),
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pEmpresa_Id int =null,
@pRiesgoPuesto VarChar(2) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM suePuestos WHERE Puesto_Id=@pPuesto_Id))
BEGIN 
	UPDATE suePuestos
	SET		@lIdentidad = suePuestos,
		Puesto_Id = @pPuesto_Id_Nueva,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id=@pEmpresa_Id, 
		RiesgoPuesto = @pRiesgoPuesto
	WHERE 
	Puesto_Id=@pPuesto_Id
END 
ELSE 
BEGIN 
	INSERT INTO suePuestos
	(
		Puesto_Id,
		Descripcion,
		Inactivo,
		Posteado,
		Usuario_Id,
		Empresa_Id, 
		RiesgoPuesto
	)
	VALUES 
	(
		@pPuesto_Id_Nueva,
		@pDescripcion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pEmpresa_Id, 
		@pRiesgoPuesto
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE suePuestosDatos
GO
CREATE PROCEDURE suePuestosDatos
(
@pPuesto_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT suePuestos.suePuestos, suePuestos.Puesto_Id, suePuestos.Descripcion, suePuestos.Inactivo,
	suePuestos.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, suePuestos.Empresa_Id,
	cast(case when suePuestos.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas, 
	RiesgoPuesto
FROM suePuestos 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = suePuestos.Usuario_Id)
WHERE  
Puesto_Id=@pPuesto_Id

  Declare @pidentity bigint= dbo.FuncFKsuePuestos(@pPuesto_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'suePuestos'
 RETURN @@Error 

GO

DROP PROCEDURE suePuestosEliminar
GO
CREATE PROCEDURE suePuestosEliminar
(
@pPuesto_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM suePuestos 
WHERE  
Puesto_Id=@pPuesto_Id
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsuePuestos
GO

CREATE FUNCTION FuncFKsuePuestos
(
@pPuestos_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = suePuestos FROM suePuestos WHERE 
	Puesto_Id = @pPuestos_Id
  RETURN @pIdentity
END


GO
