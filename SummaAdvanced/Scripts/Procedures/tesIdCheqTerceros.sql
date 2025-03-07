DROP PROCEDURE tesIdCheqTercerosGuardar
GO
CREATE PROCEDURE tesIdCheqTercerosGuardar
(
@pCartera_Id VarChar(5),
@pCtaChqRechazado varchar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesIdCheqTerceros WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))))
BEGIN 
	UPDATE tesIdCheqTerceros
	SET		CtaChqRechazado = dbo.FuncFKconCuentas(@pCtaChqRechazado)
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesIdCheqTerceros
	(
		Cartera_Id,
		CtaChqRechazado
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		dbo.FuncFKconCuentas(@pCtaChqRechazado)
	)
END 

GO

DROP PROCEDURE tesIdCheqTercerosDatos
GO
CREATE PROCEDURE tesIdCheqTercerosDatos
(
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.tesIdentifica, tesIdentifica.Cartera_id, tesIdentifica.Empresa_Id, Cast( Case When tesIdentifica.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpreas,
	tesTiposId.TipoCartera, tesTiposId.Descripcion as DescripcionTiposId, tesIdentifica.Descripcion, conCuentas.Cuenta_Id,
	conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	genUsuarios.Usuario_Id as UsuarioAmo, 	genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAmo, 
	tesIdentifica.ModiCent1, tesIdentifica.ModiCent2, 
	conCuentas2.Cuenta_Id as CtaValEnTransito,
	conCuentas2.Descripcion as DescripcionCtaValEnTransito, 
	tesIdentifica.Reservado, tesIdentifica.VaAlCashFlow, tesIdentifica.Inactivo,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, tesIdentifica.Posteado, 
	CtaChqRechazado.Cuenta_Id AS CtaChqRechazado, CtaChqRechazado.Descripcion as DescripcionCtaChqRechazado, 
	tesIdentifica.FormaDePagoP, tesIdentifica.OrdenPtoVta
FROM 
tesIdentifica inner join tesIdCheqTerceros ON tesIdentifica.tesIdentifica = tesIdCheqTerceros.Cartera_Id
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
LEFT OUTER JOIN conCuentas  CtaChqRechazado ON (CtaChqRechazado.conCuentas = tesIdCheqTerceros.CtaChqRechazado)
WHERE (tesIdentifica.Cartera_Id = @pCartera_Id)
 

Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'
RETURN @@Error 

 

GO

DROP PROCEDURE tesIdCheqTercerosEliminar
GO
CREATE PROCEDURE tesIdCheqTercerosEliminar
(
@pCartera_id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdCheqTerceros 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))
 
 RETURN @@Error 

GO

GO
