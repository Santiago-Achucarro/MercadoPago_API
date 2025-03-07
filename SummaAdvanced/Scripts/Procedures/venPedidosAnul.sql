DROP PROCEDURE venPedidosAnulGuardar
GO
CREATE PROCEDURE venPedidosAnulGuardar
(
@pvenPedidos int,
@pFecha qFechaHora,
@pOperacion char(1),
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venPedidosAnul WHERE (venPedidos = @pvenPedidos)))
BEGIN 
	UPDATE venPedidosAnul
	SET Fecha = @pFecha,
		Operacion = @pOperacion,
		Usuario_Id = @pUsuario_Id
	WHERE (venPedidos = @pvenPedidos)
END 
ELSE 
BEGIN 
	INSERT INTO venPedidosAnul
	(
		venPedidos,
		Fecha,
		Operacion,
		Usuario_Id
	)
	VALUES 
	(
		@pvenPedidos,
		@pFecha,
		@pOperacion,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE venPedidosAnulDatos
GO
CREATE PROCEDURE venPedidosAnulDatos
(
@pvenPedidos int
)
AS
SET NOCOUNT ON 

SELECT venPedidos.venPedidos, venPedidosAnul.Fecha, venPedidosAnul.Operacion, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM venPedidosAnul 
INNER JOIN venPedidos ON (venPedidos.venPedidos = venPedidosAnul.venPedidos)
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = venPedidosAnul.Usuario_Id)
WHERE (venPedidosAnul.venPedidos = @pvenPedidos)
 
 RETURN @@Error 

GO

DROP PROCEDURE venPedidosAnulEliminar
GO
CREATE PROCEDURE venPedidosAnulEliminar
(
@pvenPedidos int
)
AS
SET NOCOUNT ON 

DELETE FROM venPedidosAnul WHERE (venPedidos = @pvenPedidos)
 
RETURN @@Error 

GO
