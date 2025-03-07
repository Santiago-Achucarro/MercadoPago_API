DROP PROCEDURE venAsiCierreCrGuardar
GO
CREATE PROCEDURE venAsiCierreCrGuardar
(
@pAsiento_Id bigint,
@pconRenglon int,
@pCliente_Id VarChar(15)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venAsiCierreCr WHERE (Asiento_Id = @pAsiento_Id) AND (conRenglon = @pconRenglon)))
BEGIN 
	UPDATE venAsiCierreCr
	SET		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id)
	WHERE (Asiento_Id = @pAsiento_Id) AND (conRenglon = @pconRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO venAsiCierreCr
	(
		Asiento_Id,
		conRenglon,
		Cliente_Id
	)
	VALUES 
	(
		@pAsiento_Id,
		@pconRenglon,
		dbo.FuncFKvenClientes(@pCliente_Id)
	)
END 

GO

DROP PROCEDURE venAsiCierreCrDatos
GO
CREATE PROCEDURE venAsiCierreCrDatos
(
@pAsiento_Id bigint,
@pconRenglon int= NULL
)
AS
SET NOCOUNT ON 

SELECT 
	venAsiCierre.Asiento_Id, 
	venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionProveedores,
	venAsiCierreCr.conRenglon, 
	conCuentas.Cuenta_Id, conCuentas.Descripcion DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2,
	conMovCont.LeyendaLibroMayor, conMovCont.Importe, 
	conMovCont.ImporteMonedaOriginal, conMovCont.Tipomov,
	conMovCont.Clase
FROM venAsiCierreCr 
INNER JOIN venAsiCierre  ON (venAsiCierre.Asiento_Id = venAsiCierreCr.Asiento_Id)
INNER JOIN conMovCont  ON (conMovCont.conAsientos = venAsiCierreCr.Asiento_Id) AND (conMovCont.Renglon = venAsiCierreCr.conRenglon)
INNER JOIN conMovCont conMovCont2 ON (conMovCont2.conAsientos = venAsiCierreCr.Asiento_Id) AND (conMovCont2.Renglon = venAsiCierreCr.conRenglon)
INNER JOIN venClientes  ON (venClientes.genEntidades = venAsiCierreCr.Cliente_Id)
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_id
INNER JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_id
WHERE venAsiCierreCr.Asiento_Id = @pAsiento_Id AND		
venAsiCierreCr.conRenglon = IsNull(@pconRenglon, venAsiCierreCr.conRenglon)
 
RETURN @@Error 

GO

DROP PROCEDURE venAsiCierreCrEliminar
GO
CREATE PROCEDURE venAsiCierreCrEliminar
(
@pAsiento_Id bigint,
@pconRenglon int=NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venAsiCierreCr 
WHERE Asiento_Id = @pAsiento_Id AND 
venAsiCierreCr.conRenglon = IsNull(@pconRenglon, venAsiCierreCr.conRenglon)
 
RETURN @@Error 

GO

