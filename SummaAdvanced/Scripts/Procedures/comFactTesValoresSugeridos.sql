DROP PROCEDURE comFactTesValoresSugeridos
GO


CREATE PROCEDURE comFactTesValoresSugeridos(@Proveed_id VarChar(15), @Fecha DateTime)
AS

	SELECT @Proveed_id as Proveed_id, @Fecha as Fecha


	IF EXISTS(SELECT 1 FROM comProveedores WHERE Proveed_id = @Proveed_id)
		BEGIN 

			SELECT  comProvCtasContrap.Detalle, 
				conCuentas.Cuenta_Id, conCuentas.Descripcion, 
				conCentro1.Centro1_Id, conCentro2.Centro2_Id
				FROM 
				comProvCtasContrap inner join conCuentas ON
				comProvCtasContrap.Cuenta_Id = conCuentas.conCuentas
				inner join comProveedores ON
				comProveedores.genEntidades = comProvCtasContrap.Proveed_Id
				LEFT JOIN conCentro1 ON conCentro1.conCentro1 = comProvCtasContrap.Centro1_Id
				LEFT JOIN conCentro2 ON conCentro2.conCentro2 = comProvCtasContrap.Centro2_Id
				
				Where
					comProveedores.Proveed_Id = @Proveed_id

			SELECT comImpuestos.Impuesto_Id, comImpuestos.Descripcion, 
					comImpuestos.Porcentaje, 1 as Cantidad, comImpuestos.Formulacalc
			From 
				comProveedoresImpuestos INNER JOIN comImpuestos ON
				comProveedoresImpuestos.Impuesto_Id = comImpuestos.comImpuestos
				INNER JOIN comProveedores ON 
				comProveedores.genEntidades = comProveedoresImpuestos.Proveed_Id
				Where
					comProveedores.Proveed_Id = @Proveed_id AND 
					@Fecha between comImpuestos.Fecha_Desde and ISNULL(comImpuestos.Fecha_Hasta, @Fecha) 


		END
	ELSE
		BEGIN 

		
		SELECT D1.DETALLE , D2.Cuenta_Id, conCuentas.Descripcion, D3.Centro1_Id, 
			D4.Centro2_Id
			FROM 
			( SELECT TOP 1 COUNT(1) Cant, DETALLE FROM comParaSugerido WHERE
					Cuit = @Proveed_id  group by DETALLE  order by 1 Desc) as D1	
			Cross join  					 
			(SELECT TOP 1 COUNT(1) as Cant, Cuenta_Id FROM comParaSugerido WHERE
					Cuit = @Proveed_id group by Cuenta_Id order by 1 Desc) as D2
					 INNER JOIN conCuentas ON conCuentas.Cuenta_Id = d2.Cuenta_Id
			Cross join 
			(SELECT TOP 1 COUNT(1) as Cant, Centro1_id FROM comParaSugerido WHERE 
			Cuit = @Proveed_id  group by Centro1_id  order by 1 Desc) as D3
			 Cross Join 
			(SELECT TOP 1 COUNT(1) as Cant, Centro2_id  FROM comParaSugerido WHERE
					Cuit = @Proveed_id group by Centro2_id  order by 1 Desc) as D4
		


		SELECT TOP 1 comImpuestos.Impuesto_Id, comImpuestos.Descripcion, 
					comImpuestos.Porcentaje, count(*) as Cantidad, 
					comImpuestos.Formulacalc
			From 
				comMovImpuestos INNER JOIN comImpuestos ON
				comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos
				INNER JOIN comMovprov ON
				comMovprov.comMovProv = comMovImpuestos.comMovProv
				INNER JOIN genEntidades ON 
				genEntidades.genEntidades = comMovprov.Proveed_Id
				Where
					genEntidades.Cuit = @Proveed_id AND 
					@Fecha between comImpuestos.Fecha_Desde and ISNULL(comImpuestos.Fecha_Hasta, @Fecha) 
		GROUP BY comImpuestos.Impuesto_Id, comImpuestos.Descripcion,  comImpuestos.Porcentaje, comImpuestos.Formulacalc
		ORDER BY 4 Desc
				

		END


GO