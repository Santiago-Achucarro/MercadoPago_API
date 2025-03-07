DROP PROCEDURE tesIdRetClienGuardar
GO
CREATE PROCEDURE tesIdRetClienGuardar
(
@pCartera_Id VarChar(5),
@pvaSubDiarioVta bit,
@pTipoImpuesto int,
@pNroResSicore Numeric(5)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesIdRetClien WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))))
BEGIN 
	UPDATE tesIdRetClien
	SET vaSubDiarioVta = @pvaSubDiarioVta,
	TipoImpuesto = @pTipoImpuesto,
	NroResSicore = @pNroResSicore
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesIdRetClien
	(
		Cartera_Id,
		vaSubDiarioVta,
		TipoImpuesto,
		NroResSicore
		
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pvaSubDiarioVta,
		@pTipoImpuesto,
		@pNroResSicore
	)
END 

GO

DROP PROCEDURE tesIdRetClienDatos
GO
CREATE PROCEDURE tesIdRetClienDatos
(
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 

SELECT tesIdentifica.tesIdentifica, tesIdentifica.Cartera_Id, tesIdentifica.Empresa_Id, 
Cast( Case When tesIdentifica.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpreas,
	tesTiposId.TipoCartera, tesTiposId.Descripcion as DescripcionTiposId, tesIdentifica.Descripcion, conCuentas.Cuenta_Id,
	conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	genUsuarios.Usuario_Id as UsuarioAmo, genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAmo, 
	tesIdentifica.ModiCent1, tesIdentifica.ModiCent2, 
	conCuentas2.Cuenta_Id as CtaValEnTransito,
	conCuentas2.Descripcion as DescripcionCtaValEnTransito, 
	tesIdentifica.Reservado, tesIdentifica.VaAlCashFlow, tesIdentifica.Inactivo,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, tesIdentifica.Posteado, 
	tesIdRetClien.vaSubDiarioVta, tesIdRetClien.TipoImpuesto, impTipoImpuesto.Descripcion DescripcionTipoImpuesto, tesIdRetClien.NroResSicore, 
	tesidentifica.FormaDePagoP
FROM tesIdentifica 
INNER JOIN tesIdRetClien ON tesIdentifica.tesIdentifica = tesIdRetClien.Cartera_Id
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
Left Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = tesIdRetClien.TipoImpuesto
WHERE (tesIdentifica.Cartera_Id = @pCartera_Id)



Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'
 
RETURN @@Error 

GO

DROP PROCEDURE tesIdRetClienEliminar
GO
CREATE PROCEDURE tesIdRetClienEliminar
(
@pCartera_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdRetClien 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id))
 
RETURN @@Error 

GO

GO
