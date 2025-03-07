--SELECT  substring(Convert(VarChar(34), SYSDATETIMEOFFSET() ),29,6) 

Insert into genInstalacion (Dominio_Id, LIcencias, RptServidor, RptCarpeta, RptUsuario, RptClave, 
RptDominio, UsoHorario, PorEmpresa, Clave, Licencia, conDigiCta ,conDigiSubCta ,contMascaraCuenta) 
Values (case when substring(Convert(VarChar(34), SYSDATETIMEOFFSET() ),29,6) = '-03.00' THEN 'AR' ELSE 'MX' END , 
100, null, null, null, null, null, substring(Convert(VarChar(34), SYSDATETIMEOFFSET() ),29,3) 
,1, ' ',NEWID(), 5,3,'9999-999' )
Go

insert into genUsuarios(Usuario_Id, Empresa_Id, Apellido_y_Nombres, TipoUsuario, 
	Clave_de_Acceso, Sucursal, Cargo, UltCambioPass, Intentos, Email, 
	UsuarioCarga, PtoEmision, CambiarClave, MalClave, EsSupervisor, Inactivo, Posteado, Cultura, MultiplesLogins, RestringeHorarios)
	Values('ADMINSUMMA',NULL, 'ADMINISTRADOR DE SUMMA', 'U', 35664,NULL, ' ',GETDATE(), 0,'', 1, null, 0,0,1, 0,1, 'es-MX',0,0)
	Go

insert into genUsuarios(Usuario_Id, Empresa_Id, Apellido_y_Nombres, TipoUsuario, 
	Clave_de_Acceso, Sucursal, Cargo, UltCambioPass, Intentos, Email, 
	UsuarioCarga, PtoEmision, CambiarClave, MalClave, EsSupervisor, Inactivo, Posteado, Cultura, MultiplesLogins, RestringeHorarios)
	Values('ELMUNDO',NULL, 'Grupo El Mundo', 'G', 0,NULL, ' ',GETDATE(), 0,'', 1, null, 0,0,0, 0,1, 'es-MX',0,0)
	Go

Insert Into genGrupos (Grupo_Id, Usuario_Id)Values (2,1)
Go

INSERT INTO genMonedas (Moneda_Id,Empresa_Id,Descripcion,Simbolo,CodigoFiscal,CtaFactaRecibir,CtaFactaRecibirImp,Inactivo,Usuario_Id,Posteado,CantidadDigitos)
     VALUES ('PES', null, 'Pesos', '$', null, null, null, 0, 1, 1, 2)
GO



INSERT INTO genEmpresas (Empresa_Id,Detalle,RazonSocial,Logo,ExtensionArchivo,Moneda_Id,Pais_Id,Cuit,Calle,NoExterior,NoInterior,Colonia,Localidad,
	Municipio,Referencia,Provincia_Id,CodigoPostal,FechaInicioSumma,FechaInicioSociedad, FechaCalculoStock,FechaCierreCompras,FechaCierreVentas,
	FechaCierreStock,FechaCierreTesoreria,NumeroIIBB,IGJ,Actividad,Regimen,Telefono,CarpetaEspecial,UsaCantidadAlterna,UsaDespachoImportacion,
	UsaSerie,CtaMercaEnTransitoImpor, TipoCosto, TipoCosto2, TipoCosto3,EnviaPedido,
	Usuario_Id,Inactivo, FechaCierreActivoFijo,FechaCalculoActivoFijo, FechaCalculoActivoDiferido,
	FechaCierreSueldos,ConfirmarEnviarPedidos ,ConfirmarEnviarFacturas, ConfirmarEnviarRecibo,ConfirmarEnviarOC, RemisionesAlCosto,TrabajaDomingo,
	TrabajaSabado, SeguridadRH)
    VALUES ('EMPRESA','Empresa S.A.', 'Empresa S.A.', null, '', 1, null, '', 'Calle', '12334', '', '', 'CABA', '', '', 
	null, '1431', '20170901', '19911221', '20170831', '20170831', '20170831', '20170831', '20170831', 'IIBB', 'IGJ', 'Venta', '', 'TEL', '', 0, 0, 0,
	null, 'U', 'P', 'S', 0,
	null, 0, '20170831', '20170831', '20170831', '20170831',1,1,1,1,1, 0, 0, 0)
GO

Update genMonedas Set Empresa_Id = 1

INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AF','Afganistan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('DZ','Algeria')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AD','Andorra')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AG','Antigua and Bermuda')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AM','Armenia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AU','Australia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AZ','Azerbaijan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BH','Bahrain')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BB','Barbados')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BE','Begium')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BJ','Benin')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BT','Bhutan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BA','Bosnia-Herzegovina')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BV','Bouvet Island')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IO','British Indian Ocean Territory')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BG','Bulgaria')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BI','Burundi')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CM','Cameroon')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CV','Cape Verde')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CF','Central African Republic')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CL','Chile')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CX','Christmas Island')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CO','Colombia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CG','Congo')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CR','Costa Rica')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CU','Cuba')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CZ','Czech Republic')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('DK','Denmark')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('DM','Dominica')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TP','East Timor')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('EG','Egypt')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GQ','Equatorial Guinea')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ET','Ethiopia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FO','Faroe Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FI','Finland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FX','France (European Territory)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PF','French Polynesia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GA','Gabon')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GE','Georgia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GH','Ghana')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GR','Greece')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GD','Grenada')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GU','Guam (US)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GN','Guinea')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GY','Guyana')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('HM','Heard and McDonald Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('HK','Hong Kong')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IS','Iceland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ID','Indonesia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IQ','Iraq')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IL','Israel')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CI','Ivory Coast (C te D Ivoire)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('JP','Japan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KZ','Kazakhstan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KI','Kiribati')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KG','Kyrgyzstan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LV','Latvia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LS','Lesotho')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LY','Libya (Libyan Arab Jamahiriya)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LT','Lithuania')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MO','Macau')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MG','Madagascar')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MY','Malasya')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ML','Mali')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MH','Marshall Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MR','Mauritania')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MX','Mexico')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MD','Moldavia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MN','Mongolia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MA','Morocco')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MM','Myanmar')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NR','Nauru')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AN','Netherland Antilles')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NT','Neutral Zone')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NZ','New Zealand')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NE','Niger')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NU','Niue')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KP','North Korea')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NO','Norway')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PK','Pakistan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PA','Panama')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PY','Paraguay')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PH','Philipines')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PL','Poland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PT','Portugal')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('QA','Qatar')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('RO','Romania')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('RW','Rwanda')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KN','Saint Kitts Nevis Anguilla')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PM','Saint Pierre and Miquelon')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('VC','aint Vincent and the Grenadines')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SM','San Marino')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SN','Senegal')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SL','Sierra Leone')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SK','Slovak Republic (Slovakia)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SB','Solomon Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ZA','South Africa')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SU','Soviet Union')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LK','Sri Lanka')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SR','Surinam')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SZ','Swaziland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CH','Switzwerland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TJ','Tajikistan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TZ','Tanzania')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TG','Togo')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TO','Tonga')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TN','Tunisia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TM','Turkmenistan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TV','Tuvalu')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('UA','Ukraine')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('UK','United Kingdom')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('UM','United States Minor Outlying Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('UZ','Uzbekistan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('VA','Vatican City State')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('VI','Virgin Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('EH','Western Sahara')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('YU','Yugoslavia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ZM','Zambia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AL','Albania')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AS','American Samoa')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AO','Angola')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AQ','Antartica')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AR','Argentina')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AW','Aruba')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AT','Austria')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BS','Bahamas')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BD','Bangladesh')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BY','Belarus')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BZ','Belize')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BM','Bermuda')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BO','Bolivia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BW','Botswana')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BR','Brazil')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BN','Brunei Darussalam')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('BF','Burkina Faso')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KH','Cambodia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CA','Canada')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KY','Cayman Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TD','Chad')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CN','China')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CC','Cocos (Keeling) Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KM','Comoros')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CK','Cook Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('HR','Croatia (Hrvatska)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CY','Cyprus')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('CS','Czechoslovakia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('DJ','Djibouti')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('DO','Dominican Republic')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('EC','Ecuador')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SV','El Salvador')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('EE','Estonia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FK','Falkland Islands (Malvinas)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FJ','Fiji')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FR','France')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GF','French Guyana')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TF','French Southern Territories')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GM','Gambia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('DE','Germany')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GI','Gibraltar')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GL','Greenland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GP','Guadaloupe (French)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GT','Guatemala')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('GW','Guinea-Bissau')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('HT','Haiti')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('HN','Honduras')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('HU','Hungary')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IN','India')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IR','Islamic Republic of Iran')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IE','Ireland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('IT','Italy')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('JM','Jamaica')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('JO','Jordan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KE','Kenya')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KW','Kuwait')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LA','Laos (Peoples Democratic Republic)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LB','Lebanon')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LR','Liberia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LI','Liechtenstein')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LU','Luxembourg')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MK','Macedonia (Former Yugoslav Republic of)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MW','Malawi')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MV','Maldives')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MT','Malta')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MQ','Martinique (French)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MU','Mauritius')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('FM','Micronesia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MC','Monaco')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MS','Montserrat')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MZ','Mozambique')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NA','Namibia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NP','Nepal')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NL','Netherland')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NC','New Caledonia (French)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NI','Nicaragua')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NG','Nigeria')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('NF','Norfolk Island')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('MP','Northern Mariana Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('OM','Oman')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PW','Palau')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PG','Papua New Guinea')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PE','Peru')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PN','Pitcairn')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('PR','Puerto Rico (US)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('RE','Reunion (French)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('RU','Russian Federation')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SH','Saint Helena')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('LC','Saint Lucia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ST','Saint Tome and Principe')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('WS','Samoa')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SA','Saudi Arabia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SC','Seychelles')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SG','Singapore')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SI','Slovenia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SO','Somalia')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('KR','South Korea')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ES','Spain')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SD','Sudan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SJ','Svalbard and Jan Mayen Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SE','Sweden')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('SY','Syria (Syrian Arab Republic)')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TW','Taiwan')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TH','Thailand')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TK','Tokelau')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TT','Trinidad and Tobago')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TR','Turkey')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('TC','Turks and Caicos Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('UG','Uganda')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('AE','United Arab Emirates')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('US','United States of America')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('UY','Uruguay')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('VU','Vanuatu')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('VE','Venezuela')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('WF','Wallis and Futuna Islands')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('YE','Yemen')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ZR','Zaire')
INSERT INTO genDominios (Dominio_id, Descripcion) VALUES('ZW','Zimbabwe')

INSERT INTO genPaises (Pais_Id ,Empresa_Id, Descripcion, CodFiscal, Dominio_Id, Inactivo, Usuario_Id,Posteado)
VALUES(52, NULL, 'Mexico', 'MEX', 'MX', 0, 1, 1)

INSERT INTO genPaises (Pais_Id ,Empresa_Id, Descripcion, CodFiscal, Dominio_Id, Inactivo, Usuario_Id,Posteado)
VALUES(54, NULL, 'Argentina', 'AR', 'AR', 0, 1, 1)

INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('1','Activo','ACT')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('2','Pasivo','PAS')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('3','Capital_Contable','CAP')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('4','Ingresos','ING')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('5','Gastos','GAS')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('6','Costos','COS')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('7','Otros_Ingresos','OI')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('8','Otros_Egresos','OE')
INSERT INTO conRubros(Rubro_id, Descripcion , Tipo) Values('9','Orden','ORD')


INSERT INTO impLibrosTiposRenglon(TipoRenglon,Descripcion) Values( 'EX','Exento Impuesto')
INSERT INTO impLibrosTiposRenglon(TipoRenglon,Descripcion) Values( 'GR','Gravado Impuesto')
INSERT INTO impLibrosTiposRenglon(TipoRenglon,Descripcion) Values( 'IM','Importe Impuesto')
INSERT INTO impLibrosTiposRenglon(TipoRenglon,Descripcion) Values( 'TO','Total')





Insert into conCuadro1Filas (Cuadro1Fila_Id, Descripcion, Empresa_id, Posteado, Inactivo, Usuario_id) Values ('0', 'Sin Gasto',null,1,0,1)

INSERT INTO comProveedoresTipoPasivo(TipoCtaProv, Descripcion)	 values(1, 'Mercaderia')
INSERT INTO comProveedoresTipoPasivo(TipoCtaProv, Descripcion)	 values(2, 'Servicios')

INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(0, 'Ninguno')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(1, 'Pantalla')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(2, 'Año')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(3, 'Mes')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(5, 'Letra_Ventas')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(6, 'Letra_Compras')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(7, 'Ejercicio')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(8, 'TipoMov')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(9, 'Proveedor')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(10, 'Despacho')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(11, 'Sucursal')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(12, 'RellenoCon0')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(13, 'Año Sueldos')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(14, 'Mes Sueldos')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(15, 'Quincena Sueldos')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(16, 'Semana Sueldos')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(17, 'Decena Sueldos')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) VALUES(18, 'Vez Sueldos')
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion) Values(19,'Punto_Emision');
INSERT INTO genSegmentoOrigenes(OriSeg_Id, Descripcion)	Values(20,'Valor_Fijo');









INSERT INTO comMovTipos(Tipomov, Descripcion , Signo) VALUES('F','Factura',-1)
INSERT INTO comMovTipos(Tipomov, Descripcion , Signo) VALUES('D','Nota_de_Debito',-1)
INSERT INTO comMovTipos(Tipomov, Descripcion , Signo) VALUES('R','Nota_de_Credito',1)
INSERT INTO comMovTipos(Tipomov, Descripcion , Signo) VALUES('P','Pago',1)
-- AJ FEB 18
INSERT INTO comMovTipos(Tipomov, Descripcion, Signo) VALUES('C','Cobraza',-1)
-- FIN AJ
INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('COMPRASIMPUESTOS','NG', 'NETO_GRAVADO', 103, 'N')
INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('COMPRASIMPUESTOS','PORCE', 'PROCENTAJE', 103, 'N')
INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('COMPRASIMPUESTOS','IIF', 'Funcion_condicional', 113, 'U')

INSERT INTO stkTiposmov (Tipomov, Descripcion, Signo) VALUES('E','Entrada',1)
INSERT INTO stkTiposmov (Tipomov, Descripcion, Signo) VALUES('S','Salida',-1)
INSERT INTO stkTiposmov (Tipomov, Descripcion, Signo) VALUES('RV','Revaluo',0)

INSERT INTO stkSubTipoMov (SubTipomov_id, TipoMov, Descripcion, Consumo, CantCopias)  VALUES('FCP','E', 'Factura_de_Proveedores',0, 2)
INSERT INTO stkSubTipoMov (SubTipomov_id, TipoMov, Descripcion, Consumo, CantCopias)  VALUES('NCP','S', 'Nota_de_Credito_de_Proveedores',0, 2)
INSERT INTO stkSubTipoMov (SubTipomov_id, TipoMov, Descripcion, Consumo, CantCopias)  VALUES('NP','E', 'Entrada_por_Orden_de_Compra',0, 2)
Insert Into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias)Values ('REM', 'S', 'Remitos_a_Clientes', 0, 2)
Insert Into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias)Values ('EOMV', 'E', 'Entradas_por_Otros_Movimientos', 0, 2)
Insert Into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias)Values ('SOMV', 'S', 'Salidas_por_Otros_Movimientos', 0, 2)
Insert Into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias)Values ('OE', 'E', 'Entradas_por_Orden_de_Embarque', 0, 2)



--INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
-- VALUES(1, 'VENFECHACIERRE','Fecha de Cierre de Ventas', 'D',5,0,'GEN','',0,0,NULL, NULL, '20160101')


