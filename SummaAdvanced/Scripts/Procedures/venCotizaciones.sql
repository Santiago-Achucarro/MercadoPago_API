DROP PROCEDURE venCotizacionesGuardar
GO
CREATE PROCEDURE venCotizacionesGuardar
(
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pEmpresa_Id int = NULL,
@pSubTipoMov_Id varchar(5) = NULL,
@pFecha datetime = NULL,
@pCliente_Id varchar(15) = NULL,
@pSucursal int = NULL,
@pMoneda_Id varchar(3) = NULL,
@pMonedaFacturacion varchar(3) = NULL,
@pCondPagoCli_Id varchar(5) = NULL,
@pListaPrecio_Id varchar(5) = NULL,
@pVendedor_Id varchar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pEstado char(1) = NULL,
@pUsuarioAutoriz_Id varchar(25) = NULL,
@pFechaAutorizo datetime = NULL,
@pObservaciones varchar(max) = NULL,
@pObservEstado varchar(max) = NULL,
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
@pFechaUltMod datetime = NULL,
@pCliOrdenCompra varchar(15) = NULL,
@pvenNroPedido varchar(15) = NULL,
@pFacturaAnticipo Sino,
@pTrabaDespacho Sino,
@pPorAnticipo qPorcentaje,
@pAnticipo qMonedaD2,
@pAnticipoPendiente qMonedaD2,
@pObsAnticipo QMemo = NULL,
@pTipoPrecioForm char(1) = NULL,
@pCongelaCambio Sino,
@pFecha_Registro datetime = NULL,
@pCambio qMonedaD8,
@pIncoterm_Id char(3) = NULL,
@pSoloEntrega Sino,
@pUsuario_Id int = NULL,
@pPosteado Sino,
@pMetodoPago varchar(3) = NULL,
@pUsoCfdi char(3) = NULL, 
@pClienteExistente SiNo = 1, 
@pVigencia DateTime
)
AS
SET NOCOUNT ON 

DECLARE @lIdentidad int = (Select venCotizaciones
 from venCotizSegmento
 Where
	venCotizSegmento.Empresa_id = @pEmpresa_Id and 
	venCotizSegmento.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venCotizSegmento.Segmento1N = @pSegmento1N and 
	venCotizSegmento.Segmento2N = @pSegmento2N and 
	venCotizSegmento.Segmento3N = @pSegmento3N and 
	venCotizSegmento.Segmento4N = @pSegmento4N and 
	venCotizSegmento.Segmento1C = @pSegmento1C and 
	venCotizSegmento.Segmento2C = @pSegmento2C and 
	venCotizSegmento.Segmento3C = @pSegmento3C and 
	venCotizSegmento.Segmento4C = @pSegmento4C )

IF (EXISTS (SELECT 1 FROM venCotizaciones WHERE venCotizaciones.venCotizaciones=@lIdentidad))
BEGIN 
	UPDATE venCotizaciones
	SET		@lIdentidad = venCotizaciones,
		Empresa_Id = @pEmpresa_Id,
		SubTipoMov_Id = dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		Fecha = @pFecha,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Sucursal = @pSucursal,
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
		Fecha_Registro = getDate() ,
		Cambio = @pCambio,
		Incoterm_Id = dbo.FuncFKvenIncoterm(@pIncoterm_Id),
		SoloEntrega = @pSoloEntrega,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado,
		MetodoPago = @pMetodoPago,
		UsoCfdi = @pUsoCfdi, 
		ClienteExistente = @pClienteExistente, 
		Vigencia = @pVigencia
	WHERE venCotizaciones.venCotizaciones=@lIdentidad
