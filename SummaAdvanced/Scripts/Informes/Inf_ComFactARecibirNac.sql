-- exec Inf_ComFactARecibirNac '20200630',1

DROP PROCEDURE Inf_ComFactARecibirNac
GO
CREATE PROCEDURE Inf_ComFactARecibirNac @FechaHasta DateTime, @Empresa int, @ProveedorDesde varchar(15), @ProveedorHasta varchar(15)
AS

SELECT 	dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C
	, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N
	, comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N) AS Segmento,
	comOrdenComp.comOrdenComp, comOCCuerpo.Renglon_OC,  comTipoPermi.TipoPermi_Id,
	comOrdenComp.Fecha, comProveedores.Proveed_id, comProveedores.RazonSocial, 
	ISNULL(stkProductos.Producto_Id,' ') as Producto_Id, 
	ISNULL(stkProductos.Descripcion, comOCMemo.Detalle) as Descripcion, 
	comOCCuerpo.Cantidad as CantidadOriginal, 
	ISNULL((SELECT sum(stkMoviCuerpo.Cantidad*stkMoviCabe.Signo) 
				from  stkMoviOC INNER JOIN stkMoviCuerpo ON
				stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
				stkMoviOC.Renglon = stkMoviCuerpo.Renglon and
				stkMoviOC.comOrdenComp = comOcCuerpo.comOrdenComp and
				stkMoviOC.Renglon_OC = comOcCuerpo.Renglon_OC
				INNER JOIN stkMoviCabe ON 
				stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
				INNER JOIN conMovcont ON
				conMovcont.conAsientos = stkMoviCuerpo.stkMoviCabe and
				conMovcont.Renglon = CASE WHEN stkMoviCabe.Signo=1 
								THEN stkMoviCuerpo.conRenglonDebe ELSE stkMoviCuerpo.conRenglonHaber END					
				INNER JOIN conAsientos ON
				conAsientos.conAsientos = conMovcont.conAsientos

				WHERE
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado  = 1 and 
					conAsientos.Fecha <= @FechaHasta and 
					conAsientos.Empresa_Id = @Empresa
						),0) +
	ISNULL((SELECT SUM(comOcReceCuerpo.Cantidad) 
		from comOcReceCuerpo INNER JOIN conAsientos ON 
			conAsientos.conAsientos = comOcReceCuerpo.comOcRecepcion 
			WHERE
				conAsientos.Anulado = 0 and 
				conAsientos.Fecha <= @FechaHasta and 
				comOcReceCuerpo.comOrdenComp = comOCCuerpo.comOrdenComp and 
				comOcReceCuerpo.Renglon_OC = comOCCuerpo.Renglon_OC),0) as CantRecibido,
	ISNULL((SELECT sum(conMovcont.Importe*stkMoviCabe.Signo) 
				from  stkMoviOC INNER JOIN stkMoviCuerpo ON
				stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
				stkMoviOC.Renglon = stkMoviCuerpo.Renglon and
				stkMoviOC.comOrdenComp = comOcCuerpo.comOrdenComp and
				stkMoviOC.Renglon_OC = comOcCuerpo.Renglon_OC
				INNER JOIN stkMoviCabe ON 
				stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
				INNER JOIN conMovcont ON
				conMovcont.conAsientos = stkMoviCuerpo.stkMoviCabe and
				conMovcont.Renglon = CASE WHEN stkMoviCabe.Signo=1 
						THEN stkMoviCuerpo.conRenglonDebe ELSE stkMoviCuerpo.conRenglonHaber END
				INNER JOIN conAsientos ON
				conAsientos.conAsientos = conMovcont.conAsientos
				WHERE
					conAsientos.Anulado = 0 and 
					conAsientos.Fecha <= @FechaHasta and 
					conAsientos.Empresa_Id = @Empresa),0) +
		ISNULL((SELECT SUM(conMovCont.Importe *(-2*conMovcont.Tipomov+3)) 
			from comOcReceCuerpo INNER JOIN conAsientos ON 
			conAsientos.conAsientos = comOcReceCuerpo.comOcRecepcion 
			INNER JOIN conMovCont ON
			conMovCont.conAsientos =comOcReceCuerpo.comOcRecepcion  AND 
			conMovCont.Renglon =comOcReceCuerpo.conRenglon
			WHERE
				conAsientos.Anulado = 0 and 
				conAsientos.Fecha <= @FechaHasta and 
				comOcReceCuerpo.comOrdenComp = comOCCuerpo.comOrdenComp and 
				comOcReceCuerpo.Renglon_OC = comOCCuerpo.Renglon_OC),0) as ValRecibido, 
					
			ISNULL((SELECT sum(commovpoc.Cantidad*-comMovTipos.Signo) 
				from  commovpoc INNER JOIN commovprov ON
					commovpoc.comMovProv = commovprov.commovprov and 
					commovpoc.comOrdenComp = comOCCuerpo.comOrdenComp and 
					commovpoc.Renglon_OC = comOCCuerpo.Renglon_OC
					INNER JOIN conAsientos ON
					conAsientos.conAsientos = comMovprov.comMovprov
					INNER JOIN comMovTipos ON  comMovTipos.TipoMov = commovprov.TipoMov
				WHERE
					conAsientos.Anulado = 0 and 
					conAsientos.Posteado =1 and 
					conAsientos.Fecha <= @FechaHasta and 
					conAsientos.Empresa_Id = @Empresa),0) 	as CantidadFacturada, 
					
				ROUND(ISNULL((SELECT sum(commovpoc.Cantidad*-comMovTipos.Signo* commovpoc.Cambio ) 
				from  commovpoc INNER JOIN commovprov ON
					commovpoc.comMovProv = commovprov.commovprov and 
					commovpoc.comOrdenComp = comOCCuerpo.comOrdenComp  AND
					commovpoc.Renglon_OC = comOCCuerpo.Renglon_OC
					INNER JOIN conAsientos ON
					conAsientos.conAsientos = comMovprov.comMovprov
					INNER JOIN comMovTipos ON  comMovTipos.TipoMov = commovprov.TipoMov
						
				WHERE
					conAsientos.Anulado = 0 and 
					conAsientos.Fecha <= @FechaHasta and 
					conAsientos.Empresa_Id = @Empresa),0)* comOCCuerpo.Precio,2)   AS MontoFacturado
