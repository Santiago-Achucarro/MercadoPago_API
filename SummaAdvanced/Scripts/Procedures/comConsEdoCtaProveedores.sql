
-- comConsEdoCtaProveedores '0722',2, '20190401','20190531', 'DOL', 1
-- comConsEdoCtaProveedores 'Q001',2, '20170801','20171222', null, 1
-- comConsEdoCtaProveedores 'Q001',2, '20170801','20171222', 'DOL', 1


DROP PROCEDURE comConsEdoCtaProveedores
GO
CREATE PROCEDURE comConsEdoCtaProveedores(
	@Proveed_Id VarChar(15),
	@PendHist INT,
	@FechaDesde DateTime,
	@FechaHasta DateTime,
	@Moneda_Id VarChar(5)=NULL,
	@Empresa Int
)

AS
select @Proveed_Id as Proveed_Id, @PendHist as PendHist,
	@FechaDesde as FechaDesde, @FechaHasta as FechaHasta,
	@Moneda_Id as Moneda_Id, @Empresa as Empresa, ISNULL(comProveedores.RazonSocial, ' ') as RazonSocial,
	ISNULL(genMonedas.Descripcion,' ') as DescripcionMoneda, DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.FechaActual())) as FechaAplicacion,
	dbo.FechaActual() as FechaApli, 0 as Renglon, ' ' AS XmlUpload, '' as Xml, cast('' as char) as OrigenXml
FROM comProveedores
	LEFT OUTER JOIN genMonedas ON genMonedas.Moneda_id = @Moneda_Id
WHERE Proveed_Id = @Proveed_Id

	SELECT commovprov.comMovProv,
		comMovTipos.TipoMov, comMovTipos.Descripcion as Tipomovs, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
		comMovProv.Fecha_CCP Fecha,
		case when comMovTipos.Signo=1  then 
	genMovCuotas.Importe ELSE 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Debe,
		case when comMovTipos.Signo=-1  then 
	genMovCuotas.Importe  else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Haber,
		CASE WHEN @PendHist=1 THEN  genMovCuotas.Saldo else case when commovprov.FacturaTesoreria=1 then 0 else genMovCuotas.Saldo end end * comMovTipos.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Saldo,
		CASE WHEN @PendHist=1 THEN  genMovCuotas.Saldo else case when commovprov.FacturaTesoreria=1 then 0 else genMovCuotas.Importe end end * comMovTipos.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as SaldoAcum,
		genMovCuotas.CuotaNro,
		genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio,
		genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro,
		CASE WHEN ISNULL(CONVERT(char(1),comMovProv.XMLFiscal), ' ') = ' ' THEN 0 ELSE 1 END AS XML, cast(0 as bit) as EditaEmbarques,
		conAsientos.Observaciones, comMovProv.Base_Ganancias, comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion TipoCtaProvDescripcion, comMovProv.ClaveFiscal,
		conAsientos.Fecha FechaContable
	FROM COMMOVPROV
		INNER JOIN comProveedores ON COMMOVPROV.Proveed_Id = comProveedores.genEntidades
		INNER JOIN comMovTipos ON comMovTipos.TipoMov = commovprov.TipoMov
		inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
		INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genEmpresas ON conAsientos.Empresa_Id = genEmpresas.genEmpresas
		INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =comMovProv.comMovProv
		INNER JOIN genMonedas ON genMonedas.genMonedas = case When @Moneda_Id IS NULL then genEmpresas.Moneda_Id else conAsientos.Moneda_Id end
		inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
		Left Join comProveedoresTipoPasivo On comProveedoresTipoPasivo.TipoCtaProv = comMovProv.TipoCtaProv
	--Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
	WHERE
	conAsientos.Empresa_Id =@Empresa And conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And --tesRengMovicomMovProv.tesMovimientos Is Null And
		comProveedores.Proveed_Id =@Proveed_Id and
		((genMovCuotas.Saldo > 0 and @PendHist = 1 AND comMovProv.FacturaTesoreria = 0 ) or (
			--conAsientos.Fecha between @FechaDesde and @FechaHasta and @PendHist = 2)) and 
			comMovProv.Fecha_CCP between @FechaDesde and @FechaHasta and @PendHist = 2 )) and
		genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)

