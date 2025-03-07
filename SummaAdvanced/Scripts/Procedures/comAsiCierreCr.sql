DROP PROCEDURE comAsiCierreCrGuardar
GO
CREATE PROCEDURE comAsiCierreCrGuardar
(
@pAsiento_Id bigint,
@pconRenglon int,
@pProveed_id VarChar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comAsiCierreCr WHERE (Asiento_Id = @pAsiento_Id) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE comAsiCierreCr
	SET		Proveed_id = dbo.FuncFKcomProveedores(@pProveed_id)
	WHERE (Asiento_Id = @pAsiento_Id) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO comAsiCierreCr
	(
		Asiento_Id,
		conRenglon,
		Proveed_id
	)
	VALUES 
	(
		@pAsiento_Id,
		@pconRenglon,
		dbo.FuncFKcomProveedores(@pProveed_id)
	)
END 

GO

DROP PROCEDURE comAsiCierreCrDatos
GO
CREATE PROCEDURE comAsiCierreCrDatos
(
@pAsiento_Id bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

SELECT 
	comAsiCierre.Asiento_Id, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores,
	comAsiCierreCr.conRenglon, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2,
	conMovCont.LeyendaLibroMayor, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal, conMovCont.Tipomov,
	conMovCont.Clase
FROM comAsiCierreCr 
INNER JOIN comAsiCierre  ON (comAsiCierre.Asiento_Id = comAsiCierreCr.Asiento_Id)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = comAsiCierreCr.Asiento_Id) AND (conMovCont.Renglon = comAsiCierreCr.conRenglon)
INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = comAsiCierreCr.Asiento_Id) AND (conMovCont2.Renglon = comAsiCierreCr.conRenglon)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comAsiCierreCr.Proveed_id)
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
INNER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
WHERE comAsiCierreCr.Asiento_Id = @pAsiento_Id AND		
comAsiCierreCr.conRenglon = IsNull(@pconRenglon, comAsiCierreCr.conRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE comAsiCierreCrEliminar
GO
CREATE PROCEDURE comAsiCierreCrEliminar
(
@pAsiento_Id bigint,
@pconRenglon int=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comAsiCierreCr 
WHERE Asiento_Id = @pAsiento_Id AND 
comAsiCierreCr.conRenglon = IsNull(@pconRenglon, comAsiCierreCr.conRenglon)
 
RETURN @@Error 

GO

