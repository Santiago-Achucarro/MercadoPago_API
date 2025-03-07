--impRetSussClie 1, '20220101','20220730'

Drop procedure impRetSussClie
Go
Create procedure impRetSussClie
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
AS

SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) RetClie
--- "a" es el resultado de una subconsulta así la puedo ordenar por fecha.

SELECT a.Renglon from (
SELECT SUBSTRING(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+SUBSTRING(genEntidades.Cuit,13,1)+
CONVERT(CHAR(8),conAsientos.Fecha,112)+'   '+
SUBSTRING(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+SUBSTRING(genEntidades.Cuit,13,1)+CONVERT(CHAR(4),conAsientos.Fecha,112)+
RIGHT(REPLICATE('0',10)+LTRIM(RTRIM(CONVERT(VARCHAR(10),tesRengMoviRetClie.ComprobanteRet))),10)+' '+
RIGHT(REPLICATE('0',15)+LTRIM(RTRIM(CONVERT(VARCHAR(15),CAST(ISNULL(conMovCont.Importe,0) AS DECIMAL(15,2)),1))),15) Renglon
FROM tesRengMovi 
	INNER JOIN tesMovimientos ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	INNER JOIN tesIdRetClien ON tesRengMovi.Cartera_Id = tesIdRetClien.Cartera_Id
	INNER JOIN tesIdentifica on tesIdRetClien.Cartera_Id = tesIdentifica.tesIdentifica
	INNER JOIN conMovCont on conMovcont.conAsientos = tesRengMovi.tesMovimientos AND 
		conMovcont.Renglon = tesRengMovi.conRenglon
	INNER JOIN tesRengMoviRetClie ON tesRengMoviRetClie.tesMovimientos = conMovcont.conAsientos AND 
		tesRengMoviRetClie.conRenglon = conMovcont.Renglon
	INNER JOIN conAsientos on tesMovimientos.tesMovimientos = conAsientos.conAsientos
	INNER JOIN venMovimientos ON tesMovimientos.tesMovimientos = venMovimientos.venMovimientos
	INNER JOIN venClientes ON venMovimientos.Cliente_Id = venClientes.genEntidades
	INNER JOIN genEntidades ON venClientes.genEntidades = genEntidades.genEntidades
WHERE conAsientos.fecha BETWEEN @pFechaDesde and @pFechaHasta AND 
	 conAsientos.Empresa_Id = @pEmpresa_Id AND
	 tesIdRetClien.TipoImpuesto = '2201' AND 
	 conAsientos.Anulado = 0) a	 
GO