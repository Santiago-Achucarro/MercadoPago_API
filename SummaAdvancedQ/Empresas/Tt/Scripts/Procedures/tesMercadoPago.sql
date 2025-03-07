DROP PROCEDURE tesMercadoPagoGuardar
GO
CREATE PROCEDURE tesMercadoPagoGuardar
(
@pMercadoPago_Id varchar(15),
@pMercadoPago_Id_Nuevo varchar(15),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesMercadoPago WHERE (MercadoPago_Id = @pMercadoPago_Id)))
BEGIN 
	UPDATE tesMercadoPago
	SET		@lIdentidad = tesMercadoPago,
		MercadoPago_Id = @pMercadoPago_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (MercadoPago_Id = @pMercadoPago_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesMercadoPago
	(
		MercadoPago_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pMercadoPago_Id,
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

DROP PROCEDURE tesMercadoPagoDatos
GO
CREATE PROCEDURE tesMercadoPagoDatos
(
@pMercadoPago_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT tesMercadoPago.tesMercadoPago, tesMercadoPago.MercadoPago_Id, tesMercadoPago.MercadoPago_Id MercadoPago_Id_Nueva, tesMercadoPago.Empresa_Id,
	Cast( Case When tesMercadoPago.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, tesMercadoPago.Descripcion, tesMercadoPago.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, tesMercadoPago.Posteado
FROM tesMercadoPago 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesMercadoPago.Usuario_Id)
WHERE (MercadoPago_Id = @pMercadoPago_Id)
 


 Declare @pidentity bigint= dbo.FuncFKtesMercadoPago(@pMercadoPago_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesMercadoPago'
RETURN @@Error 

GO

DROP PROCEDURE tesMercadoPagoEliminar
GO
CREATE PROCEDURE tesMercadoPagoEliminar
(
@pMercadoPago_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesMercadoPago 
WHERE (MercadoPago_Id = @pMercadoPago_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesMercadoPago
GO

CREATE FUNCTION FuncFKtesMercadoPago
(
@pMercadoPago_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesMercadoPago FROM tesMercadoPago WHERE 
	MercadoPago_Id = @pMercadoPago_Id
  RETURN @pIdentity
END


GO
