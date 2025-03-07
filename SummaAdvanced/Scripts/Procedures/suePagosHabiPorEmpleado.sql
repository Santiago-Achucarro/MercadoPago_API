DROP PROCEDURE suePagosHabiPorEmpleadoGuardar
GO
CREATE PROCEDURE suePagosHabiPorEmpleadoGuardar
(
@pSecuencia int,
@pLegajo int,
@psueLiquidacion bigint,
@ptesMovimientos bigint = NULL,
@pFechaHabilitacion qFecha = NULL,
@pImporte qMonedaD2,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM suePagosHabiPorEmpleado WHERE (Secuencia = @pSecuencia) AND 
	(Legajo = dbo.FuncFksuePersonal(@pLegajo)) AND (sueLiquidacion = @psueLiquidacion)))
BEGIN 
	UPDATE suePagosHabiPorEmpleado
	SET		tesMovimientos = @ptesMovimientos,
		FechaHabilitacion = @pFechaHabilitacion,
		Importe = @pImporte,
		Usuario_Id = @pUsuario_Id
	WHERE (Secuencia = @pSecuencia) AND (Legajo = 
	dbo.FuncFksuePersonal(@pLegajo)) AND (sueLiquidacion = @psueLiquidacion)
END 
ELSE 
BEGIN 
	INSERT INTO suePagosHabiPorEmpleado
	(
		Secuencia,
		Legajo,
		sueLiquidacion,
		tesMovimientos,
		FechaHabilitacion,
		Importe,
		Usuario_Id
	)
	VALUES 
	(
		@pSecuencia,
		dbo.FuncFksuePersonal(@pLegajo),
		@psueLiquidacion,
		@ptesMovimientos,
		@pFechaHabilitacion,
		@pImporte,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE suePagosHabiPorEmpleadoDatos
GO
CREATE PROCEDURE suePagosHabiPorEmpleadoDatos
(
@psueLiquidacion bigint,
@pSecuencia int = NULL,
@pLegajo int = NULL

)
AS
SET NOCOUNT ON 

SELECT Cast(1 as Bit) as Marca, suePagosHabiPorEmpleado.Secuencia, suePersonal.Legajo, 
	suePersonal.Nombres+','+suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno as DescripcionPersonal, 
	suePagosHabiPorEmpleado.sueLiquidacion, 
	suePagosHabiPorEmpleado.tesMovimientos, 
	ISNULL(suePagosHabiPorEmpleado.FechaHabilitacion, sueLiquidacion.FechaPago) as FechaHabilitacion,
	suePagosHabiPorEmpleado.Importe, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Decena, 
	sueLiquidacion.Semana, sueLiquidacion.Vez
FROM suePagosHabiPorEmpleado 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePagosHabiPorEmpleado.Legajo)
INNER JOIN sueLiquidacion  ON (sueLiquidacion.sueLiquidacion = suePagosHabiPorEmpleado.sueLiquidacion)
LEFT JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = suePagosHabiPorEmpleado.tesMovimientos)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = suePagosHabiPorEmpleado.Usuario_Id)
WHERE (sueLiquidacion.sueLiquidacion = @psueLiquidacion) 
AND (suePagosHabiPorEmpleado.Secuencia = ISNULL(@pSecuencia,suePagosHabiPorEmpleado.Secuencia))
AND (suePersonal.Legajo = ISNULL(@pLegajo,suePersonal.Legajo))


 
RETURN @@Error 

GO

DROP PROCEDURE suePagosHabiPorEmpleadoEliminar
GO
CREATE PROCEDURE suePagosHabiPorEmpleadoEliminar
(
@psueLiquidacion bigint,
@pSecuencia int = NULL ,
@pLegajo int = NULL

)
AS
SET NOCOUNT ON 

DELETE FROM suePagosHabiPorEmpleado 
WHERE 
(sueLiquidacion = @psueLiquidacion) 
AND (Secuencia = ISNULL(@pSecuencia, Secuencia))
AND (Legajo = CASE WHEN   @pLegajo IS NULL THEN Legajo ELSE dbo.FuncFksuePersonal(@pLegajo) END)

 
 RETURN @@Error 

