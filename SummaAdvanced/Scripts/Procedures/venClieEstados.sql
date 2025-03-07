DROP PROCEDURE venClieEstadosGuardar
GO
CREATE PROCEDURE venClieEstadosGuardar
(
@pEstado_Id varchar(5),
@pEstado_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pCuenta_Id varchar(25) = NULL,
@pReservado bit,
@pImpideOperaciones bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venClieEstados WHERE (Estado_Id = @pEstado_Id)))
BEGIN 
	UPDATE venClieEstados
	SET		@lIdentidad = venClieEstados,
		Estado_Id = @pEstado_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Reservado = @pReservado,
		Inactivo = @pInactivo,
		ImpideOperaciones = @pImpideOperaciones,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Estado_id = @pEstado_id)
END 
ELSE 
BEGIN 
	INSERT INTO venClieEstados
	(
		Estado_Id,
		Empresa_Id,
		Descripcion,
		Cuenta_Id,
		Reservado,
		Inactivo,
		ImpideOperaciones,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pEstado_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		@pReservado,
		@pInactivo,
		@pImpideOperaciones,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venClieEstadosDatos
GO
CREATE PROCEDURE venClieEstadosDatos
(
@pEstado_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venClieEstados.venClieEstados, venClieEstados.Estado_Id, venClieEstados.Empresa_Id, 
	Cast( Case When venClieEstados.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venClieEstados.Descripcion, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, venClieEstados.Reservado,
	venClieEstados.Inactivo, venClieEstados.ImpideOperaciones,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venClieEstados.Posteado
FROM venClieEstados 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = venClieEstados.Cuenta_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venClieEstados.Usuario_Id)
WHERE (Estado_id = @pEstado_id)
 


 Declare @pidentity bigint= dbo.FuncFKvenClieEstados(@pEstado_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venClieEstados'
 RETURN @@Error 

GO

DROP PROCEDURE venClieEstadosEliminar
GO
CREATE PROCEDURE venClieEstadosEliminar
(
@pEstado_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venClieEstados 
WHERE (Estado_Id = @pEstado_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenClieEstados
GO

CREATE FUNCTION FuncFKvenClieEstados
(
@pEstado_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venClieEstados FROM venClieEstados WHERE 
	Estado_Id = @pEstado_Id
  RETURN @pIdentity
END


GO
