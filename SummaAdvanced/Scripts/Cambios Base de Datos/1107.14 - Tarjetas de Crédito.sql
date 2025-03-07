ALTER TABLE tesTarjetas3 ALTER COLUMN Cupon VARCHAR(20) NOT NULL
GO
ALTER TABLE tesTarjetas3 ADD NroAutorizacion VARCHAR(25) NULL
GO
ALTER TABLE tesTarjetas3 ADD NroTarjeta VARCHAR(20) NULL
GO
ALTER TABLE tesTarjetas3 ADD SecuenciaActual SMALLINT  NOT NULL
GO
ALTER TABLE tesTarjetas3 ADD FechaConciliacion DATETIME NULL
GO
ALTER TABLE tesTarjetas3 ADD BancoConc INTEGER NULL
GO
ALTER TABLE tesTarjetas3 ADD NumeroConc INTEGER  NULL
GO
ALTER TABLE tesTarjetas3 ADD Cliente_Id bigint  NULL
GO
ALTER TABLE tesTarjetas3 ADD Empresa_Id INTEGER NULL
GO

INSERT INTO tesTarjetas3Estado (Estado, Descripcion) VALUES ('C','En_Cartera')
GO
INSERT INTO tesTarjetas3Estado (Estado, Descripcion) VALUES ('P','Presentado')
GO

INSERT INTO tesSubTiposMov (SubTipo_Id,Descripcion,TipoMov,CantCopias,genReportes) VALUES ('T3C','Concilicion_Tarjetas','E',1,65)
GO

INSERT INTO genVersion(Version) Values(1107.14)
GO







