DROP PROCEDURE tesFFCobClientesGuardar
GO
CREATE PROCEDURE tesFFCobClientesGuardar
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pCliente_Id VarChar(15),
@pMoneda_Id varchar(3),
@pMonto numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesFFCobClientes WHERE 
	(tesFlujoFondo = @ptesFlujoFondo) AND 
	(Fecha = @pFecha) AND 
	(Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id)) AND 
	(Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))))
BEGIN 
	UPDATE tesFFCobClientes
	SET		Monto = @pMonto
	WHERE (tesFlujoFondo = @ptesFlujoFondo) AND 
		(Fecha = @pFecha) AND 
		(Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id)) AND 
		(Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesFFCobClientes
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

DROP PROCEDURE tesFFCobClientesDatos
GO
CREATE PROCEDURE tesFFCobClientesDatos
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pCliente_Id VarChar(15),
@pMoneda_Id VarChar(3)
)
AS
SET NOCOUNT ON 

SELECT  tesFFCobClientes.tesFlujoFondo, 
	tesFFCobClientes.Fecha, venClientes.Cliente_Id, venClientes.RazonSocial,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
		tesFFCobClientes.Monto, tesFlujoFondo.FechaDesde, tesFlujoFondo.FechaHasta
FROM tesFFCobClientes 
INNER JOIN tesFlujoFondo  ON (tesFlujoFondo.tesFlujoFondo = tesFFCobClientes.tesFlujoFondo)
INNER JOIN venClientes  ON (venClientes.genEntidades = tesFFCobClientes.Cliente_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesFFCobClientes.Moneda_Id)
WHERE (tesFFCobClientes.tesFlujoFondo = @ptesFlujoFondo)
AND (tesFFCobClientes.Fecha = @pFecha)
AND (venClientes.Cliente_Id = @pCliente_Id)
AND (genMonedas.Moneda_Id = @pMoneda_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE tesFFCobClientesEliminar
GO
CREATE PROCEDURE tesFFCobClientesEliminar
(
@ptesFlujoFondo bigint,
@pFechaDesde datetime ,
@pFechaHasta datetime 
)
AS
SET NOCOUNT ON 

DELETE FROM tesFFCobClientes 
WHERE (tesFlujoFondo = @ptesFlujoFondo)
AND (Fecha Between @pFechaDesde AND @pFechaHasta)
 
 RETURN @@Error 

GO

