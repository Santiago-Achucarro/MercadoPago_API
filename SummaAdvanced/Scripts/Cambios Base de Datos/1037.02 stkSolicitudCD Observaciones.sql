
alter table stkSolicitudCD add 
Posteado SiNo not null default 1,
Usuario_Id int not null default 1,
Observaciones qMemo not null default '',

Constraint stkSolicitudCDUsuarioFK foreign key (Usuario_Id) references genUsuarios(genUsuarios)

Insert into genVersion (Version) Values (1037.02)
Go
