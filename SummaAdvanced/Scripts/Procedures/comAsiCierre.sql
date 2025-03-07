DROP PROCEDURE comAsiCierreGuardar
GO
CREATE PROCEDURE comAsiCierreGuardar
(
@pAsiento_Id bigint,
@pFecha qFecha,
@pMoneda_Id varchar(3)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comAsiCierre WHERE (Asiento_Id = @pAsiento_Id)))
BEGIN 
	UPDATE comAsiCierre
	SET	Fecha = @pFecha,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id)
	WHERE (Asiento_Id = @pAsiento_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comAsiCierre
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

DROP PROCEDURE comAsiCierreDatos
GO
CREATE PROCEDURE comAsiCierreDatos
(
@pFecha DateTime, 
@pMoneda_id VarChar(3), 
@pEmpresa_Id Int
)
AS
SET NOCOUNT ON 

DECLARE @Asiento_id bigint
SET @Asiento_id = (SELECT comAsiCierre.Asiento_Id 
		FROM comAsiCierre inner join conAsientos ON
		comAsiCierre.Asiento_Id = conAsientos.conAsientos
		WHERE comAsiCierre.Fecha= @pFecha and 
			comAsiCierre.Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_id) and 
			conAsientos.Empresa_Id = @pEmpresa_Id)
 


SELECT comAsiCierre.Asiento_Id , conAsientos.Empresa_Id, comAsiCierre.Fecha, 
	conAsientos.FechaRegistro, conAsientos.Cambio, conAsientos.CambioMonedaOriginal, 
	conAsientos.Anulado, conAsientos.Observaciones, conAsientos.Posteado,
    comAsiCierre.Fecha, genMonedas.Moneda_Id,  	genMonedas.Descripcion as DescripcionMonedas
FROM comAsiCierre 
INNER JOIN conAsientos  ON conAsientos.conAsientos = comAsiCierre.Asiento_Id
INNER JOIN genMonedas  ON genMonedas.genMonedas = comAsiCierre.Moneda_Id
WHERE comAsiCierre.Fecha= @pFecha and 
	genMonedas.Moneda_Id = @pMoneda_id and 
	conAsientos.Empresa_Id = @pEmpresa_Id

Exec comAsiCierreCrDatos @Asiento_id, null		
 
RETURN @@Error 

GO

DROP PROCEDURE comAsiCierreEliminar
GO
CREATE PROCEDURE comAsiCierreEliminar
(
@Asiento_Id bigInt
)
AS
SET NOCOUNT ON 

DELETE FROM comAsiCierre 
WHERE comAsiCierre.Asiento_Id = @Asiento_Id
 
RETURN @@Error 

GO


-- Asiento a Insertar
drop PROCEDURE comAsiCierreCalculoDatos
go
-- comAsiCierreCalculoDatos '20180331',1
CREATE PROCEDURE comAsiCierreCalculoDatos (
@Fecha DateTime, 
@Empresa_Id Int
)
AS

SELECT @Fecha as Fecha

Select Proveed_id, RazonSocial, Cuenta_id, Descripcion, 
	Moneda_id, Sum(Importe) as Importe, 
	SUM(ImporteMonedaOriginal) AS ImporteMonedaOriginal
	
