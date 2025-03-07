
Create table espVenCotizacionResumidaKSK(
	venCotizaciones Int NOT NULL,
	Cantidad Numeric(18,4)  NOT NULL, 
	Medida_Id Int NOT NULL,	
	Leyenda VarChar(MAX) NOT NULL,
	ValorUnitario Numeric(18,4) NOT NULL, 
	ClaveFiscal varChar(8) NOT NULL, 
	Primary key(venCotizaciones)
)
GO
	
Alter table espVenCotizacionResumidaKSK add Constraint 
	SKVenCotizacionResumidaCotiKSK Foreign Key (venCotizaciones)
	REFERENCES venCotizaciones
	ON DELETE CASCADE
GO


Alter table espVenCotizacionResumidaKSK add Constraint 
	FkespVenCotizacionResumidaUMKSK Foreign Key (Medida_Id)
	REFERENCES stkUniMed



Create table espvenPedidosResumidaKSK(
	venPedidos Int NOT NULL,
	Cantidad Numeric(18,4)  NOT NULL, 
	Medida_Id Int NOT NULL,
	Leyenda VarChar(MAX) NOT NULL,
	ValorUnitario Numeric(18,4) NOT NULL, 
	ClaveFiscal varChar(8) NOT NULL, 
	Primary key(venPedidos)
)
GO
	
Alter table espvenPedidosResumidaKSK add Constraint 
	FkespvenPedidosPediKSK Foreign Key (venPedidos)
	REFERENCES venPedidos
	ON DELETE CASCADE
GO

Alter table espvenPedidosResumidaKSK add Constraint 
	espvenPedidosResumidaUMKSK Foreign Key (Medida_Id)
	REFERENCES stkUniMed

Create table espVenMovimientosResuKSK(
	venMovimientos bigInt NOT NULL,
	Cantidad Numeric(18,4)  NOT NULL, 
	Medida_Id Int NOT NULL,
	Leyenda VarChar(MAX) NOT NULL,
	ValorUnitario Numeric(18,4) NOT NULL, 
	ClaveFiscal varChar(8) NOT NULL, 
	Primary key(venMovimientos)
)
GO
	
Alter table espVenMovimientosResuKSK add Constraint 
	FkespVenMovimientosResuKSK Foreign Key (venMovimientos)
	REFERENCES venMovimientos
	ON DELETE CASCADE
GO


Alter table espVenMovimientosResuKSK add Constraint 
	espVenMovimientosResuUMKSK Foreign Key (Medida_Id)
	REFERENCES stkUniMed



INSERT INTO genVersionEmpresas (Version) Values(251)
GO