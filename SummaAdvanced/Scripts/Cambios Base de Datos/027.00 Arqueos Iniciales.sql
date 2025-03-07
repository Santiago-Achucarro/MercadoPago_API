IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 27.00)
begin


CREATE TABLE tesAICheques
( 
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	FechaVencimiento     datetime  NOT NULL ,
	Chequera_Id          int  NULL ,
	numCheque            integer  NOT NULL ,
	AlaOrden             varchar(120)  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKtesAICheques PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Empresa_Id ASC,Renglon ASC)
);



CREATE TABLE tesAIDepositos
( 
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	Renglon              integer  NOT NULL ,
	numCheque            integer  NOT NULL ,
	CarteraCheq_Id       integer  NOT NULL ,
	FechaVencimiento     datetime  NOT NULL ,
	Importe              qMonedaD2 ,
	Clearing             varchar(3)  NOT NULL ,
	Banco_Id             integer  NOT NULL ,
	Cliente_Id           bigint  NULL ,
	cuentaBanco          varchar(15)  NOT NULL ,
	sucBanco             varchar(15)  NOT NULL ,
	CONSTRAINT XPKtesAIDepositos PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Empresa_Id ASC,Renglon ASC)
);


CREATE TABLE tesAISaldos
( 
	Cartera_Id           integer  NOT NULL ,
	Empresa_Id           integer  NOT NULL ,
	SaldoInicial         qMonedaD2 ,
	Cambio               qMonedaD4 ,
	Usuario_Id           integer  NULL ,
	FechaRegistro        datetime  NOT NULL ,
	Confirmado			 SiNo,
	CONSTRAINT XPKtesAISaldos PRIMARY KEY  CLUSTERED (Cartera_Id ASC,Empresa_Id ASC)
);


ALTER TABLE tesAICheques
	ADD CONSTRAINT R_3981 FOREIGN KEY (Cartera_Id,Empresa_Id) REFERENCES tesAISaldos(Cartera_Id,Empresa_Id);





ALTER TABLE tesAICheques
	ADD CONSTRAINT R_3983 FOREIGN KEY (Chequera_Id,Cartera_Id,Empresa_Id) REFERENCES tesChequeras(Chequera_Id,Cartera_Id,Empresa_Id);





ALTER TABLE tesAIDepositos
	ADD CONSTRAINT R_3984 FOREIGN KEY (Cartera_Id,Empresa_Id) REFERENCES tesAISaldos(Cartera_Id,Empresa_Id);





ALTER TABLE tesAIDepositos
	ADD CONSTRAINT R_3985 FOREIGN KEY (CarteraCheq_Id) REFERENCES tesIdCheqTerceros(Cartera_Id);




ALTER TABLE tesAIDepositos
	ADD CONSTRAINT R_3986 FOREIGN KEY (Clearing) REFERENCES tesClearing(Clearing);




ALTER TABLE tesAIDepositos
	ADD CONSTRAINT R_3987 FOREIGN KEY (Banco_Id) REFERENCES tesBancos(tesBancos);




ALTER TABLE tesAIDepositos
	ADD CONSTRAINT R_3988 FOREIGN KEY (Cliente_Id) REFERENCES venClientes(genEntidades);




ALTER TABLE tesAISaldos
	ADD CONSTRAINT R_3979 FOREIGN KEY (Cartera_Id) REFERENCES tesIdentifica(tesIdentifica);




ALTER TABLE tesAISaldos
	ADD CONSTRAINT R_3980 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios);




ALTER TABLE tesAISaldos
	ADD CONSTRAINT R_3982 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas);



INSERT INTO genVersion(Version) Values(27.00);

end


