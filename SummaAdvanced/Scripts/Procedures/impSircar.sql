-- FM 23/09/2022 13169 le quité el producto *Cambio en conMovCont.Importe que ya está en pesos --
Drop procedure impSircarRet
Go
--impSircarRet 1, '921','20220801','20220930',2
Create procedure impSircarRet
(
@pEmpresa_Id int,
@pJurisdiccion varchar(3) ,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pOpcion int

)
As

Select @pEmpresa_Id Empresa_Id, @pJurisdiccion Jurisdiccion, Descripcion DescripJurisdiccion,@pFechaDesde FechaDesde, @pFechaHasta FechaHasta, @pOpcion Opcion
from impJurisdicciones 
where impJurisdicciones.impJurisdicciones = dbo.funcFKimpJurisdicciones(@pJurisdiccion)
		

Select a.Renglon 
From 
	(Select RIGHT('00000'+lTrim(Rtrim(cast(ROW_NUMBER() OVER(ORDER BY genAsiSegmentos.Segmento1N ASC) as varchar(8)))),5) +',1,'+
	'01'+','+
	genAsiSegmentos.Segmento2c+RIGHT('00000000'+Ltrim(Rtrim(convert(varchar(8),tesRetProvSegmento.Segmento1N))),8)+','+
	--genAsiSegmentos.Segmento1C+','+genAsiSegmentos.Segmento4C+','+genAsiSegmentos.Segmento2c+RIGHT('00000000'+Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+','+
	+ltrim(rtrim(replace(genEntidades.Cuit,'-','')))+','+convert(char(10),conAsientos.Fecha,103)+','+
	RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(tesRengMoviRetProv.BaseImponible,0) as decimal(12,2)),1))),12)+','+
	RIGHT(replicate('0',6)+ltrim(rtrim(convert(varchar(6),cast(ISNULL(tesRengMoviRetProv.Porcentaje,0) as decimal(6,2)),1))),6)+','+
	RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(conMovcont.Importe,0) as decimal(12,2)),1))),12)+','+
	RIGHT(replicate('0',3)+ltrim(rtrim(convert(varchar(3),cast(ISNULL(tesidretprov.NroResSicore,0) as int),1))),3)+','+@pJurisdiccion Renglon
	From tesRengMoviRetProv
	inner join tesrengmovi on tesRengMoviRetProv.tesMovimientos = tesrengmovi.tesmovimientos and tesrengmoviretprov.conRenglon = tesRengMovi.conRenglon
	inner join conMovcont on tesRengMoviRetProv.tesMovimientos = conmovcont.conAsientos and tesRengMoviRetProv.conRenglon = conmovcont.Renglon 
	inner join conasientos on conMovCont.conAsientos = conAsientos.conAsientos 
	inner join comMovprov on tesRengMoviRetProv.tesmovimientos = comMovprov.comMovprov
	inner join comProveedores on comMovprov.Proveed_Id = comproveedores.genEntidades
	inner join genEntidades on comProveedores.genEntidades= genentidades.genEntidades
	inner Join genasiSegmentos on genAsiSegmentos.Asiento_Id = tesRengMoviRetProv.tesMovimientos
	inner join comMovtipos on comMovProv.TipoMov = comMovtipos.TipoMov
	inner join tesIdRetProv on tesIdRetProv.Cartera_Id = tesrengmovi.Cartera_Id
	inner join tesRetProvSegmento on tesRetProvSegmento.tesmovimientos = tesRengMovi.tesMovimientos and 
	tesRetProvSegmento.conRenglon = tesrengmovi.conRenglon
	inner join tesIdentifica on tesIdentifica.tesIdentifica = tesrengmovi.Cartera_Id
	inner join impTipoImpuesto on impTipoImpuesto.TipoImpuesto = tesIdRetProv.TipoImpuesto
	inner join impjurisdicciones on impjurisdicciones.impjurisdicciones = imptipoimpuesto.juris_id
	Where  conAsientos.Empresa_Id = @pEmpresa_id and
	conAsientos.fecha between @pFechaDesde and @pFechaHasta and 
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	impjurisdicciones.Juris_Id = @pJurisdiccion) a

		 
Go

Drop procedure impSircarPer
Go


--impSircarPer 1, '908','20220901','20220930',2
Create procedure impSircarPer
(
@pEmpresa_Id int,
@pJurisdiccion varchar(3) ,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pOpcion int

)
As

