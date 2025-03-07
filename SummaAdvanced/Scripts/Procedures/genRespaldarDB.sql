--declare @pBase varchar(30)='Grupo2BYB'
--declare @pRuta nvarchar(max)=N'F:\SQL\Backup\Grupo2BYB-2021520-14-25-33.bak'
--declare @pNombre nvarchar(max)=N'Grupo2BYB--2021-05-20T21:25:33'
drop Procedure genRespaldarDB
go
create Procedure genRespaldarDB
(
    @pBase varchar(100),
    @pRuta nvarchar(max),
    @pNombre nvarchar(max)
)
as
BACKUP DATABASE @pBase TO  DISK = @pRuta WITH NOFORMAT, NOINIT,  NAME = @pNombre, NOSKIP, REWIND, NOUNLOAD,  STATS = 10
go
