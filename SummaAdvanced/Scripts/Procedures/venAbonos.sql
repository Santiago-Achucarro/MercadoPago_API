DROP PROCEDURE venAbonosGuardar
GO
CREATE PROCEDURE venAbonosGuardar
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
@pSubTipoMov_Id varchar(5) = NULL,
@pFechaInicio qFecha,
@pFechaFin qFecha,
@pFechaUltFacturacion qFecha,
@pFechaProxFacturacion qFecha,
@pCliente_Id varchar(15) = NULL,
@pSucursal SucursalN = NULL,
@pSucursalUsu Sucursal = NULL,
@pMoneda_Id varchar(3) = NULL,
@pMonedaFacturacion varchar(3) = NULL,
@pCondPagoCli_Id varchar(5) = NULL,
@pListaPrecio_Id varchar(5) = NULL,
@pVendedor_Id varchar(5) = NULL,
@pFormaEntrega_Id varchar(3) = NULL,
@pObservaciones QMemo = NULL,
@pSubTotal qMonedaD2,
@pSubTotalBonif qMonedaD2,
@pImporteTotal qMonedaD2,
@pBonificacion1 qMonedaD2,
@pBonificacion2 qMonedaD2,
@pBonificacion3 qMonedaD2,
@pBonificacion4 qMonedaD2,
@pBonificacion5 qMonedaD2,
@pDato1 qMonedaD2,
@pDato2 qMonedaD2,
@pDato3 qMonedaD2,
@pFrecuencia char(1),
@pCambio qMonedaD8,
@pTipoPrecioForm char(1),
@pFechaRegistro qFechaHora,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
Declare @lIdentity int = (Select venAbonos
 From venAbonosSegmentos
 Where
	venAbonosSegmentos.Empresa_id = @pEmpresa_Id and 
	venAbonosSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venAbonosSegmentos.Segmento1N = @pSegmento1N and 
	venAbonosSegmentos.Segmento2N = @pSegmento2N and 
	venAbonosSegmentos.Segmento3N = @pSegmento3N and 
	venAbonosSegmentos.Segmento4N = @pSegmento4N and 
	venAbonosSegmentos.Segmento1C = @pSegmento1C and 
	venAbonosSegmentos.Segmento2C = @pSegmento2C and 
	venAbonosSegmentos.Segmento3C = @pSegmento3C and 
	venAbonosSegmentos.Segmento4C = @pSegmento4C )

IF (@lIdentity IS NOT NULL)
BEGIN 
	UPDATE venAbonos
	SET @lIdentity = venAbonos,
		Empresa_Id = @pEmpresa_Id,
		SubTipoMov_Id = dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		FechaInicio = @pFechaInicio,
		FechaFin = @pFechaFin,
		FechaUltFacturacion = @pFechaUltFacturacion,
		FechaProxFacturacion = @pFechaProxFacturacion,
		Cliente_Id = dbo.FuncFKvenClientes(@pCliente_Id),
		Sucursal = @pSucursal,
		SucursalUsu = dbo.FuncFKgenSucursalesEmpr(@pSucursalUsu),
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		MonedaFacturacion = dbo.FuncFKgenMonedas(@pMonedaFacturacion),
		CondPagoCli_Id = dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		Vendedor_Id = dbo.FuncFKvenVendedores(@pVendedor_Id),
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		Observaciones = @pObservaciones,
		SubTotal = @pSubTotal,
		SubTotalBonif = @pSubTotalBonif,
		ImporteTotal = @pImporteTotal,
		Bonificacion1 = @pBonificacion1,
		Bonificacion2 = @pBonificacion2,
		Bonificacion3 = @pBonificacion3,
		Bonificacion4 = @pBonificacion4,
		Bonificacion5 = @pBonificacion5,
		Dato1 = @pDato1,
		Dato2 = @pDato2,
		Dato3 = @pDato3,
		Frecuencia = @pFrecuencia,
		Cambio = @pCambio,
		TipoPrecioForm = @pTipoPrecioForm,
		FechaRegistro = getDate() ,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE venAbonos = @lIdentity
