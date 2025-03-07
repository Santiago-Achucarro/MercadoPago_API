Drop procedure impPercPba
Go
--impPercPba 1, '20220413','20220430'
Create procedure impPercPba
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pCodActi7 as Sino
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, @pCodActi7 CodActividad7

Select ltrim(rtrim(genEntidades.Cuit))+
		convert(char(10),conAsientos.Fecha,103)+case genAsisegmentos.segmento1c When 'R' then 'C' When  'I' then 'E' When 'E' then 'H'  When 'B' then 'I'
		else genAsisegmentos.segmento1c end +
		rTrim(ltrim(genasisegmentos.segmento3c))+RIGHT('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +RIGHT('00000000'+Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8) +
		case genAsisegmentos.segmento1c when 'R' then 
		'-'+RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(venMovimpuestos.BaseImponible*conAsientos.Cambio,0) as decimal(11,2)),1))),11)
		when 'E' then 
		'-'+RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(venMovimpuestos.BaseImponible*conAsientos.Cambio,0) as decimal(11,2)),1))),11)
		else 
		RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(venMovimpuestos.BaseImponible*conAsientos.Cambio,0) as decimal(12,2)),1))),12) 
		end+ 
		case genAsisegmentos.segmento1c when 'R' then 
		'-'+RIGHT(replicate('0',10)+ltrim(rtrim(convert(varchar(10),cast(ISNULL(venMovimpuestos.Importe*conAsientos.Cambio,0) as decimal(10,2)),1))),10) 
		 when 'E' then 
		'-'+RIGHT(replicate('0',10)+ltrim(rtrim(convert(varchar(10),cast(ISNULL(venMovimpuestos.Importe*conAsientos.Cambio,0) as decimal(10,2)),1))),10) 
		else 
		RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(venMovimpuestos.Importe*conAsientos.Cambio,0) as decimal(11,2)),1))),11) 
		end + Case When @pCodActi7 = 1 Then Convert(char(10),conAsientos.Fecha,103) Else '' End + 'A' Registro
		From venMovImpuestos
	 inner join venmovimientos on 
	 venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
	 inner join genentidades on 
	 venmovimientos.Cliente_Id= genEntidades.genEntidades
	 inner join venImpuestos on
	 venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
	 inner join conmovcont on 
	 venmovimpuestos.venMovimientos = conmovcont.conAsientos and 
	 venmovimpuestos.conRenglon = conmovcont.Renglon
	 inner join conasientos on 
	 venmovimpuestos.venmovimientos = conasientos.conasientos 
	 inner join genasisegmentos on 
	 genasisegmentos.asiento_id = conAsientos.conasientos
	 where 
	 conMovcont.Importe > 0 AND 
	 venImpuestos.TipoImpuesto = 1902 and  conAsientos.Anulado = 0 and 
	 conasientos.fecha Between @pFechaDesde And @pFechaHasta and 
	 conAsientos.empresa_Id = @pEmpresa_Id


	 Go


