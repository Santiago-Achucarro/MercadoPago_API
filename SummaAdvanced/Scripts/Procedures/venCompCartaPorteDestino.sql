DROP PROCEDURE venCompCartaPorteDestinoGuardar
GO
CREATE PROCEDURE venCompCartaPorteDestinoGuardar
(
@pvenmovimientos bigint,
@pUbicacion int,
@pidDestino int,
@pRFCDestinatario varchar(14) = NULL,
@pNombreDestinatario varchar(254) = NULL,
@pNumRegIdTrib varchar(40) = NULL,
@pResidenciaFiscal smallint = NULL,
@pNumEstacion varchar(6) = NULL,
@pNombreEstacion varchar(50) = NULL,
@pNavegacionTrafico varchar(8) = NULL,
@pFechaHoraProgLlegada datetime,
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
IF (EXISTS (SELECT 1 FROM venCompCartaPorteDestino WHERE (venmovimientos = @pvenmovimientos) AND (Ubicacion = @pUbicacion) AND (idDestino = @pidDestino)))
BEGIN 
	UPDATE venCompCartaPorteDestino
	SET		RFCDestinatario = @pRFCDestinatario,
		NombreDestinatario = @pNombreDestinatario,
		NumRegIdTrib = @pNumRegIdTrib,
		ResidenciaFiscal = dbo.FuncFKgenPaises(@pResidenciaFiscal),
		NumEstacion = @pNumEstacion,
		NombreEstacion = @pNombreEstacion,
		NavegacionTrafico = @pNavegacionTrafico,
		FechaHoraProgLlegada = @pFechaHoraProgLlegada,
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
	WHERE (venmovimientos = @pvenmovimientos) AND (Ubicacion = @pUbicacion) AND (idDestino = @pidDestino)
END 
ELSE 
BEGIN 
	INSERT INTO venCompCartaPorteDestino
	(
		venmovimientos,
		Ubicacion,
		idDestino,
		RFCDestinatario,
		NombreDestinatario,
		NumRegIdTrib,
		ResidenciaFiscal,
		NumEstacion,
		NombreEstacion,
		NavegacionTrafico,
		FechaHoraProgLlegada,
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
		@pidDestino,
		@pRFCDestinatario,
		@pNombreDestinatario,
		@pNumRegIdTrib,
		dbo.FuncFKgenPaises(@pResidenciaFiscal),
		@pNumEstacion,
		@pNombreEstacion,
		@pNavegacionTrafico,
		@pFechaHoraProgLlegada,
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

DROP PROCEDURE venCompCartaPorteDestinoDatos
GO
CREATE PROCEDURE venCompCartaPorteDestinoDatos
(
@pvenmovimientos bigint,
@pUbicacion int = NULL,
@pidDestino int = NULL
)
AS
SET NOCOUNT ON 

SELECT venCompCartaPorteDestino.venmovimientos, venCompCartaPorteDestino.Ubicacion, venCompCartaPorteDestino.idDestino,
	venCompCartaPorteDestino.RFCDestinatario, venCompCartaPorteDestino.NombreDestinatario, venCompCartaPorteDestino.NumRegIdTrib, genPaises.Pais_Id ResidenciaFiscal,
	venCompCartaPorteDestino.NumEstacion, venCompCartaPorteDestino.NombreEstacion, venCompCartaPorteDestino.NavegacionTrafico,
	venCompCartaPorteDestino.FechaHoraProgLlegada, venCompCartaPorteDestino.Calle, venCompCartaPorteDestino.NumeroExterior, 
	venCompCartaPorteDestino.Numerointerior, venCompCartaPorteDestino.Colonia, venCompCartaPorteDestino.Localidad, 
	venCompCartaPorteDestino.Referencia, venCompCartaPorteDestino.Municipio,
	venCompCartaPorteDestino.Estado, genPaises2.Pais_Id, venCompCartaPorteDestino.CodigoPostal
FROM venCompCartaPorteDestino 
INNER JOIN venCompCartaPorteUbi  ON (venCompCartaPorteUbi.venmovimientos = venCompCartaPorteDestino.venmovimientos) AND (venCompCartaPorteUbi.Ubicacion = venCompCartaPorteDestino.Ubicacion)
LEFT JOIN genPaises  ON (genPaises.genPaises = venCompCartaPorteDestino.ResidenciaFiscal)
LEFT JOIN genPaises genPaises2 ON (genPaises2.genPaises = venCompCartaPorteDestino.Pais)
WHERE (venCompCartaPorteDestino.venmovimientos = @pvenmovimientos)
AND (venCompCartaPorteDestino.Ubicacion = ISNULL(@pUbicacion,venCompCartaPorteDestino.Ubicacion))
AND (venCompCartaPorteDestino.idDestino = ISNULL(@pidDestino,venCompCartaPorteDestino.idDestino))
 
RETURN @@Error 

GO

DROP PROCEDURE venCompCartaPorteDestinoEliminar
GO
CREATE PROCEDURE venCompCartaPorteDestinoEliminar
(
@pvenmovimientos bigint,
@pUbicacion int = NULL,
@pidDestino int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCompCartaPorteDestino 
WHERE (venmovimientos = @pvenmovimientos)
AND (Ubicacion = ISNULL(@pUbicacion,Ubicacion))
AND (idDestino = ISNULL(@pidDestino, idDestino))
 
 RETURN @@Error 

GO

