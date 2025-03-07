-- FM 13699. PH. Cambié conAsientos.Fecha por comMovProv.Fecha_CCP y que las aplicaciones solo tenga en cuenta las que son de distintos proveedores --
--INF_COMEDOCTA 'comex','comex', 0, '20230101','20230531', 1

DROP PROCEDURE INF_COMEDOCTA
GO
CREATE PROCEDURE INF_COMEDOCTA(
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Pendiente bit, 
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Empresa Int
)

AS
--declare @ProveedDesde VarChar(15)='comex',@ProveedHasta VarChar(15)='comex',@Pendiente bit=1, @FechaDesde DateTime='20230101', @FechaHasta DateTime='20230531',@Empresa Int=1
SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	comMovProv.Fecha_CCP Fecha, 
	comProveedores.RazonSocial,
		dbo.Segmento(genAsiSegmentos.Segmento_id, 
			genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
			genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
			genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
			genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) AS Segmento, 
			genAsiSegmentos.Segmento4C as Comprobante, 
			genSucursalesEmpr.Sucursal as Sucursal_Id, 
	CASE WHEN comMovTipos.Signo = 1 then genMovCuotas.Importe else 0 end as Debe,
	CASE WHEN comMovTipos.Signo != 1 then genMovCuotas.Importe else 0 end as Haber,
	genMovCuotas.Saldo  * comMovTipos.Signo as Saldo, 
	genMovCuotas.FechaVencimiento, conAsientos.Cambio,
	CASE WHEN comMovTipos.Signo = 1 then conAsientos.Cambio *genMovCuotas.Importe else 0 end as DebeBase,
	CASE WHEN comMovTipos.Signo != 1 then conAsientos.Cambio *genMovCuotas.Importe else 0 end as HaberBae,
	conAsientos.Cambio * genMovCuotas.Saldo  * comMovTipos.Signo as SaldoBase,
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion Provincia_id, genPaises.Descripcion Pais_Id, 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail, comMovProv.comMovprov , 
	genUsuarios.Usuario_Id

FROM comMovProv 
inner join comProveedores ON comMovProv.Proveed_id = comProveedores.genEntidades
INNER JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON genPaises.genPaises = comProveedores.Pais
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = comMovprov.comMovprov
inner join genSucursalesEmpr on conAsientos.Sucursal=genSucursalesEmpr.genSucursalesEmpr
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = conAsientos.Usuario_Id
	WHERE
		comMovProv.FacturaTesoreria = 0 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		((@Pendiente = 1 AND genMovCuotas.Saldo <> 0) OR 
		(@Pendiente = 0 AND comMovProv.Fecha_CCP Between @FechaDesde and @FechaHasta)) and 
		conAsientos.Empresa_Id = @Empresa


UNION ALL
-- IMPORTACIONES 
SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	genCancMov.FechaAplicacion Fecha, 
	comProveedores.RazonSocial, 
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
			genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
			genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
			genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
			genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N)	 AS Segmento, 
			genAsiSegmentos.Segmento4C as Comprobante, genSucursalesEmpr.Sucursal as Sucursal_Id, 
	0 as Debe,
	(genCancMov.Importe)  as Haber,
	0 as Saldo,
	genCancMov.FechaAplicacion ,  
	 1 as Cambio,
	 0 as DebeBase,
	 genCancMov.Importe_ap  as HaberBase,
	0  as SaldoBase , 
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion Provincia_id, genPaises.Descripcion Pais_Id, 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail, genAsiSegmentos.Asiento_Id comMovprov ,
	genUsuarios.Usuario_Id
FROM genCancMov 
INNER JOIN comMovProv ON genCancMov.Asiento_Id = comMovprov.comMovProv 
Inner Join comMovProv comMovProvAp On comMovProvAp.comMovProv = genCancMov.Asiento_Id_Ap
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = genCancMov.Asiento_Id_Ap
INNER JOIN comProveedores ON comMovProv.Proveed_id = comProveedores.genEntidades
INNER JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON genPaises.genPaises = comProveedores.Pais
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genSucursalesEmpr on conAsientos.Sucursal=genSucursalesEmpr.genSucursalesEmpr
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = genCancMov.Usuario_Id
	WHERE
		comMovProv.FacturaTesoreria = 0 and 
		genCancMov.Importacion = 1 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		@Pendiente = 0 and genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta and 
		conAsientos.Empresa_Id = @Empresa
		And comMovProv.Proveed_Id <> comMovProvAp.Proveed_Id
	
UNION ALL
--- importaciones

SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	genCancMov.FechaAplicacion Fecha, 
	comProveedores.RazonSocial, 
	dbo.Segmento(genAsiSegmentos.Segmento_id, 
			genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
			genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
			genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
			genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N)	 AS Segmento, 
			genAsiSegmentos.Segmento4C as Comprobante, genSucursalesEmpr.Sucursal as Sucursal_Id, 
	(genCancMov.Importe_ap) as Debe,
	0  as Haber,
	0 as Saldo, 
	@FechaDesde,  
	1 as Cambio,
	genCancMov.Importe  as DebeBase,
	 0 as HaberBase,
	0 as SaldoBase , 
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion Provincia_id, genPaises.Descripcion Pais_Id, 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail, genAsiSegmentos.Asiento_Id comMovprov ,
	genUsuarios.Usuario_Id
FROM genCancMov 
INNER JOIN comMovProv ON genCancMov.Asiento_Id_Ap = comMovprov.comMovProv 
Inner Join comMovProv comMovProvId On comMovProvId.comMovProv = genCancMov.Asiento_Id
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = genCancMov.Asiento_Id
INNER JOIN comProveedores ON comMovProv.Proveed_id = comProveedores.genEntidades
INNER JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON genPaises.genPaises = comProveedores.Pais
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genSucursalesEmpr on conAsientos.Sucursal=genSucursalesEmpr.genSucursalesEmpr
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = genCancMov.Usuario_Id
	WHERE
		comMovProv.FacturaTesoreria = 0 and 
		genCancMov.Importacion = 1 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		@Pendiente = 0 and genCancMov.FechaAplicacion between @FechaDesde and @FechaHasta and 
		conAsientos.Empresa_Id = @Empresa
		And comMovProv.Proveed_Id <> comMovProvId.Proveed_Id


union all

SELECT Proveed_id, Moneda_id, Fecha, RazonSocial, Segmento, Comprobante, Sucursal_Id, 
	case when Sum(Saldo) >0 then Sum(Saldo) else 0 end as Debe, 
	case when Sum(Saldo) <0 then -Sum(Saldo) else 0 end as Haber, 
	Sum(Saldo) as Saldo,
	FechaVencimiento, avg(Cambio) as Cambio,
	case when SUM(SaldoBase) >0 then SUM(SaldoBase) else 0 end as DebeBase, 
	case when SUM(SaldoBase) <0 then -SUM(SaldoBase) else 0 end  as HaberBase, 
	SUM(SaldoBase) as SaldoBase, 
	Direccion1, Direccion2, Localidad, CodigoPostal, 
	Provincia_Id, Pais_Id, Telefono, Contacto, 
	Email, comMovprov, ''