END 
ELSE 
BEGIN 
	INSERT INTO venAbonos
	(
		Empresa_Id,
		SubTipoMov_Id,
		FechaInicio,
		FechaFin,
		FechaUltFacturacion,
		FechaProxFacturacion,
		Cliente_Id,
		Sucursal,
		SucursalUsu,
		Moneda_Id,
		MonedaFacturacion,
		CondPagoCli_Id,
		ListaPrecio_Id,
		Vendedor_Id,
		FormaEntrega_Id,
		Observaciones,
		SubTotal,
		SubTotalBonif,
		ImporteTotal,
		Bonificacion1,
		Bonificacion2,
		Bonificacion3,
		Bonificacion4,
		Bonificacion5,
		Dato1,
		Dato2,
		Dato3,
		Frecuencia,
		Cambio,
		TipoPrecioForm,
		FechaRegistro,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKvenSubTipoMov(@pSubTipoMov_Id),
		@pFechaInicio,
		@pFechaFin,
		@pFechaUltFacturacion,
		@pFechaProxFacturacion,
		dbo.FuncFKvenClientes(@pCliente_Id),
		@pSucursal,
		dbo.FuncFKgenSucursalesEmpr(@pSucursalUsu),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		dbo.FuncFKgenMonedas(@pMonedaFacturacion),
		dbo.FuncFKvenCondPago(@pCondPagoCli_Id),
		dbo.FuncFKvenListasPrecios(@pListaPrecio_Id),
		dbo.FuncFKvenVendedores(@pVendedor_Id),
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		@pObservaciones,
		@pSubTotal,
		@pSubTotalBonif,
		@pImporteTotal,
		@pBonificacion1,
		@pBonificacion2,
		@pBonificacion3,
		@pBonificacion4,
		@pBonificacion5,
		@pDato1,
		@pDato2,
		@pDato3,
		@pFrecuencia,
		@pCambio,
		@pTipoPrecioForm,
		getDate(),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentity =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentity as RetVal 

GO

DROP PROCEDURE venAbonosDatos_Identity
GO
CREATE PROCEDURE venAbonosDatos_Identity
(
@lIdentity int
)
AS
SET NOCOUNT ON 

SELECT venAbonos.venAbonos, venAbonos.Empresa_Id, genSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1N,
	venAbonosSegmentos.Segmento2N,venAbonosSegmentos.Segmento3N,venAbonosSegmentos.Segmento4N,
	venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,venAbonosSegmentos.Segmento3C,
	venAbonosSegmentos.Segmento4C, 
	dbo.Segmento(venAbonosSegmentos.Segmento_Id, venAbonosSegmentos.Segmento1C, venAbonosSegmentos.Segmento2C,
	venAbonosSegmentos.Segmento3C, venAbonosSegmentos.Segmento4C, venAbonosSegmentos.Segmento1N,
	venAbonosSegmentos.Segmento2N,venAbonosSegmentos.Segmento3N,venAbonosSegmentos.Segmento4N) Abono, 
	venSubTipoMov.SubTipoMov_Id, venSubTipoMov.Descripcion as DescripcionSubTipoMov,
	venAbonos.FechaInicio, venAbonos.FechaFin, venAbonos.FechaUltFacturacion, venAbonos.FechaProxFacturacion,
	venClientes.Cliente_Id, venAbonos.Sucursal, venClieHabitual.NombreFantasia, genSucursalesEmpr.Sucursal SucursalUsu,
	genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, genMonedasFactu.Moneda_Id MonedaFacturacion,
	genMonedasFactu.Descripcion as DescripcionMonedasFacturacion, venCondPago.CondPagoCli_Id, venCondPago.Descripcion as DescripcionCondPago, venListasPrecios.ListaPrecio_Id,
	venListasPrecios.Descripcion as DescripcionListasPrecios, venVendedores.Vendedor_Id, venVendedores.Nombre as DescripcionVendedores, venFormaEntrega.FormaEntrega_Id,
	venFormaEntrega.RazonSocial as DescripcionFormaEntrega, venAbonos.Observaciones, venAbonos.SubTotal, venAbonos.SubTotalBonif,
	venAbonos.ImporteTotal, venAbonos.Bonificacion1, venAbonos.Bonificacion2, venAbonos.Bonificacion3,
	venAbonos.Bonificacion4, venAbonos.Bonificacion5, venAbonos.Dato1, venAbonos.Dato2,
	venAbonos.Dato3, venAbonos.Frecuencia, venAbonos.Cambio, venAbonos.TipoPrecioForm, venAbonos.FechaRegistro, venAbonos.Inactivo,
	venAbonos.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM venAbonos 
LEFT JOIN venSubTipoMov  ON (venSubTipoMov.venSubTipoMov = venAbonos.SubTipoMov_Id)
LEFT JOIN venClieHabitual  ON (venClieHabitual.genEntidades = venAbonos.Cliente_Id) AND (venClieHabitual.Sucursal = venAbonos.Sucursal)
Left Join venClientes On venAbonos.Cliente_Id = venClientes.genEntidades
LEFT JOIN genSucursalesEmpr  ON (genSucursalesEmpr.genSucursalesEmpr = venAbonos.SucursalUsu)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venAbonos.Moneda_Id)
LEFT JOIN genMonedas genMonedasFactu ON (genMonedasFactu.genMonedas = venAbonos.MonedaFacturacion)
LEFT JOIN venCondPago  ON (venCondPago.venCondPago = venAbonos.CondPagoCli_Id)
LEFT JOIN venListasPrecios  ON (venListasPrecios.venListasPrecios = venAbonos.ListaPrecio_Id)
LEFT JOIN venVendedores  ON (venVendedores.venVendedores = venAbonos.Vendedor_Id)
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venAbonos.FormaEntrega_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venAbonos.Usuario_Id)
INNER JOIN venAbonosSegmentos ON venAbonosSegmentos.venAbonos = venAbonos.venAbonos
INNER JOIN genSegmentos ON venAbonosSegmentos.Segmento_Id = genSegmentos.genSegmentos
WHERE  venAbonos.venAbonos = @lIdentity

