-- tesIdentificaSaldo 'BN772',1
drop procedure tesIdentificaSaldo
go
create procedure tesIdentificaSaldo
(
@pCartera_Id varchar(5),
@pEmpresa INT
)
as

--Saldos
select tesIdentifica.Cartera_Id, sum(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as SaldoContable, sum(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as SaldoBanco from tesMovimientos 
inner join conAsientos on conAsientos.conAsientos=tesMovimientos.tesMovimientos
inner join conMovCont on conMovCont.conAsientos=conAsientos.conAsientos
inner join tesRengMovi on tesRengMovi.tesMovimientos=conAsientos.conAsientos and tesrengmovi.conRenglon=conMovCont.Renglon
inner join tesIdentifica on tesRengMovi.Cartera_Id=tesIdentifica.tesIdentifica
where 
	tesIdentifica.Cartera_Id=@pCartera_Id and
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @pEmpresa
group by tesIdentifica.Cartera_Id
declare @Fecha DateTime

Set @Fecha = dbo.fechasinhora(Getdate())

--Debitos
select tesIdentifica.Cartera_Id, 
	sum(case when tesCheqProp.FechaVencimiento = dateadd(dd,1,@Fecha) then Importe else 0 end) as Importe24, 
	sum(case when tesCheqProp.FechaVencimiento = dateadd(dd,2,@Fecha) then Importe else 0 end) as Importe48, 
	sum(case when tesCheqProp.FechaVencimiento > dateadd(dd,2,@Fecha) then Importe else 0 end) as Importe72
from tesIdentifica inner join tesRengMovi on tesRengMovi.Cartera_Id= tesIdentifica.tesIdentifica
inner join conAsientos on tesRengMovi.tesMovimientos = conAsientos.conAsientos
inner join conMovCont on conMovCont.conAsientos=tesRengMovi.tesMovimientos and tesRengMovi.conRenglon=conMovCont.Renglon
inner join tesBPlink on  tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos and  tesBPlink.conRenglon = tesRengMovi.conRenglon
inner join tesCheqProp on tesBPlink.tesCheqProp=tesCheqProp.tesCheqProp
Where
	tesCheqProp.FechaVencimiento > GETDATE() and
	tesRengMovi.TipomovCont = 2 and 
	tesIdentifica.Cartera_Id=@pCartera_Id and
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @pEmpresa
	GROUP BY tesIdentifica.Cartera_Id

--Creditos

select tesIdentifica.Cartera_Id, 
	sum(case when DATEADD(dd,tesCheqTerceros.ClearingDias, conAsientos.Fecha) = dateadd(dd,1,@Fecha) then Importe else 0 end) as Importe24, 
	sum(case when DATEADD(dd,tesCheqTerceros.ClearingDias, conAsientos.Fecha) = dateadd(dd,2,@Fecha) then Importe else 0 end) as Importe48, 
	sum(case when DATEADD(dd,tesCheqTerceros.ClearingDias, conAsientos.Fecha) > dateadd(dd,2,@Fecha) then Importe else 0 end) as Importe72
from tesIdentifica inner join tesRengMovi on tesRengMovi.Cartera_Id= tesIdentifica.tesIdentifica
inner join tesRengmovi tesRengmovi2 on tesRengmovi2.tesMovimientos = tesRengmovi.tesMovimientos and tesRengmovi.conRenglon != tesRengmovi2.conRenglon
inner join conAsientos on tesRengMovi.tesMovimientos = conAsientos.conAsientos
inner join conMovCont on conMovCont.conAsientos=tesRengMovi2.tesMovimientos and tesRengMovi2.conRenglon=conMovCont.Renglon
inner join tesCTlink on  tesCTlink.tesMovimientos = tesRengMovi2.tesMovimientos and  tesCTlink.conRenglon = tesRengMovi2.conRenglon
inner join tesCheqTerceros on tesCheqTerceros.tesCheqTerceros=tesCTlink.tesCheqTerceros
inner join tesMovimientos ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
inner join tesSubTiposMov on tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
Where
	tesSubTiposMov.SubTipo_Id = 'DE3' AND 
	tesIdentifica.Cartera_Id=@pCartera_Id and
	conAsientos.Anulado = 0 AND
	conAsientos.Posteado = 1 and
	conAsientos.Empresa_Id = @pEmpresa and
	tesRengMovi.TipomovCont = 1
	GROUP BY tesIdentifica.Cartera_Id



go
