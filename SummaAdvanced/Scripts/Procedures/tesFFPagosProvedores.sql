DROP PROCEDURE tesFFPagosProvedoresGuardar
GO
CREATE PROCEDURE tesFFPagosProvedoresGuardar
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pProveed_Id VarChar(15),
@pMoneda_Id varchar(3),
@pMonto numeric(18,2)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesFFPagosProvedores WHERE 
	(tesFlujoFondo = @ptesFlujoFondo) AND 
	(Fecha = @pFecha) AND 
	(Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id)) AND 
	(Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))))
BEGIN 
	UPDATE tesFFPagosProvedores
	SET		Monto = @pMonto
	WHERE (tesFlujoFondo = @ptesFlujoFondo) AND (Fecha = @pFecha) AND 
		(Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id)) AND 
		(Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id))
END 
ELSE 
BEGIN 
	INSERT INTO tesFFPagosProvedores
	(
		tesFlujoFondo,
		Fecha,
		Proveed_Id,
		Moneda_Id,
		Monto
	)
	VALUES 
	(
		@ptesFlujoFondo,
		@pFecha,
		dbo.FuncFKcomProveedores(@pProveed_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pMonto
	)
END 

GO

DROP PROCEDURE tesFFPagosProvedoresDatos
GO
CREATE PROCEDURE tesFFPagosProvedoresDatos
(
@ptesFlujoFondo bigint,
@pFecha datetime,
@pProveed_Id VarChar(15),
@pMoneda_Id VarChar(3)
)
AS
SET NOCOUNT ON 

SELECT tesFlujoFondo.tesFlujoFondo , tesFFPagosProvedores.Fecha, 
	comProveedores.Proveed_Id, comProveedores.RazonSocial,
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, 
	tesFFPagosProvedores.Monto, tesFlujoFondo.FechaDesde, tesFlujoFondo.FechaHasta
FROM tesFFPagosProvedores 
INNER JOIN tesFlujoFondo  ON (tesFlujoFondo.tesFlujoFondo = tesFFPagosProvedores.tesFlujoFondo)
INNER JOIN comProveedores  ON (comProveedores.genEntidades = tesFFPagosProvedores.Proveed_Id)
INNER JOIN genMonedas  ON (genMonedas.genMonedas = tesFFPagosProvedores.Moneda_Id)
WHERE (tesFFPagosProvedores.tesFlujoFondo = @ptesFlujoFondo)
AND (tesFFPagosProvedores.Fecha = @pFecha)
AND (comProveedores.Proveed_Id = @pProveed_Id)
AND (genMonedas.Moneda_Id = @pMoneda_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE tesFFPagosProvedoresEliminar
GO
CREATE PROCEDURE tesFFPagosProvedoresEliminar
(
@ptesFlujoFondo bigint,
@pFechaDesde datetime ,
@pFechaHasta datetime 
)
AS
SET NOCOUNT ON 

DELETE FROM tesFFPagosProvedores 
WHERE 
(tesFlujoFondo = @ptesFlujoFondo) AND 
(Fecha between @pFechaDesde and @pFechaHasta)
 
RETURN @@Error 

GO


