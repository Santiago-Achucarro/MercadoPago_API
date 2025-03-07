CREATE TABLE venPediEstados(
	Estado_Id Char(1) NOT NULL, 
	Descripcion VarChar(120) NOT NULL,
	Primary Key(Estado_Id))

GO

Insert into venPediEstados(Estado_Id, Descripcion) VALUES('A','Pendiente de Facturar Anticipo')  
--Insert into venPediEstados(Estado_Id, Descripcion) VALUES('B','Para autorizar Bonificación')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('C','Validacion Comercial')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('F','Facturado')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('N','Anulado')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('P','Pendiente')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('R','Rechazado por Validación Comercial')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('T','Terminado')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('Z','Rechazado')
Insert into venPediEstados(Estado_Id, Descripcion) VALUES('E','Entregado')

GO

--SELECT * FROM venPedidos where Estado NOT IN (SELECT Estado_Id from venPediEstados)

Alter table venPedidos Add Constraint fkvenPediEstados 
FOREIGN KEY (Estado) REFERENCES venPediEstados
GO

INSERT INTO genVersion(Version) Values(1093.00)
GO