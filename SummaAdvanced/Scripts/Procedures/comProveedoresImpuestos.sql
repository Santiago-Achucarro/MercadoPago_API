DROP PROCEDURE comProveedoresImpuestosInsertar
GO
CREATE PROCEDURE comProveedoresImpuestosInsertar
(
@pProveed_Id bigint,
@pImpuesto_Id VarChar(5)
)
AS
BEGIN 
	INSERT INTO comProveedoresImpuestos
	(
		Proveed_Id,
		Impuesto_Id
	)
	VALUES 
	(
		@pProveed_Id,
		 dbo.FuncFKcomImpuestos(@pImpuesto_Id)
	)
END 

GO

DROP PROCEDURE comProveedoresImpuestosDatos
GO
CREATE PROCEDURE comProveedoresImpuestosDatos
(
@pProveed_Id VarChar(15),
@pImpuesto_Id VarChar(5)=NULL
)
AS
SET NOCOUNT ON 

SELECT comProveedores.genEntidades , comProveedores.Proveed_Id,  
	comImpuestos.Impuesto_Id, comImpuestos.Descripcion as DescripcionImpuestos, 
		comImpuestos.Depende_De, impTipoImpuesto.CodigoFiscal, 
		comImpuestos.Fecha_Desde, comImpuestos.Fecha_Hasta,
			comImpuestos.Porcentaje, comImpuestos.FormulaCalc,
			comImpuestos.VaAlCosto, 
			conCuentas.Cuenta_id as CuentaDebe, conCuentas.Descripcion as DescricpionCtaDebe,
			CtaCredito.Cuenta_id as CuentaHaber, CtaCredito.Descripcion as DescricpionCuentaCtaHaber
FROM comProveedoresImpuestos 
INNER JOIN comProveedores ON  comProveedores.genEntidades = comProveedoresImpuestos.Proveed_Id
INNER JOIN comImpuestos  ON (comImpuestos.comImpuestos = comProveedoresImpuestos.Impuesto_Id)
INNER JOIN impTipoImpuesto ON  impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
LEFT OUTER JOIN conCuentas ON conCuentas.conCuentas = comImpuestos.CtaDebe
LEFT OUTER JOIN conCuentas CtaCredito ON CtaCredito.conCuentas = comImpuestos.CtaHaber
WHERE 
comProveedores.Proveed_Id = @pProveed_Id AND
ComImpuestos.Impuesto_Id = ISNULL(@pImpuesto_Id ,ComImpuestos.Impuesto_Id)
 
RETURN @@Error 

GO


DROP PROCEDURE comProveedoresImpuestosEliminar
GO
CREATE PROCEDURE comProveedoresImpuestosEliminar
(
@pProveed_Id bigint ,
@pImpuesto_Id VarChar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comProveedoresImpuestos 
WHERE 
Proveed_Id = @pProveed_Id AND 
(@pImpuesto_Id IS NULL OR Impuesto_Id = dbo.FuncFKcomImpuestos(@pImpuesto_Id))
 
 RETURN @@Error 

GO

GO
