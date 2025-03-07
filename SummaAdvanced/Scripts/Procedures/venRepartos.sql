--venrepartodatos 1
DROP PROCEDURE venRepartoGuardar
GO
CREATE PROCEDURE venRepartoGuardar
(
@pEmpresa_Id int,
@pSegmento_Id varChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pSucursal varChar(5),
@pFechaReparto qFecha,
@pFechaEntrega qFecha,
@pDeposito_Id varchar(15) = NULL,
@pZonaDesde varchar(5),
@pZonaHasta varchar(5),
@pTipoClieDesde varchar(5),
@pTipoClieHasta varchar(5),
@pClienteDesde varchar(15),
@pClienteHasta varchar(15),
@pDepoPedido_Id varchar(15) = NULL,
@pAutomatico Sino,
@pCerrado Sino
)
AS
SET NOCOUNT ON 
Declare @lIdentity int = (Select venReparto
 from venRepaSegmentos
 Where
	venRepaSegmentos.Empresa_id = @pEmpresa_Id and 
	venRepaSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venRepaSegmentos.Segmento1N = @pSegmento1N and 
	venRepaSegmentos.Segmento2N = @pSegmento2N and 
	venRepaSegmentos.Segmento3N = @pSegmento3N and 
	venRepaSegmentos.Segmento4N = @pSegmento4N and 
	venRepaSegmentos.Segmento1C = @pSegmento1C and 
	venRepaSegmentos.Segmento2C = @pSegmento2C and 
	venRepaSegmentos.Segmento3C = @pSegmento3C and 
	venRepaSegmentos.Segmento4C = @pSegmento4C )

IF (@lIdentity IS NOT NULL)
BEGIN 
	UPDATE venReparto
	SET
		Empresa_Id = @pEmpresa_Id,
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		FechaReparto = @pFechaReparto,
		FechaEntrega = @pFechaEntrega,
		Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id),
		ZonaDesde = @pZonaDesde,
		ZonaHasta = @pZonaHasta,
		TipoClieDesde = @pTipoClieDesde,
		TipoClieHasta = @pTipoClieHasta,
		ClienteDesde = @pClienteDesde,
		ClienteHasta = @pClienteHasta,
		DepoPedido_Id = dbo.FuncFKstkDepositos(@pDepoPedido_Id),
		Automatico = @pAutomatico,
		Cerrado = @pCerrado
	WHERE @lIdentity = venReparto
END 
ELSE 
BEGIN 
	INSERT INTO venReparto
	(
		Empresa_Id,
		Sucursal,
		FechaReparto,
		FechaEntrega,
		Deposito_Id,
		ZonaDesde,
		ZonaHasta,
		TipoClieDesde,
		TipoClieHasta,
		ClienteDesde,
		ClienteHasta,
		DepoPedido_Id,
		Automatico,
		Cerrado
	)
	VALUES 
	(	
		@pEmpresa_Id,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		@pFechaReparto,
		@pFechaEntrega,
		dbo.FuncFKstkDepositos(@pDeposito_Id),
		@pZonaDesde,
		@pZonaHasta,
		@pTipoClieDesde,
		@pTipoClieHasta,
		@pClienteDesde,
		@pClienteHasta,
		dbo.FuncFKstkDepositos(@pDepoPedido_Id),
		@pAutomatico,
		@pCerrado
	)
	SET @lIdentity =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentity as RetVal 

GO

DROP PROCEDURE venRepartoDatos
GO
CREATE PROCEDURE venRepartoDatos
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
As

Declare @pIdentity int= (select venReparto from venRepaSegmentos
	Where
	venRepaSegmentos.Empresa_Id = @pEmpresa_Id and 
	venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	venRepaSegmentos.Segmento1N = @pSegmento1N and 
	venRepaSegmentos.Segmento2N = @pSegmento2N and 
	venRepaSegmentos.Segmento3N = @pSegmento3N and 
	venRepaSegmentos.Segmento4N = @pSegmento4N and 
	venRepaSegmentos.Segmento1C = @pSegmento1C and 
	venRepaSegmentos.Segmento2C = @pSegmento2C and 
	venRepaSegmentos.Segmento3C = @pSegmento3C and 
	venRepaSegmentos.Segmento4C = @pSegmento4C)

Exec venRepartoDatosIdentity @pIdentity

GO




Drop PROCEDURE venRepartoEliminar
Go

CREATE PROCEDURE venRepartoEliminar
(
@lIdentity int
)
AS
SET NOCOUNT ON 

