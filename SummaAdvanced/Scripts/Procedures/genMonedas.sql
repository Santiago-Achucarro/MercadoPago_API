
-- exec genMonedasDatos 'PES'
DROP PROCEDURE genMonedasGuardar
GO
CREATE PROCEDURE genMonedasGuardar
(
@pMoneda_Id varchar(3),
@pMoneda_Id_Nuevo varchar(3),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(30),
@pSimbolo varchar(5),
@pCodigoFiscal varChar(25),
@pCtaFactaRecibir varChar(25),
@pCtaFactaRecibirImp varChar(25),
@pCantidadDigitos int,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genMonedas WHERE (Moneda_Id = @pMoneda_Id)))
BEGIN 
	UPDATE genMonedas
	SET @lIdentidad = genMonedas,
		Moneda_Id = @pMoneda_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Simbolo = @pSimbolo,
		CodigoFiscal = @pCodigoFiscal,
		CtaFactaRecibir = dbo.FuncFKconCuentas(@pCtaFactaRecibir),
		CtaFactaRecibirImp = dbo.FuncFKconCuentas(@pCtaFactaRecibirImp),
		CantidadDigitos = @pCantidadDigitos,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Moneda_Id = @pMoneda_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genMonedas
	(
		Moneda_Id,
		Empresa_Id,
		Descripcion,
		Simbolo,
		CodigoFiscal,
		CtaFactaRecibir,
		CtaFactaRecibirImp,
		CantidadDigitos,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pMoneda_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pSimbolo,
		@pCodigoFiscal,
		dbo.FuncFKconCuentas(@pCtaFactaRecibir),
		dbo.FuncFKconCuentas(@pCtaFactaRecibirImp),
		@pCantidadDigitos,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE genMonedasDatos
GO
CREATE PROCEDURE genMonedasDatos
(
@pMoneda_Id varchar(3)
)
AS
SET NOCOUNT ON 

SELECT genMonedas.genMonedas, genMonedas.Moneda_Id, genMonedas.Empresa_Id, 
	Cast( Case When genMonedas.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genMonedas.Descripcion, genMonedas.Simbolo, genMonedas.CodigoFiscal,
	conCuentasFAR.Cuenta_Id CtaFactaRecibir, conCuentasFAR.Descripcion DescripcionCtaFactaRecibir,
	conCuentasFARI.Cuenta_Id CtaFactaRecibirImp, conCuentasFARI.Descripcion DescripcionCtaFactaRecibirImp,
	genMonedas.CantidadDigitos, genMonedas.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genMonedas.Posteado
FROM genMonedas 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genMonedas.Usuario_Id)
Left Join conCuentas conCuentasFAR On conCuentasFAR.conCuentas = genMonedas.CtaFactaRecibir
Left Join conCuentas conCuentasFARI On conCuentasFARI.conCuentas = genMonedas.CtaFactaRecibirImp
WHERE (genMonedas.Moneda_Id = @pMoneda_Id)
 


Declare @pidentity bigint= dbo.FuncFKgenMonedas(@pMoneda_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'genMonedas'
RETURN @@Error 

GO

DROP PROCEDURE genMonedasEliminar
GO
CREATE PROCEDURE genMonedasEliminar
(
@pMoneda_Id varchar(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genMonedas 
WHERE (Moneda_Id = @pMoneda_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKgenMonedas
GO

CREATE FUNCTION FuncFKgenMonedas
(
@pMoneda_Id varchar (3)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genMonedas FROM genMonedas WHERE 
	Moneda_Id = @pMoneda_Id
  RETURN @pIdentity
END


GO

DROP Procedure genMonedasDatosCierre
GO
CREATE Procedure genMonedasDatosCierre (
	@Fecha DateTime
)
as
SELECT @Fecha as Fecha

SELECT genMonedas.Moneda_id, genMonedas.Descripcion, 
genTipoCambio.CambioCompra,
genTipoCambio.CambioVenta
FROM genMonedas inner join genTipoCambio on
genTipoCambio.Moneda_id = genMonedas.genMonedas and 
genTipoCambio.Fecha = (SELECT MAX(Fecha) from genTipoCambio genTipoCambio1 where
		genTipoCambio1.Moneda_id =   genMonedas.genMonedas and 
		genTipoCambio1.Fecha <= @Fecha)
GO

	
DROP PROCEDURE genMonedasDatosFiscal
GO
CREATE PROCEDURE genMonedasDatosFiscal
(
@pIdFiscal varchar(25)
)
AS
SET NOCOUNT ON 


SELECT genMonedas.genMonedas, genMonedas.Moneda_Id, genMonedas.Empresa_Id, 
	Cast( Case When genMonedas.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genMonedas.Descripcion, genMonedas.Simbolo, genMonedas.CodigoFiscal,
	conCuentasFAR.Cuenta_Id CtaFactaRecibir, conCuentasFAR.Descripcion DescripcionCtaFactaRecibir,
	conCuentasFARI.Cuenta_Id CtaFactaRecibirImp, conCuentasFARI.Descripcion DescripcionCtaFactaRecibirImp,
	genMonedas.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genMonedas.Posteado
FROM genMonedas 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genMonedas.Usuario_Id)
Left Join conCuentas conCuentasFAR On conCuentasFAR.conCuentas = genMonedas.CtaFactaRecibir
Left Join conCuentas conCuentasFARI On conCuentasFARI.conCuentas = genMonedas.CtaFactaRecibirImp
WHERE (genMonedas.CodigoFiscal = @pIdFiscal)
 
 Declare @pidentity bigint= (select genMonedas from genMonedas where 
	CodigoFiscal = @pIdFiscal)
	
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'genMonedas'
 RETURN @@Error 

GO

	