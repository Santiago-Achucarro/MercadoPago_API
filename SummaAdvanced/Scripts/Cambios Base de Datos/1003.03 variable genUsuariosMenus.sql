IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 1003.03)
begin

insert into genGlobales VALUES(1,'GENCLIENTESMENU', 'Menu de Clientes','M',2048,0,null,null,null,/**/null,'GEN',1,null,null)

INSERT INTO genVersion (Version) Values(1003.03)
end
GO