DELETE FROM venReparto WHERE venReparto.venReparto = @lIdentity
RETURN @@Error 

GO

-- venRepartoCalcularCuerpo 1,'REPARTO',0,0,0,0,' ',' ',' ',' ','20231120','09','09',' ','ZZ',' ','ZZ','S100','S100'
Drop Procedure venRepartoCalcularCuerpo
Go

Create Procedure venRepartoCalcularCuerpo
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
@pFechaEntrega DateTime,
@pDeposito_Id varChar(15),
@pDepoPedido varChar(15),
@pZonaDesde varChar(5),
@pZonaHasta varChar(5),
@pTipoClieDesde varChar(5),
@pTipoClieHasta varChar(5),
@pClienteDesde varChar(15),
@pClienteHasta varChar(15)
)
As

Declare @pIdentity int = isnull((Select venReparto From venRepaSegmentos
	Where
	venRepaSegmentos.Empresa_Id = @pEmpresa_id And 
	venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And 
	venRepaSegmentos.Segmento1N = @pSegmento1N And 
	venRepaSegmentos.Segmento2N = @pSegmento2N And 
	venRepaSegmentos.Segmento3N = @pSegmento3N And 
	venRepaSegmentos.Segmento4N = @pSegmento4N And 
	venRepaSegmentos.Segmento1C = @pSegmento1C And 
	venRepaSegmentos.Segmento2C = @pSegmento2C And 
	venRepaSegmentos.Segmento3C = @pSegmento3C And 
	venRepaSegmentos.Segmento4C = @pSegmento4C),0)


SELECT venReparto.venReparto, venRepaSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venRepaSegmentos.Segmento1N,
	venRepaSegmentos.Segmento2N,venRepaSegmentos.Segmento3N,venRepaSegmentos.Segmento4N, venRepaSegmentos.Segmento1C, 
	venRepaSegmentos.Segmento2C,venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, genSucursalesEmpr.Sucursal,
	venReparto.FechaReparto, venReparto.FechaEntrega, stkDepositos.Deposito_Id,
	stkDepositos.Descripcion as DescripcionDepositos, venReparto.ZonaDesde, venReparto.ZonaHasta, venReparto.TipoClieDesde,
	venReparto.TipoClieHasta, venReparto.ClienteDesde, venReparto.ClienteHasta, stkDepositos2.Deposito_Id DepoPedido_Id,
	stkDepositos2.Descripcion as DescripcionDepoPedido, venReparto.Automatico,
	venReparto.Cerrado, Convert(bit, 0) IncluyeStockCero, '' Mensaje, 0 Renglon, 'S' VolverACalcular, '' PrimeraVez, 0 Total

FROM venReparto 
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venReparto.Deposito_Id)
LEFT JOIN stkDepositos stkDepositos2 ON (stkDepositos2.stkDepositos = venReparto.DepoPedido_Id)
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venReparto.venReparto
Inner Join genSegmentos On genSegmentos.genSegmentos = venRepaSegmentos.Segmento_Id
Left Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = venReparto.Sucursal
WHERE venReparto.venReparto = @pIdentity

