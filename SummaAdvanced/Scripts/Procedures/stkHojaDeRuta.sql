DROP PROCEDURE stkHojaDeRutaGuardar
GO
CREATE PROCEDURE stkHojaDeRutaGuardar
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pUsuario_Id int = NULL,
@pFechaRegistro qFechaHora,
@pvenReparto int = NULL,
@pFormaEntrega_Id VarChar(5) = NULL,
@pPatente_Id varchar(20) = NULL,
@pPatenteAcoplado varchar(20) = NULL, 
@pChofer VarChar(100)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentity int = (Select stkHojaDeRuta
 From stkHojaSegmentos
 Where
	stkHojaSegmentos.Empresa_Id = @pEmpresa_Id and 
	stkHojaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	stkHojaSegmentos.Segmento1N = @pSegmento1N and 
	stkHojaSegmentos.Segmento2N = @pSegmento2N and 
	stkHojaSegmentos.Segmento3N = @pSegmento3N and 
	stkHojaSegmentos.Segmento4N = @pSegmento4N and 
	stkHojaSegmentos.Segmento1C = @pSegmento1C and 
	stkHojaSegmentos.Segmento2C = @pSegmento2C and 
	stkHojaSegmentos.Segmento3C = @pSegmento3C and 
	stkHojaSegmentos.Segmento4C = @pSegmento4C )

IF (@lIdentity IS NOT NULL)
BEGIN 
	UPDATE stkHojaDeRuta
	SET
		Empresa_Id = @pEmpresa_Id,
		Usuario_Id = @pUsuario_Id,
		FechaRegistro = @pFechaRegistro,
		venReparto = @pvenReparto,
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		Patente_Id = dbo.FuncFKvenCamiones(@pPatente_Id),
		PatenteAcoplado = dbo.FuncFKvenCamiones(@pPatenteAcoplado), 
		Chofer  = @pChofer
	WHERE stkHojaDeRuta = @lIdentity
END 
ELSE 
BEGIN 
	INSERT INTO stkHojaDeRuta
	(
		Empresa_Id,
		Usuario_Id,
		FechaRegistro,
		venReparto,
		FormaEntrega_Id,
		Patente_Id,
		PatenteAcoplado, 
		Estado ,
		Chofer
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pUsuario_Id,
		@pFechaRegistro,
		@pvenReparto,
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		dbo.FuncFKvenCamiones(@pPatente_Id),
		dbo.FuncFKvenCamiones(@pPatenteAcoplado),
		'A', 
		@pChofer
	)
	SET @lIdentity =  Cast(SCOPE_IDENTITY() as int) 
END 
SELECT @lIdentity AS RetVal 
GO

DROP PROCEDURE stkHojaDeRutaIdentity
GO
CREATE PROCEDURE stkHojaDeRutaIdentity
(
@lIdentity int
)
AS
SET NOCOUNT ON 

SELECT stkHojaDeRuta.stkHojaDeRuta, stkHojaDeRuta.Empresa_Id, genSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1N,
	stkHojaSegmentos.Segmento2N,stkHojaSegmentos.Segmento3N,stkHojaSegmentos.Segmento4N,
	stkHojaSegmentos.Segmento1C, stkHojaSegmentos.Segmento2C,stkHojaSegmentos.Segmento3C,
	stkHojaSegmentos.Segmento4C, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	stkHojaDeRuta.FechaRegistro, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial ForEntregaRazonSocial,
	venCamiones.Patente_Id, venCamiones.Descripcion as DescripcionCamiones,
	venCamiones2.Patente_Id PatenteAcoplado, venCamiones2.Descripcion as DescripcionAcoplado,
	dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C,
	venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, 
	venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) Reparto, stkHojaDeRuta.venReparto Reparto_Id,
	'' ClienteDesde, '' RazonSocialClieD, 'ZZZZZZZZZZZZZZZ' ClienteHasta, '' RazonSocialClieH,
	'' ZonaDesde, '' DescripcionZonaD, 'ZZZZZ' ZonaHasta, '' DescripcionZonaH,
	'' RegionDesde, '' DescripcionRegionD, 'ZZZZZ' RegionHasta, '' DescripcionRegionH,
	'' TipoClieDesde, '' DescripcionTipoClieD, 'ZZZZZ' TipoClieHasta, '' DescripcionTipoClieH,
	'' FormaDesde, '' DescripcionFormaD, 'ZZZ' FormaHasta,  '' DescripcionFormaH,
	' ' SucursalDesde, 'ZZZZ' SucursalHasta,
	Cast(0 As bit) FiltroXFecha, dbo.FechaActual() FechaDesde, dbo.FechaActual() FechaHasta, 
	stkHojaDeRuta.Estado, stkHojaDeRuta.Chofer, Cast(0 as bit) as ReporteDetallado
