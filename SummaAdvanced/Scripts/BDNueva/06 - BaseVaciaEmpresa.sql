--SET IDENTITY_INSERT genEmpresas ON
--insert into genEmpresas(genEmpresas, Empresa_Id,  Detalle, Logo, ExtensionArchivo, LogoBin, Moneda_id, 
--	Pais_id, Cuit, Calle, NoExterior, NoInterior, Colonia, Localidad, Municipio, Referencia,
--	Provincia_id, CodigoPostal, FechaInicioSumma, FechaInicioSociedad, NumeroIIBB, IGJ, 
--	Actividad, Regimen, Telefono, Usuario_Id, Inactivo) 
--	Values(@Empresa,'SummaAdv','Summa Advance','', '', '', NULL, dbo.FuncFKgenPaises(52),'XAXX010101000', ' ', ' ', ' ',
--	' ',' ',' ',' ',NULL, '10000', '20160101','20160101',' ',' ',' ','Regimen General Personas Morales', '+54-911-1234-5678', 1, 0 )
--SET IDENTITY_INSERT genEmpresas OFF

DECLARE @Empresa Int = 1

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
Values(@Empresa, 'GENLONGCLAVE','Longitud Minima Clave de Acceso', 'N',2,0,'GEN','',5,0,NULL, NULL, NULL)	

--INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
--Values(@Empresa, 'CONTDIGICTA','Digitos Sub Cuenta', 'N',2,0,'GEN','',3,0,NULL, NULL, NULL)	

--INSERT INTO GenGLOBALES(Empresa_id, NOMBRE_VAR,DESCRIPCION,cVALOR,TIPO,LONGITUD,DECIMALES,SUBSISTEMA,SOLOLECTURA,WHEREF10,NVALOR,fVALOR) 
--VALUES( @Empresa,'CONTDIGISUBCTA','DÍGITOS SUB-CUENTA','3','N',2,0,'CON',0,NULL,3.0000,NULL)

INSERT INTO genGLOBALES(Empresa_id, NOMBRE_VAR,DESCRIPCION,cVALOR,TIPO,LONGITUD,DECIMALES,SUBSISTEMA,SOLOLECTURA,WHEREF10,NVALOR,fVALOR) 
VALUES( @Empresa,'CONTMASCARACUENTA','MASCARA DE CUENTA CONTABLE','!999-999','C',25,0,'CON',0,NULL,0.0000,NULL)

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'CONMESINICIOEJE','Mes Inicio Ejercicio', 'N',2,0,'CON','',1,0,NULL, NULL, '20160101')	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'CONPERIODOS','Cantidad de Peridos Ejercicio', 'N',2,0,'CON','',12,0,NULL, NULL, '20160101')	


/* MX */


INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, SubSistema, SoloLectura, 	lupIdentidad, WhereF10, mValor)
VALUES(@Empresa,'VENPAC', 'Pac Timbrado MX', 'C',3, 0, NULL, 'B2', NULL, 'VEN', 0, 	NULL, NULL, NULL)


INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'VENUSUARIOPAC','Usuario Pac Cancelacion', 'C',120,0,'VEN','',5,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'VENCLAVEPAC','Clave Pac Cancelacion', 'C',120,0,'VEN','',5,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'VENCLAVEPACCANC','Clave Pac Cancelacion', 'C',120,0,'VEN','',5,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'VENUSUARIOPACANC','Usuario Pac Cancelacion', 'C',120,0,'VEN','',5,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'VENNOCERTIFICADO','Numero de Certificado', 'C',20,0,'VEN','',5,0,NULL, NULL, NULL);	
	
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'EMPDIRPDFFACT','Directorio pds Facturas', 'C',120,0,'VEN','C:\PDFS\',0,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'EMPDIRPDFOC','Directorio pds OC', 'C',120,0,'COM','C:\PDFS\OC\',0,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa, 'VENLLAMAPAC','Envia Cancelaciones al SAT', 'N',1,0,'VEN',' ',0,0,NULL, NULL, NULL);	

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	values(@Empresa,  'CLAVEPRIVATEKEY','Clave Private Key', 'C',50,0,'VEN',' ',0,0,NULL, NULL, NULL)
	
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	Values(@Empresa,  'VENCLAPFXCANC','Clave Pfx Key', 'C',50,0,'VEN',' ',0,0,NULL, NULL, NULL)
	


INSERT INTO genGlobales VALUES (@Empresa,'STKCOTLIMITE1','Límite de Cantidad de kgs para la generación del COT','N',14,2,0,'',NULL,NULL,'STK',0,NULL,NULL)

INSERT INTO genGlobales VALUES (@Empresa,'STKCOTLIMITE2','Límite de precio para la generación del COT','N',14,2,0,'',NULL,NULL,'STK',0,NULL,NULL)

INSERT INTO genGlobales VALUES (@Empresa,'STKCODKILOGRAMOS','Código de la Unidad de Medida Kilogramos "KGS"','C',5,0,0,'',NULL,NULL,'STK',0,NULL,NULL)

INSERT INTO genGlobales VALUES (@Empresa,'STKCOTATRI','Atributo para Nomenclador COT','N',14,0,0,'',NULL,NULL,'STK',0,NULL,NULL)


insert into genGlobales(Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,mValor,SubSistema,SoloLectura,lupIdentidad,WhereF10) values( @Empresa, 'VENCANCCONTRA','Cancela con Contramovimiento','N',1,0,0,NULL,NULL, NULL, 'VEN',0, NULL, NULL)

-- Variables Path adjuntos --
Insert Into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10) Values (@Empresa, 'PathAdjuntos', 'Ruta de adjuntos', 'C', 120, 0, null, null, null, null, 'STK', 0, null, null)
Insert into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10) Values (@Empresa, 'PATHADJUNTOSCLIE','Ruta de adjuntos de clientes', 'C', 120, 0, null, null, null, null, 'VEN', 0, null, null)
Insert into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10) Values (@Empresa, 'PATHADJUNTOSCONFORMAS','Ruta de adjuntos de clientes', 'C', 120, 0, null, null, null, null, 'VEN', 0, null, null)
Insert Into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10) Values (@Empresa, 'PathAdjuntosMovProv', 'Ruta de adjuntos Facturas de compras', 'C', 120, 0, null, null, null, null, 'COM', 0, null, null)
Insert Into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10) Values (@Empresa, 'PathAdjuntosRemi', 'Ruta de adjuntos Remitos', 'C', 120, 0, null, null, null, null, 'STK', 0, null, null)
Insert Into  genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, nValor, cValor, fValor, mValor, SubSistema, SoloLectura, lupIdentidad, WhereF10) Values (@Empresa, 'PathAdjuntosPedido', 'Ruta de adjuntos Pedidos', 'C', 120, 0, null, null, null, null, 'VEN', 0, null, null)

-- estas para Mexico tambien van
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor)
	VALUES(@Empresa, 'GENWSAAPUBLICKEY','Clave publica factura electrónica', 'M',5,0,'VEN', 0, null, null, NULL, NULL, Null, '')	


INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor)
	VALUES(@Empresa, 'GENWSAAPRIVATEKEY','Clave privada factura electrónica', 'M',5,0,'VEN', 0, null, null, NULL, NULL, Null, '')	


