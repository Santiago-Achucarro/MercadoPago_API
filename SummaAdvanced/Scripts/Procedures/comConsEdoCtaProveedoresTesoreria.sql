
-- comConsEdoCtaProveedoresTesoreria '0722','zzzzzzz',1, '20190401','20190531', NULL, 1
-- comConsEdoCtaProveedoresTesoreria 'Q001',2, '20170801','20171222', null, 1
 -- comConsEdoCtaProveedoresTesoreria 'Q001',2, '20170801','20171222', 'DOL', 1


DROP PROCEDURE comConsEdoCtaProveedoresTesoreria
GO
CREATE PROCEDURE comConsEdoCtaProveedoresTesoreria(
@Proveed_Id_Desde VarChar(15), 
@Proveed_Id_Hasta VarChar(15), 
@PendHist INT, 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@Moneda_Id VarChar(5)=NULL, 
@Empresa Int
)

AS
select @Proveed_Id_Desde as Proveed_Id_Desde,@Proveed_Id_Hasta  as Proveed_Id_Hasta,@PendHist as PendHist,
@FechaDesde as FechaDesde, @FechaHasta as FechaHasta,
@Moneda_Id as Moneda_Id, @Empresa as Empresa, ISNULL(comProveedores.RazonSocial, ' ') as RazonSocial, 
ISNULL(genMonedas.Descripcion,' ') as DescripcionMoneda, DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.FechaActual())) as FechaAplicacion, 
dbo.FechaActual() as FechaApli, 0 as Renglon, ' ' AS XmlUpload, '' as Xml, cast('' as char) as OrigenXml
FROM comProveedores 
LEFT OUTER JOIN genMonedas ON genMonedas.Moneda_id = @Moneda_Id
WHERE Proveed_Id between @Proveed_Id_Desde and @Proveed_Id_Hasta
	
SELECT  comProveedores.Proveed_Id, commovprov.comMovProv, 
comMovTipos.TipoMov, comMovTipos.Descripcion as Tipomovs, dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Segmento, 
	comMovProv.Fecha_CCP Fecha, case when comMovTipos.Signo=1  then 
		CASE WHEN @PendHist=1 THEN  genMovCuotas.Importe ELSE genMovCuotas.Importe END else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Debe,
	case when comMovTipos.Signo=-1  then 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Importe ELSE case when commovprov.FacturaTesoreria=1 then 0 else genMovCuotas.Importe end END  else 0 end 
		* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Haber, 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Saldo else case when commovprov.FacturaTesoreria=1 then 0 else genMovCuotas.Saldo end end * comMovTipos.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as Saldo, 
	CASE WHEN @PendHist=1 THEN  genMovCuotas.Saldo else case when commovprov.FacturaTesoreria=1 then 0 else genMovCuotas.Importe end end * comMovTipos.Signo 
	* case When @Moneda_Id IS NULL THEN dbo.func_TipoCambio(conAsientos.Moneda_id, @FechaHasta, @Empresa) else 1 end as SaldoAcum, 
	Convert(Int,genMovCuotas.CuotaNro) as CuotaNro,
	genMovCuotas.FechaVencimiento, genMonedas.Moneda_Id, conAsientos.Cambio, 
	genUsuarios.Apellido_y_Nombres, conAsientos.FechaRegistro, 
	CASE WHEN ISNULL(CONVERT(char(1),comMovProv.XMLFiscal), ' ') = ' ' THEN 0 ELSE 1 END AS XML, cast(0 as bit) as EditaEmbarques,
	conAsientos.Observaciones, comMovProv.Base_Ganancias, comProveedoresTipoPasivo.TipoCtaProv, comProveedoresTipoPasivo.Descripcion TipoCtaProvDescripcion
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
	comProveedores.Proveed_Id between @Proveed_Id_Desde and @Proveed_Id_Hasta
	and comMovProv.FacturaTesoreria = 1 And
	((CASE WHEN ISNULL(CONVERT(char(1),comMovProv.XMLFiscal), ' ') = ' ' THEN 0 ELSE 1 END = 0 and @PendHist = 1) OR
			(comMovProv.Fecha_CCP between @FechaDesde and @FechaHasta and @PendHist = 2)) and 
				genMonedas.Moneda_Id = ISNULL(@Moneda_Id, genMonedas.Moneda_Id) 
ORDER BY 5, 15

--inventario
Select ' ' as Deposito_Id, ' ' as Producto_Id, ' ' as Descripcion, ' ' Medida_Id, 0.00 as Cantidad, 0.00 as Costo, 0.00 as Total

--asiento contable
select ' ' as Cuenta_Id, ' ' as Descripcion, ' ' as Centro1_Id, ' ' as Centro2_Id, 0.00 as Debe, 0.00 as Haber

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

GO


