create index idxgencanmovApli on genCancMov  (AsientoApli_id)
GO

create index idxgencanmovdc on genCancMov  (AsieDifCambio_Id )
GO

create index idxgencanmovAp on genCancMov  (Asiento_id_AP)
GO

insert into genVersion(Version) Values(1041.00)
GO


