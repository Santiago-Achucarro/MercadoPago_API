DROP PROCEDURE impRetCFDISecFinanGuardar
GO
CREATE PROCEDURE impRetCFDISecFinanGuardar
(
@pimpRetencionesCFDI int,
@pIdFideicom varchar(20),
@pNomFideicom varchar(100),
@pDescripFideicom varchar(300)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impRetCFDISecFinan WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)))
BEGIN 
	UPDATE impRetCFDISecFinan
	SET		IdFideicom = @pIdFideicom,
		NomFideicom = @pNomFideicom,
		DescripFideicom = @pDescripFideicom
	WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
END 
ELSE 
BEGIN 
	INSERT INTO impRetCFDISecFinan
	(
		impRetencionesCFDI,
		IdFideicom,
		NomFideicom,
		DescripFideicom
	)
	VALUES 
	(
		@pimpRetencionesCFDI,
		@pIdFideicom,
		@pNomFideicom,
		@pDescripFideicom
	)
END 

GO

DROP PROCEDURE impRetCFDISecFinanDatos
GO
CREATE PROCEDURE impRetCFDISecFinanDatos
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

SELECT impRetCFDISecFinan.impRetencionesCFDI, impRetCFDISecFinan.IdFideicom, impRetCFDISecFinan.NomFideicom,
	impRetCFDISecFinan.DescripFideicom
FROM impRetCFDISecFinan 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO

DROP PROCEDURE impRetCFDISecFinanEliminar
GO
CREATE PROCEDURE impRetCFDISecFinanEliminar
(
@pimpRetencionesCFDI int
)
AS
SET NOCOUNT ON 

DELETE FROM impRetCFDISecFinan 
WHERE (impRetencionesCFDI = @pimpRetencionesCFDI)
 
 RETURN @@Error 

GO
