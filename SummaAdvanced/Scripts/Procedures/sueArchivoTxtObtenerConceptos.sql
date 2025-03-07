DROP PROCEDURE sueArchivoTxtObtenerConceptos
GO
CREATE PROCEDURE sueArchivoTxtObtenerConceptos
(
	@pLegajo int, 
	@pAnio int,
	@pMes int,
	@pQuincena int,
	@pVez int,
	@pSemana int,
	@pDecena int,
	@pEmpresa Int
)
As
Select sueConceptos.Concepto_Id, sueTerminada.Dato Cantidad, sueTerminada.Dato2, sueTerminada.Importe, sueTerminada.Signo
From sueTerminada
Inner Join suePersonal On suePersonal.genEntidades = sueTerminada.Legajo
Inner Join conAsientos On conAsientos.conAsientos = sueTerminada.sueLiquidacion
Inner Join sueLiquidacion On sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
Inner Join sueConceptos On sueConceptos.sueConceptos = sueTerminada.Concepto_Id
Where conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa And
	suePersonal.Legajo = @pLegajo And
	sueConceptos.Signo != 0 And
	sueLiquidacion.Anio = @pAnio And
	(@pMes = 0 Or sueLiquidacion.Mes = @pMes) And
	(@pQuincena = 0 Or sueLiquidacion.Quincena = @pQuincena) And 
	(@pVez = 0 Or sueLiquidacion.Vez = @pVez) And
	(@pSemana = 0 Or sueLiquidacion.Semana = @pSemana) And
	(@pDecena = 0 Or sueLiquidacion.Decena = @pDecena)
Go
