CREATE TABLE venCotizFactuCuerpo(
	venMovimientos bigint,
	RenglonCuerpo int, 
	venCotizaciones int, 
	Renglon_Co int, 
	Cantidad QCantidadD8 NOT NULL, 
	Primary Key(venMovimientos, RenglonCuerpo) 
)
GO

ALTER TABLE venCotizFactuCuerpo ADD Constraint FkvenCotizFactuCuerpoVM 
	Foreign Key (venMovimientos,	RenglonCuerpo ) References venMovConStockCr
GO

ALTER TABLE venCotizFactuCuerpo ADD Constraint FkvenCotizFactuCuerpoCoti 
	Foreign Key (venCotizaciones,	Renglon_Co ) References venCotizCuerpo
GO


CREATE TABLE venCotizPediCuerpo(
	venPedidos int,
	Renglon_Pe int, 
	venCotizaciones int, 
	Renglon_Co int, 
	Cantidad QCantidadD8 NOT NULL, 
	Primary Key(venPedidos, Renglon_Pe) 
)
GO

ALTER TABLE venCotizPediCuerpo ADD Constraint FkvenCotizPediCuerpoPed
	Foreign Key (venPedidos, Renglon_Pe ) References venPediCuerpo
GO

ALTER TABLE venCotizPediCuerpo ADD Constraint FKvenCotizPediCuerpoCoti 
	Foreign Key (venCotizaciones,	Renglon_Co ) References venCotizCuerpo
GO

insert into genVersion (Version) Values(589.00)
GO

