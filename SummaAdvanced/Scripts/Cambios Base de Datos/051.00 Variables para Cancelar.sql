INSERT INTO genVersion (Version) VALUES (51.00)

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	select genEmpresas.genEmpresas,  'VENLLAMAPAC','Envia Cancelaciones al SAT', 'N',1,0,'VEN',' ',0,0,NULL, NULL, NULL
	from genEmpresas	


INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	select genEmpresas.genEmpresas,  'CLAVEPRIVATEKEY','Clave Private Key', 'C',50,0,'VEN',' ',0,0,NULL, NULL, NULL
	from genEmpresas	


INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema,  cValor, nValor, SoloLectura, lupIdentidad, WhereF10, fValor)
	select genEmpresas.genEmpresas,  'VENCLAPFXCANC','Clave Pfx Key', 'C',50,0,'VEN',' ',0,0,NULL, NULL, NULL
	from genEmpresas	

GO