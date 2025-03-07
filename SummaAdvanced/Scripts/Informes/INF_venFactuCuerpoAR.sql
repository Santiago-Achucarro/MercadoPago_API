DROP PROCEDURE INF_venFactuCuerpoAR
GO
CREATE PROCEDURE INF_venFactuCuerpoAR (
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


	AS

	SELECT venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		Alterna.Medida_Id as MedidaAlterna,
		venMovConStockCr.CantFacturada, venMovConStockCr.CantOriginal, 
		venMovConStockCr.CantEntregada, venMovConStockCr.CantidadAlternaForm as CantidadAlterna, 
		venMovConStockCr.PrecioForm, venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, 
		venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, 
		venMovConStockCr.PrecioFormImpuestoTot, venMovConStockCr.Observaciones, 
		venMovconStockcr.Bonificacion,
		--Convert(Numeric(18,2), (CantFacturada*PrecioForm * (1-Bonificacion/100))) as SubTotal, FM Arreglamos con AJ volver a la vida el campo original
		venMovConStockCr.SubTotal,
		venMovConStockCr.SubTotalFormImpuesto, 
		stkProductos.CodigoFiscal as ClaveSat,
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos AND 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0) as IVA,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos  and 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0) as ISR,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos  and 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) as IEPS, 
				
		ISNULL((SELECT TOP 1
		ISNULL(comDespachos.Anio,'XX') + '  ' + ISNULL(comDespachos.Aduana_id,'XX')+'  '+
			ISNULL(comDespachos.Patente,'XXXX')	+ '  ' +
			left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) 
			From venMovStkHist INNER JOIN stkMoviDespa ON
				venMovConStockCr.venMovimientos =  venMovStkHist.venMovimientos and 
				venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo and 
				stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe and 
				stkMoviDespa.Renglon  = venMovStkHist.Renglon
				INNER JOIN comDespachos ON 
				comDespachos.comDespachos = stkMoviDespa.Despacho_Id
				Where
				comDespachos.Pedimento > 0 ),' ')  as Despacho, 
				' ' as Serie, '' Predial
				
		
	from venMovConStockCr inner join genAsiSegmentos ON
		venMovConStockCr.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venMovConStockCr.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venMovConStockCr.Medida_Id
		LEFT OUTER JOIN stkUniMed AS Alterna on
		Alterna.stkUniMed = stkProductos.MedidaAlterna

	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id And
		NOT EXISTS(SELECT 1 FROM stkMoviSerie INNER JOIN venMovStkHist ON
			stkMoviSerie.stkMoviCabe = venMovStkHist.stkMoviCabe AND 
			stkMoviSerie.Renglon =venMovStkHist.Renglon AND 
			venMovStkHist.venMovimientos = venMovConStockCr.venMovimientos and 
			venMovStkHist.RenglonCuerpo = venMovConStockCr.RenglonCuerpo )
