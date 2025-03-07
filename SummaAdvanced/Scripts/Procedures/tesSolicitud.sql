DROP PROCEDURE tesSolicitudGuardar
GO
CREATE PROCEDURE tesSolicitudGuardar
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pSolicitante_Id VarChar(5),
@pCausa varchar(max) = NULL,
@pFecha datetime,
@pMonto qMonedaD2,
@pEstado char(1),
@pUsuarioAutorizo varchar(25) = NULL,
@pFechaAutorizo datetime = NULL,
@pUsuario_Id int,
@pFechaCarga datetime, 
@pCartera_Id VarChar(5)
)
AS
SET NOCOUNT ON 
DECLARE @ptesSolicitud bigint

SET @ptesSolicitud = (SELECT tesSolicitud
	FROM tesSolSegmentos WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C))

IF (@ptesSolicitud is not null)


BEGIN 
	UPDATE tesSolicitud
	SET	
		Causa = @pCausa,
		Fecha = @pFecha,
		Monto = @pMonto,
		Estado = @pEstado,
		UsuarioAutorizo = dbo.FuncFKgenUsuarios(@pUsuarioAutorizo),
		FechaAutorizo = @pFechaAutorizo,
		Usuario_Id = @pUsuario_Id,
		FechaCarga = @pFechaCarga, 
		Solicitante_Id = dbo.FuncFKtesSolicitantes(@pSolicitante_Id), 
		Cartera_Id = dbo.FuncFKtesIdentifica(@pCartera_Id)
	WHERE 
		tesSolicitud = @ptesSolicitud
END 
ELSE 
BEGIN 
	INSERT INTO tesSolicitud
	(
		Solicitante_Id,
		Causa,
		Fecha,
		Monto,
		Estado,
		UsuarioAutorizo,
		FechaAutorizo,
		Usuario_Id,
		FechaCarga, 
		Cartera_Id
	)
	VALUES 
	(
		dbo.FuncFKtesSolicitantes(@pSolicitante_Id),
		@pCausa,
		@pFecha,
		@pMonto,
		@pEstado,
		dbo.FuncFKgenUsuarios(@pUsuarioAutorizo),
		@pFechaAutorizo,
		@pUsuario_Id,
		@pFechaCarga, 
		dbo.FuncFKtesIdentifica(@pCartera_Id)
	)
	SET @ptesSolicitud =  Cast(SCOPE_IDENTITY() as bigint) 
END 
Select @ptesSolicitud as RetVal 

GO

DROP PROCEDURE tesSolicitudDatos
GO
CREATE PROCEDURE tesSolicitudDatos
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)

AS
SET NOCOUNT ON 

SELECT tesSolicitud.tesSolicitud, 
	genSegmentos.Segmento_Id, tesSolSegmentos.Segmento1C, tesSolSegmentos.Segmento2C, 
	tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, 
	tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N, 
	tesSolSegmentos.Segmento4N,
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre as DescripcionSolicitantes, tesSolicitud.Causa,
	tesSolicitud.Fecha, tesSolicitud.Monto, tesSolicitud.Estado, genUsuarios.Usuario_Id as UsuarioAutorizo,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAutorizo, tesSolicitud.FechaAutorizo, 
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario,
	tesSolicitud.FechaCarga, tesidentifica.Cartera_id, tesIdentifica.Descripcion as DescripcionCartera, 
	ISNULL((SELECT sum(conMovCont.importe*(-2*conMovCont.Tipomov+3)) from conMovcont inner join tesSolRendicion on
		conMovcont.conAsientos = tesSolRendicion.tesMovimientos and 
		tesSolRendicion.tesSolicitud = tesSolicitud.tesSolicitud 
		INNER JOIN tesRengMovi ON
		tesRengMovi.tesMovimientos = conMovCont.conAsientos and 
		tesRengMovi.conRenglon = conMovCont.Renglon and 
		tesRengMovi.TipomovCont = 1 
		INNER JOIN conAsientos ON
		conAsientos.conAsientos = conMovCont.conAsientos and
		conAsientos.Posteado = 1 AND
		conAsientos.Anulado = 0 ),0) as Rendido
	
