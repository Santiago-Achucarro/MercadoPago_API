DROP PROCEDURE comMovProvAnexoImpInsertar
GO
CREATE PROCEDURE comMovProvAnexoImpInsertar
(
@pAsiento_Id bigint,
@pconRenglon int,
@pImpuesto_Id varchar(5),
@pPorcentaje qPorcentaje,
@pBase_Imponible qMonedaD2,
@pImporte_Impuesto qMonedaD2
)
AS
BEGIN 
	INSERT INTO comMovProvAnexoImp
	(
		Asiento_Id,
		conRenglon,
		Impuesto_Id,
		Porcentaje,
		Base_Imponible,
		Importe_Impuesto
	)
	VALUES 
	(
		@pAsiento_Id,
		@pconRenglon,
		dbo.FuncFKcomImpuestos(@pImpuesto_Id),
		@pPorcentaje,
		@pBase_Imponible,
		@pImporte_Impuesto
	)
END 

GO

DROP PROCEDURE comMovProvAnexoImpDatos
GO
CREATE PROCEDURE comMovProvAnexoImpDatos
(
@pAsiento_Id bigint=null,
@ptesMovimientos bigint=null,
@pconRenglon int=null
)
AS
SET NOCOUNT ON 

SELECT comMovProvAnexoImp.Asiento_Id, comMovpAnexo.tesRengMovi_Id as tesMovimientos , comMovProvAnexoImp.conRenglon, 
	comImpuestos.Impuesto_Id, comImpuestos.Descripcion as DescripcionImpuestos, comMovProvAnexoImp.Porcentaje,
	comMovProvAnexoImp.Base_Imponible, comMovProvAnexoImp.Importe_Impuesto, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta, 
	conCentro1.Centro1_id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_id, conCentro2.Descripcion as DescripcionCentro2
FROM comMovProvAnexoImp 
INNER JOIN comMovpAnexo  ON (comMovpAnexo.Asiento_Id = comMovProvAnexoImp.Asiento_Id)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = comMovProvAnexoImp.Asiento_Id) AND (conMovCont.Renglon = comMovProvAnexoImp.conRenglon)
INNER JOIN comImpuestos  ON (comImpuestos.comImpuestos = comMovProvAnexoImp.Impuesto_Id)
LEFT OUTER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
LEFT OUTER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
LEFT OUTER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
WHERE 
comMovpAnexo.Asiento_Id = ISNULL(@pAsiento_Id, comMovpAnexo.Asiento_Id) and 
comMovpAnexo.RenglonRengMovi = ISNULL(@pconRenglon, comMovpAnexo.RenglonRengMovi) and
comMovpAnexo.tesRengMovi_id = ISNULL(@pTesMovimientos, comMovpAnexo.tesRengMovi_id)

 
RETURN @@Error 

GO

DROP PROCEDURE comMovProvAnexoImpEliminar
GO
CREATE PROCEDURE comMovProvAnexoImpEliminar
(
@pAsiento_Id bigint,
@pconRenglon int=NULL
)
AS
SET NOCOUNT ON 


DELETE FROM comMovProvAnexoImp  WHERE 
(comMovProvAnexoImp.Asiento_Id = @pAsiento_Id) AND 
(comMovProvAnexoImp.conRenglon = IsNull(@pconRenglon,comMovProvAnexoImp.conRenglon))
 
RETURN @@Error 

GO

GO
