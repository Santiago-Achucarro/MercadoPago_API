Alter table tesIdentifica Add FormaDePagoP VarChar(2)
GO

Update tesidentifica set FormaDePagoP = '03' where TipoCartera = 1
Update tesidentifica set FormaDePagoP = '02' where TipoCartera = 2
Update tesidentifica set FormaDePagoP = '02' where TipoCartera = 3
Update tesidentifica set FormaDePagoP = '03' where TipoCartera = 4
Update tesidentifica set FormaDePagoP = '01' where TipoCartera = 5
Update tesidentifica set FormaDePagoP = '17' where TipoCartera = 6
Update tesidentifica set FormaDePagoP = '01' where TipoCartera = 7
Update tesidentifica set FormaDePagoP = '01' where TipoCartera = 8
Update tesidentifica set FormaDePagoP = '01' where TipoCartera = 9
Update tesidentifica set FormaDePagoP = '01' where TipoCartera = 10
Update tesidentifica set FormaDePagoP = '01' where TipoCartera = 11

go


INSERT INTO genVersion(Version) Values(89.000)
GO