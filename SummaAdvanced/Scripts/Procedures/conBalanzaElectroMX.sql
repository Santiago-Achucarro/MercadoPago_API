Drop procedure conBalanzaElectroMX
go
create procedure conBalanzaElectroMX
(
@pAnio int,
@pMes int,
@pNivel Int,
@pEmpresa int
)
as
select @pAnio as Anio, @pMes as Mes,@pNivel as Nivel
declare @FechaDesde datetime, @FechaDesdeE datetime, @FechaHasta datetime

set @FechaDesdeE = (select Fecha_Desde from conPeriodos where Ejercicio=@pAnio and Periodo=1 and Empresa_Id=@pEmpresa)

if @pMes = 13
begin

set @FechaHasta = (select Fecha_Hasta from conPeriodos where Ejercicio=@pAnio and Periodo=12 and Empresa_Id=@pEmpresa)

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel , conCuentas.Imputable,
	SUM(case when conAsientos.Especial != 'CIR' Then 	conMovCont.Importe * (-2*conMovCont.Tipomov+3) else 0 end/**case when conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END*/) as Saldoinicial,
	SUM(case when conAsientos.Especial != 'CIR' and conMovCont.Tipomov=1	then  conMovCont.Importe else 0 end) as Debe,
	SUM(case when conAsientos.Especial != 'CIR' and  conMovCont.Tipomov=2	then  conMovCont.Importe else 0 end) as Haber,
	ISNULL(SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3)/**case when conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END */),0) as SaldoiFinal,conCuentas.Naturaleza
FROM conCuentas
LEFT OUTER JOIN (conMovCont INNER JOIN conAsientos ON
	conAsientos.conAsientos = conMovCont.conAsientos AND 
	conAsientos.Fecha between @FechaDesdeE and @FechaHasta and
	conAsientos.Empresa_Id = @pEmpresa) ON 
	conMovCont.Cuenta_Id = conCuentas.conCuentas 
Where
	conAsientos.Especial NOT IN ('CCP') AND
	conAsientos.Anulado = 0 and 
	conCuentas.Imputable = 1 AND 
	conAsientos.Posteado= 1 and
	ISNULL(conCuentas.Empresa_Id,@pEmpresa) = @pEmpresa 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel , conCuentas.Imputable,conCuentas.Naturaleza
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel, conCuentas.Imputable, 
	0,0,0 ,0,conCuentas.Naturaleza
from conCuentas
where
	Imputable = 0 and 
	Nivel = @pNivel and 
	ISNULL(conCuentas.Empresa_Id,@pEmpresa) = @pEmpresa 
ORDER BY 1

end

ELSE

begin

set @FechaDesde= (select Fecha_Desde from conPeriodos where Ejercicio=@pAnio and Periodo=@pMes and Empresa_Id=@pEmpresa)
set @FechaHasta = (select Fecha_Hasta from conPeriodos where Ejercicio=@pAnio and Periodo=@pMes and Empresa_Id=@pEmpresa)

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel , conCuentas.Imputable,
	SUM(case when conAsientos.Fecha < @FechaDesde  or conAsientos.Especial = 'APE' Then 
		conMovCont.Importe * (-2*conMovCont.Tipomov+3) else 0 end /*case when conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END*/) 		as Saldoinicial,
	SUM(case when conAsientos.Especial <> 'APE' AND  conAsientos.Fecha >= @FechaDesde and conMovCont.Tipomov=1	then  conMovCont.Importe else 0 end) as Debe,
	SUM(case when conAsientos.Especial <> 'APE' AND  conAsientos.Fecha >= @FechaDesde and  conMovCont.Tipomov=2	then  conMovCont.Importe else 0 end) as Haber,
	ISNULL(SUM(conMovCont.Importe * (-2*conMovCont.Tipomov+3)/**case when conCuentas.Naturaleza ='A' THEN -1 ELSE 1 END*/ ),0)	as SaldoiFinal,conCuentas.Naturaleza
FROM conCuentas
LEFT OUTER JOIN (conMovCont INNER JOIN conAsientos ON
	conAsientos.conAsientos = conMovCont.conAsientos AND 
	conAsientos.Fecha between @FechaDesdeE and @FechaHasta and
	conAsientos.Empresa_Id = @pEmpresa) ON 
	conMovCont.Cuenta_Id = conCuentas.conCuentas 
Where
	conAsientos.Especial NOT IN ('CCP','CIR') AND
	conAsientos.Anulado = 0 and 
	conCuentas.Imputable = 1 AND 
	conAsientos.Posteado= 1 and
	ISNULL(conCuentas.Empresa_Id,@pEmpresa) = @pEmpresa 
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel , conCuentas.Imputable,conCuentas.Naturaleza
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, conCuentas.Nivel, conCuentas.Imputable, 
	0,0,0 ,0,conCuentas.Naturaleza
from conCuentas
where
	Imputable = 0 and 
	Nivel = @pNivel and 
	ISNULL(conCuentas.Empresa_Id,@pEmpresa) = @pEmpresa 
ORDER BY 1
end
go


