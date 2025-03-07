-- AJ MAY 17 QUITO EL 
-- AJ ENE 18 Metodo y Uso
-- venPedidosEstadoDatos 6

DROP PROCEDURE venPedidosGuardar
GO
CREATE PROCEDURE venPedidosGuardar
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pSubTipoMov_Id varchar(5),
@pFecha qFechaHora,
@pCliente_Id varChar(15) = NULL,
@pSucursal SucursalN = NULL,
@pSucursalUsu varChar(5),
@pMoneda_Id varchar(3) = NULL,
@pMonedaFacturacion varchar(3) = NULL,
@pCondPagoCli_Id varchar(5) = NULL,
@pListaPrecio_Id varchar(5) = NULL,	
@pVendedor_Id varChar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pEstado char(1),
@pUsuarioAutoriz_Id varchar(25) = NULL,
@pFechaAutorizo datetime = NULL,
@pObservaciones QMemo = NULL,
@pObservEstado QMemo = NULL,
@pMotivo_Id smallint = NULL,
@pImporteTotal qMonedaD2,
@pBonificacion1 qMonedaD2,
@pBonificacion2 qMonedaD2,
@pBonificacion3 qMonedaD2,
@pBonificacion4 qMonedaD2,
@pBonificacion5 qMonedaD2,
@pDato1 qMonedaD2,
@pDato2 qMonedaD2,
@pDato3 qMonedaD2,
@pFechaUltMod qFechaHora,
@pCliOrdenCompra varchar(100),
@pvenNroPedido varchar(15),
@pFacturaAnticipo Sino,
@pTrabaDespacho Sino,
@pPorAnticipo qPorcentaje,
@pAnticipo qMonedaD2,
@pAnticipoPendiente qMonedaD2,
@pObsAnticipo QMemo = NULL,
@pTipoPrecioForm char(1),
@pCongelaCambio Sino,
@pFecha_Registro datetime,
@pCambio qMonedaD8,
@pIncoterm_Id char(3) = NULL,
@pSoloEntrega Sino,
@pUsuario_Id int,
@pPosteado Sino,
@pMetodoPago VarChar(3), 
@pUsoCfdi VarChar(3),
@pSubTotal qMonedaD2,
@pSubTotalBonif qMonedaD2,
@pImpOtCargos qMonedaD2,
@pDescOtrosCargos varchar(60) = Null,
@pDatoOtCargos qMonedaD2,
@pCtaOtrosCargos varchar(25) = Null
)
AS
SET NOCOUNT ON 
Declare @lIdentity int = (Select venPedidos
 from venPediSegmentos
 Where
	venPediSegmentos.Empresa_id = @pEmpresa_Id and 
	venPediSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venPediSegmentos.Segmento1N = @pSegmento1N and 
	venPediSegmentos.Segmento2N = @pSegmento2N and 
	venPediSegmentos.Segmento3N = @pSegmento3N and 
	venPediSegmentos.Segmento4N = @pSegmento4N and 
	venPediSegmentos.Segmento1C = @pSegmento1C and 
	venPediSegmentos.Segmento2C = @pSegmento2C and 
	venPediSegmentos.Segmento3C = @pSegmento3C and 
	venPediSegmentos.Segmento4C = @pSegmento4C )

