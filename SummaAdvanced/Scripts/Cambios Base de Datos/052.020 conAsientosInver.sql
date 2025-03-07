insert into genVersion(Version) values(52.02)
CREATE TABLE conAsientosInver
(
    Asiento_Id bigint NOT NULL,
    Asiento_Id_Inver bigint not NULL,
	foreign key (Asiento_Id) references conAsientos(conAsientos),
	foreign key (Asiento_Id_Inver) references conAsientos(conAsientos),
	primary key (Asiento_Id, Asiento_Id_Inver)
);
go
