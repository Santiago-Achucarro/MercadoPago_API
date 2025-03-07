drop procedure wooClientesUltCodigo
go
create procedure wooClientesUltCodigo
(
    @pCuit varchar(25),
    @pEmpresa_Id int
)
as

declare @pCliente_Id varchar(15)=(select Cliente_Id from venClientes inner join genEntidades on genEntidades.genEntidades=venClientes.genEntidades where genEntidades.Cuit=@pCuit)
exec venClieHabitualDatos @pCliente_Id, 99
select max(Cliente_Id) as UltCodigo from venClientes where Cliente_Id like 'EC_%'
go


DROP PROCEDURE wooClientesGuardar
GO
CREATE PROCEDURE wooClientesGuardar
(
@pVendedor_Id varchar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pCondFisc_Id varchar(5) = NULL,
@pCobrador_Id varchar(5) = NULL,
@pCategCred_Id varchar(5) = NULL,
@pCondPago_Id varchar(5) = NULL,
@pListaPrecio_Id varchar(5) = NULL,
@pRegion_Id varchar(5) = NULL,
@pZona_Id varchar(5) = NULL,
@pTipoClie_Id varchar(5) = NULL,
@pEmpresa_Id int
)

AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooClientes WHERE (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE wooClientes
	SET		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		CondFisc_Id = dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		Cobrador_Id = dbo.FuncFKvenCobradores(@pCobrador_Id),
		CategCred_Id = dbo.FuncFKvenCategCredito(@pCategCred_Id),
		CondPago_Id = dbo.FuncFKvenCondPago(@pCondPago_Id),
		ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		Region_Id = dbo.FuncFKvenRegion(@pRegion_Id),
		Zona_Id = dbo.FuncFKvenZona(@pZona_Id),
		TipoClie_Id = dbo.FuncFKvenTiposClie(@pTipoClie_Id),
		Empresa_Id = @pEmpresa_Id
	WHERE (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO wooClientes
	(
		Vendedor_Id,
		FormaEntrega_Id,
		CondFisc_Id,
		Cobrador_Id,
		CategCred_Id,
		CondPago_Id,
		ListaPrecio_Id,
		Region_Id,
		Zona_Id,
		TipoClie_Id,
		Empresa_Id
	)
	VALUES 
	(
		dbo.FuncFKvenVendedores( @pVendedor_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		dbo.FuncFKvenCobradores(@pCobrador_Id),
		dbo.FuncFKvenCategCredito(@pCategCred_Id),
		dbo.FuncFKvenCondPago(@pCondPago_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		dbo.FuncFKvenRegion(@pRegion_Id),
		dbo.FuncFKvenZona(@pZona_Id),
		dbo.FuncFKvenTiposClie(@pTipoClie_Id),
		@pEmpresa_Id
	)
END 

GO

DROP PROCEDURE wooClientesDatos
GO
CREATE PROCEDURE wooClientesDatos
(
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega,
	venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion as DescripcionCondFiscal, venCobradores.Cobrador_Id, venCobradores.Nombre as DescripcionCobradores,
	venCategCredito.CategCred_Id, venCategCredito.Descripcion as DescripcionCategCredito, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago,
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, venRegion.Region_Id, venRegion.Descripcion as DescripcionRegion,
	venZona.Zona_Id, venZona.Descripcion as DescripcionZona, venTiposClie.TipoClie_Id, venTiposClie.Descripcion as DescripcionTiposClie,
	wooClientes.Empresa_Id
FROM wooClientes 
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = wooClientes.Vendedor_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = wooClientes.FormaEntrega_Id)
LEFT JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = wooClientes.CondFisc_Id)
LEFT JOIN venCobradores  ON (venCobradores.venCobradores = wooClientes.Cobrador_Id)
LEFT JOIN venCategCredito  ON (venCategCredito.venCategCredito = wooClientes.CategCred_Id)
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = wooClientes.CondPago_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = wooClientes.ListaPrecio_Id)
LEFT JOIN venRegion  ON (venRegion.venRegion = wooClientes.Region_Id)
LEFT JOIN venZona  ON (venZona.venZona = wooClientes.Zona_Id)
LEFT JOIN venTiposClie  ON (venTiposClie.venTiposClie = wooClientes.TipoClie_Id)
WHERE (wooClientes.Empresa_Id = @pEmpresa_Id)
 
 SELECT genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, CuentaDxVtas.Cuenta_Id as CuentaDxVtas, CuentaDxVtas.Descripcion as DescripcionCuentaDxVtas,
	CtaFactAnticipo.Cuenta_Id as CtaFactAnticipo, CtaFactAnticipo.Descripcion as DescripcionCtaFactAnticipo, CtaAnticipo.Cuenta_Id as CtaAnticipo, CtaAnticipo.Descripcion as DescripcionCtaAnticipo,
	wooClientesCtas.Empresa_Id
FROM wooClientesCtas 
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = wooClientesCtas.Moneda_Id)
LEFT JOIN conCuentas CuentaDxVtas ON (CuentaDxVtas.conCuentas = wooClientesCtas.CuentaDxVtas)
LEFT JOIN conCuentas CtaFactAnticipo ON (CtaFactAnticipo.conCuentas = wooClientesCtas.CtaFactAnticipo)
LEFT JOIN conCuentas CtaAnticipo ON (CtaAnticipo.conCuentas = wooClientesCtas.CtaAnticipo)
WHERE (wooClientesCtas.Empresa_Id = @pEmpresa_Id)
RETURN @@Error 

GO

DROP PROCEDURE wooClientesEliminar
GO
CREATE PROCEDURE wooClientesEliminar
(
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM wooClientes 
WHERE Empresa_Id = @pEmpresa_Id
 
 RETURN @@Error 

GO

GO

DROP PROCEDURE wooClientesCtasGuardar
GO
CREATE PROCEDURE wooClientesCtasGuardar
(
@pMoneda_Id varchar(3) = NULL,
@pCuentaDxVtas varchar(25) = NULL,
@pCtaFactAnticipo varchar(25) = NULL,
@pCtaAnticipo varchar(25) = NULL,
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooClientesCtas WHERE (Empresa_Id = @pEmpresa_Id) and Moneda_Id=dbo.FuncFKgenMonedas(@pMoneda_Id)))
BEGIN 
	UPDATE wooClientesCtas
	SET		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		CuentaDxVtas = dbo.FuncFKconCuentas(@pCuentaDxVtas),
		CtaFactAnticipo = dbo.FuncFKconCuentas(@pCtaFactAnticipo),
		CtaAnticipo = dbo.FuncFKconCuentas(@pCtaAnticipo),
		Empresa_Id = @pEmpresa_Id
	WHERE (Empresa_Id = @pEmpresa_Id and Moneda_Id=dbo.FuncFKgenMonedas(@pMoneda_Id))
END 
ELSE 
BEGIN 
	INSERT INTO wooClientesCtas
	(
		Moneda_Id,
		CuentaDxVtas,
		CtaFactAnticipo,
		CtaAnticipo,
		Empresa_Id
	)
	VALUES 
	(
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKconCuentas(@pCuentaDxVtas),
		dbo.FuncFKconCuentas(@pCtaFactAnticipo),
		dbo.FuncFKconCuentas(@pCtaAnticipo),
		@pEmpresa_Id
	)
END 

GO


DROP PROCEDURE wooClientesCtasEliminar
GO
CREATE PROCEDURE wooClientesCtasEliminar
(
@pEmpresa_Id varchar(15),
@pMoneda_Id varchar(5)=null
)
AS
SET NOCOUNT ON 

DELETE FROM wooClientesCtas 
WHERE (Empresa_Id = dbo.FuncFKgenEmpresas(@pEmpresa_Id) and Moneda_Id=isnull(dbo.FuncFKgenMonedas(@pMoneda_Id), Moneda_Id))
 
 RETURN @@Error 

GO

GO
