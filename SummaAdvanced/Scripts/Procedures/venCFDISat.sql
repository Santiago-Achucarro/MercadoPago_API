DROP PROCEDURE venCFDISatGuardar
GO
CREATE PROCEDURE venCFDISatGuardar
(
@pUUID char(36),
@pEmpresa_Id int = NULL,
@pRFCReceptor char(13) = NULL,
@pFecha datetime = NULL,
@pMonto numeric(18,9) = NULL,
@pImpuestos numeric(18,9) = NULL,
@pFolio bigint = NULL,
@pSerie varchar(100) = NULL,
@pXML varchar(max) = NULL,
@pUsuario int = NULL,
@pFechaCarga datetime = NULL,
@pTipoComprobante Char(1) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venCFDISat WHERE (UUID = @pUUID)))
BEGIN 
	UPDATE venCFDISat
	SET		Empresa_Id = @pEmpresa_Id,
		RFCReceptor = @pRFCReceptor,
		Fecha = @pFecha,
		Monto = @pMonto,
		Impuestos = @pImpuestos,
		Folio = @pFolio,
		Serie =ISNULL(@pSerie,''),
		XML = @pXML,
		Usuario = @pUsuario,
		FechaCarga = @pFechaCarga,
		TipoComprobante = @pTipoComprobante
	WHERE (UUID = @pUUID)
END 
ELSE 
BEGIN 
	INSERT INTO venCFDISat
	(
		UUID,
		Empresa_Id,
		RFCReceptor,
		Fecha,
		Monto,
		Impuestos,
		Folio,
		Serie,
		XML,
		Usuario,
		FechaCarga,
		TipoComprobante
	)
	VALUES 
	(
		@pUUID,
		@pEmpresa_Id,
		@pRFCReceptor,
		@pFecha,
		@pMonto,
		@pImpuestos,
		@pFolio,
		ISNULL(@pSerie,''),
		@pXML,
		@pUsuario,
		@pFechaCarga,
		@pTipoComprobante
	)
END 

GO

DROP PROCEDURE venCFDISatDatos
GO
CREATE PROCEDURE venCFDISatDatos
(
@pUUID char(36)
)
AS
SET NOCOUNT ON 

SELECT venCFDISat.UUID,  venCFDISat.Empresa_Id, venCFDISat.RFCReceptor, venCFDISat.Fecha, 
	venCFDISat.Monto, venCFDISat.Impuestos,
	venCFDISat.Folio, venCFDISat.Serie, venCFDISat.XML, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCFDISat.FechaCarga, 
	venCFDISat.TipoComprobante
FROM venCFDISat 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCFDISat.Usuario)
WHERE (UUID = @pUUID)
 
RETURN @@Error 

GO

DROP PROCEDURE venCFDISatEliminar
GO
CREATE PROCEDURE venCFDISatEliminar
(
@pUUID char(36) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCFDISat 
WHERE (UUID = ISNULL(@pUUID, UUID))
 
 RETURN @@Error 

GO

