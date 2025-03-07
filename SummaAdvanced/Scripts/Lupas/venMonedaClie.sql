DELETE FROM lupIdentidadesParam WHERE Identidad_Id = dbo.FuncFKlupIdentidades('venMonedaClie')
DELETE FROM lupIdentidadesColVisibles WHERE Identidad_Id = dbo.FuncFKlupIdentidades('venMonedaClie')
DELETE FROM lupIdentidades WHERE Identidad_Id = 'venMonedaClie'
--lupIdentidades
INSERT INTO lupIdentidades(Identidad_Id, Descripcion, CamposSelect, FromSelect, WhereSelect, OrderByDefault, CamposClaves, CampoDescripcion, CampoFKTablaSeg, VistaSeg, CampoPKVistaSeg) VALUES('venMonedaClie', 'Moneda Cliente', 'Moneda_Id,DescripcionMoneda,Cliente_Id', 'vvenClientesCtas', '', 'Moneda_Id', 'Moneda_Id', 'DescripcionMoneda', Null, Null, Null)
--lupIdentidadesColVisibles
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('venMonedaClie'), 'DescripcionMoneda')
INSERT INTO lupIdentidadesColVisibles(Identidad_Id, Campo) VALUES(dbo.FuncFKlupIdentidades('venMonedaClie'), 'Moneda_Id')