/*
If @pSegmento1N = 0
Begin
*/
-- Los renglones del reparto ingresado --
	Select venPediSegmentos.Empresa_Id,  venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
		venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N, venPediSegmentos.Segmento1C, 
		venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
		dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
		venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,
		venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) Segmento,
		venClientes.Cliente_Id, venClientes.RazonSocial, 0 Renglon_Rep,
		venPedidos.venPedidos, venPedidos.UsuarioAutoriz_Id,
		venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id, stkProductos.Descripcion,
		stkUniMed.Medida_Id MedidaPpal, stkUMAlt.Medida_Id MedidaAlterna, stkUMPed.Medida_Id MedidaPed,
		venPediCuerpo.Factor, stkProductos.FactorAlterna,
		stkProductos.Clase, stkProductos.ClaseAlterna, stkProductos.Serializable, stkProductos.TrabajaPorLotes, 
		(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida)/ venPediCuerpo.Factor PendienteRemitir,
		(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadFacturada)/ venPediCuerpo.Factor PendienteFacturar,
		stkExistencia.Cantidad/ venPediCuerpo.Factor Stock, stkExistencia.CantidadReservada/ venPediCuerpo.Factor CantidadReservada, 
		venPediCuerpo.ReservaMercaderia,
		venPediCuerpo.Bonificacion,
		(Select Sum(vrp.CantidadForm*vpc.Factor) From venRepaPedi vrp, venReparto vr, venPediCuerpo vpc, venRepaSegmentos vrs Where
			vrp.Remitido = 0 and vr.Cerrado = 0 And
			vrp.venReparto = vr.venReparto And
			vrs.venReparto = vr.venReparto And
			vpc.venPedidos = vrp.venPedidos And
			vpc.Renglon_Pe = vrp.Renglon_Pe And
			vpc.Producto_Id = stkProductos.stkProductos And vrs.Empresa_Id = @pEmpresa_Id And
			/*vpc.ReservaMercaderia = 0 And */
			vr.venReparto <> @pIdentity And vpc.Deposito_Id = dbo.FuncFKstkDepositos(@pDepoPedido))/ venPediCuerpo.Factor CantResePedi,
			/*
		(Select Sum(vrf.Cantidad) From venRepaFactu vrf, venReparto  vr, venMovConStockCr vmc Where
			vrf.Sucursal_rep = vr.Sucursal_rep and
			vrf.Numero_rep = vr.Numero_rep and
			vmc.venTipomov_id  = vrf.venTipomov_id and
			vmc.vensucursal = vrf.venSucursal and
			vmc.venComprobante = vrf.venComprobante and
			vmc.venLetra = vrf.venLetra and
			vmc.venRenglon = vrf.venRenglon and
			vmc.Producto_id = stkProductos.Producto_id and
			(vr.Sucursal_rep <> ?pSucursal_rep or vr.Numero_rep <> ?pNumero_rep)) */ 0 CantReseFactu,
		stkExistencia.CantidadAlterna StockAlterna, 

		venRepaPedi.CantidadForm, venRepaPedi.CantidadAlternaForm,
		venRepaPedi.Remitido, venRepaPedi.Facturado, venPediCuerpo.FechaEntrega,
		venCondPago.CondPagoCli_Id, venCondPago.Descripcion DescCondPago, 0 Renglon, 
		0.00 as Disponible, venPedidos.SoloEntrega, ' ' Color
	From venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venPediCuerpo On venPedidos.venPedidos = venPediCuerpo.venPedidos
	Inner Join venRepaPedi On venRepaPedi.venPedidos = venPediCuerpo.venPedidos And
			venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join stkProductos On stkProductos.stkProductos = venPediCuerpo.Producto_Id
	Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
	Left Join stkUniMed stkUMAlt On stkUMAlt.stkUniMed = stkProductos.MedidaAlterna
	Inner Join stkUniMed stkUMPed On stkUMPed.stkUniMed = venPediCuerpo.Medida_Id
	Inner Join venCondPago On venCondPago.venCondPago = venPedidos.CondPagoCli_Id
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venClieHabitual On venClieHabitual.genEntidades = venPedidos.Cliente_Id And venClieHabitual.Sucursal = venPedidos.Sucursal
	Left Join stkExistencia On stkExistencia.Producto_Id = venPediCuerpo.Producto_Id And 
			stkExistencia.Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) And stkExistencia.Empresa_Id= @pEmpresa_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	Where venFormaEntrega.ExcluirDelReparto = 0 And venPediCuerpo.FechaEntrega <= @pFechaEntrega And 
	venRepaPedi.venReparto = @pIdentity

