---select * from vconMovCont where conAsientos = 1637

-- Inf_venSaldoXCuenta '20191231',1
DROP PROCEDURE Inf_venSaldoXCuenta
GO
CREATE PROCEDURE Inf_venSaldoXCuenta @FechaHasta DateTime, @Empresa int
AS
SELECT Cuenta_Id, Descripcion, Cliente_id, RazonSocial , 
	SUM(Monto) as Monto
FROM (
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
From venMovimientos 
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
Inner Join venSubTipoMov On venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Where
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And 
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('CLI', 'ANTCL') And
	venSubTipoMov.SubTipoMov_Id Not In ('DDC', 'CDC')
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial
	having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
From genCancMov 
INNER JOIN conAsientos ON genCancMov.AsientoApli_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genCancMov.Asiento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
Where
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('CLI', 'ANTCL')
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial
	having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0
UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
From genCancMov 
INNER JOIN conAsientos ON genCancMov.AsieDifCambio_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genCancMov.Asiento_Id
INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
Where
	conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('CLI', 'ANTCL')
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial
	having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0

UNION ALL
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial, 
	Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) as Monto
From venAsiCierre inner join venAsiCierrecr ON venAsiCierre.Asiento_Id = venAsiCierreCr.Asiento_Id
INNER JOIN conAsientos ON venAsiCierre.Asiento_Id = conAsientos.conAsientos
INNER JOIN conMovCont ON conMovCont.conAsientos = venAsiCierreCr.Asiento_Id and 
				conMovCont.Renglon = venAsiCierreCr.conRenglon
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id
INNER JOIN venClientes ON venClientes.genEntidades = venAsiCierreCr.Cliente_Id 
Where
	conAsientos.Anulado = 0 And 
	conAsientos.Posteado = 1 And
	conAsientos.Empresa_Id = @Empresa and 
	conAsientos.Fecha <= @FechaHasta  and 
	conMovCont.Clase IN('CLI', 'ANTCL')
GROUP BY conCuentas.Cuenta_Id, conCuentas.Descripcion, 
	venClientes.Cliente_Id, venClientes.RazonSocial
	having Convert(Numeric(18,2), SUM(conMovCont.Importe* (-2*conMovCont.Tipomov+3))) <> 0

	) as XXX
GROUP BY Cuenta_Id, Descripcion, Cliente_id, RazonSocial  
	HAVING SUM(Monto) <> 0
ORDER BY 1,4  DESC
GO



