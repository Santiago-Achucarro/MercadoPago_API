-- Inf_sueConceptos  0,9999,1
drop PROCEDURE Inf_sueConceptos 
go
CREATE PROCEDURE Inf_sueConceptos
(
	@ConceptoDesde Int,
	@ConceptoHasta Int,
	@Empresa_Id int

)

as

SELECT sueConceptos.Concepto_Id, sueConceptos.Descripcion, Formula, 
	ColumnaRecibo, Signo,
	TipoPercepcion, TipoDeduccion, TipoOtro, TipoHora, TipoIncapacidad, 
	conCuentasDebe.Cuenta_Id as CuentaDebe, conCuentasDebe.Descripcion as DescripcionCtaDebe,
	conCuentasHaber.Cuenta_Id as CuentaHaber, conCuentasHaber.Descripcion as DescripcionCtaHaber, 
	conSubcuentasDebe.SubCuenta_Id SubCuentaDebe, conSubcuentasDebe.Descripcion as DescripcionSubcuentasDebe,
	conSubcuentasHaber.SubCuenta_Id SubCuentaHaber, conSubcuentasHaber.Descripcion as DescripcionSubcuentasHaber
From sueConceptos
	left join conCuentas conCuentasDebe ON
		conCuentasDebe.concuentas = sueConceptos.CuentaDebe
	left join conCuentas conCuentasHaber ON
		conCuentasHaber.concuentas = sueConceptos.CuentaHaber
	left join conSubcuentas conSubcuentasDebe ON
		conSubcuentasDebe.consubcuentas = sueConceptos.SubCuentaDebe
	left join conSubcuentas conSubcuentasHaber ON
		conSubcuentasHaber.consubcuentas = sueConceptos.SubCuentaHaber
Where
	sueConceptos.Concepto_Id BETWEEN @ConceptoDesde and @ConceptoHasta 
order by 1