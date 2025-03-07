
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 24.00)
begin

INSERT INTO genVersion(Version) Values(24.00);

CREATE TABLE venPediFacturados
( 
	venMovimientos       bigint  NOT NULL ,
	venPedidos           integer  NOT NULL ,
	Importe              qMonedaD2 ,
	CONSTRAINT XPKvenPediFacturados PRIMARY KEY  CLUSTERED (venMovimientos ASC)
);



ALTER TABLE venPediFacturados
	ADD CONSTRAINT R_3976 FOREIGN KEY (venPedidos) REFERENCES venPedidos(venPedidos);

ALTER TABLE venPediFacturados
	ADD CONSTRAINT R_3977 FOREIGN KEY (venMovimientos) REFERENCES venMovimientos(venMovimientos);

end

