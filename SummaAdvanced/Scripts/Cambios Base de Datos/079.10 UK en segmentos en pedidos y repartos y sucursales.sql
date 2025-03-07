Alter table venPedidos Add SucursalUsu integer  NULL
Go

Update venPedidos Set SucursalUsu = dbo.FuncFKgenSucursalesEmpr(venPediSegmentos.Segmento1C) From venPediSegmentos Where venPediSegmentos.venPedidos = venPedidos.venPedidos
Go

ALTER TABLE venPedidos
	ADD CONSTRAINT R_4072 FOREIGN KEY (SucursalUsu) REFERENCES genSucursalesEmpr(genSucursalesEmpr)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1venPediSegmentos ON venPediSegmentos
( 
	venPedidos            ASC
)
go



Alter table venReparto Add Sucursal integer  NULL
Go

Update venReparto Set Sucursal = dbo.FuncFKgenSucursalesEmpr(venRepaSegmentos.Segmento1C) From venRepaSegmentos Where venRepaSegmentos.venReparto = venReparto.venReparto
Go

ALTER TABLE venReparto
	ADD CONSTRAINT R_4073 FOREIGN KEY (Sucursal) REFERENCES genSucursalesEmpr(genSucursalesEmpr)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1venRepaSegmentos ON venRepaSegmentos
( 
	venReparto            ASC
)
go

Insert into genVersion (Version) Values (79.10)
Go


