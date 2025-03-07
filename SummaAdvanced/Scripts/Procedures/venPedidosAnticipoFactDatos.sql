-- venPedidosAnticipoFactDatos 793
DROP PROCEDURE venPedidosAnticipoFactDatos
GO
CREATE PROCEDURE venPedidosAnticipoFactDatos
(
	@venPedidos Int
)
AS



SELECT venPediFacturados.venPedidos,
	sum(CASE WHEN venTipomov.Signo = 1 then -conMovCont.Importe * (-2*conMovCont.Tipomov+3) else 0 end) as ImporteFac,  
	sum(CASE WHEN venTipomov.Signo = 1 then -conMovCont.ImporteMonedaOriginal* (-2*conMovCont.Tipomov+3) else 0 end ) as ImporteOriginalFac, 
	sum(CASE WHEN venTipomov.Signo = -1 then -conMovCont.Importe * (-2*conMovCont.Tipomov+3) else 0 end) as ImporteNC,  
	sum(CASE WHEN venTipomov.Signo = -1 then -conMovCont.ImporteMonedaOriginal* (-2*conMovCont.Tipomov+3) else 0 end ) as ImporteOriginalNC 
FROM venPediFacturados 
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = venPediFacturados.venMovimientos
INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN venMovDetalle ON  venMovDetalle.venMovimientos = conAsientos.conAsientos 
INNER JOIN conMovCont ON conMovCont.conAsientos = venMovDetalle.venMovimientos AND
			conMovCont.Renglon = venMovDetalle.conRenglon
INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	venPediFacturados.venPedidos = @venPedidos
GROUP BY venPediFacturados.venPedidos
GO

