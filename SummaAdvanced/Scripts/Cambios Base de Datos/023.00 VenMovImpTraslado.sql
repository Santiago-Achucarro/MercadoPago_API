
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 23.00)
begin

INSERT INTO genVersion(Version) Values(23.00);


drop TABLE venMovImpTraslado;

CREATE TABLE venMovImpTraslado
( 
	Asiento_Id           bigint  NOT NULL ,
	RenglonDebe          integer  NOT NULL ,
	RenglonHaber         integer  NULL ,
	venMovimientos       bigint  NULL ,
	tesMovimientos       bigint  NULL ,
	Impuesto_Id          integer  NOT NULL ,
	Cliente_Id           bigint  NOT NULL ,
	Cartera_Id           integer  NOT NULL ,
	Banco_Id             integer  NULL ,
	BaseImponible        qMonedaD2 ,
	Monto                qMonedaD2 ,
	TotalCobro           qMonedaD2 ,
	CONSTRAINT XPKvenMovImpTrasladado PRIMARY KEY  CLUSTERED (Asiento_Id ASC,RenglonDebe ASC)
);



ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3435 FOREIGN KEY (Asiento_Id) REFERENCES conAsientos(conAsientos);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3436 FOREIGN KEY (venMovimientos) REFERENCES venMovimientos(venMovimientos);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3437 FOREIGN KEY (tesMovimientos) REFERENCES tesMovimientos(tesMovimientos);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3438 FOREIGN KEY (Impuesto_Id) REFERENCES venImpuestos(venImpuestos);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3692 FOREIGN KEY (Cliente_Id) REFERENCES venClientes(genEntidades);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3694 FOREIGN KEY (Cartera_Id) REFERENCES tesIdentifica(tesIdentifica);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3695 FOREIGN KEY (Banco_Id) REFERENCES tesIdBancoPropio(Cartera_Id);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3974 FOREIGN KEY (Asiento_Id,RenglonDebe) REFERENCES conMovCont(conAsientos,Renglon);

ALTER TABLE venMovImpTraslado
	ADD CONSTRAINT R_3975 FOREIGN KEY (Asiento_Id,RenglonHaber) REFERENCES conMovCont(conAsientos,Renglon);

Alter table venAsiCierre drop column Cambio; 

END
