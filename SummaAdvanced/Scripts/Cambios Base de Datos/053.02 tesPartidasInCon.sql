insert into genVersion (Version) values (53.02)
CREATE TABLE tesPartidasInCon
(
    Cartera_Id int NOT NULL,
    Fecha datetime not NULL,
	Comprobante int not null,
	Debe_Haber int not null,
	Importe qMonedaD2 NOT NULL,
	Empresa_Id int NOT NULL,
	foreign key(Cartera_Id) references tesIdentifica(tesIdentifica),
	foreign key(Empresa_Id) references genEmpresas(genEmpresas),
	primary key (Cartera_Id, Fecha, Comprobante)
);