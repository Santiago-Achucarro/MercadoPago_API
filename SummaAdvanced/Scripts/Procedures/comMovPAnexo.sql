
DROP PROCEDURE comMovpAnexoGuardar
GO
CREATE PROCEDURE comMovpAnexoGuardar
(
@pAsiento_Id bigint,
@pProvAnexo bigint,
@ptesRengMovi_Id bigint,
@pRenglonRengMovi int,
@pFecha_Ane datetime,
@pFechaFiscal datetime,
@pCondFiscal_Id varchar(5) = NULL,
@pOrigen_Id smallint = NULL,
@pVieneDeFiscal Sino,
@pXMLFiscal text = NULL,
@pClaveFiscal varchar(36) = NULL,
@pconRenglonProv int = null
)
AS

SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comMovpAnexo WHERE (Asiento_Id = @pAsiento_Id)))
BEGIN 
	UPDATE comMovpAnexo
	SET	ProvAnexo = @pProvAnexo,
		tesRengMovi_Id = @ptesRengMovi_Id,
		RenglonRengMovi = @pRenglonRengMovi,
		Fecha_Ane = @pFecha_Ane,
		FechaFiscal = @pFechaFiscal,
		Origen_Id = dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id),
		CondFiscal_Id = dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		VieneDeFiscal = @pVieneDeFiscal,
		XMLFiscal = @pXMLFiscal,
		ClaveFiscal = @pClaveFiscal,
		conRenglonProv = @pconRenglonProv
	WHERE (Asiento_Id = @pAsiento_Id)
END 
ELSE 
BEGIN 

	INSERT INTO comMovpAnexo
	(
		Asiento_Id,
		ProvAnexo,
		tesRengMovi_Id,
		RenglonRengMovi,
		Fecha_Ane,
		FechaFiscal,
		Origen_Id,
		CondFiscal_Id,
		VieneDeFiscal,
		XMLFiscal,
		ClaveFiscal,
		conRenglonProv
	)
	VALUES 
	(
		@pAsiento_Id,
		@pProvAnexo,
		@ptesRengMovi_Id,
		@pRenglonRengMovi,
		@pFecha_Ane,
		@pFechaFiscal,
		dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id),
		dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		@pVieneDeFiscal,
		@pXMLFiscal,
		@pClaveFiscal,
		@pconRenglonProv
	)
END 

GO

DROP PROCEDURE comMovpAnexoDatos
GO
CREATE PROCEDURE comMovpAnexoDatos
(
@pAsiento_Id bigint=null,
@pTesMovimientos bigint=null,
@pRenglonRengMovi int=null
)
AS
SET NOCOUNT ON 

SELECT comMovpAnexo.Asiento_Id, genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	conAsientos.Posteado, genMonedas.Moneda_Id, conAsientos.Cambio, 
	conAsientos.CambioMonedaOriginal, conAsientos.Observaciones,
	comMovpAnexo.tesRengMovi_Id, comMovpAnexo.RenglonRengMovi, comMovPAnexo.conRenglonProv,
	conMovCont.Tipomov, conAsientos.Fecha as Fecha_Contable, 
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal,  tesIdentifica.Cartera_Id, 
	tesIdentifica.Descripcion as DescripcionCartera, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	genEntidades.CUIT, genEntidades.genEntidades,
	comProvAnexo.RazonSocial , comProvAnexo.Direccion1, comProvAnexo.Direccion2, 
	comProvAnexo.Localidad, comProvAnexo.Cod_Postal, 
	genProvincias.Provincia_id, genProvincias.Descripcion as DescripcionProvincia,
	comMovpAnexo.Fecha_Ane, comMovpAnexo.FechaFiscal, 
	comOrigenesFiscales.Origen_Id, 
	comOrigenesFiscales.Descripcion as DescripcioncomOrigenesFiscales, comCondFiscal.CondFiscal_Id,
	comCondFiscal.Descripcion as DescripcionCondFiscal, comMovpAnexo.VieneDeFiscal,
	comMovpAnexo.XMLFiscal, comMovpAnexo.ClaveFiscal
