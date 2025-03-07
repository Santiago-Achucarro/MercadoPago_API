DROP PROCEDURE espParaAutorizarKSKGuardar
GO
CREATE PROCEDURE espParaAutorizarKSKGuardar
(
	@pvenMovimientos bigint,
	@ptesMovimientos bigint = NULL,
	@pCausa varchar(250),
	@pEstado char(1),
	@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM espParaAutorizarKSK WHERE (venMovimientos = @pvenMovimientos)))
BEGIN 
	UPDATE espParaAutorizarKSK
	SET		Causa = @pCausa,
		Estado = @pEstado,
		Usuario_Id = @pUsuario_Id,
		tesMovimientos = @ptesMovimientos
	WHERE (venMovimientos = @pvenMovimientos)
END 
ELSE 
BEGIN 
	INSERT INTO espParaAutorizarKSK
	(
		venMovimientos,
		tesMovimientos,
		Causa,
		Estado,
		Usuario_Id
	)
	VALUES 
	(
		@pvenMovimientos,
		@ptesMovimientos,
		@pCausa,
		@pEstado,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE espParaAutorizarKSKDatos
GO
CREATE PROCEDURE espParaAutorizarKSKDatos
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

SELECT espParaAutorizarKSK.venMovimientos, espParaAutorizarKSK.tesMovimientos,
	espParaAutorizarKSK.Causa, espParaAutorizarKSK.Estado,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	venClientes.Cliente_Id, venClientes.RazonSocial, venMovimientos.Importe, 
	genMonedas.Moneda_Id

FROM espParaAutorizarKSK 
INNER JOIN venMovimientos  ON (venMovimientos.venMovimientos = espParaAutorizarKSK.venMovimientos)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = espParaAutorizarKSK.Usuario_Id)
INNER JOIN venClientes ON  venClientes.genEntidades = venMovimientos.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
INNER JOIN genSucursalesEmpr  on genSucursalesEmpr.genSucursalesEmpr  = conAsientos.Sucursal
INNER JOIN genAsiSegmentos ON   genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
WHERE (espParaAutorizarKSK.venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

DROP PROCEDURE espParaAutorizarKSKEliminar
GO
CREATE PROCEDURE espParaAutorizarKSKEliminar
(
@pvenMovimientos bigint
)
AS
SET NOCOUNT ON 

DELETE FROM espParaAutorizarKSK 
WHERE (venMovimientos = @pvenMovimientos)
 
 RETURN @@Error 

GO

GO
