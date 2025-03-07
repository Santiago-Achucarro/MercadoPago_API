insert into genVersion (Version) values (60.02)

go
alter TABLE comSolicitudesSat
add UltimaRespuestaSat varchar(100),
 SolicitudSat varchar(max)
go