UNION ALL
	-- IMPORTACIONES
	SELECT commovprov.comMovProv,
		comMovTipos.TipoMov, comMovTipos.Descripcion as Tipomovs, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
		genCancMov.FechaAplicacion Fecha,
		genCancMov.Importe_ap 	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos1.Moneda_id, @FechaHasta, @Empresa) else 1 end  as Debe,
		0 as Haber,
		genCancMov.Importe_ap * case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos1.Moneda_id, @FechaHasta, @Empresa) else 1 end  as Saldo,
		genCancMov.Importe_ap * case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos1.Moneda_id, @FechaHasta, @Empresa) else 1 end  as SaldoAcum,
		genCancMov.CuotaNro CuotaNro,
		genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio,
		genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro,
		CASE WHEN ISNULL(CONVERT(char(1),comMovProv.XMLFiscal), ' ') = ' ' THEN 0 ELSE 1 END AS XML, cast(0 as bit) as EditaEmbarques,
		conAsientos.Observaciones, comMovProv.Base_Ganancias, comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion TipoCtaProvDescripcion, commovprov.ClaveFiscal,
		conAsientos.Fecha FechaContable
	FROM genCancMov INNER JOIN COMMOVPROV ON genCancMov.Asiento_Id = COMMOVPROV.comMovProv
		INNER JOIN commovprov  commovprov1 on genCancMov.Asiento_Id_ap = COMMOVPROV1.comMovProv
		INNER JOIN comProveedores ON COMMOVPROV1.Proveed_Id = comProveedores.genEntidades
		INNER JOIN comMovTipos ON comMovTipos.TipoMov = commovprov.TipoMov
		inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
		INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genEmpresas ON conAsientos.Empresa_Id = genEmpresas.genEmpresas
		INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =comMovProv.comMovProv
		inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
		INNER JOIN conAsientos conAsientos1 ON conAsientos1.conAsientos = commovprov1.comMovProv
		INNER JOIN genMonedas ON genMonedas.genMonedas = CASE WHEN @Moneda_Id  IS NULL THEN 
	genEmpresas.Moneda_Id else conAsientos1.Moneda_Id end
		Left Join comProveedoresTipoPasivo On comProveedoresTipoPasivo.TipoCtaProv = comMovProv.TipoCtaProv
	WHERE
	@PendHist= 2 and

		genCancMov.Importacion = 1 and
		conAsientos.Empresa_Id =@Empresa And
		conAsientos1.Anulado = 0 and
		conAsientos1.Posteado = 1 and
		conAsientos.Anulado = 0 And
		conAsientos.Posteado = 1 And --tesRengMovicomMovProv.tesMovimientos Is Null And
		comProveedores.Proveed_Id =@Proveed_Id And commovprov1.Proveed_Id <> comMovProv.Proveed_Id And
		genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta and
		genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)

