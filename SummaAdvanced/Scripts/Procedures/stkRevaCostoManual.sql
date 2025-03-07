--stkRevaCostoManual 'STK','RV','0001',' ',' ',0,0,0,0, 'A','AZZZ', ' ',' ', 1, '0204'
DROP PROCEDURE stkRevaCostoManual
GO
CREATE PROCEDURE stkRevaCostoManual
(
	@Segmento_Id VarChar(10),
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Centro1_Id VarChar(8),
	@Centro2_Id VarChar(8),
	@Empresa_Id Int, 
	@pSucursal VarChar(4)

)
AS
DECLARE @pPorSucursal bit = (Select case when TipoCosto='S' THEN 1 ELSE 0 END from genEmpresas Where genEmpresas = @Empresa_Id )


Select stkMoviCabe.stkMoviCabe, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	conAsientos.Fecha, 
	@Centro1_Id as Centro1_Id, conCentro1.Descripcion as  DescripcionCentro1, 
	@Centro2_Id as Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	MIN(stkProductos.Producto_id) as ProductoDesde,
	MAX(stkProductos.Producto_id) as ProductoHasta, 
	CAST(0 as bit) as ParaTodasLasSuc
	FROM conAsientos 
	INNER JOIN stkMoviCabe ON conAsientos.conAsientos = stkMoviCabe.stkMoviCabe
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id =conAsientos.conAsientos
	INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	LEFT JOIN conCentro1 ON conCentro1.Centro1_Id = @Centro1_Id
	LEFT JOIN conCentro2 ON conCentro2.Centro2_Id = @Centro2_Id
	INNER JOIN stkMoviCuerpoReva ON stkMoviCuerpoReva.stkMoviCabe = stkMoviCabe.stkMoviCabe
	INNER JOIN stkProductos ON stkProductos.stkProductos =stkMoviCuerpoReva.Producto_Id
	WHERE
		genSegmentos.Segmento_Id = @Segmento_Id and 
		genAsiSegmentos.Segmento1C = @Segmento1C and
		genAsiSegmentos.Segmento2C = @Segmento2C and
		genAsiSegmentos.Segmento3C = @Segmento3C and
		genAsiSegmentos.Segmento4C = @Segmento4C and
		genAsiSegmentos.Segmento1N = @Segmento1N and
		genAsiSegmentos.Segmento2N = @Segmento2N and
		genAsiSegmentos.Segmento3N = @Segmento3N and
		genAsiSegmentos.Segmento4N = @Segmento4N and 
		genAsiSegmentos.Empresa_Id = @Empresa_Id
	GROUP BY stkMoviCabe.stkMoviCabe, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C, 
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, 
	conAsientos.Fecha, conCentro1.Descripcion, conCentro2.Descripcion 


	if @Segmento1N = 0
	begin
		
		IF @pPorSucursal=0

		

		begin 
		
		SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
			stkUniMed.Medida_Id, 
			CASE WHEN genEmpresas.TipoCosto = 'P' THEN 
				isnull(stkProductosCostos.CostoPromPond, stkProductos.CostoPromPond) else  
				isnull(stkProductosCostos.CostoUltCompra, stkProductos.CostoUltCompra) end as Costo,
				0.00 as CostoNuevo
		FROM stkProductos 
		INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa_Id
			inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
			LEFT JOIN stkProductosCostos ON stkProductosCostos.Producto_Id = stkProductos.stkProductos and 
					stkProductosCostos.Empresa_Id = @Empresa_Id

		where 
			stkProductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta and 
			ISNULL(stkProductos.Empresa_Id, @Empresa_id) = @Empresa_id and 
			stkProductos.Clase IN ('E','-') and 
			stkProductos.Inactivo = 0 AND 
			stkProductos.Posteado = 1 
			order by 1
	end
	ELSE
		BEGIN 

		SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
			stkUniMed.Medida_Id, 
			CASE WHEN genEmpresas.TipoCosto = 'P' THEN 
				isnull(stkProductosCostos.CostoPromPond, stkProductos.CostoPromPond) else  
				isnull(stkProductosCostos.CostoUltCompra, stkProductos.CostoUltCompra) end as Costo,
				0.00 as CostoNuevo
		FROM stkProductos 
		INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa_Id
			inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
			LEFT JOIN (stkProductosCostosSucursal stkProductosCostos 
			inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = stkProductosCostos.Sucursal and
				genSucursalesEmpr.Sucursal = @pSucursal ) ON stkProductosCostos.Producto_Id = stkProductos.stkProductos and 
					stkProductosCostos.Empresa_Id = @Empresa_Id
			

		where 
			stkProductos.Producto_Id BETWEEN @ProductoDesde And @ProductoHasta and 
			ISNULL(stkProductos.Empresa_Id, @Empresa_id) = @Empresa_id and 
			stkProductos.Clase IN ('E','-') and 
			stkProductos.Inactivo = 0 AND 
			stkProductos.Posteado = 1 
			order by 1
		END
	END
	else
	begin

		SELECT stkProductos.Producto_Id, stkProductos.Descripcion, 
			stkUniMed.Medida_Id, 
			CASE WHEN genEmpresas.TipoCosto IN( 'P','S') THEN 
				stkMoviCuerpoReva.PPP_Anterior else  stkMoviCuerpoReva.PUC_Anterior end as Costo,
				CASE WHEN genEmpresas.TipoCosto IN( 'P','S') THEN 
				stkMoviCuerpoReva.PPP_Actual else  stkMoviCuerpoReva.PUC_Actual end as CostoNuevo
		FROM stkProductos 
		INNER JOIN genEmpresas ON genEmpresas.genEmpresas = @Empresa_Id
			inner join stkUniMed ON stkUniMed.stkUniMed = stkProductos.Medida_Id
			INNER JOIN stkMoviCuerpoReva ON stkMoviCuerpoReva.Producto_Id = stkProductos.stkProductos
			INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = stkMoviCuerpoReva.stkMoviCabe
			INNER JOIN genSegmentos ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
		where 
			genSegmentos.Segmento_Id = @Segmento_Id and 
			genAsiSegmentos.Segmento1C = @Segmento1C and
			genAsiSegmentos.Segmento2C = @Segmento2C and
			genAsiSegmentos.Segmento3C = @Segmento3C and
			genAsiSegmentos.Segmento4C = @Segmento4C and
			genAsiSegmentos.Segmento1N = @Segmento1N and
			genAsiSegmentos.Segmento2N = @Segmento2N and
			genAsiSegmentos.Segmento3N = @Segmento3N and
			genAsiSegmentos.Segmento4N = @Segmento4N and
			genAsiSegmentos.Empresa_Id = @Empresa_Id			
		order by 1


	end

GO


	
	






