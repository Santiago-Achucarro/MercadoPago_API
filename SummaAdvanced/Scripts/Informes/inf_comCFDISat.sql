--exec inf_comCFDISat '20220101','20220131',1,0
drop procedure inf_comCFDISat
go
create procedure inf_comCFDISat
(
    @FechaDesde datetime,
    @FechaHasta datetime,
    @Subidos SiNo,
    @Empresa_Id int
)
as
select UUID, RFCEmisor, Fecha, Monto, Folio, Serie, isnull(FechaCarga,' ') FechaCarga ,
case when TipoDeComprobante='E' then 'Egreso' when TipoDeComprobante='I' then 'Ingreso' when TipoDeComprobante='P' then 'Pago' else TipoDeComprobante end as TipoDeComprobante 
, vcomProveedores.Proveed_Id, vcomProveedores.RazonSocial
from comCFDISat
left join vComproveedores on comCFDISat.RFCEmisor = vComproveedores.CUIT
where 
Fecha between @FechaDesde and @FechaHasta and 
	@Subidos=Subido and 
	isnull(comCFDISat.Empresa_Id, @Empresa_Id)=@Empresa_Id
go