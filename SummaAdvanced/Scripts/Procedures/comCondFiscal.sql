DROP PROCEDURE comCondFiscalGuardar
GO
CREATE PROCEDURE comCondFiscalGuardar
(
@pCondFiscal_id varchar(5),
@pCondFiscal_id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pCodigoFiscal varchar(3) = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comCondFiscal WHERE (CondFiscal_id = @pCondFiscal_id)))
BEGIN 
	UPDATE comCondFiscal
	SET		@lIdentidad = comCondFiscal,
		CondFiscal_id = @pCondFiscal_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		CodigoFiscal = @pCodigoFiscal,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (CondFiscal_id = @pCondFiscal_id)
END 
ELSE 
BEGIN 
	INSERT INTO comCondFiscal
	(
		CondFiscal_id,
		Empresa_Id,
		Descripcion,
		CodigoFiscal,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCondFiscal_id,
		@pEmpresa_Id,
		@pDescripcion,
		@pCodigoFiscal,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comCondFiscalDatos
GO
CREATE PROCEDURE comCondFiscalDatos
(
@pCondFiscal_id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comCondFiscal.comCondFiscal, comCondFiscal.CondFiscal_id, comCondFiscal.Empresa_Id, Cast( Case When comCondFiscal.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comCondFiscal.Descripcion, comCondFiscal.CodigoFiscal, comCondFiscal.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comCondFiscal.Posteado
FROM comCondFiscal 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comCondFiscal.Usuario_Id)
WHERE (CondFiscal_id = @pCondFiscal_id)
 


  Declare @pidentity bigint= dbo.FuncFKcomCondFiscal(@pCondFiscal_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comCondFiscal'
 RETURN @@Error 

GO

DROP PROCEDURE comCondFiscalEliminar
GO
CREATE PROCEDURE comCondFiscalEliminar
(
@pCondFiscal_id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comCondFiscal 
WHERE (CondFiscal_id = @pCondFiscal_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomCondFiscal
GO

CREATE FUNCTION FuncFKcomCondFiscal
(
@pCondFiscal_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comCondFiscal FROM comCondFiscal WHERE 
	CondFiscal_id = @pCondFiscal_id
  RETURN @pIdentity
END


GO
