DROP PROCEDURE tesIdVariosGuardar
GO
CREATE PROCEDURE tesIdVariosGuardar
(
@pCartera_Id VarChar(5),
@pModi_Cuenta bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesIdVarios WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))))
BEGIN 
	UPDATE tesIdVarios
	SET		Modi_Cuenta = @pModi_Cuenta
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))
END 
ELSE 
BEGIN 
	INSERT INTO tesIdVarios
	(
		Cartera_Id,
		Modi_Cuenta
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_id),
		@pModi_Cuenta
	)
END 

GO

DROP PROCEDURE tesIdVariosDatos
GO
CREATE PROCEDURE tesIdVariosDatos
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
	tesIdVarios.Modi_Cuenta, tesIdentifica.FormaDePagoP, tesIdentifica.OrdenPtoVta
FROM tesIdentifica 
INNER JOIN tesIdVarios ON tesIdentifica.tesIdentifica = tesIdVarios.Cartera_Id
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
WHERE (tesIdentifica.Cartera_id = @pCartera_id)
 


Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'
 
RETURN @@Error 

GO

DROP PROCEDURE tesIdVariosEliminar
GO
CREATE PROCEDURE tesIdVariosEliminar
(
@pCartera_id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdVarios 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))
 
 RETURN @@Error 

GO

GO
