DROP PROCEDURE tesIdBancoPropioGuardar
GO
CREATE PROCEDURE tesIdBancoPropioGuardar
(
@pCartera_Id VarChar(5),
@pChequeraPredeter int = NULL,
@pBanco_Id varchar(3),
@pCantRenglones int,
@pnumCuenta varchar(35),
@pCtaContDiferido varchar(25) = NULL,
@pMaximoLibrado numeric(9),
@pValorComision numeric(5),
@pLimCredVtaCheques numeric(9),
@pCtaCorto numeric(5),
@pFormulario_Id int,
@pReferencia varchar(150),
@pRepoCheq_Id varchar(50) = NULL, 
@pRepoCheq_IdDif varchar(50) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesIdBancoPropio WHERE (Cartera_Id = dbo.FuncFKtesIdentifica( @pCartera_Id))))
BEGIN 
	UPDATE tesIdBancoPropio
	SET		ChequeraPredeter = @pChequeraPredeter,
		Banco_Id = dbo.FuncFKtesBancos(@pBanco_Id),
		CantRenglones = @pCantRenglones,
		numCuenta = @pnumCuenta,
		CtaContDiferido = dbo.FuncFKconCuentas(@pCtaContDiferido),
		MaximoLibrado = @pMaximoLibrado,
		ValorComision = @pValorComision,
		LimCredVtaCheques = @pLimCredVtaCheques,
		CtaCorto = @pCtaCorto,
		Formulario_Id = @pFormulario_Id,
		Referencia = @pReferencia,
		RepoCheq_Id =dbo.FuncFKgenReportes(@pRepoCheq_Id),
		RepoCheqDif_Id = dbo.FuncFKgenReportes(@pRepoCheq_IdDif) 
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica( @pCartera_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesIdBancoPropio
	(
		Cartera_Id,
		ChequeraPredeter,
		Banco_Id,
		CantRenglones,
		numCuenta,
		CtaContDiferido,
		MaximoLibrado,
		ValorComision,
		LimCredVtaCheques,
		CtaCorto,
		Formulario_Id,
		Referencia,
		RepoCheq_Id,
		RepoCheqDif_Id
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica( @pCartera_Id),
		@pChequeraPredeter,
		dbo.FuncFKtesBancos(@pBanco_Id),
		@pCantRenglones,
		@pnumCuenta,
		dbo.FuncFKconCuentas(@pCtaContDiferido),
		@pMaximoLibrado,
		@pValorComision,
		@pLimCredVtaCheques,
		@pCtaCorto,
		@pFormulario_Id,
		@pReferencia,
		dbo.FuncFKgenReportes(@pRepoCheq_Id),
		dbo.FuncFKgenReportes(@pRepoCheq_IdDif)
	)
END 

GO

DROP PROCEDURE tesIdBancoPropioDatos
GO
CREATE PROCEDURE tesIdBancoPropioDatos
(
@pCartera_Id VarChar(5), 
@pEmpresa_Id Int = NULL
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

	(select max(Chequera_Id) from tesChequeras 
	where
		tesChequeras.Cartera_Id = tesIdentifica.tesIdentifica and
		tesChequeras.Empresa_Id = @pEmpresa_Id and 
		tesChequeras.Estado_Id = 'P') AS ChequeraPredeter, tesBancos.Banco_Id,
	tesBancos.Descripcion as DescripcionBancos, tesIdBancoPropio.CantRenglones, 
	tesIdBancoPropio.numCuenta, 
	CtaContDiferido.Cuenta_Id as CtaContDiferido, CtaContDiferido.Descripcion as DescripcionCtaContDiferido, 
	tesIdBancoPropio.MaximoLibrado, tesIdBancoPropio.ValorComision, tesIdBancoPropio.LimCredVtaCheques,
	tesIdBancoPropio.CtaCorto, tesIdBancoPropio.Formulario_Id, tesIdBancoPropio.Referencia, 
	genReportes.Reporte_Id RepoCheq_Id, genReportes.Titulo TituloRepoCheq, genRepo2.Reporte_Id RepoCheqDif_Id, 
	genRepo2.Titulo TituloRepoCheqDif, tesIdentifica.FormaDePagoP, tesIdentifica.OrdenPtoVta
FROM tesIdentifica
inner join tesIdBancoPropio ON
tesIdBancoPropio.Cartera_id = tesIdentifica.tesIdentifica  
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
INNER JOIN tesBancos  ON (tesBancos.tesBancos = tesIdBancoPropio.Banco_Id)
LEFT JOIN conCuentas  as CtaContDiferido ON (CtaContDiferido.conCuentas = tesIdBancoPropio.CtaContDiferido)
LEFT JOIN genReportes ON genReportes.genReportes = tesIdBancoPropio.RepoCheq_Id
LEFT JOIN genReportes as genRepo2 ON genRepo2.genReportes = tesIdBancoPropio.RepoCheqDif_Id
WHERE (tesIdentifica.Cartera_id = @pCartera_id)

Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'
RETURN @@Error 
GO


DROP PROCEDURE tesIdBancoPropioEliminar
GO
CREATE PROCEDURE tesIdBancoPropioEliminar
(
@pCartera_id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdBancoPropio 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))
 
RETURN @@Error 

GO

GO
