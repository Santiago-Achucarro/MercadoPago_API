Update venClientes Set Regimen = IsNull((Select cValor From genGlobales Where Nombre_Var = 'FacturaCreditoClave27'), 'ADC') From genInstalacion Where genInstalacion.Dominio_Id = 'AR' And isNull(Regimen, '') = ''
Go
Insert Into genVersion (Version) Values (1098.10)
Go
