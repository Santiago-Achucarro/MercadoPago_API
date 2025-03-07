INSERT INTO genTareas (genTareas,Tarea_Id, Descripcion) 
values(1,'APECAJA','Apertura de Caja')
GO
INSERT INTO genTareasParametros(Tarea_Id,Parametro,Descripcion,Obligatorio)
VALUES(1, 'Sucursal','Sucursal a Aperturar',1)
GO

insert into genVersion (Version) Values(1022.00)
GO


