INSERT INTO  tesSubTiposMov (SubTipo_Id, Descripcion, TipoMov, CantCopias, genReportes) VALUES('PAS','Pago_de_Sueldos','E',1,NULL)

INSERT INTO tesIdentifica(Cartera_Id, Empresa_Id, TipoCartera, Descripcion, Cuenta_Id, Centro1_Id, Centro2_Id,
	Moneda_Id, UsuarioAmo, ModiCent1, ModiCent2, CtaValEnTransito, Reservado, VaAlCashFlow ,Inactivo, Usuario_Id, Posteado, FormaDePagoP) 
values('SUE',NULL, 9, 'Sueldos', NULL, 1,1,NULL,  NULL, 0,0,NULL,1,0,0,1,1,'01')

GO


insert into genVersion(Version) Values(555.00)
GO