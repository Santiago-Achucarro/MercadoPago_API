DROP PROCEDURE suePagosHabiGuardar
GO
CREATE PROCEDURE suePagosHabiGuardar
(
@psueLiquidacion bigint,
@ptesMovimientos bigint = NULL,
@pFechaHabilitacion qFecha= NULL,
@pImporte qMonedaD2,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM suePagosHabi WHERE (sueLiquidacion = @psueLiquidacion)))
BEGIN 
	UPDATE suePagosHabi
	SET		tesMovimientos = @ptesMovimientos,
		FechaHabilitacion = @pFechaHabilitacion,
		Importe = @pImporte,
		Usuario_Id = @pUsuario_Id
	WHERE (sueLiquidacion = @psueLiquidacion)
END 
ELSE 
BEGIN 
	INSERT INTO suePagosHabi
	(
		sueLiquidacion,
		tesMovimientos,
		FechaHabilitacion,
		Importe,
		Usuario_Id
	)
	VALUES 
	(
		@psueLiquidacion,
		@ptesMovimientos,
		@pFechaHabilitacion,
		@pImporte,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE suePagosHabiDatos
GO
CREATE PROCEDURE suePagosHabiDatos
(
@psueLiquidacion bigint
)
AS
SET NOCOUNT ON 

SELECT suePagosHabi.sueLiquidacion, sueLiquidacion.Descripcion as DescripcionLiquidacion, 
	suePagosHabi.tesMovimientos, 
	suePagosHabi.FechaHabilitacion as FechaHabilitacion, 
	suePagosHabi.Importe, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Decena, 
	sueLiquidacion.Semana, sueLiquidacion.Vez
FROM suePagosHabi 
INNER JOIN sueLiquidacion  ON (sueLiquidacion.sueLiquidacion = suePagosHabi.sueLiquidacion)
LEFT JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = suePagosHabi.tesMovimientos)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = suePagosHabi.Usuario_Id)
WHERE (sueLiquidacion.sueLiquidacion = @psueLiquidacion)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePagosHabiEliminar
GO
CREATE PROCEDURE suePagosHabiEliminar
(
@psueLiquidacion bigint
)
AS
SET NOCOUNT ON 

DELETE FROM suePagosHabi 
WHERE (sueLiquidacion = @psueLiquidacion)
 
 RETURN @@Error 

GO

GO


DROP PROCEDURE suePagosHabiPendDatos
GO
CREATE PROCEDURE suePagosHabiPendDatos
(
	@Empresa_Id int
)
AS
SET NOCOUNT ON 

SELECT @Empresa_Id as Empresa_Id

SELECT sueLiquidacion.sueLiquidacion, sueLiquidacion.Descripcion as DescripcionLiquidacion, 
	sueLiquidacion.PorEmpleado,
	ISNULL(suePagosHabi.FechaHabilitacion, sueLiquidacion.FechaPago) as FechaHabilitacion, 
	suePagosHabi.Importe, 	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	Cast(case when suePagosHabi.FechaHabilitacion IS NULL THEN 0 ELSE 1 END as Bit) as Marca, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id,  genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, 
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento,
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Decena, 
	sueLiquidacion.Semana, sueLiquidacion.Vez
FROM sueLiquidacion
Left JOIN suePagosHabi ON (sueLiquidacion.sueLiquidacion = suePagosHabi.sueLiquidacion)
LEFT JOIN genUsuarios ON (genUsuarios.genUsuarios = suePagosHabi.Usuario_Id)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id =sueLiquidacion.sueLiquidacion
INNER JOIN genEmpresas ON genEmpresas.genEmpresas = genAsiSegmentos.Empresa_Id 
WHERE 
	genEmpresas.FechaCierreSueldos < sueLiquidacion.FechaContabilizacion and
	suePagosHabi.tesMovimientos IS NULL and 
	genAsiSegmentos.Empresa_Id = @Empresa_Id
	

-- por empleado
exec suePagosHabiPorEmpleadoDatos 0,0,0

 
RETURN @@Error 

GO


