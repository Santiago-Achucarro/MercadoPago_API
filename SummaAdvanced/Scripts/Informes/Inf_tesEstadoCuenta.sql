-- Inf_tesEstadoCuenta '20181201','20181231',' ','zzz', 1

DROP Procedure Inf_tesEstadoCuenta
GO
CREATE Procedure Inf_tesEstadoCuenta
(
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@SucursalDesde VarChar(4), 
	@SucursalHasta VarChar(4), 
	@Empresa int
)
AS

SELECT 1 TM , 'Saldos_Iniciales' as DescripcionTM, ' ' as TIPOMOV,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as Saldo,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as SaldoBase
from conAsientos INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos 
INNER JOIN tesRengMovi ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN tesTiposId on tesTiposId.tesTiposId = tesIdentifica.TipoCartera
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Where
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	tesTiposId.Tipocartera IN( 'CP','CT','EF')  and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 and 
	conAsientos.Fecha < @FechaDesde and
	conAsientos.Empresa_Id = @Empresa
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion 
HAVING SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) <> 0
UNION ALL

SELECT 2 TM , tesSubTiposMov.Descripcion as DescripcionTM,  tesSubTiposMov.TipoMov,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as Saldo,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as SaldoBase
from conAsientos INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos 
INNER JOIN tesRengMovi ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN tesMovimientos ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN tesTiposId on tesTiposId.tesTiposId = tesIdentifica.TipoCartera
INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
Where
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	tesTiposId.Tipocartera NOT IN( 'RE')  and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 and 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta AND 
	conAsientos.Empresa_Id = @Empresa
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion , 
	tesSubTiposMov.Descripcion ,  tesSubTiposMov.TipoMov
UNION ALL
SELECT 3 TM , 'Saldos_Finales' as DescripcionTM, ' ' as TIPOMOV,
	tesIdentifica.Cartera_Id, tesIdentifica.Descripcion as DescripcionCartera, 
	SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) as Saldo,
	SUM(conMovCont.Importe*(-2*conMovCont.TipoMov+3)) as SaldoBase
from conAsientos INNER JOIN conMovCont ON conAsientos.conAsientos = conMovCont.conAsientos 
INNER JOIN tesRengMovi ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
INNER JOIN tesTiposId on tesTiposId.tesTiposId = tesIdentifica.TipoCartera
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	Where
	genSucursalesEmpr.Sucursal between @SucursalDesde and @SucursalHasta and 
	tesTiposId.Tipocartera IN( 'CP','CT','EF')  and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 and 
	conAsientos.Fecha <= @FechaHasta and
	conAsientos.Empresa_Id = @Empresa
GROUP BY tesIdentifica.Cartera_Id, tesIdentifica.Descripcion 
HAVING SUM(conMovCont.ImporteMonedaOriginal*(-2*conMovCont.TipoMov+3)) <> 0
ORDER BY 1,3 DESC, 2
GO	