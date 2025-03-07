-- tesFuljoDatosINT 1, '20200928','20201004',1

DROP PROCEDURE tesFuljoDatosINT
GO
CREATE PROCEDURE tesFuljoDatosINT(
@tesFlujoFondo bigint, 
@FechaDesde DateTime, 
@FechaHasta DateTime, 
@Empresa_Id Int
)

AS
SET DATEFIRST 1

Select tesFlujoFondo.tesFlujoFondo, 
	genSegmentos.Segmento_Id, tesFFSegmentos.Segmento1N, tesFFSegmentos.Segmento2N,
	tesFFSegmentos.Segmento3N, tesFFSegmentos.Segmento4N, tesFFSegmentos.Segmento1C,
	tesFFSegmentos.Segmento2C, tesFFSegmentos.Segmento3C, tesFFSegmentos.Segmento4C,
	tesFlujoFondo.FechaDesde, tesFlujoFondo.FechaHasta, tesFlujoFondo.DetallaClientes, 
	tesFlujoFondo.DetallaProveedores, tesFlujoFondo.Periodo, 
	tesFlujoFondo.FechaRegistro, genUsuarios.Usuario_Id, tesFFSegmentos.Empresa_Id
From tesFlujoFondo 
INNER JOIN tesFFSegmentos ON tesFFSegmentos.tesFlujoFondo =tesFlujoFondo.tesFlujoFondo
INNER JOIN genSegmentos ON genSegmentos.genSegmentos =tesFFSegmentos.Segmento_Id
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = tesFlujoFondo.Usuario_Id
Where
	tesFlujoFondo.tesFlujoFondo = @tesFlujoFondo

