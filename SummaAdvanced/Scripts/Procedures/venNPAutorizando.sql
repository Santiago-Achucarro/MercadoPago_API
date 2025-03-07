DROP PROCEDURE venNPAutorizandoGuardar
GO
CREATE PROCEDURE venNPAutorizandoGuardar
(
@pvenPedidos int,
@pSecuencia int,
@pNivelAuto_Id varchar(5),
@pUsuario_Id varChar(25) = NULL,
@pFecha datetime = NULL,
@pTipoApro char(1),
@pResultadoFormula varChar(max) = Null
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venNPAutorizando WHERE (venPedidos = @pvenPedidos) AND (Secuencia = @pSecuencia)))
BEGIN 
	UPDATE venNPAutorizando
	SET	Usuario_Id = dbo.FuncFKgenUsuarios(@pUsuario_Id),
		Fecha = case when @pFecha is null then null else dbo.FechaActual() end,
		TipoApro = @pTipoApro,
		ResultadoFormula = @pResultadoFormula
	WHERE (venPedidos = @pvenPedidos) AND (Secuencia = @pSecuencia)
END 
ELSE 
BEGIN

	Select @pSecuencia = IsNull(Max(Secuencia), 0) + 1 From venNPAutorizando Where venPedidos = @pvenPedidos

	INSERT INTO venNPAutorizando
	(
		venPedidos,
		Secuencia,
		NivelAuto_Id,
		Usuario_Id,
		Fecha,
		TipoApro,
		ResultadoFormula
	)
	VALUES 
	(
		@pvenPedidos,
		@pSecuencia,
		dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id),
		dbo.FuncFKgenUsuarios(@pUsuario_Id),
		case when @pFecha is null then null else dbo.FechaActual() end,
		@pTipoApro,
		@pResultadoFormula
	)
END

Select @pSecuencia As RetVal

GO

DROP PROCEDURE venNPAutorizandoDatos
GO
CREATE PROCEDURE venNPAutorizandoDatos
(
@pvenPedidos int
)
AS
SET NOCOUNT ON 

SELECT venNPAutorizando.venPedidos,
venNPAutorizando.Secuencia, venNivelesAuto.NivelAuto_Id, venNivelesAuto.Descripcion as DescripcioncomNivelesAuto,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venNPAutorizando.Fecha, venNPAutorizando.TipoApro, venNPAutorizando.ResultadoFormula
FROM venNPAutorizando 
INNER JOIN venPedidos  ON (venPedidos.venPedidos = venNPAutorizando.venPedidos)
INNER JOIN venNivelesAuto  ON (venNivelesAuto.venNivelesAuto = venNPAutorizando.NivelAuto_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venNPAutorizando.Usuario_Id)
WHERE venNPAutorizando.venPedidos = @pvenPedidos
AND venNPAutorizando.Usuario_Id Is Null
 
RETURN @@Error 

GO


DROP PROCEDURE venNPAutorizandoEliminar
GO
CREATE PROCEDURE venNPAutorizandoEliminar
(
@pvenPedidos int,
@pSecuencia int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venNPAutorizando 
WHERE venPedidos = @pvenPedidos
AND Secuencia = ISNULL(@pSecuencia, Secuencia)
 
RETURN @@Error 
Go

