-- INF_stkSeguimientoSerie ' ' ,'ZZZZ', '20180101','20191231',1
DROP PROCEDURE INF_stkSeguimientoSerie
GO
CREATE PROCEDURE INF_stkSeguimientoSerie
(
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@SerieDesde VarChar(20),
	@SerieHasta VarChar(20),
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@Empresa Int

)
as
SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
stkMoviSerie.Serie, stkFamilias.Familia_Id, stkFamilias.Descripcion as DescripcionFamilia, 
		stkGrupos.Grupo_Id, stkGrupos.Descripcion as DescripcionGrupo,
		ISNULL(CONVERT(Char(10),stkSerieVencimiento.Vencimiento,103),' ') as Vencimiento,
	conAsientos.Fecha, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N) AS SegmentoStr, 
	case when comOCSegmentos.Segmento_Id IS NOT NULL THEN
	dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C,comOCSegmentos.Segmento2C, 
	comOCSegmentos.Segmento3C,comOCSegmentos.Segmento4C, 	comOCSegmentos.Segmento1N,
	comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N
	) 
	When genAsiSegmentosV.Segmento_Id IS NOT NULL THEN
	dbo.Segmento(genAsiSegmentosV.Segmento_Id, genAsiSegmentosV.Segmento1C,genAsiSegmentosV.Segmento2C, 
	genAsiSegmentosV.Segmento3C,genAsiSegmentosV.Segmento4C, 	genAsiSegmentosV.Segmento1N,
	genAsiSegmentosV.Segmento2N, genAsiSegmentosV.Segmento3N, genAsiSegmentosV.Segmento4N) 
	ELSE
		dbo.Segmento(proOrdenSegmento.Segmento_Id, proOrdenSegmento.Segmento1C,proOrdenSegmento.Segmento2C, 
		proOrdenSegmento.Segmento3C,proOrdenSegmento.Segmento4C, 	proOrdenSegmento.Segmento1N,
		proOrdenSegmento.Segmento2N, proOrdenSegmento.Segmento3N, proOrdenSegmento.Segmento4N) 
	END
	 AS Segmento2,
	isnull(ISNULL(ISNULL(comProveedores.Proveed_id, venclientes.Cliente_id), stkCausasMovi.Causa_Id), ' ') as Entidad, 
	isnull(ISNULL(ISNULL(comProveedores.RazonSocial, venClientes.RazonSocial),  stkCausasMovi.Descripcion), ' ') as DescripcionEntidad,
	stkSubTipoMov.SubTipoMov_Id, stkSubTipoMov.Descripcion as DescripcionSTM,
	
	stkUniMed.Medida_Id, stkMoviSerie.Cantidad* stkMoviCabe.Signo as Cantidad, 
	stkDepositos.Deposito_Id, stkMoviCuerpo.CostoUnitario, 
	Convert(nUMERIC(18,2),stkMoviCuerpo.CostoUnitario*stkMoviSerie.Cantidad* stkMoviCabe.Signo) as Total
	from stkMoviSerie INNER JOIN stkMoviCuerpo ON
	stkMoviCuerpo.stkMoviCabe = stkMoviSerie.stkMoviCabe AND 
	stkMoviCuerpo.Renglon =stkMoviSerie.Renglon
	inner join stkProductos ON
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	INNER JOIN stkMoviCabe ON 
	stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
	inner join stkDepositos ON
	stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
	inner join conAsientos ON
	conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
	inner join genAsiSegmentos ON
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	LEFT JOIN stkSerieVencimiento ON 
	stkSerieVencimiento.Serie = stkMoviSerie.Serie and 
	stkSerieVencimiento.Empresa_Id = @Empresa and 
	stkSerieVencimiento.Producto_Id = stkProductos.stkProductos
	LEFT JOIN (stkMoviOC INNER JOIN comOrdenComp ON 
		stkMoviOC.comOrdenComp = comOrdenComp.comOrdenComp
		inner join comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_Id
		INNER JOIN comOCSegmentos ON  comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp	) ON 
		stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkmovicabe and 
		stkMoviOC.Renglon = stkMoviCuerpo.Renglon
	LEFT JOIN (venMovStkHist INNER JOIN venMovimientos ON 
		venMovStkHist.venMovimientos = venMovimientos.venMovimientos
		INNER JOIN venClientes ON 
			venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER JOIN genAsiSegmentos genAsiSegmentosv ON 
		genAsiSegmentosv.Asiento_Id = venMovimientos.venMovimientos) ON
		venMovStkHist.stkMoviCabe = stkmovicuerpo.stkMoviCabe AND
		venMovStkHist.Renglon = stkmovicuerpo.Renglon
		INNER JOIN stkSubTipoMov ON 
		stkSubTipoMov.SubTipoMov_Id = stkMoviCabe.SubTipoMov_Id
	LEFT JOIN (stkMoviCausa INNER JOIN stkCausasMovi ON 
		stkMoviCausa.Causa_Id = stkCausasMovi.stkCausasMovi) ON 
		stkMoviCausa.stkMoviCabe = stkMoviCabe.stkMoviCabe
	LEFT JOIN (proOrdenStock inner join proMovCierreOrden on 
		proOrdenStock.proMovCierreOrden = proMovCierreOrden.proMovCierreOrden
		INNER JOIN 	proOrdenSegmento ON
		proMovCierreOrden.proOrden = proOrdenSegmento.proOrden	) ON
		proOrdenStock.stkMoviCabe = stkMoviCabe.stkMoviCabe
	LEFT JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	Where
		conAsientos.Anulado= 0 AND 
		conAsientos.Posteado = 1 AND 
		isnull(stkFamilias.Familia_Id,' ') Between @FamiliaDesde and @FamiliaHasta and 
		isnull(stkGrupos.Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and 
		stkProductos.Producto_Id Between @ProductoDesde AND @ProductoHasta AND 
		stkMoviSerie.Serie between @serieDesde And @serieHasta and 
		conAsientos.Fecha between @FechaDesde And @FechaHasta AND 
		genAsiSegmentos.Empresa_Id = @Empresa
Order by 1,3
GO