IF (@lIdentity IS NOT NULL)
BEGIN 
	UPDATE venPedidos
	SET 
		Empresa_Id = @pEmpresa_Id,
		SubTipoMov_Id = dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		Fecha = @pFecha,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Sucursal = @pSucursal,
		SucursalUsu = dbo.FuncFKgenSucursalesEmpr(@pSucursalUsu),
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		MonedaFacturacion = dbo.FuncFKgenMonedas(@pMonedaFacturacion),
		CondPagoCli_Id = dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		Estado = @pEstado,
		UsuarioAutoriz_Id = dbo.FuncFKgenUsuarios(@pUsuarioAutoriz_Id),
		FechaAutorizo = @pFechaAutorizo,
		Observaciones = @pObservaciones,
		ObservEstado = @pObservEstado,
		Motivo_Id = @pMotivo_Id,
		ImporteTotal = @pImporteTotal,
		Bonificacion1 = @pBonificacion1,
		Bonificacion2 = @pBonificacion2,
		Bonificacion3 = @pBonificacion3,
		Bonificacion4 = @pBonificacion4,
		Bonificacion5 = @pBonificacion5,
		Dato1 = @pDato1,
		Dato2 = @pDato2,
		Dato3 = @pDato3,
		FechaUltMod = @pFechaUltMod,
		CliOrdenCompra = @pCliOrdenCompra,
		venNroPedido = @pvenNroPedido,
		FacturaAnticipo = @pFacturaAnticipo,
		TrabaDespacho = @pTrabaDespacho,
		PorAnticipo = @pPorAnticipo,
		Anticipo = @pAnticipo,
		AnticipoPendiente = @pAnticipoPendiente,
		ObsAnticipo = @pObsAnticipo,
		TipoPrecioForm = @pTipoPrecioForm,
		CongelaCambio = @pCongelaCambio,
		Fecha_Registro = @pFecha_Registro,
		Cambio = @pCambio,
		Incoterm_Id = dbo.FuncFKvenIncoterm(@pIncoterm_Id),
		SoloEntrega = @pSoloEntrega,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado,
		MetodoPago = @pMetodoPago, 
		UsoCfdi = @pUsoCfdi,
		SubTotal = @pSubTotal,
		SubTotalBonif = @pSubTotalBonif,
		ImpOtCargos = @pImpOtCargos,
		DescOtrosCargos = @pDescOtrosCargos,
		DatoOtCargos = @pDatoOtCargos,
		CtaOtrosCargos = dbo.FuncFKconCuentas(@pCtaOtrosCargos)
	WHERE venPedidos = @lIdentity
END 
ELSE 
BEGIN 
	INSERT INTO venPedidos
	(
		Empresa_Id,
		SubTipoMov_Id,
		Fecha,
		Cliente_Id,
		Sucursal,
		SucursalUsu,
		Moneda_Id,
		MonedaFacturacion,
		CondPagoCli_Id,
		ListaPrecio_Id,
		Vendedor_Id,
		FormaEntrega_Id,
		Estado,
		UsuarioAutoriz_Id,
		FechaAutorizo,
		Observaciones,
		ObservEstado,
		Motivo_Id,
		ImporteTotal,
		Bonificacion1,
		Bonificacion2,
		Bonificacion3,
		Bonificacion4,
		Bonificacion5,
		Dato1,
		Dato2,
		Dato3,
		FechaUltMod,
		CliOrdenCompra,
		venNroPedido,
		FacturaAnticipo,
		TrabaDespacho,
		PorAnticipo,
		Anticipo,
		AnticipoPendiente,
		ObsAnticipo,
		TipoPrecioForm,
		CongelaCambio,
		Fecha_Registro,
		Cambio,
		Incoterm_Id,
		SoloEntrega,
		Usuario_Id,
		Posteado, 
		MetodoPago,
		UsoCfdi,
		SubTotal,
		SubTotalBonif,
		ImpOtCargos,
		DescOtrosCargos,
		DatoOtCargos,
		CtaOtrosCargos
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		@pFecha,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pSucursal,
		dbo.FuncFKgenSucursalesEmpr(@pSucursalUsu),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKgenMonedas(@pMonedaFacturacion),
		dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		@pEstado, /* FM 24/03/2019 Dec�a 'P' */
		dbo.FuncFKgenUsuarios(@pUsuarioAutoriz_Id),
		@pFechaAutorizo,
		@pObservaciones,
		@pObservEstado,
		@pMotivo_Id,
		@pImporteTotal,
		@pBonificacion1,
		@pBonificacion2,
		@pBonificacion3,
		@pBonificacion4,
		@pBonificacion5,
		@pDato1,
		@pDato2,
		@pDato3,
		@pFechaUltMod,
		@pCliOrdenCompra,
		@pvenNroPedido,
		@pFacturaAnticipo,
		@pTrabaDespacho,
		@pPorAnticipo,
		@pAnticipo,
		@pAnticipoPendiente,
		@pObsAnticipo,
		@pTipoPrecioForm,
		@pCongelaCambio,
		@pFecha_Registro,
		@pCambio,
		dbo.FuncFKvenIncoterm(@pIncoterm_Id),
		@pSoloEntrega,
		@pUsuario_Id,
		@pPosteado, 
		@pMetodoPago, 
		@pUsoCfdi,
		@pSubTotal,
		@pSubTotalBonif,
		@pImpOtCargos,
		@pDescOtrosCargos,
		@pDatoOtCargos,
		dbo.FuncFKconCuentas(@pCtaOtrosCargos)
	)
	SET @lIdentity =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentity as RetVal 

