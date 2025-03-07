

ALter table venCamiones add NroPoliza VarChar(30)
ALter table venCamiones add NombreAseg VarChar(50)
ALter table venCamiones add ConfVehicular VarChar(10)
ALter table venCamiones add Modelo INT

GO

Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(12, 'Tipo de Camiones')
GO
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C2','Camión Unitario (2 llantas en el eje delantero y 4 llantas en el eje trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C3','Camión Unitario (2 llantas en el eje delantero y 6 o 8 llantas en los dos ejes traseros)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C2R2','Camión-Remolque (6 llantas en el camión y 8 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C3R2','Camión-Remolque (10 llantas en el camión y 8 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C2R3','Camión-Remolque (6 llantas en el camión y 12 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C3R3','Camión-Remolque (10 llantas en el camión y 12 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S1','Tractocamión Articulado (6 llantas en el tractocamión, 4 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S2','Tractocamión Articulado (6 llantas en el tractocamión, 8 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S3','Tractocamión Articulado (6 llantas en el tractocamión, 12 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S1','Tractocamión Articulado (10 llantas en el tractocamión, 4 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2','Tractocamión Articulado (10 llantas en el tractocamión, 8 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S3','Tractocamión Articulado (10 llantas en el tractocamión, 12 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S1R2','Tractocamión Semirremolque-Remolque (6 llantas en el tractocamión, 4 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S2R2','Tractocamión Semirremolque-Remolque (6 llantas en el tractocamión, 8 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S1R3','Tractocamión Semirremolque-Remolque (6 llantas en el tractocamión, 4 llantas en el semirremolque y 12 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S1R2','Tractocamión Semirremolque-Remolque (10 llantas en el tractocamión, 4 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S1R3','Tractocamión Semirremolque-Remolque (10 llantas en el tractocamión, 4 llantas en el semirremolque y 12 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2R2','Tractocamión Semirremolque-Remolque (10 llantas en el tractocamión, 8 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2R3','Tractocamión Semirremolque-Remolque (10 llantas en el tractocamión, 8 llantas en el semirremolque y 12 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2R4','Tractocamión Semirremolque-Remolque (10 llantas en el tractocamión, 8 llantas en el semirremolque y 16 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S2S2','Tractocamión Semirremolque-Semirremolque (6 llantas en el tractocamión, 8 llantas en el semirremolque delantero y 8 llantas en el semirremolque trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2S2','Tractocamión Semirremolque-Semirremolque (10 llantas en el tractocamión, 8 llantas en el semirremolque delantero y 8 llantas en el semirremolque trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S3S2','Tractocamión Semirremolque-Semirremolque (10 llantas en el tractocamión, 12 llantas en el semirremolque delantero y 8 llantas en el semirremolque trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','OTROEV','Especializado de Voluminoso')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','OTROEGP','Especializado de Gran Peso')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','OTROSG','Servicio de Grúas')
GO





INSERT INTO genVersion (Version) Values(1048.00)
GO


