-- sueLiqAsientoRes 10626
DROP PROCEDURE sueLiqAsientoResDatos
GO
CREATE PROCEDURE sueLiqAsientoResDatos
(
	@sueLiquidacion bigInt
)
as
SELECT genSucursalesEmpr.Sucursal,  genSucursalesEmpr.Descripcion as DescripcionSuc,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro2.Centro2_Id, 
	CASE WHEN SUM(sueMovCont.Importe) >0 THEN SUM(sueMovCont.Importe) ELSE 0 END AS Debe,
	CASE WHEN SUM(sueMovCont.Importe) <0 THEN -SUM(sueMovCont.Importe) ELSE 0 END AS Haber
from sueMovCont INNER JOIN sueLiquidacion ON 
sueMovCont.sueLiquidacion = sueLiquidacion.sueLiquidacion
inner join  conCuentas ON
conCuentas.conCuentas = sueMovCont.Cuenta_Id 
INNER JOIN conCentro1 ON
conCentro1.conCentro1 = sueMovCont.Centro1_Id 
INNER JOIN conCentro2 ON
conCentro2.conCentro2 = sueMovCont.Centro2_Id 
inner join suePersSucursal ON
suePersSucursal.Legajo = sueMovCont.Legajo and 
sueLiquidacion.FechaFinal between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr =suePersSucursal.Sucursal
Where
	sueLiquidacion.sueLiquidacion = @sueLiquidacion
GROUP BY genSucursalesEmpr.Sucursal,  genSucursalesEmpr.Descripcion ,
	conCuentas.Cuenta_Id, conCuentas.Descripcion ,
	conCentro1.Centro1_Id, conCentro2.Centro2_Id 