INSERT INTO tesCheqPropEstado(Estado_Id, Descripcion) Values('P','Entregado_a_Proveedor')
INSERT INTO tesCheqPropEstado(Estado_Id, Descripcion) Values('D','Depositado')
INSERT INTO tesCheqPropEstado(Estado_Id, Descripcion) Values('R','Rechazado')
INSERT INTO tesCheqPropEstado(Estado_Id, Descripcion) Values('I','Entregado_diferido')


INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('A','Acreditado')
INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('C','En_Cartera')
INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('D','Rechazado_Nota_de_Debito')
INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('J','Canjeado')
INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('N','Depositado')
INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('P','Entregado_a_proveedores')
INSERT INTO tesCheqTerEstado(Estado_Id, Descripcion) Values('R','Rechazado')

INSERT INTO tesChequerasEstado (Estado_Id, Descripcion) Values('A','Activa_(No_Predeterminada)')
INSERT INTO tesChequerasEstado (Estado_Id, Descripcion) Values('B','Dada_de_Baja')
INSERT INTO tesChequerasEstado (Estado_Id, Descripcion) Values('I','Inactiva_Nueva')
INSERT INTO tesChequerasEstado (Estado_Id, Descripcion) Values('P','Predeteminada')

INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('CP','Bancos_Propios')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('CT','Cheques_de_Clientes')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('EF','Efectivo')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('CA','Caja_de_Ahorro')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('FF','Fondo_Fijo')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('FP','Facturas_de_Proveedores')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('GR','Anticipo_Gastos_a_Rendir')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('RC','Retenciones_de_Clientes')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('RE','Reservado')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('RP','Retenciones_a_Proveedores')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('VA','Varios')
INSERT INTO tesTiposId (TipoCartera, Descripcion) VALUES('T3','Tarjetas_de_Clientes')

INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'AGP','Pago_de_Anticipo_de_gastos',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'AGR','Rendicion_de_Anticipo_de_gastos',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'AIB','Arqueo_inicial_Bancos',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'AOP','Anulacion_de_O/P',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'CBA','Creditos_Bancarios',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'CCR','Canje_de_Cheques_Rechazados',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'COB','Cobranza_a_clientes',1,'I')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'CR3','Cheques_rechazados_de_Clientes',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'CRP','Cheques_rechazados_Propios',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'DBA','Cargos_Bancarios',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'DE3','Deposito_Cheques_de_Clientes',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'DEE','Deposito_de_Efectivo',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'DFC','Asientos_de_Diferencias_de_Cambio',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'EGR','Egresos_Varios',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'FCP','Pago_Fondo_Fijo',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'FCR','Reposicion_Fondo Fijo',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'FFC','Creacion_de_Fondo_Fijo',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'FFT','Actualizacion__Rendicion_de_Fondos_Fijos',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'ING','Ingresos_Varios',1,'I')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'PAP','Pagos_a_Proveedores',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'SIC','Saldo_Inicial_Cheques',1,'E')
INSERT INTO tesSubTiposMov(SUBTIPO_ID,DESCRIPCION,CantCopias,Tipomov) Values( 'SIO','Saldo_Inicial_Otros',1,'E')
INSERT INTO tesSubTiposMov(SubTipo_id,Descripcion,CantCopias,Tipomov) Values( 'PCL','Pagos_a_Clientes',1,'E')
-- AJ FEB 2018
INSERT INTO tesSubTiposMov(SubTipo_id,Descripcion,CantCopias,Tipomov) Values( 'COP','Cobraza_Proveedores',1,'I')
-- FIN AJ
INSERT INTO tesSubTiposMov(SubTipo_id,Descripcion,CantCopias,Tipomov) Values( 'DCD','Débito_de_Cheques_Diferidos_al_vencimiento',1,'E')


INSERT INTO comOrigenesFiscales (Origen_id, Descripcion, Dominio_id) 
	VALUES(3, 'Servicios','MX')

INSERT INTO comOrigenesFiscales (Origen_id, Descripcion, Dominio_id) 
	VALUES(6, 'Arrendamientos de Inmuebles','MX')

INSERT INTO comOrigenesFiscales (Origen_id, Descripcion, Dominio_id) 
	VALUES(85, 'Otros','MX')
	
INSERT INTO conCentro1(Centro1_Id,Empresa_Id,Descripcion,Inactivo,Nivel,Imputable,Notas,Posteado,Usuario_Id) Values( '',Null,'Ninguno',0,1,1,'',1,1)
INSERT INTO conCentro1(Centro1_Id,Empresa_Id,Descripcion,Inactivo,Nivel,Imputable,Notas,Posteado,Usuario_Id) Values( '%',Null,'Obligatorio',0,1,1,'',1,1)
INSERT INTO conCentro1(Centro1_Id,Empresa_Id,Descripcion,Inactivo,Nivel,Imputable,Notas,Posteado,Usuario_Id) Values( '*',Null,'Todos',0,1,0,'',1,1)

INSERT INTO conCentro2(Centro2_Id,Empresa_Id,Descripcion,Inactivo,Nivel,Imputable,Notas,Posteado,Usuario_Id) Values( '',Null,'Ninguno',0,1,1,'',1,1)
INSERT INTO conCentro2(Centro2_Id,Empresa_Id,Descripcion,Inactivo,Nivel,Imputable,Notas,Posteado,Usuario_Id) Values( '%',Null,'Obligatorio',0,1,0,'',1,1)
INSERT INTO conCentro2(Centro2_Id,Empresa_Id,Descripcion,Inactivo,Nivel,Imputable,Notas,Posteado,Usuario_Id) Values( '*',Null,'Todos',0,1,0,'',1,1)


INSERT INTO comocestados (Estado_Id, Descripcion) Values('A','Autorizada')
INSERT INTO comocestados (Estado_Id, Descripcion) Values('E','Entregada')
INSERT INTO comocestados (Estado_Id, Descripcion) Values('I','Importacion_Cerrada')
INSERT INTO comocestados (Estado_Id, Descripcion) Values('P','Pendiente_Autorizacion')
INSERT INTO comocestados (Estado_Id, Descripcion) Values('R','Rechazada')
INSERT INTO comocestados (Estado_Id, Descripcion) Values('T','Terminada')




INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'C','Cobranza',-1,'COB')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'D','Nota_de_Debito',1,'NDA')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'F','Factura',1,'FAC')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'N','Anticipo',-1,'ANT')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'P','Pago',1,'PAG')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'R','Nota_de_Credito',-1,'NCR')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'X','Credito_Interno',-1,'CRI')
INSERT INTO venTipoMov(venTipomov,DESCRIPCION,SIGNO,TIPOMOVRESUMIDO) Values( 'Y','Debito_Interno',1,'CAI')
Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('I', 'Factura de crédito electrónica MyPymes', 1, 'FCR')
Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('B', 'Nota de débito de crédito electrónica MyPymes', 1, 'DCR')
Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('E', 'Nota de crédito de crédito electrónica MyPymes', -1, 'CCR')



