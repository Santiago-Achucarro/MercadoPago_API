Drop Procedure impCiti
Go
Create Procedure impCiti
(
@pEmpresa_Id int,
@pFechaDesde Datetime,
@pFechaHasta Datetime
)
As

Select @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, ' ' Destino, 0 ImportacionDefBienes

-- Ventas --
Select conAsientos.conAsientos, conAsientos.Fecha, genAsiSegmentos.Segmento2C venSucursal, genAsiSegmentos.Segmento1C venTipoMov_Id,
genAsiSegmentos.Segmento1N venComprobante, IsNull(venMovimientos.ComprobanteDesde, genAsiSegmentos.Segmento1N) ComprobanteDesde,
genAsiSegmentos.Segmento3C venLetra, venClientes.RazonSocial, genEntidades.TipoDoc, genPaises.Pais_Id Pais_Id_Fact,
venMovimientosFiscal.Comprobante_Id, venCondFiscal.CodigoFiscal,  

IsNull((Select Max(genMovCuotas.FechaVencimiento) FV From genMovCuotas
Where genMovCuotas.Asiento_Id = venMovimientos.venMovimientos), 0) FechaVencimiento, 

genMonedas.Moneda_Id, conAsientos.Cambio, genEntidades.Cuit, conMovCont.Importe,
IsNull((Select Sum(venMovImpuestos.BaseImponibleMonedaNac) BI From venMovImpuestos
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.CodigoFiscal = '1' And 
impTipoImpuesto.Referencia02 = 'IVA'), 0) NoGravado,

conMovCont.Importe -
/*
IsNull((Select Sum(BaseImponibleMonedaNac) BI From venMovImpuestos 
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos 
and impTipoImpuesto.Referencia01 = 'IVA'
and venMovImpuestos.venMovimientos = venMovimientos.venMovimientos), 0) -
*/
(IsNull((Select Sum(conMovCont.Importe) BI From venMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = venMovimientos.venMovimientos And
	conMovCont.Renglon = venMovImpuestos.conRenglon
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos), 0) +

IsNull((Select Sum(venMovImpuestos.BaseImponibleMonedaNac) BI From venMovImpuestos
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.CodigoFiscal <> '2' And 
impTipoImpuesto.Referencia01 = 'IVA'), 0)) Exento,

IsNull((Select Sum(conMovCont.Importe) BI From venMovImpuestos  Inner Join conMovCont On conMovCont.conAsientos = venMovimientos.venMovimientos And
	conMovCont.Renglon = venMovImpuestos.conRenglon
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia04 = 'PERC' And 
impTipoImpuesto.Referencia05 = '1'), 0) PercNac,
IsNull((Select Sum(conMovCont.Importe) BI From venMovImpuestos  Inner Join conMovCont On conMovCont.conAsientos = venMovimientos.venMovimientos And
	conMovCont.Renglon = venMovImpuestos.conRenglon
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia04 = 'PERC' And 
impTipoImpuesto.Referencia02 = '2'), 0) PercIIBB,
IsNull((Select Sum(conMovCont.Importe) BI From venMovImpuestos  Inner Join conMovCont On conMovCont.conAsientos = venMovimientos.venMovimientos And
	conMovCont.Renglon = venMovImpuestos.conRenglon
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos And
impTipoImpuesto.Referencia02 = '3'), 0) PercMuni,
IsNull((Select Sum(conMovCont.Importe) BI From venMovImpuestos  Inner Join conMovCont On conMovCont.conAsientos = venMovimientos.venMovimientos And
	conMovCont.Renglon = venMovImpuestos.conRenglon
	Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Where venMovImpuestos.venMovimientos = venMovimientos.venMovimientos And
impTipoImpuesto.Referencia02 = '4'), 0) ImpInterno

