-- AfiActivoFijoXLSCatalogo ' ','A' 

drop procedure AfiActivoFijoXLSCatalogo
go
create procedure AfiActivoFijoXLSCatalogo
(
    @pActivoFijoDesde varchar(15),
    @pActivoFijoHasta varchar(15), 
	@pEmpresa_Id int
)
as
select @pActivoFijoDesde as ActivoFijoDesde, @pActivoFijoHasta as ActivoFijoHasta
select ActivoFijo_Id, afiActivoFijo.Descripcion, FechaAlta, FechaIniDepre, isnull(FechaBaja,'') FechaBaja, ValorInicial, VidaUtil, VidaUtilRestante, PorResidual, AmortAcumulada,
afiActivoFijo.Rubro_Id, Cantidad, CtaValorOrigen.Cuenta_Id as CtaValorOrigen_Id, CtaAmortAcum.Cuenta_Id as CtaAmortAcum_Id, CtaAmortizacion.Cuenta_Id as CtaAmortizacion_Id
from afiActivoFijo
inner join conCuentas CtaValorOrigen on CtaValorOrigen.conCuentas=afiActivoFijo.CtaValorOrigen_Id
inner join conCuentas CtaAmortAcum on CtaAmortAcum.conCuentas=afiActivoFijo.CtaAmortAcum_Id
inner join conCuentas CtaAmortizacion on CtaAmortizacion.conCuentas=afiActivoFijo.CtaAmortizacion_Id
WHERE
	afiActivoFijo.Empresa_Id = @pEmpresa_Id AND 
	afiActivoFijo.ActivoFijo_Id BETWEEN @pActivoFijoDesde AND @pActivoFijoHasta
order by 1

select afiActivoFijo.ActivoFijo_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id, Porcentaje from afiCentros
inner join afiActivoFijo on afiActivoFijo.afiActivoFijo=afiCentros.ActivoFijo_Id
inner join conCentro1 on conCentro1.conCentro1=afiCentros.Centro1_Id
inner join conCentro2 on conCentro2.conCentro2=afiCentros.Centro2_Id
where
	afiActivoFijo.Empresa_Id = @pEmpresa_Id AND 
	afiActivoFijo.ActivoFijo_Id BETWEEN @pActivoFijoDesde AND @pActivoFijoHasta
Order by 1


select afiActivoFijo.ActivoFijo_Id, AfiResponsables.Responsable_Id, afiResponsableActivo.Cantidad 
	from afiResponsableActivo
inner join afiActivoFijo on afiActivoFijo.afiActivoFijo=afiResponsableActivo.ActivoFijo_Id
inner join AfiResponsables on AfiResponsables.AfiResponsables=afiResponsableActivo.Responsable_Id
where
	afiActivoFijo.Empresa_Id = @pEmpresa_Id AND 
	afiActivoFijo.ActivoFijo_Id BETWEEN @pActivoFijoDesde AND @pActivoFijoHasta
Order by 1

GO
