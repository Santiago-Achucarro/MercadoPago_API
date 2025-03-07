IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 29.00)
begin

ALTER TABLE  tesCFDICobranza add Sucursal Int NOT NULL;




CREATE TABLE tesCFDICobranzaRel
( 
	tesCFDICobranza      integer  NOT NULL ,
	tesCFDICobranzaR     integer  NOT NULL ,
	CONSTRAINT XPKtesCFDICobranzaRel PRIMARY KEY  CLUSTERED (tesCFDICobranza ASC,tesCFDICobranzaR ASC)
);


ALTER TABLE tesCFDICobranzaRel
	ADD CONSTRAINT R_3989 FOREIGN KEY (tesCFDICobranzaR) REFERENCES tesCFDICobranza(tesCFDICobranza);


ALTER TABLE tesCFDICobranzaRel
	ADD CONSTRAINT R_3990 FOREIGN KEY (tesCFDICobranza) REFERENCES tesCFDICobranza(tesCFDICobranza);



exec genSegmentosGuardar  'CPAG','CPAG', 'Complemento de Pago',8,0,0,0,1,4,0,0,0,1,0,0,0,11,0,0,0,2,0,0,0,1,0,0,0,0,'1N', 0,1,1;

DECLARE @Segmento Int;
set @Segmento= (select dbo.FuncFKgenSegmentos('CPAG'));
exec genSegmentosNombresGuardar  @Segmento , 'Comprobante',' ',' ',' ','Suc',' ',' ',' ',1;

delete from genGlobales where Nombre_Var IN
	('COMFECHACIERRE','CONTMASCARACUENTA','CTAFACAREC','STKFECHACIERRE','STKTIPOCOSTO',
		'TESFECHACIERRE','VENFECHACIERRE');

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	VALUES(1, 'VENCLAVEPACCANC','Clave Pac Cancelacion', 'C',120,0,'VEN','',5,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	VALUES(1, 'VENUSUARIOPACANC','Usuario Pac Cancelacion', 'C',120,0,'VEN','',5,0,NULL, NULL, NULL);	
		


INSERT genEntidadesBasicas  (Entidad_Id, Descripcion) Values(9,'Codigo de Pac')                      
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', ' ','Ninguno');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'EK','EKomercio');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'E1','EKomercio Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'EB','eBuzon');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'EP','eBuzon Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'AD','Advantage');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'AP','Advantage Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'ED','Edicom');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'ET','Edicom Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'DF','Defacture');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'D1','Defacture Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'SF','Solucion Factible');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'ST','Solucion Factible Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'SO','STO');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'SP','STO Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'BT','Buzon Fiscal Token');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'B2','Buzon Fiscal Token Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'A1','Advans');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'A2','Advans Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'QM','SummaAdvans Pruebas');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'ME','MasterEdi');
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) Values(9, 'MX', 'MP','MasterEdi Pruebas');


alter table genGlobales Alter column nValor Numeric(18,4) NULL;
alter table genGlobales Alter column cValor VarChar(200) NULL;

INSERT INTO genVersion(Version) Values(29.00);

end