END 
ELSE 
BEGIN 
	INSERT INTO venCotizaciones
	(
		Empresa_Id,
		SubTipoMov_Id,
		Fecha,
		Cliente_Id,
		Sucursal,
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
		ClienteExistente, 
		Vigencia
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		@pFecha,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pSucursal,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKgenMonedas(@pMonedaFacturacion),
		dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		@pEstado,
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
		getDate(),
		@pCambio,
		dbo.FuncFKvenIncoterm(@pIncoterm_Id),
		@pSoloEntrega,
		@pUsuario_Id,
		@pPosteado,
		@pMetodoPago,
		@pUsoCfdi,
		@pClienteExistente, 
		@pVigencia
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venCotizacionesDatos
GO
create procedure venCotizacionesDatos
(
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
as
declare @venCotizacion int = (select venCotizaciones from venCotizSegmento 
where Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id)
and Segmento1C =@pSegmento1C and Segmento2C=@pSegmento2C and Segmento3C=@pSegmento3C and Segmento4C=@pSegmento4C and
Segmento1N=@pSegmento1N and Segmento2C=@pSegmento2C and Segmento3C=@pSegmento3C and Segmento4C=@pSegmento4C and Empresa_Id=@pEmpresa_Id)
print @venCotizacion
exec venCotizacionesDatosInt @venCotizacion

SELECT getdate() as Fecha, '' Producto_Id, '' Descripcion, 0.00 as Existencia, 
	0.00 as Compras, 0.00 as Embarques,	
		0.00 as Pedidos, 0.00 as TransitoLocal,
		0.00 as Final, '' as Deposito_Id

select '' as Entidad_Id, '' as Descripcion, '' SegmentoSTR, 0.00 as Cantidad


go
drop procedure venCotizacionesDatosInt
go
create procedure venCotizacionesDatosInt
(
@pvenCotizacion int
)
as

select venCotizSegmento.Empresa_Id, genSegmentos.Segmento_Id, venCotizSegmento.Segmento1N, venCotizSegmento.Segmento2N, venCotizSegmento.Segmento3N,
venCotizSegmento.Segmento4N, venCotizSegmento.Segmento1C, venCotizSegmento.Segmento2C,
venCotizSegmento.Segmento3C, venCotizSegmento.Segmento4C,venCotizaciones.venCotizaciones, 
venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov, Fecha, venClientes.Cliente_Id, venClientes.RazonSocial as DescripcionCliente,
venClieHabitual.Sucursal, venClieHabitual.NombreFantasia, genMonedas.Moneda_Id,
genMonedas.Descripcion as DescripcionMoneda, MonedaFact.Moneda_Id as MonedaFact, MonedaFact.Descripcion as DescripcionMonedaFact,
venCondPago.CondPagoCli_Id as CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPagoCli, venListasPrecios.ListaPrecio_Id,
venListasPrecios.Descripcion as DescripcionListaPrec, venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedor,
venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial as DescripcionFormaEntrega, Estado, UsuAutoriz.Usuario_Id as UsuAutoriz,
UsuAutoriz.Apellido_y_Nombres as DescripcionUsuAutoriz, FechaAutorizo, venCotizaciones.Observaciones, ObservEstado, Motivo_Id, ImporteTotal,
venCotizaciones.Bonificacion1,venCotizaciones.Bonificacion2,venCotizaciones.Bonificacion3,Bonificacion4, Bonificacion5, Dato1, Dato2, Dato3, FechaUltMod, CliOrdenCompra,
venNroPedido, FacturaAnticipo, TrabaDespacho, PorAnticipo, Anticipo, AnticipoPendiente,ObsAnticipo, venCotizaciones.TipoPrecioForm, venCotizaciones.CongelaCambio,
Fecha_Registro, Cambio, venIncoterm.Incoterm_Id, venIncoterm.Descripcion as DescripcionIncoterm, SoloEntrega, 
genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCotizaciones.Posteado,
MetodoPago, UsoCfdi, venCotizaciones.ClienteExistente, venCotizaciones.Vigencia, 0 as TipoPago,  CAST(0 as bit) AceptaDatosExternos,0.00 as Impuestos
from venCotizaciones
left join genMonedas MonedaFact on MonedaFact.genMonedas= venCotizaciones.MonedaFacturacion
left join genUsuarios UsuAutoriz on UsuAutoriz.genUsuarios=venCotizaciones.UsuarioAutoriz_Id
left join venSubTipoMov on venSubTipoMov.venSubTipoMov=venCotizaciones.SubTipoMov_Id
left join venClientes on venClientes.genEntidades= venCotizaciones.Cliente_Id
left join genMonedas on genMonedas.genMonedas=venCotizaciones.Moneda_Id
left join venCondPago on venCondPago.venCondPago=venCotizaciones.CondPagoCli_Id
left join venListasPrecios on venListasPrecios.venListasPrecios=venCotizaciones.ListaPrecio_Id
left join venVendedores on venVendedores.venVendedores=venCotizaciones.Vendedor_Id
left join venFormaEntrega on venFormaEntrega.venFormaEntrega=venCotizaciones.FormaEntrega_Id
left join venIncoterm on venIncoterm.venIncoterm_int=venCotizaciones.Incoterm_Id
left join genUsuarios on genUsuarios.genUsuarios=venCotizaciones.Usuario_Id
inner join venCotizSegmento on venCotizaciones.venCotizaciones=venCotizSegmento.venCotizaciones
inner join genSegmentos on genSegmentos.genSegmentos=venCotizSegmento.Segmento_Id
left join genSucursalesEmpr on genSucursalesEmpr=venCotizaciones.Sucursal
LEFT JOIN venClieHabitual  ON (venClieHabitual.genEntidades = venCotizaciones.Cliente_Id) AND (venClieHabitual.Sucursal = venCotizaciones.Sucursal)
where venCotizaciones.venCotizaciones=@pvenCotizacion
exec venCotizClienteDatos @pvenCotizacion
exec venCotizCuerpoDatos  @pvenCotizacion

Exec genAtributosGeneralesIdentityDatos @pvenCotizacion, 'venCotizaciones'

go
drop procedure venCotizacionesEliminar
go
create procedure venCotizacionesEliminar
(
@pvenCotizaciones int
)
as
delete from venCotizaciones where venCotizaciones.venCotizaciones=@pvenCotizaciones
go


Drop Procedure venCotizacionesAutorizar
Go

Create Procedure venCotizacionesAutorizar
(
@pvenCotizaciones Int,
@pUsuario_Id Int,
@pObservEstado qMemo
)
As
Update venCotizaciones Set UsuarioAutoriz_Id = @pUsuario_Id, FechaAutorizo = dbo.FechaActual(), ObservEstado = @pObservEstado
	Where venCotizaciones = @pvenCotizaciones
Go

Drop Procedure venCotizRechazar
Go

Create Procedure venCotizRechazar
(
@pvenCotizaciones Int,
@pUsuario_Id Int,
@pObservEstado qMemo
)
As
Update venCotizaciones Set UsuarioAutoriz_Id = @pUsuario_Id, FechaAutorizo = dbo.FechaActual(), ObservEstado = @pObservEstado,
	Estado = 'Z' Where venCotizaciones= @pvenCotizaciones
Go

Drop Procedure venCotizAplicarAnticipo
Go

Create Procedure venCotizAplicarAnticipo
(
@pvenCotizaciones Int,
@pMonto Numeric(18,2)
)
As
Update venCotizaciones Set AnticipoPendiente = AnticipoPendiente - @pMonto Where venCotizaciones = @pvenCotizaciones
Go

Drop Procedure venCotizacionesCambiarEstado
GO
Create Procedure venCotizacionesCambiarEstado
(
@pvenCotizaciones Int,
@pEstado Char(1)
)
As
Update venCotizaciones Set 	Estado = @pEstado Where venCotizaciones = @pvenCotizaciones
Go


Drop Procedure venCotizEstadoDatos
GO
Create Procedure venCotizEstadoDatos
(
@pvenCotizaciones Int
)
As
SELECT venCotizaciones.venCotizaciones, venCotizaciones.Estado, 
	venCotizaciones.UsuarioAutoriz_Id,
	Cast(MAX(Convert(int,Pendiente)) as bit) Pendiente , 
			SUM(CantidadPedida) CantidadPedida, 
			SUM(CantidadRemitida) CantidadRemitida, 
			SUM(CantidadFacturada) CantidadFacturada
FROM venCotizaciones INNER JOIN venCotizCuerpo ON
	venCotizaciones.venCotizaciones = venCotizCuerpo.Cotizacion_Id
WHERE
venCotizaciones.venCotizaciones= @pvenCotizaciones
GROUP BY venCotizaciones.venCotizaciones, venCotizaciones.Estado, venCotizaciones.UsuarioAutoriz_Id
	
Go



