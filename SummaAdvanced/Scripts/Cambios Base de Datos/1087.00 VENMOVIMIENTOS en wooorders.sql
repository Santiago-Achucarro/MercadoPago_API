if not exists(select 1 from sysColumns inner join sysobjects on   sysColumns.id = sysobjects.id and
	sysobjects.name = 'wooOrders' and syscolumns.name = 'venMovimientos')

	alter table wooOrders add venMovimientos bigint
GO

INSERT INTO genVersion(Version) Values(1087.00)
