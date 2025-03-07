DROP PROCEDURE comCFDISatGuardar
GO
CREATE PROCEDURE comCFDISatGuardar
(
@pUUID char(36),
@pEmpresa_Id int,
@pRFCEmisor char(13),
@pFecha datetime,
@pMonto numeric(18,2),
@pFolio VarChar(25),
@pSerie varchar(100),
@pSubido bit,
@pXML varchar(max) = NULL,
@pUsuario int = NULL,
@pFechaCarga datetime = NULL,
@pTipoComprobante char
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comCFDISat WHERE (UUID = @pUUID)))
BEGIN 
	UPDATE comCFDISat
	SET		Empresa_Id = @pEmpresa_Id,
		RFCEmisor = @pRFCEmisor,
		Fecha = @pFecha,
		Monto = @pMonto,
		Folio = @pFolio,
		Serie = @pSerie,
		Subido = @pSubido,
		XML = @pXML,
		Usuario = @pUsuario,
		FechaCarga = @pFechaCarga,
		TipoDeComprobante=@pTipoComprobante
	WHERE (UUID = @pUUID)
END 
ELSE 
BEGIN 
	INSERT INTO comCFDISat
	(
		UUID,
		Empresa_Id,
		RFCEmisor,
		Fecha,
		Monto,
		Folio,
		Serie,
		Subido,
		XML,
		Usuario,
		FechaCarga,
		TipoDeComprobante
	)
	VALUES 
	(
		@pUUID,
		@pEmpresa_Id,
		@pRFCEmisor,
		@pFecha,
		@pMonto,
		@pFolio,
		@pSerie,
		@pSubido,
		@pXML,
		@pUsuario,
		@pFechaCarga,
		@pTipoComprobante
	)
END 

GO

DROP PROCEDURE comCFDISatDatos
GO
CREATE PROCEDURE comCFDISatDatos
(
@pUUID char(36)
)
AS
SET NOCOUNT ON 

SELECT comCFDISat.UUID, comCFDISat.Empresa_Id, comCFDISat.RFCEmisor, comCFDISat.Fecha,
	comCFDISat.Monto, comCFDISat.Folio, comCFDISat.Serie, comCFDISat.Subido,
	comCFDISat.XML, comCFDISat.Usuario, comCFDISat.FechaCarga, '' as Upload, TipoDeComprobante
FROM comCFDISat 
WHERE (UUID = @pUUID)
 exec comCFDISatPagoDatos @pUUID, null
 RETURN @@Error 

GO

DROP PROCEDURE comCFDISatEliminar
GO
CREATE PROCEDURE comCFDISatEliminar
(
@pUUID char(36) 
)
AS
SET NOCOUNT ON 

DELETE FROM comCFDISat 
WHERE (UUID = @pUUID)
 
 RETURN @@Error 

GO

DROP PROCEDURE comCFDISatDatosRango
GO
CREATE PROCEDURE comCFDISatDatosRango
(
 @pFechaDesde datetime,
 @pFechaHasta datetime,
 @pRFCEmisorDesde varchar(20),
 @pRFCEmisorHasta varchar(20)
)
AS
SET NOCOUNT ON 

select @pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta, @pRFCEmisorDesde as RFCDesde, @pRFCEmisorHasta as RFCHasta
SELECT comCFDISat.UUID, comCFDISat.Empresa_Id, comCFDISat.RFCEmisor, comCFDISat.Fecha,
	comCFDISat.Monto, comCFDISat.Folio, comCFDISat.Serie, comCFDISat.Subido,
	--comCFDISat.XML, comento el xml por que quedaba muy pesado el paquete
	 comCFDISat.Usuario, comCFDISat.FechaCarga, TipoDeComprobante, cast (0 as bit) as Marca
FROM comCFDISat 
WHERE (Fecha between @pFechaDesde and @pFechaHasta) and RFCEmisor between @pRFCEmisorDesde and @pRFCEmisorHasta and Subido=0
 RETURN @@Error 

GO
