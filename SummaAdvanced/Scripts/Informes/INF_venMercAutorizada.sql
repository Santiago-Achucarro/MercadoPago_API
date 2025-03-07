-- INF_venMercAutorizada @Segmento_Id ='REPARTO', @Segmento1N=1,@Segmento2N=0,	@Segmento3N= 0,@Segmento4N= 0,@Segmento1C= '0001',@Segmento2C= '  ',@Segmento3C=' ',	@Segmento4C= ' ',@Empresa =1

drop PROCEDURE INF_venMercAutorizada
GO

CREATE PROCEDURE INF_venMercAutorizada
(@Segmento_Id VarChar(10),
 @Segmento1N INT,
 @Segmento2N INT,
 @Segmento3N INT,
 @Segmento4N INT,
 @Segmento1C VarChar(20),
 @Segmento2C VarChar(20),
 @Segmento3C VarChar(20),
 @Segmento4C VarChar(20),
 @Empresa int
 )

AS

SELECT  dbo.Segmento(venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C
	, venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N
	, venRepaSegmentos.Segmento2N, venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N) as Segmento,
	stkProductos.Producto_id, stkProductos.Descripcion, 
	SUM(venRepaPedi.CantidadForm) AS CantidadForm, stkUniMed.Medida_Id,
	SUM(venRepaPedi.CantidadAlternaForm) AS CantidadAlternaForm, 
	ISNULL(stkUniMedMA.Medida_Id,' ') as MedidaAlterna, 
	stkProductos.ClaseAlterna
	FROM venRepaSegmentos inner join venReparto ON
	venRepaSegmentos.venReparto = venReparto.venReparto
	INNER JOIN venRepaPedi ON
	venRepaPedi.venReparto =venReparto.venReparto
	INNER JOIN venPediCuerpo ON
	venPediCuerpo.venPedidos =venRepaPedi.venPedidos AND 
	venPediCuerpo.Renglon_Pe =venRepaPedi.Renglon_Pe
	INNER JOIN stkProductos ON
	stkProductos.stkProductos = venPediCuerpo.Producto_Id
	INNER JOIN genSegmentos ON
	genSegmentos.genSegmentos = venRepaSegmentos.Segmento_Id
	INNER JOIN stkUniMed ON
	stkUniMed.stkUniMed = stkProductos.Medida_Id
	LEFT OUTER JOIN stkUniMed  as stkUniMedMA ON 
	stkUniMedMA.stkUniMed = stkProductos.MedidaAlterna
	WHERE
	genSegmentos.Segmento_Id = @Segmento_Id and 
	venRepaSegmentos.Segmento1C = @Segmento1C and  
	venRepaSegmentos.Segmento2C = @Segmento2C and 
	venRepaSegmentos.Segmento3C = @Segmento3C and  
	venRepaSegmentos.Segmento4C = @Segmento4C and 
	venRepaSegmentos.Segmento1N = @Segmento1N and 
	venRepaSegmentos.Segmento2N = @Segmento2N and 
	venRepaSegmentos.Segmento3N = @Segmento3N and  
	venRepaSegmentos.Segmento4N = @Segmento4N and 
	venRepaSegmentos.Empresa_Id = @Empresa 
GROUP BY venRepaSegmentos.Segmento_Id, venRepaSegmentos.Segmento1C, venRepaSegmentos.Segmento2C
	, venRepaSegmentos.Segmento3C, venRepaSegmentos.Segmento4C, venRepaSegmentos.Segmento1N
	, venRepaSegmentos.Segmento2N, venRepaSegmentos.Segmento3N, venRepaSegmentos.Segmento4N,
	stkProductos.Producto_id, stkProductos.Descripcion, stkUniMed.Medida_Id, stkUniMedMA.Medida_Id,
	stkProductos.ClaseAlterna
order by 2

