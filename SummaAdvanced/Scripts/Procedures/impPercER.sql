Drop procedure impPercER
Go
--impPercER 1, '20220801','20220930'
Create procedure impPercER
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
select RIGHT('00000' +
cast(Cast(ROW_NUMBER() OVER( ORDER BY conAsientos.Fecha,genasisegmentos.segmento2c,genasisegmentos.segmento3c) as int) as varchar(5)),5)+','+
RIGHT('000' +(case genAsisegmentos.segmento1c when 'F' then '1' when 'D' then '2' else '102' end),3)
+','+genasisegmentos.segmento3c+','+genasisegmentos.segmento2c+
+RIGHT('00000000' + Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)
+','++ substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
+','+convert(char(10),conAsientos.Fecha,103)+
+',' + Case when venTipoMov.Signo = 1 Then '0' Else '-' End + -- 13170. Las NC van con signo negativo --
RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(venMovImpuestos.BaseImponibleMonedaNac,0) as decimal(11,2)),1))),11) +
+','+RIGHT(replicate('0',6)+ltrim(rtrim(convert(varchar(6),cast(ISNULL(venMovimpuestos.Porcentaje,0) as decimal(6,2)),1))),6)+
+','+ Case when venTipoMov.Signo = 1 Then '0' Else '-' End + -- 13170. Las NC van con signo negativo --
RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(conMovcont.Importe,0) as decimal(11,2)),1))),11)+
',001,908' Registro
From venMovImpuestos
inner join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
inner join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
inner join venclientes on venclientes.genEntidades= genEntidades.genEntidades
inner join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
inner join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
inner join conasientos on venmovimpuestos.venmovimientos = conasientos.conasientos 
inner join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conasientos
Inner Join venTipoMov On venTipoMov.venTipoMov = venMovimientos.venTipoMov
--inner join genJurisCoeficientes on genJurisCoeficientes.genentidades = genentidades.genentidades
	 where 
	 conMovcont.Importe > 0 AND 
	 venImpuestos.TipoImpuesto = 1908 and  conAsientos.Anulado = 0 and 
	 conasientos.fecha Between @pFechaDesde And @pFechaHasta and 
	 conAsientos.empresa_Id = @pEmpresa_Id

Go



