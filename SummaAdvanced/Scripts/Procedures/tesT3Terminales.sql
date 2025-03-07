DROP PROCEDURE tesT3TerminalesGuardar
GO
CREATE PROCEDURE tesT3TerminalesGuardar
(
@pTerminal_Id int,
@pTerminal_Id_Nuevo int,
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pSucursal Sucursal = NULL,
@pCartera_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesT3Terminales WHERE (Terminal_Id = @pTerminal_Id)))
BEGIN 
	UPDATE tesT3Terminales
	SET @lIdentidad = tesT3Terminales,
		Terminal_Id = @pTerminal_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		Cartera_Id = @pCartera_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Terminal_Id = @pTerminal_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesT3Terminales
	(
		Terminal_Id,
		Empresa_Id,
		Descripcion,
		Sucursal,
		Cartera_Id,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pTerminal_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		@pCartera_Id,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesT3TerminalesDatos
GO
CREATE PROCEDURE tesT3TerminalesDatos
(
@pTerminal_Id int
)
AS
SET NOCOUNT ON 

SELECT tesT3Terminales.tesT3Terminales, tesT3Terminales.Terminal_Id, tesT3Terminales.Terminal_Id Terminal_Id_Nueva, tesT3Terminales.Empresa_Id,
	Cast( Case When tesT3Terminales.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, tesT3Terminales.Descripcion, 
	genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr,
	tesT3Terminales.Cartera_Id, tesIdentifica.Descripcion as DescripcionIdBancoPropio, tesT3Terminales.Inactivo, tesT3Terminales.Posteado,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM tesT3Terminales 
LEFT JOIN genSucursalesEmpr ON (genSucursalesEmpr.genSucursalesEmpr = tesT3Terminales.Sucursal)
LEFT JOIN tesIdBancoPropio ON (tesIdBancoPropio.Cartera_Id = tesT3Terminales.Cartera_Id)
Left Join tesIdentifica On tesIdentifica.tesIdentifica = tesT3Terminales.Cartera_Id
LEFT JOIN genUsuarios ON (genUsuarios.genUsuarios = tesT3Terminales.Usuario_Id)
WHERE (Terminal_Id = @pTerminal_Id)
 


 Declare @pidentity bigint= dbo.FuncFKtesT3Terminales(@pTerminal_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesT3Terminales'
RETURN @@Error 

GO

DROP PROCEDURE tesT3TerminalesEliminar
GO
CREATE PROCEDURE tesT3TerminalesEliminar
(
@pTerminal_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesT3Terminales 
WHERE (Terminal_Id = @pTerminal_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesT3Terminales
GO

CREATE FUNCTION FuncFKtesT3Terminales
(
@pTerminal_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesT3Terminales FROM tesT3Terminales WHERE 
	Terminal_Id = @pTerminal_Id
  RETURN @pIdentity
END


GO
