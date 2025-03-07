
CREATE TABLE disControlesLink
( 
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	Link varchar(25) NULL,
	foreign key (Formulario_Id, Control_Id) references discontroles (Formulario_Id,Control_Id),
	CONSTRAINT XPKdisControlesLink PRIMARY KEY  CLUSTERED (Formulario_Id,Control_Id ASC)
)
go


INSERT INTO genVersion (VErsion) Values(542.05)
GO
