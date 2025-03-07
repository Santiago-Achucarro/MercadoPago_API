DROP PROCEDURE tesFFDepositosGuardar
GO
CREATE PROCEDURE tesFFDepositosGuardar
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pCliente_Id VarChar(15),
@pMoneda_Id varchar(3),
@pMonto numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesFFDepositos 
WHERE (tesFlujoFondo = @ptesFlujoFondo) 
AND (Fecha = @pFecha) AND 
(Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id))))

BEGIN 
	UPDATE tesFFDepositos
	SET		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		Monto = @pMonto
	WHERE (tesFlujoFondo = @ptesFlujoFondo) AND (Fecha = @pFecha) AND 
		(Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesFFDepositos
	(
		tesFlujoFondo,
		Fecha,
		Cliente_Id,
		Moneda_Id,
		Monto
	)
	VALUES 
	(
		@ptesFlujoFondo,
		@pFecha,
		dbo.FuncFKvenClientes(@pCliente_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pMonto
	)
END 

GO

DROP PROCEDURE tesFFDepositosDatos
GO
CREATE PROCEDURE tesFFDepositosDatos
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pCliente_Id VarChar(15)
)
AS
SET NOCOUNT ON 

SELECT tesFlujoFondo.tesFlujoFondo ,tesFFDepositos.Fecha, 
	venClientes.Cliente_Id, venClientes.RazonSocial,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	tesFFDepositos.Monto, tesFlujoFondo.FechaDesde, tesFlujoFondo.FechaHasta 
FROM tesFFDepositos 
INNER JOIN tesFlujoFondo  ON (tesFlujoFondo.tesFlujoFondo = tesFFDepositos.tesFlujoFondo)
INNER JOIN venClientes  ON (venClientes.genEntidades = tesFFDepositos.Cliente_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesFFDepositos.Moneda_Id)
WHERE (tesFFDepositos.tesFlujoFondo = @ptesFlujoFondo)
AND (tesFFDepositos.Fecha = @pFecha)
AND (venClientes.Cliente_Id = @pCliente_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE tesFFDepositosEliminar
GO
CREATE PROCEDURE tesFFDepositosEliminar
(
@ptesFlujoFondo bigint,
@pFechaDesde DateTime,
@pFechaHasta DateTime
)
AS
SET NOCOUNT ON 

DELETE FROM tesFFDepositos 
WHERE (tesFlujoFondo = @ptesFlujoFondo) AND 
(Fecha between @pFechaDesde and @pFechaHasta)
 
RETURN @@Error 

GO