UNION ALL 
	--- SERIE
	SELECT venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		Alterna.Medida_Id as MedidaAlterna,
		venMovConStockCr.CantFacturada, venMovConStockCr.CantOriginal, 
		venMovConStockCr.CantEntregada, venMovConStockCr.CantidadAlternaForm as CantidadAlterna, 
		venMovConStockCr.PrecioForm, venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, 
		venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, 
		venMovConStockCr.PrecioFormImpuestoTot, venMovConStockCr.Observaciones, 
		venMovconStockcr.Bonificacion,
		--Convert(Numeric(18,2), (CantFacturada*PrecioForm * (1-Bonificacion/100))) as SubTotal, FM Arreglamos con AJ volver a la vida el campo original
		venMovConStockCr.SubTotal,
		venMovConStockCr.SubTotalFormImpuesto, 
		stkProductos.CodigoFiscal as ClaveSat,
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos AND 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0) as IVA,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos  and 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0) as ISR,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos  and 
				venMovCSImpuestos.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) as IEPS, 
				
		ISNULL((SELECT TOP 1
		ISNULL(comDespachos.Anio,'XX') + '  ' + ISNULL(comDespachos.Aduana_id,'XX')+'  '+
			ISNULL(comDespachos.Patente,'XXXX')	+ '  ' +
			left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) 
			From venMovStkHist INNER JOIN stkMoviDespa ON
				venMovConStockCr.venMovimientos =  venMovStkHist.venMovimientos and 
				venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo and 
				stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe and 
				stkMoviDespa.Renglon  = venMovStkHist.Renglon
				INNER JOIN comDespachos ON 
				comDespachos.comDespachos = stkMoviDespa.Despacho_Id
				Where
				comDespachos.Pedimento > 0 ),' ')  as Despacho, 
				' ' as Serie, '' Predial
				
		
	from venMovConStockCr inner join genAsiSegmentos ON
		venMovConStockCr.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venMovConStockCr.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venMovConStockCr.Medida_Id
		LEFT OUTER JOIN stkUniMed AS Alterna on
		Alterna.stkUniMed = stkProductos.MedidaAlterna

	Where genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id And
		EXISTS(SELECT 1 FROM stkMoviSerie INNER JOIN venMovStkHist ON
			stkMoviSerie.stkMoviCabe = venMovStkHist.stkMoviCabe AND 
			stkMoviSerie.Renglon =venMovStkHist.Renglon AND 
			venMovStkHist.venMovimientos = venMovConStockCr.venMovimientos and 
			venMovStkHist.RenglonCuerpo = venMovConStockCr.RenglonCuerpo )
	UNION ALL 
	SELECT venMovConStockCr.RenglonCuerpo, '' Producto_Id, 
		'Serie: '+stkMoviSerie.Serie Descripcion, '' DescripcionDetallada, stkProductos.Description, 
		''  MedidaProd, '' as FiscalMedidaProd, '' as MedidaMov, '' as FiscalMedidaMov,
		'' as MedidaAlterna, stkMoviSerie.Cantidad,  stkMoviSerie.Cantidad CantOriginal, 
		stkMoviSerie.Cantidad CantEntregada, 0 as CantidadAlterna, 0 PrecioForm, 0 PrecioLista, 0 PrecioVenta, 
		0 PrecioFormImpuesto, 0 PrecioFormImpuestoBon, 0 PrecioFormImpuestoTot, '' Observaciones, 
		0 Bonificacion, 0 SubTotal, 0 SubTotalFormImpuesto,
		'' as ClaveSat, 0 as IVA, 0 as ISR, 0 as IEPS, '' as Despacho, 
		'' Serie, '' Predial
	FROM 
		venMovConStockCr inner join venMovStkHist ON
			venMovStkHist.venMovimientos = venMovConStockCr.venMovimientos and 
			venMovStkHist.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
			INNER JOIN stkMoviSerie ON
			stkMoviSerie.stkMoviCabe = venMovStkHist.stkMoviCabe AND 
			stkMoviSerie.Renglon =venMovStkHist.Renglon
		INNER JOIN  genAsiSegmentos ON
		venMovConStockCr.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venMovConStockCr.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venMovConStockCr.Medida_Id
		LEFT OUTER JOIN stkUniMed AS Alterna on
		Alterna.stkUniMed = stkProductos.MedidaAlterna

	WHERE genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	/*
	SELECT venMovConStockCr.RenglonCuerpo, stkProductos.Producto_Id, 
		stkProductos.Descripcion, stkProductos.DescripcionDetallada, stkProductos.Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		MedidaMov.Medida_Id as MedidaMov, MedidaMov.CodigoFiscal as FiscalMedidaMov,
		Alterna.Medida_Id as MedidaAlterna,
		stkMoviSerie.Cantidad,  stkMoviSerie.Cantidad CantOriginal, 
		stkMoviSerie.Cantidad CantEntregada, venMovConStockCr.CantidadAlternaForm as CantidadAlterna, 
		venMovConStockCr.PrecioForm, venMovConStockCr.PrecioLista, venMovConStockCr.PrecioVenta, 
		venMovConStockCr.PrecioFormImpuesto, venMovConStockCr.PrecioFormImpuestoBon, 
		venMovConStockCr.PrecioFormImpuestoTot, venMovConStockCr.Observaciones, 
		venMovconStockcr.Bonificacion, 
		venMovConStockCr.SubTotal, venMovConStockCr.SubTotalFormImpuesto,
		stkProductos.CodigoFiscal as ClaveSat,
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0)/venMovConStockCr.CantFacturada * stkMoviSerie.Cantidad as IVA,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0)/venMovConStockCr.CantFacturada * stkMoviSerie.Cantidad as ISR,
		ISNULL((SELECT SUM(venMovCSImpuestos.Importe) 
			from venMovCSImpuestos inner join venImpuestos ON 
				venMovCSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovCSImpuestos.venMovimientos = venMovConStockCr.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) /venMovConStockCr.CantFacturada * stkMoviSerie.Cantidad as IEPS, 
				
		ISNULL((SELECT TOP 1
		ISNULL(comDespachos.Anio,'XX') + '  ' + ISNULL(comDespachos.Aduana_id,'XX')+'  '+
			ISNULL(comDespachos.Patente,'XXXX')	+ '  ' +
			left('0000000', 7-len(Ltrim(str(ISNULL(comDespachos.Pedimento,0),7))))+ Ltrim(str(ISNULL(comDespachos.Pedimento,0),7)) 
			From venMovStkHist INNER JOIN stkMoviDespa ON
				venMovConStockCr.venMovimientos =  venMovStkHist.venMovimientos and 
				venMovConStockCr.RenglonCuerpo = venMovStkHist.RenglonCuerpo and 
				stkMoviDespa.stkMoviCabe = venMovStkHist.stkMoviCabe and 
				stkMoviDespa.Renglon  = venMovStkHist.Renglon
				INNER JOIN comDespachos ON 
				comDespachos.comDespachos = stkMoviDespa.Despacho_Id
				Where
				comDespachos.Pedimento > 0),' ') as Despacho, 
				stkMoviSerie.Serie, '' Predial
				
		
	from 
		venMovConStockCr inner join venMovStkHist ON
			venMovStkHist.venMovimientos = venMovConStockCr.venMovimientos and 
			venMovStkHist.RenglonCuerpo = venMovConStockCr.RenglonCuerpo
			INNER JOIN stkMoviSerie ON
			stkMoviSerie.stkMoviCabe = venMovStkHist.stkMoviCabe AND 
			stkMoviSerie.Renglon =venMovStkHist.Renglon
		INNER JOIN  genAsiSegmentos ON
		venMovConStockCr.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN stkProductos ON 
		stkProductos.stkProductos = venMovConStockCr.Producto_Id
		inner join stkUniMed on 
		stkUniMed.stkUniMed = stkProductos.Medida_Id
		inner join stkUniMed as MedidaMov on 
		MedidaMov.stkUniMed = venMovConStockCr.Medida_Id
		LEFT OUTER JOIN stkUniMed AS Alterna on
		Alterna.stkUniMed = stkProductos.MedidaAlterna

	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N And
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		*/
	
