DROP PROCEDURE impRetCFDIPremiosGuardar
GO
CREATE PROCEDURE impRetCFDIPremiosGuardar
(
@pimpRetencionesCFDI int,
@pProvincia_id varchar(5) = NULL,
@pMontTotPago numeric(18,4),
@pMontTotPagoGrav numeric(18,4),
@pMontTotPagoExent numeric(18,4)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIPremios WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIPremios
	SET		Provincia_id = dbo.FuncFKgenProvincias(@pProvincia_id),
		MontTotPago = @pMontTotPago,
		MontTotPagoGrav = @pMontTotPagoGrav,
		MontTotPagoExent = @pMontTotPagoExent
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIPremios
	(
		impRetencionesCFDI,
		Provincia_id,
		MontTotPago,
		MontTotPagoGrav,
		MontTotPagoExent
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		dbo.FuncFKgenProvincias(@pProvincia_id),
		@pMontTotPago,
		@pMontTotPagoGrav,
		@pMontTotPagoExent
	)
END 

GO

DROP PROCEDURE impRetCFDIPremiosDatos
GO
CREATE PROCEDURE impRetCFDIPremiosDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIPremios.impRetencionesCFDI, genProvincias.Provincia_id, 
	genProvincias.Descripcion as DescripcionProvincia,
	impRetCFDIPremios.MontTotPago,
	impRetCFDIPremios.MontTotPagoGrav, impRetCFDIPremios.MontTotPagoExent
FROM impRetCFDIPremios left join genProvincias ON 
impRetCFDIPremios.Provincia_id = genProvincias.genProvincias
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIPremiosEliminar
GO
CREATE PROCEDURE impRetCFDIPremiosEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIPremios 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

