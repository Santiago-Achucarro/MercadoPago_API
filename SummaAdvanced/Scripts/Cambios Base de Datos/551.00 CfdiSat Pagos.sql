Alter table comCFDISat add TipoDeComprobante Char(1)
GO

CREATE TABLE comCFDISatPago
( 
	UUID                 char(36)  NOT NULL ,
	Renglon              integer  NOT NULL ,
	UUIDR                varchar(36)  NOT NULL ,
	Monto                qMonedaD2 ,
	Moneda               varchar(3)  NOT NULL ,
	CONSTRAINT XPKcomCFDISatPago PRIMARY KEY  CLUSTERED (UUID ASC,Renglon ASC)
)
go


ALTER TABLE comCFDISatPago
	ADD CONSTRAINT V2R_4449 FOREIGN KEY (UUID) REFERENCES comCFDISat(UUID)
go


INSERT INTO genVersion (Version) Values(551.00)
GO

