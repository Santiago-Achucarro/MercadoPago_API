Alter table venSubTipoMov Add PorCotizacion SiNo Default 0 not null
GO


CREATE Table venCotizFactura(
	venMovimientos BigInt NOT NULL, 
	venCotizaciones Int NOT NULL, 
	Primary key(venMovimientos)

)
GO

Alter table venCotizFactura Add Constraint FkvenCotizFacturaF 
	Foreign Key (venMovimientos) References venMovimientos

GO

Alter table venCotizFactura Add Constraint FkvenCotizFacturaC
	Foreign Key (venCotizaciones) References venCotizaciones

GO


insert into genVersion(Version) Values(587.00)
GO
