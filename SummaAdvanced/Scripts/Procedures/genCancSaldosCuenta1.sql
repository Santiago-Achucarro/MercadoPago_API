--set transaction isolation level read uncommitted
-- EXEC genCancSaldosCuenta 21950, 21962

-- select top 100 * from conAsientos order by 1 desc


DROP Procedure genCancSaldosCuenta1
GO

Create Procedure genCancSaldosCuenta1(
	@pAsiento_Id BigInt, 
	@pAsiento_Id_ap BigInt,
	@pFechaAplicacion DateTime
)
as

SELECT @pAsiento_id Asiento_Id, @pAsiento_Id_ap Asiento_Id_Ap,
	genMonedas.Moneda_Id, genMonedasAP.Moneda_Id Moneda_Id_AP, 
		conAsientos.Fecha, conAsientosAP.Fecha FechaAP, conAsientos.Cambio, conAsientosAP.Cambio CambioAP
from conAsientos 
	inner join genMonedas ON  genMonedas.genMonedas = conAsientos.Moneda_Id
	inner join conAsientos  conAsientosAP ON  conAsientosAP.conAsientos = @pAsiento_Id_ap
	inner join genMonedas genMonedasAP ON  genMonedasAP.genMonedas = conAsientosAP.Moneda_Id
	where
	conAsientos.conAsientos =@pAsiento_id


SELECT Cuenta_Id, 
Sum(PRO) PRO, Sum(ANTPR) ANTPR, Sum(PROPES) PROPES, Sum(ANTPRPES) ANTPRPES, Sum(PRO_Ap) PRO_Ap, Sum(AntPR_Ap) AntPR_Ap, Sum(PROPES_Ap) PROPES_Ap, Sum(AntPRPES_Ap) AntPRPES_Ap,
Sum(CLI) CLI, Sum(ANTCL) ANTCL, Sum(CLIPES) CLIPES, Sum(ANTCLPES) ANTCLPES, Sum(CLI_Ap) CLI_Ap, Sum(ANTCL_Ap) ANTCL_Ap, Sum(CLIPES_Ap) CLIPES_Ap, Sum(ANTCLPES_Ap) ANTCLPES_Ap
FROM
(
-------------------
---- Clientes -----
-------------------
--- CLI FACTURA. Busco la cuenta CLI en la factura topada con el importe a aplicarle ahora --
SELECT 'Debe' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) CLI, 0 ANTCL, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'CLI' AND 
	conMovCont.conAsientos = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.conAsientos, conAsientos.Cambio
union all -- CLIPAGO. Busco el total CLI de la cobranza que estoy aplicando --
SELECT 'Haber' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) CLI_Ap, 0 ANTCL_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'CLI' AND 
	conMovCont.conAsientos = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.Cambio, conAsientos.conAsientos
Union All
--- CLI FACTURA. Busco la cuenta ANTCL en la factura a aplicar ahora --
SELECT 'Debe' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) ANTCL, 
0 AS CLIPES, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'ANTCL' AND 
	conMovCont.conAsientos = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.conAsientos, conAsientos.Cambio
union all -- CLIPAGO. Busco el total ANTCL de la cobranza que estoy aplicando --
SELECT 'Haber' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) ANTCL_Ap, 
0 CLIPES_Ap, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'ANTCL' AND 
	conMovCont.conAsientos = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.Cambio, conAsientos.conAsientos

Union All
-- ASIENTOS DE APLICACION. Busco las cuentas CLI de las aplicaciones anteriores de la factura --
SELECT 'DebeAPL' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) CLI, 0 ANTCL, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'CLI' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE APLICACION. Busco las cuentas CLI de las aplicaciones anteriores de la cobranza --
Union All
SELECT 'HaberApl' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) CLI_Ap, 0 ANTCL_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'CLI' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

Union All
-- ASIENTOS DE APLICACION. Busco las cuentas ANTCL de las aplicaciones anteriores de la factura --
SELECT 'DebeAPL' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) ANTCL, 
0 AS CLIPES, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTCL' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE APLICACION. Busco las cuentas ANTCL de las aplicaciones anteriores de la cobranza --
Union All
SELECT 'HaberApl' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) ANTCL_Ap, 
0 CLIPES_Ap, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTCL' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos


Union All
-- ASIENTOS DE DC. Busco las cuentas CLI de las DC anteriores de la factura --
SELECT 'DebeDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) CLI, 0 ANTCL, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'CLI' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE DC. Busco las cuentas CLI de las DC anteriores de la cobranza --
Union All
SELECT 'HaberDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) CLI_Ap, 0 ANTCL_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'CLI' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

Union All
-- ASIENTOS DE DC. Busco las cuentas ANTCL de las DC anteriores de la factura --
SELECT 'DebeDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) ANTCL, 
0 AS CLIPES, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTCL' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE DC. Busco las cuentas ANTCL de las DC anteriores de la cobranza --
Union All
SELECT 'HaberDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) ANTCL_Ap, 
0 CLIPES_Ap, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTCL' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

Union All
-- De la cobranza que está aplicando busco las cuentas CLI de la facturas previamente aplicadas --
SELECT 'HaberCLIAplAnt' TC, conCuentas.Cuenta_Id, conasientos.conasientos,
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 CLIPES, 0 ANTCLPES,
genCancMov.Importe*(-2*conmovCont.Tipomov+3) CLI_Ap, 0 ANTCL_Ap,
ROUND(genCancMov.Importe*conAsientos.Cambio,2)*(-2*conmovCont.Tipomov+3) CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.Asiento_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'CLI' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos, conAsientos.Cambio, genCancMov.Importe, conmovCont.Tipomov
Union All
-- De la cobranza que está aplicando busco las cuentas Anticipos de la facturas previamente aplicadas --
SELECT 'HaberANTCLAplAnt' TC, conCuentas.Cuenta_Id, conasientos.conasientos,
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 CLIPES, 0 ANTCLPES,
0 CLI_Ap, genCancMov.Importe*(-2*conmovCont.Tipomov+3) ANTCL_Ap,
0 CLIPES_Ap, ROUND(genCancMov.Importe*conAsientos.Cambio,2)*(-2*conmovCont.Tipomov+3) ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.Asiento_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTCL' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos, conAsientos.Cambio, genCancMov.Importe, conmovCont.Tipomov
--- PROVEEDORES  ---
UNION ALL
--- PRO PAGO. Busco la cuenta PRO en la factura --
SELECT 'Debe' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) as PRO, 
0 as ANTPR, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) as PROPES, 
0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'PRO' AND 
	conMovCont.conAsientos = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.conAsientos, conAsientos.Cambio
union all -- PRO FACTURA. Busco el total PRO de la FACTURA que estoy aplicando --
SELECT 'Haber' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) PRO_Ap, 0 AntPR_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'PRO' AND 
	conMovCont.conAsientos = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.Cambio, conAsientos.conAsientos
Union All
--- ANTPR PAGO. Busco la cuenta ANTPR en la PAGO a aplicar ahora --
SELECT 'Debe' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) as ANTPR, 
0 as PROPES, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'ANTPR' AND 
	conMovCont.conAsientos = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.conAsientos, conAsientos.Cambio
union all -- ANTPR . Busco el total ANTRP del Pago que estoy aplicando --
SELECT 'Haber' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) AntPR_Ap, 0 PROPES_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 
0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	conMovCont.Clase = 'ANTPR' AND 
	conMovCont.conAsientos = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id, conAsientos.Cambio, conAsientos.conAsientos
Union All
-- ASIENTOS DE APLICACION. Busco las cuentas PRO de las aplicaciones anteriores del Pago --
SELECT 'DebeAPL' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) as PRO, 0 as ANTPR, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'PRO' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE APLICACION. Busco las cuentas PRO de las aplicaciones anteriores de la Factura --
Union All
SELECT 'HaberApl' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) PRO_Ap, 
0 AntPR_Ap, SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 
0 AS CLIPES, 0 ANTCLPES,
0 CLI_Ap, 0 ANTCL_Ap, 
0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'PRO' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos
Union All
-- ASIENTOS DE APLICACION. Busco las cuentas ANTPR de las aplicaciones anteriores de la Pago --
SELECT 'DebeAPL' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) as ANTPR, 0 as PROPES, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTPR' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE APLICACION. Busco las cuentas ANTPR de las aplicaciones anteriores de la Factura --
Union All
SELECT 'HaberApl' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) AntPR_Ap, 0 PROPES_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES,0 CLI_Ap, 0 ANTCL_Ap,  0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsientoApli_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTCL' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos


Union All
-- ASIENTOS DE DC. Busco las cuentas PRO de las DC anteriores del pago --
SELECT 'DebeDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) as PRO, 0 as ANTPR, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'PRO' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE DC. Busco las cuentas PRO de las DC anteriores de la Factura --
Union All
SELECT 'HaberDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) PRO_Ap, 0 AntPR_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) PROPES_Ap, 
0 AntPRPES_Ap, 0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'PRO' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

Union All
-- ASIENTOS DE DC. Busco las cuentas ANTPR de las DC anteriores del Pago --
SELECT 'DebeDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) as ANTPR, 0 as PROPES, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTPR' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

-- ASIENTOS DE DC. Busco las cuentas ANTPR de las DC anteriores de la Factura --
Union All
SELECT 'HaberDC' TC, conCuentas.Cuenta_Id, conasientos.conasientos,	
0 as PRO, 0 as ANTPR, 0 as PROPES, 0 as ANTPRPES, 0 PRO_Ap, 
SUM(conMovCont.ImporteMonedaOriginal*(-2*conmovCont.Tipomov+3)) AntPR_Ap, 0 PROPES_Ap, 
SUM(conMovCont.Importe*(-2*conmovCont.Tipomov+3)) AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 AS CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.AsieDifCambio_Id = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTPR' AND 
	genCancMov.Asiento_Id_Ap = @pAsiento_Id_ap and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos

Union All
-- Del Pago que está aplicando busco las cuentas PRO de la facturas previamente aplicadas --
SELECT 'DebeCLIAplAnt' TC, conCuentas.Cuenta_Id, conasientos.conasientos,
genCancMov.Importe*(-2*conmovCont.Tipomov+3)  as PRO, 0 as ANTPR, 
ROUND(genCancMov.Importe*conAsientos.Cambio,2)*(-2*conmovCont.Tipomov+3)  as PROPES, 
0 as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 CLIPES, 0 ANTCLPES, 0 CLI_Ap, 0 ANTCL_Ap, 0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.Asiento_Id_ap = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'PRO' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos, conAsientos.Cambio, genCancMov.Importe, conmovCont.Tipomov
Union All
-- Del Pago que está aplicando busco las cuentas Anticipos de la facturas previamente aplicadas --
SELECT 'DebeANTCLAplAnt' TC, conCuentas.Cuenta_Id, conasientos.conasientos,
0 as PRO, genCancMov.Importe*(-2*conmovCont.Tipomov+3) as ANTPR, 0 as PROPES, 
ROUND(genCancMov.Importe*conAsientos.Cambio,2)*(-2*conmovCont.Tipomov+3) as ANTPRPES, 0 PRO_Ap, 0 AntPR_Ap, 0 PROPES_Ap, 0 AntPRPES_Ap,
0 CLI, 0 ANTCL, 0 CLIPES, 0 ANTCLPES,0 CLI_Ap, 0 ANTCL_Ap,0 CLIPES_Ap, 0 ANTCLPES_Ap
from conMovCont 
	INNER JOIN conCuentas ON  conCuentas.conCuentas = conMovCont.Cuenta_Id
	inner join genCancMov ON  genCancMov.Asiento_Id_AP = conMovCont.conAsientos
	inner join conAsientos ON conAsientos.conAsientos =conMovCont.conAsientos
WHERE
	genCancMov.FechaAplicacion < @pFechaAplicacion and 
	conMovCont.Clase = 'ANTPR' AND 
	genCancMov.Asiento_Id = @pAsiento_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1
GROUP BY conCuentas.Cuenta_Id,conasientos.conasientos, conAsientos.Cambio, genCancMov.Importe, conmovCont.Tipomov
) AS XXX
GROUP BY Cuenta_Id

GO