From venMovimientos
Inner Join conAsientos On conAsientos.conAsientos = venMovimientos.venMovimientos
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
--Inner Join venClieHabitual On venClieHabitual.genEntidades = venMovimientos.Cliente_Id And venClieHabitual.Sucursal = venMovimientos.Sucursal
inner Join venMovimientosFiscal on venMovimientos.venMovimientos = venMovimientosFiscal.venMovimientos
Inner Join venClientes On venClientes.genEntidades = venMovimientos.Cliente_Id
Inner Join venClieHabitual On venClieHabitual.genEntidades = venMovimientos.Cliente_Id And
	venClieHabitual.Sucursal = venMovimientos.Sucursal
Inner Join genPaises On genPaises.genPaises = venClieHabitual.Pais_Id_Fact
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join genEntidades On genEntidades.genEntidades = venMovimientos.Cliente_Id
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Inner Join venSTMAfip On venSTMAfip.venSubTipoMov = venMovimientos.venSubTipoMov_Id And
	venSTMAfip.Letra = genAsiSegmentos.Segmento3C
Inner Join venCondFiscal On venCondFiscal.venCondFiscal = venClientes.CondFisc_Id
Inner Join conMovCont On conMovCont.conAsientos = conAsientos.conAsientos And conMovCont.Clase = 'CLI'
Where conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id And
venMovimientos.venTipoMov IN ('F','D','R', 'I', 'B', 'E') And conAsientos.Fecha BETWEEN @pFechaDesde AND @pFechaHasta
Order By 2, 3, 5

-- Al?cuotas comprobantes de ventas --
SELECT conAsientos.conAsientos, venMovImpuestos.BaseImponibleMonedaNac NetoGravado, 
impTipoImpuesto.CodigoFiscal codAlicuota, conMovCont.Importe 
FROM venMovImpuestos
INNER JOIN conMovCont ON venMovImpuestos.venMovimientos = conMovCont.conAsientos AND	
	venMovImpuestos.conRenglon = conMovCont.Renglon
Inner Join conAsientos On conAsientos.conAsientos = venMovImpuestos.venMovimientos
Inner Join venImpuestos ON venMovImpuestos.Impuesto_id = venImpuestos.venImpuestos 
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
Inner Join venMovimientos On venMovimientos.venMovimientos = conAsientos.conAsientos
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Where conAsientos.Anulado = 0 And impTipoImpuesto.Referencia01 = 'IVA' And
conAsientos.Empresa_Id = @pEmpresa_Id And
venMovimientos.venTipoMov IN ('F','D','R', 'I', 'B', 'E') And conAsientos.Fecha BETWEEN @pFechaDesde AND @pFechaHasta

-- Compras --
Select conAsientos.conAsientos, comMovProv.Fecha_CCP, comMovProv.TipoCompFE, comProveedores.Proveed_Id, 
genAsiSegmentos.Segmento2C TipoMov, genAsiSegmentos.Segmento1C Sucursal, genAsiSegmentos.Segmento1N Comprobante,
genAsiSegmentos.Segmento4C Letra, '' NroOrdenExterior, '' Aduana, '' Destinacion,
'' NroOperacion, '' FechaDespa, 
case when genSegmentos.Segmento_Id = 'FPRODESPA' then RIGHT('' + Ltrim(Rtrim(convert(varchar(16),genAsiSegmentos.Segmento3c))),16) else '' end Despacho_Id, '' Verificador, genEntidades.Cuit, comProveedores.RazonSocial, 
IsNull(genPaises.Pais_Id, 54) Pais_Id,
genEntidades.TipoDoc, comCondFiscal.CodigoFiscal, --comMovProv.Importe,
ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0) Importe,

IsNull((Select CAST(Sum(ROUND(comMovImpuestos.Base_Imponible*conAsientos.Cambio,2)) AS Decimal(12,2)) BI From comMovImpuestos 
	Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
		conMovCont.Renglon = comMovImpuestos.conRenglon
	INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia01 = 'IVA' And
impTipoImpuesto.CodigoFiscal = '1'), 0) IvaNoGravado,

IsNull((Select Sum(ROUND(comMovImpuestos.Base_Imponible*conAsientos.Cambio,2)) BI From comMovImpuestos 
	Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
		conMovCont.Renglon = comMovImpuestos.conRenglon
	INNER JOIN conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia01 = 'IVA' And
impTipoImpuesto.CodigoFiscal = '2'), 0) + 