union all
	SELECT venMovDetalle.conRenglon RenglonCuerpo, venMovDetalle.Producto_Id, 
		venMovDetalle.Detalle, venMovDetalle.Detalle DescripcionDetallada, venMovDetalle.Detalle Description, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		stkUniMed.Medida_Id as MedidaMov, stkUniMed.CodigoFiscal as FiscalMedidaMov,
		' ' MedidaAlterna,
		venMovDetalle.Cantidad, venMovDetalle.Cantidad CantOriginal, 
		venMovDetalle.Cantidad CantEntregada, 0 as CantidadAlterna, 
		venMovDetalle.ImporteUnitario as PrecioForm, venMovDetalle.ImporteUnitario PrecioLista, 
		venMovDetalle.ImporteUnitario PrecioVenta, 
		venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuesto, venMovDetalle.ImporteUnitarioDelImpuesto PrecioFormImpuestoBon, 
		venMovDetalle.ImporteUnitarioDelImpuesto * venMovDetalle.Cantidad PrecioFormImpuestoTot, 
		'' as Observaciones, 
		0.00 Bonificacion,
		Convert(Numeric(19,2),venMovDetalle.Cantidad * venMovDetalle.ImporteUnitario) as SubTotal  , 
		Convert(Numeric(19,2),venMovDetalle.ImporteUnitarioDelImpuesto * venMovDetalle.Cantidad) SubTotalFormImpuesto, 
		venMovDetalle.CodigoFiscal as ClaveSat, 
		/* para MEXICO */
		ISNULL((SELECT SUM(venMovSSImpuestos.Importe) 
			from venMovSSImpuestos inner join venImpuestos ON 
				venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovSSImpuestos.conRenglon = venmovDetalle.conRenglon and 
				venMovSSImpuestos.venMovimientos = venMovDetalle.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '002'),0) as IVA,
		ISNULL((SELECT SUM(venMovSSImpuestos.Importe) 
			from venMovSSImpuestos inner join venImpuestos ON 
				venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovSSImpuestos.conRenglon = venmovDetalle.conRenglon and 
				venMovSSImpuestos.venMovimientos = venMovDetalle.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '001'),0) as ISR,
		ISNULL((SELECT SUM(venMovSSImpuestos.Importe) 
			from venMovSSImpuestos inner join venImpuestos ON 
				venMovSSImpuestos.Impuesto_Id = venImpuestos.venImpuestos AND 
				venMovSSImpuestos.conRenglon = venmovDetalle.conRenglon and 
				venMovSSImpuestos.venMovimientos = venMovDetalle.venMovimientos 
				INNER JOIN impTipoImpuesto ON 
				impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				Where
				impTipoImpuesto.Referencia02 = '003'),0) as IEPS, 
				' ' as Despacho, ' ' as Serie, isnull(venMoviPredial.CuentaPredial,'') as Predial
		
	from venMovDetalle inner join genAsiSegmentos ON
		venMovDetalle.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		Left outer join stkUniMed on 
		stkUniMed.stkUniMed = venMovDetalle.Medida_Id
		LEFT JOIN venMoviPredial ON 
		venMoviPredial.venMovimientos = venMovDetalle.venMovimientos and 
		venMoviPredial.conRenglon  = 	venMovDetalle.conRenglon
		
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N and 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id
		-- CARTA PORTE
