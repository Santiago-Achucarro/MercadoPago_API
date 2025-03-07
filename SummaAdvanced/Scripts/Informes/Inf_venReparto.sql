DROP PROCEDURE INF_venReparto
GO
CREATE PROCEDURE INF_venReparto  (
	@Empresa_Id INT, 
	@Segmento_Id VarChar(10), 
	@Segmento1N INT,
	@Segmento2N INT,
	@Segmento3N INT,
	@Segmento4N INT,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
	)
	AS
	SELECT venRepaSegmentos.venReparto,
	dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C,
	venRepaSegmentos.Segmento2C, venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, 
	venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, venRepaSegmentos.Segmento3N, 
	venRepaSegmentos.Segmento4N) AS SegmentoStr, VenRepaPedi.Renglon_Rep,
	dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C,
	venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, venPediSegmentos.Segmento4C, 
	venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, 
	venPediSegmentos.Segmento4N) AS PedidoStr, VenRepaPedi.Renglon_Pe,
	genSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C,
	venRepaSegmentos.Segmento2C, venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, 
	venRepaSegmentos.Segmento1N, venRepaSegmentos.Segmento2N, venRepaSegmentos.Segmento3N, 
	venRepaSegmentos.Segmento4N, 
		venClientes.Cliente_Id, venClientes.RazonSocial, genEntidades.Cuit, venClieHabitual.Sucursal,
	venClieHabitual.NombreFantasia, venClieHabitual.Direccion1_Entr, genProvincias.Descripcion Provincia,
	venReparto.FechaEntrega, venReparto.FechaReparto, 
	stkProductos.Producto_Id, stkProductos.Descripcion, stkDepositos.Descripcion DescDepo,
	venPediCuerpo.CantidadPedida, venRepaPedi.CantidadForm, stkUniMed.Medida_Id, 
	ISNULL(venRepaPediSerie.Serie,'') Serie, isNull(venRepaPediSerieUbi.Cantidad, ISNULL(venRepaPediSerie.Cantidad, venRepaPedi.CantidadForm)) CantSerie, 
	ISNULL(STUFF((SELECT ' '+ A FROM (SELECT DISTINCT Ped.Observaciones A
		FROM venRepaPedi venRP
		INNER JOIN (SELECT DISTINCT venPedidos.venPedidos, venPedidos.Sucursal, venPedidos.Observaciones
		FROM venPedidos) Ped ON
		venRP.venPedidos = Ped.venPedidos AND
		VenReparto.venReparto = venRP.VenReparto AND
		VenPedidos.Sucursal = Ped.Sucursal) B
		FOR XML PATH ('')),1,1,''),'') Observaciones, venVendedores.Vendedor_Id, venVendedores.Nombre NombreVendedor,
	venPedidos.CliOrdenCompra, isNull(stkUbicaciones.Ubicacion_Id, ISNULL(stkUbiAlmacenDefecto.Ubicacion_Id,'')) AS Ubicacion_Id
	FROM venRepaSegmentos
	INNER JOIN genSegmentos ON venRepaSegmentos.Segmento_Id = genSegmentos.genSegmentos
	INNER JOIN venReparto ON venRepaSegmentos.venReparto = venReparto.venReparto
	INNER JOIN VenRepaPedi ON venReparto.venReparto = VenRepaPedi.venReparto 
	LEFT OUTER JOIN venRepaPediSerie ON  VenRepaPedi.venPedidos = venRepaPediSerie.venPedidos AND
		VenRepaPedi.Renglon_Pe = venRepaPediSerie.Renglon_Pe AND
		VenRepaPedi.venReparto = venRepaPediSerie.venReparto AND
		VenRepaPedi.Renglon_Rep = venRepaPediSerie.Renglon_Rep
	INNER JOIN venPediCuerpo ON VenRepaPedi.venPedidos = venPediCuerpo.venPedidos AND
		venRepaPedi.Renglon_Pe = venPediCuerpo.Renglon_Pe
	INNER JOIN venPedidos ON venPedidos.venPedidos = venRepaPedi.venPedidos
	INNER JOIN stkProductos ON venPediCuerpo.Producto_Id = stkProductos.stkProductos 
	INNER JOIN genEntidades ON genEntidades.genEntidades =venPedidos.Cliente_Id 
	Inner join venClientes ON venClientes.genEntidades = genEntidades.genEntidades 
	INNER JOIN venClieHabitual ON venClieHabitual.genEntidades = venPedidos.Cliente_Id and 
		venClieHabitual.Sucursal = venPedidos.Sucursal
	INNER JOIN genProvincias ON venClieHabitual.Provincia_Id_Entr = genProvincias.genProvincias
	INNER JOIN stkDepositos ON venReparto.Deposito_Id = stkDepositos.stkDepositos
	INNER JOIN stkUniMed ON venPediCuerpo.Medida_Id = stkUniMed.stkUniMed
	INNER JOIN venPediSegmentos ON venPedidos.venPedidos = venPediSegmentos.venPedidos
	INNER JOIN genSegmentos genSeg ON venPediSegmentos.Segmento_Id = genSeg.genSegmentos
	Inner Join venVendedores On venVendedores.venVendedores = venClieHabitual.Vendedor_Id
	Left Join (venRepaPediSerieUbi Inner Join stkUbicaciones On venRepaPediSerieUbi.Ubicacion_Id = stkUbicaciones.stkUbicaciones) 
		On venRepaPediSerieUbi.venReparto = venRepaPediSerie.venReparto And venRepaPediSerieUbi.Renglon_Rep = venRepaPediSerie.Renglon_Rep And
			venRepaPediSerieUbi.venPedidos = venRepaPediSerie.venPedidos And venRepaPediSerieUbi.Renglon_Pe = venRepaPediSerie.Renglon_Pe And
			venRepaPediSerieUbi.Serie = venRepaPediSerie.Serie
	LEFT JOIN stkUbiAlmacenDefecto ON stkUbiAlmacenDefecto.Producto_Id = stkProductos.stkProductos and
		stkUbiAlmacenDefecto.Deposito_Id = stkDepositos.stkDepositos
	WHERE
		venRepaSegmentos.Empresa_Id = @Empresa_Id and
		genSegmentos.Segmento_Id =  @Segmento_Id and
		venRepaSegmentos.Segmento1C = @Segmento1C and 
		venRepaSegmentos.Segmento2C = @Segmento2C and 
		venRepaSegmentos.Segmento3C = @Segmento3C and 
		venRepaSegmentos.Segmento4C = @Segmento4C and 
		venRepaSegmentos.Segmento1N = @Segmento1N and 
		venRepaSegmentos.Segmento2N = @Segmento2N and  
		venRepaSegmentos.Segmento3N = @Segmento3N and  
		venRepaSegmentos.Segmento4N = @Segmento4N 
	ORDER BY venClientes.Cliente_Id, venClieHabitual.Sucursal, PedidoStr
GO