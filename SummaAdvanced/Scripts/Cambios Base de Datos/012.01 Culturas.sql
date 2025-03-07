-------------------------------------------------------------
-- Da error el Update si se lo corre directament. Correrlo --
-- uno a uno ------------------------------------------------
-------------------------------------------------------------
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 12.01)
begin

	INSERT INTO genVersion(Version) Values(12.01);

	CREATE TABLE genCulturas
	( 
		Cultura              varchar(5)  NOT NULL ,
		Descripcion          varchar(50)  NOT NULL ,
		CONSTRAINT XPKgenCulturas PRIMARY KEY  CLUSTERED (Cultura ASC)
	);

	Insert Into genCulturas (Cultura, Descripcion) Values ('es-AR', 'Español Argentina');
	Insert Into genCulturas (Cultura, Descripcion) Values ('es-MX', 'Español México');
	Insert Into genCulturas (Cultura, Descripcion) Values ('en', 'English');
	Insert Into genCulturas (Cultura, Descripcion) Values ('pt', 'Portugues');



	Alter table genUsuarios Add Cultura varchar(5)  NULL;
	Update genUsuarios Set Cultura = 'es-AR' Where TipoUsuario = 'U';

	ALTER TABLE genUsuarios
		ADD CONSTRAINT R_3946 FOREIGN KEY (Cultura) REFERENCES genCulturas(Cultura);

End