insert into VenIncoterm (Incoterm_id, Descripcion) Values('CFR','COSTE Y FLETE (PUERTO DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('CIF','COSTE, SEGURO Y FLETE (PUERTO DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('CPT','TRANSPORTE PAGADO HASTA (EL LUGAR DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('CIP','TRANSPORTE Y SEGURO PAGADOS HASTA (LUGAR DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DAF','ENTREGADA EN FRONTERA (LUGAR CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DAP','ENTREGADA EN LUGAR.')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DAT','ENTREGADA EN TERMINAL.')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DES','ENTREGADA SOBRE BUQUE (PUERTO DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DEQ','ENTREGADA EN MUELLE (PUERTO DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DDU','ENTREGADA DERECHOS NO PAGADOS (LUGAR DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('DDP','ENTREGADA DERECHOS PAGADOS (LUGAR DE DESTINO CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('EXW','EN FABRICA (LUGAR CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('FCA','FRANCO TRANSPORTISTA (LUGAR DESIGNADO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('FAS','FRANCO AL COSTADO DEL BUQUE (PUERTO DE CARGA CONVENIDO).')
insert into VenIncoterm (Incoterm_id, Descripcion) Values('FOB','FRANCO A BORDO (PUERTO DE CARGA CONVENIDO).')



Go

Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASLISTASPRECIOS', 'STOT', 'SubTotal_antes_de_los_descuentos', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASLISTASPRECIOS', 'STOB', 'SubTotal_bonificado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASLISTASPRECIOS', 'ATRICLIE', 'Devuelve_el_atributo_X_del_cliente', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASLISTASPRECIOS', 'BONI', 'Bonificacion_N_cargada_en_el_cliente', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASLISTASPRECIOS', 'DATO', 'DATO_N_cargada_en_el_comprobante', 100, 'N')
GO

Insert genWSFactElec (TipoFE, Descripcion)Values ('FEV1', 'Factura elect. local V1')
Go
Insert genWSFactElec (TipoFE, Descripcion)Values ('FEX', 'Factura elect. exterior')
Go
Insert genWSFactElec (TipoFE, Descripcion)Values ('MTXCA', 'FE local MTXCA')
Go






INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(1,'Unidad Medida Fiscal')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(2,'Unidad Medida Fiscal Exportaciones')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(3,'Codigos Fiscales de Productos')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(4,'SubTipos Fiscales (USO)')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(5,'Codigos de Aduana')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(6,'Formas de Pago')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(7,'Metodos de Pago')
Insert into genEntidadesBasicas (Entidad_Id, Descripcion) Values(10, 'Origen y Aplicacion de Fondos')

INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(500,'Tipo Comite INE ')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(501,'Tipo Ambito INE')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(502,'Entidad Federativa INE')
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(503,'Motivo Exportacion')




INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) values(200,'Códigos fiscales de Monedas')





insert into conAnexosOrigenes(Origen, Descripcion, TipoRubro) values (1,'Costo Rubro','COS')
insert into conAnexosOrigenes(Origen, Descripcion, TipoRubro) values (2,'Gasto','GAS')
insert into conAnexosOrigenes(Origen, Descripcion, TipoRubro) values (3,'Resultado Positivo','ING')
insert into conAnexosOrigenes(Origen, Descripcion, TipoRubro) values (4,'Otros Ingresos','OI')
insert into conAnexosOrigenes(Origen, Descripcion, TipoRubro) values (5,'Otros Egresos','OE')
insert into conAnexosOrigenes(Origen, Descripcion, TipoRubro) values (6,'Impuestos','IM')
INSERT INTO conAnexosOrigenes (Origen, Descripcion, TipoRubro) Values(7,'Impuestos Ejercicio','OE')

-- AJ 09/02/2018
insert into tesCheqPropEstado Values('A','Anulado')

-- AJ 09/03/18
INSERT INTO comEmbEstado(Estado_Id, Descripcion) Values('P','Pendiente')
INSERT INTO comEmbEstado(Estado_Id, Descripcion) Values('C','Cerrado')


-- AJ 19/03/18
insert into comMovTipos (Tipomov, Descripcion, Signo) Values('X','Credito Aplicacion Importaciones ',-1)
insert into comMovTipos (Tipomov, Descripcion, Signo) Values('Y','Debito Aplicacion Importaciones ',1)


-- este es para MX
SET IDENTITY_INSERT genSegmentos ON
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(1, 'ASI', 'Asientos Contables', 8, 4, 0, 0, 1, 0, 0, 0, 0, 1, 7, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(2, 'FPRO', 'Facturas Proveedores', 10, 0, 0, 0, 0, 5, 1, 15, 0, 1, 0, 0, 0, 1, 8, 9, 0, 4, 0, 0, 0, 3, 1, 2, 0, 0, '3C', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(3, 'TES', 'Movimientos de Tesoreria', 8, 0, 0, 0, 1, 1, 4, 0, 0, 1, 0, 0, 0, 8, 11, 0, 0, 3, 0, 0, 0, 1, 2, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(4, 'OC', 'Ordenes de Compra', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(6, 'STOCK', 'Movimientos de Stock', 8, 0, 0, 0, 1, 2, 4, 0, 0, 1, 0, 0, 0, 8, 11, 0, 0, 3, 0, 0, 0, 1, 2, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(7, 'NP', 'PEDIDOS DE VENTAS', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(9, 'REM', 'REMISION O REMITO', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(10, 'FC', 'FACTURACION', 8, 0, 0, 0, 1, 1, 4, 1, 0, 1, 0, 0, 0, 8, 11, 5, 0, 3, 0, 0, 0, 1, 2, 4, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(11, 'HOJADERUTA', 'HOJA DE RUTA', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(12, 'REOC', 'Recepcion Ordenes de Compra No Codificados', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(13, 'INV', 'INVENTARIOS', 8, 0, 0, 0, 0, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(14, 'EMB', 'EMBARQUE', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(15, 'AIMP', 'APLICACIONES DE IMPORTACIONES', 8, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 8, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(16, 'REPARTO', 'Repartos', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(17, 'RV', 'Revaluos', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 8, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(18, 'APLI', 'APLICACIONES', 8, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(19, 'DFCC', 'DIFERENCIA EN CAMBIOS COMPRAS', 8, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(20, 'PRAJU', 'AJUSTES A PROVEEDORES', 8, 0, 0, 0, 1, 1, 4, 0, 0, 1, 0, 0, 0, 8, 11, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(21, 'REVOC', 'Reversion Ordenes de Compra No Codificados', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(22, 'CPAG', 'Complemento de Pago', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(23, 'FPRODESPA', 'Facturas de Aduana', 0, 0, 0, 0, 0, 15, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '1C', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(24, 'DFCV', 'DIFERENCIA EN CAMBIOS VENTAS', 8, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(25, 'PROG', 'Programa de Produccion', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(26, 'PORD', 'Ordenes de Produccion', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(27, 'DEP', 'Depreciaciones', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(28, 'ABAJ', 'Bajas Activo Fijo', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(29, 'VCOT', 'Cotizaciones de Ventas', 8, 0, 0, 0, 1, 8, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, 'N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(30, 'CPRO', 'Cierre de Orden Produccion', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(31, 'REQIN', 'Requerimiento Interno', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(32, 'SLIQ', 'Nomina', 4, 2, 3, 5, 0, 0, 0, 0, 0, 1, 13, 14, 15, 18, 0, 0, 0, 0, 1, 2, 3, 4, 0, 0, 0, 0, '4N', 0, 1, 1, 1)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(33, 'IMPLQ', 'Liquidacion Impuestos', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(34, 'SDXT', 'Descuentos por Tope', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(35, 'AGC', 'Anticipos de Gastos por Comprobar', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(36, 'FLFO', 'Flujo de Fondos', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
INSERT INTO genSegmentos(genSegmentos, Segmento_Id, Descripcion, Digitos1N, Digitos2N, Digitos3N, Digitos4N, TieneColumnaAutomatica, Digitos1C, Digitos2C, Digitos3C, Digitos4C, Origen1N, Origen2N, Origen3N, Origen4N, Origen1C, Origen2C, Origen3C, Origen4C, Orden1N, Orden2N, Orden3N, Orden4N, Orden1C, Orden2C, Orden3C, Orden4C, HabilitaEdicion, TamanioVariable, Inactivo, Usuario_Id, Posteado, EsSueldos) VALUES(37, 'SCD', 'Solicitud Cambio Almacen', 8, 0, 0, 0, 1, 4, 0, 0, 0, 1, 0, 0, 0, 11, 0, 0, 0, 2, 0, 0, 0, 1, 0, 0, 0, 1, '1N', 0, 1, 1, 0)
SET IDENTITY_INSERT genSegmentos OFF
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(1, 'Asiento', 'Ejercicio', '', '', '', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(2, 'Comprobante', '', '', '', 'Serie', 'TM', 'Proveedor', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(3, 'Comprobante', '', '', '', 'TM', 'Sucursal', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(4, 'Numero', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(6, 'Numero', '', '', '', 'TM', 'Sucursal', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(7, 'Numero', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(9, 'Numero', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(10, 'Folio', '', '', '', 'TM', 'Sucursal', 'Ser', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(11, 'Numero', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(12, 'Comprob', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(13, 'Comprobante', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(14, 'Embarque', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(15, 'Comprobante', '', '', '', 'TM', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(16, 'Comprob', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(17, 'Comprob', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(18, 'Comprobante', '', '', '', '', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(19, 'Comprobante', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(20, 'Comprobante', '', '', '', 'TM', 'Suc', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(21, 'Comprob', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(22, 'Comprobante', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(23, '', '', '', '', 'Despacho', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(24, 'Comprobante', '', '', '', 'Suc', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(25, 'Comprobante', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(26, 'Comprobante', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(28, 'Baja', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(32, 'Anio', 'Mes', 'Quin', 'Vez', '', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(33, 'Comprobante', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(34, 'Comprobante', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(35, 'Comprobante', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(36, 'Flujo', '', '', '', 'Sucursal', '', '', '', 1)
INSERT INTO genSegmentosNombres(Segmento_Id, Nombre1N, Nombre2N, Nombre3N, Nombre4N, Nombre1C, Nombre2C, Nombre3C, Nombre4C, Usuario_Id) VALUES(37, 'Solicitud', '', '', '', 'Sucursal', '', '', '', 1)

-- FIN PARA MX



INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('CDS', 'S','Cambio_de_deposito_Salida',0,1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('CDE', 'E','Cambio_de_deposito_Entrada',0,1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('CIE','RV', 'Cierre de Embarque', 0, 1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('PDP','RV', 'Diferencia En Precios', 0, 1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('RV','RV','Revaluo', 0, 1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('RPR','E','Remitos_de_Proveedores', 0, 1)




Insert Into genCulturas (Cultura, Descripcion) Values ('es-AR', 'EspAñol Argentina');
Insert Into genCulturas (Cultura, Descripcion) Values ('es-MX', 'EspAñol México');
Insert Into genCulturas (Cultura, Descripcion) Values ('en', 'English');
Insert Into genCulturas (Cultura, Descripcion) Values ('pt', 'Portugues');


insert into stkSubTipoMov (SubTipoMov_Id,TipoMov,Descripcion,Consumo,CantCopias,Reporte_Id) values('INVE','E','Inventario_Entrada',0,1,null);
insert into stkSubTipoMov (SubTipoMov_Id,TipoMov,Descripcion,Consumo,CantCopias,Reporte_Id) values('INVS','S','Inventario_Salida',0,1,null);
INSERT INTO stkSubTipoMov(SubTipoMov_Id, TipoMov, Descripcion,Consumo,CantCopias) VALUES('RFR', 'RV', 'Revaluo_Facturas_Remisiones', 0, 1)


INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES('RVS','RV', 'Revaluo_Manual', 0, 1, null)

Insert Into conGruposCont (Grupo_Id, Empresa_Id, Descripcion, Inactivo, Usuario_Id, Posteado) values ('*', Null, 'Todos', 0, 1, 1)
Insert Into conGruposCont (Grupo_Id, Empresa_Id, Descripcion, Inactivo, Usuario_Id, Posteado) values ('%', Null, 'Obligatorio', 0, 1, 1)
Insert Into conGruposCont (Grupo_Id, Empresa_Id, Descripcion, Inactivo, Usuario_Id, Posteado) values ('0', Null, 'Ninguno', 0, 1, 1)



INSERT INTO genVersion(Version) Values(32.02);


Insert Into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias)Values ('NC', 'E', 'Entradas_por_Nota_de_Credito', 0, 2)

-- AJ 24-9-18
insert into comMovTipos (TipoMov, Descripcion, Signo) VALUES('V','Ajustes Positivo Estado de Cuenta',1)
insert into comMovTipos (TipoMov, Descripcion, Signo) VALUES('W','Ajustes Negativo Estado de Cuenta',-1)
Insert Into stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias)Values ('DP', 'S', 'Devoluciones_a_Proveedores', 0, 2)



INSERT INTO genGlobales (Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,mValor,SubSistema,SoloLectura,lupIdentidad,WhereF10)
VALUES (1,'GENWSFECHAVENC','Fecha Vencimiento Claves Factura electrónica','F',12,0,0,'','20191231',NULL,'GEN',0,NULL,NULL)
GO


insert into genClavesComunes Values('password')
insert into genClavesComunes Values('123456')
insert into genClavesComunes Values('12345678')
insert into genClavesComunes Values('abc123')
insert into genClavesComunes Values('qwerty')
insert into genClavesComunes Values('monkey')
insert into genClavesComunes Values('letmein')
insert into genClavesComunes Values('dragon')
insert into genClavesComunes Values('111111')
insert into genClavesComunes Values('baseball')
insert into genClavesComunes Values('iloveyou')
insert into genClavesComunes Values('trustno1')
insert into genClavesComunes Values('1234567')
insert into genClavesComunes Values('sunshine')
insert into genClavesComunes Values('master')
insert into genClavesComunes Values('123123')
insert into genClavesComunes Values('welcome')
insert into genClavesComunes Values('shadow')
insert into genClavesComunes Values('ashley')
insert into genClavesComunes Values('football')
insert into genClavesComunes Values('futbol')
insert into genClavesComunes Values('jesus')
insert into genClavesComunes Values('michael')
insert into genClavesComunes Values('ninja')
insert into genClavesComunes Values('mustang')
insert into genClavesComunes Values('password1')
insert into genClavesComunes Values('1234567890')
insert into genClavesComunes Values('1qaz2wsx')
insert into genClavesComunes Values('login')
insert into genClavesComunes Values('clave')
insert into genClavesComunes Values('qwertyuiop')
insert into genClavesComunes Values('passw0rd')
insert into genClavesComunes Values('starwars')
insert into genClavesComunes Values('solo')
GO


insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1500, 'Sueldos')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1501, 'Actividades')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1502, 'Afore')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1503, 'Condicion Servicio')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1504, 'Estado Civil')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1505, 'Localidad')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1506, 'Modalidad Contratacion')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1507, 'Sinestrado')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1508, 'Situacion Revi')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1509, 'TipoContrato')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1510, 'TipoEmpleador')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1511, 'Tipo Jornada')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1512, 'Tipo Regimen')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1513, 'Tipo SDI')
insert into genEntidadesBasicas (Entidad_Id, Descripcion) values (1514, 'Codigo Natural')
GO



INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) Values(1515, 'SEXO')

GO

-- V2





insert into genEntidadesBasicas(Entidad_Id, Descripcion) Values(1516, 'Tipo Deduccion')
GO

insert into genEntidadesBasicas(Entidad_Id, Descripcion) Values(1517, 'Tipo Percepcion')
GO

insert into genEntidadesBasicas(Entidad_Id, Descripcion) Values(1518, 'Tipo Otros Pagos')
GO





INSERT INTO tesIdentifica(Cartera_Id, Descripcion, TipoCartera, Empresa_Id, ModiCent1, ModiCent2, Reservado, VaAlCashFlow, Inactivo, Usuario_id, Posteado, Centro1_Id, Centro2_Id)
	Values('CLI','Clientes', dbo.FuncFktesTiposId('RE'),null, 0,0,0,0,0,1,1, dbo.FuncFKconCentro1(' '),dbo.FuncFKconCentro2(' '))

INSERT INTO tesIdentifica(Cartera_Id, Descripcion, TipoCartera, Empresa_Id, ModiCent1, ModiCent2, Reservado, VaAlCashFlow, Inactivo, Usuario_id, Posteado, Centro1_Id, Centro2_Id)
	Values('ANTCL','Clientes', dbo.FuncFktesTiposId('RE'),null, 0,0,0,0,0,1,1, dbo.FuncFKconCentro1(' '),dbo.FuncFKconCentro2(' '))

INSERT INTO tesIdentifica(Cartera_Id, Descripcion, TipoCartera, Empresa_Id, ModiCent1, ModiCent2, Reservado, VaAlCashFlow, Inactivo, Usuario_id, Posteado, Centro1_Id, Centro2_Id)
	Values('PRO','Proveedores', dbo.FuncFktesTiposId('RE'),null, 0,0,0,0,0,1,1, dbo.FuncFKconCentro1(' '),dbo.FuncFKconCentro2(' '))

INSERT INTO tesIdentifica(Cartera_Id, Descripcion, TipoCartera, Empresa_Id, ModiCent1, ModiCent2, Reservado, VaAlCashFlow, Inactivo, Usuario_id, Posteado, Centro1_Id, Centro2_Id)
	Values('ANTPR','Proveedores', dbo.FuncFktesTiposId('RE'),null, 0,0,0,0,0,1,1, dbo.FuncFKconCentro1(' '),dbo.FuncFKconCentro2(' '))

INSERT INTO tesIdentifica(Cartera_Id, Descripcion, TipoCartera, Empresa_Id, ModiCent1, ModiCent2, Reservado, VaAlCashFlow, Inactivo, Usuario_id, Posteado, Centro1_Id, Centro2_Id)
	Values('DFC','Diferencia en Cambios', dbo.FuncFktesTiposId('RE'),null, 0,0,0,0,0,1,1, dbo.FuncFKconCentro1(' '),dbo.FuncFKconCentro2(' '))
GO




Insert Into conGrupoCentro (Grupo_Id, Centro1_Id, Centro2_Id) Values (dbo.FuncFKconGruposCont('*'), dbo.FuncFKconCentro1('*'), dbo.FuncFKconCentro2('*'))
Insert Into conGrupoCentro (Grupo_Id, Centro1_Id, Centro2_Id) Values (dbo.FuncFKconGruposCont('%'), dbo.FuncFKconCentro1('%'), dbo.FuncFKconCentro2('%'))
Insert Into conGrupoCentro (Grupo_Id, Centro1_Id, Centro2_Id) Values (dbo.FuncFKconGruposCont('0'), dbo.FuncFKconCentro1(''), dbo.FuncFKconCentro2(''))

insert into genLexico values('PROLEXICO','MAX','Devuelve_el_maximo_valor_entre_los_dos_numeros',168,'N')
insert into genLexico values('PROLEXICO','MIN','Devuelve_el_minimo_valor_entre_los_dos_numeros',168,'N')
insert into genLexico values('PROLEXICO','IIF','Funcion_condicional',113,'N')
insert into genLexico values('PROLEXICO','VAR','Devuelve_el_valor_de_una_variable_global',100,'N')

Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'PADRON', 'Valor_del_padron_del_parametro', 123, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'NCDEVOL', 'Indica_si_es_NC_por_devolucion', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'ASIGPORC', 'Asigna_valor_recibido_al_porcentaje', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'MUEVESTOCK', 'Indica_si_el_subtipo_mueve_stock', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'PCIACLIE', 'Provincia_de_facturacion_del_cliente', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'PCIACLIEENTR', 'Provincia_de_entrega_del_cliente', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'TIPOMOV', 'Indica_se_es_Factura_Debito_o_cRedito', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASIMPUESTOS', 'IIF', 'Condicional', 113, 'U')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASIMPUESTOS', 'NG', 'Neto_gravado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASIMPUESTOS', 'SUBTIPO', 'SubTipo_de movimientos_de_ventas', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASIMPUESTOS', 'CAMBIO', 'Tipo_de_cambio_del_movimientos_de_ventas', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) values ('VENTASIMPUESTOS', 'PORCE', 'Porcentaje_cargado_en_el_Impuesto', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'PORCEASOC', 'Porcentaje_del_impuesto_del_comprobante_asociado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'EXENCION', 'Porcentaje_de_exencion_de_la_jurisdiccion', 123, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'DTODO', 'Indica_si_completa_la_NC_para_ese_impuesto', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'IF0', 'IF0(par1, par2) Devuelve_par2_si_par1_es_cero_sino_par1', 168, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASIMPUESTOS', 'ATRICLIE', 'Devuelve_el_atributo_X_del_cliente', 100, 'N')

iNSERT INTO venSubTipoMov(SubTipoMov_Id, Empresa_Id, venTipoMov, Descripcion, MueveStock, EsVentaContado, AdmiteDevolucion, ModificaPrecio, Reservado, GeneraRemito, SegmentoRemito_Id, NCxDevolucion, UsuarioAutorizado, AdmiteBoniRenglon, Centro1_Id, Centro2_Id, PideCambio, ModFecha, ModCondPago, ModVendedor, ModCobrador, PideObervaciones, CantidadCopias, ModDeposito, ModListaPrecios, PideFechaEntrega, PideObsReng, CtaDefecto, ModCtaDefecto, ModCentro1, ModCentro2, PideOtrosCargos, CtaOtrosCargos, PermModCtaOtCar, FechaEntregaporRen, AdmiteFactsinEntr, ModiUniMed, AfectaComVenta, AfectaComCobra, MaxCantItems, EsPorDifPrecio, AfectaEstadistica, ClaveAcceso, EsPorDifCambio, TipoPrecioForm, SoloImpuestos, CodigoFormulario, BajoCosto, Administrativa, PideReferencia, PideOrdenCompra, PideCongelarCambio, PideMarcaReserva, Inactivo, Usuario_Id, Posteado, PermiteSoloEntrega, CodigoFiscal, PidePredial, PideCodProd, PideComExpoMX, PorCotizacion) 
VALUES('PAGOS', 1, 'P', 'Pagos a Clientes', 0, 0, 0, 0, 0, 0, Null, 0, 2, 0, Null, Null, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, Null, 0, 0, 0, 0, Null, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, '', 0, Null, 0, 0, 0, 0, 0, 0, 0, 1,1, 0, Null, 0, 0, 0, 0)

INSERT INTO comMovTipos (Tipomov, Descripcion, Signo) Values('Q','Reversion OP', -1)

INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) Values(11,'Tipo Retencion')



INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ABS','ABS(nExp). Valor absoluto.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ACUM','ACUM(CodDesde, CodHasta [, nLapso]). Suma importes del rango de concepto del mes actual nLapso meses',102,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ANIO','Año de la liquidación en curso.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ANIOMENOS','AnioMenos(nMeses). Al mes actual le resta nMeses y devuelve el año correspondiente.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ANT','Años de antigüedad del empleado.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ANTB','Años de antigüedad a la fecha de baja.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ANTD','Años de antigüedad a diciembre.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','BAJA','Fecha de baja del legajo en curso.',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','BASEISR','BASE ISTP ([MES],[ANIO]).',110,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','BASESDI','BASESDI([mes],[anio]) Base para el calculo del SDI.',110,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','BASESS','Base Imponible Seguridad Social',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','CAF','CAF("25/09/91"). Convierte Caracter A Fecha. Sirve para hacer comparaciones entre fechas.',123,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','CANT','CANT(codDesde, CodHasta [,nMes [, nAño [, nVez]]]). Cantidad liquidada del rango de conceptos.',108,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','PUESTO','Código del Cargo',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','CAT','Código de categoría del empleado.',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','COD','COD(nCod). Importe liquidado para este concepto.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','CTROCOSTO','Centro de Costo asociado al legajo.',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','RFC','RFC',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','CUOTAFIJA','CUOTAFIJA(nExpr1, nMonto). Devuelve el monto a retener según ganancias de la tabla nExpr1.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DATO','Valor ingresado por la opción de carga de DATO().',120,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DIASB','Dias a Restar por Baja',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DIASI','Dias a Restar por Ingreso Reciente',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DIASUA','Dias Ultimo Año',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DIASVAC','Son los días calculados de vacacaciones que corresponde según la antigüedad.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DVAC','Días que corresponden de vacaciones',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DVACCORR','Días corridos que corresponden de vacaciones',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EDAD','Es la edad al últ. día del mes.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EGR','Fecha de egreso del empleado.',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EGRA','Año de Egreso.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EGRD','Día de Egreso.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EGRM','Mes de Egreso.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EMPR','Nombre de la Empresa. (que se está',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ENT','ENT(nExp). Parte entera.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ENVAC','Días de vacaciones del mes que se liquida.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','EXISTESEMANA','Da 0 si la semana no fue generada y 1 si lo fue',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','FCHA','Fecha de liquidación actual.',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','FECHA_PAGO','Fecha de Pago del Recibo.',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','FECHAINIINFO','Fecha Inicio descuento infonavit del empleado',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','GANPOR','GANPOR(nExpr1, nMonto). Devuelve el monto a retener según ganancias de la tabla nExpr1.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','GETVAR','GETVAR( nVariable ). Devuelve el valor almacenado por PUTVAR(nVariable)/PUTVAR0(nVariable).',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','GRUPO','Numero del Grupo de la liquidacion',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','HORA','HORA(nIndice) de la categoría del legajo.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','IIF','IIF(condición, expr3, expr4). Si condición es verdadero, devuelve expr1, sino devuelve expr2.',113,'U')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','IMP','IMP(nIndice). Devuelve el valor del rengón nIndice de los importes de cada legajo.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','IMPMAR','IMPMAR(nExpr1, nMonto). Devuelve el monto a retener según ganancias de la tabla nExpr1.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','INGA','Año de ingreso del empleado.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','INGD','Día de ingreso del empleado.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','INGM','Mes de ingreso del empleado.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','INGMREC','Mes de Ingreso con considerando los Meses reconocidos.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','INGR','Fecha de Ingreso del Empleado.',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NEMPLE','Numero de Empelado',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MAX','MAX(nExpr1, nExpr2). Máximo entre las dos expresiones.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MES','Mes de la liquidación actual.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MESMENOS','MESMENOS(nMeses). Al mes actual le resta nMeses y devuelve el mes correspondiente.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MESP','Mes de Pago de la liquidación actual.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MIN','Mínimo entre dos expresiones.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MOD','MOD(nExpr1, nExpr2). Es el resto de dividir nExpr1 por nExpr2.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','MOD1','Idem MOD pero si el resultado es 0, devuelve nExpr2.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NAC','NAC(nExp). Convierte el número nExp a caracter.',100,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NACA','Año de Nacimiento del empleado.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NACD','Día de Nacimiento del empleado.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NACIM','Fecha de nacimiento del empleado.',103,'D')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NACM','Mes de Nacimiento.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NETO','Neto del recibo.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NROCEDINFO','N° Credito infonavit del empleado',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','NROIMSS','Numero de IMSS',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','PCIA','Nombre de la Provincia del domicilio del empleado.',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','POT','POT( nBase, nExponente). nBase elevado a nExponente.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','PUTVAR','PUTVAR( nVariable, nExpr). Almacena en nVariable nExpr para usarlo luego con GETVAR. Devuelve nExpr.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','PUTVAR0','PUTVAR( nVariable, nExpr). Almacena en nVariable nExpr para usarlo luego con GETVAR. Devuelve 0.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','QUIN','Quincena que se está liquidando.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SEM','Semana que se está liquidando.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','DECE','Decena que se está liquidando.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','REGPATRO','Registro Patronal',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SCANTPER','SUM1(CodDesde, CodHasta ,nLapso). SUMA CANTIDAD DEL PERIODO DATO',102,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SCANTPER1','SCANTPER1(CodDesde, CodHasta ,nLapso). SUMA CANTIDAD DEL PERIODO CANT',102,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SDATO','SDATO(CodDesde, CodHasta [,nMes [,nAño [,nVez]]]). Suma los rangos. va por Datos Variables.',108,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SEXO','Sexo: "M" = Masculino, "F" = Femenino.',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SUCURSAL','Sucursal del Cliente',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SUM1','SUM1(CodDesde, CodHasta [,nLapso]). Suma importes del rango de concep. del mes anterior nLapso meses',102,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SUMA','SUMA(CodDesde, CodHasta [,nMes [,nAño [,nVez]]]). Suma los rangos. Sin nMes toma todas las liquidac.',108,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SUMAQUIN','SUMAQUIN(CodDesde, CodHasta [,nMes [,nQuin [,nVez]]]). Suma los rangos. Sin nMes toma todas las liq.',108,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TAB','TAB(nExpr1, nExpr2). De la tabla nExpr1, devuelve el valor de la fila menor o igual más proxima.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TABGAN','TABGAN(nExpr1, nMonto). Devuelve el monto a retener según ganancias de la tabla nExpr1.',168,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TC','Tipo de Categoría M,Q,S,D',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TESUA','Tipo Empleado Sua',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TIPODESCINFO','Tipo de descuento infonavit del empleado',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TIPOPAGO','Devuelve el tipo de pago con el cual se le paga al empleado.',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TMONTO','Monto a descontar por Tope',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TPARCI','Monto de la Parcialidad',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TSALDO','Saldo del monto a descontar por tope',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','TTOTAL','Monto Total del Concepto',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ULTD','Ultimo día del mes que se liquida.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','UNI','Marca el valor que saldrá en la columna cantidad del recibo.',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','VALORINFO','Valor descuento infonavit del empleado',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','VAR','Importe de la Variable Global VAR(x)',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','VEZ','Vez que se está liquidando.',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SUMAA','Suma de Conceto Desde, Concepto Hasta, Propiedad'  ,109,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','SUMAAFPAGO','Suma de Conceto Desde, Concepto Hasta, Propiedad, según fecha de pago' ,109,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values('SUELEXICO','ACUG','ACUG(CodDesde, CodHasta). Acumulado anual para Ganancias según fecha de pago' ,168,'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CONDSERV', 'Condición de servicio del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'DET', 'Nombre de la categoría del empleado', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CTROCOSTO_NOM', 'Centro de Costo (Descripción) asociada al legajo', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CUIL', 'CUIL del empleado', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CUENBAN', 'Cuenta Bancaria del Empleado', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'DOCTIPO', 'Tipo de Documento del Empleado', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'GANCONY', 'Devuelve la cantidad de meses en el año actual que el/la cónyuge está afectado a ganancias', 111, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'GANHIJO', 'Devuelve la cantidad de meses en el año actual que hijos están afectados a ganancias', 111, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'GANOTRO', 'Devuelve la cantidad de meses en el año actual que otros están afectados a ganancias', 111, 'N')

GO


INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('PRDE', 'E', 'Produccion Entrada', 0, 1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias) VALUES('PRDS', 'S', 'Produccion Salida', 0, 1)

GO

insert into comNivelesAuto (NivelAuto_Id, Descripcion, Inactivo, Posteado, Usuario_Id) Values('LI','Descripcion', 0,1, 1)
GO


Insert into comriestados (EstadoRI_Id, Descripcion) Values('A','Autorizado') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('E','Entregado') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('P','Pendiente de Autorizacion') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('R','Rechazado') 
Insert into comriestados (EstadoRI_Id, Descripcion) Values('T','Terminado') 
GO


Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMAOC', 'IIF', 'Condicional', 113, 'U')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMAOC', 'MONTO', 'Monto', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMAOC', 'SIEMPRE', 'Requiere autorización Siempre', 103, 'L')
GO



Insert into tesSubTiposMov (SubTipo_Id, Descripcion,TipoMov, CantCopias) VALUES('PAI','Pago de Impuestos','E',1)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES('SCO', 'S','Salida_de_Componentes',1,1,null)
insert into tesIdentifica(Cartera_Id, Empresa_Id, TipoCartera, Descripcion, Centro1_Id, Centro2_Id, ModiCent1, ModiCent2,
	 Reservado, VaAlCashFlow, Inactivo, Usuario_Id, Posteado)
	VALUES('IMP',NULL, 9, 'Impuestos', 1,1,0,0,0,0,0,1,1)
GO

INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('SUELEXICO','LEGA','Numero de Empelado',103,'N')
INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('SUELEXICO','TIPOLEGA','Convenio',103,'C')

GO
INSERT INTO  tesSubTiposMov (SubTipo_Id, Descripcion, TipoMov, CantCopias, genReportes) VALUES('PAS','Pago_de_Sueldos','E',1,NULL)

INSERT INTO tesIdentifica(Cartera_Id, Empresa_Id, TipoCartera, Descripcion, Cuenta_Id, Centro1_Id, Centro2_Id,
	Moneda_Id, UsuarioAmo, ModiCent1, ModiCent2, CtaValEnTransito, Reservado, VaAlCashFlow ,Inactivo, Usuario_Id, Posteado, FormaDePagoP) 
values('SUE',NULL, 9, 'Sueldos', NULL, 1,1,NULL,  NULL, 0,0,NULL,1,0,0,1,1,'01')
GO


Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'IIF', 'Condicional', 113, 'U')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MONTO', 'Monto', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'SIEMPRE', 'Requiere autorización Siempre', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MVENDEDOR', 'Modificado el Vendedor', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MFORMAE', 'Modificada la forma de entrega', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MLISTAP', 'Modificada la lista de precios', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MBONIFDATO', 'Modificado Dato en pantalla', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MBONIFRENG', 'Modificada bonificación por renglón', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'MPRECIORENG', 'Modificada precio en renglón', 103, 'L')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('ESQUEMANP', 'ESCLIENTE', 'Es Cliente el usuario que ingreso el pedido', 103, 'L')

Insert Into venNivelesAuto (NivelAuto_Id, Empresa_Id, Descripcion, Inactivo,Posteado, Usuario_Id) Values ('LI', null, 'Listo', 0,1, 1)

GO
INSERT Into venEsquemaAuto (EsquemaAuto_Id, Descripcion, Empresa_Id) Values('VC','VALIDACION COMERCIAL',NULL)
GO

Insert into genMenusOrden (Opcion, Orden) Values ('5', '01')
Insert into genMenusOrden (Opcion, Orden) Values ('1', '02')
Insert into genMenusOrden (Opcion, Orden) Values ('2', '03')
Insert into genMenusOrden (Opcion, Orden) Values ('3', '04')
Insert into genMenusOrden (Opcion, Orden) Values ('6', '05')
Insert into genMenusOrden (Opcion, Orden) Values ('9', '06')
Insert into genMenusOrden (Opcion, Orden) Values ('S', '07')
Insert into genMenusOrden (Opcion, Orden) Values ('8', '08')
Insert into genMenusOrden (Opcion, Orden) Values ('4', '09')
Insert into genMenusOrden (Opcion, Orden) Values ('7', '10')
Go


INSERT Into genTamanioHoja(TamanioHoja, Descripcion, AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('CA','Carta',21.59-1.27,27.94-1.27, 8, 10.5, 0,0)
INSERT Into genTamanioHoja(TamanioHoja, Descripcion,AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('A4','A4',21-1.27,29.7-1.27, 8.27-0.5, 11.69-0.5, 0,0)

INSERT Into genTamanioHoja(TamanioHoja, Descripcion,AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('LE','Legal',21.59-1.27,35.56-1.27, 8.5-0.5, 14-0.5, 0,0)

INSERT Into genTamanioHoja(TamanioHoja, Descripcion,AltoIn, AnchoIn, Altocm, Anchicm, AltoPx, AnchoPx) 
VALUES('A3','A4',29.7-1.27,42-1.27, 11.69-0.5, 16.54-0.5, 0,0)
GO

insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(1,'Bancos e inversiones','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(2,'Clientes','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(3,'Deudores Diversos','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(4,'Cuentas Incobrables','1',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(5,'Saldos a Favor ISR e IVA','1',1,0)

insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(51,'Proveedores','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(52,'Acreedores Bancarios','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(53,'Acreedores Diversos','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(54,'Impuestos por Pagar','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(55,'SAR Interno Patron','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(56,'PTU por Pagar','2',1,0)
insert into conRubrosAxi(RubroAxi_Id, Descripcion, Rubro_Id, Posteado, Inactivo) Values(57,'Aport p/fut Aum Cap.','2',1,0)
GO

insert into tesSubTiposMov (TipoMov, SubTipo_Id, Descripcion, CantCopias) values('E', 'PAG', 'PAGO ANTICIPO DE GASTOS', 1)
insert into tesSubTiposMov (TipoMov, SubTipo_Id, Descripcion, CantCopias) values('E', 'RAG', 'RENDICION ANTICIPO DE GASTOS', 1)

GO

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo,CantCopias , Reporte_Id) VALUES('SRI','S','Salida Requicision Interna',1,1,null)
INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo,CantCopias , Reporte_Id) VALUES('ERI','E','Entrada Requicision Interna',1,1,null)
GO


insert into tesTiposId (TipoCartera, Descripcion,FormaDePagoP) values ('GC', 'Gastos por Comprobar', '17')
GO

INSERT INTO genLexico(SetFunciones, Funcion, Descripcion, Token, TipoDato) Values('SUELEXICO','FORMU','FORMULA DEL REPORTE',123,'N')
GO

INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmActivoDiferidoOtros', '', 'Alta_desde_Otros_Sistema', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Alta_desde_otros_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmActivoFijoOtros', '', 'Alta_Otros_Sistemas', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Alta_desde_otros')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmafiActivoDiferido', '', 'Activo Diferido', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Activo_Diferido.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmafiActivoFijo', '', 'Activo Fijo', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Actualizaci%C3%B3n_de_Activo')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmAfiBajas', '', 'Bajas o Disminuciones', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Bajas_o_Disminuciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmAfiBajasCD', '', 'Bajas o Disminuciones Diferido', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Bajas_o_Disminuciones')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmAfiCerrar', '', 'Cierre_de_Mes', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Cierre_de_Periodos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmAfiCrearDepre', '', 'Generar Depreciaciones', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Generar_Depreciaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmAfiCrearDepreCD', '', 'Generar Amortizaciones', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Generar_Amortizaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmAfiImportarXls', '', 'Importar_Xls', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Importar_de_XLS.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmafiRubros', '', 'Rubros', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Rubros.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmafiRubrosCD', '', 'Rubros Diferido', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Rubro_Activo_Diferido.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomAjusteEdoCta', '', 'Ajustes Estado de Cuenta', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Ajustes_Estado_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomCategorias', '', 'Categorias', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Categor%C3%ADas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomCFDISat', '', 'Importar_Xml Cfdi', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Importar_XML_CFDI.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomComprasPagadas', '', 'DIOT', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_DIOT.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomCondFiscal', '', 'Condicion Fiscal Compras', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Condici%C3%B3n_Fiscal.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomConPago', '', 'Condiciones_de_Pago', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Condiciones_de_Pago.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomConsEdoCtaProveedor', '', 'Consulta Estado de Cuenta', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Consulta_de_Estado')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomDespachos', '', 'Despachos_de_importacion', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Pedimento_de_Importaci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomEmbarqueEdtoCta', '', 'Estado de Cuenta Embarque', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Cierre_de_Edo')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomEmbarques', '', 'Embarques', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Embarques.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomEsquemaAuto', '', 'Esquema_de_autorizaciones', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Esquemas_de_Autorizaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomFacturaOC', '', 'Facturas con Ordenes De Compra', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_Orden_Compra.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomFacturasEmbarque', '', 'Facturas por Orden de Embarque', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_por_Orden')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomFacturasVariasOC', '', 'Factura por Varias O.C.', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_por_Varias')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomForEntre', '', 'Formas_de_Entrega', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Formas_de_Entrega.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomHabilitarPagos', '', 'Habilitacion_de_pagos', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Habilitaci%C3%B3n_Pagos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomHabilitarPagosMasiv', '', 'Habilitar Pagos Masivos', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Habilitar_Pagos_Masivos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomImpuestos', '', 'Impuestos_de_Compras', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Impuestos_de_Compras.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomLibros', '', 'Libros de impuestos compras', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Definici%C3%B3n_Libro.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomListaNegraMX', '', 'Lista Negra Mexico', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Importar_Lista_Negra.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomMovProvConStock', '', 'Movimientos con Stock Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_Directas_con')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomMovProvDifPrec', '', 'Diferencias_En_Precios', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Diferencias_en_Precios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomMovProvRemiPend', '', 'Factura de Remitos Pendientes', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_de_Remisiones')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomMovProvSinStock', '', 'Movimientos de Compras Sin Stock', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_Sin_Stock.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomMovProvXml', '', 'Recepcion Complemento de Pago', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Recepci%C3%B3n_Complemento_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomNivelesAuto', '', 'Niveles_de_Autorizacion', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Niveles_Autorizaci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomOCRecepcion', '', 'Recepcion No Codificados', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Recepci%C3%B3n_No_Codificados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomOCRevRecepcion', '', 'Revierte_Recepcion', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Revierte_Recepci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomOrdenComp', '', 'Ordenes de Compra', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_%C3%93rdenes_de_Compra.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomOrdenCompCons', '', 'Consulta_ordenes_de_compra', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Consulta_%C3%93rdenes_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomOrdenCompPendAuto', '', 'Autorizacion_Ordenes_de_Compra', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Autorizaci%C3%B3n_%C3%93rdenes_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomOrigenesFiscales', '', 'Origenes_Fiscales', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Or%C3%ADgenes_Fiscales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmComprasCerrar', '', 'Cierre de Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Cierre_de_Compras.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomProveedores', '', 'Proveedores', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomProvSaldoIni', '', 'Saldos_Iniciales_Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Saldos_Iniciales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomProvTipos', '', 'Tipos_de_Proveedores', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Tipos_de_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomProvXls', '', 'importa xls', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Importar_Proveedores_XLS.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomRegiones', '', 'Regiones', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Regiones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomRequisitosInternos', '', 'Requeriminetos Internos', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Requisici%C3%B3n_Interna.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomRIConciliacion', '', 'Ordenes de Compra Desde RI', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_%C3%93rdenes_de_Compra')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomRIPendAuto', '', 'Autorizaciones de RI', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Autorizaciones_de_RI.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomSolicitudesSat', '', 'Descarga Masiva CFDIs Sat', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Descarga_Masiva_CFDIs.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomTipoPermi', '', 'Tipo_Ordenes_Compra', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Tipo_%C3%93rdenes_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmcomTipoPermiRI', '', 'Tipos de Requerimiento', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Tipos_de_Requerimiento.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAcutalizarCuentaMov', '', 'Actualizar Cuentas de Movimientos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Actualizar_Cuentas_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAnexosGrupos', '', 'Anexos Grupos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Anexos_Grupos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAnexosOrigenes', '', 'Origenes Anexos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Or%C3%ADgenes_Anexos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAsiApeCierre', '', 'Asiento Apertura y Cierre', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Generaci%C3%B3n_Asiento_Apertura')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAsientos', '', 'Asientos_Contabilidad', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_P%C3%B3lizas_Contables.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAsientosApertura', '', 'Marcar Asiento de Apertura', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_P%C3%B3liza_de_Apertura.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAsientosInver', '', 'Invertir_Asiento', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Revertir_P%C3%B3liza.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAsientosReservados', '', 'Asientos Contabilidad Reservados', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_P%C3%B3lizas_Contables_con')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconAsientosTipo', '', 'Asientos_Tipo', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_P%C3%B3lizas_Tipo.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconBaseDistri', '', 'Bases_de_Distribucion', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Bases_de_Distribuci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconCatalogoElectroMX', '', 'Catalogo Electronico MX', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Contabilidad_Electr%C3%B3nica.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconCentro1', '', 'Centro_de_Costos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Centros_de_Costos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconCentro2', '', 'Centro_Alternativo', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Centro_2.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconCuentasActualizacio', '', 'Catalogo_de_Cuentas', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Cat%C3%A1logo_de_Cuentas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconEjercicios', '', 'Ejercicios', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Ejercicios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconEstadoRes', '', 'Consulta_Estados_Financieros', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Consulta_Estados_Financieros.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconFechasCierres', '', 'Consulta de Fechas de Cierres', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Consulta_de_Fechas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconGruposCont', '', 'Grupos_de_Centros', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Grupos_de_Centros.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconIndAjus', '', 'Valores_Indices_de_Ajuste', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Valores_%C3%8Dndices_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconIndicesAjustes', '', 'Indices_de_ajuste', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_%C3%8Dndices_de_Ajuste.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconinfDefGenerar', '', 'Definibles_Generar', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Imprimir_Definibles.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconinfDefinibles', '', 'Definicion_Informes_Definibles', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Definici%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconOrigAplicReng', '', 'Origen y Aplicacion de Fondos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Origen_y_Aplicaci%C3%B3n')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconPeriodos', '', 'Apertura Cierre de Periodos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Apertura_Cierre_Periodos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconRubroAxi', '', 'Rubro Ajuste por Inflacion', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Rubros_para_Ajuste')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconRubros', '', 'Rubros', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Rubros.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconRubrosPrevi', '', 'Anexo de Previsiones', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Anexo_de_Previsiones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconSituPatri', '', 'Situacion_Patrimonial', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Estado_de_Situaci%C3%B3n')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconSubCuentas', '', 'SubCuentas', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_SubCuentas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconTipoEspeciales', '', 'Tipos_Especiales', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Tipos_Especiales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmconTiposContables', '', 'Tipos_Contables', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Tipos_Contables.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenConfiguracionDescar', '', 'Configuracion Descarga Facturas', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Configuraci%C3%B3n_Descarga_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenConfiguracionFE', '', 'Configurar Factura Electronica', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Configuraci%C3%B3n_Factura_Electr%C3%B3nica.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenContadorCopia', '', 'Copia_Primer_Numero', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Copia_Primer_N%C3%BAmero.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenDiasFestivos', '', 'Dias Festivos', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_D%C3%ADas_Festivos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenEmpresas', '', 'Empresas', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Empresas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenGrupos', '', 'Grupos', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Grupos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenMensajes', '', 'Mensajes', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Mensajes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenMonedas', '', 'Monedas', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Monedas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenPaises', '', 'Paises', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Pa%C3%ADses.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenPermisos', '', 'Permisos', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Permisos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenPermisosCopia', '', 'Copiar_Permisos', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Copiar_Permisos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenPrimerNumero', '', 'Definicion Primer Numero', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Definici%C3%B3n_Primer_N%C3%BAmero.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenProvincias', '', 'Provincias', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Estados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenSegmentos', '', 'Segmentos', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Segmentos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenSucursalesEmpr', '', 'Sucursales_de_la_empresa', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Sucursal_Empresas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenUsuarios', '', 'Usuarios', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Usuarios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmgenVariablesUsuario', '', 'Configuracion Seguridad', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Configuraci%C3%B3n_de_Seguridad.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmimpCierre', '', 'Cierre de Impuestos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Cierre_de_Periodos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmImpImpuestos', '', 'Impuestos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Impuestos._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmImpLiquidacion', '', 'Liquidacion_de_Impuestos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_C%C3%A1lculo_de_Impuestos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmimpRetencionesCFDI', '', 'Timbrado de Rentenciones', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Timbrado_de_Retenciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkCausasMovi', '', 'Causas_de_otros_movimientos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Causas_de_Otros')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkCondFisCompra', '', 'CF Compras Productos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Condici%C3%B3n_Fiscal_Compras.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkCondFisVenta', '', 'CF Ventas Productos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Condici%C3%B3n_fiscal_Ventas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkconsKardex', '', 'Consulta de Kardex', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Consulta_Kardex.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkDepositos', '', 'Depositos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Almacenes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkDevolucionesProv', '', 'Devoluciones a Proveedores', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Devoluciones_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEntradasCD', '', 'Cambio de Deposito', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Ingreso_por_Cambio')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEntradasEmbarque', '', 'Entradas Embaque', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Entradas_Embarque.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEntradasOc', '', 'Entradas_por_Orden_de_Compra', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Entradas_por_Orden')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEntradasRemito', '', 'Entradas_Cancelacion_Remitos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Entradas_Cancelaci%C3%B3n_Remitos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEntradasRI', '', 'Entradas  por RI', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Entradas_por_Requerimiento')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEnTransitoCD', '', 'Salidas Cambio de Almacen', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Cambio_de_Almacen.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkEnTransitoCDDirecto', '', 'Cambio de Deposito Directo', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Cambio_Dep%C3%B3sito_Directo.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkExistenciasXDeposi', '', '', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Existencia_Lote_Serie.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkExistenciasXDeposit', '', 'Consulta de Stock', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Consulta_de_Stock.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkFamilias', '', 'Familias', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Familias.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkGrupos', '', 'Grupos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Grupos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkHojaDeRuta', '', 'Hoja_de_ruta', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Hoja_de_Ruta.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkHojaRutaCerrar', '', 'Cierre_de_Hoja_de_Ruta', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Cierre_de_Hoja')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkImportarXLSProducto', '', 'Importar Productos de Xls', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Importar_Productos_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkInventario', '', 'Inventarios Fisicos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Inventarios_F%C3%ADsicos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkInventario', 'AR', 'Inventarios Fisicos', 'https://Adv.quasarglobal.com/Adv/InventariosAR/GuiaInventariosADV.html#_Inventarios_F%C3%ADsicos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkInvMoviStk', '', 'Autorizacion de Inventarios', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Autorizaci%C3%B3n_de_Inventarios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkMaxMin', '', 'Maximos y Minimos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_M%C3%A1ximos_y_M%C3%ADnimos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkMoviCabeEntradasCau', '', 'Ingresos_por_otras_causas', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Ingresos_por_Otras')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkMoviCabeSalidasCaus', '', 'Salidas_por_otras_causas', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Salidas_por_Otras')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkMoviProv', '', 'Remitos de Proveedores', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Remisiones_de_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkProductos', '', 'Productos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Productos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkProductosPlantilla', '', 'Plantillas de Productos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Plantillas_de_Productos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkRemiCancPend', '', 'Quitar Remitos Pendientes', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Quitar_Remitos_Pendientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkRemiConforma', '', 'Conformacion_de_Remisiones', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Conformaci%C3%B3n_de_Remisiones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkRemisionFactura', '', 'Remision de Facturas Pendientes', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Remisi%C3%B3n_de_Facturas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkRevaluoManual', '', 'Revaluo Manual de Stock', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Reval%C3%BAo_Manual.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkSalidasRemito', '', 'Remitos_a_clientes', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Remisiones_a_Clientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkSalidasRI', '', 'Salidas por RI', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Salidas_por_Requerimiento')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkSubTipoMov', '', 'Sub Tipos Mov', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Configuraci%C3%B3n_de_Subtipos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkTipos', '', 'Tipos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Tipos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstkUniMed', '', 'Unidades de Medida', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Unidades_de_Medida.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmstockCerrar', '', 'Cierre_de_Periodo', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Cierre_de_Periodos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueArchivosTxt', '', 'Configuracion Archivos de Texto', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Configuraci%C3%B3n_Archivos_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueCategorias', '', 'Categorias', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Categor%C3%ADas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueCateNombre', '', 'Nombre Importes Categorias', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Nombre_Importes_Categor%C3%ADas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueCierre', '', 'Cierre de Sueldos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Cierre_de_Sueldos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueConcAcum', '', 'Actualizacion de Descuento por Tope', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Actualizaci%C3%B3n_de_Descuento')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueConceptos', '', 'Conceptos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Percepciones_y_Deducciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueConsRecibo', '', 'Consulta de Recibos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Consulta_de_Recibos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueConvenio', '', 'Convenio', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Convenio.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueDatos', '', 'Ingreso de Dato por Empleado', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Ingreso_de_Dato')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueDatoXConcepto', '', 'Ingreso de Dato por Concepto', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Ingreso_de_Dato_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueDatoXLS', '', 'Ingreso de Dato desde Excel', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Ingreso_de_Dato_2')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueGanancias', '', 'Tablas_Ganancias', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Tablas_Ganancias.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueGenerarArchivosTxt', '', 'Generar Archivos De Texto', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Generar_Archivos_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueGrupos', '', 'Grupos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Grupos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueImpNombre', '', 'Nombre Importe_Personal', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Nombre_Importes_Personal.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiqCategoHistorico', '', 'Historia de Importes Categorias', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Historial_de_Importes')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiqPersImporte', '', 'Carga_de_Importes_Por_Empleado', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Carga_de_Importes')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiqPersImportesHist', '', 'Historial de Importes', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Historial_de_Importes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiqPersImporteXLS', '', 'Importar Importes Desde Excel', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Importar_Importes_desde')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiquidacion', '', 'Liquidacion_de_Sueldos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Generaci%C3%B3n_de_N%C3%B3minas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiqVarGlobales', '', 'Variables Globales', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Variables_Globales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueLiqVarGlobalesHisto', '', 'Historial de Variables Globales', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Historial_de_Variables')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsuePagosHabi', '', 'Habilitacion_de_Pagos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Habilitaci%C3%B3n_de_Pagos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsuePeriodicidad', '', 'Periodicidad', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Periodicidad.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsuePersonal', '', 'Personal', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Personal.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsuePersonalXLS', '', 'Cargar Personal de Excel', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Cargar_Personal_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsuePlantilla', '', 'Plantilla de Centros', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Plantilla_de_Centros.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsuePuestos', '', 'Puestos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Puesto.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueTablas', '', 'Tablas_Generales', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Tablas_Generales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueTablasVacaciones', '', 'Tablas de Vacaciones', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Tablas_de_Vacaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueTimbradoRecibos', '', 'Timbrado de Recibos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Timbrado_de_Recibos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueTipoPago', '', 'TipoPago', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Tipo_Pago.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVacCorresponden', '', 'Carga de Dias Correspondientes de Vacaciones', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Carga_de_D%C3%ADas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVacTomadas', '', 'Carga de Vacaciones', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Carga_de_Vacaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVarGlobales', '', 'Nombres Variables Globales', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Nombres_Variables_Globales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVariables', '', 'Activar_Conceptos_por_Empleado', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Activar_Conceptos_por')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVariablesCopiar', '', 'Copiar Variables', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Copiar_Variables.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVariablesMasivas', '', 'Activar_Conceptos_por_Rango_de_Empleados', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Activar_Conceptos_por_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmsueVariablesMasivoElim', '', 'Inactivar_Conceptos_por_Rango_de_Empleados', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Inactivar_Conceptos_por')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenAjuEdoCta', '', 'Ajustes Estado de Cuenta', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Ajustes_estado_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCamiones', '', 'Actualizacion_de_camiones', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Actualizaci%C3%B3n_de_Camiones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCanjeNotas', '', 'Canje de Notas de Ventas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Canje_de_Notas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCategCredito', '', 'Catergoria de Credito', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Categor%C3%ADa_de_Cr%C3%A9dito.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenClientes', '', 'Clientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Clientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenClientesSaldoIni', '', 'Saldos Iniciales Clientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Saldos_Iniciales_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenClieXLS', '', 'importart clientes de XLS', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Importar_Clientes_desde')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCobradores', '', 'Cobradores', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Cobradores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCondFiscal', '', 'Condicion Fiscal', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Condici%C3%B3n_Fiscal._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCondPago', '', 'Condiciones de Pago Ventas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Condiciones_de_Pago.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenConsEdoCtaClientes', '', 'Consulta_Estado_de_Cuenta_Clientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Consulta_Estado_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenConsPedidosClie', '', 'Consulta de Pedidos por Cliente', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Consulta_Pedidos_por')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenCotizaciones', '', 'Cotizaciones', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Cotizaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenEnviarCancelaciones', '', 'Enviar Cancelaciones Diferidas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Enviar_Cancelaciones_Diferidas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenEsquemaAuto', '', 'Esquema_de_autorizaciones', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Esquema_de_Autorizaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenFactAnulHasta', '', 'Anulacion de Facturas No Registradas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Anulaci%C3%B3n_de_Facturas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenFacturacionPedido', '', 'Facturacion_de_un_pedido', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Facturaci%C3%B3n_de_un')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenFacturacionRemito', '', 'Facturacion Remitos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Facturaci%C3%B3n_Remitos_Pendientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenFormaEntrega', '', 'Forma de Entrega', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Formas_de_Entrega.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenGeneraRemitoFactura', '', 'Generacion_de_remitos_facturas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Generaci%C3%B3n_de_Remisiones')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenGraVentas', '', 'Grafico de Ventas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Gr%C3%A1fico_de_Ventas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenImprimirComprobante', '', 'Re-Imprimir Comprobantes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Reimprimir_Comprobantes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenImpuestos', '', 'Impuestos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Impuestos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenLibros', '', 'Libro impuesto ventas', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Libro_impuestos_ventas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenLimiteCredito', '', 'Limite De Credito', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_L%C3%ADmite_de_Cr%C3%A9dito.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenListasCoeficiente', '', 'Coeficiente Lista', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Coeficiente_Lista.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenListasCopiar', '', 'Copiar Lista Precios', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Copiar_Listas_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenListasPrecios', '', 'Listas_de_precios', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Listas_de_Precios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenListasPrecXLS', '', 'Importar Listas de Excel', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Listas_de_Precios')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenMovConforma', '', 'Conformacion_de_Facturas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Conformaci%C3%B3n_de_Facturas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenMoviAnuladas', '', 'Consulta de Movimientos Anulados', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Consulta_de_Movimientos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenMovimientosConStock', '', 'Facturas con Stock', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Codificados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenMovimientosSinStock', '', 'Movimientos Sin Stock', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_No_Codificados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenNivelesAuto', '', 'Niveles_de_Autorizacion', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Niveles_de_Autorizaci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenPediAutoriza', '', 'Autorizacion_de_pedidos_por_limite_de_credito', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Autorizaci%C3%B3n_de_pedidos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenPedidos', '', 'Actualizacion_Pedidos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Actualizaci%C3%B3n_de_Pedidos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenPedidosCons', '', 'Consulta de Pedidos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Consulta_de_Pedidos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenPedidosDesechar', '', 'Desechar_pedido_pendiente', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Desechar_pedido_pendiente.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenPedidosFactuAnticip', '', 'Facturacion Anticipo', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Facturaci%C3%B3n_de_un_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenPedidosVCAutoriza', '', 'Autorizacion_comercial', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Autorizaci%C3%B3n_comercial.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenRegion', '', 'Regiones', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Regiones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenReparto', '', 'Actualizacion_de_repartos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Actualizaci%C3%B3n_de_Repartos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenRepartoCierre', '', 'Cierre_de_Reparto', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Cierre_de_Repartos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenSubTipoMov', '', 'Sub_Tipo_de_Movimientos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Subtipo_de_Movimientos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmVentasCerrar', '', 'Cierre_de_Ventas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Cierre_Ventas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenTiposClie', '', 'Tipos de Clientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Tipos_de_Cliente.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenVendedores', '', 'Vendedores', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Vendedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('frmvenZona', '', 'Zonas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Zonas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rpt_suePlantilla', '', 'Plantilla_Resumido', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Plantilla_de_Centros_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptAfiDepreciaciones', '', 'Depreciaciones', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Reporte_de_Depreciaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptAfiDepreciacionesCD', '', 'Reporte de Amorizaciones', 'https://Adv.quasarglobal.com/Adv/ActivoFijo/GuiaActivoFijoADV.html#_Reporte_de_Amortizaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptBalance', '', 'Balanza_de_Comprobacion', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Balanza_de_Comprobaci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomCatProv', '', 'Catalogo_de_Proveedores', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Cat%C3%A1logo_de_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomCompRegistrados', '', 'Comprobantes_Registrados', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Comprobantes_Registrados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomCompSaldo', '', 'Composicion de Saldos Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Composici%C3%B3n_de_Saldos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomCostosImportacion', '', 'Costo de Importacion', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Costo_de_Importaci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomEdocta', '', 'Informe Estado de Cuenta', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Informe_de_Estado')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptComFactARecibirImp', '', 'ComFactARecibirImp', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_An%C3%A1lisis_de_Facturas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptComFactARecibirNac', '', 'Facturas A Recibir', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Facturas_a_Recibir')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomFactProvMenores', '', 'Informe_de_Facturas_de_Proveedores_Menores', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Informe_de_Facturas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomImpPagados', '', 'Impuestos Pagados', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Impuestos_Pagados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomLibros', '', 'libros de compras reporte', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Libros_de_Compras.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomOrdenCompra', '', 'Ordenes de Compra', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_%C3%93rdenes_de_Compra._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomPagosHabi', '', 'comPagosHabi', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Informe_de_Pagos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptComPosfinancieraDeta', '', 'Posicion Financiera', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Posici%C3%B3n_Financiera.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomPrevCompras', '', 'Prevision_de_Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Previsi%C3%B3n_de_Compras.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomReqInternoDet', '', 'Requerimientos Internos', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Requerimientos_Internos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomSaldosProv', '', 'Saldos_de_Proveedores', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Saldos_de_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptComSaldoXCuenta', '', 'Saldo Por Cuenta', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Saldo_por_Cuenta.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptComSubDiario', '', 'Sub Diario De Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Sub_Diario_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptComSubMayor', '', 'Sub Mayor De Compras', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Sub_Mayor_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptcomUltimasCompras', '', 'Ultimas Compras por Producto', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_%C3%9Altimas_Compras_por')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconBalanzaXCentro', '', 'Balanza Por Centro De Costos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Balanza_por_Centros')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconCentro1', '', 'Centro de Costo', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Centros_de_Costos._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconCentro2', '', 'Centros Alternativos', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Centros_Alternativos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconComprasEjercicio', '', 'Comrpas Ejercicio', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Compras_Ejercicio.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconCuentas', '', 'Catalogo_de_Cuentas', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Cat%C3%A1logos_de_Cuentas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconEdoRes', '', 'Estado de Resultados', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Estado_de_Resultado')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconGruposCont', '', 'Grupos_de_Centros', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Grupos_de_Centros._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconInfAxiMx', '', 'Aujuste por Inflacion MX', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Determinaci%C3%B3n_Ajuste_por')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconMayor', '', 'Mayor Contable', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Mayor_Contable_Detallado.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconMayorRes', '', 'Mayor_Contable_Resumido', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Mayor_Contable_Resumido.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconSituPatri', '', 'Situacion Patrimonial', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Estado_de_Situaci%C3%B3n_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconSubDiario', '', 'Sub_Diario_Contable', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Sub_Diario_Contable.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptconSubDiarioRes', '', 'Sub Diario Resumido', 'https://Adv.quasarglobal.com/Adv/Contabilidad/GuiaContabilidadADV.html#_Subdiario_Resumido.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptgenPermisos', '', 'Permisos por Usuario', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Permisos_por_Usuario.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptgenUsuGrupo', '', 'Usuarios Por Grupo', 'https://Adv.quasarglobal.com/Adv/Generalidades/GuiaGeneralidadesADV.html#_Permisos_por_Grupo.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptimpControlCfdi', '', 'Control de Cfdis Emitidos', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Control_de_CFDIs')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptMatrizDistribMonto', '', 'Matriz_de_Distribucion', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Matriz_de_Distribuci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptRankProv', '', 'RankProv', 'https://Adv.quasarglobal.com/Adv/Compras/GuiaComprasADV.html#_Ranking_de_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkAFecha', '', 'Stock A Fecha', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Inventario_a_Fecha.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkAnaMoviStock', '', 'Analisis de Movimientos de Stock', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_An%C3%A1lisis_de_Movimientos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkEnsambles', '', 'Ensambles', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Ensambles.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkExceso', '', 'Exceso de Stock', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Exceso_de_Stock.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkInvAjustes', '', 'Informe de Ajustes Necesarios', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Informe_de_Ajustes')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkInvIngresado', '', 'Informe Inventario Ingresado', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Informe_Inventario_Ingresado.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkMaxMin', '', 'Maximos y Minimos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_M%C3%A1ximos_y_M%C3%ADnimos._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkMercTransImp', '', 'Mercancias_En_Transito_Importacion', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Mercanc%C3%ADas_en_Tr%C3%A1nsito_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkMercTransLoc', '', 'Mercancias En Transito', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Mercanc%C3%ADas_en_Tr%C3%A1nsito')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkOtrosMovimientos', '', 'Otros_Movimientos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Otros_Movimientos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkProdSinMovimientos', '', 'Productos sin Movimientos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Productos_sin_Movimiento.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkProductos', '', 'Informe de Productos', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Informe_de_Productos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkRankConsumo', '', 'Ranking De Consumo', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Ranking_de_Consumo.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkRemiPendFact', '', 'Remitos Pendientes de Facturar', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Remisiones_Pendientes_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkReposicion', '', 'Reposicion de Stock', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Reposici%C3%B3n_de_Stock.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkRotacion', '', 'StkRotacion', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Rotaci%C3%B3n_de_Productos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkSeguimientoDespa', '', 'Seguimiento de Despachos Importacion', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Seguimiento_de_Pedimentos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkSeguimientoSerie', '', 'Seguimientos de Numeros de Serie/Lote', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Seguimiento_de_N%C3%BAmeros')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkSubDiario', '', 'Sub Diario de Inventarios', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_SubDiario_de_Inventarios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkSubMayor', '', 'Mayor De Stock', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_SubMayor_de_Inventarios.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkTraspasosPend', '', 'Traspasos_Pendientes', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Traspasos_Pendientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStkxAlmacen', '', 'Stock por almacen', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Inventario_por_Almac%C3%A9n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptstkXDeposito', '', 'Existencia_por_Deposito', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Existencia_por_Dep%C3%B3sito.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptStockNegativo', '', 'Stock_Negativo', 'https://Adv.quasarglobal.com/Adv/Inventarios/GuiaInventariosADV.html#_Productos_con_Stock')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueAcumAnual', '', 'Acumulados_Anuales', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Acumulados_Anuales.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueConcDesc', '', 'Descuentos por Tope', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Descuentos_por_Tope.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueConceptos', '', 'Conceptos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Percepciones_y_Deducciones._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueConceptosDet', '', 'Conceptos Detallado', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Percepciones_y_Deducciones_1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueConceptosRes', '', 'Conceptos Resumidos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Percepciones_y_Deducciones')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueDetAsiConc', '', 'Detalle de Asiento por Concepto', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Detalle_de_Asiento')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueEmpleados', '', 'Empleados', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Empleados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueNetos', '', 'Netos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Netos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueNomina', '', 'Nomina', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_N%C3%B3mina.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsuePlantillaDetalle', '', 'Plantilla de Centros Detallado', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Plantilla_de_Centros')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueRecibo', '', 'Recibo de Sueldos', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Recibos_de_Sueldo.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueSubDiario', '', 'Sub Diario', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Sub_Diario.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptsueSubMayor', '', 'Sub Mayor', 'https://Adv.quasarglobal.com/Adv/Sueldos/GuiaSueldosADV.html#_Sub_Mayor.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenAnaMora', '', 'Analisis_de_Mora', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_An%C3%A1lisis_de_Mora.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenAplicaciones', '', 'venAplicaciones', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Aplicaciones.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenClientes', '', 'venClientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Clientes._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenCompSaldos', '', 'Composicion_de_Saldos_Ventas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Composici%C3%B3n_de_Saldos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenContribMarg', '', 'venContribMarg', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Contribuci%C3%B3n_Marginal.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenControlEntrega', '', 'Control de Entregas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Control_de_Entregas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenCorteDocu', '', 'Corte de Documentacion', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Corte_de_Documentaci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenEdoCta', '', 'Estado_de_Cuenta_Clientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Estado_de_Cuenta')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenFactProdPend', '', 'venFactProdPend', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Facturas_por_Producto')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenHojaRuta', '', 'Hoja_de_Ruta', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Hoja_de_Ruta.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenImpCobrados', '', 'Impuestos Cobrados', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Impuestos_Cobrados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenLibros', '', 'Libros de Ventas', 'https://Adv.quasarglobal.com/Adv/Impuestos/GuiaImpuestosADV.html#_Libros_de_Ventas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenLimiteCredito', '', 'Limites_de_Credito', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_L%C3%ADmites_de_Cr%C3%A9dito.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenListaPrecios', '', 'venListaPrecios', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Listas_de_Precios._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenMercAutorizada', '', 'Mercancia Autorizada', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Mercanc%C3%ADa_Autorizada.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenMovimientoXSubTipoM', '', 'Por SubTipo de Movimiento', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Por_Sub_Tipo')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPedArtPendDeta', '', 'Articulos_Pedidos_Pendientes_Detallado', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Art%C3%ADculos_Pedidos_Pendientes')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPedArtPendRes', '', 'Articulos Pedidos Pendientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Art%C3%ADculos_Pedidos_Pendientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPedCliente', '', 'Pedidos Ingresados por Cliente', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Pedidos_Ingresados_por')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPedEstados', '', 'Estado de Pedidos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Estado_de_Pedidos.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPediAutorizados', '', 'Pedidos Autorizados', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Pedidos_Autorizados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPediPendxVend', '', 'Pendidos Pendientes por Vendedor', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Pendientes_por_Vendedor.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPediRetxCred', '', 'Pedidos Retenidos Por Creditos', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Retenidos_por_Cr%C3%A9dito.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPedRankCliente', '', 'Ranking De Pedidos De Clientes', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Ranking_de_Pedidos')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenPosFinanciera', '', 'Posicion Financiera', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Posici%C3%B3n_Financiera.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenProdCotizados', '', 'Productos Cotizados', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Productos_Cotizados.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenRankCli', '', 'venRankCli', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Ranking_de_Clientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenRemiFactAsoc', '', 'venRemiFactAsoc', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Remisiones_y_Facturas')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenRemiPendFact', '', 'venRemiPendFact', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Remisiones_Pendientes_de')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenSaldosClie', '', 'venSaldosClie', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Saldos_de_Clientes.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenSaldoXCuenta', '', 'venSaldoXCuenta', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Deuda_por_Cuenta')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenSubDiario', '', 'venSubDiario', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Sub_Diario.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenSubMayor', '', 'venSubMayor', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Sub_Mayor.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptVentaXCliente', '', 'Ventas_por_Cliente', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Ventas_por_Cliente.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenUnidadesVend', '', 'Unidades_Vendidas', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Unidades_Vendidas.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenVendedores', '', 'venVendedores', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Vendedores._1')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenVentasPeriodo', '', 'Ventas_por_Periodo', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Ventas_por_Periodo.')
INSERT INTO genLinksAyuda(CodigoLnk, Dominio_Id, Descripcion, Link) VALUES('rptvenVentasProducto', '', 'venVentasProducto', 'https://Adv.quasarglobal.com/Adv/Ventas/GuiaVentasADV.html#_Ventas_por_Producto.')


INSERT INTO genEntidadesBasicas(Entidad_Id, Descripcion) Values(1605,'Tipo Inasistencia')



insert into genGlobales VALUES(1,'GENCLIENTESMENU', 'Menu de Clientes','M',2048,0,null,null,null,/**/null,'GEN',1,null,null)
UPDATE genGlobales set mValor = 'MgAyADIAMAA0ADUAOgA1ADIAMQAwADEAMAA6ADUAMgAyADAAOQAwADoANQAzADEAMAAwADAAOgA1ADMAMQAwADcAMAA6ADUAMwA0ADAAMQAwADoANQAzADQAMAAyADAA' where Nombre_Var = 'GENCLIENTESMENU'
GO

Insert Into genEntidadesBasicas (Entidad_id, Descripcion) Values ('1607', 'Obras Sociales')

Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'SETVAR', 'SETVAR( @Variable, nExpr). Almacena en @Variable nExpr para luego devolver el nExpr con @Variable', 169, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'SETVAR0', 'SETVAR0( @Variable, nExpr). Almacena en @Variable nExpr para luego devolver 0', 169, 'N')

INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('afiActivoFijo','Actualizacion_Activo_Fijo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('afiRubros','Rubros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comCategorias','Categorias')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comCondFiscal','Condicion_Fiscal_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comConPago','Condiciones_de_Pago')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comDespachos','Despachos_de_importacion')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comEmbarques','Embarques')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comEsquemaAuto','Esquema_de_autorizaciones_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comForEntre','Formas_de_Entrega_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comImpuestos','Impuestos_de_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comLIbros','Definicion_Libro_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comMovProv','Movimientos_de_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comNivelesAuto','Niveles_de_Autorizacion_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comOrdenComp','Ordenes_de_Compra')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comOrigenesFiscales','Origenes_Fiscales_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comProveedores','Proveedores')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comProvTipos','Tipos_de_Proveedores')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comRegiones','Regiones_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comReqInternos','Requerimientos_Internos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comTipoPermi','Tipo_Ordenes_Compra')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('comTipoPermiRI','Tipos_de_Requerimiento')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conAsientosTipo','Asientos_Tipo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conBaseDistri','Bases_de_Distribucion')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conCentro1','Centro_de_Costos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conCentro2','Centro_Alternativo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conGruposCont','Grupos_de_Centros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conIndicesAjustes','Indices_de_ajuste')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conRubros','Rubros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('conSubCuentas','SubCuentas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genEmpresas','Empresas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genMonedas','Monedas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genPaises','Paises')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genSucursalesEmpr','Sucursales_de_la_empresa')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('genUsuarios','Usuarios')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impImpuestos','Impuestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impJurisdicciones','Jurisdicciones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impLiquidacion','Liquidacion_de_Impuestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('impPadron','Definicion_Padrones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proCausas','Causas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proCentroProductivo','Centro_Productivo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proRecetas','Recetas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proRecuersos','Recursos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('proTrabajo3','Trabajos_Terceros')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkCausasMovi','Causas_de_otros_movimientos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkCondfisCompra','Condicion_Fiscal_Compras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkCondfisVenta','Condicion_Fiscal_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkDepositos','Depositos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkEnTransito','Ingreso_por_Cambio_Deposito')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkFamilias','Familias')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkGrupos','Grupos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkHojaDeRuta','Hoja_de_ruta')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkInventarios','Inventarios_Físicos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkMoviCabe','Movimientos_de_Stock')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkProductosPlantilla','Plantillas_de_Productos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkProductos','Productos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkTipos','Tipos_Stock')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('stkUniMed','Unidades_de_Medida')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueArchivosTxt','Configuracion_Archivos_de_Texto_Sueldos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueCategorias','Categorías')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueConvenio','Convenio')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueGrupos','Grupos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueLiquidacion','Liquidacion_de_Sueldos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('suePersonal','Personal')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('suePuestos','Puestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueTablaVacacion','Tablas_de_Vacaciones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('sueTipoPago','Tipos_de_Pago')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesBancos','Bancos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesCausasRechazo','Causas_de_Rechazo')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesChequeras','Chequeras')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesClearing','Clearing')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesGanancias','Tabla_Ganancias')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesIdentifica','Movimientos_de_Identificadores_Tesoreria')
GO

INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesMovimientos','Movimientos_de_Tesoreria')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('tesSubTiposMov','SubTipo_de_Moivimientos_Tesoreria')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCamiones','Actualizacion_de_camiones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCategCredito','Categoria_de_Credito')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCobradores','Cobradores')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCondFiscal','Condicion_Fiscal')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCondPago','Condiciones_de_Pago')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venCotizaciones','Cotizaciones')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venFormaEntrega','Formas_de_Entrega_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venImpuestos','Impuestos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venLibros','Libro_impuesto_ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venListasPrecios','Listas_de_precios')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venMovimientos','Movimientos_de_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venPedidos','Actualizacion_Pedidos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venRegion','Regiones_Ventas')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venReparto','Actualizacion_de_repartos')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venTiposClie','Tipos_Clientes')
GO
INSERT INTO genAtriGralesClases (Tabla_Id,Descripcion) VALUES ('venZona','Zonas_Ventas')
GO
INSERT INTO genAtriGralesClases(Tabla_Id, Descripcion) Values('venClientes','Clientes')
GO

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES ('ECO','E','Entrada de Componentes',1,1,null)

insert into genLexico values( 'SUELEXICO','ANIV','Devuelve_1_si_el_empleado_cumple_años_de_Antiguedad_o_cero_sino',103,'N')


Insert Into comMovTipos (TipoMov, Descripcion, Signo) Values ('H', 'Cheque_rechazado', -1)
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor) VALUES(1, 'UMCADAUNO','Codigo de UM que representa Unidades', 'C',5,0,'STK', 0, null, null, NULL, NULL, Null, null)	
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor) VALUES(1, 'CFVentasRenglonGravado','CF Gravado renglon facturacion', 'C',5,0,'VEN', 0, null, null, NULL, NULL, Null, null)	
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor) VALUES(1, 'SUBTIPOCHR','Codigo de SubTipoMov Cheque Rechazado', 'C',5,0,'VEN', 0, null, null, NULL, NULL, Null, null)	

Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'TOTCOL', 'ToCol(x) Total de la columna x', 100, 'N')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('1', 'UNICA VEZ')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('2', 'REPETITIVA')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('3', 'DIARIAMENTE')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('4', 'SEMANALMENTE')
INSERT INTO genTiposEjecucionTarea (TipoEjecucionTarea_Id, Descripcion) VALUES ('5', 'MENSUALMENTE')

INSERT INTO genTareas (Tarea_Id, Descripcion) values ('APECAJA','Apertura de Caja')
INSERT INTO genTareasParametros(Tarea_Id,Parametro,Descripcion,Obligatorio) VALUES (dbo.FuncFKgenTareas('APECAJA'), 'Sucursal','Sucursal a Aperturar',1)

insert into genTareas (Tarea_Id, Descripcion) values  ( 'SALDOVENC', 'Envia Correos a Clientes Con Saldos Vencidos')
insert into genTareas (Tarea_Id, Descripcion) values  ( 'RESPALDOS', 'Crea Respaldos de La Base de Datos')
insert into genTareasParametros (Tarea_Id, Parametro, Descripcion, Obligatorio) values (dbo.FuncFKgenTareas('Respaldos'), 'UbicacionRespaldos', 'Carpeta Donde se Guardaran los Respaldos', 1)

Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'AAAAMMDD', 'Devuelve la fecha en el formato AAAAMMDD', 123, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'APEYNOMB', 'Nombre Y Apellido Completo', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'APELLIDO', 'Apellidos y Nombres del Empleado', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'SUBSTR', 'Toma N2 caracteres del string C1 que comienza en N1, SUBSTR(C1,N1,N2)', 172, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CONYU', 'Cónyuge', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'HIJOS', 'Cantidad de Hijos para el Salario Familiar', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'SITUREVIS', 'Situación de revista del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'ACTI', 'Código de Actividad del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'ZONA', 'Código de Zona del empleado', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'APAD', 'Aporte Adicional del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'MODCONTR', 'Modalidad de contrato del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'FAD', 'Cantidad de Fam. Adherentes en la Obra Social', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'APVO', 'Aporte Voluntario del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'FIJO', 'Coloca una cadena de caracteres fijada por el usuario FIJO(''Cadena'')', 123, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'SOLONUM', 'Devuelve solo caracteres numéricos de un campo', 123, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CAMPO', 'Devuelve el valor del Campo. CAMPO(''Campo'')', 123, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CAMPOP', 'Devuelve el valor positivo del Campo. CAMPOP(''Campo'')', 123, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'FECHAF', 'Devuelve la fecha ingresada en el formulario. FechaF(x) siendo x 1, 2 o 3', 100, 'D')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'ENTER', 'Enter', 103, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'CONCEPTOS', 'Conceptos(Informe) de la liquidación analizada', 123, 'C')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'INCAPACIDAD', 'Código de incapacidad del empleado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'REVIS', 'Situaciones de Revista del Empleado en el mes. Revis(x) siendo x 1, 2 o 3', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'REVISD', 'Día de Inicio de la Situación de Revista del Empleado en el mes. RevisD(x) siendo x 1, 2 o 3', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'REGS', 'Devuelve la cantidad de registros (para usar en resúmen)', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('SUELEXICO', 'DEBCRED', '(D)ébito o (C)rédito según concepto', 103, 'C')
go

insert into genLexico (SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES ('SUELEXICO', 'SUMSGN','SUMASGN(CodDesde, CodHasta [,nMes [,nAño [,nVez]]]). Suma los rangos. Sin nMes toma todas las liquidac.',108,'N')

INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','ATRI','Atributo <n> del Articulo',100,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','CANTFAM','Cantidad Facturada de la Familia X ',123,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','CANTOFE','Cantidad de la Oferta ',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','CANTPROD','Cantidad Facturada Producto (''x'')',123,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','CANTRENG','Cantidad Facturada renglon',103,'N')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','LPRECIO','Lista de Precios',103,'C')
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('VENBONIFLEXICO','SUCUEMPR','Sucursal Empresa',103,'C')

INSERT INTO  genEntidadesBasicas(Entidad_Id, Descripcion) Values(504, 'Causas Cancelacion')
GO



INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('VENTASLISTASPRECIOS', 'RENATRIO','Valor Subtotal Renglon por Atributo N Producto',100,'N' )
go
INSERT INTO genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values('VENTASLISTASPRECIOS','SUMATRIO','Suma Subtotal Renglones por Atributo N Producto',100,'N')
Go
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES('VENTASLISTASPRECIOS', 'RENATRI','Valor Subtotal Renglon por Atributo N Producto / 100 ',100,'N' )
go
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES('VENTASLISTASPRECIOS', 'RENATRICLIE','Valor Subtotal Renglon por Atributo N del Cliente Indireccion Producto / 100 ',100,'N' )
go
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES('VENTASLISTASPRECIOS', 'RENATRI1','Valor Subtotal Renglon por Atributo N Producto',100,'N' )
go
INSERT INTO genLexico(SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES('VENTASLISTASPRECIOS', 'RENATRI1PL','Valor a Precio Lista Renglon por Atributo N Producto/100',100,'N' )
go

insert into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) VALUES('VENTASLISTASPRECIOS','TABLA','TABLA DE DESCUENTO <Tab>,<Monto>',168,'N')

--- Carta Porte --
-- c_CveTransporte
Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(13, 'c_CveTransporte')
GO

--  Tipo Estacion
Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(14, 'Clave Estacion')
GO



--  Unidad de Peso y Embalaje
Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(15, 'Unidad Peso y Embalaje')
GO


--- embalaje
Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(17, 'Embalaje')
GO


--- embalaje
Insert into genEntidadesBasicas(Entidad_Id,Descripcion) vALUES(18, 'Tipo de Permiso')
GO




INSERT INTO venTipomov(venTipoMov,Descripcion,Signo,TipoMovResumido) Values('M','Remision',0,'REM')


insert into tesSubTiposMov(SubTipo_Id,Descripcion,TipoMov,CantCopias,genReportes)
VALUES('DNI','Depositos por Identificar','I',1, dbo.FuncFKgenReportes('TESMOVIMIENTOSDH'))

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES('EEMP','E','Entradas desde Empleados',1,1,null)
GO

INSERT INTO stkSubTipoMov (SubTipoMov_Id, TipoMov, Descripcion, Consumo, CantCopias, Reporte_Id) VALUES('SEMP','S','Salidas para Empleados',1,1,null)
GO

-- PRODUCCION
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproRecetas',' ','Recetas','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Receta.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproCentroProductivo',' ','Centro_Productivo','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Centro_Productivo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproRecursos',' ','Recursos','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Recursos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproTrabajo3',' ','Trabajos_Terceros','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Sub_Recursos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproVarGlobales',' ','Globales','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Maquilas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproCausas',' ','Causas','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Globales.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproRecetasCopiar',' ','Copiar_Recetas','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Causas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproRecetasCambioProd',' ','Cambio_Producto_A_x_B','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Copiar_Recetas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproRecetasXLS',' ','Cargar_Recetas_de_Excel','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Cambio_Producto_')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproProgramaProduccion',' ','Programa_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Cargar_Recetas_desde')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproOrdenesGenerar',' ','Generar_Ordenes_Desde_un_Programa','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Programa_de_Producci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproPasarAProduccion',' ','Pasar_Ordenes_a_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Generar_%C3%93rdenes_desde')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproOrdenes',' ','Ordenes','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Pasar_%C3%93rdenes_de')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('renfrmGenerarOP',' ','Generar_OP_Desde_Pedido','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_%C3%93rdenes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproPrograma',' ','Programar_Trabajos_de_Terceros','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Programar_Trabajos_de')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproProgramaSubRecursos',' ','Programacion_de_SubRecursos','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Programaci%C3%B3n_de_SubRecursos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproOrdenCerrar',' ','Cierre_de_Ordenes','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Cierre_de_%C3%93rdenes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproOrdenLimpiar',' ','Limpiar_Ordenes_Incumplidas','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Limpiar_%C3%93rdenes_Incumplidas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproRecetas',' ','Recetas','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Receta._1')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmproExplotar',' ','Explosion_Receta','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Explosi%C3%B3n_de_Receta.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproCadenaProduccion',' ','Cadena_de_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Cadena_de_Producci%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproUsoUnProducto',' ','Uso_de_un_Prodcuto','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Uso_de_un')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproPrograma',' ','Informe_Programa','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Informe_de_Programa.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproProgramaExplotar',' ','Exposion_de_un_Programa','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Explosi%C3%B3n_de_un')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproFaltantes',' ','Faltantes_de_Stock_para_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Faltantes_de_Stock')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproFechasMrp',' ','MRPV','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_MRPV.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproTrabajosCP',' ','Trabajos_por_Centro_Productivo','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Trabajos_por_Centro')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproTrabajosCPDeta',' ','Trabajos_por_Centro_Productivo_Detallado','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Trabajos_por_Centro_1')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproTrabajosRecu',' ','Trabajo_ por_Recurso','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Trabajos_por_Recurso.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproTrabajosProv',' ','Trabajos_por_Proveedor','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Trabajos_por_Proveedor.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproConsMateriales',' ','Consumos_para_el_Proveedor_Interno','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Consumos_para_el')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproOrdenOrigen',' ','Origen_de_Ordenes_de_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Origen_de_%C3%93rdenes')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproMovStockOrden',' ','Movimientos_de_Stock_por_Orden_de_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Movimientos_de_Stock')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproProduccionesPend',' ','Producciones_Pendientes','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Producciones_Pendientes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproProduccionesPeriodo',' ','Producciones_del_Periodo','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Producciones_del_Periodo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproEficiencia',' ','Eficiencia','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Eficiencia.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproCausasMov',' ','Ineficiencias_por_Causa','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Ineficiencias_por_Causa.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproCostos',' ','Costos','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Costos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rptproCostosPorOrden',' ','Costos_por_Orden_de_Produccion','https://Adv.quasarglobal.com/Adv/Produccion/GuiaProduccionADV.html#_Costos_por_Orden')
-- TESORERIA
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdEfectivo',' ','Efectivo','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Efectivo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdAntGC',' ','Anticipos_Gastos_por_Comprobar','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Anticipos_Gastos_por')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdCheques',' ','Cheques_de_Clientes','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cheques_de_Clientes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesBancos',' ','Bancos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Bancos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesClearing',' ','Clearing','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Clearing.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCausasRechazo',' ','Causas_de_Rechazo','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Causas_de_Rechazo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdBancoProp',' ','Bancos_Propios','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Bancos_Propios.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesChequeras',' ','Chequeras','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Chequeras.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdFondoFijo',' ','Fondo_Fijo','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Fondo_Fijo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdVarios',' ','Varios','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Varios.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdFactProv',' ','Facturas_Proveedores','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Facturas_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSubTipoMov',' ','SubTipo_de_Moivimientos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_SubTipo_de_Movimientos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCobranzas',' ','Cobranzas','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cobranzas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesOtrosIngresos',' ','Otros_Ingresos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Otros_Ingresos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCobranzaProv',' ','Cobranza_Proveedores','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cobranzas_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCFDICobranza',' ','Timbrado_de_Cobranzas','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Timbrado_de_Cobranzas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIngDepPorIdent',' ','Depositos_por_Identificar','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Dep%C3%B3sitos_por_Identificar.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdentDepositos',' ','Identificacion_Depositos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Identificaci%C3%B3n_Dep%C3%B3sitos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesPagosProveedores',' ','Pagos_a_Proveedores','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Pagos_a_Proveedores.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmTesOtrosEgresos',' ','Otros_Egresos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Otros_Egresos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesPagosClie',' ','Pagos_a_Clientes','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Pagos_a_Clientes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesReversionOP',' ','Reversion_Pago_a_Proveedores','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Reversi%C3%B3n_Pago_a')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesPagoImpuestos',' ','Pago_de_Impuestos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Pago_de_Impuestos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesPagoSueldos',' ','Pago_de_Sueldos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Pago_de_Sueldos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesDebitosBancarios',' ','Debitos_Bancarios','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_D%C3%A9bitos_Bancarios.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCreditosBancarios',' ','Creditos_Bancarios','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cr%C3%A9ditos_Bancarios.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesDepositoEfectivo',' ','Deposito_Efectivo','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Dep%C3%B3sitos_Efectivo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesDepositoCheques',' ','Deposito_Cheques','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Dep%C3%B3sitos_Cheques.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIngChqRechazados',' ','Cheques_Rechazados_Ingreso','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cheques_Rechazados_Ingreso.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesChequesRechCanje',' ','Canje_Cheques_Rechazados','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Canje_Cheques_Rechazados.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesConciliacion',' ','Conciliacion_Bancaria','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Conciliaci%C3%B3n_Bancaria.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesPartidasInCon',' ','Movimientos_Reg_Banco_y_no_Empresa','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Movimientos_Registrados_por')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCheqPropAnul',' ','Anulacion_de_Cheques','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Anulaci%C3%B3n_de_Cheques.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesCTercerosCambio',' ','Cambios_Cheques_de_Terceros','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Asignar_Datos_Pago.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesAperturaCaja',' ','Apertura_de_caja','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Apertura_de_caja.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesoreriaCerrar',' ','Cierre_de_Tesoreria','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cierre_de_Tesorer%C3%ADa.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesAISaldos',' ','Saldo_Inicial_Bancos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Saldo_inicial_Bancos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSaldoInicial',' ','Saldos_Iniciales_Otros','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Saldos_Iniciales_Otros.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSolicitantes',' ','Solicitantes','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Solicitantes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSolicitud',' ','Solicitud','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Solicitud.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSolicitudAutoriza',' ','Autorización Anticipo Gastos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Autorizaci%C3%B3n_Anticipo_Gastos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSolicitudPago',' ','Pago_Anticipo','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Pago_Anticipo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesSolicitudRendicion',' ','Rendicion','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Rendici%C3%B3n.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesSolAnticipos',' ','Informe_Solicitud_Gastos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Informe_Solicitud_de')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesFlujoFondo',' ','Flujo_de_Fondos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Flujo_de_Fondos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesMovimientosXCartera',' ','Movimientos_por_Cartera','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Movimientos_por_Cartera.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesRendicionCaja',' ','Rendicion_de_Caja','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Rendici%C3%B3n_de_Caja.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesConcBancaria',' ','Conciliacion_Bancaria','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Conciliaci%C3%B3n_Bancaria._1')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesLibroBanco',' ','Libro_Banco','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Libro_Banco.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesIngCobranzas',' ','Ingresos_por_Cobranzas','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Ingresos_por_Cobranzas.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesPagosEmitidos',' ','Pagos_Emitidos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Pagos_Emitidos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesCheqPropImpresion',' ','Impresion_de_cheques','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Impresi%C3%B3n_de_Cheques.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesEstadoCuenta',' ','Estado_de_Cuenta','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Estado_de_Cuenta.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesMovPorSubTipo',' ','Movimientos_por_SubTipo','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Movimientos_por_SubTipo.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesImpresionComp',' ','Impresion_de_Comprobantes','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Impresi%C3%B3n_de_Comprobantes.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesRetenciones',' ','Retenciones','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Retenciones.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesChequesClientes',' ','Cheques de Clientes','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cheques_de_Clientes._1')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesChequesEmitidos',' ','Cheques_Emitidos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cheques_Emitidos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesChequesDevueltos',' ','Cheques_Devueltos','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Cheques_Devueltos.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesSubDiario',' ','Subdiario_Tesoreria','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Sub_Diario_Tesorer%C3%ADa.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesSubMayor',' ','Sub_Mayor','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Sub_Mayor.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('rpttesTiposCambio',' ','Tipos_de_Cambio','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Tipos_de_Cambio.')
INSERT INTO genLinksAyuda(CodigoLnk, DOMINIO_Id, Descripcion, Link) VALUES('frmtesIdentificaSaldo',' ','Saldo_Bancario','https://Adv.quasarglobal.com/Adv/Tesoreria/GuiaTesoreriaADV.html#_Saldo_Bancario.')
GO

INSERT INTO genLexico (SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES ('SUELEXICO','SUMAP','SUMAP(CodDesde, CodHasta [,nMes [,nAño [,nVez]]]). Suma los rangos + Retroactivos. Sin nMes toma todas las liquidac.)',108,'N')
INSERT INTO genLexico (SetFunciones,Funcion,Descripcion,Token,TipoDato) VALUES ('SUELEXICO','DDMMAAAA','Devuelve la fecha en el formato DDMMAAAA',123,'C')
GO

insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATCLIE','MX', 'CATALOGO DE CLIENTES', 'http://adv.quasarglobal.com/adv/CatClientes/GuiaMigraExcelClientes.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATCLIE',' ', 'CATALOGO DE CLIENTES', 'http://adv.quasarglobal.com/adv/CatClientesAr/GuiaMigraExcelClientesAR.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATPROD',' ', 'CATALOGO DE PRODUCTOS', 'http://adv.quasarglobal.com/adv/CatProductos/GuiaCatExcelProductos.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATPROVE','MX', 'CATALOGO DE PROVEEDORES', 'http://adv.quasarglobal.com/adv/CatProvee/GuiaMigraExcelProvee.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('CATPROVE',' ', 'CATALOGO DE PROVEEDORES', 'http://adv.quasarglobal.com/adv/CatProveeAR/GuiaMigraExcelProveeAR.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('INVENTARIO',' ', 'INVENTARIO FISICO', 'http://adv.quasarglobal.com/adv/Inventario/GuiaCargaExcelInventario.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('INVENTARIO','AR', 'INVENTARIO FISICO', 'http://adv.quasarglobal.com/adv/InventarioAR/GuiaCargaExcelInventario.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('LISTASPRE',' ', 'LISTAS DE PRECIOS', 'http://adv.quasarglobal.com/adv/ListasPrec/GuiaCargaExcelListasPrec.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SINICLIE','MX', 'SALDO INICIAL CLIENTES', 'http://adv.quasarglobal.com/adv/SaldoIniClie/GuiaMigraSaldoIniClie.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SINICLIE',' ', 'SALDO INICIAL CLIENTES', 'http://adv.quasarglobal.com/adv/SaldoIniClieAR/GuiaMigraSaldoIniClieAR.html')

insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('REVALUO','', 'Revaluos de Stock', 'http://adv.quasarglobal.com/adv/Revaluos/GuiaMigraRevaluos.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('REVALUOS','', 'Revaluos de Stock', 'http://adv.quasarglobal.com/adv/Revaluos/GuiaMigraRevaluos.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SINIPRO','', 'Saldos Iniciales Proveedores', 'http://adv.quasarglobal.com/adv/SaldoIniProveAr/GuiaMigraSaldoIniProveAr.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SINIPRO','MX', 'Saldos Iniciales Proveedores', 'http://adv.quasarglobal.com/adv/SaldoIniProve/GuiaMigraSaldoIniProve.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SUEPERS','', 'Personal de Sueldos', 'http://adv.quasarglobal.com/Adv/CatPersonalAR/GuiaMigraExcelPersonalAR.html')
insert into genLinksAyuda (CodigoLnk, Dominio_Id, Descripcion, link) Values('SUEPERS','MX', 'Personal de Sueldos', 'http://adv.quasarglobal.com/Adv/CatPersonal/GuiaMigraExcelPersonal.html')



Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'NG', 'Neto_gravado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'PORC', 'Porcentaje_cargado_en_la_definicion_de_la_retencion', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'MINIMO', 'Minimo_cargado_en_la_definicion_de_la_retencion', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'ASIGPORC', 'Asigna_como_porcentaje_el_valor_recibido_como_parametro', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'ASIGBI', 'Asigna_como_base_imponible_el_valor_recibido_como_parametro', 100, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'IIF', 'Funcion_condicional', 113, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'MAX', 'Devuelve_el_maximo_valor_entre_los_2_parametros', 168, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'MIN', 'Devuelve_el_minimo_valor_entre_los_2_parametros', 168, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'TRET', 'Total_retenido_previamente', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'ACUM', 'Acumulado_mensual_gravado', 103, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato)values ('TESRETENCIONES', 'TABLA', 'Tabla_de_ganancias', 168, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('TESRETENCIONES', 'PADRON', 'Valor_del_padron_del_parametro', 123, 'N')
Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('TESRETENCIONES', 'AcumUsu', 'Acumulado_retenido_segun_Usuario', 103, 'N')

Insert Into genLexico (SetFunciones,Funcion,Descripcion,Token,TipoDato) Values ('SUELEXICO','CBA','Cuenta Bancaria',103,'C')

EXECUTE genSegmentosGuardar
   @pSegmento_Id = 'ABONOS'
  ,@pSegmento_Id_Nuevo = 'ABONOS'
  ,@pDescripcion = 'Abonos de ventas'
  ,@pDigitos1N = 8
  ,@pDigitos2N = 0
  ,@pDigitos3N = 0
  ,@pDigitos4N = 0
  ,@pTieneColumnaAutomatica = 1
  ,@pDigitos1C = 4
  ,@pDigitos2C = 0
  ,@pDigitos3C = 0
  ,@pDigitos4C = 0
  ,@pOrigen1N = 1
  ,@pOrigen2N = 0
  ,@pOrigen3N = 0
  ,@pOrigen4N = 0
  ,@pOrigen1C = 11
  ,@pOrigen2C = 0
  ,@pOrigen3C = 0
  ,@pOrigen4C = 0
  ,@pOrden1N = 2
  ,@pOrden2N = 0
  ,@pOrden3N = 0
  ,@pOrden4N = 0
  ,@pOrden1C = 1
  ,@pOrden2C = 0
  ,@pOrden3C = 0
  ,@pOrden4C = 0
  ,@pHabilitaEdicion = 0
  ,@pTamanioVariable = '1N'
  ,@pInactivo = 0
  ,@pUsuario_Id = 1
  ,@pPosteado = 1
  ,@pEsSueldos  = 0
  ,@pEmpiezaEnUno = 0
GO

DECLARE @pSegmento_Id int 
set @pSegmento_Id = dbo.FuncFKgenSegmentos('ABONOS')
EXEC genSegmentosNombresGuardar
   @pSegmento_Id 
  ,@pNombre1N = 'Abono'
  ,@pNombre2N = ''
  ,@pNombre3N= ''
  ,@pNombre4N= ''
  ,@pNombre1C = 'Sucursal'
  ,@pNombre2C= ''
  ,@pNombre3C= ''
  ,@pNombre4C= ''
  ,@pUsuario_Id=1
GO

EXECUTE genSegmentosGuardar
   @pSegmento_Id = 'CICLOABONO'
  ,@pSegmento_Id_Nuevo = 'CICLOABONO'
  ,@pDescripcion = 'Ciclo Facturación Abonos de ventas'
  ,@pDigitos1N = 8
  ,@pDigitos2N = 0
  ,@pDigitos3N = 0
  ,@pDigitos4N = 0
  ,@pTieneColumnaAutomatica = 1
  ,@pDigitos1C = 4
  ,@pDigitos2C = 0
  ,@pDigitos3C = 0
  ,@pDigitos4C = 0
  ,@pOrigen1N = 1
  ,@pOrigen2N = 0
  ,@pOrigen3N = 0
  ,@pOrigen4N = 0
  ,@pOrigen1C = 11
  ,@pOrigen2C = 0
  ,@pOrigen3C = 0
  ,@pOrigen4C = 0
  ,@pOrden1N = 2
  ,@pOrden2N = 0
  ,@pOrden3N = 0
  ,@pOrden4N = 0
  ,@pOrden1C = 1
  ,@pOrden2C = 0
  ,@pOrden3C = 0
  ,@pOrden4C = 0
  ,@pHabilitaEdicion = 0
  ,@pTamanioVariable = '1N'
  ,@pInactivo = 0
  ,@pUsuario_Id = 1
  ,@pPosteado = 1
  ,@pEsSueldos  = 0
  ,@pEmpiezaEnUno = 0
GO

DECLARE @pSegmento_Id int 
set @pSegmento_Id = dbo.FuncFKgenSegmentos('CICLOABONO')
EXEC genSegmentosNombresGuardar
   @pSegmento_Id 
  ,@pNombre1N = 'Ciclo'
  ,@pNombre2N = ''
  ,@pNombre3N= ''
  ,@pNombre4N= ''
  ,@pNombre1C = 'Sucursal'
  ,@pNombre2C= ''
  ,@pNombre3C= ''
  ,@pNombre4C= ''
  ,@pUsuario_Id=1
GO
