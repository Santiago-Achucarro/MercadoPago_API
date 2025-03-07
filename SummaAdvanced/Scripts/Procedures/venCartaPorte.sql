-- exec venCartaPorteDatos 1,'FC',1,0,0,0,'M','0202','',''


DROP procedure venCartaPorteDatos
GO

create procedure venCartaPorteDatos(
	@pEmpresa_Id int, 
	@pSegmento_Id VarChar(10), 
	@pSegmento1N int,
	@pSegmento2N int,
	@pSegmento3N int,
	@pSegmento4N int,
	@pSegmento1C VarChar(20),
	@pSegmento2C VarChar(20),
	@pSegmento3C VarChar(20),
	@pSegmento4C VarChar(20))
	as 


SELECT venCartaPorteFact.venMovimientosFactCP, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
venCompCartaPorteOrigen.FechaHoraSalida,  ' ' Archivo, ' ' NombreArchivo, ' ' Extension,
venCamiones.Patente_Id Camion_Id, Remolque1.Patente_Id Remolque1, Remolque2.Patente_Id Remolque2, venOperadores.Operador_Id ,conAsientos.Fecha

from venCartaPorteFact
inner join conAsientos ON venCartaPorteFact.venMovimientosFactCP = conAsientos.conAsientos
inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =conAsientos.conAsientos
INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	--INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Entr
	--INNER JOIN genPaises ON genPaises.genPaises = venClieHabitual.Pais_Id_Entr
	LEFT JOIN venCompCartaPorte ON venCompCartaPorte.venmovimientos = venCartaPorteFact.venMovimientosFactCP
	LEFT JOIN venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	LEFT JOIN venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
	LEFT JOIN venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
	LEFT JOIN venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
	LEFT JOIN venCompCartaPorteDestino ON  venCompCartaPorteDestino.venmovimientos = venCartaPorteFact.venMovimientosFactCP
	LEFT JOIN venCompCartaPorteOrigen ON  venCompCartaPorteOrigen.venmovimientos = venCartaPorteFact.venMovimientosFactCP

--from venMovimientos 
--inner join venCartaPorteFact on venCartaPorteFact.venMovimientosFactCP= venMovimientos.venMovimientos
--	inner join conAsientos ON venCartaPorteFact.venMovimientosFactCP = conAsientos.conAsientos
--	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =conAsientos.conAsientos
--		INNER JOIN venClieHabitual ON  venClieHabitual.genEntidades =venMovimientos.Cliente_Id and 
--								   venClieHabitual.Sucursal =  	venMovimientos.Sucursal
--	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
--	INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Entr
--	INNER JOIN genPaises ON genPaises.genPaises = venClieHabitual.Pais_Id_Entr
--	LEFT JOIN venCompCartaPorte ON venCompCartaPorte.venmovimientos = venmovimientos.venMovimientos
--	LEFT JOIN venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
--	LEFT JOIN venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
--	LEFT JOIN venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
--	LEFT JOIN venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
--	LEFT JOIN venCompCartaPorteDestino ON  venCompCartaPorteDestino.venmovimientos = venmovimientos.venmovimientos
--	LEFT JOIN venCompCartaPorteOrigen ON  venCompCartaPorteOrigen.venmovimientos = venmovimientos.venmovimientos

WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C


	--Facturas
	
SELECT venMovimientosFactCP.venMovimientos,venCartaPorteFact.Parada ,venCartaPorteFact.DistanciaRecorrida, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
conAsientos.Fecha, venClientes.Cliente_Id, venClientes.RazonSocial,
venClieHabitual.Direccion1_Entr as Calle, venClieHabitual.NroExterior_Entr NroExterior,
venClieHabitual.NroInterior_Entr NroInterior, venClieHabitual.CodPostal_Entr CodPostal, 
venClieHabitual.Direccion2_Entr as Colonia,  venClieHabitual.Localidad_Entr as Localidad,
genProvincias.Provincia_Id, genPaises.Pais_Id,
venClieHabitual.c_ColoniaEntr, venClieHabitual.c_LocalidadEntr, venClieHabitual.c_MunicipioEntr,
venCompCartaPorte.TotalDistRec,
venCompCartaPorteDestino.FechaHoraProgLlegada, 
dbo.FechaSinHora(dbo.FechaActual()) FechaCP

