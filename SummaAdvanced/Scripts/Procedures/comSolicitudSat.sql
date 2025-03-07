DROP PROCEDURE comSolicitudesSatGuardar
GO
CREATE PROCEDURE comSolicitudesSatGuardar
(
@pSolicitud int,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pEmpresa_Id int = NULL,
@pEmitidos bit = NULL,
@pDescargados bit = NULL,
@pFecha datetime = NULL,
@pUsuario_Id int = NULL,
@pSolicitud_Sat varchar(max),
@pRespuestaSat varchar(100),
@pMetaDatos bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comSolicitudesSat WHERE (Solicitud = @pSolicitud)))
BEGIN 
	UPDATE comSolicitudesSat
	SET		FechaDesde = @pFechaDesde,
		FechaHasta = @pFechaHasta,
		Empresa_Id = @pEmpresa_Id,
		Emitidos = @pEmitidos,
		Descargados = @pDescargados,
		Fecha = @pFecha,
		Usuario_Id = @pUsuario_Id,
		SolicitudSat=@pSolicitud_Sat,
		UltimaRespuestaSat=@pRespuestaSat, 
		MetaDatos = @pMetaDatos
	WHERE (Solicitud = @pSolicitud)
END 
ELSE 
BEGIN 
	INSERT INTO comSolicitudesSat
	(
		FechaDesde,
		FechaHasta,
		Empresa_Id,
		Emitidos,
		Descargados,
		Fecha,
		Usuario_Id,
		SolicitudSat,
		UltimaRespuestaSat,
		MetaDatos
	)
	VALUES 
	(
		@pFechaDesde,
		@pFechaHasta,
		@pEmpresa_Id,
		@pEmitidos,
		@pDescargados,
		@pFecha,
		@pUsuario_Id,
		@pSolicitud_Sat,
		@pRespuestaSat,
		@pMetaDatos
	)

	SET @pSolicitud =  Cast(SCOPE_IDENTITY() as bigint) 
END 
Select @pSolicitud as RetVal 

GO

DROP PROCEDURE comSolicitudesSatDatos
GO
CREATE PROCEDURE comSolicitudesSatDatos
(
@pSolicitud int,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT comSolicitudesSat.Solicitud, comSolicitudesSat.FechaDesde, comSolicitudesSat.FechaHasta, comSolicitudesSat.Solicitud Solicitud_Nueva,
	comSolicitudesSat.Empresa_Id, comSolicitudesSat.Emitidos, comSolicitudesSat.Descargados,
	comSolicitudesSat.Fecha, comSolicitudesSat.Usuario_Id, cast(0 as bit) as Pendiente, SolicitudSat, 
	comSolicitudesSat.MetaDatos, cast(0 as bit) as Nueva
FROM comSolicitudesSat 
WHERE (Solicitud = @pSolicitud)

SELECT comSolicitudesSat.Solicitud, SolicitudSat, comSolicitudesSat.FechaDesde, comSolicitudesSat.FechaHasta, 
	comSolicitudesSat.Emitidos,comSolicitudesSat.Metadatos,
	comSolicitudesSat.Fecha, genUsuarios.Usuario_Id, cast(0 as bit) as Pendiente,UltimaRespuestaSat
	FROM comSolicitudesSat
	inner join genUsuarios on genUsuarios=comSolicitudesSat.Usuario_Id
	where comSolicitudesSat.Descargados=0 and comSolicitudesSat.Empresa_Id=@pEmpresa_Id
 RETURN @@Error 

GO

DROP PROCEDURE comSolicitudesSatEliminar
GO
CREATE PROCEDURE comSolicitudesSatEliminar
(
@pSolicitud int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comSolicitudesSat 
WHERE (Solicitud = ISNULL(@pSolicitud, Solicitud))
 
 RETURN @@Error 

GO

GO


DROP PROCEDURE comSolicitudesSatDatosXEmpresa
GO
CREATE PROCEDURE comSolicitudesSatDatosXEmpresa
(
@pEmpresa_Id int,
@pPendientes sino
)
AS
SET NOCOUNT ON 

SELECT comSolicitudesSat.Solicitud, comSolicitudesSat.FechaDesde, comSolicitudesSat.FechaHasta, comSolicitudesSat.Solicitud Solicitud_Nueva,
	comSolicitudesSat.Empresa_Id, comSolicitudesSat.Emitidos, comSolicitudesSat.Descargados,
	comSolicitudesSat.Fecha, comSolicitudesSat.Usuario_Id, cast(0 as bit) as Pendiente, SolicitudSat, 
	comSolicitudesSat.MetaDatos, cast(0 as bit) as Nueva
FROM comSolicitudesSat 
WHERE (Solicitud = @pEmpresa_Id and 
	(@pPendientes=1 or Descargados=0))

SELECT comSolicitudesSat.Solicitud, SolicitudSat, comSolicitudesSat.FechaDesde, comSolicitudesSat.FechaHasta, 
	comSolicitudesSat.Emitidos, comSolicitudesSat.Metadatos,
	comSolicitudesSat.Fecha, genUsuarios.Usuario_Id, cast(1-comSolicitudesSat.Descargados as bit) as Pendiente,UltimaRespuestaSat
	FROM comSolicitudesSat
	inner join genUsuarios on genUsuarios=comSolicitudesSat.Usuario_Id
	where 
	(comSolicitudesSat.Descargados=0 or @pPendientes=0) and 
	comSolicitudesSat.Empresa_Id=@pEmpresa_Id
	-- and comSolicitudesSat.Fecha>dateadd(DD,-7,GETDATE()) 
 RETURN @@Error 

GO

