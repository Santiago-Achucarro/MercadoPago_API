


alter table tesCFDICobranza
add FechaCancelacionSAT qFecha null
go

alter table tesCFDICobranza
add RazonCancelacion varchar(20) null
go

update tesCFDICobranza set FechaCancelacionSAT = FechaCancelacion
go

insert into genVersion(Version) Values(1070.30)
GO