FROM stkHojaDeRuta 
LEFT JOIN genUsuarios ON (genUsuarios.genUsuarios = stkHojaDeRuta.Usuario_Id)
LEFT JOIN venReparto  ON (venReparto.venReparto = stkHojaDeRuta.venReparto)
LEFT JOIN venCamiones ON (venCamiones.venCamiones = stkHojaDeRuta.Patente_Id)
LEFT JOIN venCamiones venCamiones2 ON (venCamiones2.venCamiones = stkHojaDeRuta.PatenteAcoplado)
LEFT JOIN venFormaEntrega On venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
Inner Join stkHojaSegmentos On stkHojaSegmentos.stkHojaDeRuta = stkHojaDeRuta.stkHojaDeRuta
INNER JOIN genSegmentos ON stkHojaSegmentos.Segmento_Id = genSegmentos.genSegmentos
Left Join venRepaSegmentos On venRepaSegmentos.venReparto = stkHojaDeRuta.venReparto
WHERE stkHojaDeRuta.stkHojaDeRuta = @lIdentity

Exec genAtributosGeneralesIdentityDatos @lIdentity, 'stkHojaDeRuta'
RETURN @@Error 
GO


DROP PROCEDURE stkHojaDeRutaDatos
GO
CREATE PROCEDURE stkHojaDeRutaDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
As

Declare @pIdentity int= (select stkHojaDeRuta From stkHojaSegmentos
	Where
	stkHojaSegmentos.Empresa_id = @pEmpresa_id and 
	stkHojaSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	stkHojaSegmentos.Segmento1N = @pSegmento1N and 
	stkHojaSegmentos.Segmento2N = @pSegmento2N and 
	stkHojaSegmentos.Segmento3N = @pSegmento3N and 
	stkHojaSegmentos.Segmento4N = @pSegmento4N and 
	stkHojaSegmentos.Segmento1C = @pSegmento1C and 
	stkHojaSegmentos.Segmento2C = @pSegmento2C and 
	stkHojaSegmentos.Segmento3C = @pSegmento3C and 
	stkHojaSegmentos.Segmento4C = @pSegmento4C)

