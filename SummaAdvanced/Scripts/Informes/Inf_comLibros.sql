/* AJ NOV 18 AGREGUE SOLO COMPRAS */

-- Inf_comLibros 'IVACP', '20220801','20220801', 1, 1, 0,1
drop PROCEDURE Inf_comLibros
go
CREATE PROCEDURE Inf_comLibros (
@Libro_Id VarChar(5), 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@Empresa_Id Int, 
@SoloCompras bit, 
@SoloPendientes bit,
@AgrupaCF bit
)
as

if @SoloPendientes = 0
Begin

SELECT XXX.Fecha, xxx.FechaContable, XXX.SegmentoStr, XXX.TipoMov, XXX.ClaveFiscal, XXX.Cuit, xxx.comMovProv, xxx.Origen_Id, xxx.Descripcion,
XXX.RazonSocial, -SUM(XXX.Columna01*xxx.Signo) as Columna01,
	-SUM(XXX.Columna02*xxx.Signo) as Columna02, -SUM(XXX.Columna03*xxx.Signo) as Columna03,
		-SUM(XXX.Columna04*xxx.Signo) as Columna04, -SUM(XXX.Columna05*xxx.Signo) as Columna05, 
		-SUM(XXX.Columna06*xxx.Signo) as Columna06, -SUM(XXX.Columna07*xxx.Signo) as Columna07, 
		-SUM(XXX.Columna08*xxx.Signo) as Columna08, -SUM(XXX.Columna09*xxx.Signo) as Columna09, 
		-SUM(XXX.Columna10*xxx.Signo) as Columna10, -SUM(XXX.Columna11*xxx.Signo) as Columna11, 
		-SUM(XXX.Columna12*xxx.Signo) as Columna12, XXX.CondFiscal_Id, XXX.DescripcionCondFiscal

FROM (

SELECT comMovProv.comMovProv, comMovProv.Fecha_ccp Fecha, conAsientos.Fecha AS FechaContable, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as SegmentoStr,
	comMovTipos.TipoMov, conAsientos.Cambio, comMovTipos.Signo, comOrigenesFiscales.Origen_Id, comOrigenesFiscales.Descripcion,
	ISNULL(comMovprov.ClaveFiscal, ' ') as ClaveFiscal, 
	genEntidades.Cuit, comProveedores.RazonSocial , 
	CASE WHEN comLibrosImpuestos.Columna = 1 THEN
	CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna01,
		CASE WHEN comLibrosImpuestos.Columna = 2 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna02,
		
		CASE WHEN comLibrosImpuestos.Columna = 3 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna03,
		
		CASE WHEN comLibrosImpuestos.Columna = 4 THEN
		CASE  comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna04,
		
		CASE WHEN comLibrosImpuestos.Columna = 5 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna05, 

		CASE WHEN comLibrosImpuestos.Columna = 6 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				ELSE 0 END ELSE 0 END AS Columna06,

		CASE WHEN comLibrosImpuestos.Columna = 7 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				ELSE 0 END ELSE 0 END AS Columna07, 

		CASE WHEN comLibrosImpuestos.Columna = 8 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				ELSE 0 END ELSE 0 END AS Columna08,

		CASE WHEN comLibrosImpuestos.Columna = 9 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				ELSE 0 END ELSE 0 END AS Columna09, 

		CASE WHEN comLibrosImpuestos.Columna = 10 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				ELSE 0 END ELSE 0 END AS Columna10, 

		CASE WHEN comLibrosImpuestos.Columna = 11 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna11,

		CASE WHEN comLibrosImpuestos.Columna = 12 THEN
		CASE comLibrosImpuestos.TipoRenglon WHEN 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		ELSE 0 END ELSE 0 END AS Columna12, comCondFiscal.CondFiscal_Id, comCondFiscal.Descripcion DescripcionCondFiscal

FROM comMovProv 
	INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
	INNER JOIN genEntidades ON genEntidades.genEntidades = comMovProv.Proveed_Id
	INNER JOIN comProveedores ON comProveedores.genEntidades = genEntidades.genEntidades
	INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovProv.TipoMov
	Left Join comOrigenesFiscales On comOrigenesFiscales.comOrigenesFiscales = comMovProv.Origen_Id
	CROSS JOIN (comLibrosImpuestos Inner Join comLibros on comLibros.comLibros = comLibrosImpuestos.comLibros)
	INNER JOIN comCondFiscal ON comCondFiscal.comCondFiscal = comMovProv.condFiscal_Id
WHERE 

(@SoloCompras = 0 or 
	Exists(select 1 from conMovCont INNER JOIN conCuentas ON 	
		conMovCont.conAsientos = conAsientos.conAsientos and 
		conMovCont.Cuenta_Id = conCuentas.conCuentas 
		INNER JOIN conTipoEspecialesCuerpo on 
		conTipoEspecialesCuerpo.Tipo_id =  conCuentas.Tipo_id 
		Where
			conTipoEspecialesCuerpo.TipoEspe_Id = 'INVEN') OR
	Exists(select 1 from comMovPOC INNER JOIN comOCArticulo ON 
		comMovPOC.comMovprov = conasientos.conAsientos and 
		comMovPOC.comOrdenComp = comOCArticulo.comOrdenComp and 
		comMovPOC.Renglon_OC = comOCArticulo.Renglon_OC
		INNER JOIN stkProductos ON 
		stkProductos.Clase IN ('E', '-')) OR 
	Exists(select 1 from comMovPOC INNER JOIN comOCMemo ON 
		comMovPOC.comMovprov = conasientos.conAsientos and 
		comMovPOC.comOrdenComp = comOCMemo.comOrdenComp and 
		comMovPOC.Renglon_OC = comOCMemo.Renglon_OC 
		inner join conCuentas ON 
		conCuentas.conCuentas = comOCMemo.Cuenta_Id 
		INNER JOIN conTipoEspecialesCuerpo on 
		conTipoEspecialesCuerpo.Tipo_id =  conCuentas.Tipo_id ) )
		 and 
conAsientos.Anulado = 0 and 
conAsientos.Posteado = 1 and 
isnull(comLibros.Empresa_Id,@Empresa_Id) = @Empresa_Id And comLibros.Libro_Id = @Libro_Id And
conAsientos.Empresa_Id = @Empresa_Id and
conAsientos.Fecha between @FechaDesde and @FechaHasta and  
comMovTipos.TipoMov in ('F','R','D', 'I', 'B', 'E')) AS XXX
group by XXX.Fecha, XXX.SegmentoStr, XXX.ClaveFiscal, XXX.Cuit, 
XXX.RazonSocial, xxx.comMovProv, XXX.TipoMov, xxx.comMovProv, xxx.Origen_Id, xxx.Descripcion, 
XXX.FechaContable, XXX.CondFiscal_Id, XXX.DescripcionCondFiscal
ORDER BY 1,2
end

