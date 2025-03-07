
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 42.06)
begin

	INSERT INTO genVersion(Version) Values(42.06);

	CREATE TABLE genVersionEmpresas
	( 
		Version              int  NOT NULL ,
		Fecha         datetime  default getdate() NOT NULL ,
		 PRIMARY KEY   (Version)
	);

End


