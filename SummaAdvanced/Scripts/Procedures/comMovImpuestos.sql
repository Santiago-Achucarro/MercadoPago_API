DROP PROCEDURE comMovImpuestosGuardar
GO
CREATE PROCEDURE comMovImpuestosGuardar
(
@pcomMovProv bigint,
@pconRenglon int,
@pImpuesto_Id varchar(5),
@pPorcentaje qPorcentaje,
@pBase_Imponible qMonedaD2,
@pImporte_Impuesto qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comMovImpuestos WHERE (comMovProv = @pcomMovProv) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE comMovImpuestos
	SET	Impuesto_Id = dbo.FuncFKcomImpuestos(@pImpuesto_Id),
		Porcentaje = @pPorcentaje,
		Base_Imponible = @pBase_Imponible,
		Importe_Impuesto = @pImporte_Impuesto
	WHERE (comMovProv = @pcomMovProv) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comMovImpuestos
	(
		comMovProv,
		conRenglon,
		Impuesto_Id,
		Porcentaje,
		Base_Imponible,
		Importe_Impuesto
	)
	VALUES 
	(
		@pcomMovProv,
		@pconRenglon,
		dbo.FuncFKcomImpuestos(@pImpuesto_Id),
		@pPorcentaje,
		@pBase_Imponible,
		@pImporte_Impuesto
	)
END 

GO

DROP PROCEDURE comMovImpuestosDatos
GO
CREATE PROCEDURE comMovImpuestosDatos
(
@pcomMovProv bigint,
@pconRenglon int= null
)
AS
SET NOCOUNT ON 

SELECT comMovImpuestos.comMovProv, comMovImpuestos.conRenglon, 
	comImpuestos.Impuesto_Id, comImpuestos.Descripcion as DescripcionImpuesto,
	comMovImpuestos.Porcentaje, 
	comMovImpuestos.Base_Imponible, comMovImpuestos.Importe_Impuesto,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.TipoMov, conMovCont.Clase, conMovCont.Importe as ImporteContable
 FROM 
	comMovImpuestos INNER JOIN conMovCont ON
	comMovImpuestos.comMovprov =conMovCont.conAsientos and 
	comMovImpuestos.conRenglon = conMovCont.Renglon 
	INNER JOIN comImpuestos ON 
	comImpuestos.comImpuestos = comMovImpuestos.Impuesto_id
	INNER JOIN conCuentas ON 
	conCuentas.conCuentas = conMovCont.cuenta_id 
	LEFT OUTER JOIN conCentro1 ON 
	conCentro1.conCentro1 = conMovCont.Centro1_id
	LEFT OUTER JOIN conCentro2 ON 
	conCentro2.conCentro2 = conMovCont.Centro2_id
	Where 
	comMovImpuestos.conRenglon = IsNull(@pconRenglon, comMovImpuestos.conRenglon) AND 
	comMovImpuestos.comMovProv = @pcomMovProv
ORDER BY 2 
RETURN @@Error 

GO

DROP PROCEDURE comMovImpuestosEliminar
GO
CREATE PROCEDURE comMovImpuestosEliminar
(
@pcomMovProv bigint,
@pconRenglon int= null
)
AS
SET NOCOUNT ON 

DELETE FROM comMovImpuestos 
WHERE (comMovProv = @pcomMovProv) AND (conRenglon = IsNull(@pconRenglon, comMovImpuestos.conRenglon))
 
 RETURN @@Error 

GO