UNION ALL
	-- importaciones 2
	SELECT commovprov.comMovProv,
		comMovTipos.TipoMov, comMovTipos.Descripcion as Tipomovs, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento,
		genCancMov.FechaAplicacion Fecha,
		0 as Debe,
		genCancMov.Importe * case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Haber,
		-genCancMov.Importe * case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end  as Saldo,
		-genCancMov.Importe * case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end  as SaldoAcum,
		genCancMov.CuotaNro_Ap CuotaNro,
		genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio,
		genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro,
		CASE WHEN ISNULL(CONVERT(char(1),comMovProv.XMLFiscal), ' ') = ' ' THEN 0 ELSE 1 END AS XML, cast(0 as bit) as EditaEmbarques,
		conAsientos.Observaciones, comMovProv.Base_Ganancias, comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion TipoCtaProvDescripcion, comMovProv.ClaveFiscal,
		conAsientos.Fecha FechaContable
	FROM genCancMov INNER JOIN COMMOVPROV ON genCancMov.Asiento_Id_AP = COMMOVPROV.comMovProv
		INNER JOIN commovprov  commovprov1 on genCancMov.Asiento_Id = COMMOVPROV1.comMovProv
		INNER JOIN comProveedores ON COMMOVPROV1.Proveed_Id = comProveedores.genEntidades
		INNER JOIN comMovTipos ON comMovTipos.TipoMov = commovprov.TipoMov
		inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
		INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
		INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =comMovProv.comMovProv
		inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
		INNER JOIN conAsientos conAsientos1 ON conAsientos1.conAsientos = commovprov1.comMovProv
		INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos1.Moneda_Id
		Left Join comProveedoresTipoPasivo On comProveedoresTipoPasivo.TipoCtaProv = comMovProv.TipoCtaProv
	WHERE
	@PendHist= 2 and
		conAsientos1.Anulado = 0 and
		conAsientos1.Posteado = 1 and
		genCancMov.Importacion = 1 and
		conAsientos.Empresa_Id =@Empresa And conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And --tesRengMovicomMovProv.tesMovimientos Is Null And
		comProveedores.Proveed_Id =@Proveed_Id And commovprov1.Proveed_Id <> comMovProv.Proveed_Id And
		genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta and
		genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
