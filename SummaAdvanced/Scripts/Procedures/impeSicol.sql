DROP PROCEDURE impeSicol
GO
CREATE PROCEDURE impeSicol
(
@pEmpresa_Id INT,
@pFechaDesde DATETIME,
@pFechaHasta DATETIME
)
AS

SELECT @pFechaDesde FechaDesde, @pFechaHasta FechaHasta

Select genEntidades.Cuit, genAsiSegmentos.Segmento1N Comprobante, conAsientos.Fecha, genAsiSegmentos.Segmento1C Sucursal,
	comMovImpuestos.Base_Imponible * conAsientos.Cambio BaseImponible, conMovCont.Importe,
	genAsiSegmentos.Segmento2C TipoMov, genAsiSegmentos.Segmento4C Letra, comMovProv.comMovProv
From comMovProv
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Inner Join comProveedores On comMovProv.Proveed_Id = comProveedores.genEntidades
Inner Join genEntidades On genEntidades.genEntidades = comProveedores.genEntidades
Inner Join conAsientos On conAsientos.conAsientos = comMovProv.comMovProv
Inner Join comMovImpuestos On comMovImpuestos.comMovProv = comMovProv.comMovProv
Inner Join conMovCont On conMovCont.conAsientos = comMovImpuestos.comMovProv And conMovCont.Renglon = comMovImpuestos.conRenglon
Inner Join comImpuestos On comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
Where conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And comImpuestos.TipoImpuesto = 1901 And
conAsientos.Empresa_Id = @pEmpresa_Id And comMovProv.FechaFiscal Between @pFechaDesde And @pFechaHasta
Go