FROM comMovpAnexo 
INNER JOIN genEntidades ON genEntidades.genEntidades = comMovpAnexo.ProvAnexo
INNER JOIN conAsientos  ON (conAsientos.conAsientos = comMovpAnexo.Asiento_Id)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos 
INNER JOIN genSegmentos on genSegmentos.genSegmentos = genAsiSegmentos.Segmento_id
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_id
INNER JOIN conMovCont  ON conMovCont.conAsientos = comMovPAnexo.tesRengMovi_Id and 
							conMovCont.Renglon =comMovPAnexo.conRenglonProv
INNER JOIN comProvAnexo  ON (comProvAnexo.genEntidades = comMovpAnexo.ProvAnexo)
INNER JOIN tesRengMovi  ON (tesRengMovi.tesMovimientos = comMovpAnexo.tesRengMovi_Id) AND 
			(tesRengMovi.conRenglon = comMovpAnexo.conRenglonProv)
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id 							
INNER JOIN conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
INNER JOIN conCentro1 ON conMovCont.Centro1_Id = conCentro1.conCentro1
INNER JOIN conCentro2 ON conMovCont.Centro2_Id = conCentro2.conCentro2
LEFT JOIN comOrigenesFiscales  ON (comOrigenesFiscales.comOrigenesFiscales = comMovpAnexo.Origen_Id)
LEFT JOIN comCondFiscal  ON (comCondFiscal.comCondFiscal = comMovpAnexo.CondFiscal_Id)
LEFT JOIN genProvincias ON comProvAnexo.Provincia_Id = genProvincias.genProvincias
WHERE 
	comMovpAnexo.Asiento_Id = IsNull(@pAsiento_Id,comMovpAnexo.Asiento_Id) and 
	comMovpAnexo.tesRengMovi_Id = IsNull(@pTesMovimientos,comMovpAnexo.tesRengMovi_Id) and
	comMovpAnexo.RenglonRengMovi = IsNull(@pRenglonRengMovi, comMovpAnexo.RenglonRengMovi)
ORDER BY 2,3

SELECT commovpanexoDetalle.Asiento_id, commovpanexoDetalle.Renglon, 
	conCuentas.Cuenta_id, conCuentas.Descripcion as DescripcionCuenta, 
	conCentro1.Centro1_id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_id, conCentro2.Descripcion as DescripcionCentro2,
	conBaseDistri.Base_id, conBaseDistri.Descripcion as DescripcionBase,
	commovpanexoDetalle.Importe, comMovpAnexo.RenglonRengMovi
FROM 
	commovpanexoDetalle INNER JOIN comMovpAnexo ON commovpanexoDetalle.Asiento_id =comMovpAnexo.Asiento_id
	INNER JOIN conCuentas ON commovpanexoDetalle.Cuenta_Id = conCuentas.conCuentas
	INNER JOIN conCentro1 ON commovpanexoDetalle.Centro1_Id = conCentro1.conCentro1
	INNER JOIN conCentro2 ON commovpanexoDetalle.Centro2_Id = conCentro2.conCentro2
	left outer join conBaseDistri ON commovpanexoDetalle.Base_id = conBaseDistri.conBaseDistri 
WHERE	
	comMovpAnexo.Asiento_Id = IsNull(@pAsiento_Id,comMovpAnexo.Asiento_Id) and 
	comMovpAnexo.tesRengMovi_Id = IsNull(@pTesMovimientos,comMovpAnexo.tesRengMovi_Id) and
	comMovpAnexo.RenglonRengMovi = IsNull(@pRenglonRengMovi, comMovpAnexo.RenglonRengMovi)
ORDER BY 1,2

EXEC comMovProvAnexoImpDatos @pAsiento_id, @pTesMovimientos, @pRenglonRengMovi

 
RETURN @@Error 

GO

DROP PROCEDURE comMovpAnexoEliminar
GO
CREATE PROCEDURE comMovpAnexoEliminar
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

DELETE FROM comMovpAnexo 
WHERE (Asiento_Id = @pAsiento_Id)
 
RETURN @@Error 

GO


DROP PROCEDURE comMovpAnexoEliminarTes
GO
CREATE PROCEDURE comMovpAnexoEliminarTes
(
@pTesMovimientos bigint=null,
@pRenglonRengMovi int=null
)
AS
SET NOCOUNT ON 

DELETE FROM comMovpAnexo 
WHERE 
	tesRengMovi_id = @pTesMovimientos and 
	RenglonRengMovi  = @pRenglonRengMovi
 
RETURN @@Error 

GO
