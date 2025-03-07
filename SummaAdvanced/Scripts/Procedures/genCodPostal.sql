DROP PROCEDURE genCodPostalGuardar
GO
CREATE PROCEDURE genCodPostalGuardar
(
@pCodigoPostal varchar(10),
@pEstado varchar(3),
@pMunicipio varchar(3),
@pLocalidad varchar(2),
@pFranjaFonteriza bit,
@pCodigoUso varchar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genCodPostal WHERE (CodigoPostal = @pCodigoPostal)))
BEGIN 
	UPDATE genCodPostal
	SET		Estado = @pEstado,
		Municipio = @pMunicipio,
		Localidad = @pLocalidad,
		FranjaFonteriza = @pFranjaFonteriza,
		CodigoUso = @pCodigoUso
	WHERE (CodigoPostal = @pCodigoPostal)
END 
ELSE 
BEGIN 
	INSERT INTO genCodPostal
	(
		CodigoPostal,
		Estado,
		Municipio,
		Localidad,
		FranjaFonteriza,
		CodigoUso
	)
	VALUES 
	(
		@pCodigoPostal,
		@pEstado,
		@pMunicipio,
		@pLocalidad,
		@pFranjaFonteriza,
		@pCodigoUso
	)
END 

GO

DROP PROCEDURE genCodPostalDatos
GO
CREATE PROCEDURE genCodPostalDatos
(
@pCodigoPostal varchar(10)
)
AS
SET NOCOUNT ON 

SELECT genCodPostal.CodigoPostal, genCodPostal.Estado, genCodPostal.Municipio, genCodPostal.Localidad,
	genCodPostal.FranjaFonteriza, genCodPostal.CodigoUso, genProvincias.Provincia_Id
FROM genCodPostal
		left join genProvincias on genProvincias.CodFiscal = genCodPostal.Estado
WHERE (CodigoPostal = @pCodigoPostal)
 
RETURN @@Error 

GO

DROP PROCEDURE genCodPostalEliminar
GO
CREATE PROCEDURE genCodPostalEliminar
(
@pCodigoPostal varchar(10) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genCodPostal 
WHERE (CodigoPostal = ISNULL(@pCodigoPostal, CodigoPostal))
 
 RETURN @@Error 

GO

