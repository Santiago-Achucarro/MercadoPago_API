IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 6.00)
begin

INSERT INTO genVersion (Version) Values(6.00)
GO

ALTER TABLE comPagosAnticipo ADD comEmbarques BigInt
GO
ALTER TABLE comPagosAnticipo ADD FechaPago DateTime
GO

ALTER TABLE comPagosAnticipo add comPagosAnticipo BigInt Identity Not null
GO

ALTER TABLE comPagosAnticipo add Foreign Key (comEmbarques) References comEmbarques
GO

ALTER TABLE comPagosAnticipo drop Constraint XPKcomPagosAnticipo
GO
ALTER TABLE comPagosAnticipo add Constraint XPKcomPagosAnticipo Primary key (comPagosAnticipo)
GO

Create Index XicomPagosAnticipo  ON  comPagosAnticipo (Proveed_Id, Moneda_Id, Empresa_Id, tesMovimientos)
GO

ALTER TABLE comMovprovEmb drop constraint XPKcomMovProvEmb 
GO

ALTER TABLE comMovprovEmb add constraint XPKcomMovProvEmb Primary Key  (commovprov,comEmbarques)
end
GO




