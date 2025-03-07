
insert into genVersion(Version) values(62.02)
go
delete comSolicitudesSat 


DECLARE @table NVARCHAR(512), @sql NVARCHAR(MAX);

SELECT @table = N'dbo.comSolicitudesSat';

SELECT @sql = 'ALTER TABLE ' + @table 
    + ' DROP CONSTRAINT ' + name + ';'
    FROM sys.key_constraints
    WHERE [type] = 'PK'
    AND [parent_object_id] = OBJECT_ID(@table);

EXEC sp_executeSQL @sql;

alter table comSolicitudesSat drop column Solicitud

alter table comSolicitudesSat add Solicitud int identity
alter table comSolicitudesSat add primary key(Solicitud)
go