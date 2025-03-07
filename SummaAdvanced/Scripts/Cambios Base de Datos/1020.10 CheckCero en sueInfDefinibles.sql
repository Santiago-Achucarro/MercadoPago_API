Alter table sueInfDefFormulas add CheckCero Sino Null
Go
Update sueInfDefFormulas Set CheckCero = 0
Go
Alter table sueInfDefFormulas alter column CheckCero Sino Not Null
Go

Insert Into genVersion (Version) Values (1020.10)
Go
