DROP PROCEDURE impRetCFDIOperConDerivGuardar
GO
CREATE PROCEDURE impRetCFDIOperConDerivGuardar
(
@pimpRetencionesCFDI int,
@pMontGanAcum numeric(18,4),
@pMontPerdDed numeric(18,4)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDIOperConDeriv WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDIOperConDeriv
	SET		MontGanAcum = @pMontGanAcum,
		MontPerdDed = @pMontPerdDed
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDIOperConDeriv
	(
		impRetencionesCFDI,
		MontGanAcum,
		MontPerdDed
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pMontGanAcum,
		@pMontPerdDed
	)
END 

GO

DROP PROCEDURE impRetCFDIOperConDerivDatos
GO
CREATE PROCEDURE impRetCFDIOperConDerivDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDIOperConDeriv.impRetencionesCFDI, impRetCFDIOperConDeriv.MontGanAcum, impRetCFDIOperConDeriv.MontPerdDed
FROM impRetCFDIOperConDeriv 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDIOperConDerivEliminar
GO
CREATE PROCEDURE impRetCFDIOperConDerivEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDIOperConDeriv 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO
