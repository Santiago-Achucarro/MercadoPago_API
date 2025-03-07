DROP PROCEDURE comConPagoGuardar
GO
CREATE PROCEDURE comConPagoGuardar
(
@pCondPago_Id varchar(5),
@pCondPago_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pDesde varchar(2),
@pDias int,
@pCantidadCuotas int,
@pAplicaFactCredito bit,
@pAdmiteFactPagoAdel bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comConPago WHERE (CondPago_Id = @pCondPago_Id)))
BEGIN 
	UPDATE comConPago
	SET		@lIdentidad = comConPago,
		CondPago_Id = @pCondPago_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Desde = @pDesde,
		Dias = @pDias,
		CantidadCuotas = @pCantidadCuotas,
		AplicaFactCredito = @pAplicaFactCredito,
		AdmiteFactPagoAdel = @pAdmiteFactPagoAdel,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (CondPago_Id = @pCondPago_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comConPago
	(
		CondPago_Id,
		Empresa_Id,
		Descripcion,
		Desde,
		Dias,
		CantidadCuotas,
		AplicaFactCredito,
		AdmiteFactPagoAdel,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCondPago_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pDesde,
		@pDias,
		@pCantidadCuotas,
		@pAplicaFactCredito,
		@pAdmiteFactPagoAdel,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comConPagoDatos
GO
CREATE PROCEDURE comConPagoDatos
(
@pCondPago_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT comConPago.comConPago, comConPago.CondPago_Id, comConPago.Empresa_Id, Cast( Case When comConPago.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	comConPago.Descripcion, comConPago.Desde, comConPago.Dias, comConPago.CantidadCuotas,
	comConPago.AplicaFactCredito, comConPago.AdmiteFactPagoAdel, comConPago.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comConPago.Posteado
FROM comConPago 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comConPago.Usuario_Id)
WHERE (CondPago_Id = @pCondPago_Id)
 


 Declare @pidentity bigint= dbo.FuncFKcomConPago(@pCondPago_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comConPago'
 RETURN @@Error 

GO

DROP PROCEDURE comConPagoEliminar
GO
CREATE PROCEDURE comConPagoEliminar
(
@pCondPago_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comConPago 
WHERE (CondPago_Id = @pCondPago_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomConPago
GO

CREATE FUNCTION FuncFKcomConPago
(
@pCondPago_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comConPago FROM comConPago WHERE 
	CondPago_Id = @pCondPago_Id
  RETURN @pIdentity
END


GO
