DROP PROCEDURE impCfdiMetaDatosGuardar
GO
CREATE PROCEDURE impCfdiMetaDatosGuardar
(
@pUuid char(36),
@pRfcEmisor varchar(13),
@pNombreEmisor varchar(200),
@pRfcReceptor varchar(13),
@pNombreReceptor varchar(200) = NULL,
@pRfcPac varchar(13),
@pFechaEmision datetime,
@pFechaCertificacionSat datetime,
@pMonto numeric(18,2),
@pEfectoComprobante char(1),
@pEstatus bit,
@pFechaCancelacion datetime = NULL,
@pFechaDescarga datetime,
@pUsuario_Id int, 
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impCfdiMetaDatos WHERE (Uuid = @pUuid)))
BEGIN 
	UPDATE impCfdiMetaDatos
	SET		RfcEmisor = @pRfcEmisor,
		NombreEmisor = @pNombreEmisor,
		RfcReceptor = @pRfcReceptor,
		NombreReceptor = @pNombreReceptor,
		RfcPac = @pRfcPac,
		FechaEmision = @pFechaEmision,
		FechaCertificacionSat = @pFechaCertificacionSat,
		Monto = @pMonto,
		EfectoComprobante = @pEfectoComprobante,
		Estatus = @pEstatus,
		FechaCancelacion = @pFechaCancelacion,
		FechaDescarga = @pFechaDescarga,
		Usuario_Id = @pUsuario_Id, 
		Empresa_Id = @pEmpresa_Id
	WHERE (Uuid = @pUuid)
END 
ELSE 
BEGIN 
	INSERT INTO impCfdiMetaDatos
	(
		Uuid,
		RfcEmisor,
		NombreEmisor,
		RfcReceptor,
		NombreReceptor,
		RfcPac,
		FechaEmision,
		FechaCertificacionSat,
		Monto,
		EfectoComprobante,
		Estatus,
		FechaCancelacion,
		FechaDescarga,
		Usuario_Id, 
		Empresa_Id
	)
	VALUES 
	(
		@pUuid,
		@pRfcEmisor,
		@pNombreEmisor,
		@pRfcReceptor,
		@pNombreReceptor,
		@pRfcPac,
		@pFechaEmision,
		@pFechaCertificacionSat,
		@pMonto,
		@pEfectoComprobante,
		@pEstatus,
		@pFechaCancelacion,
		@pFechaDescarga,
		@pUsuario_Id, 
		@pEmpresa_Id
	)
END 

GO

DROP PROCEDURE impCfdiMetaDatosDatos
GO
CREATE PROCEDURE impCfdiMetaDatosDatos
(
@pUuid char(36)
)
AS
SET NOCOUNT ON 

SELECT impCfdiMetaDatos.Uuid, impCfdiMetaDatos.RfcEmisor, impCfdiMetaDatos.NombreEmisor, impCfdiMetaDatos.RfcReceptor,
	impCfdiMetaDatos.NombreReceptor, impCfdiMetaDatos.RfcPac, impCfdiMetaDatos.FechaEmision, impCfdiMetaDatos.FechaCertificacionSat,
	impCfdiMetaDatos.Monto, impCfdiMetaDatos.EfectoComprobante, impCfdiMetaDatos.Estatus, impCfdiMetaDatos.FechaCancelacion,
	impCfdiMetaDatos.FechaDescarga, genUsuarios.Usuario_Id,  impCfdiMetaDatos.Empresa_Id
FROM impCfdiMetaDatos 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = impCfdiMetaDatos.Usuario_Id)
WHERE (Uuid = @pUuid)
 
 RETURN @@Error 

GO

DROP PROCEDURE impCfdiMetaDatosEliminar
GO
CREATE PROCEDURE impCfdiMetaDatosEliminar
(
@pUuid char(36) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impCfdiMetaDatos 
WHERE (Uuid = ISNULL(@pUuid, Uuid))
 
 RETURN @@Error 

GO


DROP PROCEDURE impCfdiMetaDatosEliminarxFecha
GO
CREATE PROCEDURE impCfdiMetaDatosEliminarxFecha
(
	@pFechaDesde DateTime, 
	@pFechaHasta DateTime,
	@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM impCfdiMetaDatos 
WHERE FechaEmision Between @pFechaDesde AND @pFechaHasta AND 
	Empresa_Id = @pEmpresa_Id
 
 RETURN @@Error 

GO

