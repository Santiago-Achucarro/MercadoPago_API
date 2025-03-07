-- EXEC Inf_sueVacaciones 2021,0,9999,1
DROP PROCEDURE Inf_sueVacaciones
GO
CREATE PROCEDURE Inf_sueVacaciones(
	@Anio Int,
	@LegajoDesde Int, 
	@LegajoHasta int, 
	@Empresa_Id Int
)
as
SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno,
suePersonal.ApellidoMaterno, suePersonal.Nombres, 
suePersonal.FechaIngreso, ISNULL(sueVacCorresponden.Dias,sueVacTomadas.Dias) Corresponden,
ISNULL(sueVacTomadas.FechaDesde,'') FechaDesde, ISNULL(sueVacTomadas.FechaHasta,'') FechaHasta, 
ISNULL(sueVacTomadas.Dias,0) Dias, 0 Saldo
FROM suePersonal 
	LEFT JOIN sueVacTomadas ON suePersonal.genEntidades = sueVacTomadas.Legajo AND
		sueVacTomadas.Anio = @Anio
	LEFT JOIN sueVacCorresponden ON suePersonal.genEntidades = sueVacCorresponden.Legajo AND
		sueVacCorresponden.Anio = @Anio
WHERE
	suePersonal.Empresa_Id= @Empresa_Id and 
	suePersonal.Legajo between @LegajoDesde and @LegajoHasta AND 
	ISNULL(sueVacCorresponden.Dias,sueVacTomadas.Dias) IS NOT NULL
ORDER BY 1,7
GO

--SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno,
--suePersonal.ApellidoMaterno, suePersonal.Nombres, 
--suePersonal.FechaIngreso, ISNULL(suePersonal.FechaBaja,'') FechaBaja,
--ISNULL((SELECT sueVacCorresponden.Dias FROM sueVacCorresponden where
--	sueVacCorresponden.Legajo = suePersonal.genEntidades and 
--	sueVacCorresponden.Anio = @Anio),0)  as Corresponden,
--ISNULL((SELECT sueVacCorresponden.Saldo FROM sueVacCorresponden where
--	sueVacCorresponden.Legajo = suePersonal.genEntidades and 
--	sueVacCorresponden.Anio = @Anio),0)  as Saldo
--from suePersonal 
--where
--	suePersonal.Empresa_Id= @Empresa_Id and 
--	suePersonal.Legajo between @LegajoDesde and @LegajoHasta
--ORDER BY 1
--

