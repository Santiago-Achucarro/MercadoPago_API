DROP PROCEDURE tesIdTarjetas3Guardar
GO
CREATE PROCEDURE tesIdTarjetas3Guardar
(
@pCartera_Id VarChar(5),
@pMaxCuotas int,
@pBanco_Id varchar(3),
@pTipoTarjeta varchar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesIdTarjetas3 WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))))
BEGIN 
	UPDATE tesIdTarjetas3
	SET MaxCuotas = @pMaxCuotas,
	Banco_Id  = dbo.FuncFKtesBancos(@pBanco_Id),
	TipoTarjeta = dbo.FuncFKtesIdTarjetasTipo(@pTipoTarjeta)
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesIdTarjetas3
	(
		Cartera_Id,
		MaxCuotas,
		Banco_Id,
		TipoTarjeta
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pMaxCuotas,
		dbo.FuncFKtesBancos(@pBanco_Id),
		dbo.FuncFKtesIdTarjetasTipo(@pTipoTarjeta)
	)
END 

GO

DROP PROCEDURE tesIdTarjetas3Datos
GO
CREATE PROCEDURE tesIdTarjetas3Datos
(
@pCartera_Id VarChar(5)
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
	tesIdentifica.FormaDePagoP, tesIdentifica.OrdenPtoVta, tesIdTarjetas3.MaxCuotas, tesBancos.Banco_Id, tesIdTarjetasTipo.TipoTarjeta
FROM tesIdentifica 
INNER JOIN tesIdTarjetas3 ON tesIdentifica.tesIdentifica = tesIdTarjetas3.Cartera_Id
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
Inner Join tesBancos On tesBancos.tesBancos = tesIdTarjetas3.Banco_Id
Inner Join tesIdTarjetasTipo On tesIdTarjetasTipo.tesIdTarjetasTipo = tesIdTarjetas3.TipoTarjeta
WHERE (tesIdentifica.Cartera_Id = @pCartera_Id)
 


Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'
 
RETURN @@Error 

GO

DROP PROCEDURE tesIdTarjetas3Eliminar
GO
CREATE PROCEDURE tesIdTarjetas3Eliminar
(
@pCartera_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdTarjetas3 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
 
RETURN @@Error 

GO
