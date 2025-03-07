--tesCartera de tesRengMovi y conasientos y tesidentifica genusuarios 
--id descripcion y todos los movimientos por fecha agrupados
--inf_tesMovXCartera 'PESOS','PESOS', '20200401','20200401',' ','zzz',' ','zz',1

drop procedure inf_tesMovXCartera
go
create procedure inf_tesMovXCartera
(
@CarteraDesde varchar(5),
@CarteraHasta varchar(5),
@FechaDesde datetime,
@FechaHasta datetime, 
@Centro1Desde VarChar(8),
@Centro1Hasta VarChar(8),
@Centro2Desde VarChar(8),
@Centro2Hasta VarChar(8), 
@SucursalDesde VarChar(4),
@SucursalHasta VarChar(4),
@Empresa_Id Int
)
as

Select tesIdentifica.Cartera_Id,tesIdentifica.Descripcion, DATEADD(dd,-1, @FechaDesde) as Fecha ,
	'Saldo Inicial' as SegmentoSTR,
	case when sum(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2)))>0 then
	 sum(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3) as numeric(18,2))) else 0 end as Debito,
	case when sum(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2)))<0 then
	 -sum(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2))) else 0 end as Credito,
	sum(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3) as numeric(18,2))) as Saldo,
	SUM(cast(conMovCont.ImporteMonedaOriginal *(-2*conMovCont.TipoMov+3)as numeric(18,2))) as ImporteMonedaOriginal, 
		' ' Observaciones, ' ' Cuenta_Id,	' ' as DescripcionCuenta,
	conCentro1.Centro1_Id,conCentro1.Descripcion as DescripcionCentro1, 
	' ' Centro2_Id, ' '  as DescripcionCentro2, 'SI' as SubTipo_Id, '' as Usuario_Id
from tesIdentifica 
inner join tesRengMovi on tesRengMovi.Cartera_Id=tesIdentifica.tesIdentifica
inner join tesMovimientos on tesRengMovi.tesMovimientos=tesMovimientos.tesMovimientos
inner join conAsientos on tesMovimientos.tesMovimientos=conAsientos.conAsientos
inner join genUsuarios on conAsientos.Usuario_Id= genUsuarios.genUsuarios
inner join genAsiSegmentos on conAsientos.conAsientos=genAsiSegmentos.Asiento_Id
inner join conMovCont on conmovcont.conAsientos= conAsientos.conAsientos and conMovCont.Renglon=tesRengMovi.conRenglon
left join conCentro1 on conCentro1.conCentro1=isnull(conMovCont.Centro1_Id,1) 
left join conCentro2 on conCentro2.conCentro2=isnull(conMovCont.Centro2_Id,1)
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas
inner join tesSubTiposMov on tesMovimientos.SubTipo_Id=tesSubTiposMov.tesSubTiposMov
inner join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr =  conasientos.Sucursal
where 
	conAsientos.Empresa_Id = @Empresa_Id and 
	tesIdentifica.Cartera_Id between @CarteraDesde and @CarteraHasta and 
	conAsientos.Fecha < @FechaDesde  and 
	conAsientos.Anulado=0 and 
	conAsientos.Posteado=1 and 
	ISNULL(conCentro1.Centro1_Id,' ') BETWEEN @Centro1Desde and @Centro1Hasta and
	ISNULL(conCentro2.Centro2_Id,' ') BETWEEN @Centro2Desde and @Centro2Hasta  and 
	gensucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
GROUP BY tesIdentifica.Cartera_Id,tesIdentifica.Descripcion, 
	conCentro1.Centro1_Id,conCentro1.Descripcion
HAVING SUM(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2))) <> 0
UNION ALL
Select tesIdentifica.Cartera_Id,tesIdentifica.Descripcion, conAsientos.Fecha, dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as SegmentoSTR,
	case when (cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2)))>0 then
	 (cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2))) else 0 end as Debito,
	case when (cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2)))<0 then
	 -(cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2))) else 0 end as Credito,
	 (cast(conMovCont.Importe *(-2*conMovCont.TipoMov+3)as numeric(18,2))) as Saldo,
 cast(conMovCont.ImporteMonedaOriginal *(-2*conMovCont.TipoMov+3)as numeric(18,2)) as ImporteMonedaOriginal, conAsientos.Observaciones, conCuentas.Cuenta_Id,
  conCuentas.Descripcion as DescripcionCuenta,
conCentro1.Centro1_Id,conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
tesSubTiposMov.SubTipo_Id, genUsuarios.Usuario_Id
from tesIdentifica 
inner join tesRengMovi on tesRengMovi.Cartera_Id=tesIdentifica.tesIdentifica
inner join tesMovimientos on tesRengMovi.tesMovimientos=tesMovimientos.tesMovimientos
inner join conAsientos on tesMovimientos.tesMovimientos=conAsientos.conAsientos
inner join genUsuarios on conAsientos.Usuario_Id= genUsuarios.genUsuarios
inner join genAsiSegmentos on conAsientos.conAsientos=genAsiSegmentos.Asiento_Id
inner join conMovCont on conmovcont.conAsientos= conAsientos.conAsientos and conMovCont.Renglon=tesRengMovi.conRenglon
left join conCentro1 on conCentro1.conCentro1=conMovCont.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=conMovCont.Centro2_Id
inner join conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas
inner join tesSubTiposMov on tesSubTiposMov.tesSubTiposMov=tesMovimientos.SubTipo_Id
inner join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr =  conasientos.Sucursal
where 
	conAsientos.Empresa_Id = @Empresa_Id and 
	(tesIdentifica.Cartera_Id between @CarteraDesde and @CarteraHasta) and 
	(conAsientos.Fecha between @FechaDesde and @FechaHasta) and 
	conAsientos.Posteado=1 and 
	conAsientos.Anulado=0 and 
	ISNULL(conCentro1.Centro1_Id,' ') BETWEEN @Centro1Desde and @Centro1Hasta and
	ISNULL(conCentro2.Centro2_Id,' ') BETWEEN @Centro2Desde and @Centro2Hasta and 
	gensucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta
ORDER BY 1, 3, 10 
GO