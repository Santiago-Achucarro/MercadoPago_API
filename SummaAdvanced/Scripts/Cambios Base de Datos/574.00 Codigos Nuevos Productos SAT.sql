
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) 
	VALUES(3, 'MX', '15101514','Gasolina regular menor a 91 octanos')
INSERT INTO genEntidadesBasicasValor (Entidad_Id, Dominio_Id, Clave, Descripcion) 
	VALUES(3, 'MX', '15101515','Gasolina premium mayor o igual a 91 octanos')

Update genEntidadesBasicasValor set  Descripcion= 'Gas natural'  where Entidad_Id =3 and Dominio_id = 'MX' AND Clave= '15101512'

delete from genEntidadesBasicasValor where  Clave = '15101506' and Entidad_Id = 3 and Dominio_Id = 'MX'
delete from genEntidadesBasicasValor where  Clave = '93151507' and Entidad_Id = 3 and Dominio_Id = 'MX'
GO

INSERT INTO genVersion (Version) Values(574.00)
GO