GO


DROP PROCEDURE venPedidosDatos_Identity
GO
CREATE PROCEDURE venPedidosDatos_Identity
(
@lIdentity int
)
AS
SET NOCOUNT ON 

SELECT venPedidos.venPedidos, venPediSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N,
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C,
	venPediSegmentos.Segmento4C, 
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
	venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,
	venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) Segmento,
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, venPedidos.Fecha,
	venClientes.Cliente_Id, venPedidos.Sucursal, venClieHabitual.NombreFantasia, genMonedas.Moneda_Id,
	genMonedas.Descripcion as DescripcionMonedas, genMonedasFact.Moneda_Id MonedaFacturacion, genMonedas.Descripcion DescripcionMonFacturacion,
	venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Descripcion as DescripcionListasPrecios, venVendedores.Vendedor_Id, 
	venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, venPedidos.Estado,
	genUsuarioAutoriz.Usuario_Id UsuarioAutoriz_Id, genUsuarioAutoriz.Apellido_y_Nombres as DescripcionUsuarioAutoriz,
	venPedidos.FechaAutorizo, venPedidos.Observaciones,
	venPedidos.ObservEstado, venPedidos.Motivo_Id, venPedidos.ImporteTotal, venPedidos.Bonificacion1,
	venPedidos.Bonificacion2, venPedidos.Bonificacion3, venPedidos.Bonificacion4, venPedidos.Bonificacion5,
	venPedidos.Dato1, venPedidos.Dato2, venPedidos.Dato3, venPedidos.FechaUltMod,
	venPedidos.CliOrdenCompra, venPedidos.venNroPedido, venPedidos.FacturaAnticipo, venPedidos.TrabaDespacho,
	venPedidos.PorAnticipo, venPedidos.Anticipo, venPedidos.AnticipoPendiente, venPedidos.ObsAnticipo,
	venPedidos.TipoPrecioForm, venPedidos.CongelaCambio, venPedidos.Fecha_Registro, venPedidos.Cambio,
	venIncoterm.Incoterm_Id, venIncoterm.Descripcion as DescripcionIncoterm, venPedidos.SoloEntrega,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venPedidos.Posteado, 
	venPedidos.MetodoPago , venpedidos.UsoCfdi, UsosCfdi.Descripcion as DescripcionUsoCfdi, 
	Metodos.Descripcion as DescripcionMetodoPago, venPedidos.SubTotal, venPedidos.SubTotalBonif,
	genSucursalesEmpr.Sucursal SucursalUsu, 0 as TipoPago, CAST(0 as bit) AceptaDatosExternos,
	ImpOtCargos, DescOtrosCargos, DatoOtCargos, conCtaOtCargos.Cuenta_Id CtaOtrosCargos, conCtaOtCargos.Descripcion DescCtaOtrosCargos
FROM venPedidos 
INNER JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id)
LEFT JOIN venClieHabitual  ON (venClieHabitual.genEntidades = venPedidos.Cliente_Id) AND (venClieHabitual.Sucursal = venPedidos.Sucursal)
Left Join venClientes On venPedidos.Cliente_Id = venClientes.genEntidades
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venPedidos.Moneda_Id)
Left Join genMonedas genMonedasFact On genMonedasFact.genMonedas = venPedidos.MonedaFacturacion
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venPedidos.CondPagoCli_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venPedidos.ListaPrecio_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venPedidos.Vendedor_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id)
LEFT JOIN genUsuarios genUsuarioAutoriz  ON (genUsuarioAutoriz.genUsuarios = venPedidos.UsuarioAutoriz_Id)
LEFT JOIN venIncoterm  ON (venIncoterm.venIncoterm_int = venPedidos.Incoterm_Id)
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = venPedidos.Usuario_Id)
INNER JOIN venPediSegmentos ON venPediSegmentos.venPedidos = venPedidos.venPedidos
INNER JOIN genSegmentos ON venPediSegmentos.Segmento_Id = genSegmentos.genSegmentos
LEFT JOIN genEntidadesBasicasValor as UsosCfdi ON
UsosCfdi.Entidad_Id = 4 AND 
UsosCfdi.Dominio_Id = 'MX' AND 
UsosCfdi.Clave = venPedidos.UsoCfdi
LEFT JOIN genEntidadesBasicasValor as Metodos ON
Metodos.Entidad_Id = 6 AND 
Metodos.Dominio_Id = 'MX' AND 
Metodos.Clave = venPedidos.MetodoPago
Left Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = venPedidos.SucursalUsu
Left Join conCuentas conCtaOtCargos On conCtaOtCargos.conCuentas = venPedidos.CtaOtrosCargos

