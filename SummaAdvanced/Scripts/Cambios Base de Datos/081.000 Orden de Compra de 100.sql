INSERT INTO genVersion (Version) VALUES(81.000)
GO
ALTER TABLE venPedidos Alter Column CliOrdenCompra VarChar(100) Not Null
GO