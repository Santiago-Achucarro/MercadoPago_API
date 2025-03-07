
CREATE TABLE disControlesBoton
( 
	Formulario_Id int NOT NULL,
	Control_Id varchar(200) NOT NULL,
	ControlAsociado_Id varchar(200) NULL,
	AsociadoAFilaGrilla bit NULL,
	Icono varchar(40) NULL,
	foreign key (Formulario_Id, ControlAsociado_Id) references discontroles (Formulario_Id,Control_Id),
	CONSTRAINT XPKdisControlesBoton PRIMARY KEY  CLUSTERED (Formulario_Id,Control_Id ASC)
)
go


INSERT INTO genVersion (VErsion) Values(540.05)
GO

