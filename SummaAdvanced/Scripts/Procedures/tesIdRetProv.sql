DROP PROCEDURE tesIdRetProvGuardar
GO
CREATE PROCEDURE tesIdRetProvGuardar
(
@pCartera_Id VarChar(5),
@pFormula varchar(max),
@pSegmento_Id varchar(10),
@pTipoImpuesto int,
@pNroResSicore numeric(5),
@pTipoCtaProv int,
@pConcepto varchar(max) = NULL,
@pPorcentaje numeric(5,2),
@pUsuarioFirmante varchar(30),
@pMinimo numeric(9),
@pGenRetxFact bit,
@pReporte_Id varChar(50)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesIdRetProv WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))))
BEGIN 
	UPDATE tesIdRetProv
	SET	
		Formula = @pFormula,
		Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id),
		TipoImpuesto = @pTipoImpuesto,
		NroResSicore = @pNroResSicore,
		TipoCtaProv = @pTipoCtaProv,
		Concepto = @pConcepto,
		Porcentaje = @pPorcentaje,
		UsuarioFirmante = @pUsuarioFirmante,
		Minimo = @pMinimo,
		GenRetxFact = @pGenRetxFact,
		Reporte_Id = dbo.FuncFKgenReportes(@pReporte_Id)
	WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))
END 
ELSE 
BEGIN 
	INSERT INTO tesIdRetProv
	(
		Cartera_Id,
		Formula,
		Segmento_Id,
		TipoImpuesto,
		NroResSicore,
		TipoCtaProv,
		Concepto,
		Porcentaje,
		UsuarioFirmante,
		Minimo,
		GenRetxFact,
		Reporte_Id
	)
	VALUES 
	(
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pFormula,
		dbo.FuncFKgenSegmentos(@pSegmento_Id),
		@pTipoImpuesto,
		@pNroResSicore,
		@pTipoCtaProv,
		@pConcepto,
		@pPorcentaje,
		@pUsuarioFirmante,
		@pMinimo,
		@pGenRetxFact,
		dbo.FuncFKgenReportes(@pReporte_Id)
	)
END 

GO

DROP PROCEDURE tesIdRetProvDatos
GO
CREATE PROCEDURE tesIdRetProvDatos
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
	genSegmentos.Segmento_Id, genSegmentos.Descripcion DescripcionSegmento, tesIdRetProv.Formula, 
	impTipoImpuesto.TipoImpuesto, impTipoImpuesto.Descripcion DescripcionTipoImpuesto,
	tesIdRetProv.NroResSicore, tesIdRetProv.TipoCtaProv, comProveedoresTipoPasivo.Descripcion DescripcionTipoPasivo,
	tesIdRetProv.Concepto, tesIdRetProv.Porcentaje, tesIdRetProv.UsuarioFirmante, tesIdRetProv.Minimo, tesIdRetProv.GenRetxFact,
	genReportes.Reporte_Id, genReportes.Titulo, tesIdentifica.FormaDePagoP
FROM tesIdentifica 
INNER JOIN tesIdRetProv ON tesIdentifica.tesIdentifica = tesIdRetProv.Cartera_Id
INNER JOIN tesTiposId  ON (tesTiposId.tesTiposId = tesIdentifica.TipoCartera)
LEFT JOIN conCuentas  ON (conCuentas.conCuentas = tesIdentifica.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = tesIdentifica.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = tesIdentifica.Centro2_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = tesIdentifica.Moneda_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesIdentifica.UsuarioAmo)
LEFT JOIN conCuentas conCuentas2 ON (conCuentas2.conCuentas = tesIdentifica.CtaValEnTransito)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesIdentifica.Usuario_Id)
Left Join genSegmentos On genSegmentos.genSegmentos = tesIdRetProv.Segmento_Id
Left Join comProveedoresTipoPasivo On comProveedoresTipoPasivo.TipoCtaProv = tesIdRetProv.TipoCtaProv
Left Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = tesIdRetProv.TipoImpuesto
Left Join genReportes On genReportes.genReportes = tesIdRetProv.Reporte_Id
WHERE (tesIdentifica.Cartera_id = @pCartera_id)


Declare @pidentity bigint= dbo.FuncFKtesIdentifica(@pCartera_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'tesIdentifica'

RETURN @@Error 

GO

DROP PROCEDURE tesIdRetProvEliminar
GO
CREATE PROCEDURE tesIdRetProvEliminar
(
@pCartera_id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM tesIdRetProv 
WHERE (Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_id))
 
 RETURN @@Error 

GO
