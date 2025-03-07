DROP PROCEDURE venAsiCierreGuardar
GO
CREATE PROCEDURE venAsiCierreGuardar
(
@pAsiento_Id bigint,
@pFecha qFecha,
@pMoneda_Id varchar(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venAsiCierre WHERE (Asiento_Id = @pAsiento_Id)))
BEGIN 
	UPDATE venAsiCierre
	SET	Fecha = @pFecha,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)
	WHERE (Asiento_Id = @pAsiento_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venAsiCierre
	(
		Asiento_Id,
		Fecha,
		Moneda_Id
		
	)
	VALUES 
	(
		@pAsiento_Id,
		@pFecha,
		dbo.FuncFKgenMonedas(@pMoneda_Id)
	)
END 

GO

DROP PROCEDURE venAsiCierreDatos
GO
CREATE PROCEDURE venAsiCierreDatos
(
@pFecha DateTime, 
@pMoneda_id VarChar(3), 
@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

DECLARE @Asiento_id bigint
SET @Asiento_id = (SELECT venAsiCierre.Asiento_Id 
		FROM venAsiCierre  inner join conAsientos ON
		venAsiCierre.Asiento_Id = conAsientos.conAsientos
		WHERE venAsiCierre.Fecha= @pFecha and 
			venAsiCierre.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_id) and 
			conAsientos.Empresa_Id = @pEmpresa_Id)
  


SELECT venAsiCierre.Asiento_Id , conAsientos.Empresa_Id, venAsiCierre.Fecha, 
	conAsientos.FechaRegistro, conAsientos.Cambio, conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones, conAsientos.Posteado,
    venAsiCierre.Fecha, genMonedas.Moneda_Id,  	genMonedas.Descripcion as DescripcionMonedas
FROM venAsiCierre 
INNER JOIN conAsientos  ON conAsientos.conAsientos = venAsiCierre.Asiento_Id
INNER JOIN genMonedas  ON genMonedas.genMonedas = venAsiCierre.Moneda_Id
WHERE venAsiCierre.Fecha= @pFecha and 
	genMonedas.Moneda_Id = @pMoneda_id and 
	conAsientos.Empresa_Id = @pEmpresa_Id

Exec venAsiCierreCrDatos @Asiento_id, null		
 
RETURN @@Error 

GO

DROP PROCEDURE venAsiCierreEliminar
GO
CREATE PROCEDURE venAsiCierreEliminar
(
@Asiento_Id bigInt
)
AS
SET NOCOUNT ON 

DELETE FROM venAsiCierre 
WHERE venAsiCierre.Asiento_Id = @Asiento_Id
 
RETURN @@Error 

GO


-- Asiento a Insertar
drop PROCEDURE venAsiCierreCalculoDatos
go
-- venAsiCierreCalculoDatos '20191130',1
CREATE PROCEDURE venAsiCierreCalculoDatos (
@Fecha DateTime, 
@Empresa_Id Int
)
AS

SELECT @Fecha as Fecha

Select Cliente_Id, RazonSocial, Cuenta_id, Descripcion, 
	Moneda_id, Sum(Importe) as Importe, 
	SUM(ImporteMonedaOriginal) AS ImporteMonedaOriginal
	
from (

SELECT genMonedas.Moneda_id, venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, 
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM venClientes INNER join venMovimientos ON
venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos = venMovimientos.venMovimientos
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('CLI', 'ANTCL')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas
WHERE 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY genMonedas.Moneda_id, venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion
UNION ALL
SELECT  genMonedas.Moneda_id,venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM venClientes INNER join venMovimientos ON
venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsientoApli_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('CLI', 'ANTCL')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas

WHERE 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
UNION ALL
SELECT  genMonedas.Moneda_id,venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM venClientes INNER join venMovimientos ON
venClientes.genEntidades = venMovimientos.Cliente_Id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id = venMovimientos.venMovimientos
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsieDifCambio_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('CLI', 'ANTCL')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas

WHERE 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado = 1 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
UNION ALL
SELECT genMonedas.Moneda_id,venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, 
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM venClientes INNER join venAsiCierreCr ON
venClientes.genEntidades = venAsiCierreCr.Cliente_Id
INNER JOIN conAsientos ON
conAsientos.conAsientos = venAsiCierreCr.Asiento_id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovcont.Renglon = venAsiCierreCr.conRenglon and 
conMovCont.Clase IN ('CLI', 'ANTCL')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas

WHERE 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha
GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id) as xxx
GROUP BY Cliente_Id, RazonSocial, Cuenta_id, Descripcion, 
	Moneda_id	
ORDER BY 1	,2 


GO

DROP PROCEDURE venAsiCierreDatosCierre
GO
CREATE PROCEDURE venAsiCierreDatosCierre
(
@pFecha DateTime, 
@Empresa_Id Int
)
AS
SET NOCOUNT ON 

SELECT @pFecha as Fecha 



SELECT venAsiCierre.Asiento_Id , conAsientos.Empresa_Id, venAsiCierre.Fecha, 
	conAsientos.Anulado, genMonedas.Moneda_Id, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
FROM venAsiCierre 
INNER JOIN conAsientos  ON conAsientos.conAsientos = venAsiCierre.Asiento_Id
INNER JOIN genMonedas  ON genMonedas.genMonedas = venAsiCierre.Moneda_Id
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
inner join genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE venAsiCierre.Fecha between @pFecha  and DATEADD(dd,1,@pFecha)  and 
conAsientos.Anulado = 0 and 
conAsientos.Empresa_Id = @Empresa_Id

 
RETURN @@Error 

GO