Exec venAbonosCuerpoDatos @lIdentity

Exec genAtributosGeneralesIdentityDatos @lIdentity, 'venAbonos'
Exec genAdjuntosDatos '',0,0
RETURN @@Error 

GO


DROP PROCEDURE venAbonosDatos
GO
CREATE PROCEDURE venAbonosDatos
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

Declare @pIdentity int = (select venAbonos from venAbonosSegmentos
	Where
	venAbonosSegmentos.Empresa_id = @pEmpresa_id and 
	venAbonosSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	venAbonosSegmentos.Segmento1N = @pSegmento1N and 
	venAbonosSegmentos.Segmento2N = @pSegmento2N and 
	venAbonosSegmentos.Segmento3N = @pSegmento3N and 
	venAbonosSegmentos.Segmento4N = @pSegmento4N and 
	venAbonosSegmentos.Segmento1C = @pSegmento1C and 
	venAbonosSegmentos.Segmento2C = @pSegmento2C and 
	venAbonosSegmentos.Segmento3C = @pSegmento3C and 
	venAbonosSegmentos.Segmento4C = @pSegmento4C)

Exec venAbonosDatos_Identity @pIdentity
Go


DROP PROCEDURE venAbonosEliminar
GO
CREATE PROCEDURE venAbonosEliminar
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
@pSegmento4C VarChar(20)
)
AS
SET NOCOUNT ON 

Declare @lIdentity int = (select venAbonos from venAbonosSegmentos
	Where
	venAbonosSegmentos.Empresa_id = @pEmpresa_Id and 
	venAbonosSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	venAbonosSegmentos.Segmento1N = @pSegmento1N and 
	venAbonosSegmentos.Segmento2N = @pSegmento2N and 
	venAbonosSegmentos.Segmento3N = @pSegmento3N and 
	venAbonosSegmentos.Segmento4N = @pSegmento4N and 
	venAbonosSegmentos.Segmento1C = @pSegmento1C and 
	venAbonosSegmentos.Segmento2C = @pSegmento2C and 
	venAbonosSegmentos.Segmento3C = @pSegmento3C and 
	venAbonosSegmentos.Segmento4C = @pSegmento4C)

DELETE FROM venAbonos 
WHERE venAbonos = @lIdentity
RETURN @@Error 

GO

Drop procedure venAbonosActuFecha
GO
Create procedure venAbonosActuFecha
(
@pvenAbonos int,
@pFechaUltFacturacion datetime,
@pFechaProxFacturacion datetime
)
As

Update venAbonos Set FechaProxFacturacion = @pFechaProxFacturacion, FechaUltFacturacion = @pFechaUltFacturacion
Where venAbonos = @pvenAbonos
Go

