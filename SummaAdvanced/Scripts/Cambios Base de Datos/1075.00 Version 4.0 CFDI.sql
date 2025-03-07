INSERT INTO genGlobales(Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,mValor,SubSistema,
SoloLectura,lupIdentidad,WhereF10)
select genEmpresas.genEmpresas, 'GENVERSIONCFDI','Version CFDI','C',3,0,0,'3.3',NULL,NULL, 'GEN',0,NULL, NULL
FROM genEmpresas
GO

CREATE TABLE venMovimientosGlobal(
	venMovimientos BigInt NOT NULL, 
	Periodicidad VarChar(2) NOT NULL,
	Meses VarChar(2) NOT NULL,
	Anio Smallint NOT NULL,
	Primary Key(venMovimientos))
GO

Alter Table venMovimientosGlobal add Constraint fkvenMovimientosGlobal 
	foreign Key (venMovimientos) References venMovimientos
GO

Insert into genEntidadesBasicas(Entidad_Id, Descripcion) VALUES(505,'Regimenes')
GO

INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','601','General de Ley Personas Morales')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','603','Personas Morales con Fines no Lucrativos')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','605','Sueldos y Salarios e Ingresos Asimilados a Salarios')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','606','Arrendamiento')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','607','Régimen de Enajenación o Adquisición de Bienes')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','608','Demás ingresos')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','610','Residentes en el Extranjero sin Establecimiento Permanente en México')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','611','Ingresos por Dividendos (socios y accionistas)')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','612','Personas Físicas con Actividades Empresariales y Profesionales')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','614','Ingresos por intereses')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','615','Régimen de los ingresos por obtención de premios')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','616','Sin obligaciones fiscales')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','620','Sociedades Cooperativas de Producción que optan por diferir sus ingresos')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','621','Incorporación Fiscal')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','622','Actividades Agrícolas, Ganaderas, Silvícolas y Pesqueras')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','623','Opcional para Grupos de Sociedades')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','624','Coordinados')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','625','Régimen de las Actividades Empresariales con ingresos a través de Plataformas Tecnológicas')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(505,'MX','626','Régimen Simplificado de Confianza')
GO

if not Exists(select 1 from genEntidadesBasicas where Entidad_Id = '1001')
	Insert into genEntidadesBasicas(Entidad_Id, Descripcion) VALUES(1001,'Objeto Impuesto')
GO

INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(1001,'MX','01','No objeto de impuesto')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(1001,'MX','02','Si objeto de impuesto')
INSERT INTO genEntidadesBasicasValor(Entidad_Id,Dominio_Id,Clave,Descripcion) Values(1001,'MX','03','Sí objeto del impuesto y no obligado al desglose')
GO

Update venCondFiscal set CodigoFiscal = '02' 
GO

delete from genEntidadesBasicasValor where entidad_id = 504
GO

INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '01','Comprobante Emitido con Errores Con Relacion')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '02','Comprobante Emitido con Errores Sin Relacion')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '03','No se llevo a cabo la operacion')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(504,'MX', '04','Operacion Nominativa Relacionada en la Factura Global')
GO


INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id, Clave, Descripcion) VALUES(4,'MX', 'S01','Sin efectos fiscales')
GO



INSERT INTO genVersion(Version) Values(1075.00)
GO