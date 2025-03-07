
DROP PROCEDURE tesIdentificaGuardar
GO
CREATE PROCEDURE tesIdentificaGuardar
(
@pCartera_Id varchar(5),
@pCartera_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pTipoCartera varChar(2),
@pDescripcion varchar(35),
@pCuenta_Id varchar(25) = NULL,
@pCentro1_Id varchar(8),
@pCentro2_Id varchar(8),
@pMoneda_Id varchar(3) = NULL,
@pUsuarioAmo varchar(25) = NULL,
@pModiCent1 bit,
@pModiCent2 bit,
@pCtaValEnTransito varchar(25) = NULL,
@pReservado numeric(5),
@pVaAlCashFlow bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pFormaDePagoP VarChar(2),
@pOrdenPtoVta int = Null
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM tesIdentifica WHERE (Cartera_Id = @pCartera_Id)))
BEGIN 
	UPDATE tesIdentifica
	SET @lIdentidad = tesIdentifica,
		Cartera_Id = @pCartera_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		TipoCartera = dbo.FuncFKtesTiposId(@pTipoCartera),
		Descripcion = @pDescripcion,
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		UsuarioAmo = dbo.FuncFKgenUsuarios(@pUsuarioAmo),
		ModiCent1 = @pModiCent1,
		ModiCent2 = @pModiCent2,
		CtaValEnTransito = dbo.FuncFKconCuentas(@pCtaValEnTransito),
		Reservado = @pReservado,
		VaAlCashFlow = @pVaAlCashFlow,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		FormaDePagoP = @pFormaDePagoP,
		OrdenPtoVta = @pOrdenPtoVta
	WHERE (Cartera_Id = @pCartera_Id)
END 
ELSE 
BEGIN 
	INSERT INTO tesIdentifica
	(
		Cartera_Id,
		Empresa_Id,
		TipoCartera,
		Descripcion,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		Moneda_Id,
		UsuarioAmo,
		ModiCent1,
		ModiCent2,
		CtaValEnTransito,
		Reservado,
		VaAlCashFlow,
		Inactivo,
		Usuario_Id,
		Posteado,
		FormaDePagoP,
		OrdenPtoVta
	)
	VALUES 
	(
		@pCartera_Id,
		@pEmpresa_Id,
		dbo.FuncFKtesTiposId(@pTipoCartera),
		@pDescripcion,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKgenUsuarios(@pUsuarioAmo),
		@pModiCent1,
		@pModiCent2,
		dbo.FuncFKconCuentas(@pCtaValEnTransito),
		@pReservado,
		@pVaAlCashFlow,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado,
		@pFormaDePagoP,
		@pOrdenPtoVta
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE tesIdentificaDatos
GO
CREATE PROCEDURE tesIdentificaDatos
(
@pCartera_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.tesIdentifica, tesIdentifica.Cartera_Id, tesIdentifica.Empresa_Id, Cast( Case When tesIdentifica.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpreas,
	tesTiposId.TipoCartera, tesTiposId.Descripcion as DescripcionTiposId, tesIdentifica.Descripcion, conCuentas.Cuenta_Id,
	conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	genUsuarios.Usuario_Id as UsuarioAmo, 	genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAmo, 
	tesIdentifica.ModiCent1, tesIdentifica.ModiCent2, 
	conCuentas2.Cuenta_Id as CtaValEnTransito,
	conCuentas2.Descripcion as DescripcionCtaValEnTransito, 
	tesIdentifica.Reservado, tesIdentifica.VaAlCashFlow, tesIdentifica.Inactivo,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, tesIdentifica.Posteado,
	tesIdentifica.FormaDePagoP, tesIdentifica.OrdenPtoVta
FROM tesIdentifica 
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
WHERE (Cartera_Id = @pCartera_Id)
 


 Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'
 RETURN @@Error 

GO

DROP PROCEDURE tesIdentificaEliminar
GO
CREATE PROCEDURE tesIdentificaEliminar
(
@pCartera_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdentifica 
WHERE (Cartera_Id = @pCartera_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKtesIdentifica
GO

CREATE FUNCTION FuncFKtesIdentifica
(
@pCartera_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = tesIdentifica FROM tesIdentifica WHERE 
	Cartera_Id = @pCartera_Id
  RETURN @pIdentity
END


GO

Drop procedure tesIdentificaPV
Go
Create procedure tesIdentificaPV
(
@pEmpresa_Id int
)
As
Select Cartera_Id, tesIdentifica.Descripcion, tesTiposId.TipoCartera, Cast(0 As Numeric(15,2)) Importe
From tesIdentifica
Inner Join tesTiposId On tesTiposId.tesTiposId = tesIdentifica.TipoCartera
Where OrdenPtoVta <> 0 And isNull(tesIdentifica.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id
Order by tesIdentifica.OrdenPtoVta
Go
