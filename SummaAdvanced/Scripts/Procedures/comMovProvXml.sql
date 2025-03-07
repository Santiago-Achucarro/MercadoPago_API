-- comMovProvXmlDatos ' ', 'zzzz', '20200201','20200229', 'H',1
-- comMovprovXmlBuscarDatos ' ', 'zzzz', '20200201','20200229',1
drop procedure comMovProvXmlDatos
go
create procedure comMovProvXmlDatos
(
@pProveedorDesde varchar(16),
@pProveedorHasta varchar(15),
@pFechaDesde datetime,
@pFechaHasta datetime,
@pPendiende char,
@Empresa_Id int
)
as
select @pProveedorDesde as ProveedorDesde, @pProveedorHasta as ProveedorHasta,  @pFechaDesde as FechaDesde, @pFechaHasta as FechaHasta,
@pPendiende as Pendiente, '' as Upload, '' as lupXml

select comMovProv.comMovProv, XMLFiscal, Cuit, 
	cast(CASE WHEN ClaveFiscal is null or ClaveFiscal='' THEN 0 ELSE 1 END as bit) as Marca, 
		ClaveFiscal as UUID, 
		comProveedores.Proveed_Id , 
		dbo.Segmento(genAsiSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C,
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) Pago, 
		conAsientos.Fecha, comProveedores.RazonSocial, 
			comMovprov.Importe, genMonedas.Moneda_Id 
From comMovProv 
INNER JOIN genEntidades on genEntidades.genEntidades=comMovProv.Proveed_Id
INNER JOIN comProveedores on comProveedores.genEntidades=comMovProv.Proveed_Id 
INNER JOIN conAsientos ON conAsientos.conAsientos =comMovProv.comMovProv 
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovProv.comMovProv 
INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
Where 
conAsientos.Anulado = 0 and
conAsientos.Posteado = 1 and
conAsientos.Empresa_Id = @Empresa_Id and 
comMovProv.TipoMov='P' and 
comMovProv.VieneDeFiscal=1 and 
comProveedores.Proveed_Id BETWEEN @pProveedorDesde and @pProveedorHasta and
conAsientos.Fecha BETWEEN @pFechaDesde  and @pFechaHasta and 
(@pPendiende='H' or ClaveFiscal is null or ClaveFiscal='')
go

drop procedure comMovProvXmlGuardar
go
create procedure comMovProvXmlGuardar
(
@pcomMovProv bigint,
@pXml text,
@pUUID varchar(35),
@pRequiere Bit
)
as
update comMovProv set ClaveFiscal=@pUUID, XMLFiscal=@pXml, 
VieneDeFiscal =@pRequiere 
Where comMovProv=@pcomMovProv
go



DROP PROCEDURE comMovprovXmlBuscarDatos
GO
CREATE PROCEDURE comMovprovXmlBuscarDatos
(
@ProveedorDesde varchar(16),
@ProveedorHasta varchar(15),
@FechaDesde datetime,
@FechaHasta datetime,
@Empresa_Id int
)
as

select comMovProvP.comMovprov ,	comCFDISatPago.UUID, comCFDISat.Xml,genCancMov.Importe
from 
	tesMovimientos inner join genCancMov ON
		tesMovimientos.tesMovimientos = genCancMov.Asiento_Id 
	INNER JOIN comMovprov ON
		genCancMov.Asiento_Id_Ap =comMovprov.comMovProv
	inner join comMovProv  comMovProvp on comMovProvp.comMovProv = tesMovimientos.tesMovimientos
	left join comCFDISatPago ON uuidr = comMovProv.clavefiscal
	INNER JOIN comCFDISat on comCFDISat.uuid = comCFDISatPago.UUID
	INNER JOIN conAsientos ON conAsientos.conAsientos = tesMovimientos.tesMovimientos 
	INNER JOIN conAsientos conAsientosF ON conAsientosf.conAsientos = comMovprov.comMovprov
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovprov.Proveed_Id
	INNER JOIN genEntidades ON genEntidades .genEntidades = comProveedores.genEntidades

WHERE
	genEntidades.Cuit = comCFDISat.RFCEmisor and 
	conasientos.Anulado = 0 and 
	conasientosF.Anulado = 0 and 
	conAsientos.Fecha >= @FechaDesde and -- @FechaHasta and
	comProveedores.Proveed_Id Between @ProveedorDesde and @ProveedorHasta and 
	conasientos.Empresa_Id = @Empresa_Id and 
	comCFDISat.Subido = 0 /*and
	commovprovp.Importe = comCFDISat.Monto and 
	genCancMov.Importe = comCFDISatPago.Monto*/
GO

