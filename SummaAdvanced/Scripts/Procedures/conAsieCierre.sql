--set transaction isolation level read uncommitted
-- conAsieCierreResDATOS 1,2021
-- conAsieCierrePatDATOS 1,2021

DROP PROCEDURE conAsieCierreResDATOS
GO
CREATE PROCEDURE conAsieCierreResDATOS
(
	@Empresa INT, 
	@Ejercicio smallint
	

)
AS
set transaction isolation level read uncommitted
DECLARE @FechaDesdeE Datetime
DECLARE @FechaDesdeH Datetime
Set @FechaDesdeE = (Select MIN(Fecha_Desde) From conPeriodos Where Ejercicio = @Ejercicio AND Empresa_Id = @Empresa)
Set @FechaDesdeH = (Select MAX(Fecha_HASTA) From conPeriodos Where Ejercicio = @Ejercicio AND Empresa_Id = @Empresa)



SELECT @Ejercicio AS Ejercicio

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, ISNULL(conCentro1.Centro1_Id,' ') as Centro1_Id, 
	ISNULL(conCentro2.Centro2_Id,' ') as Centro2_Id, Sum(-conMovCont.Importe*(-2*conMovCont.Tipomov+3)) as Monto
from conCuentas 
INNER JOIN conMovCont ON conCuentas.conCuentas = conMovCont.Cuenta_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos 
--INNER JOIN conPeriodos ON conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta and 
--	conPeriodos.Empresa_Id = conAsientos.Empresa_Id
INNER JOIN conRubros ON conRubros.Rubro_Id = conCuentas.Rubro_Id
inner join genEmpresas on conAsientos.Empresa_Id=genEmpresas.genEmpresas
left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
Left Join conCentro1 On conCentro1.conCentro1 = conMovCont.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = conMovCont.Centro2_Id
WHERE
	(conAsientos.Fecha>= genEmpresas.FechaInicioSumma or conAsientosCon.conAsientos IS Not NULL) AND
	conAsientos.Empresa_Id = @Empresa  and
	conAsientos.Fecha between @FechaDesdeE and @FechaDesdeH and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado=1and
	conRubros.Tipo NOT IN ('ACT','PAS','CAP', 'ORD')
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, ISNULL(conCentro1.Centro1_Id,' '), ISNULL(conCentro2.Centro2_Id,' ')
HAVING sum(conMovCont.Importe*(-2*conMovCont.Tipomov+3)) <> 0
order by 1	

GO




DROP PROCEDURE conAsieCierrePatDATOS
GO
CREATE PROCEDURE conAsieCierrePatDATOS
(
	@Empresa INT, 
	@Ejercicio smallint
	

)
AS
set transaction isolation level read uncommitted
DECLARE @FechaDesdeE Datetime
DECLARE @FechaDesdeH Datetime
Set @FechaDesdeE = (Select MIN(Fecha_Desde) From conPeriodos Where Ejercicio = @Ejercicio AND Empresa_Id = @Empresa)
Set @FechaDesdeH = (Select MAX(Fecha_HASTA) From conPeriodos Where Ejercicio = @Ejercicio AND Empresa_Id = @Empresa)



SELECT @Ejercicio AS Ejercicio

SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	ISNULL(conCentro1.Centro1_Id,' ') as Centro1_id, 
	ISNULL(conCentro2.Centro2_Id,' ') as Centro2_id, 
	sum(-conMovCont.Importe*(-2*conMovCont.Tipomov+3)) as Monto
from conCuentas INNER JOIN conMovCont ON
 conCuentas.conCuentas = conMovCont.Cuenta_Id
 INNER JOIN conAsientos ON
 conAsientos.conAsientos = conMovCont.conAsientos 
 --INNER JOIN conPeriodos ON 
 --conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta and 
 --conPeriodos.Empresa_Id = conAsientos.Empresa_Id
 INNER JOIN conRubros ON
 conRubros.Rubro_Id = conCuentas.Rubro_Id
 LEFT JOIN conCentro1 ON conCentro1.conCentro1 = conMovCont.Centro1_Id
 LEFT JOIN conCentro2 ON conCentro2.conCentro2 = conMovCont.Centro2_Id
 inner join genEmpresas on genEmpresas.genEmpresas=conAsientos.Empresa_Id
 left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
 WHERE
	conAsientos.Empresa_Id = @Empresa  and
	conAsientos.Fecha between @FechaDesdeE and @FechaDesdeH and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado=1and
	(conAsientos.Fecha>= genEmpresas.FechaInicioSumma or conAsientosCon.conAsientos IS Not NULL) and
	conRubros.Tipo IN ('ACT','PAS','CAP', 'ORD')
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	ISNULL(conCentro1.Centro1_Id,' ') , ISNULL(conCentro2.Centro2_Id,' ') 
HAVING sum(conMovCont.Importe*(-2*conMovCont.Tipomov+3)) <> 0
order by 1	

GO


DROP PROCEDURE conAsieCierreDATOS
GO
CREATE PROCEDURE conAsieCierreDATOS
(
	@Empresa INT, 
	@Ejercicio smallint,
	@CtaResEjer VarChar(25),
	@CtaResAcum VarChar(25)
)
AS

SELECT @Ejercicio AS Ejercicio, @CtaResEjer CtaResEjer,	 ' ' as DescripcionCtaResEjer,
@CtaResAcum CtaResAcum,	 ' ' as DescripcionCtaResAcum

select conAsientos.conAsientos, conAsientos.Especial, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C
FROM conAsientos INNER JOIN conPeriodos ON
  conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta and 
  conPeriodos.Empresa_Id = conAsientos.Empresa_Id
  inner join genAsiSegmentos ON
  genAsiSegmentos.Asiento_Id = conAsientos.conAsientos 
  INNER JOIN genSegmentos ON
  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE
	conAsientos.Especial IN ('CCP','CIR') AND 
	conAsientos.Empresa_Id = @Empresa AND 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado=1 and
	conPeriodos.Ejercicio = @Ejercicio
GO	

DROP PROCEDURE conAsieApeDATOS
GO
CREATE PROCEDURE conAsieApeDATOS
(
	@Empresa INT, 
	@Ejercicio smallint
)
AS
SELECT @Ejercicio AS Ejercicio

select conAsientos.conAsientos, conAsientos.Especial, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
	genAsiSegmentos.Segmento4C
FROM conAsientos INNER JOIN conPeriodos ON
   conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta and 
   conPeriodos.Empresa_Id = conAsientos.Empresa_Id
  inner join genAsiSegmentos ON
  genAsiSegmentos.Asiento_Id = conAsientos.conAsientos 
  INNER JOIN genSegmentos ON
  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE
	conAsientos.Especial = 'APE' AND 
	conAsientos.Empresa_Id = @Empresa AND 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado=1 and
	conPeriodos.Ejercicio = @Ejercicio

GO	




