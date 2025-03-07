DROP PROCEDURE venCompCartaPorteOrigenGuardar
GO
CREATE PROCEDURE venCompCartaPorteOrigenGuardar
(
@pvenmovimientos bigint,
@pUbicacion int,
@pidOrigen int,
@pRFCRemitente varchar(14) = NULL,
@pNombreRemitente varchar(254) = NULL,
@pNumRegIdTrib varchar(40) = NULL,
@pResidenciaFiscal smallint = NULL,
@pNumEstacion varchar(6) = NULL,
@pNombreEstacion varchar(50) = NULL,
@pNavegacionTrafico varchar(8) = NULL,
@pFechaHoraSalida datetime,
@pCalle varchar(100),
@pNumeroExterior varchar(30) = NULL,
@pNumerointerior varchar(30) = NULL,
@pColonia varchar(120) = NULL,
@pLocalidad varchar(120) = NULL,
@pReferencia varchar(100) = NULL,
@pMunicipio varchar(120) = NULL,
@pEstado varchar(30) = NULL,
@pPais smallint = NULL,
@pCodigoPostal varchar(20) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCompCartaPorteOrigen WHERE (venmovimientos = @pvenmovimientos) AND (Ubicacion = @pUbicacion) AND (idOrigen = @pidOrigen)))
BEGIN 
	UPDATE venCompCartaPorteOrigen
	SET		RFCRemitente = @pRFCRemitente,
		NombreRemitente = @pNombreRemitente,
		NumRegIdTrib = @pNumRegIdTrib,
		ResidenciaFiscal = dbo.FuncFKgenPaises(@pResidenciaFiscal),
		NumEstacion = @pNumEstacion,
		NombreEstacion = @pNombreEstacion,
		NavegacionTrafico = @pNavegacionTrafico,
		FechaHoraSalida = @pFechaHoraSalida,
		Calle = @pCalle,
		NumeroExterior = @pNumeroExterior,
		Numerointerior = @pNumerointerior,
		Colonia = @pColonia,
		Localidad = @pLocalidad,
		Referencia = @pReferencia,
		Municipio = @pMunicipio,
		Estado = @pEstado,
		Pais = dbo.FuncFKgenPaises(@pPais),
		CodigoPostal = @pCodigoPostal
	WHERE (venmovimientos = @pvenmovimientos) AND (Ubicacion = @pUbicacion) AND (idOrigen = @pidOrigen)
END 
ELSE 
BEGIN 
	INSERT INTO venCompCartaPorteOrigen
	(
		venmovimientos,
		Ubicacion,
		idOrigen,
		RFCRemitente,
		NombreRemitente,
		NumRegIdTrib,
		ResidenciaFiscal,
		NumEstacion,
		NombreEstacion,
		NavegacionTrafico,
		FechaHoraSalida,
		Calle,
		NumeroExterior,
		Numerointerior,
		Colonia,
		Localidad,
		Referencia,
		Municipio,
		Estado,
		Pais,
		CodigoPostal
	)
	VALUES 
	(
		@pvenmovimientos,
		@pUbicacion,
		@pidOrigen,
		@pRFCRemitente,
		@pNombreRemitente,
		@pNumRegIdTrib,
		dbo.FuncFKgenPaises(@pResidenciaFiscal),
		@pNumEstacion,
		@pNombreEstacion,
		@pNavegacionTrafico,
		@pFechaHoraSalida,
		@pCalle,
		@pNumeroExterior,
		@pNumerointerior,
		@pColonia,
		@pLocalidad,
		@pReferencia,
		@pMunicipio,
		@pEstado,
		dbo.FuncFKgenPaises(@pPais),
		@pCodigoPostal
	)
END 

GO

DROP PROCEDURE venCompCartaPorteOrigenDatos
GO
CREATE PROCEDURE venCompCartaPorteOrigenDatos
(
@pvenmovimientos bigint,
@pUbicacion int = null,
@pidOrigen int = null
)
AS
SET NOCOUNT ON 

SELECT venCompCartaPorteOrigen.venmovimientos, venCompCartaPorteOrigen.Ubicacion, venCompCartaPorteOrigen.idOrigen,
	venCompCartaPorteOrigen.RFCRemitente, venCompCartaPorteOrigen.NombreRemitente, venCompCartaPorteOrigen.NumRegIdTrib, genPaises.Pais_Id AS ResidenciaFiscal,
	venCompCartaPorteOrigen.NumEstacion, venCompCartaPorteOrigen.NombreEstacion, venCompCartaPorteOrigen.NavegacionTrafico,
	venCompCartaPorteOrigen.FechaHoraSalida, venCompCartaPorteOrigen.Calle, venCompCartaPorteOrigen.NumeroExterior, venCompCartaPorteOrigen.Numerointerior,
	venCompCartaPorteOrigen.Colonia, venCompCartaPorteOrigen.Localidad, venCompCartaPorteOrigen.Referencia, venCompCartaPorteOrigen.Municipio,
	venCompCartaPorteOrigen.Estado, genPaises2.Pais_Id, venCompCartaPorteOrigen.CodigoPostal
FROM venCompCartaPorteOrigen 
INNER JOIN venCompCartaPorteUbi  ON (venCompCartaPorteUbi.venmovimientos = venCompCartaPorteOrigen.venmovimientos) AND (venCompCartaPorteUbi.Ubicacion = venCompCartaPorteOrigen.Ubicacion)
LEFT JOIN genPaises  ON (genPaises.genPaises = venCompCartaPorteOrigen.ResidenciaFiscal)
LEFT JOIN genPaises genPaises2 ON (genPaises2.genPaises = venCompCartaPorteOrigen.Pais)
WHERE (venCompCartaPorteOrigen.venmovimientos = @pvenmovimientos)
AND (venCompCartaPorteOrigen.Ubicacion = ISNULL(@pUbicacion,venCompCartaPorteOrigen.Ubicacion))
AND (venCompCartaPorteOrigen.idOrigen = ISNULL(@pidOrigen,venCompCartaPorteOrigen.idOrigen))
 
RETURN @@Error 

GO

DROP PROCEDURE venCompCartaPorteOrigenEliminar
GO
CREATE PROCEDURE venCompCartaPorteOrigenEliminar
(
@pvenmovimientos bigint,
@pUbicacion int = NULL,
@pidOrigen int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCompCartaPorteOrigen 
WHERE (venmovimientos = @pvenmovimientos)
AND (Ubicacion = ISNULL(@pUbicacion,Ubicacion))
AND (idOrigen = ISNULL(@pidOrigen, idOrigen))
 
RETURN @@Error 

GO
