DROP PROCEDURE venCategCreditoGuardar
GO
CREATE PROCEDURE venCategCreditoGuardar
(
@pCategCred_id varchar(5),
@pCategCred_id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pMaxDiasAtraso smallint,
@pPorcenDeudaVenci numeric(5),
@pTipoCredito numeric(5),
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venCategCredito WHERE (CategCred_id = @pCategCred_id)))
BEGIN 
	UPDATE venCategCredito
	SET		@lIdentidad = venCategCredito,
		CategCred_id = @pCategCred_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		MaxDiasAtraso = @pMaxDiasAtraso,
		PorcenDeudaVenci = @pPorcenDeudaVenci,
		TipoCredito = @pTipoCredito,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (CategCred_id = @pCategCred_id)
END 
ELSE 
BEGIN 
	INSERT INTO venCategCredito
	(
		CategCred_id,
		Empresa_Id,
		Descripcion,
		MaxDiasAtraso,
		PorcenDeudaVenci,
		TipoCredito,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCategCred_id,
		@pEmpresa_Id,
		@pDescripcion,
		@pMaxDiasAtraso,
		@pPorcenDeudaVenci,
		@pTipoCredito,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venCategCreditoDatos
GO
CREATE PROCEDURE venCategCreditoDatos
(
@pCategCred_id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venCategCredito.venCategCredito, venCategCredito.CategCred_id, venCategCredito.Empresa_Id, Cast( Case When venCategCredito.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venCategCredito.Descripcion, venCategCredito.MaxDiasAtraso, venCategCredito.PorcenDeudaVenci, venCategCredito.TipoCredito,
	venCategCredito.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCategCredito.Posteado
FROM venCategCredito 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCategCredito.Usuario_Id)
WHERE (CategCred_id = @pCategCred_id)
 


 Declare @pidentity bigint= dbo.FuncFKvenCategCredito(@pCategCred_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCategCredito'
 RETURN @@Error 

GO

DROP PROCEDURE venCategCreditoEliminar
GO
CREATE PROCEDURE venCategCreditoEliminar
(
@pCategCred_id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCategCredito 
WHERE (CategCred_id = @pCategCred_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenCategCredito
GO

CREATE FUNCTION FuncFKvenCategCredito
(
@pCategCred_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venCategCredito FROM venCategCredito WHERE 
	CategCred_id = @pCategCred_id
  RETURN @pIdentity
END


GO