FROM comOrdenComp INNER JOIN comOcSegmentos ON
comOcSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
INNER JOIN comProveedores ON
comProveedores.genEntidades = comOrdenComp.Proveed_id 
INNER JOIN comOCCuerpo ON
comOrdenComp.comOrdenComp = comOCCuerpo.comOrdenComp
LEFT OUTER JOIN (comOcArticulo INNER JOIN stkProductos ON
comOcArticulo.Producto_Id = stkProductos.stkProductos) ON
comOcArticulo.comOrdenComp = comOCCuerpo.comOrdenComp and
comOcArticulo.Renglon_OC = comOCCuerpo.Renglon_OC
LEFT OUTER JOIN comOCMemo ON
comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp and
comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
INNER JOIN comTipoPermi ON comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id
Where
	comOrdenComp.Estado_Id != 'R' AND 
	comOCSegmentos.Empresa_Id = @Empresa and 
	not exists(select 1 from comEmbCuerpo inner join  conAsientos as Embarque on 
	comEmbCuerpo.comEmbarques = Embarque.conAsientos and 
	comEmbCuerpo.comOrdenComp =  comOrdenComp.comOrdenComp and 
	Embarque.Anulado = 0 and Embarque.Posteado = 1)  AND
	comProveedores.Proveed_id BETWEEN @ProveedorDesde AND @ProveedorHasta 
	AND	ISNULL((SELECT sum(stkMoviCuerpo.Cantidad*stkMoviCabe.Signo) 
				from  stkMoviOC INNER JOIN stkMoviCuerpo ON
				stkMoviOC.stkMoviCabe = stkMoviCuerpo.stkMoviCabe AND 
				stkMoviOC.Renglon = stkMoviCuerpo.Renglon and
				stkMoviOC.comOrdenComp = comOcCuerpo.comOrdenComp and
				stkMoviOC.Renglon_OC = comOcCuerpo.Renglon_OC
				INNER JOIN stkMoviCabe ON 
				stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
				INNER JOIN conMovcont ON
				conMovcont.conAsientos = stkMoviCuerpo.stkMoviCabe and
				conMovcont.Renglon = CASE WHEN stkMoviCabe.Signo=1 
								THEN stkMoviCuerpo.conRenglonDebe ELSE stkMoviCuerpo.conRenglonHaber END					
				INNER JOIN conAsientos ON
				conAsientos.conAsientos = conMovcont.conAsientos

				WHERE
					conAsientos.Anulado = 0 and 
					conAsientos.Fecha <= @FechaHasta and 
					conAsientos.Empresa_Id = @Empresa
						),0) +
	ISNULL((SELECT SUM(comOcReceCuerpo.Cantidad) 
		from comOcReceCuerpo INNER JOIN conAsientos ON 
			conAsientos.conAsientos = comOcReceCuerpo.comOcRecepcion 
			WHERE
				conAsientos.Anulado = 0 and 
				conAsientos.Fecha <= @FechaHasta and 
				comOcReceCuerpo.comOrdenComp = comOCCuerpo.comOrdenComp and 
				comOcReceCuerpo.Renglon_OC = comOCCuerpo.Renglon_OC),0) <> 
				 	ISNULL((SELECT sum(commovpoc.Cantidad*-comMovTipos.Signo) 
				from  commovpoc INNER JOIN commovprov ON
					commovpoc.comMovProv = commovprov.commovprov and 
					commovpoc.comOrdenComp = comOCCuerpo.comOrdenComp and 
					commovpoc.Renglon_OC = comOCCuerpo.Renglon_OC
					INNER JOIN conAsientos ON
					conAsientos.conAsientos = comMovprov.comMovprov
					INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovprov.Tipomov
				WHERE
					conAsientos.Anulado = 0 and 
					conAsientos.Fecha <= @FechaHasta and 
					conAsientos.Empresa_Id = @Empresa),0)  
						
