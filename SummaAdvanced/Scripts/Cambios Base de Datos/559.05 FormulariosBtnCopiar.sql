
alter table disformularios add BotonCopiar SiNo not null default 1
GO

INSERT INTO genVersion (Version) Values(559.05)
GO

--Actualizo los formularios que no tienen botones para actualizar para que por defecto no muestren el boton de copiar
Update disFormularios 
Set BotonCopiar = 0
Where (BotonGuardar=0) and (BotonPostear=0)
 

--Tengo que ejecutar este sp, para que se creen los temporales, y no de error despues los sp que utilizan los temporales
exec TempdisDisenioCopiarActual
GO
