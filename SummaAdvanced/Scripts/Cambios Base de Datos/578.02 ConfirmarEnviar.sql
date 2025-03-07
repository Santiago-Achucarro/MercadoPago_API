alter table genEmpresas add
ConfirmarEnviarPedidos SiNo not null default 0,
ConfirmarEnviarFacturas SiNo not null default 0,
ConfirmarEnviarRecibo SiNo not null default 0,
ConfirmarEnviarOC SiNo not null default 0

go
insert into genVersion (Version) values (578.02)
