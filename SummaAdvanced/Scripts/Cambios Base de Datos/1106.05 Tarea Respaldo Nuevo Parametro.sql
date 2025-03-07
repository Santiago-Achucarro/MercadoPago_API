If Exists(Select 1 From genTareas Where Tarea_Id = 'Respaldos')
Begin
    insert into genTareasParametros (Tarea_Id, Parametro, Descripcion, Obligatorio) values (dbo.FuncFKgenTareas('Respaldos'), 'UbicacionGeneracion', 'Carpeta Donde se generaran los Respaldos', 0)
End
GO

INSERT INTO genVersion(Version) Values(1106.05);
GO