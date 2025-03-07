
/****** Object:  Index [XPKvenMovImpTrasladado]    Script Date: 08/09/2020 17:21:29 ******/
ALTER TABLE [dbo].[venMovImpTraslado] DROP CONSTRAINT [XPKvenMovImpTrasladado]
GO

CREATE INDEX XIEvenMovImpTrasladado ON venMovImpTraslado (Asiento_Id, RenglonDebe)


insert into genVersion(Version) Values(609.00)
GO