IsNull((Select ISNULL((SELECT SUM(conMovCont.Importe) FROM conMovCont 
			WHERE comMovProv.comMovProv = conMovCont.conAsientos AND conMovCont.Clase = 'PRO'),0) - 
			IsNull(Sum(ROUND(comMovImpuestos.Base_Imponible*conAsientos.Cambio,2)), 0) BI 
From comMovImpuestos 
	Inner Join comMovProv CMP On CMP.comMovProv = comMovProv.comMovProv
	Inner Join conAsientos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
	Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
		conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia01 = 'IVA'), 0) -

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos 
	Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
		conMovCont.Renglon = comMovImpuestos.conRenglon
Where comMovImpuestos.comMovProv = comMovProv.comMovProv), 0) IvaExento,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos 
	Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
		conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia04 = 'PERC' And
impTipoImpuesto.Referencia05 = '1'), 0) PercIva,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
	conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia04 = 'PERC' And
impTipoImpuesto.Referencia05 = '1' And impTipoImpuesto.Referencia02 <> 'IVA'), 0) PercNac,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
	conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia04 = 'PERC' And
impTipoImpuesto.Referencia02 = '2'), 0) PercIIBB,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
	conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And
impTipoImpuesto.Referencia02 = '3'), 0) PercMuni,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
	conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And
impTipoImpuesto.Referencia02 = '4'), 0) ImpInterno,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
	conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Where comMovImpuestos.comMovProv = comMovProv.comMovProv AND
comImpuestos.TipoImpuesto IN ('1021','1022')), 0) Otros,

IsNull((Select Sum(conMovCont.Importe) BI From comMovImpuestos Inner Join conMovCont On conMovCont.conAsientos = comMovProv.comMovProv And
	conMovCont.Renglon = comMovImpuestos.conRenglon
	Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
	Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Where comMovImpuestos.comMovProv = comMovProv.comMovProv And impTipoImpuesto.Referencia01 = 'IVA'), 0) IVA,
genMonedas.Moneda_Id, conAsientos.Cambio

From comMovProv
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
Inner Join genSegmentos On genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Left Join genPaises On genPaises.genPaises = comProveedores.Pais
Inner Join genMonedas On genMonedas.genMonedas = conAsientos.Moneda_Id
Inner Join genEntidades On genEntidades.genEntidades = comMovprov.Proveed_Id
Inner Join comCondFiscal On comCondFiscal.comCondFiscal = comProveedores.CondFiscal_Id
Where conAsientos.Anulado = 0 And conAsientos.Empresa_Id = @pEmpresa_Id And
comMovProv.TipoMov IN ('F','D','R', 'I', 'B', 'E') And conAsientos.Fecha BETWEEN @pFechaDesde AND @pFechaHasta
Order By 2, 6, 7

-- Al?cuotas comprobantes de Compras --
SELECT conAsientos.conAsientos, CAST(ROUND(comMovImpuestos.Base_Imponible*conAsientos.Cambio,2) as decimal (12,2)) NetoGravado, 
impTipoImpuesto.CodigoFiscal codAlicuota, conMovCont.Importe Importe_Impuesto
FROM comMovImpuestos
INNER JOIN conMovCont ON comMovImpuestos.comMovProv = conMovCont.conAsientos AND	
	comMovImpuestos.conRenglon = conMovCont.Renglon
Inner Join conAsientos On conAsientos.conAsientos = comMovImpuestos.comMovProv
Inner Join comImpuestos ON comMovImpuestos.Impuesto_Id = comImpuestos.comImpuestos 
Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto
Inner Join comMovProv On comMovProv.comMovProv = conAsientos.conAsientos
Where conAsientos.Anulado = 0 And impTipoImpuesto.Referencia01 = 'IVA' And
conAsientos.Empresa_Id = @pEmpresa_Id And
comMovProv.TipoMov IN ('F','D','R', 'I', 'B', 'E') And conAsientos.Fecha BETWEEN @pFechaDesde AND @pFechaHasta
GO
