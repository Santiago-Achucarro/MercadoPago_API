IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 5.00)
begin

INSERT INTO genVersion (Version) Values(5.00)

ALTER TABLE comMovprovEmb Drop Constraint R_3826
ALTER TABLE comMovprovEmb Drop Constraint XPKcomMovProvEmb
ALTER TABLE comMovProvEmb DROP COLUMN Renglon_OC
ALTER TABLE comMovProvEmb DROP COLUMN Cantidad
ALTER TABLE comMovProvEmb DROP COLUMN comOrdenComp

GO

ALTER TABLE comMovprovEmb add constraint XPKcomMovProvEmb Primary Key  (commovprov)
GO

ALTER TABLE comMovprovEmb ADD Constraint R_3826 foreign key (comEmbarques) 
	references comEmbarques
end
GO

