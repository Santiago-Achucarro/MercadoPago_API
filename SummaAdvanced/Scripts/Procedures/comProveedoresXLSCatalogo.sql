-- EXEC  comProveedoresXLSCatalogo ' ','ZZZ'
drop procedure comProveedoresXLSCatalogo
go
create procedure comProveedoresXLSCatalogo
(
    @pProveedorDesde varchar(15),
    @pProveedorHasta varchar(15)
)
as
select @pProveedorDesde as ProveedorDesde, @pProveedorHasta as ProveedorHasta

select Proveed_Id, genEntidades.Cuit as ClaveFiscal, TipoDoc, idFiscal
,case when comProveedores.Empresa_Id is null then 1 else 0 END as PTodasEmpresas,
RazonSocial, NombreLegal, Direccion1, Direccion2, Localidad, CodigoPostal, genProvincias.Provincia_Id,
genPaises.Pais_Id, Telefono, comRegiones.Region_Id, comConPago.CondPago_Id, comForEntre.FormaEnt_Id,
Contacto, EMail, Fax, Letra_Fact, Observaciones, comCondFiscal.CondFiscal_Id, Ganancias,
IBrutos, comOrigenesFiscales.Origen_Id, EsAduana, TipoCuenta, NroCuenta, CBU, tesBancos.Banco_Id,
comProveedores.Inactivo, comProvTipos.ProvTipo_Id
from comProveedores
inner join genEntidades on genEntidades.genEntidades=comProveedores.genEntidades
inner join genProvincias on genProvincias.genProvincias=comProveedores.Provincia_Id
inner join genPaises on genPaises.genPaises=comProveedores.Pais
inner join comRegiones on comRegiones.comRegiones=comProveedores.Region_Id
inner join comConPago on comConPago.comConPago=comProveedores.CondPago_Id
inner join comForEntre on comForEntre.comForEntre=comProveedores.FormaEnt_Id
inner join comCondFiscal on comCondFiscal.comCondFiscal=comProveedores.CondFiscal_Id
inner join comOrigenesFiscales on comOrigenesFiscales.comOrigenesFiscales=comProveedores.Origen_Id
inner join comProvTipos on comProvTipos.comProvTipos=comProveedores.ProvTipo_Id
left join tesBancos on tesBancos.tesBancos=comProveedores.Banco_Id
where comProveedores.Proveed_Id between @pProveedorDesde and @pProveedorHasta

select comProveedores.Proveed_Id, TipoCtaProv, genMonedas.Moneda_Id, conCuentas.Cuenta_Id, 
ctaPagoXAdelantado.Cuenta_Id ctaPagoXAdelantado, CtaAnticipo.Cuenta_Id as CtaAnticipo
from comProveedoresCtasPasivo
inner join comProveedores on comProveedores.genEntidades=comProveedoresCtasPasivo.genEntidades
inner join genMonedas on genMonedas.genMonedas=comProveedoresCtasPasivo.Moneda_Id
inner join conCuentas on conCuentas.conCuentas=comProveedoresCtasPasivo.Cuenta_Id
inner join conCuentas ctaPagoXAdelantado on ctaPagoXAdelantado.conCuentas=comProveedoresCtasPasivo.ctaPagoXAdelantado
inner join conCuentas CtaAnticipo on CtaAnticipo.conCuentas=comProveedoresCtasPasivo.CtaAnticipo
where comProveedores.Proveed_Id between @pProveedorDesde and @pProveedorHasta

select comProveedores.Proveed_Id, conCuentas.Cuenta_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, comProvCtasContrap.Detalle
from comProvCtasContrap
inner join conCuentas on conCuentas.conCuentas=comProvCtasContrap.Cuenta_Id
inner join comProveedores on comProveedores.genEntidades=comProvCtasContrap.Proveed_Id
inner join conCentro1 on conCentro1.conCentro1=comProvCtasContrap.Centro1_Id
inner join conCentro2 on conCentro2.conCentro2=comProvCtasContrap.Centro2_Id
where comProveedores.Proveed_Id between @pProveedorDesde and @pProveedorHasta

select comProveedores.Proveed_Id, impImpuestos.Impuesto_Id from comProveedoresImpuestos
inner join comProveedores on comProveedores.genEntidades=comProveedoresImpuestos.Proveed_Id
inner join impImpuestos on impImpuestos.impImpuestos=comProveedoresImpuestos.Impuesto_Id
where comProveedores.Proveed_Id between @pProveedorDesde and @pProveedorHasta

select comProveedores.Proveed_Id, impJurisdicciones.Juris_Id, Situacion, Coeficiente, Exencion, ISNULL(FechaHasta,'') FechaHasta
from genJurisCoeficientes
inner join comProveedores on comProveedores.genEntidades=genJurisCoeficientes.genEntidades
inner join impJurisdicciones on impJurisdicciones.impJurisdicciones=genJurisCoeficientes.Juris_Id
WHERE comProveedores.Proveed_Id between @pProveedorDesde and @pProveedorHasta

select comProveedores.Proveed_Id, tesIdentifica.Cartera_Id, Exencion, ISNULL(FechaHasta,'') FechaHasta
from comProveedoresRetencion
inner join comProveedores on comProveedores.genEntidades=comProveedoresRetencion.Proveed_Id
inner join tesIdentifica on tesIdentifica.tesIdentifica=comProveedoresRetencion.Cartera_Id
where comProveedores.Proveed_Id between @pProveedorDesde and @pProveedorHasta
go
