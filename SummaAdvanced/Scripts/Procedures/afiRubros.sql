DROP PROCEDURE AfiRubrosGuardar
GO
CREATE PROCEDURE AfiRubrosGuardar
(
@pRubro_Id varchar(5),
@pRubro_Id_Nuevo varchar(5),
@pEmpresa_Id Int=NULL,
@pDescripcion varchar(120),
@pVidaUtil int,
@pVidaUtilFiscal int,
@pCtaValorOrigen_Id varchar(25) = NULL,
@pCtaAmortAcum_Id varchar(25) = NULL,
@pCtaAmortizacion_Id varchar(25) = NULL,
@pTipo varchar(2),
@pDigitos smallint, 
@pUsuario_Id Int, 
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM AfiRubros WHERE Rubro_Id=@pRubro_Id ))
BEGIN 
	UPDATE AfiRubros
	SET		@lIdentidad = AfiRubros,
		Rubro_Id = @pRubro_Id_Nuevo,
		Descripcion = @pDescripcion,
		VidaUtil = @pVidaUtil,
		VidaUtilFiscal = @pVidaUtilFiscal,
		CtaValorOrigen_Id = dbo.FuncFKconCuentas(@pCtaValorOrigen_Id),
		CtaAmortAcum_Id = dbo.FuncFKconCuentas(@pCtaAmortAcum_Id),
		CtaAmortizacion_Id = dbo.FuncFKconCuentas(@pCtaAmortizacion_Id),
		Tipo = @pTipo,
		Digitos = @pDigitos, 
		Usuario_Id =@pUsuario_Id, 
		Posteado = @pPosteado, 
		Empresa_Id = @pEmpresa_Id
	WHERE 
	Rubro_Id = @pRubro_Id
END 
ELSE 
BEGIN 
	INSERT INTO AfiRubros
	(
		Rubro_Id,
		Descripcion,
		VidaUtil,
		VidaUtilFiscal,
		CtaValorOrigen_Id,
		CtaAmortAcum_Id,
		CtaAmortizacion_Id,
		Tipo,
		Digitos, 
		Usuario_Id, 
		Posteado ,
		Empresa_Id, 
		FechaAlta
	)
	VALUES 
	(
		@pRubro_Id_Nuevo,
		@pDescripcion,
		@pVidaUtil,
		@pVidaUtilFiscal,
		dbo.FuncFKconCuentas(@pCtaValorOrigen_Id),
		dbo.FuncFKconCuentas(@pCtaAmortAcum_Id),
		dbo.FuncFKconCuentas(@pCtaAmortizacion_Id),
		@pTipo,
		@pDigitos, 
		@pUsuario_Id, 
		@pPosteado ,
		@pEmpresa_Id,
		dbo.FechaActual()
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE AfiRubrosDatos
GO
CREATE PROCEDURE AfiRubrosDatos
(@pRubro_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT AfiRubros.AfiRubros, AfiRubros.Rubro_Id, 
	Cast(Case when AfiRubros.Empresa_Id IS NULL THEN 1 ELSE 0 END as Bit) PTodasEmpresas,
	AfiRubros.Empresa_Id,
	AfiRubros.Descripcion, AfiRubros.VidaUtil,
	AfiRubros.VidaUtilFiscal, conCuentas.Cuenta_Id as CtaValorOrigen, conCuentas.Descripcion as DescripcionCtaValorOrigen, 
	conCuentas2.Cuenta_Id as CtaAmortAcum_Id,
	conCuentas2.Descripcion as DescripcionCtaAmortAcum_Id, conCuentas3.Cuenta_Id as CtaAmortizacion_Id, 
	conCuentas3.Descripcion as DescripcionCtaAmortizacion_Id, AfiRubros.Tipo,
	AfiRubros.Digitos, AfiRubros.Posteado, genUsuarios.Usuario_Id
FROM AfiRubros 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = AfiRubros.CtaValorOrigen_Id)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = AfiRubros.CtaAmortAcum_Id)
LEFT JOIN conCuentas conCuentas3 ON (conCuentas3.conCuentas = AfiRubros.CtaAmortizacion_Id)
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = AfiRubros.Usuario_Id
WHERE  
AfiRubros.Rubro_Id=@pRubro_Id

  Declare @pidentity bigint= dbo.FuncFKAfiRubros(@pRubro_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'AfiRubros'
 RETURN @@Error 

GO

DROP PROCEDURE AfiRubrosEliminar
GO
CREATE PROCEDURE AfiRubrosEliminar
(@pRubro_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM AfiRubros 
WHERE
Rubro_Id =@pRubro_Id  
 RETURN @@Error 

GO

DROP FUNCTION FuncFKAfiRubros
GO

CREATE FUNCTION FuncFKAfiRubros
(
@pRubro_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = AfiRubros FROM AfiRubros WHERE 
	Rubro_Id = @pRubro_Id
  RETURN @pIdentity
END

GO


DROP PROCEDURE AfiRubrosCuentaDatos
GO
CREATE PROCEDURE AfiRubrosCuentaDatos
(
	@pCuenta_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT AfiRubros.AfiRubros, AfiRubros.Rubro_Id, 
	Cast(Case when AfiRubros.Empresa_Id IS NULL THEN 1 ELSE 0 END as Bit) PTodasEmpresas,
	AfiRubros.Empresa_Id,
	AfiRubros.Descripcion, AfiRubros.VidaUtil,
	AfiRubros.VidaUtilFiscal, conCuentas.Cuenta_Id as CtaValorOrigen, conCuentas.Descripcion as DescripcionCtaValorOrigen, 
	conCuentas2.Cuenta_Id as CtaAmortAcum_Id,
	conCuentas2.Descripcion as DescripcionCtaAmortAcum_Id, conCuentas3.Cuenta_Id as CtaAmortizacion_Id, 
	conCuentas3.Descripcion as DescripcionCtaAmortizacion_Id, AfiRubros.Tipo,
	AfiRubros.Digitos, AfiRubros.Posteado, genUsuarios.Usuario_Id
FROM AfiRubros 
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = AfiRubros.CtaValorOrigen_Id)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = AfiRubros.CtaAmortAcum_Id)
LEFT JOIN conCuentas conCuentas3 ON (conCuentas3.conCuentas = AfiRubros.CtaAmortizacion_Id)
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = AfiRubros.Usuario_Id
WHERE  
conCuentas.Cuenta_Id = @pCuenta_Id

 
 RETURN @@Error 

GO
