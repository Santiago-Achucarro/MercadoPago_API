Update venMovImpuestos   set BaseImponibleMonedaNac = BaseImponible
where  BaseImponible != BaseImponibleMonedaNac and 
	exists(select 1 from conAsientos, genEmpresas where
		conAsientos.conAsientos = venMovImpuestos.venMovimientos and 
		genEmpresas.genEmpresas = conAsientos.Empresa_Id and
		conAsientos.Moneda_Id = genEmpresas.Moneda_Id and 
		conAsientos.Posteado =1)  And venMovImpuestos.BaseImponible <> venMovImpuestos.BaseImponibleMonedaNac
Go

Insert Into genVersion (Version) Values (611.10)
Go