-- Inf_ComprasEjercicio 2019,1
DROP PROCEDURE Inf_ComprasEjercicio
GO
CREATE PROCEDURE Inf_ComprasEjercicio
(
	@Ejercicio Int,
	@Empresa_Id Int
)
as
select Ejercicio, Periodo, left(Mes,3) as Mes, sum(Cargos) as Cargos, sum(Abonos) as Abonos, 
	Sum(OtrosAbono - OtrosCargo) Otros , 
	sum(Abonos + OtrosAbono) Costo, SUM(DevCompras) AS DevCompras, 
	   SUM(Cargos - OtrosCargo - DevCompras) ComprasNetas, 
	   SUM(OtrosCargo) OtrosCargo , SUM(OtrosAbono) OtrosAbono,
	   ISNULL((SELECT SUM(Importe*(-2*Tipomov+3)) from 
		conasientos inner join conMovcont on 
		conasientos.conasientos = conMovcont.conasientos
		INNER JOIN conCuentas ON
			conCuentas.conCuentas = conmovcont.cuenta_id
		INNER JOIN conPeriodos ON 
			conAsientos.Fecha Between conPeriodos.Fecha_Desde AND conPeriodos.Fecha_Hasta
		Where
			conasientos.Especial = 'APE' and 
			conCuentas.tipo_id = 'MERCA' AND
			conPeriodos.Ejercicio = @Ejercicio),0) AS SaldoInicial


from (
SELECT conperiodos.Ejercicio, conperiodos.periodo, 
	DATENAME(MONTH,conPeriodos.Fecha_Hasta) Mes,
	SUM(CASE WHEN conCuentas.tipo_id ='MERCA' AND conMovCont.TipoMov= 1 THEN  conMovCont.importe ELSE 0 END) AS Cargos, 
	SUM(CASE WHEN conCuentas.tipo_id ='MERCA'  AND conMovCont.TipoMov = 2 THEN  conMovCont.importe ELSE 0 END) AS Abonos,
	SUM(CASE WHEN conCuentas.tipo_id NOT IN ('MERCA','COSTO','FACAR') AND conMovCont.TipoMov = 1  THEN conMovCont.Importe*(-2*conMovCont.Tipomov+3) ELSE 0 END)  as OtrosCargo,
	SUM(CASE WHEN conCuentas.tipo_id NOT IN ('MERCA','COSTO','FACAR') AND conMovCont.TipoMov = 2  THEN conMovCont.Importe*(-2*conMovCont.Tipomov+3) ELSE 0 END)  as OtrosAbono,
	SUM(CASE WHEN conCuentas.tipo_id = 'FACAR' AND conMovCont.Tipomov = 1 THEN conMovCont.Importe ELSE 0 END)  as DevCompras 
from conPeriodos inner join conAsientos ON 
	conAsientos.Fecha between conPeriodos.fecha_desde and conPeriodos.fecha_hasta 
	INNER JOIN conMovCont ON 
	conMovCont.conAsientos = conAsientos.conAsientos
	INNER JOIN conCuentas ON 		
	conCuentas.conCuentas = conMovCont.Cuenta_Id
	INNER JOIN stkMoviCabe ON
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
where
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conperiodos.Ejercicio = @Ejercicio
GROUP BY conperiodos.Ejercicio, conperiodos.periodo, conPeriodos.Fecha_Hasta
UNION ALL
SELECT conperiodos.Ejercicio, conperiodos.periodo, 
	DATENAME(MONTH,conPeriodos.Fecha_Hasta) Mes,
	SUM(CASE WHEN conCuentas.tipo_id ='MERCA' AND conMovCont.TipoMov= 1 THEN  conMovCont.importe ELSE 0 END) AS Cargos, 
	SUM(CASE WHEN conCuentas.tipo_id ='MERCA'  AND conMovCont.TipoMov = 2 THEN  conMovCont.importe ELSE 0 END) AS Abonos,
	0  as OtrosCargo,
	0 as OtrosAbono,
	0 as DevCompras 
from conPeriodos inner join conAsientos ON 
	conAsientos.Fecha between conPeriodos.fecha_desde and conPeriodos.fecha_hasta 
	INNER JOIN conMovCont ON 
	conMovCont.conAsientos = conAsientos.conAsientos
	INNER JOIN conCuentas ON 		
	conCuentas.conCuentas = conMovCont.Cuenta_Id
	
where
	NOT EXISTS(SELECT 1 FROM stkMoviCabe WHERE  stkMoviCabe.stkMoviCabe = conAsientos.conAsientos) AND
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conperiodos.Ejercicio = @Ejercicio
GROUP BY conperiodos.Ejercicio, conperiodos.periodo, conPeriodos.Fecha_Hasta

) as xxx
group by Ejercicio, Periodo, Mes
ORDER BY 1,2

GO