Union All	
-- Los renglones pendientes de los pedidos --
	Select venPediSegmentos.Empresa_Id,  venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
		venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N, venPediSegmentos.Segmento1C, 
		venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
		dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
		venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,
		venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) Segmento,
		venClientes.Cliente_Id, venClientes.RazonSocial, 0 Renglon_Rep,
		venPedidos.venPedidos, venPedidos.UsuarioAutoriz_Id,
		venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id, stkProductos.Descripcion,
		stkUniMed.Medida_Id MedidaPpal, stkUMAlt.Medida_Id MedidaAlterna, stkUMPed.Medida_Id MedidaPed,
		venPediCuerpo.Factor, stkProductos.FactorAlterna,
		stkProductos.Clase, stkProductos.ClaseAlterna, stkProductos.Serializable, stkProductos.TrabajaPorLotes, 
		(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida)/ venPediCuerpo.Factor PendienteRemitir,
		(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadFacturada)/ venPediCuerpo.Factor PendienteFacturar,
		stkExistencia.Cantidad/ venPediCuerpo.Factor Stock, stkExistencia.CantidadReservada/ venPediCuerpo.Factor CantidadReservada, 
		venPediCuerpo.ReservaMercaderia,	venPediCuerpo.Bonificacion,
		(Select Sum(vrp.CantidadForm*vpc.Factor) From venRepaPedi vrp, venReparto vr, venPediCuerpo vpc, venRepaSegmentos vrs Where
			vrp.Remitido = 0 and vr.Cerrado = 0 And
			vrp.venReparto = vr.venReparto And
			vrs.venReparto = vr.venReparto And
			vpc.venPedidos = vrp.venPedidos And
			vpc.Renglon_Pe = vrp.Renglon_Pe And
			vpc.Producto_Id = stkProductos.stkProductos And vrs.Empresa_Id = @pEmpresa_Id And
			/*vpc.ReservaMercaderia = 0 And*/
			(vr.venReparto <> @pIdentity And vpc.Deposito_Id = dbo.FuncFKstkDepositos(@pDepoPedido)))/ venPediCuerpo.Factor CantResePedi,
			/*
		(Select Sum(vrf.Cantidad) From venRepaFactu vrf, venReparto  vr, venMovConStockCr vmc Where
			vrf.Sucursal_rep = vr.Sucursal_rep and
			vrf.Numero_rep = vr.Numero_rep and
			vmc.venTipomov_id  = vrf.venTipomov_id and
			vmc.vensucursal = vrf.venSucursal and
			vmc.venComprobante = vrf.venComprobante and
			vmc.venLetra = vrf.venLetra and
			vmc.venRenglon = vrf.venRenglon and
			vmc.Producto_id = stkProductos.Producto_id and
			(vr.Sucursal_rep <> ?pSucursal_rep or vr.Numero_rep <> ?pNumero_rep)) */ 0 CantReseFactu,
		stkExistencia.CantidadAlterna StockAlterna, 

		0 CantidadForm, 0 CantidadAlternaForm, Cast(0 As bit) Remitido, Cast(0 As bit) Facturado, venPediCuerpo.FechaEntrega,
		venCondPago.CondPagoCli_Id, venCondPago.Descripcion DescCondPago,
		Cast(ROW_NUMBER() OVER( ORDER BY venClientes.Cliente_Id, venPedidos.venPedidos, venPediCuerpo.Renglon_Pe) as int) - 1 as Renglon, 
		0.00 as Disponible, venPedidos.SoloEntrega, ' ' Color
	From venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venPediCuerpo On venPedidos.venPedidos = venPediCuerpo.venPedidos
	--Inner Join venRepaPedi On venRepaPedi.venPedidos = venPediCuerpo.venPedidos And
	--		venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join stkProductos On stkProductos.stkProductos = venPediCuerpo.Producto_Id
	Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
	Left Join stkUniMed stkUMAlt On stkUMAlt.stkUniMed = stkProductos.MedidaAlterna
	Inner Join stkUniMed stkUMPed On stkUMPed.stkUniMed = venPediCuerpo.Medida_Id
	Inner Join venCondPago On venCondPago.venCondPago = venPedidos.CondPagoCli_Id
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venClieHabitual On venClieHabitual.genEntidades = venPedidos.Cliente_Id And venClieHabitual.Sucursal = venPedidos.Sucursal
	Left Join stkExistencia On stkExistencia.Producto_Id = venPediCuerpo.Producto_Id And 
			stkExistencia.Deposito_Id = dbo.FuncFKstkDepositos(@pDeposito_Id) and stkExistencia.Empresa_Id=@pEmpresa_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	Where venFormaEntrega.ExcluirDelReparto = 0 And venPediCuerpo.FechaEntrega <= @pFechaEntrega And 
	Not Exists (Select 1 From venRepaPedi, venReparto Where
			venReparto.venReparto = venRepaPedi.venReparto And
			( venReparto.Cerrado = 0 Or venReparto.venReparto = @pIdentity) And
			venRepaPedi.venPedidos = venPediCuerpo.venPedidos And
			venRepaPedi.Renglon_pe = venPediCuerpo.Renglon_pe) And
	venTiposClie.TipoClie_Id Between @pTipoClieDesde And @pTipoClieHasta And
	venClientes.Cliente_Id Between @pClienteDesde And @pClienteHasta And
	venPediCuerpo.Deposito_Id = dbo.FuncFKstkDepositos(@pDepoPedido) And
	venPediCuerpo.Pendiente = 1 And (venPediCuerpo.CantidadPedida > venPediCuerpo.CantidadRemitida /* Or
	venPediCuerpo.CantidadPedida > venPediCuerpo.CantidadFacturada*/) And
	venPedidos.Estado = 'P' and venPedidos.Empresa_Id= @pEmpresa_Id
	--Order by 11, 2,3,4,5,6,7,8,9
	Order by venClientes.Cliente_Id, venPedidos.venPedidos, venPediCuerpo.Renglon_Pe

