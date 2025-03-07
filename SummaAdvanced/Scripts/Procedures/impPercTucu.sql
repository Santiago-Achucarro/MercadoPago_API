Drop procedure impPercTucu
Go
--impPercTucu 1, '20220901','20220930'
Create procedure impPercTucu
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
--Select  @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
Select cast(year(conAsientos.fecha) as char(4)) + Right(Replicate('0',2)+cast(Month(conAsientos.fecha) as varchar(2)),2) + Right('00'+cast(Day(conAsientos.fecha) as varchar(2)),2)+'80'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
Case When genAsisegmentos.segmento1c In ('F', 'I') Then (Case genasisegmentos.segmento3c When 'A' Then '01'  Else '06' End) 
When genAsisegmentos.segmento1c In ('D', 'B') Then (Case genasisegmentos.segmento3c When 'A' Then '02'  Else '07' End)
When genAsisegmentos.segmento1c In ('R', 'E') Then (Case genasisegmentos.segmento3c When 'A' Then '03' Else '08' End ) 
Else '09' End + 
rtrim(genasisegmentos.segmento3c)+Right('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +Right('00000000' + Ltrim(Rtrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+
Right(Replicate('0',16)+ltrim(rtrim(Convert(varchar(15),cast(isNull(venmovImpuestos.BaseImponibleMonedaNac,0) as decimal(15,2)),1))),15) +
Right(Replicate('0',6)+ltrim(rtrim(Convert(varchar(6),cast(isNull(venMovimpuestos.Porcentaje,0) as decimal(6,2)),1))),6)+
Right(Replicate('0',15)+ltrim(rtrim(Convert(varchar(15),cast(isNull(conMovcont.Importe,0) as decimal(15,2)),1))),15) 
--Right(Replicate('0',11)+substring(replace(venClientes.ibrutos,'-',''),1,11),11)
Registro
From venMovImpuestos
Inner Join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
Inner Join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
Inner Join venclientes on venclientes.genEntidades= genEntidades.genEntidades
Inner Join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
Inner Join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
Inner Join conAsientos on venmovimpuestos.venmovimientos = conAsientos.conAsientos 
Inner Join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conAsientos
Where 
conMovcont.Importe > 0 AND 
venImpuestos.TipoImpuesto = 1924 and  conAsientos.Anulado = 0 and 
conAsientos.fecha Between @pFechaDesde And @pFechaHasta and 
conAsientos.empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And conAsientos.Posteado = 1


GO

--Retper para percepciones....

Drop procedure impRetPerClie
Go
--impRetPerClie 1, '20220901','20220930'
Create procedure impRetPerClie
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
--Select  @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
Select '80'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
cast(venClientes.RAZONSOCIAL as char(40))+
cast(venClieHabitual.Direccion1_Fact as char(45))+
cast(vencliehabitual.Localidad_Fact as char(15))+
cast(genProvincias.Descripcion as char(15))+
Right(Replicate('0',11)+substring(replace(venClientes.ibrutos,'-',''),1,11),11)+
Right(Replicate('0',8)+rtrim(ltrim(substring(vencliehabitual.CodPostal_Fact,1,8))),8)
Registro
From venMovImpuestos
Inner Join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
Inner Join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
Inner Join venclientes on venclientes.genEntidades= genEntidades.genEntidades
Inner Join venClieHabitual on venclientes.genEntidades = venCliehabitual.genEntidades and vencliehabitual.Sucursal = venclientes.SucursalPredeter
Inner Join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
Inner Join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
Inner Join conAsientos on venmovimpuestos.venmovimientos = conAsientos.conAsientos 
Inner Join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conAsientos
Inner Join genProvincias on venClieHabitual.Provincia_Id_Fact = genProvincias.genProvincias
where 
conMovcont.Importe > 0 AND 
venImpuestos.TipoImpuesto = 1924 and
conAsientos.fecha Between @pFechaDesde And @pFechaHasta and 
conAsientos.empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And conAsientos.Posteado = 1


GO


--- Retper Reteciones...
Drop procedure impRetPerProv
Go
--impRetPerProv 1, '20220901','20220930'
Create procedure impRetPerProv
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
--Select  @pFechaDesde FechaDesde, @pFechaHasta FechaHasta
Select '80'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
cast(comProveedores.RAZONSOCIAL as char(40))+
cast(comProveedores.Direccion1 as char(45))+
cast(comProveedores.Localidad as char(15))+
cast(genProvincias.Descripcion as char(15))+
Right(Replicate('0',11)+substring(replace(comProveedores.IBrutos,'-',''),1,11),11)+
Right(Replicate('0',8)+rtrim(ltrim(substring(comProveedores.CodigoPostal,1,8))),8)
Registro
FROM tesRengMovi 
Inner Join tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
Inner Join tesIdRetProv on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
--Inner Join tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
--Inner Join conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
--Inner Join tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
Inner Join conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
Inner Join genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
Inner Join comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
Inner Join comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
Inner Join genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
Inner Join comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
Inner Join genProvincias on comProveedores.Provincia_Id = genProvincias.genProvincias
--Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
--left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
where conAsientos.fecha between @pFechaDesde and @pFechaHasta
and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
and comMovprov.TipoMov = 'P'
and tesIdRetProv.TipoImpuesto = 1924
And conAsientos.Anulado = 0 And conAsientos.Posteado = 1


Go


Drop procedure impPercRetTucu
Go
--impPercRetTucu 1, '20220901','20220930'
--impPercRetTucu 1, '20220413','20220430'
Create procedure impPercRetTucu
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
Select Convert(char(10),conAsientos.Fecha,103)+'80'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
Case When genAsisegmentos.segmento1c In ('F', 'I') Then (Case genasisegmentos.segmento3c When 'A' Then '01'  Else '06' End) 
When genAsisegmentos.segmento1c In ('D', 'B') Then (Case genasisegmentos.segmento3c When 'A' Then '02'  Else '07' End)
When genAsisegmentos.segmento1c In ('R', 'E') Then (Case genasisegmentos.segmento3c When 'A' Then '03' Else '08' End ) 
Else '09' End + 
rtrim(genasisegmentos.segmento3c)+Right('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +Right('00000000' + Ltrim(Rtrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+
Right(Replicate('0',16)+ltrim(rtrim(Convert(varchar(15),cast(isNull(venmovImpuestos.BaseImponibleMonedaNac,0) as decimal(15,2)),1))),15) +
Right(Replicate('0',6)+ltrim(rtrim(Convert(varchar(6),cast(isNull(venMovimpuestos.Porcentaje,0) as decimal(6,2)),1))),6)+
Right(Replicate('0',15)+ltrim(rtrim(Convert(varchar(15),cast(isNull(conMovcont.Importe,0) as decimal(15,2)),1))),15) +
Right(Replicate('0',11)+substring(replace(venClientes.ibrutos,'-',''),1,11),11)
Registro
From venMovImpuestos
Inner Join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
Inner Join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
Inner Join venclientes on venclientes.genEntidades= genEntidades.genEntidades
Inner Join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
Inner Join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
Inner Join conAsientos on venmovimpuestos.venmovimientos = conAsientos.conAsientos 
Inner Join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conAsientos
where 
conMovcont.Importe > 0 AND 
venImpuestos.TipoImpuesto = 1924 and
conAsientos.fecha Between @pFechaDesde And @pFechaHasta and 
conAsientos.empresa_Id = @pEmpresa_Id And conAsientos.Anulado = 0 And conAsientos.Posteado = 1
Union All
Select Convert(char(10),conAsientos.Fecha,103)+'80'+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+
Case When genAsisegmentos.segmento1c In ('F', 'I') Then (Case genasisegmentos.segmento3c When 'A' Then '01'  Else '06' End) 
When genAsisegmentos.segmento1c In ('D', 'B') Then (Case genasisegmentos.segmento3c When 'A' Then '02'  Else '07' End)
When genAsisegmentos.segmento1c In ('R', 'E') Then (Case genasisegmentos.segmento3c When 'A' Then '03' Else '08' End ) 
Else '09' End + 
rtrim(genasisegmentos.segmento3c)+Right('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) +Right('00000000' + Ltrim(Rtrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+
Right(Replicate('0',15)+ltrim(rtrim(Convert(varchar(15),cast(isNull(Servicio.Importe,0)+isNull(Mercaderia.importe,0) as decimal(15,2)),1))),15) +
Right(Replicate('0',6)+ltrim(rtrim(Convert(varchar(6),cast(isNull(tesRengMoviRetProv.porcentaje,0) as decimal(6,2)),1))),6)+
Right(Replicate('0',15)+ltrim(rtrim(Convert(varchar(15),cast(isNull(conMovcont.Importe,0) as decimal(15,2)),1))),15) +
Right(Replicate('0',11)+substring(replace(comProveedores.ibrutos,'-',''),1,11),11)
Registro
FROM tesRengMovi 
Inner Join tesMovimientos on tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
Inner Join tesidretprov on tesRengMovi.Cartera_Id = tesIdRetProv.Cartera_Id
Inner Join tesidentifica on tesIdRetProv.Cartera_Id = tesIdentifica.tesIdentifica
Inner Join conMovcont on conMovcont.conAsientos = tesRengMovi.tesMovimientos and conMovcont.Renglon = tesRengMovi.conRenglon
Inner Join tesRengMoviRetProv on tesRengMoviRetProv.tesMovimientos = conMovcont.conAsientos and tesRengMoviRetProv.conRenglon = conMovcont.Renglon
Inner Join conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
Inner Join genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id 
Inner Join comMovprov on tesMovimientos.tesMovimientos = comMovprov.comMovprov
Inner Join comProveedores on comMovprov.Proveed_Id = comProveedores.genEntidades
Inner Join genEntidades on comProveedores.genEntidades = genEntidades.genEntidades
Inner Join comCondFiscal on comProveedores.CondFiscal_Id = comCondFiscal.comCondFiscal
Left join tesMoviGravado Servicio on Servicio.tesMovimientos = tesMovimientos.tesMovimientos and Servicio.TipoCtaProv = 2 
left join tesMoviGravado Mercaderia on Mercaderia.tesMovimientos = tesMovimientos.tesMovimientos and Mercaderia.TipoCtaProv = 1
where conAsientos.fecha between @pFechaDesde and @pFechaHasta
and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
and comMovprov.TipoMov = 'P'
and tesIdRetProv.TipoImpuesto = 1924
And conAsientos.Anulado = 0 And conAsientos.Posteado = 1

Go


Drop procedure impPercNCTucu
Go
--impPercNCTucu 1, '20220901','20220930'
Create procedure impPercNCTucu
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
Select 
--rtrim(genasisegmentos.segmento3c)+
Right('0000'+Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4) ++Right('00000000' + Ltrim(Rtrim(Convert(varchar(8),genAsiSegmentos.Segmento1N))),8)+
Right('0000'+Ltrim(Rtrim(venApli.Segmento2C)),4) + Right('00000000' + Ltrim(Rtrim(Convert(varchar(8),venApli.Segmento1N))),8)+
Case When genAsisegmentos.segmento1c In ('F', 'I') Then (Case genasisegmentos.segmento3c When 'A' Then '01'  Else '06' End) 
When genAsisegmentos.segmento1c In ('D', 'B') Then (Case genasisegmentos.segmento3c When 'A' Then '02'  Else '07' End)
When genAsisegmentos.segmento1c In ('R', 'E') Then (Case genasisegmentos.segmento3c When 'A' Then '03' Else '08' End ) 
Else '09' End
Registro
From venMovImpuestos 
Inner Join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
Inner Join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
Inner Join venclientes on venclientes.genEntidades= genEntidades.genEntidades
Inner Join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
Inner Join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
Inner Join conAsientos on venmovimpuestos.venmovimientos = conAsientos.conAsientos 
Inner Join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conAsientos
LEFT JOIN (genCancMov Inner Join VenMovimientos VenMov ON genCancMov.Asiento_Id = VenMov.venMovimientos
	Inner Join conAsientos conAsi ON venMov.venMovimientos = conAsi.conAsientos AND conAsi.Anulado = 0
	Inner Join genAsiSegmentos genAsiSeg ON conAsi.conAsientos = genAsiSeg.Asiento_Id) ON conAsientos.conAsientos = genCancMov.Asiento_Id_Ap 
Inner Join genasisegmentos venApli on venApli.Asiento_Id = gencancmov.Asiento_Id
where 
conMovcont.Importe > 0 AND genAsisegmentos.segmento1c In ('R', 'E') and 
conAsientos.fecha between @pFechaDesde and @pFechaHasta
and genAsiSegmentos.Empresa_Id = @pEmpresa_Id
and venImpuestos.TipoImpuesto = 1924
And conAsientos.Anulado = 0 And conAsientos.Posteado = 1