WHERE venPedidos.venPedidos = @lIdentity

exec venPediCuerpoDatos  @lIdentity

Exec genAtributosGeneralesIdentityDatos @lIdentity, 'venPedidos'

SELECT getdate() as Fecha, '' Producto_Id, '' Descripcion, 0.00 as Existencia, 
	0.00 as Compras, 0.00 as Embarques,	
		0.00 as Pedidos, 0.00 as TransitoLocal,
		0.00 as Final, '' as Deposito_Id

select '' as Entidad_Id, '' as Descripcion, '' SegmentoSTR, 0.00 as Cantidad


-- para v2 las cotizaciones
select genSegmentos.Segmento_Id, venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N,
	venCotizSegmento.Segmento3N, venCotizSegmento.Segmento4N, venCotizSegmento.Segmento1C,
	venCotizSegmento.Segmento2C, venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C,CAST(0 AS BIT) as Agregar
FROM venCotizPedidos INNER JOIN venCotizSegmento ON
	venCotizPedidos.Cotizacion_Id = venCotizSegmento.venCotizaciones
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = venCotizSegmento.Segmento_Id
	Where
		venCotizPedidos.Pedido_Id = @lIdentity


Select venNPAutorizando.venPedidos, venNPAutorizando.Secuencia, venNivelesAuto.NivelAuto_Id,
venNivelesAuto.Descripcion DescripcionNivelesAuto, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres DescripciongenUsuarios,
venNPAutorizando.Fecha, venNPAutorizando.TipoApro
From venNPAutorizando
Inner Join venNivelesAuto On venNivelesAuto.venNivelesAuto = venNPAutorizando.NivelAuto_Id
Inner Join genUsuarios On genUsuarios.genUsuarios = venNPAutorizando.Usuario_Id
Where venNPAutorizando.venPedidos = @lIdentity

Select venPedidos.venPedidos, venEsquemaAuto.EsquemaAuto_Id, venEsquemaAuto.Descripcion DescripcionEsquema 
From venPedidos
inner join venSubTipoMov ON venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
Left Join venEsquemaAuto On venEsquemaAuto.venEsquemaAuto = venSubTipoMov.EsquemaAuto_Id
Where venPedidos.venPedidos = @lIdentity

Select venNPAutorizando.venPedidos, venNPAutorizando.Secuencia, venNivelesAuto.NivelAuto_Id,
venNivelesAuto.Descripcion DescripcionNivelesAuto, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres DescripciongenUsuarios,
venNPAutorizando.Fecha, venNPAutorizando.TipoApro
From venNPAutorizando
Inner Join venNivelesAuto On venNivelesAuto.venNivelesAuto = venNPAutorizando.NivelAuto_Id
Left Join genUsuarios On genUsuarios.genUsuarios = venNPAutorizando.Usuario_Id
Where venNPAutorizando.venPedidos = @lIdentity

Select MVendedor, MFormaE, MListaP, MBonifDato, MBonifReng, MPrecioReng From venPediValiComer Where venPedidos = @lIdentity
select 0.00 as Disponible, 0.00 as LimiteCredito
exec venPedidosPendClie ''

exec genAdjuntosDatos '',0,0
Go