UNION ALL
SELECT venCompCartaPorteMercancia.Renglon RenglonCuerpo, ' ' Producto_Id, 
		venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Descripcion, venCompCartaPorteMercancia.Descripcion, 
		stkUniMed.Medida_Id as MedidaProd, stkUniMed.CodigoFiscal as FiscalMedidaProd,
		stkUniMed.Medida_Id as MedidaMov, stkUniMed.CodigoFiscal as FiscalMedidaMov,
		' ' as MedidaAlterna,
		venCompCartaPorteMercancia.Cantidad CantFacturada, venCompCartaPorteMercancia.Cantidad CantOriginal, 
		venCompCartaPorteMercancia.Cantidad CantEntregada, 0 as CantidadAlterna, 
		0 PrecioForm, 0 PrecioLista, 0 PrecioVenta, 
		0 PrecioFormImpuesto, 0 PrecioFormImpuestoBon, 
		0 PrecioFormImpuestoTot, '' Observaciones, 
		0 Bonificacion,
		--Convert(Numeric(18,2), (CantFacturada*PrecioForm * (1-Bonificacion/100))) as SubTotal, FM Arreglamos con AJ volver a la vida el campo original
		0 SubTotal,
		0 SubTotalFormImpuesto, 
		venCompCartaPorteMercancia.BienesTransp as ClaveSat,
		/* para MEXICO */
		0 as IVA,
		0 as ISR,
		0 as IEPS, 	''	 as Despacho, 
				' ' as Serie, '' Predial
		
	from venCompCartaPorteMercancia inner join genAsiSegmentos ON
		venCompCartaPorteMercancia.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genSegmentos ON 
		genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		inner join stkUniMed on 
		stkUniMed.stkUniMed = venCompCartaPorteMercancia.Medida_Id
		inner join venMovimientos ON  venMovimientos.venMovimientos = venCompCartaPorteMercancia.venmovimientos
	Where
		genSegmentos.Segmento_Id =  @pSegmento_Id and
		genAsiSegmentos.Segmento1C = @pSegmento1C and 
		genAsiSegmentos.Segmento2C = @pSegmento2C and 
		genAsiSegmentos.Segmento3C = @pSegmento3C and 
		genAsiSegmentos.Segmento4C = @pSegmento4C and 
		genAsiSegmentos.Segmento1N = @pSegmento1N and 
		genAsiSegmentos.Segmento2N = @pSegmento2N and  
		genAsiSegmentos.Segmento3N = @pSegmento3N and  
		genAsiSegmentos.Segmento4N = @pSegmento4N  AND 
		genAsiSegmentos.Empresa_Id = @pEmpresa_Id AND 
		venMovimientos.venTipomov = 'M'
	ORDER BY 1, Producto_Id desc

GO

