

ALter table venCamiones add NroPoliza VarChar(30)
ALter table venCamiones add NombreAseg VarChar(50)
ALter table venCamiones add ConfVehicular VarChar(10)
ALter table venCamiones add Modelo INT

GO

Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(12, 'Tipo de Camiones')
GO
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C2','Cami�n Unitario (2 llantas en el eje delantero y 4 llantas en el eje trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C3','Cami�n Unitario (2 llantas en el eje delantero y 6 o 8 llantas en los dos ejes traseros)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C2R2','Cami�n-Remolque (6 llantas en el cami�n y 8 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C3R2','Cami�n-Remolque (10 llantas en el cami�n y 8 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C2R3','Cami�n-Remolque (6 llantas en el cami�n y 12 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','C3R3','Cami�n-Remolque (10 llantas en el cami�n y 12 llantas en remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S1','Tractocami�n Articulado (6 llantas en el tractocami�n, 4 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S2','Tractocami�n Articulado (6 llantas en el tractocami�n, 8 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S3','Tractocami�n Articulado (6 llantas en el tractocami�n, 12 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S1','Tractocami�n Articulado (10 llantas en el tractocami�n, 4 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2','Tractocami�n Articulado (10 llantas en el tractocami�n, 8 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S3','Tractocami�n Articulado (10 llantas en el tractocami�n, 12 llantas en el semirremolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S1R2','Tractocami�n Semirremolque-Remolque (6 llantas en el tractocami�n, 4 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S2R2','Tractocami�n Semirremolque-Remolque (6 llantas en el tractocami�n, 8 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S1R3','Tractocami�n Semirremolque-Remolque (6 llantas en el tractocami�n, 4 llantas en el semirremolque y 12 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S1R2','Tractocami�n Semirremolque-Remolque (10 llantas en el tractocami�n, 4 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S1R3','Tractocami�n Semirremolque-Remolque (10 llantas en el tractocami�n, 4 llantas en el semirremolque y 12 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2R2','Tractocami�n Semirremolque-Remolque (10 llantas en el tractocami�n, 8 llantas en el semirremolque y 8 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2R3','Tractocami�n Semirremolque-Remolque (10 llantas en el tractocami�n, 8 llantas en el semirremolque y 12 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2R4','Tractocami�n Semirremolque-Remolque (10 llantas en el tractocami�n, 8 llantas en el semirremolque y 16 llantas en el remolque)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T2S2S2','Tractocami�n Semirremolque-Semirremolque (6 llantas en el tractocami�n, 8 llantas en el semirremolque delantero y 8 llantas en el semirremolque trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S2S2','Tractocami�n Semirremolque-Semirremolque (10 llantas en el tractocami�n, 8 llantas en el semirremolque delantero y 8 llantas en el semirremolque trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','T3S3S2','Tractocami�n Semirremolque-Semirremolque (10 llantas en el tractocami�n, 12 llantas en el semirremolque delantero y 8 llantas en el semirremolque trasero)')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','OTROEV','Especializado de Voluminoso')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','OTROEGP','Especializado de Gran Peso')
Insert into genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) values(12,'MX','OTROSG','Servicio de Gr�as')
GO





INSERT INTO genVersion (Version) Values(1048.00)
GO


