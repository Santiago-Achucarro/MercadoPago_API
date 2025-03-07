Drop procedure impPercSantaFe
Go
--impPercSantaFe 1, '20220101','20220730'
Create procedure impPercSantaFe
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones

Select '2'+convert(char(10),conAsientos.Fecha,103)+'559'+
case genasisegmentos.segmento1C when 'F' then '01' When 'D' Then '02' Else '09'  end +
rtrim(genasisegmentos.segmento3c)+RIGHT('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+'    '+
convert(char(10),conAsientos.Fecha,103)+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(venmovimientos.Importe,0) as decimal(12,2)),1))),12) +
'3'+substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
case venclientes.situacion when '1' then '1' when '2' then '1' else '2' end +
case venclientes.situacion when '1' then RIGHT(replicate('0',10)+substring(replace(venClientes.ibrutos,'-',''),1,10),10) 
when '2' then RIGHT(replicate('0',10)+substring(replace(venClientes.ibrutos,'-',''),1,10),10) else '0000000000' end +
case venCondFiscal.codigoFiscal when '01' then '1' when '02' then '2' when '03' then '0' when '04' then '3' when '06' then '4' when '11' then '1' 
else '5' end+
'00'+'000000000,00'+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(TotalIva.Importe,0) as decimal(12,2)),1))),12) +
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(venmovImpuestos.BaseImponibleMonedaNac,0) as decimal(12,2)),1))),12) +
RIGHT(replicate('0',5)+ltrim(rtrim(convert(varchar(5),cast(ISNULL(venMovimpuestos.Porcentaje,0) as decimal(5,2)),1))),5)+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(conMovcont.Importe,0) as decimal(12,2)),1))),12)+ '000000000,00'+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(conMovcont.Importe,0) as decimal(12,2)),1))),12)+
Case genjuriscoeficientes.situacion when '4' then '005' 
when '1' then (case genjuriscoeficientes.coeficiente when 0 then '005' else '001' end )
when '2' then (case genjuriscoeficientes.coeficiente when 0 then '005' else '002' end ) end 
Renglon
From venMovImpuestos
inner join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
inner join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
inner join venclientes on venclientes.genEntidades= genEntidades.genEntidades
inner join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
inner join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
inner join conasientos on venmovimpuestos.venmovimientos = conasientos.conasientos 
inner join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conasientos
inner join venCondFiscal on venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
inner join (Select venmovimpuestos.venmovimientos, Sum(venMovimpuestos.Importe*conAsientos.Cambio) Importe From venMovimpuestos 
inner join venImpuestos on venMovImpuestos.Impuesto_Id=venImpuestos.venImpuestos 
	inner join impTipoImpuesto on impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
	inner join conasientos on conasientos.conAsientos=venmovimpuestos.venMovimientos 
	Where impTipoImpuesto.TipoImpuesto between 1001 and 1009
	Group by venMovImpuestos.venMovimientos) TotalIva on TotalIva.venMovimientos = venmovimientos.venMovimientos
inner join genJurisCoeficientes on genJurisCoeficientes.genentidades= genentidades.genentidades
Where 
conMovcont.Importe > 0 AND 
venImpuestos.TipoImpuesto = 1921 and  conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
conAsientos.Fecha Between @pFechaDesde And @pFechaHasta and 
conAsientos.Empresa_Id = @pEmpresa_Id


GO

Drop procedure impRetSantaFe
Go
--impRetTucu 1, '20220101','20220731'
Create procedure impRetSantaFe
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
select '1'+convert(char(10),conAsientos.Fecha,103)+'515'+
'08'+
rtrim(genasisegmentos.segmento3c)+RIGHT('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+'    '+
convert(char(10),conAsientos.Fecha,103)+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(comMovprov.Importe,0) as decimal(12,2)),1))),12) +
'3'+substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
case genJurisCoeficientes.Situacion when '1' then '1' when '2' then '1' else '2' end +
case genJurisCoeficientes.Situacion when '1' then RIGHT(replicate('0',10)+substring(replace(comProveedores.IBrutos,'-',''),1,10),10) 
when '2' then RIGHT(replicate('0',10)+substring(replace(comProveedores.ibrutos,'-',''),1,10),10) else '0000000000' end +
case comCondFiscal.codigoFiscal when '01' then '1' when '02' then '2' when '03' then '0' when '04' then '3' when '06' then '4' when '11' then '1' 
else '5' end+
'00'+'000000000,00'+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(Iva.Importe,0) as decimal(12,2)),1))),12) +
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(Servicio.Importe,0)+ISNULL(Mercaderia.importe,0) as decimal(12,2)),1))),12) +
RIGHT(replicate('0',5)+ltrim(rtrim(convert(varchar(5),cast(ISNULL(tesRengMoviRetProv.porcentaje,0) as decimal(5,2)),1))),5)+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(conMovcont.Importe,0) as decimal(12,2)),1))),12)+ '000000000,00'+
RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(conMovcont.Importe,0) as decimal(12,2)),1))),12)+
Case genjuriscoeficientes.situacion when '4' then '005' 
when '1' then (case genjuriscoeficientes.coeficiente when 0 then '005' else '001' end )
when '2' then (case genjuriscoeficientes.coeficiente when 0 then '005' else '002' end ) end 
Renglon
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
inner join genJurisCoeficientes on genJurisCoeficientes.genentidades= genentidades.genentidades
inner join (SELECT ccp.asiento_id_ap, SUM(Importe_Impuesto) Importe 
	FROM genCancMov ccp
	inner join comMovImpuestos cmi on ccp.Asiento_Id_Ap = cmi.comMovprov 
	inner join comImpuestos ci on ci.comImpuestos = cmi.Impuesto_Id
	inner join impTipoImpuesto on ci.TipoImpuesto = impTipoImpuesto.TipoImpuesto
	Where impTipoImpuesto.TipoImpuesto between 1001 and 1009
	Group by ccp.asiento_id_ap) IVA on iva.Asiento_Id_Ap = tesmovimientos.tesMovimientos
Where conAsientos.Fecha between @pFechaDesde and @pFechaHasta
and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
and comMovprov.TipoMov = 'P'
and tesIdRetProv.TipoImpuesto = 1921
and conAsientos.Anulado = 0 And conAsientos.Posteado = 1

Go