from (

SELECT genMonedas.Moneda_id, comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, 
	
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores 
INNER join comMovProv ON comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
INNER JOIN conMovCont ON conMovCont.conAsientos =conAsientos.conAsientos AND conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON genEmpresas.genEmpresas = @Empresa_Id AND genEmpresas.Moneda_Id != genMonedas.genMonedas
WHERE 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY genMonedas.Moneda_id, comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion
UNION ALL
--APLICACIONES
SELECT  genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores 
INNER join commovprov ON comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN genCancMov ON genCancMov.Asiento_Id = comMovProv.comMovProv 
INNER JOIN conAsientos ON conAsientos.conAsientos = genCancMov.AsientoApli_Id
INNER JOIN conMovCont ON conMovCont.conAsientos = conAsientos.conAsientos AND conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON genEmpresas.genEmpresas = @Empresa_Id AND genEmpresas.Moneda_Id != genMonedas.genMonedas

WHERE 
	genCancMov.Importacion = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
UNION ALL
-- DIFERENCIA EN CAMBIOS
SELECT  genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores INNER join commovprov ON
comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id = comMovProv.comMovProv 
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsieDifCambio_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas

WHERE 
	genCancMov.Importacion = 0 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id

UNION ALL
-- CIERRE DE MES
SELECT genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, 
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores INNER join comAsiCierreCr ON
comProveedores.genEntidades = comAsiCierreCr.Proveed_id
INNER JOIN conAsientos ON
conAsientos.conAsientos = comAsiCierreCr.Asiento_id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovcont.Renglon = comAsiCierreCr.conRenglon and 
conMovCont.Clase IN ('PRO', 'ANTPR')
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
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
UNION ALL
-- IMPORTACIONES 
SELECT  genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores INNER join commovprov ON
comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id = comMovProv.comMovProv 
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsientoApli_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas
INNER JOIN genCancMovApliImpor ON
genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
genCancMovApliImpor.Renglon = conMovCont.Renglon and 
genCancMovApliImpor.EsDelAp = 0
WHERE 
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
-- IMPORTACIONES AP
UNION ALL
SELECT  genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores INNER join commovprov ON
comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id_Ap = comMovProv.comMovProv 
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsientoApli_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas
INNER JOIN genCancMovApliImpor ON
genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
genCancMovApliImpor.Renglon = conMovCont.Renglon and 
genCancMovApliImpor.EsDelAp = 1
WHERE 
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
-- IMPORTACIONES DC
UNION ALL
SELECT  genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores INNER join commovprov ON
comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id = comMovProv.comMovProv 
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsieDifCambio_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas
INNER JOIN genCancMovApliImpor ON
genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
genCancMovApliImpor.Renglon = conMovCont.Renglon and 
genCancMovApliImpor.EsDelAp = 0
WHERE 
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id
-- IMPROTACIONES DC AP
UNION ALL
SELECT  genMonedas.Moneda_id,comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion,
	SUM(conMovCont.Importe * (-2*conMovCont.TipoMov+3)) as Importe, 
	SUM(conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3)) as ImporteMonedaOriginal 
FROM comProveedores INNER join commovprov ON
comProveedores.genEntidades = comMovProv.Proveed_id
INNER JOIN genCancMov ON 
genCancMov.Asiento_Id_Ap = comMovProv.comMovProv 
INNER JOIN conAsientos ON
conAsientos.conAsientos = genCancMov.AsieDifCambio_Id
INNER JOIN conMovCont ON
conMovCont.conAsientos =conAsientos.conAsientos AND 
conMovCont.Clase IN ('PRO', 'ANTPR')
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conMovCont.Cuenta_id 
INNER JOIN genMonedas ON 
genMonedas.genMonedas = conCuentas.Moneda_id 
INNER JOIn genEmpresas ON
genEmpresas.genEmpresas = @Empresa_Id AND 
genEmpresas.Moneda_Id != genMonedas.genMonedas
INNER JOIN genCancMovApliImpor ON
genCancMovApliImpor.conAsientos = conMovCont.conAsientos and 
genCancMovApliImpor.Renglon = conMovCont.Renglon and 
genCancMovApliImpor.EsDelAp = 1
WHERE 
	genCancMov.Importacion = 1 and 
	conAsientos.Anulado = 0 and 
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Fecha <= @Fecha 
GROUP BY comproveedores.Proveed_id, comProveedores.RazonSocial,
	conCuentas.Cuenta_id,  conCuentas.Descripcion, genMonedas.Moneda_id

	) as xxx
GROUP BY Proveed_id, RazonSocial, Cuenta_id, Descripcion, 
	Moneda_id	
ORDER BY 5,1


GO
-- aj traigo el revertido tambien si es que existe
DROP PROCEDURE comAsiCierreDatosCierre
GO
CREATE PROCEDURE comAsiCierreDatosCierre
(
@pFecha DateTime, 
@Empresa_Id Int
)
AS
SET NOCOUNT ON 

SELECT @pFecha as Fecha 



SELECT comAsiCierre.Asiento_Id , conAsientos.Empresa_Id, comAsiCierre.Fecha, 
	conAsientos.Anulado, genMonedas.Moneda_Id, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
FROM comAsiCierre 
INNER JOIN conAsientos  ON conAsientos.conAsientos = comAsiCierre.Asiento_Id
INNER JOIN genMonedas  ON genMonedas.genMonedas = comAsiCierre.Moneda_Id
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
inner join genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE comAsiCierre.Fecha between @pFecha  and DATEADD(dd,1,@pFecha) and 
conAsientos.Anulado = 0 and 
conAsientos.Empresa_Id = @Empresa_Id

 
RETURN @@Error 

GO
