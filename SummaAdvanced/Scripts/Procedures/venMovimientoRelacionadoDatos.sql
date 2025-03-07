DROP PROCEDURE venMovimientoRelacionadoDatos
go
CREATE PROCEDURE venMovimientoRelacionadoDatos(
	@venMovimientos BigInt
)
AS

SELECT venMovimientosFiscal.ClaveFiscal AS UUID
FROM venMovimientosCFDIR 
	INNER JOIN venMovimientosFiscal on venMovimientosFiscal.venMovimientos =venMovimientosCFDIR.venMovimientos
WHERE
	venMovimientosCFDIR.TipoRelacion = '04' AND 
	venMovimientosCFDIR.venMovimientosr = @venMovimientos
go


