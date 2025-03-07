
Create Table impCfdiMetaDatos(
	Uuid Char(36) NOT NULL, 
	RfcEmisor VarChar(13) NOT NULL, 
	NombreEmisor VarChar(200) NOT NULL, 
	RfcReceptor VarChar(13) NOT NULL, 
	NombreReceptor VarChar(200) , 
	RfcPac VarChar(13) NOT NULL, 
	FechaEmision DateTime NOT NULL, 
	FechaCertificacionSat DateTime NOT NULL, 
	Monto Numeric(18,2) NOT NULL, 
	EfectoComprobante Char(1) NOT NULL, 
	Estatus Bit NOT NULL, 
	FechaCancelacion DateTime, 
	FechaDescarga DateTime NOT NULL,
	Usuario_Id Int NOT NULL,
	Empresa_Id int NOT NULL,
	PRIMARY KEY(UUID))
GO

ALTER TABLE impCfdiMetaDatos ADD CONSTRAINT fkimpCfdiMetaDatosU 
	FOREIGN KEY (Usuario_Id) References genUsuarios
GO
ALTER Table comSolicitudesSat Add MetaDatos Sino NULL
go

Update comSolicitudesSat Set MetaDatos = 0
go

ALTER Table comSolicitudesSat Alter Column MetaDatos Sino NOT NULL
go

insert into genVersion (Version) Values(580.00)
GO

--Uuid~RfcEmisor~NombreEmisor~RfcReceptor~NombreReceptor~RfcPac~FechaEmision~FechaCertificacionSat~Monto~EfectoComprobante~Estatus~FechaCancelacion