Insert into genSegmentoOrigenes (oriSeg_Id, Descripcion) 	values(13,'Año Sueldos')
Insert into genSegmentoOrigenes (oriSeg_Id, Descripcion) 	values(14,'Mes Sueldos')
Insert into genSegmentoOrigenes (oriSeg_Id, Descripcion) 	values(15,'Quincena Sueldos')
Insert into genSegmentoOrigenes (oriSeg_Id, Descripcion) 	values(16,'Semana Sueldos')
Insert into genSegmentoOrigenes (oriSeg_Id, Descripcion) 	values(17,'Decena Sueldos')
Insert into genSegmentoOrigenes (oriSeg_Id, Descripcion) 	values(18,'Vez Sueldos')
GO

insert into comNivelesAuto (NivelAuto_Id, Descripcion, Inactivo, Posteado, Usuario_Id) Values('LI','Descripcion', 0,1, 1)
GO

exec genSegmentosGuardar  'SLIQ', 'SLIQ', 'Nomina' , 4,2,3,5, 0, 0,0,0,0,1,13,14,15,18,0,0,0,
	0,1,2,3,4,0,0,0,0, '4N',0,1,1
	go
	DECLARE @pSegmento_Id VarChar(25)
	
SET @pSegmento_Id = DBO.FuncFkgenSegmentos('SLIQ')
exec genSegmentosNombresGuardar   @pSegmento_Id,  'Anio','Mes','Quin','Vez', ' ',' ',' ',' ', 1

go


Alter table genSegmentos Add EsSueldos SiNo NULL DEFAULT 0 
GO
UPDATE genSegmentos set EsSueldos = case when Segmento_Id='SLIQ' THEN 1 ELSE 0 END
GO
Alter table genSegmentos ALTER Column EsSueldos SiNo NOT NULL 
GO

declare @SQL VarChar(1000)
SELECT @SQL = 'ALTER TABLE '+sp.name+' DROP Constraint '+sh.name from sysobjects sh , sysobjects sp  where sh.Type = 'K' and
sp.id = sh.parent_obj AND sp.name = 'sueTabla'

EXEC(@SQL)
GO

ALTER TABLE sueTabla add Primary Key(Tabla_Id, Fila)
GO



INSERT INTO genVersion (Version) VALUES(528.000)
GO
