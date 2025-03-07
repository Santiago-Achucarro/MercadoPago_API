

alter table sueNominaCFDI add FechaCancelacionSAT qFecha NULL
go

alter table sueNominaCFDI add RazonCancelacion varchar(20)
go

update sueNominaCFDI set FechaCancelacionSAT = FechaCancelacion
go

insert into genVersion(Version) Values(1069.03)
GO