UNION ALL -- REMISIONES

SELECT 	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C
	, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N
	, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	conAsientos.conAsientos, stkMoviCuerpo.Renglon, 'REM' AS TipoPermi_Id,
	conAsientos.Fecha, comProveedores.Proveed_id, comProveedores.RazonSocial, 
	stkProductos.Producto_Id as Producto_Id, stkProductos.Descripcion ,
	stkMoviCuerpo.CantidadForm as CantidadOriginal, 
	stkRemiPendFactPro.CantidadPendiente + 
		ISNULL((Select SUM(comRemiPendFact.CantidadFacturado)
					From comRemiPendFact , conAsientos AS Fact
					WHERE
						comRemiPendFact.stkMoviCabe = stkRemiPendFactPro.stkMoviCabe AND 
						comRemiPendFact.Renglon = stkRemiPendFactPro.Renglon and 
						Fact.conAsientos = comRemiPendFact.comMovProv and 
						Fact.Anulado = 0 and
						Fact.Posteado = 1 and 
						Fact.Fecha > @FechaHasta),0) as CantRecibido, 
						(stkRemiPendFactPro.CantidadPendiente+
				ISNULL((Select SUM(comRemiPendFact.CantidadFacturado )
					From comRemiPendFact , conAsientos AS Fact
					WHERE
						comRemiPendFact.stkMoviCabe = stkRemiPendFactPro.stkMoviCabe AND 
						comRemiPendFact.Renglon = stkRemiPendFactPro.Renglon and 
						Fact.conAsientos = comRemiPendFact.comMovProv and 
						Fact.Anulado = 0 and
						Fact.Posteado = 1 and 
						Fact.Fecha > @FechaHasta),0)) * stkMoviCuerpo.CostoUnitario  as ValRecibido, 
			ISNULL((SELECT sum(comRemiPendFact.CantidadFacturado) 
				from  comRemiPendFact INNER JOIN  conAsientos FACT ON
					FACT.conAsientos = comRemiPendFact.comMovprov and 
					comRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
					comRemiPendFact.Renglon =stkMoviCuerpo.Renglon
				WHERE
					FACT.Anulado = 0 and 
					FACT.Fecha <= @FechaHasta and 
					FACT.Empresa_Id = @Empresa),0)  as CantidadFacturada, 
				ROUND(ISNULL((SELECT sum(comRemiPendFact.CantidadFacturado) 
				from  comRemiPendFact INNER JOIN  conAsientos FACT ON
					FACT.conAsientos = comRemiPendFact.comMovprov and 
					comRemiPendFact.stkMoviCabe = stkMoviCuerpo.stkMoviCabe and 
					comRemiPendFact.Renglon =stkMoviCuerpo.Renglon
				WHERE
					FACT.Anulado = 0 and 
					FACT.Fecha <= @FechaHasta and 
					FACT.Empresa_Id = @Empresa),0)* stkMoviCuerpo.CostoUnitario,2)   AS MontoFacturado
From stkRemiPendFactPro INNER JOIN conAsientos ON
		stkRemiPendFactPro.stkMoviCabe = conAsientos.conAsientos
		INNER JOIN stkMoviProv ON 
		stkMoviProv.stkMoviCabe = stkRemiPendFactPro.stkMoviCabe
		inner join stkMoviCuerpo ON 
		stkMoviCuerpo.stkMoviCabe = stkRemiPendFactPro.stkMoviCabe AND 
		stkMoviCuerpo.Renglon  =stkRemiPendFactPro.Renglon
		INNER JOIN stkProductos ON  stkProductos.stkProductos = stkMoviCuerpo.Producto_Id 
		INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos 
		inner join comProveedores ON  comProveedores.genEntidades = stkMoviProv.Proveed_Id
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Fecha <= @FechaHasta and 
	conAsientos.Empresa_Id = @Empresa and 
	comProveedores.Proveed_id BETWEEN @ProveedorDesde AND @ProveedorHasta AND
		stkRemiPendFactPro.CantidadPendiente + 
		ISNULL((Select sum(comRemiPendFact.CantidadFacturado) 
					From comRemiPendFact , conAsientos AS Fact
					WHERE
						comRemiPendFact.stkMoviCabe = stkRemiPendFactPro.stkMoviCabe AND 
						comRemiPendFact.Renglon = stkRemiPendFactPro.Renglon and 
						Fact.conAsientos = comRemiPendFact.comMovProv and 
						Fact.Anulado = 0 and
						Fact.Posteado = 1 and 
						Fact.Fecha > @FechaHasta),0) <> 0

ORDER BY 2,3
GO



