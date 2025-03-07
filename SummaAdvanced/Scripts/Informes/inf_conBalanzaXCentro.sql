-- inf_conBalanzaXCentro '20210901','20210930', ' ','ZZZ',' ','ZZZ','4','9z',1, 1, 'es-MX'
-- inf_conBalanzaXCentro '20180101','20181031', ' ','ZZZ',' ','ZZZ','1140-101','1140-101',1, 0, 'en-US'

-- inf_conBalanzaXCentro '20180101','20181031', ' ','ZZZ',' ','ZZZ','1140-102','1140-102',1, 0
drop procedure inf_conBalanzaXCentro
go
create procedure inf_conBalanzaXCentro
(
@FechaDesde datetime,
@FechaHasta datetime,
@Centro1Desde varchar(8),
@Centro1Hasta varchar(8),
@Centro2Desde varchar(8),
@Centro2Hasta varchar(8),
@CuentaDesde varchar(25),
@CuentaHasta varchar(25),
@Empresa_Id int,
@PorAlternativo bit, 
@Cultura VarChar(5)=null
)
as

Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))


if(@PorAlternativo=0)
begin
select conCuentas.Cuenta_Id, 
CASE WHEN @EnOtro=1 THEN conCuentas.Description else 
	conCuentas.Descripcion end as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
sum(case when conMovCont.TipoMov=1 then Importe else 0 end) as Debe, 
sum (case when conMovCont.TipoMov=2 then Importe else 0 end) as Haber

from conAsientos
inner join conMovCont on conAsientos.conAsientos=conMovCont.conAsientos
inner join conCentro1 on ISNULL(conMovCont.Centro1_Id,1)=conCentro1.conCentro1
inner join conCentro2 on ISNULL(conMovCont.Centro2_Id,1)=conCentro2.conCentro2
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
left join conAsientosCon on conAsientosCon.conAsientos = conAsientos.conAsientos
inner join genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
where 
(conAsientos.Fecha >= genEmpresas.FechaInicioSumma or conAsientosCon.conAsientos is Not null) and
conAsientos.Anulado = 0 and
conAsientos.Posteado = 1 and 
conCentro1.Centro1_Id between @Centro1Desde and @Centro1Hasta and
conAsientos. Fecha between @FechaDesde and @FechaHasta and
conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and
conAsientos.Empresa_Id=@Empresa_Id
Group by conCuentas.Cuenta_Id,conCuentas.Descripcion,conCentro2.Centro2_Id,conCentro2.Descripcion, 
conCentro1.Centro1_Id,conCentro1.Descripcion, concuentas.Description
order by 3,1,5
end
else
begin
select conCuentas.Cuenta_Id, 
CASE WHEN @EnOtro=1 THEN conCuentas.Description else 
	conCuentas.Descripcion end  as DescripcionCuenta, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
sum(case when conMovCont.TipoMov=1 then Importe else 0 end) as Debe, sum (case when conMovCont.TipoMov=2 then Importe else 0 end) as Haber

from conAsientos
inner join conMovCont on conAsientos.conAsientos=conMovCont.conAsientos
inner join conCentro1 on ISNULL(conMovCont.Centro1_Id,1)=conCentro1.conCentro1
inner join conCentro2 on ISNULL(conMovCont.Centro2_Id,1)=conCentro2.conCentro2
inner join conCuentas on conCuentas.conCuentas=conMovCont.Cuenta_Id
left join conAsientosCon on conAsientosCon.conAsientos = conAsientos.conAsientos
inner join genEmpresas ON genEmpresas.genEmpresas = conAsientos.Empresa_Id
where 
(conAsientos.Fecha >= genEmpresas.FechaInicioSumma or conAsientosCon.conAsientos is Not null) and
conAsientos.Anulado = 0 and
conAsientos.Posteado = 1 and 
conCentro2.Centro2_Id between @Centro2Desde and @Centro2Hasta and
conAsientos. Fecha between @FechaDesde and @FechaHasta and
conCuentas.Cuenta_Id between @CuentaDesde and @CuentaHasta and
conAsientos.Empresa_Id=@Empresa_Id
Group by conCuentas.Cuenta_Id,conCuentas.Descripcion,
conCentro1.Centro1_Id,conCentro1.Descripcion, conCentro2.Centro2_Id,conCentro2.Descripcion,
	conCuentas.Description
order by 5,1,3
end
go
