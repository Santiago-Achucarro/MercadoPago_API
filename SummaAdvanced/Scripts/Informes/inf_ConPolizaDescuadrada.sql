-- exec inf_ConPolizaDescuadrada '20210101','20211231',1

drop procedure inf_ConPolizaDescuadrada
go
create procedure inf_ConPolizaDescuadrada(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id Int
)
AS

SELECT vgenAsiSegmentos.Segmento, vgenAsiSegmentos.Segmento_Id, 
	disFormularios.Descripcion, 
SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as Diferencia
from conAsientos 
	LEFT JOIN vgenAsiSegmentos ON vgenAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	LEFT JOIN disFormularios ON disFormularios.disFormularios = conAsientos.Formulario_Id
	inner join conMovCont ON conMovCont.conAsientos=conAsientos.conAsientos
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon on  conAsientosCon.conAsientos = conAsientos.conAsientos
	WHERE
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos.Empresa_Id = @Empresa_Id and 
		conAsientos.Fecha between @FechaDesde and @FechaHasta and 
		(conAsientosCon.conAsientos is not null or
		conAsientos.Fecha >= genEmpresas.FechaInicioSumma )
GROUP BY vgenAsiSegmentos.Segmento, vgenAsiSegmentos.Segmento_Id, 
	disFormularios.Descripcion
having SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) <> 0
ORDER BY 2,1
GO

	