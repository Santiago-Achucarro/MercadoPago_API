ALTER TABLE genInstalacion Add LongitudClave int
ALTER TABLE genInstalacion Add DiasDuracionClave int
ALTER TABLE genInstalacion Add LoginGracia int
ALTER TABLE genInstalacion Add CantIntentosFallidos int
ALTER TABLE genInstalacion Add ClaveSimbolos bit
ALTER TABLE genInstalacion Add ClaveNumero bit
ALTER TABLE genInstalacion Add ClaveMayuscula bit
ALTER TABLE genInstalacion Add ClaveMinuscula bit
ALTER TABLE genInstalacion Add ClaveComunes bit
GO


CREATE TABLE genClavesComunes
(
	Clave VarChar(50) NOT NULL, 
	Primary key(Clave)
)

GO

insert into genClavesComunes Values('password')
insert into genClavesComunes Values('123456')
insert into genClavesComunes Values('12345678')
insert into genClavesComunes Values('abc123')
insert into genClavesComunes Values('qwerty')
insert into genClavesComunes Values('monkey')
insert into genClavesComunes Values('letmein')
insert into genClavesComunes Values('dragon')
insert into genClavesComunes Values('111111')
insert into genClavesComunes Values('baseball')
insert into genClavesComunes Values('iloveyou')
insert into genClavesComunes Values('trustno1')
insert into genClavesComunes Values('1234567')
insert into genClavesComunes Values('sunshine')
insert into genClavesComunes Values('master')
insert into genClavesComunes Values('123123')
insert into genClavesComunes Values('welcome')
insert into genClavesComunes Values('shadow')
insert into genClavesComunes Values('ashley')
insert into genClavesComunes Values('football')
insert into genClavesComunes Values('futbol')
insert into genClavesComunes Values('jesus')
insert into genClavesComunes Values('michael')
insert into genClavesComunes Values('ninja')
insert into genClavesComunes Values('mustang')
insert into genClavesComunes Values('password1')
insert into genClavesComunes Values('1234567890')
insert into genClavesComunes Values('1qaz2wsx')
insert into genClavesComunes Values('login')
insert into genClavesComunes Values('clave')
insert into genClavesComunes Values('qwertyuiop')
insert into genClavesComunes Values('passw0rd')
insert into genClavesComunes Values('starwars')
insert into genClavesComunes Values('solo')

GO

INSERT INTO genVersion(Version) Values(80.000)
GO