GO

DROP PROCEDURE suePagosHabiPorEmpleadoPendDatos
GO
CREATE PROCEDURE suePagosHabiPorEmpleadoPendDatos
(
	@psueLiquidacion bigint
)
AS
SET NOCOUNT ON 

SELECT sueLiquidacion
from sueLiquidacion where sueLiquidacion = @psueLiquidacion

SELECT Cast(1 as Bit) as Marca, suePagosHabiPorEmpleado.Secuencia, suePersonal.Legajo, 
	suePersonal.Nombres+','+suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno as DescripcionPersonal, 
	suePagosHabiPorEmpleado.sueLiquidacion, 
	ISNULL(suePagosHabiPorEmpleado.FechaHabilitacion, sueLiquidacion.FechaPago) as FechaHabilitacion,
	suePagosHabiPorEmpleado.Importe, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Decena, 
	sueLiquidacion.Semana, sueLiquidacion.Vez
FROM suePagosHabiPorEmpleado 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePagosHabiPorEmpleado.Legajo)
INNER JOIN sueLiquidacion  ON (sueLiquidacion.sueLiquidacion = suePagosHabiPorEmpleado.sueLiquidacion)
LEFT JOIN tesMovimientos  ON (tesMovimientos.tesMovimientos = suePagosHabiPorEmpleado.tesMovimientos)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = suePagosHabiPorEmpleado.Usuario_Id)
WHERE 
	(sueLiquidacion.sueLiquidacion = @psueLiquidacion) AND 
	(suePagosHabiPorEmpleado.tesMovimientos IS NULL)
UNION ALL
SELECT Cast(0 as Bit) as Marca, 1 Secuencia, suePersonal.Legajo, 
	suePersonal.Nombres+','+suePersonal.ApellidoPaterno+','+suePersonal.ApellidoMaterno as DescripcionPersonal, 
	sueLiquidacion.sueLiquidacion, 
	sueLiquidacion.FechaPago AS FechaHabilitacion,
	SUM(sueTerminada.Importe*sueTerminada.Signo) as Importe, 
	' ' Usuario_Id, ' ' as DescripcionUsuario, sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Decena, 
	sueLiquidacion.Semana, sueLiquidacion.Vez
FROM 
sueLiquidacion 
INNER JOIN sueTerminada ON sueLiquidacion.sueLiquidacion = sueTerminada.sueLiquidacion
inner join suePersonal ON (suePersonal.genEntidades = sueTerminada.Legajo)
WHERE
	sueTerminada.sueLiquidacion = @psueLiquidacion And
	NOT EXISTS(SELECT 1 FROM suePagosHabiPorEmpleado  
	WHERE
		sueTerminada.sueLiquidacion = suePagosHabiPorEmpleado.sueLiquidacion And 
		sueTerminada.Legajo =suePagosHabiPorEmpleado.legajo) 
GROUP BY suePersonal.Legajo, 
	suePersonal.Nombres,suePersonal.ApellidoPaterno,suePersonal.ApellidoMaterno , 
	sueLiquidacion.sueLiquidacion, sueLiquidacion.FechaPago, 
	sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Quincena, sueLiquidacion.Decena, 
	sueLiquidacion.Semana, sueLiquidacion.Vez
ORDER BY 2
 
 RETURN @@Error 

GO



DROP PROCEDURE suePagosHabiAsignarTesMovimientos
GO
CREATE PROCEDURE suePagosHabiAsignarTesMovimientos
(

	@psueLiquidacion bigint, 
	@pTesmMovimientos bigint = NULL

)
AS
SET NOCOUNT ON 

UPDATE suePagosHabiPorEmpleado SET tesMovimientos = @pTesmMovimientos
WHERE 
	sueLiquidacion = @psueLiquidacion

UPDATE suePagosHabi SET tesMovimientos = @pTesmMovimientos
WHERE 
	sueLiquidacion = @psueLiquidacion
 
 RETURN @@Error 

GO
