DROP Procedure venPediAutorizaDatos
GO
CREATE Procedure venPediAutorizaDatos
(
@pCliente_Id varChar(15) ,
@pEmpresa_Id int
)
As
IF @pCliente_Id = ''
	set @pCliente_Id = null

Select '' Cliente_Id, '' RazonSocial, '' TipoClie_Id, '' DescripcionTipoClie, '' Vendedor_Id, '' DescripcionVendedor, '' Zona_Id, '' DescripcionZona,
'' FormaEntrega_Id, '' DescripcionFormaEntrega, ' ' PrimeraVez, ' ' Mensaje,  0 Registro, ' ' Continuar, '' Cobrador_Id, '' DescripcionCobrador

Select venPedidos.venPedidos, venPediSegmentos.Segmento_Id, 
	venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N,
	venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C,
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
	venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, 
	venPediSegmentos.Segmento4N) Segmento,
	venClientes.Cliente_Id, venClientes.RazonSocial, venPedidos.Fecha, venPedidos.ObservEstado, 'P' Estado, venPedidos.ImporteTotal,
	'' Motivo, venPedidos.UsuarioAutoriz_Id
	FROM venPedidos
	Inner Join venClieHabitual On venPedidos.Cliente_Id = venClieHabitual.genEntidades And venPedidos.Sucursal = venClieHabitual.Sucursal
	--Inner Join venPedicuerpo On venPediCuerpo.venPedidos = venPedidos.venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venVendedores On venVendedores.venVendedores = venPedidos.Vendedor_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	WHERE
	venPedidos.Empresa_Id = @pEmpresa_Id And
	venPedidos.Estado In ('A','P') And 
	venClientes.Cliente_id = @pCliente_Id  And
	exists(select 1 from venPedicuerpo 
	Where venPediCuerpo.venPedidos = venPedidos.venPedidos and 
	venPedicuerpo.Pendiente = 1 And
	(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida) > 0) 
	Order By venClientes.Cliente_Id, venPedidos.venPedidos
	--venPediSegmentos.Segmento_Id, 
	--venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, venPediSegmentos.Segmento4N,
	--venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C
GO




DROP Procedure venPediAutorizaClienteDatos
GO
CREATE Procedure venPediAutorizaClienteDatos
(
@pCliente_Id varChar(15) = NULL,
@pTipoClie_Id varChar(5) = Null,
@pVendedor_Id varChar(5) = Null,
@pCobrador_Id varchar(5) = Null,
@pZona_Id varChar(5) = Null,
@pFormaEntrega_Id varChar(3) = Null,
@pSucursal_Id varchar(4) = null,
@pEmpresa_Id int
)
As
IF @pCliente_Id = ''
	set @pCliente_Id = null

IF @pSucursal_Id = ''
	set @pSucursal_Id = null
Select '' Cliente_Id, '' RazonSocial, '' TipoClie_Id, '' DescripcionTipoClie, '' Vendedor_Id, '' DescripcionVendedor, '' Cobrador_Id, '' DescripcionCobrador,
'' Zona_Id, '' DescripcionZona,
'' FormaEntrega_Id, '' DescripcionFormaEntrega

Select Distinct venClientes.Cliente_Id
	FROM venPedidos
	Inner Join venClieHabitual On venPedidos.Cliente_Id = venClieHabitual.genEntidades And venPedidos.Sucursal = venClieHabitual.Sucursal
	--Inner Join venPedicuerpo On venPediCuerpo.venPedidos = venPedidos.venPedidos
	Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
	Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
	Inner Join venVendedores On venVendedores.venVendedores = venPedidos.Vendedor_Id
	Inner Join venFormaEntrega On venFormaEntrega.venFormaEntrega = venPedidos.FormaEntrega_Id
	INNER JOIN venCobradores ON venCobradores.venCobradores = venClieHabitual.Cobrador_Id
	INNER JOIN  genUsuarios ON  genUsuarios.genUsuarios =venPedidos.Usuario_Id
	inner join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr=genUsuarios.Sucursal
	WHERE
	genSucursalesEmpr.Sucursal= ISNULL(@pSucursal_Id,genSucursalesEmpr.Sucursal) and
	venPedidos.UsuarioAutoriz_Id IS NULL AND 
	venPedidos.Empresa_Id = @pEmpresa_Id And
	venPedidos.Estado In ('P','A') And 
	venClientes.Cliente_id = IsNull(@pCliente_Id,venClientes.Cliente_Id) And
	venClieHabitual.TipoClie_Id = IsNull(dbo.FuncFKvenTiposClie(@pTipoClie_Id), venClieHabitual.TipoClie_Id) And
	venVendedores.Vendedor_Id = IsNull(@pVendedor_Id, venVendedores.Vendedor_Id) And
	venFormaEntrega.FormaEntrega_Id = IsNull(@pFormaEntrega_Id, venFormaEntrega.FormaEntrega_Id) And 
	venCobradores.Cobrador_Id = ISNULL(@pCobrador_Id, venCobradores.Cobrador_Id) AND
	exists(select 1 from venPedicuerpo 
	Where venPediCuerpo.venPedidos = venPedidos.venPedidos and 
	venPedicuerpo.Pendiente = 1 And
	(venPediCuerpo.CantidadPedida - venPediCuerpo.CantidadRemitida) > 0) 

GO