Select @pEmpresa_Id Empresa_Id, @pJurisdiccion Jurisdiccion, Descripcion DescripJurisdiccion,@pFechaDesde FechaDesde, @pFechaHasta FechaHasta, @pOpcion Opcion
from impJurisdicciones 
where impJurisdicciones.impJurisdicciones = dbo.funcFKimpJurisdicciones(@pJurisdiccion)


--cast(ISNULL(venImpuestos.NroResSicore,0) as decimal(12,2)),1)))
select a.Renglon 
From 
	(Select RIGHT('00000'+lTrim(Rtrim(cast(ROW_NUMBER() OVER(ORDER BY genAsiSegmentos.Segmento1N ASC) as varchar(8)))),5) +','+
	Right('000'+ltrim(rtrim(cast(IsNull(
	Case When genAsiSegmentos.Segmento3C <> 'E' Then
		Case When genAsiSegmentos.Segmento1C In ('F', 'I') Then 1 When genAsiSegmentos.Segmento1C In ('D', 'B') Then 2
		When genAsiSegmentos.Segmento1C In ('R', 'E') Then 102 End
	Else -- Comprobantes de Exportacion --
		Case When genAsiSegmentos.Segmento1C In ('F', 'I') Then 5 When genAsiSegmentos.Segmento1C In ('D', 'B') Then 6
		When genAsiSegmentos.Segmento1C In ('R', 'E') Then 106 End
	End
	, 0) as varchar(3)))),3)+','+
	genAsiSegmentos.Segmento3C+','+genAsiSegmentos.Segmento2c+RIGHT('00000000'+Ltrim(Rtrim(convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+','+
	ltrim(rtrim(replace(genEntidades.Cuit,'-','')))+','+convert(char(10),conAsientos.Fecha,103)+','+
	Case When genAsiSegmentos.Segmento1C In ('R', 'E') Then
		'-' + RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(venMovImpuestos.BaseImponibleMonedaNac,0) as decimal(11,2)),1))),11)+',' -- 13268
	Else
		RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(venMovImpuestos.BaseImponibleMonedaNac,0) as decimal(12,2)),1))),12)+','
	End +
	RIGHT(replicate('0',6)+ltrim(rtrim(convert(varchar(6),cast(ISNULL(venMovImpuestos.Porcentaje,0) as decimal(6,2)),1))),6)+','+
	Case When genAsiSegmentos.Segmento1C In ('R', 'E') Then
		'-' + RIGHT(replicate('0',11)+ltrim(rtrim(convert(varchar(11),cast(ISNULL(venMovImpuestos.importe,0) as decimal(11,2)),1))),11)+',' -- 13268
	Else
		RIGHT(replicate('0',12)+ltrim(rtrim(convert(varchar(12),cast(ISNULL(venMovImpuestos.importe,0) as decimal(12,2)),1))),12)+','
	End + 
	RIGHT(replicate('0',3)+ltrim(rtrim(convert(varchar(3),cast(genAtributosValores.ValorN as int),1))),3)+','+@pJurisdiccion Renglon
	from venMovimientos
	inner join conasientos on venmovimientos.venmovimientos = conasientos.conasientos
	inner join venMovimpuestos on venMovimpuestos.venmovimientos = venmovimientos.venMovimientos
	inner join genentidades on venmovimientos.Cliente_Id = genentidades.genentidades
	inner Join genasiSegmentos on genAsiSegmentos.Asiento_Id = venMovimientos.venmovimientos
	inner join venImpuestos on venmovimpuestos.Impuesto_Id= venImpuestos.venImpuestos
	inner join impTipoImpuesto on impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
	left outer join venMovimientosFiscal on conasientos.conAsientos = venMovimientosFiscal.venMovimientos
	inner join impjurisdicciones on impjurisdicciones.impjurisdicciones = imptipoimpuesto.juris_id
	left outer join genAtributosValores on genAtributosValores.Identity_Id = venimpuestos.venImpuestos and genAtributosValores.AtributoNro = 1
	Where conAsientos.Empresa_Id = @pEmpresa_id and 
	conAsientos.fecha between @pFechaDesde and @pFechaHasta and 
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	impjurisdicciones.Juris_Id = @pJurisdiccion) a
		 
Go
