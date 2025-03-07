-- exec venClientesXLSCatalogo '','ZZZZZZ'
-- exec venClientesXLSCatalogo '35000','35001'
drop Procedure venClientesXLSCatalogo
go
create Procedure venClientesXLSCatalogo
(
    @pClienteDesde varchar(15),
    @pClienteHasta varchar(15)
)
as
select @pClienteDesde as ClienteDesde, @pClienteHasta as ClienteHasta
select Cliente_Id, genEntidades.Cuit as ClaveFiscal, genEntidades.TipoDoc, genEntidades.IdFiscal, case when venClientes.Empresa_Id is null then 1 else 0 end as PTodasEmpresas,
RazonSocial, SucursalPredeter, venCondFiscal.CondFisc_Id, LimiteCredito, MonedaLimCred.Moneda_Id MonedaLimCred,
venCategCredito.CategCred_Id, Bonificacion1, Bonificacion2, Bonificacion3, Puntual,
ISNULL(venClieEstados.Estado_Id,' ') AS Estado_Id, GeneraDebito, Siempre, CongelaCambio, IBrutos, Regimen, Situacion, venClientes.Posteado
from venClientes
inner join genEntidades on genEntidades.genEntidades=venClientes.genEntidades
inner join venCondFiscal on venCondFiscal.venCondFiscal=venClientes.CondFisc_Id
inner join genMonedas MonedaLimCred on MonedaLimCred.genMonedas=venClientes.MonedaLimCred
inner join venCategCredito on venCategCredito.venCategCredito=venClientes.CategCred_Id
left join venClieEstados on venClieEstados.venClieEstados=venClientes.Estado_Id
where venClientes.Cliente_Id BETWEEN @pClienteDesde and @pClienteHasta

select venClientes.Cliente_Id, Sucursal, NombreFantasia, Direccion1_Fact, Direccion2_Fact,
Localidad_Fact, CodPostal_Fact, ProvinciaFact.Provincia_Id as Provincia_Id_Fact, PaisFact.Pais_Id as Pais_Id_Fact,
Telefonos, Fax, venClieHabitual.EMail, Direccion1_Entr, Direccion2_Entr, Localidad_Entr, CodPostal_Entr,
ProvinciaEntr.Provincia_Id as Provincia_Id_Entr, PaisEntr.Pais_Id as Pais_Id_Entr,
venTiposClie.TipoClie_Id, venListasPrecios.ListaPrecio_Id, venFormaEntrega.FormaEntrega_Id,
venCondPago.CondPagoCli_Id, venVendedores.Vendedor_Id, venCobradores.Cobrador_Id, venZona.Zona_Id,
venRegion.Region_Id, Contactos, venClieHabitual.Inactivo, isnull(Observaciones,' ') Observaciones, venClieHabitual.Bonificacion1 as BonificacionS1, venClieHabitual.Bonificacion2 as BonificacionS2,
venClieHabitual.Bonificacion3 as BonificacionS3, ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, 
ISNULL(conCentro2.Centro2_Id,' ') Centro2_Id, NroExterior_Fact, NroInterior_Fact,
NroExterior_Entr, NroInterior_Entr, Reclamos, MetodoDePago , venClientes.Posteado 
from venClieHabitual
inner join venClientes on venClieHabitual.genEntidades=venClientes.genEntidades
inner join genProvincias ProvinciaFact on ProvinciaFact.genProvincias=venClieHabitual.Provincia_Id_Fact
inner join genPaises PaisFact on PaisFact.genPaises=venClieHabitual.Pais_Id_Fact
inner join genPaises PaisEntr on PaisEntr.genPaises=venClieHabitual.Pais_Id_Entr
inner join genProvincias ProvinciaEntr on ProvinciaEntr.genProvincias=venClieHabitual.Provincia_Id_Entr
inner join venTiposClie on venTiposClie.venTiposClie=venClieHabitual.TipoClie_Id
inner join venListasPrecios on venListasPrecios.venListasPrecios=venClieHabitual.ListaPrecio_Id
inner join venFormaEntrega on venFormaEntrega.venFormaEntrega=venClieHabitual.FormaEntrega_Id
inner join venCondPago on venCondPago.venCondPago=venClieHabitual.CondPagoCli_Id
inner join venVendedores on venVendedores.venVendedores=venClieHabitual.Vendedor_Id
inner join venCobradores on venCobradores.venCobradores=venClieHabitual.Cobrador_Id
inner join venZona on venZona.venZona=venClieHabitual.Zona_Id
inner join venRegion on venRegion.venRegion=venClieHabitual.Region_Id
left join conCentro1 on conCentro1.conCentro1=venClieHabitual.Centro1_Id
left join conCentro2 on conCentro2.conCentro2=venClieHabitual.Centro2_Id
where venClientes.Cliente_Id BETWEEN @pClienteDesde and @pClienteHasta

select venClientes.Cliente_Id, genMonedas.Moneda_Id, CuentaDxVtas.Cuenta_Id as CuentaDxVtas,
CtaFactAnticipo.Cuenta_Id as CtaFactAnticipo, 
CtaAnticipo.Cuenta_Id as CtaAnticipo
from venClientesCtas
inner join venClientes on venClientes.genEntidades=venClientesCtas.Cliente_Id
inner join genMonedas on genMonedas.genMonedas=venClientesCtas.Moneda_Id
inner join conCuentas CuentaDxVtas on CuentaDxVtas.conCuentas=venClientesCtas.CuentaDxVtas
inner join conCuentas CtaFactAnticipo on CtaFactAnticipo.conCuentas=venClientesCtas.CtaFactAnticipo
inner join conCuentas CtaAnticipo on CtaAnticipo.conCuentas=venClientesCtas.CtaAnticipo
where venClientes.Cliente_Id BETWEEN @pClienteDesde and @pClienteHasta

SELECT venClientes.Cliente_Id, impJurisdicciones.Juris_Id, genJurisCoeficientes.Situacion, Coeficiente, Exencion, isnull(FechaHasta,'') FechaHasta
from genJurisCoeficientes
inner join venClientes on venClientes.genEntidades=genJurisCoeficientes.genEntidades
inner join impJurisdicciones on impJurisdicciones.impJurisdicciones=genJurisCoeficientes.Juris_Id
where venClientes.Cliente_Id BETWEEN @pClienteDesde and @pClienteHasta

SELECT venClientes.Cliente_Id, venClieContacto.Sucursal, venClieContacto.NroContacto, 
	venClieContacto.Nombre, venClieContacto.Email, venClieContacto.Telefono,venClieContacto.Interno, 
	venClieContacto.Puesto, 
venClieContacto.EnviaFacturas, venClieContacto.EnviaPedido, venClieContacto.EnviaRecibo, 
venClieContacto.Inactivo, venClieContacto.Movil, venClieContacto.Observaciones 
FROM venClientes INNER JOIN venClieContacto ON
	venClientes.genEntidades =venClieContacto.Cliente_Id 
Where venClientes.Cliente_Id BETWEEN @pClienteDesde and @pClienteHasta
GO

