drop procedure inf_tesRetenciones
go
create procedure inf_tesRetenciones
(
@CarteraDesde varchar(5),
@CarteraHasta varchar(5),
@FechaDesde datetime,
@FechaHasta datetime,
@Empresa_Id int,
@Tipo int
)
AS
IF @Tipo = 1
	SELECT tesIdentifica.Cartera_Id, conAsientos.Fecha, 0 NroResSicore, vtesMovimientos.Segmento Comp,
	tesSubTiposMov.SubTipo_Id, (-2*tesRengMovi.TipoMovCont+3)*conMovCont.Importe Importe, genEntidades.Cuit,
	venClientes.Cliente_Id ClieProv, venClientes.RazonSocial, tesIdentifica.Descripcion,
	tesRengMoviRetClie.SucursalRet, tesRengMoviRetClie.ComprobanteRet,
	tesRengMoviRetClie.BaseImponible, tesRengMoviRetClie.Porcentaje
	FROM conAsientos
	INNER JOIN tesMovimientos ON conAsientos.conAsientos = tesMovimientos.tesMovimientos AND
		conAsientos.Empresa_Id= @Empresa_Id
	INNER JOIN vtesMovimientos ON vtesMovimientos.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN venMovimientos ON conAsientos.conAsientos = venMovimientos.venMovimientos AND
		venMovimientos.venTipoMov IN ('C','N')
	INNER JOIN tesRengMovi ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
	INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN tesTiposId ON tesIdentifica.TipoCartera = tesTiposId.tesTiposId AND
		tesTiposId.TipoCartera = 'RC'
	INNER JOIN tesRengMoviRetClie ON tesRengMovi.tesMovimientos = tesRengMoviRetClie.tesMovimientos AND
		tesRengMovi.conRenglon = tesRengMoviRetClie.conRenglon
	INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos AND
			tesRengMovi.conRenglon = conMovCont.Renglon
	INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
	INNER JOIN tesSubTiposMov ON tesMovimientos.SubTipo_Id = tesSubTiposMov.tesSubTiposMov
	INNER JOIN genEntidades ON venClientes.genEntidades = genEntidades.genEntidades
	WHERE tesIdentifica.Cartera_Id BETWEEN @CarteraDesde and @CarteraHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1
	UNION ALL
	SELECT tesIdentifica.Cartera_Id, conAsientos.Fecha, 0 NroResSicore, vtesMovimientos.Segmento Comp,
	tesSubTiposMov.SubTipo_Id, (-2*tesRengMovi.TipoMovCont+3)*conMovCont.Importe Importe, ' ' CUIT,
	' ' Cliente_Id, ' ' RazonSocial, tesIdentifica.Descripcion,
	tesRengMoviRetClie.SucursalRet, tesRengMoviRetClie.ComprobanteRet,
	tesRengMoviRetClie.BaseImponible, tesRengMoviRetClie.Porcentaje
	FROM conAsientos
	INNER JOIN tesMovimientos ON conAsientos.conAsientos = tesMovimientos.tesMovimientos AND
		conAsientos.Empresa_Id= @Empresa_Id	
	INNER JOIN vtesMovimientos ON vtesMovimientos.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesRengMovi ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
	INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN tesTiposId ON tesIdentifica.TipoCartera = tesTiposId.tesTiposId AND
		tesTiposId.TipoCartera = 'RC'
	INNER JOIN tesRengMoviRetClie ON tesRengMovi.tesMovimientos = tesRengMoviRetClie.tesMovimientos AND
		tesRengMovi.conRenglon = tesRengMoviRetClie.conRenglon
	INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos AND
			tesRengMovi.conRenglon = conMovCont.Renglon
	INNER JOIN tesSubTiposMov ON tesMovimientos.SubTipo_Id = tesSubTiposMov.tesSubTiposMov AND
		tesSubTiposMov.SubTipo_Id = 'EGR'
	WHERE tesIdentifica.Cartera_Id BETWEEN @CarteraDesde and @CarteraHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1
	ORDER BY 1,2
