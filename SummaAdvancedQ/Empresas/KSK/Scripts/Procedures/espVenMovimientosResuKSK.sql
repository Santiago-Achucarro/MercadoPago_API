DROP PROCEDURE espVenMovimientosResuKSKGuardar
GO
CREATE PROCEDURE espVenMovimientosResuKSKGuardar
(
@pvenMovimientos bigint,
@pCantidad numeric(18,4),
@pMedida_Id varchar(5),
@pLeyenda  VarChar(Max),
@pValorUnitario numeric(18,4),
@pClaveFiscal varchar(8)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espVenMovimientosResuKSK WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE espVenMovimientosResuKSK
	SET		Cantidad = @pCantidad,
		Leyenda = @pLeyenda,
		Medida_Id = dbo.FuncFKstkUniMed(@pMedida_Id),
		ValorUnitario = @pValorUnitario,
		ClaveFiscal = @pClaveFiscal
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO espVenMovimientosResuKSK
	(
		venMovimientos,
		Cantidad,
		Medida_Id,
		Leyenda,
		ValorUnitario,
		ClaveFiscal
	)
	VALUES 
	(
		@pvenMovimientos,
		@pCantidad,
		dbo.FuncFKstkUniMed(@pMedida_Id),
		@pLeyenda,
		@pValorUnitario,
		@pClaveFiscal
	)
END 

GO

DROP PROCEDURE espVenMovimientosResuKSKDatos
GO
CREATE PROCEDURE espVenMovimientosResuKSKDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT espVenMovimientosResuKSK.venMovimientos, espVenMovimientosResuKSK.Cantidad, stkUniMed.Medida_Id,
		espVenMovimientosResuKSK.Leyenda, espVenMovimientosResuKSK.ValorUnitario, espVenMovimientosResuKSK.ClaveFiscal
FROM espVenMovimientosResuKSK 
INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = espVenMovimientosResuKSK.Medida_Id)
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE espVenMovimientosResuKSKEliminar
GO
CREATE PROCEDURE espVenMovimientosResuKSKEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM espVenMovimientosResuKSK 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