UNION ALL
	SELECT SI.comMovProv, SI.TipoMov, SI.Tipomovs, SI.Segmento,
		SI.Fecha, SUM(SI.Debe) AS Debe, SUM(SI.Haber) AS Haber,
		SUM(SI.Saldo) as Saldo, SUM(SI.SaldoAcum) SaldoAcum,
		si.CuotaNro, si.FechaVenc, si.Moneda_Id, si.Cambio,
		si.Apellido_y_Nombres, si.FechaRegistro, si.XML, si.EditaEmbarques,
		si.Observaciones, si.Base_Ganancias, Si.TipoCtaProv, si.TipoCtaProvDescripcion, ''  as ClaveFiscal,
		SI.Fecha FechaContable
	FROM (
					SELECT 0 as comMovProv, ' ' TipoMov, 'Saldo Inicial' as Tipomovs, ' ' Segmento,
				DATEADD(dd,-1,@FechaDesde) as Fecha,
				case when  
		SUM(genMovCuotas.Importe *comMovTipos.Signo ) > 0
	 then 
		SUM(genMovCuotas.Importe *comMovTipos.Signo ) ELSE 0 END as Debe,
				case when  
		SUM(genMovCuotas.Importe *comMovTipos.Signo ) < 0
	 then 
		-SUM(genMovCuotas.Importe *comMovTipos.Signo) ELSE 0  END as Haber,
				SUM(genMovCuotas.Importe *comMovTipos.Signo ) as Saldo,
				SUM(genMovCuotas.Importe *comMovTipos.Signo ) as SaldoAcum,
				0 CuotaNro,
				DATEADD(dd,-1,@FechaDesde) as FechaVenc, genMonedas.Moneda_Id, 1 Cambio,
				' ' Apellido_y_Nombres, DATEADD(dd,-1,@FechaDesde) FechaRegistro ,
				0 AS XML, cast(0 as bit) as EditaEmbarques, '' Observaciones, 0 Base_Ganancias, 0 TipoCtaProv, '' TipoCtaProvDescripcion
			FROM COMMOVPROV
				INNER JOIN comProveedores ON COMMOVPROV.Proveed_Id = comProveedores.genEntidades
				INNER JOIN comMovTipos ON comMovTipos.TipoMov = commovprov.TipoMov
				inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
				INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
				INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id =comMovProv.comMovProv
				INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
				inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
			--Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
			WHERE commovprov.FacturaTesoreria = 0 and conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
				conAsientos.Empresa_Id =@Empresa and --tesRengMovicomMovProv.tesMovimientos Is Null And
				comProveedores.Proveed_Id =@Proveed_Id and
				--conAsientos.Fecha < @FechaDesde and
				comMovProv.Fecha_CCP < @FechaDesde and
				@PendHist = 2 and
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
			GROUP BY genMonedas.Moneda_Id
		UNION ALL
			-- Aplicacion de Importaciones
			SELECT 0 as comMovProv, ' ' TipoMov, 'Saldo Inicial' as Tipomovs, ' ' Segmento,
				DATEADD(dd,-1,@FechaDesde) as Fecha,
				0 as Debe,
				SUM(genCancMov.Importe )   as Haber,
				SUM(-genCancMov.Importe ) as Saldo,
				SUM(-genCancMov.Importe ) as SaldoAcum,
				0 CuotaNro,
				DATEADD(dd,-1,@FechaDesde) as FechaVenc, genMonedas.Moneda_Id, 1 Cambio,
				' ' Apellido_y_Nombres, DATEADD(dd,-1,@FechaDesde) ,
				0 AS XML, cast(0 as bit) as EditaEmbarques, '' Observaciones, 0 Base_Ganancias, 0 TipoCtaProv, '' TipoCtaProvDescripcion
			FROM genCancMov INNER JOIN COMMOVPROV ON genCancMov.Asiento_id = COMMOVPROV.comMovProv
				INNER JOIN comProveedores ON COMMOVPROV.Proveed_Id = comProveedores.genEntidades
				INNER JOIN comMovTipos ON comMovTipos.TipoMov = commovprov.TipoMov
				inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
				INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
				INNER JOIN conAsientos conAsientos1 ON conAsientos1.conAsientos = genCancMov.Asiento_Id_ap
				INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
				inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
			--Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
			WHERE conAsientos1.Anulado = 0 and
				conAsientos1.Posteado = 1 and
				genCancMov.Importacion = 1 and
				commovprov.FacturaTesoreria = 0 and conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
				conAsientos.Empresa_Id =@Empresa and --tesRengMovicomMovProv.tesMovimientos Is Null And
				comProveedores.Proveed_Id =@Proveed_Id and
				genCancMov.FechaAplicacion < @FechaDesde and
				@PendHist = 2 and
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
			GROUP BY genMonedas.Moneda_Id

		UNION ALL
			-- Aplicacion de Importaciones
			SELECT 0 as comMovProv, ' ' TipoMov, 'Saldo Inicial' as Tipomovs, ' ' Segmento,
				DATEADD(dd,-1,@FechaDesde) as Fecha,
				SUM(genCancMov.Importe_Ap ) as Debe,
				0  as Haber,
				SUM(genCancMov.Importe_Ap ) as Saldo,
				SUM(genCancMov.Importe_Ap ) as SaldoAcum,
				0 CuotaNro,
				DATEADD(dd,-1,@FechaDesde) as FechaVenc, genMonedas.Moneda_Id, 1 Cambio,
				' ' Apellido_y_Nombres, DATEADD(dd,-1,@FechaDesde) ,
				0 AS XML, cast(0 as bit) as EditaEmbarques, '' Observaciones, 0 Base_Ganancias, 0 TipoCtaProv, '' TipoCtaProvDescripcion
			FROM genCancMov INNER JOIN COMMOVPROV ON genCancMov.Asiento_id_ap = COMMOVPROV.comMovProv
				INNER JOIN comProveedores ON COMMOVPROV.Proveed_Id = comProveedores.genEntidades
				INNER JOIN comMovTipos ON comMovTipos.TipoMov = commovprov.TipoMov
				inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
				INNER JOIN conAsientos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
				INNER JOIN conAsientos conAsientos1 ON conAsientos1.conAsientos = genCancMov.Asiento_Id
				INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
				inner join genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
			--Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
			WHERE conAsientos1.Anulado = 0 and
				conAsientos1.Posteado = 1 and
				genCancMov.Importacion = 1 and
				commovprov.FacturaTesoreria = 0 and conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
				conAsientos.Empresa_Id =@Empresa and --tesRengMovicomMovProv.tesMovimientos Is Null And
				comProveedores.Proveed_Id =@Proveed_Id and
				genCancMov.FechaAplicacion < @FechaDesde and
				@PendHist = 2 and
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id)
			GROUP BY genMonedas.Moneda_Id ) AS SI
	GROUP BY SI.comMovProv, SI.TipoMov, SI.Tipomovs, SI.Segmento, 
	SI.Fecha, si.CuotaNro, si.FechaVenc, si.Moneda_Id, si.Cambio, 
	si.Apellido_y_Nombres, si.FechaRegistro, si.XML, si.EditaEmbarques, 
	si.Observaciones, si.Base_Ganancias, Si.TipoCtaProv, si.TipoCtaProvDescripcion
	having  SUM(SI.Saldo) <> 0