DROP PROCEDURE venPedidosDatos
GO
CREATE PROCEDURE venPedidosDatos
(
@pEmpresa_Id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @pIdentity int= (select venPedidos from venPediSegmentos
	Where
	venPediSegmentos.Empresa_id = @pEmpresa_id and 
	venPediSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	venPediSegmentos.Segmento1N = @pSegmento1N and 
	venPediSegmentos.Segmento2N = @pSegmento2N and 
	venPediSegmentos.Segmento3N = @pSegmento3N and 
	venPediSegmentos.Segmento4N = @pSegmento4N and 
	venPediSegmentos.Segmento1C = @pSegmento1C and 
	venPediSegmentos.Segmento2C = @pSegmento2C and 
	venPediSegmentos.Segmento3C = @pSegmento3C and 
	venPediSegmentos.Segmento4C = @pSegmento4C)

Exec venPedidosDatos_Identity @pIdentity

--Remitos
SELECT ' ' AS Remito, CONVERT(DATETIME,NULL) AS Fecha, CAST(0 AS bit) as Anulado

--Factura
SELECT ' ' AS Factura, CONVERT(DATETIME,NULL) AS Fecha, CAST(0 AS bit) as Anulado

--Reparto
SELECT ' ' AS Reparto, CONVERT(DATETIME,NULL) AS Fecha, CAST(0 AS bit) as Cerrado


RETURN @@Error
GO


DROP PROCEDURE venPedidosEliminar
GO
CREATE PROCEDURE venPedidosEliminar
(
@lIdentity int
)
AS
SET NOCOUNT ON 

DELETE FROM venPedidos WHERE venPedidos.venPedidos = @lIdentity
RETURN @@Error 

GO

Drop Procedure venPedidosAutorizar
Go

Create Procedure venPedidosAutorizar
(
@pvenPedidos Int,
@pUsuario_Id Int,
@pObservEstado qMemo
)
As
Update venPedidos Set UsuarioAutoriz_Id = @pUsuario_Id, FechaAutorizo = dbo.FechaActual(), ObservEstado = @pObservEstado
	Where venPedidos = @pvenPedidos
Go

Drop Procedure venPedidosRechazar
Go

Create Procedure venPedidosRechazar
(
@pvenPedidos Int,
@pUsuario_Id Int,
@pObservEstado qMemo
)
As
Update venPedidos Set UsuarioAutoriz_Id = @pUsuario_Id, FechaAutorizo = dbo.FechaActual(), ObservEstado = @pObservEstado,
	Estado = 'Z' Where venPedidos = @pvenPedidos
Go

Drop Procedure venPedidosAplicarAnticipo
Go

Create Procedure venPedidosAplicarAnticipo
(
@pvenPedidos Int,
@pMonto Numeric(18,2)
)
As
Update venPedidos Set AnticipoPendiente = AnticipoPendiente - @pMonto Where venPedidos = @pvenPedidos
Go

Drop Procedure venPedidosCambiarEstado
GO
Create Procedure venPedidosCambiarEstado
(
@pvenPedidos Int,
@pEstado Char(1)
)
As
Update venPedidos Set 	Estado = @pEstado Where venPedidos = @pvenPedidos
Go


Drop Procedure venPedidosEstadoDatos
GO
Create Procedure venPedidosEstadoDatos
(
@pvenPedidos Int
)
As
SELECT venPedidos.venPedidos, venPedidos.Estado, 
	venPedidos.UsuarioAutoriz_Id,
	Cast(MAX(Convert(int,Pendiente)) as bit) Pendiente , 
			SUM(CantidadPedida) CantidadPedida, 
			SUM(CantidadRemitida) CantidadRemitida, 
			SUM(CantidadFacturada) CantidadFacturada
FROM venPedidos INNER JOIN venPediCuerpo ON
	venPedidos.venPedidos = venPediCuerpo.venPedidos
WHERE
venPedidos.venPedidos = @pvenPedidos
GROUP BY venPedidos.venPedidos, venPedidos.Estado, venPedidos.UsuarioAutoriz_Id
	
Go


DROP PROCEDURE venPedidosRenglonesPend
GO
CREATE PROCEDURE venPedidosRenglonesPend
(
@pEmpresa_Id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @pIdentity int= (select venPedidos from venPediSegmentos
	Where
	venPediSegmentos.Empresa_id = @pEmpresa_id and 
	venPediSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	venPediSegmentos.Segmento1N = @pSegmento1N and 
	venPediSegmentos.Segmento2N = @pSegmento2N and 
	venPediSegmentos.Segmento3N = @pSegmento3N and 
	venPediSegmentos.Segmento4N = @pSegmento4N and 
	venPediSegmentos.Segmento1C = @pSegmento1C and 
	venPediSegmentos.Segmento2C = @pSegmento2C and 
	venPediSegmentos.Segmento3C = @pSegmento3C and 
	venPediSegmentos.Segmento4C = @pSegmento4C)
Go

Drop Procedure venPedidosMotivosGuardar
Go

Create Procedure venPedidosMotivosGuardar
(
@pvenPedidos Int,
@pMotivo smallint
)
As
Update venPedidos Set Motivo_Id = @pMotivo  Where venPedidos = @pvenPedidos
Go