EXEC venRepaPediSerieDatos @pIdentity	

Exec genAtributosGeneralesIdentityDatos @pidentity, 'venReparto'

Exec venRepaUbicacionDatos   @pidentity

Go




Drop procedure venRepartoCerrar
Go
Create procedure venRepartoCerrar
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
As
Declare @pIdentity int = (Select venReparto From venRepaSegmentos
	Where
	venRepaSegmentos.Empresa_Id = @pEmpresa_id And 
	venRepaSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And 
	venRepaSegmentos.Segmento1N = @pSegmento1N And 
	venRepaSegmentos.Segmento2N = @pSegmento2N And 
	venRepaSegmentos.Segmento3N = @pSegmento3N And 
	venRepaSegmentos.Segmento4N = @pSegmento4N And 
	venRepaSegmentos.Segmento1C = @pSegmento1C And 
	venRepaSegmentos.Segmento2C = @pSegmento2C And 
	venRepaSegmentos.Segmento3C = @pSegmento3C And 
	venRepaSegmentos.Segmento4C = @pSegmento4C)

Update venReparto Set Cerrado = 1 Where venReparto = @pIdentity
Go

DROP PROCEDURE venRepartoDatosIdentity
GO
CREATE PROCEDURE venRepartoDatosIdentity
(
@pvenReparto int
)
As

