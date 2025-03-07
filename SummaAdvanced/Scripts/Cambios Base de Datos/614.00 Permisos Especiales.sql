
Create Table genPermisosEsp(
	Permiso_Id INT NOT NULL,
	Descripcion VarChar(100) NOT NULL,
	Primary Key(Permiso_Id)
)
GO

Create Table genUsuarioPermisosEsp(
	Usuario_Id Int NOT NULL, 
	Permiso_Id Int NOT NULL,
	Primary Key(Usuario_Id,Permiso_Id)
)
GO

Alter Table genUsuarioPermisosEsp add Constraint fkgenUsuarioPermisosEspUsu
Foreign Key (Usuario_Id) References genUsuarios
GO

Alter Table genUsuarioPermisosEsp add Constraint fkgenUsuarioPermisosEspPer
Foreign Key (Permiso_Id) References genPermisosEsp
GO

INSERT INTO genPermisosEsp (Permiso_Id, Descripcion) Values(1, 'Autoriza Punto de Venta')
INSERT INTO genPermisosEsp (Permiso_Id, Descripcion) Values(2, 'Modifica Condicion Fiscal')
INSERT INTO genPermisosEsp (Permiso_Id, Descripcion) Values(3, 'Autoriza Recepcion Parcial')
GO

INSERT INTO genVersion (Version) Values(614.00)
GO



