CREATE TABLE genControlesSeteos(
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	Orden int NOT NULL,
	Valor Varchar(80),
	ModificoValor Sino NOT NULL,
	Deshabilitar SiNo NOT NULL,
	Ocultar SiNo NOT NULL,
	SeteadoPorSistema SiNo NOT NULL,
	Usuario_Id int NOT NULL,
	FechaUltModif Datetime NOT NULL,
    CONSTRAINT XPKgenControlesSeteos PRIMARY KEY (Formulario_Id, Control_Id)
)
GO
CREATE UNIQUE INDEX XAK1genControlesSeteos ON genControlesSeteos (Formulario_Id, Orden)
GO
ALTER TABLE genControlesSeteos ADD CONSTRAINT fkformulario_genControlesSeteos FOREIGN KEY (Formulario_Id) REFERENCES disFormularios (disFormularios)
GO
ALTER TABLE genControlesSeteos ADD CONSTRAINT fkusuario_genControlesSeteos FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios (genUsuarios)
GO

insert into genVersion (Version) Values(1055.05)
GO