FROM tesSolicitud 
INNER JOIN tesSolicitantes  ON (tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = tesSolicitud.UsuarioAutorizo)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesSolicitud.Usuario_Id)
INNER JOIN tesSolSegmentos ON tesSolSegmentos.tesSolicitud = tesSolicitud.tesSolicitud
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = tesSolSegmentos.Segmento_Id
INNER JOIN tesIdentifica ON  tesIdentifica.tesIdentifica = tesSolicitud.Cartera_Id
WHERE  
	genSegmentos.Segmento_Id = @pSegmento_Id and 
	tesSolSegmentos.Segmento1C = @pSegmento1C and 
	tesSolSegmentos.Segmento2C = @pSegmento2C and 
	tesSolSegmentos.Segmento3C = @pSegmento3C and  
	tesSolSegmentos.Segmento4C = @pSegmento4C and
	tesSolSegmentos.Segmento1N = @pSegmento1N and 
	tesSolSegmentos.Segmento2N = @pSegmento2N and 
	tesSolSegmentos.Segmento3N = @pSegmento3N and
	tesSolSegmentos.Segmento4N = @pSegmento4N and 
	tesSolSegmentos.Empresa_Id = @pEmpresa_Id

 
 RETURN @@Error 

GO

DROP PROCEDURE tesSolicitudEliminar
GO
CREATE PROCEDURE tesSolicitudEliminar
(
	@ptesSolicitud bigint
)
AS
SET NOCOUNT ON 

DELETE FROM tesSolicitud 
WHERE   tesSolicitud = @ptesSolicitud
RETURN @@Error 

GO
-- tesSolicitudParaAutorizar 1
DROP PROCEDURE tesSolicitudParaAutorizar
GO
CREATE PROCEDURE tesSolicitudParaAutorizar
(
	@pEmpresa_Id INT
)

AS

SELECT @pEmpresa_Id as Empresa

SELECT tesSolicitud.Estado, tesSolicitud.tesSolicitud, 
	dbo.Segmento(tesSolSegmentos.Segmento_Id, tesSolSegmentos.Segmento1C, tesSolSegmentos.Segmento2C, 
	tesSolSegmentos.Segmento3C, tesSolSegmentos.Segmento4C, 
	tesSolSegmentos.Segmento1N, tesSolSegmentos.Segmento2N, tesSolSegmentos.Segmento3N, 
	tesSolSegmentos.Segmento4N) as SegmentoSTR,
	tesSolicitantes.Solicitante_Id, tesSolicitantes.Nombre as DescripcionSolicitantes, 
	tesSolicitud.Causa,	tesSolicitud.Fecha, tesSolicitud.Monto, 
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario,
	tesSolicitud.FechaCarga
FROM tesSolicitud 
INNER JOIN tesSolicitantes  ON (tesSolicitantes.genEntidades = tesSolicitud.Solicitante_Id)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = tesSolicitud.Usuario_Id)
INNER JOIN tesSolSegmentos ON tesSolSegmentos.tesSolicitud = tesSolicitud.tesSolicitud
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = tesSolSegmentos.Segmento_Id
Where
	tesSolicitud.Estado = 'P' AND 
	tesSolSegmentos.Empresa_Id = @pEmpresa_Id
GO

DROP PROCEDURE tesSolicitudCambiarEstado
GO
CREATE PROCEDURE tesSolicitudCambiarEstado(
	@ptesSolicitud bigint, 
	@pUsuario int, 
	@pEstado Char(1)
	)
	AS

	Update tesSolicitud SET Estado = @pEstado, UsuarioAutorizo = @pUsuario, 
		FechaAutorizo = dbo.FechaActual() 
		Where
			tesSolicitud = @ptesSolicitud
GO