else
begin

SELECT XXX.Fecha, XXX.FechaContable, XXX.SegmentoStr, XXX.TipoMov, XXX.ClaveFiscal, XXX.Cuit, xxx.comMovProv, xxx.Origen_Id, xxx.Descripcion,
XXX.RazonSocial, -SUM(XXX.Columna01*xxx.Signo) as Columna01,
	-SUM(XXX.Columna02*xxx.Signo) as Columna02, -SUM(XXX.Columna03*xxx.Signo) as Columna03,
		-SUM(XXX.Columna04*xxx.Signo) as Columna04, -SUM(XXX.Columna05*xxx.Signo) as Columna05, 
		-SUM(XXX.Columna06*xxx.Signo) as Columna06, -SUM(XXX.Columna07*xxx.Signo) as Columna07, 
		-SUM(XXX.Columna08*xxx.Signo) as Columna08, -SUM(XXX.Columna09*xxx.Signo) as Columna09, 
		-SUM(XXX.Columna10*xxx.Signo) as Columna10, -SUM(XXX.Columna11*xxx.Signo) as Columna11, 
		-SUM(XXX.Columna12*xxx.Signo) as Columna12, XXX.CondFiscal_Id, XXX.DescripcionCondFiscal

FROM (

SELECT comMovProv.comMovProv, comMovProv.Fecha_ccp Fecha, conAsientos.Fecha AS FechaContable, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as SegmentoStr,
	comMovTipos.TipoMov, conAsientos.Cambio, comMovTipos.Signo, comOrigenesFiscales.Origen_Id, comOrigenesFiscales.Descripcion,
	ISNULL(comMovprov.ClaveFiscal, ' ') as ClaveFiscal, 
	genEntidades.Cuit, comProveedores.RazonSocial , 
	Convert(Numeric(18,2),
	CASE WHEN comLibrosImpuestos.Columna = 1 THEN
	CASE comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 		
		ELSE 0 END ELSE 0 END * comMovprov.Saldo / commovprov.Saldo) AS Columna01,

		Convert(Numeric(18,2),
		Case when comLibrosImpuestos.Columna = 2 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna02,

		Convert(Numeric(18,2),
		Case when comLibrosImpuestos.Columna = 3 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 		
		else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna03,

		Convert(Numeric(18,2),
		Case when comLibrosImpuestos.Columna = 4 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 		
		else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna04,

		Convert(Numeric(18,2),
		Case when comLibrosImpuestos.Columna = 5 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna05,
		
		Convert(Numeric(18,2),
			Case when comLibrosImpuestos.Columna = 6 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna06,

		Convert(Numeric(18,2),
			Case when comLibrosImpuestos.Columna = 7 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna07,
				
		Convert(Numeric(18,2),
			Case when comLibrosImpuestos.Columna = 8 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna08,

	Convert(Numeric(18,2),	
			Case when comLibrosImpuestos.Columna = 9 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna09, 

	Convert(Numeric(18,2),
			Case when comLibrosImpuestos.Columna = 10 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
				else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna10, 

	Convert(Numeric(18,2),
			Case when comLibrosImpuestos.Columna = 11 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna11,

		Convert(Numeric(18,2),
			Case when comLibrosImpuestos.Columna = 12 then
		case  comLibrosImpuestos.TipoRenglon when 'TO' THEN 	
		ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovimpuestos 
				INNER JOIN conMovCont ON comMovimpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos 
				INNER JOIN conAsientos ON comMovimpuestos.comMovProv = conAsientos.conAsientos  
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv and 
				comMovimpuestos.Impuesto_Id = comLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
		WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0)-
			ISNULL((SELECT SUM(ROUND(Base_Imponible*conAsientos.Cambio,2)) FROM comMovimpuestos
				INNER JOIN comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
				INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
				INNER JOIN impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
				WHERE impTipoImpuesto.Referencia01 = 'IVA' And
				comMovimpuestos.comMovProv = comMovProv.comMovProv),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM comMovImpuestos 
				INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND
					comMovImpuestos.conRenglon = conMovCont.Renglon
				WHERE comMovimpuestos.comMovProv = comMovProv.comMovProv ),0) 
		else 0 END else 0 end * comMovprov.Saldo / commovprov.Saldo) AS Columna12,
		comCondFiscal.CondFiscal_Id, comCondFiscal.Descripcion DescripcionCondFiscal

FROM (SELECT comMovProv, comMovProv.Proveed_Id , comMovProv.TipoMov, comMovProv.Origen_Id, 
   	  comMovProv.ClaveFiscal, comMovprov.Fecha_CCP, comMovprov.CondFiscal_Id,  comMovProv.Importe, comMovProv.Saldo +
		isnull((Select sum(genCancMov.Importe) from genCancMov, conAsientos 
			Where		
				conAsientos.conAsientos = genCancMov.Asiento_Id_Ap and 
				genCancMov.Asiento_Id = comMovprov.comMovprov and 
				conAsientos.Anulado = 0 and 
				genCancMov.FechaAplicacion > @FechaHasta ),0)+
				isnull((Select sum(genCancMov.Importe) from genCancMov, conAsientos 
			Where		
				conAsientos.conAsientos = genCancMov.Asiento_Id and 
				genCancMov.Asiento_Id_Ap = comMovprov.comMovprov and 
				conAsientos.Anulado = 0 and 
				genCancMov.FechaAplicacion > @FechaHasta ),0) as Saldo
	FROM comMovProv where comMovProv.FacturaTesoreria=0) AS comMovProv 
	INNER JOIN conAsientos ON comMovProv.comMovProv = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
	INNER JOIN genEntidades ON genEntidades.genEntidades = comMovProv.Proveed_Id
	INNER JOIN comProveedores ON comProveedores.genEntidades = genEntidades.genEntidades
	INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovProv.TipoMov
	Left Join comOrigenesFiscales On comOrigenesFiscales.comOrigenesFiscales = comMovProv.Origen_Id
	CROSS JOIN (comLibrosImpuestos Inner Join comLibros on comLibros.comLibros = comLibrosImpuestos.comLibros)
	INNER JOIN comCondFiscal ON comCondFiscal.comCondFiscal = comMovProv.CondFiscal_Id
WHERE 

comMovprov.Saldo > 0 and 
conAsientos.Fecha <= @FechaHasta and 
conAsientos.Anulado = 0 and 
conAsientos.Posteado = 1 and 
isnull(comLibros.Empresa_Id,@Empresa_Id) = @Empresa_Id And comLibros.Libro_Id = @Libro_Id And
conAsientos.Empresa_Id = @Empresa_Id and
comMovTipos.TipoMov in ('F','R','D', 'I', 'B', 'E')) AS XXX
group by XXX.Fecha, XXX.SegmentoStr, XXX.ClaveFiscal, XXX.Cuit, 
XXX.RazonSocial, xxx.comMovProv, XXX.TipoMov, xxx.comMovProv, xxx.Origen_Id, xxx.Descripcion, 
XXX.FechaContable, XXX.CondFiscal_Id, XXX.DescripcionCondFiscal
ORDER BY 1,2

end

GO


