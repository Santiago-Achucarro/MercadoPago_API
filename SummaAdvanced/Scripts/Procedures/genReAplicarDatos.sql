DROP PROCEDURE genReAplicarDatos
GO
CREATE PROCEDURE genReAplicarDatos(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@Empresa_Id Int
)

as

SELECT @FechaDesde AS FechaDesde, @FechaHasta AS FechaHasta


SELECT genCancMov.FechaAplicacion,
    genCancMov.NroAplicacion , genCancMov.Asiento_Id, genCancMov.CuotaNro,  genCancMov.Asiento_Id_Ap,  genCancMov.CuotaNro_Ap,
	genCancMov.AsientoApli_Id , genCancMov.AsieDifCambio_Id, genCancMov.EsAplicOriginal, genCancMov.EsVentaContado, genCancMov.Usuario_Id, 
	genCancMov.Importacion, genCancMov.Importe, genCancMov.Importe_Ap
FROM genCancMov	
	inner join conAsientos ON conAsientos.conAsientos =genCancMov.Asiento_Id
	inner join conAsientos conAsientosAP ON conAsientosAP.conAsientos =genCancMov.Asiento_Id_Ap
WHERE
	conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 and 
	conAsientosAP.Anulado = 0 AND conAsientosAP.Posteado = 1 AND
	genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta and
	conAsientos.Empresa_Id = @Empresa_Id
	ORDER BY 1,2
GO


DROP PROCEDURE genCancMovCambioAsiApli
GO
CREATE PROCEDURE genCancMovCambioAsiApli(
	@pAsiento_Id BigInt, 
	@pCuotaNro Int, 
	@pAsiento_Id_Ap BigInt, 
	@pCuotaNro_Ap Int, 
	@pNroAplicacion int, 
	@pAsientoApli_Id BigInt = NULL
)
AS

Update genCancMov SET AsientoApli_Id = @pAsientoApli_Id 
WHERE
	Asiento_Id = @pAsiento_Id and CuotaNro = @pCuotaNro and 
	Asiento_Id_Ap =@pAsiento_Id_Ap and CuotaNro_Ap = @pCuotaNro_Ap and 
	NroAplicacion = @pNroAplicacion
GO


DROP PROCEDURE genCancMovCambioAsiDC
GO
CREATE PROCEDURE genCancMovCambioAsiDC(
	@pAsiento_Id BigInt, 
	@pCuotaNro Int, 
	@pAsiento_Id_Ap BigInt, 
	@pCuotaNro_Ap Int, 
	@pNroAplicacion int, 
	@pAsieDifCambio_Id BigInt = NULL
)
AS

Update genCancMov SET AsieDifCambio_Id = @pAsieDifCambio_Id
WHERE
	Asiento_Id = @pAsiento_Id and CuotaNro = @pCuotaNro and 
	Asiento_Id_Ap =@pAsiento_Id_Ap and CuotaNro_Ap = @pCuotaNro_Ap and 
	NroAplicacion = @pNroAplicacion
GO