-- DIAS
SELECT TOP (DATEDIFF(DD, @FechaDesde, @FechaHasta)+1) IDENTITY(INT,1,1) AS id
INTO #Tempnumeros
FROM master.sys.columns a
 CROSS JOIN master.sys.columns b

 SELECT DATEADD(DD, #Tempnumeros.Id-1,@FechaDesde) as Fecha, 
 DATEPART(DW, DATEADD(DD, #Tempnumeros.Id-1,@FechaDesde)) Dia
 from #Tempnumeros
 WHERE
	DATEPART(DW, DATEADD(DD, #Tempnumeros.Id-1,@FechaDesde)) <> 7 AND
	NOT EXISTS(SELECT 1 FROM genDiasFestivos where
		genDiasFestivos.Fecha= DATEADD(DD, #Tempnumeros.Id-1,@FechaDesde))

-- Saldos Inicial por Cartera
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion , 
	@FechaDesde as Fecha, 
	genMonedas.Moneda_Id,
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) AS Monto
From tesIdentifica 
INNER JOIN  genMonedas ON genMonedas.genMonedas =tesIdentifica.Moneda_Id
INNER JOIN tesTiposId ON tesTiposId.tesTiposId = tesIdentifica.TipoCartera
INNER JOIN tesRengMovi ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN conMovCont ON 
		tesRengMovi.tesMovimientos = conMovCont.conAsientos AND 
		tesRengMovi.conRenglon = conMovCont.Renglon and 
		tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos 
LEFT JOIN (tesBPlink INNER JOIN tesCheqProp ON 
		tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp) ON 
		tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos and
		tesBPlink.conRenglon = tesRengMovi.conRenglon
WHERE
	tesTiposId.TipoCartera != 'CT' AND 
	tesIdentifica.VaAlCashFlow = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	isnull(tesIdentifica.Empresa_Id,@Empresa_Id) = @Empresa_Id AND 
	ISNULL(tesCheqProp.FechaVencimiento, conAsientos.Fecha) <= @FechaDesde 
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion , 
	genMonedas.Moneda_Id
HAVING SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) <> 0
order by 1

-- Movimientos Diarios por Cartera
SELECT tesIdentifica.Cartera_Id, tesIdentifica.Descripcion , 
	ISNULL(tesCheqProp.FechaVencimiento, conAsientos.Fecha) Fecha, 
	genMonedas.Moneda_Id,
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) Monto
From tesIdentifica 
INNER JOIN  genMonedas ON genMonedas.genMonedas =tesIdentifica.Moneda_Id
INNER JOIN tesTiposId ON tesTiposId.tesTiposId = tesIdentifica.TipoCartera
INNER JOIN tesRengMovi ON tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN conMovCont ON 
		tesRengMovi.tesMovimientos = conMovCont.conAsientos AND 
		tesRengMovi.conRenglon = conMovCont.Renglon and 
		tesRengMovi.Cartera_Id = tesIdentifica.tesIdentifica
INNER JOIN conAsientos ON conAsientos.conAsientos = conMovCont.conAsientos 
LEFT JOIN (tesBPlink INNER JOIN tesCheqProp ON 
		tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp) ON 
		tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos and
		tesBPlink.conRenglon = tesRengMovi.conRenglon
WHERE
	tesTiposId.TipoCartera != 'CT' AND 
	tesIdentifica.VaAlCashFlow = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	isnull(tesIdentifica.Empresa_Id,@Empresa_Id) = @Empresa_Id AND 
	ISNULL(tesCheqProp.FechaVencimiento, conAsientos.Fecha) >  @FechaDesde  AND 
	ISNULL(tesCheqProp.FechaVencimiento, conAsientos.Fecha) <=  @FechaHasta 
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion , 
	ISNULL(tesCheqProp.FechaVencimiento, conAsientos.Fecha), 	genMonedas.Moneda_Id
HAVING SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) <> 0  
order by 1,3


-- Saldos Inciales de Clientes

select venClientes.Cliente_Id, venClientes.RazonSocial, 
@FechaDesde as Fecha,
genMonedas.Moneda_Id, 
SUM(genMovCuotas.Saldo*venTipomov.Signo) as Monto
from conAsientos 
	INNER JOIN venMovimientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	conAsientos.Posteado= 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	genMovCuotas.FechaVencimiento <= @FechaDesde
group by venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id
HAVING SUM(genMovCuotas.Saldo*venTipomov.Signo) <>0
ORDER BY 1

-- Clientes Vencimientos Periodo

select venClientes.Cliente_Id, venClientes.RazonSocial, 
genMovCuotas.FechaVencimiento as Fecha,
genMonedas.Moneda_Id, 
SUM(genMovCuotas.Saldo*venTipomov.Signo) as Monto
from conAsientos 
	INNER JOIN venMovimientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	conAsientos.Posteado= 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	genMovCuotas.FechaVencimiento between @FechaDesde and @FechaHasta
group by venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, genMovCuotas.FechaVencimiento
HAVING SUM(genMovCuotas.Saldo*venTipomov.Signo) <>0
ORDER BY 1

-- Clientes Ajustes Manuales Saldo Inicial
select venClientes.Cliente_Id, venClientes.RazonSocial, 
@FechaDesde as Fecha,
genMonedas.Moneda_Id, 
SUM(tesFFCobClientes.Monto) as Monto
from tesFFCobClientes 
	INNER JOIN venClientes ON venClientes.genEntidades = tesFFCobClientes.Cliente_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = tesFFCobClientes.Moneda_Id
WHERE
	tesFFCobClientes.Fecha <= @FechaDesde and 
	tesFFCobClientes.tesFlujoFondo = @tesFlujoFondo
group by venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id
ORDER BY 1

-- Clientes Ajustes Manuales Movimientos

select venClientes.Cliente_Id, venClientes.RazonSocial, 
tesFFCobClientes.Fecha,
genMonedas.Moneda_Id, 
SUM(tesFFCobClientes.Monto) as Monto
from tesFFCobClientes 
	INNER JOIN venClientes ON venClientes.genEntidades = tesFFCobClientes.Cliente_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = tesFFCobClientes.Moneda_Id
WHERE
	tesFFCobClientes.tesFlujoFondo = @tesFlujoFondo and
	tesFFCobClientes.Fecha > @FechaDesde and 
	tesFFCobClientes.Fecha  <= 	@FechaHasta
group by venClientes.Cliente_Id, venClientes.RazonSocial, 
	genMonedas.Moneda_Id, tesFFCobClientes.Fecha
ORDER BY 1


-- Saldos Inciales de Proveedores

select comProveedores.Proveed_Id, comProveedores.RazonSocial, 
@FechaDesde as Fecha,
genMonedas.Moneda_Id, 
SUM(-genMovCuotas.Saldo*comMovTipos.Signo) as Monto
from conAsientos 
	INNER JOIN comMovProv ON comMovProv.comMovProv = conAsientos.conAsientos
	INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovprov.Tipomov
	INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = comMovProv.comMovProv
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovprov.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	comMovProv.FacturaTesoreria = 0 and
	conAsientos.Posteado= 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	genMovCuotas.FechaVencimiento <= @FechaDesde
group by comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id
HAVING SUM(genMovCuotas.Saldo*comMovTipos.Signo) <>0
ORDER BY 1

-- Proveedores Vencimientos Periodo

select comProveedores.Proveed_Id, comProveedores.RazonSocial, 
genMovCuotas.FechaVencimiento Fecha,
genMonedas.Moneda_Id, 
SUM(-genMovCuotas.Saldo*comMovTipos.Signo) as Monto
from conAsientos 
	INNER JOIN comMovProv ON comMovProv.comMovProv = conAsientos.conAsientos
	INNER JOIN comMovTipos ON comMovTipos.Tipomov = comMovprov.Tipomov
	INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = comMovprov.comMovprov
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovprov.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
WHERE
	comMovProv.FacturaTesoreria = 0 and
	conAsientos.Posteado= 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	genMovCuotas.FechaVencimiento > @FechaDesde and 
	genMovCuotas.FechaVencimiento <= @FechaHasta
group by comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id, genMovCuotas.FechaVencimiento 
HAVING SUM(genMovCuotas.Saldo*comMovTipos.Signo) <>0
ORDER BY 1

-- Ajustes a Proveedores Saldo Inicial

Select comProveedores.Proveed_Id, comProveedores.RazonSocial, 
tesFFPagosProvedores.Fecha,
genMonedas.Moneda_Id, 
SUM(tesFFPagosProvedores.Monto) as Monto
from tesFFPagosProvedores 
	INNER JOIN comProveedores ON comProveedores.genEntidades = tesFFPagosProvedores.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = tesFFPagosProvedores.Moneda_Id
WHERE
	tesFFPagosProvedores.tesFlujoFondo = @tesFlujoFondo and
	tesFFPagosProvedores.Fecha <= @FechaDesde 
group by comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id, tesFFPagosProvedores.Fecha
ORDER BY 1


-- Ajustes a Proveedores Del Periodo

Select comProveedores.Proveed_Id, comProveedores.RazonSocial, 
tesFFPagosProvedores.Fecha,
genMonedas.Moneda_Id, 
SUM(tesFFPagosProvedores.Monto) as Monto
from tesFFPagosProvedores 
	INNER JOIN comProveedores ON comProveedores.genEntidades = tesFFPagosProvedores.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = tesFFPagosProvedores.Moneda_Id
WHERE
	tesFFPagosProvedores.tesFlujoFondo = @tesFlujoFondo and
	tesFFPagosProvedores.Fecha > @FechaDesde and 
	tesFFPagosProvedores.Fecha  <= 	@FechaHasta
group by comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	genMonedas.Moneda_Id, tesFFPagosProvedores.Fecha
ORDER BY 1

-- Otros Ingresos del Periodo Unicamente
Select tesFFCobranzaOtros.Renglon, tesFFCobranzaOtros.Descripcion, 
	genMonedas.Moneda_Id, tesFFCobranzaOtros.Monto, tesFFCobranzaOtros.Fecha
FROM tesFFCobranzaOtros
	INNER JOIN genMonedas ON tesFFCobranzaOtros.Moneda_Id = genMonedas.genMonedas 
	WHERE
		tesFFCobranzaOtros.tesFlujoFondo = @tesFlujoFondo and
		tesFFCobranzaOtros.Fecha BETWEEN @FechaDesde AND @FechaHasta
ORDER BY 1


-- Otros Egresos del Periodo Unicamente
Select tesFFPagosOtros.Renglon, tesFFPagosOtros.Descripcion, 
	genMonedas.Moneda_Id, tesFFPagosOtros.Monto, 
	tesFFPagosOtros.Tipo, impImpuestos.Impuesto_Id, tesFFPagosOtros.Fecha
FROM tesFFPagosOtros
	INNER JOIN genMonedas ON tesFFPagosOtros.Moneda_Id = genMonedas.genMonedas 
	left join impImpuestos ON impImpuestos.impImpuestos = tesFFPagosOtros.Impuesto_Id
	WHERE
		tesFFPagosOtros.tesFlujoFondo = @tesFlujoFondo and
		tesFFPagosOtros.Fecha BETWEEN @FechaDesde AND @FechaHasta
ORDER BY 1

-- Traigo los Cheques en Catera Saldo Inicial y del Periodo 

SELECT genMonedas.Moneda_Id, SUM(conMovCont.ImporteMonedaOriginal) AS MontoSI
FROM tesCheqTerceros
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros =tesCheqTerceros.tesCheqTerceros
inner join tesRengMovi ON  tesRengMovi.tesMovimientos =tesCTlink.tesMovimientos and
tesRengMovi.conRenglon = tesCTlink.conRenglon
Inner join conAsientos ON  conAsientos.conAsientos =tesRengMovi.tesMovimientos
Inner join tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner join genMonedas ON  genMonedas.genMonedas  =tesIdentifica.Moneda_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
			conMovCont.Renglon = tesRengMovi.conRenglon
WHERE
tesIdentifica.VaAlCashFlow = 1 and 
conAsientos.Anulado = 0 AND 
conAsientos.Posteado = 1 AND 
tesCheqTerceros.Estado_Id = 'C' AND
tesCTlink.Secuencia = 1 AND
DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento) < @FechaDesde
GROUP BY genMonedas.Moneda_Id
--LEFT JOIN venClientes ON tesCheqTerceros.Cliente_Id = venClientes.genEntidades


SELECT genMonedas.Moneda_Id, DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento) Fecha,
SUM(conMovCont.ImporteMonedaOriginal) AS Monto
FROM tesCheqTerceros
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros =tesCheqTerceros.tesCheqTerceros
inner join tesRengMovi ON  tesRengMovi.tesMovimientos =tesCTlink.tesMovimientos and
tesRengMovi.conRenglon = tesCTlink.conRenglon
Inner join conAsientos ON  conAsientos.conAsientos =tesRengMovi.tesMovimientos
Inner join tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner join genMonedas ON  genMonedas.genMonedas  =tesIdentifica.Moneda_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
			conMovCont.Renglon = tesRengMovi.conRenglon
WHERE
tesIdentifica.VaAlCashFlow = 1 and 
conAsientos.Anulado = 0 AND 
conAsientos.Posteado = 1 AND 
tesCheqTerceros.Estado_Id = 'C' AND
tesCTlink.Secuencia = 1 AND
DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento) Between @FechaDesde and @FechaHasta
GROUP BY genMonedas.Moneda_Id, DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento)

