Drop procedure impPercSalta
Go
--impPercSalta 1, '20220801','20220930'
Create procedure impPercSalta
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
select replace(convert(char(10),conAsientos.Fecha,103),'/','')+
case genasisegmentos.segmento1C when 'F' then genasisegmentos.segmento1C+'A'+'_'+genasisegmentos.segmento3C 
when 'I' then 'F'+'A'+'_'+genasisegmentos.segmento3C 
when 'D' then 'N'+'D'+'_'+genasisegmentos.segmento3C 
when 'R' then 'N'+'C'+'_'+genasisegmentos.segmento3C 
when  'E' then 'N'+'C'+'_'+genasisegmentos.segmento3C 
else 'OTRO'End +
RIGHT(REPLICATE('0',20)+RIGHT('00000000'+Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8),20) +
--RIGHT('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +RIGHT('00000000'+Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8),20) +
Left(lTrim(rTrim(venClientes.RazonSocial))+Replicate(' ',60),60)+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
RIGHT(replicate('0',16)+ltrim(rtrim(convert(varchar(20),cast(ISNULL(venMovimpuestos.BaseImponibleMonedaNac,0) as decimal(16,2)),1))),16)+
RIGHT(replicate('0',5)+ltrim(rtrim(convert(varchar(5),cast(ISNULL(venMovimpuestos.Porcentaje,0) as decimal(5,2)),1))),5) +
Case When Signo = -1 Then '-' Else '0' End + -- Si es NC signo -
RIGHT(replicate('0',15)+ltrim(rtrim(convert(varchar(16),cast(ISNULL(conMovCont.Importe,0) as decimal(16,2)),1))),16) Renglon
From venMovImpuestos
inner join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
inner join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
INNER JOIN VENCLIENTES ON genEntidades.genEntidades = venClientes.genEntidades
inner join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
inner join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
inner join conasientos on venmovimpuestos.venmovimientos = conasientos.conasientos 
inner join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conasientos
inner join venTipomov on venMovimientos.venTipoMov = ventipomov.venTipoMov
Where 
conMovcont.Importe > 0 AND 
venImpuestos.TipoImpuesto = 1917 and  conAsientos.Anulado = 0 and 
conasientos.fecha Between @pFechaDesde And @pFechaHasta and 
conAsientos.empresa_Id = @pEmpresa_Id


	 Go