ORDER BY 5, 15

--inventario
Select ' ' as Deposito_Id, ' ' as Producto_Id, ' ' as Descripcion, ' ' Medida_Id, 0.00 as Cantidad, 0.00 as Costo, 0.00 as Total

--asiento contable
select ' ' as Cuenta_Id, ' ' as Descripcion, ' ' as Centro1_Id, ' ' as Centro2_Id, 0.00 as Debe, 0.00 as Haber, ' ' LeyendaLibroMayor

--aplicaciones
select ' ' as Segmento, convert(datetime,null) as Fecha, 0.00 as Importe, ' ' as Usuario, cast(0 as bit) as Seleccionar, cast (0 as bigint) as Asiento_Id,
	cast(0 as smallint) as NroCuota, 0 as NroAplicacion, cast (0 as bigint) as AsientoApli_Id, cast (0 as bigint) as AsiDifCambio_Id,
	0.00 as Importe_Ap, cast(0 as bit) as Importacion



--impuestos
select ' ' as Impuesto_Id, ' ' as Descripcion, 0.00 as Base, 0.00 as Porcentaje, 0.00 as Importe

--orden de compra
select ' ' as Segmento, convert(datetime,null) as Fecha

--valores
select ' ' as Cartera, ' ' as Descripcion, 0.00 as importe, ' ' as NumeroDoc, convert(datetime, null) as FechaDoc

--Comprobantes
select cast(0 as bigint) as Asiento_Id, ' ' as Segmento, convert(datetime ,null) as Fecha, 0.00 as Importe, 0.00 as Saldo, cast(0 as smallint) as NroCuota, 0.00 as ImporteAplicado

--CompAAplic
select cast(0 as bigint) as Asiento_Id, cast(0 as smallint) as Cuota_Nro, 0.00 as Importe, 0.00 as Signo

--Embarques
select cast(0 as bigint) as comEmbarque, cast(0 as bigint) as comMovProv, '' as Segmento_Id, 0 as Segmento1N, 0 as Segmento2N,
	0 as Segmento3N, 0 as Segmento4N, '' as Segmento1C, '' as Segmento2C, '' as Segmento3C, '' as Segmento4C, '' as SegmentoSTR

--Oc y Emb
exec comConsEdoCtaOcEmbDatos 0

--- Adjuntos
exec genAdjuntosDatos 'comMovprov', 0,0

GO




DROP PROCEDURE comConsEdoCtaProveedoresEliminarXML
GO
CREATE PROCEDURE comConsEdoCtaProveedoresEliminarXML(
	@pcomMovProv bigint
)

as
update comMovProv set XMLFiscal='',ClaveFiscal=Null where comMovProv = @pcomMovProv




go