Exec stkHojaDeRutaIdentity @pIdentity

Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, stkRemitos.stkMoviCabe,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
ISNULL(venClientes.Cliente_Id,'') Cliente_Id, ISNULL(venClientes.RazonSocial,'') RazonSocial, 
ISNULL(venFormaEntrega.FormaEntrega_Id,'') FormaEntrega_Id, 
ISNULL(venFormaEntrega.RazonSocial,'') ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 1 as bit ) Marcado,
ISNULL(stkHojaDeRuta.Patente_id,'') Patente_id, ISNULL(stkHojaDeRuta.PatenteAcoplado,'') PatenteAcoplado, Cast(0 as numeric(19,2)) Total
From stkHojaDeRuta
Inner Join stkRemitos On stkRemitos.HojaRuta_Id = stkHojaDeRuta.stkHojaDeRuta
Inner Join conAsientos On conAsientos.conAsientos = stkRemitos.stkMoviCabe
LEFT JOIN (venClientes INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades) ON
venClientes.genEntidades = stkRemitos.Cliente_Id AND venClieHabitual.Sucursal = stkRemitos.Sucursal
LEFT JOIN venFormaEntrega On venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
Inner Join venRegion On venRegion.venRegion = venClieHabitual.Region_Id
Inner Join venZona On venZona.venZona = venClieHabitual.Zona_Id
Where stkHojaDeRuta.stkHojaDeRuta = @pIdentity
UNION ALL
Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, venMovimientos.venMovimientos,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
ISNULL(venClientes.Cliente_Id,'') Cliente_Id, ISNULL(venClientes.RazonSocial,'') RazonSocial, 
ISNULL(venFormaEntrega.FormaEntrega_Id,'') FormaEntrega_Id, 
ISNULL(venFormaEntrega.RazonSocial,'') ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 1 as bit ) Marcado,
ISNULL(stkHojaDeRuta.Patente_id,'') Patente_id, ISNULL(stkHojaDeRuta.PatenteAcoplado,'') PatenteAcoplado, Cast(0 as numeric(19,2)) Total
From stkHojaDeRuta
Inner Join stkHojaDeRutaCuerpo On stkHojaDeRutaCuerpo.stkHojaDeRuta = stkHojaDeRuta.stkHojaDeRuta
Inner Join venMovimientos ON venMovimientos.venMovimientos = stkHojaDeRutaCuerpo.conAsientos
Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
LEFT JOIN (venClientes INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades) ON
venClientes.genEntidades = venMovimientos.Cliente_Id AND venClieHabitual.Sucursal = venMovimientos.Sucursal
LEFT JOIN venFormaEntrega On venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
Inner Join venRegion On venRegion.venRegion = venClieHabitual.Region_Id
Inner Join venZona On venZona.venZona = venClieHabitual.Zona_Id
Where stkHojaDeRuta.stkHojaDeRuta = @pIdentity

GO


-- stkHojaDeRutaPendientes 1, 'RUT',0,0,0,0,' ',' ',' ',' ','RUT',' ',' ',' ','ZZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZZ',1,'20200701','20200810'
DROP PROCEDURE stkHojaDeRutaPendientes
GO
CREATE PROCEDURE stkHojaDeRutaPendientes
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pFormaEntrega_Id VarChar(5) = NULL,
@pPatente_Id varChar(20),
@pPatenteAcoplado varChar(20) = null,
@pClienteDesde varChar(15),
@pClienteHasta varChar(15),
@pZonaDesde varChar(5),
@pZonaHasta varChar(5),
@pRegionDesde varChar(5),
@pRegionHasta varChar(5),
@pTipoClieDesde varChar(5),
@pTipoClieHasta varChar(5),
@pFormaDesde varChar(5),
@pFormaHasta varChar(5),
@pFiltroXFecha bit,
@pFechaHoraDesde Datetime = null,
@pFechaHoraHasta Datetime = null, 
@pSucursalDesde Varchar(4),
@pSucursalHasta Varchar(4)
)
As

Declare @pIdentity int= (select stkHojaDeRuta From stkHojaSegmentos
	Where
	stkHojaSegmentos.Empresa_id = @pEmpresa_id and 
	stkHojaSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	stkHojaSegmentos.Segmento1N = @pSegmento1N and 
	stkHojaSegmentos.Segmento2N = @pSegmento2N and 
	stkHojaSegmentos.Segmento3N = @pSegmento3N and 
	stkHojaSegmentos.Segmento4N = @pSegmento4N and 
	stkHojaSegmentos.Segmento1C = @pSegmento1C and 
	stkHojaSegmentos.Segmento2C = @pSegmento2C and 
	stkHojaSegmentos.Segmento3C = @pSegmento3C and 
	stkHojaSegmentos.Segmento4C = @pSegmento4C)

Exec stkHojaDeRutaIdentity @pIdentity

