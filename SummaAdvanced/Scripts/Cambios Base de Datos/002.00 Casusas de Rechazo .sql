IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 2.00)
begin


INSERT INTO genVersion (Version) Values(2.00)


CREATE TABLE tesCausasRechazo
( 
	tesCausasRechazo     integer IDENTITY ( 1,1 ) ,
	Causa_Id             varchar(5)  NOT NULL ,
	Descripcion          varchar(150)  NOT NULL ,
	Empresa_Id			 int ,
	Usuario_Id			 Int NOT NULL, 
	FechaModificacion	 DateTime NOT NULL, 
	Posteado			 bit NOT NULL, 
	Inactivo			 Bit NOT NULL, 
	CONSTRAINT XPKtesCausasRechazo PRIMARY KEY  CLUSTERED (tesCausasRechazo ASC)
)



CREATE UNIQUE INDEX  AKtesCausasRechazo on tesCausasRechazo (Causa_Id)
end
GO