FROM
(
-- SI PIDIO HISTORICO TRAGO EL SALDO INICIAL
SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	Dateadd(dd,-1,@FechaDesde) Fecha, 
	comProveedores.RazonSocial, 
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion Provincia_id, genPaises.Descripcion Pais_Id, 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail, 0 comMovprov , 
		'SI' AS Segmento, ' ' as Comprobante, ' ' as Sucursal_Id, 
	CASE WHEN sum(genMovCuotas.Importe*comMovTipos.Signo)>0 then 
		sum(genMovCuotas.Importe*comMovTipos.Signo)  else 0 end as Debe,
	CASE WHEN sum(genMovCuotas.Importe*comMovTipos.Signo)<0  then -sum(genMovCuotas.Importe*comMovTipos.Signo)  else 0 end as Haber,
	SUM(genMovCuotas.Saldo  * comMovTipos.Signo) as Saldo, 
	@FechaDesde as FechaVencimiento,  SUM(genMovCuotas.Saldo  * comMovTipos.Signo*conAsientos.Cambio) /SUM(genMovCuotas.Saldo  * comMovTipos.Signo) as Cambio,
	CASE WHEN sum(genMovCuotas.Importe*comMovTipos.Signo*conAsientos.Cambio)>0 then 
		sum(genMovCuotas.Importe*comMovTipos.Signo*conAsientos.Cambio)  else 0 end as DebeBase,
	CASE WHEN sum(genMovCuotas.Importe*comMovTipos.Signo*conAsientos.Cambio)<0  then -sum(genMovCuotas.Importe*comMovTipos.Signo*conAsientos.Cambio)  else 0 end as HaberBase,
	SUM(genMovCuotas.Saldo  * comMovTipos.Signo*conAsientos.Cambio) as SaldoBase 
FROM comMovProv 
inner join comProveedores ON comMovProv.Proveed_id = comProveedores.genEntidades
INNER JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON genPaises.genPaises = comProveedores.Pais
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = comMovprov.comMovprov
inner join genSucursalesEmpr on conAsientos.Sucursal=genSucursalesEmpr.genSucursalesEmpr
	WHERE
		comMovProv.FacturaTesoreria = 0 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		@Pendiente = 0 and commovprov.Fecha_CCP < @FechaDesde and 
		conAsientos.Empresa_Id = @Empresa
	GROUP BY comProveedores.Proveed_id, genMonedas.Moneda_Id,	
	comProveedores.RazonSocial, 
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion , genPaises.Descripcion , 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail /*,genSucursalesEmpr.Sucursal*/
	having SUM(genMovCuotas.Saldo  * comMovTipos.Signo) <> 0

union all
--- importaciones
SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	Dateadd(dd,-1,@FechaDesde) Fecha, 
	comProveedores.RazonSocial, 
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion Provincia_id, genPaises.Descripcion Pais_Id, 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail, 0 comMovprov , 
		'SI' AS Segmento, ' '  as Comprobante, ' ' as Sucursal_Id, 
	0 as Debe,
	(genCancMov.Importe_ap)  as Haber,
	(-genCancMov.Importe_ap) as Saldo,
	@FechaDesde,  
	 1 as Cambio,
	 0 as DebeBase,
	 genCancMov.Importe  as HaberBase,
	-genCancMov.Importe  as SaldoBase 
FROM genCancMov 
INNER JOIN comMovProv ON genCancMov.Asiento_Id = comMovprov.comMovProv 
Inner Join comMovProv comMovProvId On comMovProvId.comMovProv = genCancMov.Asiento_Id
INNER JOIN comProveedores ON comMovProv.Proveed_id = comProveedores.genEntidades
INNER JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON genPaises.genPaises = comProveedores.Pais
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genSucursalesEmpr on conAsientos.Sucursal=genSucursalesEmpr.genSucursalesEmpr
	WHERE
		comMovProv.FacturaTesoreria = 0 and 
		genCancMov.Importacion = 1 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		@Pendiente = 0 and genCancMov.FechaAplicacion < @FechaDesde and 
		conAsientos.Empresa_Id = @Empresa
		And comMovProv.Proveed_Id <> comMovProvId.Proveed_Id
	
UNION ALL
--- importaciones

SELECT comProveedores.Proveed_id, genMonedas.Moneda_Id,	Dateadd(dd,-1,@FechaDesde) Fecha, 
	comProveedores.RazonSocial, 
	comProveedores.Direccion1,comProveedores.Direccion2,
	comProveedores.Localidad, comProveedores.CodigoPostal,
	genProvincias.Descripcion Provincia_id, genPaises.Descripcion Pais_Id, 
	comProveedores.Telefono, comProveedores.Contacto, 
	comProveedores.EMail, 0 comMovprov , 
		'SI' AS Segmento, ' ' as Comprobante, ' ' as Sucursal_Id, 
	(genCancMov.Importe) as Debe,
	0  as Haber,
	(genCancMov.Importe) as Saldo, 
	@FechaDesde,  
	1 as Cambio,
	genCancMov.Importe  as DebeBase,
	 0 as HaberBase,
	genCancMov.Importe  as SaldoBase 
FROM genCancMov 
INNER JOIN comMovProv ON genCancMov.Asiento_Id_Ap = comMovprov.comMovProv 
Inner Join comMovProv comMovProvAp On comMovProvAp.comMovProv = genCancMov.Asiento_Id_Ap
INNER JOIN comProveedores ON comMovProv.Proveed_id = comProveedores.genEntidades
INNER JOIN genProvincias ON genProvincias.genProvincias = comProveedores.Provincia_Id
INNER JOIN genPaises ON genPaises.genPaises = comProveedores.Pais
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genSucursalesEmpr on conAsientos.Sucursal=genSucursalesEmpr.genSucursalesEmpr
	WHERE
		genCancMov.Importacion = 1 and 
		comMovProv.FacturaTesoreria = 0 and 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and
		comProveedores.Proveed_Id between @ProveedDesde and @ProveedHasta and 
		@Pendiente = 0 and genCancMov.FechaAplicacion < @FechaDesde and 
		conAsientos.Empresa_Id = @Empresa
		And comMovProv.Proveed_Id <> comMovProvAp.Proveed_Id

	) AS XXX
GROUP BY Proveed_id, Moneda_id, Fecha, RazonSocial, 
	Direccion1, Direccion2, Localidad, CodigoPostal, 
	Provincia_Id, Pais_Id, Telefono, Contacto, 
	Email, comMovprov, Segmento, Comprobante, Sucursal_Id, 
	FechaVencimiento
having SUM(Saldo) <> 0
ORDER BY 1,2,3, 5