-- Primero los que ya existen y luego los que quiera agragar //
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, stkHojaDeRutaCuerpo.conAsientos stkMoviCabe,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
isnull(venClientes.Cliente_Id, venClientesF.Cliente_Id) Cliente_Id , 
isnull(venClientes.RazonSocial, venClientesF.RazonSocial) AS  RazonSocial, 
ISNULL(venFormaEntrega.FormaEntrega_Id,'') FormaEntrega_Id, 
ISNULL(venFormaEntrega.RazonSocial,'') ForEntregaRazonSocial, venTiposClie.TipoClie_Id, 
venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 1 as bit ) Marcado, 
ISNULL(stkHojaDeRuta.Patente_id,'') Patente_id, ISNULL(stkHojaDeRuta.PatenteAcoplado,'') PatenteAcoplado, 
Cast(0 as numeric(19,2)) Total
FROM stkHojaDeRuta
INNER JOIN stkHojaDeRutaCuerpo ON stkHojaDeRutaCuerpo.stkHojaDeRuta = stkHojaDeRuta.stkHojaDeRuta
INNER JOIN conAsientos ON conAsientos.conAsientos = stkHojaDeRutaCuerpo.conAsientos
LEFT JOIN (stkRemitos 
		INNER JOIN venClientes  ON 	venClientes.genEntidades = stkRemitos.Cliente_Id 
		INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades AND 
									   venClieHabitual.Sucursal = stkRemitos.Sucursal
		) ON stkRemitos.stkMoviCabe = stkHojaDeRutaCuerpo.conAsientos
LEFT JOIN (venMovimientos INNER JOIN venClientes venClientesF  ON 	venClientesF.genEntidades = venMovimientos.Cliente_Id 
		INNER JOIN venClieHabitual venClieHabitualF ON venClientesF.genEntidades = venClieHabitualF.genEntidades AND 
									   venClieHabitualF.Sucursal = venMovimientos.Sucursal
		) ON venMovimientos.venMovimientos = stkHojaDeRutaCuerpo.conAsientos

LEFT JOIN venFormaEntrega On venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
INNER JOIN genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkHojaDeRutaCuerpo.conasientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
LEFT JOIN venTiposClie On venTiposClie.venTiposClie = isnull(venClieHabitual.TipoClie_Id, venClieHabitualF.TipoClie_Id)
LEFT JOIN venRegion On venRegion.venRegion = ISNULL(venClieHabitual.Region_Id, venClieHabitualF.Region_Id)
LEFT JOIN venZona On venZona.venZona = ISNULL(venClieHabitual.Zona_Id,venClieHabitualF.Zona_Id)
WHERE stkHojaDeRuta.stkHojaDeRuta = @pIdentity
UNION ALL
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, stkRemitos.stkMoviCabe,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
venClientes.Cliente_Id, venClientes.RazonSocial, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 0 as bit ) Marcado, 
'' Patente_id, '' PatenteAcoplado, Cast(0 as numeric(19,2)) Total
FROM stkRemitos
INNER JOIN conAsientos ON conAsientos.conAsientos = stkRemitos.stkMoviCabe
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
LEFT JOIN (venClientes INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades) ON
venClientes.genEntidades = stkRemitos.Cliente_Id AND venClieHabitual.Sucursal = stkRemitos.Sucursal
LEFT JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = ISNULL(stkRemitos.FormaEntrega_Id, venClieHabitual.FormaEntrega_Id)
LEFT JOIN venTiposClie ON venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
LEFT JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
LEFT JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE stkRemitos.HojaRuta_Id IS NULL AND conAsientos.Empresa_Id = @pEmpresa_Id AND
ISNULL(venClientes.Cliente_Id,'') Between @pClienteDesde And @pClienteHasta And
ISNULL(venZona.Zona_Id,'') Between @pZonaDesde And @pZonaHasta And
ISNULL(venRegion.Region_Id,'') Between @pRegionDesde And @pRegionHasta And
ISNULL(venTiposClie.TipoClie_Id,'') Between @pTipoClieDesde And @pTipoClieHasta And
ISNULL(venFormaEntrega.FormaEntrega_Id,'') Between @pFormaDesde And @pFormaHasta And
conAsientos.Fecha Between IsNull(@pFechaHoraDesde, conAsientos.Fecha) AND
IsNull(@pFechaHoraHasta, conAsientos.Fecha) 
and  venFormaEntrega.ExcluirDelReparto = 0  /* falta la forma de entrega en la remision */
and genSucursalesEmpr.Sucursal Between @pSucursalDesde and @pSucursalHasta
UNION ALL -- Facturas que no tienen Remito
SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, venMovimientos.venMovimientos stkMoviCabe,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
venClientes.Cliente_Id, venClientes.RazonSocial, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 0 as bit ) Marcado,
'' Patente_id, '' PatenteAcoplado, Cast(0 as numeric(19,2)) Total
FROM venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
inner join genSegmentos on genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venMovimientos.Cliente_Id AND 
							  venClieHabitual.Sucursal = venMovimientos.Sucursal
