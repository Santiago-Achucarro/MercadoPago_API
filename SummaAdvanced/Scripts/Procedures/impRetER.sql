
Drop procedure impRetER
Go
--impRetER 1, '20220101','20220713'
Create procedure impRetER
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
select cast(Cast(ROW_NUMBER() OVER( ORDER BY conAsientos.Fecha,genasisegmentos.segmento2c,genasisegmentos.segmento3c ) as int) as varchar(5)) 
+case genAsisegmentos.segmento1c when 'F' then '1' when 'D' then '2' else '102' end
+genasisegmentos.segmento3c+genasisegmentos.segmento2c+
RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)
+ substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
convert(char(10),conAsientos.Fecha,103)+
RIGHT(replicate('0',15)+ltrim(rtrim(convert(varchar(15),cast(ISNULL(Servicio.Importe,0)+ISNULL(Mercaderia.importe,0) as decimal(15,2)),1))),15) +
RIGHT(replicate('0',6)+ltrim(rtrim(convert(varchar(6),cast(ISNULL(tesRengMoviRetProv.porcentaje,0) as decimal(6,2)),1))),6)+
RIGHT(replicate('0',15)+ltrim(rtrim(convert(varchar(15),cast(ISNULL(conMovcont.Importe,0) as decimal(15,2)),1))),15) +'0'+
'011914' Registro
FROM tesRengMovi 
     INNER JOIN tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
     INNER JOIN tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
	 INNER JOIN tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
	 INNER JOIN conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
	 INNER JOIN tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
	 INNER JOIN conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
	 INNER JOIN genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
	 INNER JOIN comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
	 INNER JOIN comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
	 INNER JOIN genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
	 INNER JOIN comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
	 Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
	 left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
	 INNER JOIN tesRetProvSegmento on 
	 tesRetProvSegmento.segmento_id = tesIdRetProv.Segmento_Id and 
	 tesRetProvSegmento.tesMovimientos = tesMovimientos.tesMovimientos
	 inner join genJurisCoeficientes on 
	 genJurisCoeficientes.genentidades = genentidades.genentidades
	 	 where conAsientos.fecha between @pFechaDesde and @pFechaHasta
	 and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
	 and comMovprov.TipoMov = 'P'
	 and tesIdRetProv.TipoImpuesto = 1908
	 and conAsientos.Anulado = 0 


Go