from venMovimientos 
	inner join venCartaPorteFact on venCartaPorteFact.venMovimientosFactCP= venMovimientos.venMovimientos
	inner join venMovimientos as venMovimientosFactCP on venMovimientosFactCP.venMovimientos=venCartaPorteFact.venMovimientosFact	
	inner join conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =conAsientos.conAsientos
	Inner Join venClientes ON  venClientes.genEntidades = venMovimientosFactCP.Cliente_Id
	INNER JOIN venClieHabitual ON  venClieHabitual.genEntidades =venMovimientosFactCP.Cliente_Id and 
								   venClieHabitual.Sucursal =  	venMovimientosFactCP.Sucursal
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	INNER JOIN genProvincias ON genProvincias.genProvincias = venClieHabitual.Provincia_Id_Entr
	INNER JOIN genPaises ON genPaises.genPaises = venClieHabitual.Pais_Id_Entr
	LEFT JOIN venCompCartaPorte ON venCompCartaPorte.venmovimientos = venMovimientosFactCP.venMovimientos
	LEFT JOIN venCamiones ON  venCamiones.venCamiones = venCompCartaPorte.Camion_Id
	LEFT JOIN venCamiones Remolque1 ON  Remolque1.venCamiones = venCompCartaPorte.Remolque1
	LEFT JOIN venCamiones Remolque2 ON  Remolque2.venCamiones = venCompCartaPorte.Remolque2
	LEFT JOIN venOperadores ON  venOperadores.venOperadores =venCompCartaPorte.Operador_Id
	LEFT JOIN venCompCartaPorteDestino ON  venCompCartaPorteDestino.venmovimientos = venMovimientosFactCP.venmovimientos
	LEFT JOIN venCompCartaPorteOrigen ON  venCompCartaPorteOrigen.venmovimientos = venMovimientosFactCP.venmovimientos




WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C


	-- cuerpo

SELECT venMovConStockCr.venMovimientos, venMovConStockCr.RenglonCuerpo, 
	stkProductos.Producto_Id, stkProductos.CodigoFiscal as BienesTransp, stkProductos.Descripcion, venMovConStockCr.CantFacturada as Cantidad ,
	venMovConStockCr.PrecioVenta as Precio, stkUniMed.Medida_Id, stkProductos.PesoEnKg, 
	stkProductos.MaterialPeligroso, stkProductos.CveMaterialPeligroso, stkProductos.Embalaje, 
		CAST(1 as bit) Marca
FROM venMovimientos 
inner join venCartaPorteFact on venCartaPorteFact.venMovimientosFactCP= venMovimientos.venMovimientos
	inner join venMovimientos as venMovimientosFactCP on venMovimientosFactCP.venMovimientos=venCartaPorteFact.venMovimientosFact	
	inner join conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =conAsientos.conAsientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Inner join venMovConStockCr ON  venMovConStockCr.venMovimientos = venMovimientosFactCP.venMovimientos
	iNNER JOIN stkProductos ON stkProductos.stkProductos =venMovConStockCr.Producto_Id
	inner join  stkUniMed on  stkUniMed.stkUniMed = stkProductos.Medida_Id
WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C
UNION ALL
SELECT venMovConStockCr.venMovimientos, venMovConStockCr.Renglon, ' ' as Producto_Id, 
	venMovConStockCr.BienesTransp, venMovConStockCr.Descripcion, venMovConStockCr.Cantidad ,
	venMovConStockCr.ValorMercancia as Precio, stkUniMed.Medida_Id, venMovConStockCr.PesoEnKg, 
	venMovConStockCr.MaterialPeligroso, venMovConStockCr.CveMaterialPeligroso, venMovConStockCr.Embalaje, 
		CAST(1 as bit) Marca
FROM venMovimientos 
inner join venCartaPorteFact on venCartaPorteFact.venMovimientosFactCP= venMovimientos.venMovimientos
	inner join venMovimientos as venMovimientosFactCP on venMovimientosFactCP.venMovimientos=venCartaPorteFact.venMovimientosFact	
	inner join conAsientos ON venMovimientosFactCP.venMovimientos = conAsientos.conAsientos
	inner join genAsiSegmentos ON  genAsiSegmentos.Asiento_id =conAsientos.conAsientos
	INNER JOIN genSegmentos ON  genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	Inner join venCompCartaPorteMercancia venMovConStockCr ON  venMovConStockCr.venMovimientos = venMovimientosFactCP.venMovimientos
	inner join  stkUniMed on  stkUniMed.stkUniMed = venMovConStockCr.Medida_Id
WHERE
	genAsiSegmentos.Empresa_Id = @pEmpresa_Id and 
	genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C

ORDER BY 1