LEFT JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venMovimientos.FormaEntrega_Id
LEFT JOIN venTiposClie ON venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
LEFT JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
LEFT JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE 
venMovimientos.venTipoMov = 'F' AND 
NOT EXISTS(SELECT 1 FROM stkHojaDeRutaCuerpo WHERE stkHojaDeRutaCuerpo.conAsientos = venMovimientos.venMovimientos) and
NOT EXISTS(SELECT 1 FROM stkRemitos, venMovStkHist WHERE venMovStkHist.venMovimientos = venMovimientos.venMovimientos AND 
	venMovStkHist.stkMoviCabe = stkRemitos.stkMoviCabe) and
conAsientos.Empresa_Id = @pEmpresa_Id AND
ISNULL(venClientes.Cliente_Id,'') Between @pClienteDesde And @pClienteHasta And
ISNULL(venZona.Zona_Id,'') Between @pZonaDesde And @pZonaHasta And
ISNULL(venRegion.Region_Id,'') Between @pRegionDesde And @pRegionHasta And
ISNULL(venTiposClie.TipoClie_Id,'') Between @pTipoClieDesde And @pTipoClieHasta And
ISNULL(venFormaEntrega.FormaEntrega_Id,'') Between @pFormaDesde And @pFormaHasta And
conAsientos.Fecha Between IsNull(@pFechaHoraDesde, conAsientos.Fecha) AND
IsNull(@pFechaHoraHasta, conAsientos.Fecha) and 
venFormaEntrega.ExcluirDelReparto = 0  and 
genSucursalesEmpr.Sucursal Between @pSucursalDesde and @pSucursalHasta
ORDER BY 14 DESC, 13 ASC
GO



DROP PROCEDURE stkHojaDeRutaEliminar
GO
CREATE PROCEDURE stkHojaDeRutaEliminar
(
@lIdentity int
)
AS
SET NOCOUNT ON 

DELETE FROM stkHojaDeRuta 
WHERE stkHojaDeRuta.stkHojaDeRuta = @lIdentity
RETURN @@Error 
GO



DROP PROCEDURE stkHojaDeRutaPendientesCOT
GO
CREATE PROCEDURE stkHojaDeRutaPendientesCOT
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pUsuario INT,
@pFormaEntrega_Id VarChar(5) = NULL,
@pPatente_Id varChar(20),
@pPatenteAcoplado varChar(20) = null,
@pClienteDesde varChar(15),
@pClienteHasta varChar(15),
@pZonaDesde varChar(5),
@pZonaHasta varChar(5),
@pRegionDesde varChar(5),
@pRegionHasta varChar(5),
@pTipoClieDesde varChar(5),
@pTipoClieHasta varChar(5),
@pFormaDesde varChar(5),
@pFormaHasta varChar(5),
@pFiltroXFecha bit,
@pFechaHoraDesde Datetime = NULL,
@pFechaHoraHasta Datetime = NULL
)
AS
DECLARE @pIdentity int= (select stkHojaDeRuta From stkHojaSegmentos
	WHERE
	stkHojaSegmentos.Empresa_id = @pEmpresa_id and 
	stkHojaSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	stkHojaSegmentos.Segmento1N = @pSegmento1N and 
	stkHojaSegmentos.Segmento2N = @pSegmento2N and 
	stkHojaSegmentos.Segmento3N = @pSegmento3N and 
	stkHojaSegmentos.Segmento4N = @pSegmento4N and 
	stkHojaSegmentos.Segmento1C = @pSegmento1C and 
	stkHojaSegmentos.Segmento2C = @pSegmento2C and 
	stkHojaSegmentos.Segmento3C = @pSegmento3C and 
	stkHojaSegmentos.Segmento4C = @pSegmento4C)