-- Ajuste
SELECT tesFFDepositos.Fecha, genMonedas.Moneda_Id, venClientes.Cliente_Id, 
	venClientes.RazonSocial, tesFFDepositos.Monto
FROM tesFFDepositos
	left join venClientes ON venClientes.genEntidades = tesFFDepositos.Cliente_Id 
	INNER JOIN genMonedas ON genMonedas.genMonedas =tesFFDepositos.Moneda_Id
where
	tesFFDepositos.tesFlujoFondo = @tesFlujoFondo and
	tesFFDepositos.Fecha <= @FechaHasta

-- Detalle Por Cliente
SELECT genMonedas.Moneda_Id, venClientes.Cliente_Id, venClientes.RazonSocial,
DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento) Fecha,
SUM(conMovCont.ImporteMonedaOriginal) AS Monto
FROM tesCheqTerceros
INNER JOIN tesCTlink ON tesCTlink.tesCheqTerceros =tesCheqTerceros.tesCheqTerceros
inner join tesRengMovi ON  tesRengMovi.tesMovimientos =tesCTlink.tesMovimientos and
tesRengMovi.conRenglon = tesCTlink.conRenglon
Inner join conAsientos ON  conAsientos.conAsientos =tesRengMovi.tesMovimientos
Inner join tesIdentifica ON  tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
Inner join genMonedas ON  genMonedas.genMonedas  =tesIdentifica.Moneda_Id
LEFT JOIN venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and 
			conMovCont.Renglon = tesRengMovi.conRenglon

