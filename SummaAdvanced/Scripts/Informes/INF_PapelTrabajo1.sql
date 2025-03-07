-- INF_PapelTrabajo1 2019,'INPC',1
-- INF_PapelTrabajo1Ind 2019,'INPC',1
-- repote de axi
DROP PROCEDURE INF_PapelTrabajo1
go
CREATE PROCEDURE INF_PapelTrabajo1
(
	@Ejercicio Int, 
	@Indice_Id VarChar(5),
	@Empresa_Id Int,
	@Periodo Int
)
AS
SELECT Rubro_Id, RubroAxi_Id, Descripcion, P01, P02, P03, P04, P05, P06, 
	P07, P08, P09, P10, P11, P12, 
	Convert(Numeric(18,2), (P01 + P02 + P03 + P04 + P05 + P06 + P07 + P08 + P09 + P10 + P11 + P12)) as Total,
	Convert(Numeric(18,2), (P01 + P02 + P03 + P04 + P05 + P06 + P07 + P08 + P09 + P10 + P11 + P12) / Periodos) as Promedio,
	Periodos
FROM 
(
SELECT conRubrosAxi.Rubro_Id,
		conRubrosAxi.RubroAxi_Id, conRubrosAxi.Descripcion, 
			ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 1 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 1),0) as P01, 

ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 2 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 						
						conperiodos.Periodo <= 2),0) as P02, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 3 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 3),0) as P03, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 4 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 4),0) as P04, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 5 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 5),0) as P05, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 6 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 6),0) as P06, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 7 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 7),0) as P07, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 8 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 8),0) as P08, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 9 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 9),0) as P09, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 10 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 10),0) as P10, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 11 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 11),0) as P11, 
ISNULL((SELECT SUM(conMovCont.Importe*(-2*conMovCont.tipomov+3))
				from conasientos INNER JOIN conmovcont ON
					conasientos.conasientos  = conmovcont.conasientos
					INNER JOIN conCuentas ON
					conCuentas.conCuentas = conmovcont.Cuenta_Id and 
					conCuentas.RubroAxi_Id = conRubrosAxi.conRubrosAxi
					INNER JOIN conperiodos ON
					conasientos.fecha between conperiodos.fecha_desde and conperiodos.fecha_hasta
					Where
						conAsientos.Anulado = 0 and 
						conAsientos.Posteado = 1 and
						concuentas.Ajustable = 1 and 
						@Periodo >= 12 and 
						conasientos.Empresa_id = @Empresa_Id and 
						conasientos.especial NOT IN ('CCP','CIR','AXI') AND 
						conperiodos.Ejercicio = @Ejercicio and 
						conperiodos.Periodo <= 13),0) as P12, 
						(Select count(1) from conPeriodos INNER JOIN genEmpresas ON
							genEmpresas.genEmpresas = @Empresa_Id AND 
							conPeriodos.Fecha_Desde >= genEmpresas.FechaInicioSociedad and 
							conPeriodos.Ejercicio = @Ejercicio and 
							conPeriodos.Periodo <= @Periodo) as Periodos
from conRubrosAxi inner join conRubros ON 
	conRubros.Rubro_Id = conRubrosAxi.Rubro_Id
where 
	conRubros.Tipo  in ('ACT','PAS')
) AS XXX
ORDER BY 1,2

GO


DROP PROCEDURE INF_PapelTrabajo1Ind
go
CREATE PROCEDURE INF_PapelTrabajo1Ind
(
	@Ejercicio Int, 
	@Indice_Id VarChar(5),
	@Empresa_Id Int, 
	@Periodo Int
)
AS
SELECT 
isnull((Select conIndAjusCuerpo.Indice 
from conIndAjusCuerpo 
	INNER JOIN conIndicesAjustes ON conIndicesAjustes.conIndicesAjuste =conIndAjusCuerpo.Indice_Id
	INNER JOIN conPeriodos ON conPeriodos.Ejercicio =conIndAjusCuerpo.Ejercicio and 
						conPeriodos.Periodo =conIndAjusCuerpo.Periodo

Where
		conPeriodos.Periodo = 12 and 
		conPeriodos.Ejercicio = @Ejercicio-1 and 
		conPeriodos.Empresa_Id = @Empresa_Id and 
		conIndicesAjustes.Indice_Id = @Indice_Id),1) AS IndiceInicial,
isnull((Select conIndAjusCuerpo.Indice 
from conIndAjusCuerpo 
	INNER JOIN conIndicesAjustes ON conIndicesAjustes.conIndicesAjuste =conIndAjusCuerpo.Indice_Id
	INNER JOIN conPeriodos ON conPeriodos.Ejercicio =conIndAjusCuerpo.Ejercicio and 
		conPeriodos.Periodo =conIndAjusCuerpo.Periodo
Where
		conPeriodos.Periodo = @Periodo and 
		conPeriodos.Ejercicio = @Ejercicio and 
		conPeriodos.Empresa_Id = @Empresa_Id and 
		conIndicesAjustes.Indice_Id = @Indice_Id),1) AS IndiceFinal
GO