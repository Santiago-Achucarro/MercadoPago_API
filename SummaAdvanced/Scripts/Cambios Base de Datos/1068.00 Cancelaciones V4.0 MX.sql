Update genEntidadesBasicasValor set Descripcion= 'Comprobante Emitido con Errores con Relacion' where Entidad_Id = 504 and Clave = '01' AND Dominio_Id = 'MX'
Update genEntidadesBasicasValor set Descripcion= 'Comprobante Emitido con Errores sin Relacion' where Entidad_Id = 504 and Clave = '02' AND Dominio_Id = 'MX'
Update genEntidadesBasicasValor set Descripcion= 'No se llevo a Cabo la Operacion' where Entidad_Id = 504 and Clave = '03' AND Dominio_Id = 'MX'
Update genEntidadesBasicasValor set Descripcion= 'Operacion Nominativa relacionada en una Factura Global' where Entidad_Id = 504 and Clave = '04' AND Dominio_Id = 'MX'
go

ALTER TABLE tesCfdiCobranza Add Motivo VarChar(2) 
GO

ALTER TABLE sueNominaCfdi Add Motivo VarChar(2) 
GO

insert into genVersion(Version) Values(1068.00)
GO