WHERE
tesIdentifica.VaAlCashFlow = 1 and 
conAsientos.Anulado = 0 AND 
conAsientos.Posteado = 1 AND 
tesCheqTerceros.Estado_Id = 'C' AND
tesCTlink.Secuencia = 1 AND
DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento) <= @FechaHasta
GROUP BY genMonedas.Moneda_Id, venClientes.Cliente_Id, venClientes.RazonSocial,
DATEADD(DD, tesCheqTerceros.ClearingDias, FechaVencimiento)


go


DROP PROCEDURE tesFlujoDatos
GO
CREATE PROCEDURE tesFlujoDatos(
	@Empresa_Id INT, 
	@Segmento_Id Char(5),
	@Segmento1C Char(25),
	@Segmento2C Char(25),
	@Segmento3C Char(25),
	@Segmento4C Char(25),
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int, 
	@FechaDesde DateTime = null, 
	@FechaHasta DateTime = null
)
as

DECLARE @tesFluFondo bigint

SELECT @tesFluFondo = tesFFSegmentos.tesFlujoFondo
from tesFFSegmentos inner join genSegmentos ON 
	tesFFSegmentos.Segmento_Id = genSegmentos.genSegmentos
	Where
		genSegmentos.Segmento_Id = @Segmento_Id and 
		tesFFSegmentos.Empresa_Id = @Empresa_Id and 
		tesFFSegmentos.Segmento1N = @Segmento1N and 
		tesFFSegmentos.Segmento2N = @Segmento2N and 
		tesFFSegmentos.Segmento3N = @Segmento3N and 
		tesFFSegmentos.Segmento4N = @Segmento4N and 
		tesFFSegmentos.Segmento1C = @Segmento1C and 
		tesFFSegmentos.Segmento2C = @Segmento2C and 
		tesFFSegmentos.Segmento3C = @Segmento3C and 
		tesFFSegmentos.Segmento4C = @Segmento4C 

EXEC tesFuljoDatosINT @tesFluFondo, @FechaDesde, @FechaHasta, @Empresa_Id
GO