EXEC stkHojaDeRutaIdentity @pIdentity

SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, stkRemitos.stkMoviCabe,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
venClientes.Cliente_Id, venClientes.RazonSocial, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, CAST(0 AS BIT) Marcado
FROM stkRemitos
INNER JOIN conAsientos ON conAsientos.conAsientos = stkRemitos.stkMoviCabe
INNER JOIN ((SELECT Sucursal FROM genSucursalesEmpr INNER JOIN 
(SELECT genSucursalesEmpr.Provincia_Id FROM genSucursalesEmpr INNER JOIN genUsuarios ON 
genSucursalesEmpr.genSucursalesEmpr = genUsuarios.Sucursal AND
genUsuarios.genUsuarios = @pUsuario) A ON A.Provincia_Id = genSucursalesEmpr.Provincia_Id)) SucProv	ON
conAsientos.Sucursal = SucProv.Sucursal
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
LEFT JOIN (venClientes INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades) ON
venClientes.genEntidades = stkRemitos.Cliente_Id AND venClieHabitual.Sucursal = stkRemitos.Sucursal
LEFT JOIN venFormaEntrega ON venFormaEntrega.venFormaEntrega = venClieHabitual.FormaEntrega_Id
LEFT JOIN venTiposClie ON venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
LEFT JOIN venRegion ON venRegion.venRegion = venClieHabitual.Region_Id
LEFT JOIN venZona ON venZona.venZona = venClieHabitual.Zona_Id
WHERE stkRemitos.HojaRuta_Id IS NULL AND conAsientos.Empresa_Id = @pEmpresa_Id AND
ISNULL(venClientes.Cliente_Id,'') Between @pClienteDesde And @pClienteHasta And
ISNULL(venZona.Zona_Id,'') Between @pZonaDesde And @pZonaHasta And
ISNULL(venRegion.Region_Id,'') Between @pRegionDesde And @pRegionHasta And
ISNULL(venTiposClie.TipoClie_Id,'') Between @pTipoClieDesde And @pTipoClieHasta And
ISNULL(venFormaEntrega.FormaEntrega_Id,'') Between @pFormaDesde And @pFormaHasta And
conAsientos.Fecha Between IsNull(@pFechaHoraDesde, conAsientos.Fecha) AND
ISNULL(@pFechaHoraHasta, conAsientos.Fecha) AND
NOT EXISTS (SELECT 1 FROM stkCOTAr WHERE stkCOTAr.stkHojaDeRuta = stkRemitos.HojaRuta_Id)
ORDER BY 14 DESC, 13 ASC
GO


DROP PROCEDURE stkHojaDeRutaCerrarDatos
GO
CREATE PROCEDURE stkHojaDeRutaCerrarDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
As

Declare @pIdentity int= (select stkHojaDeRuta From stkHojaSegmentos
	Where
	stkHojaSegmentos.Empresa_id = @pEmpresa_id and 
	stkHojaSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	stkHojaSegmentos.Segmento1N = @pSegmento1N and 
	stkHojaSegmentos.Segmento2N = @pSegmento2N and 
	stkHojaSegmentos.Segmento3N = @pSegmento3N and 
	stkHojaSegmentos.Segmento4N = @pSegmento4N and 
	stkHojaSegmentos.Segmento1C = @pSegmento1C and 
	stkHojaSegmentos.Segmento2C = @pSegmento2C and 
	stkHojaSegmentos.Segmento3C = @pSegmento3C and 
	stkHojaSegmentos.Segmento4C = @pSegmento4C)