SELECT venReparto.venReparto, venRepaSegmentos.Empresa_Id, genSegmentos.Segmento_Id, venRepaSegmentos.Segmento1N,
	venRepaSegmentos.Segmento2N,venRepaSegmentos.Segmento3N,venRepaSegmentos.Segmento4N, venRepaSegmentos.Segmento1C, 
	venRepaSegmentos.Segmento2C,venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, genSucursalesEmpr.Sucursal,
	venReparto.FechaReparto, venReparto.FechaEntrega, stkDepositos.Deposito_Id,
	stkDepositos.Descripcion as DescripcionDepositos, venReparto.ZonaDesde, '' DescripcionZonaDesde,
	venReparto.ZonaHasta, '' DescripcionZonaHasta, venReparto.TipoClieDesde, '' DescripcionTipoClieDesde,
	venReparto.TipoClieHasta, '' DescripcionTipoClieHasta, venReparto.ClienteDesde, '' DescripcionClienteDesde,
	venReparto.ClienteHasta, '' DescripcionClienteHasta, stkDepositos2.Deposito_Id DepoPedido_Id,
	stkDepositos2.Descripcion as DescripcionDepoPedido, venReparto.Automatico,
	venReparto.Cerrado, Convert(bit, 0) IncluyeStockCero, '' Mensaje, 0 Renglon, 'S' VolverACalcular, '' PrimeraVez, 0 Total
	FROM venReparto 
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = venReparto.Deposito_Id)
LEFT JOIN stkDepositos stkDepositos2 ON (stkDepositos2.stkDepositos = venReparto.DepoPedido_Id)
Inner Join venRepaSegmentos On venRepaSegmentos.venReparto = venReparto.venReparto
Inner Join genSegmentos On genSegmentos.genSegmentos = venRepaSegmentos.Segmento_Id
Left Join genSucursalesEmpr On genSucursalesEmpr.genSucursalesEmpr = venReparto.Sucursal
WHERE venReparto.venReparto = @pvenReparto

	Select venPediSegmentos.Empresa_Id, venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1N,
		venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N, venPediSegmentos.Segmento1C, 
		venPediSegmentos.Segmento2C,venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
		dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C,
		venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N,
		venPediSegmentos.Segmento2N,venPediSegmentos.Segmento3N,venPediSegmentos.Segmento4N) Segmento,
		venClientes.Cliente_Id, venClientes.RazonSocial, venRepaPedi.Renglon_Rep,
		venPedidos.venPedidos, venPedidos.UsuarioAutoriz_Id,
		venPediCuerpo.Renglon_Pe, stkProductos.Producto_Id, stkProductos.Descripcion,
		venPediCuerpo.Factor, stkProductos.FactorAlterna,
		stkUniMed.Medida_Id MedidaPpal, stkUMAlt.Medida_Id MedidaAlterna, stkUMPed.Medida_Id MedidaPed,
		stkProductos.Clase, stkProductos.ClaseAlterna, stkProductos.Serializable, stkProductos.TrabajaPorLotes, 
		(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida)/ venPediCuerpo.Factor PendienteRemitir,
		(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadFacturada)/ venPediCuerpo.Factor PendienteFacturar,
		stkExistencia.Cantidad/ venPediCuerpo.Factor Stock, stkExistencia.CantidadReservada/ venPediCuerpo.Factor CantidadReservada, 
		venPediCuerpo.ReservaMercaderia,	venPediCuerpo.Bonificacion,
		(Select Sum(vrp.CantidadForm*vpc.Factor) From venRepaPedi vrp, venReparto vr, venPediCuerpo vpc, venRepaSegmentos vrs Where
			vrp.Remitido = 0 and vr.Cerrado = 0 And
			vrp.venReparto = vr.venReparto And
			vrs.venReparto = vr.venReparto And
			vpc.venPedidos = vrp.venPedidos And
			vpc.Renglon_Pe = vrp.Renglon_Pe And
			vpc.Producto_Id = stkProductos.stkProductos And vrs.Empresa_Id = venPediSegmentos.Empresa_Id And
			/*vpc.ReservaMercaderia = 0 And */
			(vr.venReparto <> @pvenReparto And vpc.Deposito_Id = venPediCuerpo.Deposito_Id))/ venPediCuerpo.Factor CantResePedi,
			/*
		(Select Sum(vrf.Cantidad) From venRepaFactu vrf, venReparto  vr, venMovConStockCr vmc Where
			vrf.Sucursal_rep = vr.Sucursal_rep and
			vrf.Numero_rep = vr.Numero_rep and
			vmc.venTipomov_id  = vrf.venTipomov_id and
			vmc.vensucursal = vrf.venSucursal and
			vmc.venComprobante = vrf.venComprobante and
			vmc.venLetra = vrf.venLetra and
			vmc.venRenglon = vrf.venRenglon and
			vmc.Producto_id = stkProductos.Producto_id and
			(vr.Sucursal_rep <> ?pSucursal_rep or vr.Numero_rep <> ?pNumero_rep)) */ 0 CantReseFactu,
		stkExistencia.CantidadAlterna StockAlterna, 

		venRepaPedi.CantidadForm, venRepaPedi.CantidadAlternaForm,
		venRepaPedi.Remitido, venRepaPedi.Facturado, venPediCuerpo.FechaEntrega,
		venCondPago.CondPagoCli_Id, venCondPago.Descripcion DescCondPago, 0 Renglon, 
		0.00 as Disponible, venPedidos.SoloEntrega, ' ' Color
	From venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venPediCuerpo On venPedidos.venPedidos = venPediCuerpo.venPedidos
	Inner Join venRepaPedi On venRepaPedi.venPedidos = venPediCuerpo.venPedidos And
			venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venPedidos.SubTipoMov_Id
	Inner Join stkProductos On stkProductos.stkProductos = venPediCuerpo.Producto_Id
	Inner Join stkUniMed On stkUniMed.stkUniMed = stkProductos.Medida_Id
	Left Join stkUniMed stkUMAlt On stkUMAlt.stkUniMed = stkProductos.MedidaAlterna
	Inner Join stkUniMed stkUMPed On stkUMPed.stkUniMed = venPediCuerpo.Medida_Id
	Inner Join venCondPago On venCondPago.venCondPago = venPedidos.CondPagoCli_Id
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venClieHabitual On venClieHabitual.genEntidades = venPedidos.Cliente_Id And venClieHabitual.Sucursal = venPedidos.Sucursal
	Left Join stkExistencia On stkExistencia.Producto_Id = venPediCuerpo.Producto_Id And 
			stkExistencia.Deposito_Id = venPediCuerpo.Deposito_Id And stkExistencia.Empresa_Id= venPediSegmentos.Empresa_Id	
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	Inner Join venTiposClie On venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
	Where venFormaEntrega.ExcluirDelReparto = 0 And --venPediCuerpo.FechaEntrega <= dbo.FechaActual() And 
	venRepaPedi.venReparto = @pvenReparto

EXEC venRepaPediSerieDatos @pvenReparto	
Exec genAtributosGeneralesIdentityDatos @pvenReparto, 'venReparto'
Exec venRepaUbicacionDatos   @pvenReparto
Go


