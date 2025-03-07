DROP PROCEDURE impPercMisiones
GO
CREATE PROCEDURE impPercMisiones
(
@pEmpresa_Id int,
@pFechaDesde datetime,
@pFechaHasta datetime
)
As
--substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)
SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta, Cast(0 As bit) Retenciones, Cast(0 As bit) Percepciones
SELECT REPLACE(CONVERT(CHAR(10),conAsientos.Fecha,103),'/','-')+','+
CASE genasisegmentos.segmento1C WHEN 'F' THEN genasisegmentos.segmento1C+'A'+'_'+genasisegmentos.segmento3C 
WHEN 'I' THEN 'FCE'+'_'+genasisegmentos.segmento3C 
WHEN 'D' THEN 'N'+'D'+'_'+genasisegmentos.segmento3C 
WHEN 'B' THEN 'NDE'+'_'+genasisegmentos.segmento3C 
WHEN 'R' THEN 'N'+'C'+'_'+genasisegmentos.segmento3C 
WHEN 'E' THEN 'NCE'+'_'+genasisegmentos.segmento3C 
ELSE 'OTRO' END + ','+
RIGHT(Ltrim(Rtrim(genAsiSegmentos.Segmento2C)),4)+RIGHT(REPLICATE('0',10)+RIGHT(Ltrim(Rtrim(convert(varchar(10),genAsiSegmentos.Segmento1N))),10),10)+','+
Left(lTrim(rTrim(venClientes.RazonSocial))+Replicate(' ',100),100)+','+
substring(genEntidades.Cuit,1,2)+SUBSTRING(genEntidades.Cuit,4,8)+substring(genEntidades.Cuit,13,1)+','+
RIGHT(replicate('0',15)+ltrim(rtrim(convert(varchar(20),cast(ISNULL(venMovimpuestos.BaseImponibleMonedaNac,0) as decimal(15,2)),1))),15)+','+
RIGHT(replicate('0',5)+ltrim(rtrim(convert(varchar(5),cast(ISNULL(venMovimpuestos.Porcentaje,0) as decimal(5,2)),1))),5) Registro
From venMovImpuestos
inner join venmovimientos on venmovimpuestos.venMovimientos = venMovimientos.venMovimientos 
inner join genentidades on venmovimientos.Cliente_Id= genEntidades.genEntidades
INNER JOIN VENCLIENTES ON genEntidades.genEntidades = venClientes.genEntidades
inner join venImpuestos on venmovimpuestos.Impuesto_Id = venImpuestos.venImpuestos
inner join conmovcont on venmovimpuestos.venMovimientos = conmovcont.conAsientos and venmovimpuestos.conRenglon = conmovcont.Renglon
inner join conasientos on venmovimpuestos.venmovimientos = conasientos.conasientos 
inner join genasisegmentos on genasisegmentos.asiento_id = conAsientos.conasientos
inner join venTipomov on venMovimientos.venTipoMov = ventipomov.venTipoMov
Where 
conMovcont.Importe > 0 AND 
venImpuestos.TipoImpuesto = 1914 and  
conAsientos.Anulado = 0 AND 
conAsientos.Posteado = 1 AND
conasientos.fecha BETWEEN @pFechaDesde And @pFechaHasta AND
conAsientos.empresa_Id = @pEmpresa_Id
GO


