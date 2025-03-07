Create Table genSemaforo(
	Semaforo varChar(50),
	Empresa_Id Int,
	Primary Key(Empresa_Id, Semaforo)
)
GO
Alter table tesBancos alter column Descripcion VarChar(120)
GO
insert into genVersion (Version) Values(1025.00)
GO
