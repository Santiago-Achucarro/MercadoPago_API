Alter table stkRemitos add FormaEntrega_Id Int
GO

Alter table stkRemitos add Constraint fkstkRemitosFE 
FOREIGN KEY (FormaEntrega_Id) References venFormaEntrega
GO

Alter table stkHojaDeRuta Add Estado Char(1) 
GO
update stkHojaDeRuta set Estado = 'A' WHERE Estado IS NULL
GO

Alter table stkHojaDeRuta Alter Column Estado Char(1)  NOT NULL
GO

INSERT INTO genVersion (Version) Values(607.00)
GO