Alter table stkMoviProv Alter column RemitoProv varChar(50) Not Null
Go
Drop index XAK1stkMoviProv On stkMoviProv
Go

Insert Into genVersion (Version) Values (600.10)
Go