SELECT genSegmentos.Segmento_Id, stkHojaSegmentos.Segmento1C, stkHojaSegmentos.Segmento2C,
stkHojaSegmentos.Segmento3C, stkHojaSegmentos.Segmento4C, stkHojaSegmentos.Segmento1N, stkHojaSegmentos.Segmento2N, 
stkHojaSegmentos.Segmento3N, stkHojaSegmentos.Segmento4N, 
stkHojaDeRuta.FechaRegistro, stkHojaDeRuta.Estado
from stkHojaDeRuta inner join stkHojaSegmentos ON 
stkHojaDeRuta.stkHojaDeRuta = stkHojaSegmentos.stkHojaDeRuta
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = stkHojaSegmentos.Segmento_Id
WHERE
	stkHojaDeRuta.stkHojaDeRuta = @pIdentity


Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, stkRemitos.stkMoviCabe,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
ISNULL(venClientes.Cliente_Id,'') Cliente_Id, ISNULL(venClientes.RazonSocial,'') RazonSocial, 
ISNULL(venFormaEntrega.FormaEntrega_Id,'') FormaEntrega_Id, 
ISNULL(venFormaEntrega.RazonSocial,'') ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 1 as bit ) Marcado,
ISNULL(stkHojaDeRuta.Patente_id,'') Patente_id, ISNULL(stkHojaDeRuta.PatenteAcoplado,'') PatenteAcoplado
From stkHojaDeRuta
Inner Join stkRemitos On stkRemitos.HojaRuta_Id = stkHojaDeRuta.stkHojaDeRuta
Inner Join conAsientos On conAsientos.conAsientos = stkRemitos.stkMoviCabe
LEFT JOIN (venClientes INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades) ON
venClientes.genEntidades = stkRemitos.Cliente_Id AND venClieHabitual.Sucursal = stkRemitos.Sucursal
LEFT JOIN venFormaEntrega On venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = stkRemitos.stkMoviCabe
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
Inner Join venRegion On venRegion.venRegion = venClieHabitual.Region_Id
Inner Join venZona On venZona.venZona = venClieHabitual.Zona_Id
Where stkHojaDeRuta.stkHojaDeRuta = @pIdentity
UNION ALL
Select dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Remito, venMovimientos.venMovimientos,
genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
ISNULL(venClientes.Cliente_Id,'') Cliente_Id, ISNULL(venClientes.RazonSocial,'') RazonSocial, 
ISNULL(venFormaEntrega.FormaEntrega_Id,'') FormaEntrega_Id, 
ISNULL(venFormaEntrega.RazonSocial,'') ForEntregaRazonSocial,
venTiposClie.TipoClie_Id, venTiposClie.Descripcion DescripcionTiposClie, venRegion.Region_Id, 
venRegion.Descripcion DescripcionRegion, venZona.Zona_Id, venZona.Descripcion DescripcionZona,
conAsientos.Fecha FechaRegistro, Cast( 1 as bit ) Marcado,
ISNULL(stkHojaDeRuta.Patente_id,'') Patente_id, ISNULL(stkHojaDeRuta.PatenteAcoplado,'') PatenteAcoplado
From stkHojaDeRuta
Inner Join stkHojaDeRutaCuerpo On stkHojaDeRutaCuerpo.stkHojaDeRuta = stkHojaDeRuta.stkHojaDeRuta
Inner Join venMovimientos ON venMovimientos.venMovimientos = stkHojaDeRutaCuerpo.conAsientos
Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
LEFT JOIN (venClientes INNER JOIN venClieHabitual ON venClientes.genEntidades = venClieHabitual.genEntidades) ON
venClientes.genEntidades = venMovimientos.Cliente_Id AND venClieHabitual.Sucursal = venMovimientos.Sucursal
LEFT JOIN venFormaEntrega On venFormaEntrega.venFormaEntrega = stkHojaDeRuta.FormaEntrega_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
Inner Join venRegion On venRegion.venRegion = venClieHabitual.Region_Id
Inner Join venZona On venZona.venZona = venClieHabitual.Zona_Id
Where stkHojaDeRuta.stkHojaDeRuta = @pIdentity

GO



DROP PROCEDURE stkHojaDeRutaCambiarEstado
GO
CREATE PROCEDURE stkHojaDeRutaCambiarEstado
(
@pstkHojaDeRuta int, 
@pEstado Char(1)
)
As

Update stkHojaDeRuta SET Estado = @pEstado Where stkHojaDeRuta = @pstkHojaDeRuta
GO