ELSE
	SELECT tesIdentifica.Cartera_Id, conAsientos.Fecha, TesIdRetProv.NroResSicore, 
	vtesMovimientos.Segmento Comp, ' ' SubTipo_Id, (-2*tesRengMovi.TipoMovCont+3)*conMovCont.Importe Importe, 
	genEntidades.Cuit, comProveedores.Proveed_Id ClieProv, 	comProveedores.RazonSocial, tesIdentifica.Descripcion, 
	' ' SucursalRet, dbo.Segmento(tesRetProvSegmento.Segmento_Id, tesRetProvSegmento.Segmento1C, 
	tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,   
	tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, 
	tesRetProvSegmento.Segmento4N) ComprobanteRet, tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Porcentaje 
	FROM tesMovimientos 
	INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos
	INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos AND
		conAsientos.Empresa_Id= @Empresa_Id
	INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN tesRengMovi ON conAsientos.conAsientos = tesRengMovi.tesMovimientos AND
		conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN TesIdRetProv ON tesIdentifica.tesIdentifica = TesIdRetProv.Cartera_Id
	INNER JOIN tesRengMoviRetProv ON conAsientos.conAsientos = tesRengMoviRetProv.tesMovimientos AND
		conMovCont.Renglon = tesRengMoviRetProv.conRenglon 
	INNER JOIN comMovProv ON tesMovimientos.tesMovimientos = comMovProv.comMovProv AND
		comMovProv.TipoMov = 'P'
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEntidades ON comProveedores.genEntidades = genEntidades.genEntidades
	INNER JOIN tesRetProvSegmento ON tesMovimientos.tesMovimientos = tesRetProvSegmento.tesMovimientos AND
		conMovCont.Renglon = tesRetProvSegmento.conRenglon
	WHERE tesIdentifica.Cartera_Id BETWEEN @CarteraDesde and @CarteraHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1
	UNION ALL
	SELECT tesIdentifica.Cartera_Id, conAsientos.Fecha, TesIdRetProv.NroResSicore, vtesMovimientos.Segmento,
	'' SubTipo_Id, (-2*tesRengMovi.TipoMovCont+3)*conMovCont.Importe Importe, ISNULL(comProv.Cuit,'') Cuit, 
	ISNULL(comProv.Proveed_Id,'') Proveed_id, ISNULL(comProv.RazonSocial,'') RazonSocial, 
	tesIdentifica.Descripcion, ' ' SucursalRet, dbo.Segmento(tesRetProvSegmento.Segmento_Id, tesRetProvSegmento.Segmento1C, 
	tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,   
	tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, 
	tesRetProvSegmento.Segmento4N) NroRetencion, tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Porcentaje   
	FROM tesMovimientos 
	INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos
	INNER JOIN tesSubTiposMov ON tesMovimientos.SubTipo_Id = tesSubTiposMov.tesSubTiposMov AND
		tesSubTiposMov.SubTipo_Id IN ('EGR','CVE')
	INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos AND
		conAsientos.Empresa_Id= @Empresa_Id
	INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN tesRengMovi ON conAsientos.conAsientos = tesRengMovi.tesMovimientos AND
		conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN TesIdRetProv ON tesIdentifica.tesIdentifica = TesIdRetProv.Cartera_Id
	INNER JOIN tesRengMoviRetProv ON conAsientos.conAsientos = tesRengMoviRetProv.tesMovimientos AND
		conMovCont.Renglon = tesRengMoviRetProv.conRenglon 
	INNER JOIN tesRetProvSegmento ON tesMovimientos.tesMovimientos = tesRetProvSegmento.tesMovimientos AND
		conMovCont.Renglon = tesRetProvSegmento.conRenglon
	LEFT JOIN (SELECT comMovProv.comMovProv, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		comMovProv.TipoMov, genEntidades.Cuit FROM comMovProv  
		INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
		INNER JOIN genEntidades ON comProveedores.genEntidades = genEntidades.genEntidades) comProv ON 
	tesMovimientos.tesMovimientos = comProv.comMovProv
	WHERE tesIdentifica.Cartera_Id BETWEEN @CarteraDesde and @CarteraHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1
	UNION ALL
	SELECT tesIdentifica.Cartera_Id, conAsientos.Fecha, TesIdRetProv.NroResSicore, vtesMovimientos.Segmento,
	'' SubTipo_Id, (-2*tesRengMovi.TipoMovCont+3)*conMovCont.Importe Importe, genEntidades.Cuit, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial, tesIdentifica.Descripcion, 
	' ' SucursalRet, dbo.Segmento(tesRetProvSegmento.Segmento_Id, tesRetProvSegmento.Segmento1C, 
	tesRetProvSegmento.Segmento2C, tesRetProvSegmento.Segmento3C, tesRetProvSegmento.Segmento4C,   
	tesRetProvSegmento.Segmento1N, tesRetProvSegmento.Segmento2N, tesRetProvSegmento.Segmento3N, 
	tesRetProvSegmento.Segmento4N) NroRetencion, tesRengMoviRetProv.BaseImponible, tesRengMoviRetProv.Porcentaje  
	FROM tesMovimientos 
	INNER JOIN vtesMovimientos ON tesMovimientos.tesMovimientos = vtesMovimientos.tesMovimientos
	INNER JOIN conAsientos ON tesMovimientos.tesMovimientos = conAsientos.conAsientos AND
		conAsientos.Empresa_Id= @Empresa_Id
	INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos
	INNER JOIN tesRengMovi ON conAsientos.conAsientos = tesRengMovi.tesMovimientos AND
		conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesIdentifica ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN TesIdRetProv ON tesIdentifica.tesIdentifica = TesIdRetProv.Cartera_Id
	INNER JOIN tesRengMoviRetProv ON conAsientos.conAsientos = tesRengMoviRetProv.tesMovimientos AND
		conMovCont.Renglon = tesRengMoviRetProv.conRenglon 
	INNER JOIN comMovProv ON tesMovimientos.tesMovimientos = comMovProv.comMovProv AND
		comMovProv.TipoMov <> 'P'
	INNER JOIN comProveedores ON comMovProv.Proveed_Id = comProveedores.genEntidades
	INNER JOIN genEntidades ON comProveedores.genEntidades = genEntidades.genEntidades
	INNER JOIN tesRetProvSegmento ON tesMovimientos.tesMovimientos = tesRetProvSegmento.tesMovimientos AND
		conMovCont.Renglon = tesRetProvSegmento.conRenglon
	WHERE tesIdentifica.Cartera_Id BETWEEN @CarteraDesde and @CarteraHasta AND
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	conAsientos.Anulado = 0 and conAsientos.Posteado = 1
	ORDER BY 1,2




