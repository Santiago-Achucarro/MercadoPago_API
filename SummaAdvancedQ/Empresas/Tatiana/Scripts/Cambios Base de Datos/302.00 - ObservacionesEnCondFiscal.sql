CREATE TABLE espvenCondFiscImpTest
( 
	venCondFiscal        integer  NOT NULL ,
	venImpuestos         integer  NOT NULL ,
	Observacion			 Varchar(max) NOT NULL,	
	CONSTRAINT XPKespvenCondFiscImpTest PRIMARY KEY  CLUSTERED (venCondFiscal ASC,venImpuestos ASC)
)
go

ALTER TABLE espvenCondFiscImpTest
	ADD CONSTRAINT espvenCondFiscal FOREIGN KEY (venCondFiscal,venImpuestos) REFERENCES venCondFiscImp(venCondFiscal,venImpuestos)
GO